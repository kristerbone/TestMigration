﻿namespace SFA.Apprenticeships.Infrastructure.Elastic.Common.Entities
{
    using System;
    using Nest;

    [ElasticType(Name = "apprenticeship")]
    public class ApprenticeshipSummary : IVacancySummary
    {
        [ElasticProperty(Index = FieldIndexOption.NotAnalyzed)]
        public int Id { get; set; }

        [ElasticProperty(Index = FieldIndexOption.Analyzed, Analyzer = "snowball")]
        public string Title { get; set; }

        [ElasticProperty(Index = FieldIndexOption.NotAnalyzed)]
        public DateTime StartDate { get; set; }

        [ElasticProperty(Index = FieldIndexOption.NotAnalyzed)]
        public DateTime ClosingDate { get; set; }

        [ElasticProperty(Index = FieldIndexOption.Analyzed)]
        public string EmployerName { get; set; }

        [ElasticProperty(Index = FieldIndexOption.Analyzed, Analyzer = "snowball")]
        public string Description { get; set; }

        [ElasticProperty(Index = FieldIndexOption.Analyzed)]
        public VacancyLocationType VacancyLocationType { get; set; }

        [ElasticProperty(Type = FieldType.GeoPoint, Index = FieldIndexOption.Analyzed)]
        public GeoPoint Location { get; set; }
    }
}