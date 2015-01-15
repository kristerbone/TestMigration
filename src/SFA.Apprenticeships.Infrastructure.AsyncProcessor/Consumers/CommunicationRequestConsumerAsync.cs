﻿namespace SFA.Apprenticeships.Infrastructure.AsyncProcessor.Consumers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Application.Interfaces.Messaging;
    using EasyNetQ.AutoSubscribe;
    using Domain.Interfaces.Messaging;
    using Domain.Interfaces.Repositories;

    public class CommunicationRequestConsumerAsync : IConsumeAsync<CommunicationRequest>
    {
        private readonly ICandidateReadRepository _candidateReadRepository;
        private readonly IMessageBus _messageBus;

        public CommunicationRequestConsumerAsync(ICandidateReadRepository candidateReadRepository, IMessageBus messageBus)
        {
            _candidateReadRepository = candidateReadRepository;
            _messageBus = messageBus;
        }

        public Task Consume(CommunicationRequest message)
        {
            return Task.Run(() =>
            {
                // note, for now only candidate messages are being sent so assume entity ID is candidate ID
                var candidateId = message.EntityId;

                // note, some messages are mandatory - determined by type
                var isOptional = message.MessageType == MessageTypes.TraineeshipApplicationSubmitted ||
                                  message.MessageType == MessageTypes.ApprenticeshipApplicationSubmitted;

                var candidate = _candidateReadRepository.Get(candidateId);

                if (!isOptional || candidate.CommunicationPreferences.AllowEmail)
                {
                    SendEmailMessage(message);
                }

                if (!isOptional || candidate.CommunicationPreferences.AllowMobile)
                {
                    SendSmsMessage(message);
                }

                //todo: future work: write to communication repository
            });
        }

        private void SendEmailMessage(CommunicationRequest message)
        {
            var toEmail = message.Tokens.First(t => t.Key == CommunicationTokens.CandidateEmailAddress).Value;
            var request = new EmailRequest
            {
                ToEmail = toEmail,
                MessageType = message.MessageType,
                Tokens = GetMessageTokens(message),
            };

            _messageBus.PublishMessage(request);
        }

        private void SendSmsMessage(CommunicationRequest message)
        {
            var toMobile = message.Tokens.First(t => t.Key == CommunicationTokens.CandidateMobileNumber).Value;
            var request = new SmsRequest
            {
                ToNumber = toMobile,
                MessageType = message.MessageType,
                Tokens = GetMessageTokens(message),
            };

            _messageBus.PublishMessage(request);
        }

        private static IEnumerable<KeyValuePair<CommunicationTokens, string>> GetMessageTokens(
            CommunicationRequest message)
        {
            return
                message.Tokens.Where(
                    t =>
                        t.Key != CommunicationTokens.CandidateEmailAddress &&
                        t.Key != CommunicationTokens.CandidateMobileNumber);
        } 
    }
}