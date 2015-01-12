﻿namespace SFA.Apprenticeships.Web.Candidate.UnitTests.Mediators.ApprenticeshipSearch
{
    using System;
    using Candidate.Mediators;
    using Candidate.ViewModels.VacancySearch;
    using Common.Constants;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class DetailsTests : TestsBase
    {
        private const int Id = 1;
        private Mock<IUserDataProvider> _userDataProvider;
        private const string VacancyDistance = "10";

        [Test]
        public void VacancyNotFound()
        {
            var response = Mediator.Details(Id, null, null);

            response.AssertCode(Codes.ApprenticeshipSearch.Details.VacancyNotFound, false);
        }

        [Test]
        public void VacancyHasError()
        {
            const string message = "The vacancy has an error";
            
            var vacancyDetailViewModel = new VacancyDetailViewModel {ViewModelMessage = message};
            ApprenticeshipVacancyDetailProvider.Setup(p => p.GetVacancyDetailViewModel(It.IsAny<Guid?>(), It.IsAny<int>())).Returns(vacancyDetailViewModel);
            
            var response = Mediator.Details(Id, null, null);

            response.AssertMessage(Codes.ApprenticeshipSearch.Details.VacancyHasError, message, UserMessageLevel.Warning, true);
        }

        [Test]
        public void Ok()
        {
            var vacancyDetailViewModel = new VacancyDetailViewModel();
            ApprenticeshipVacancyDetailProvider.Setup(p => p.GetVacancyDetailViewModel(It.IsAny<Guid?>(), It.IsAny<int>())).Returns(vacancyDetailViewModel);

            var response = Mediator.Details(Id, null, null);

            response.AssertCode(Codes.ApprenticeshipSearch.Details.Ok, true);
        }
        [Test]
        public void PopulateDistance()
        {
            var vacancyDetailViewModel = new VacancyDetailViewModel();
            var mediator = GetMediator(vacancyDetailViewModel);

            _userDataProvider.Setup(udp => udp.Pop(UserDataItemNames.VacancyDistance)).Returns(VacancyDistance);
            _userDataProvider.Setup(udp => udp.Pop(UserDataItemNames.LastViewedVacancyId)).Returns(Convert.ToString(Id));

            var response = mediator.Details(Id, null, null);

            response.AssertCode(Codes.ApprenticeshipSearch.Details.Ok, true);
        }

        private IApprenticeshipSearchMediator GetMediator(VacancyDetailViewModel vacancyDetailViewModel)
        {
            var configurationManager = new Mock<IConfigurationManager>();
            var searchProvider = new Mock<ISearchProvider>();
            var apprenticeshipVacancyDetailProvider = new Mock<IApprenticeshipVacancyDetailProvider>();
            apprenticeshipVacancyDetailProvider.Setup(p => p.GetVacancyDetailViewModel(It.IsAny<Guid?>(), It.IsAny<int>())).Returns(vacancyDetailViewModel);
            _userDataProvider = new Mock<IUserDataProvider>();
            var mediator = GetMediator(configurationManager.Object, searchProvider.Object, apprenticeshipVacancyDetailProvider.Object, _userDataProvider.Object);
            return mediator;
        }
    }
}