﻿namespace SFA.Apprenticeships.Infrastructure.Communication.Sms.SmsMessageFormatters
{
    using System.Collections.Generic;
    using System.Linq;
    using Application.Interfaces.Communications;

    public class SmsTraineeshipApplicationSubmittedMessageFormatter : SmsMessageFormatter
    {
        public SmsTraineeshipApplicationSubmittedMessageFormatter(ITwillioConfiguration configuration)
            : base(configuration)
        {
            Message = GetTemplateConfiguration("MessageTypes.TraineeshipApplicationSubmitted").Message;
        }

        public override string GetMessage(IEnumerable<CommunicationToken> communicationTokens)
        {
            return string.Format(Message, communicationTokens.First(ct => ct.Key == CommunicationTokens.ApplicationVacancyReference).Value);
        }
    }
}