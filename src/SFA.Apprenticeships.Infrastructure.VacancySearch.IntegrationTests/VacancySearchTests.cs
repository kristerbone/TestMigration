﻿namespace SFA.Apprenticeships.Infrastructure.VacancySearch.IntegrationTests
{
    using Application.Interfaces.Search;
    using Application.Interfaces.Vacancies;
    using Configuration;
    using Domain.Entities.Locations;
    using Domain.Entities.Vacancies.Apprenticeships;
    using Domain.Interfaces.Mapping;
    using Elastic.Common.Configuration;
    using Elastic.Common.IoC;
    using FluentAssertions;
    using IoC;
    using NUnit.Framework;
    using StructureMap;

    [TestFixture]
    public class VacancySearchTests
    {
        private const string RetailAndCommercialEnterprise = "MFP"; //"HBY"; //"Retail and Commercial Enterprise";
        private IElasticsearchClientFactory _elasticsearchClientFactory;
        private IMapper _mapper;

        [TestFixtureSetUp]
        public void FixtureSetUp()
        {
#pragma warning disable 0618
            // TODO: AG: CRITICAL: NuGet package update on 2014-10-30.
            ObjectFactory.Initialize(x =>
            {
                x.AddRegistry<ElasticsearchCommonRegistry>();
                x.AddRegistry<VacancySearchRegistry>();
            });

            _elasticsearchClientFactory = ObjectFactory.GetInstance<IElasticsearchClientFactory>();
            // TODO: AG: CRITICAL: NuGet package update on 2014-10-30.
            _mapper = ObjectFactory.GetInstance<IMapper>();
#pragma warning restore 0618
        }

        [Test]
        public void ShouldReturnFrameworksCount()
        {

            var vacancySearchProvider = new ApprenticeshipsSearchProvider(_elasticsearchClientFactory, _mapper,
                SearchConfiguration.Instance);

            var vacancies = vacancySearchProvider.FindVacancies(GetCommonSearchParameters());

            vacancies.AggregationResults.Should().HaveCount(c => c > 0);
        }

        [Test]
        public void ShouldSearchBySector()
        {

            var vacancySearchProvider = new ApprenticeshipsSearchProvider(_elasticsearchClientFactory, _mapper,
                SearchConfiguration.Instance);

            var searchParameters = GetCommonSearchParameters();
            searchParameters.Sector = RetailAndCommercialEnterprise;

            var vacancies = vacancySearchProvider.FindVacancies(searchParameters);

            vacancies.AggregationResults.Should().HaveCount(c => c > 0);
        }

        [Test]
        public void ShouldSearchBySectorAndFramework()
        {

            var vacancySearchProvider = new ApprenticeshipsSearchProvider(_elasticsearchClientFactory, _mapper,
                SearchConfiguration.Instance);

            var searchParameters = GetCommonSearchParameters();
            searchParameters.Sector = RetailAndCommercialEnterprise;
            searchParameters.Frameworks = new[] {"582"};

            var vacancies = vacancySearchProvider.FindVacancies(searchParameters);

            vacancies.AggregationResults.Should().HaveCount(1);
        }

        private static ApprenticeshipSearchParameters GetCommonSearchParameters()
        {
            return new ApprenticeshipSearchParameters
            {
                ApprenticeshipLevel = "Intermediate",
                Location = new Location
                {
                    Name = "London",
                    GeoPoint = new GeoPoint
                    {
                        Latitude = 51.5072,
                        Longitude = 0.1275
                    }
                },
                PageNumber = 1,
                PageSize = 5,
                SearchRadius = 5,
                SortType = VacancySortType.ClosingDate,
                VacancyLocationType = ApprenticeshipLocationType.NonNational
            };
        }
    }
}