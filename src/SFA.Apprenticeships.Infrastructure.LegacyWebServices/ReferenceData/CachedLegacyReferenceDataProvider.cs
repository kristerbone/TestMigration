﻿namespace SFA.Apprenticeships.Infrastructure.LegacyWebServices.ReferenceData
{
    using System.Collections.Generic;
    using Application.Interfaces.ReferenceData;
    using Application.ReferenceData;
    using Domain.Entities.ReferenceData;
    using Domain.Interfaces.Caching;

    public class CachedLegacyReferenceDataProvider : IReferenceDataProvider
    {
        private static readonly BaseCacheKey CacheKey = new ReferenceDataServiceCacheKeyEntry();
        private readonly ICacheService _cache;
        private readonly IReferenceDataProvider _referenceDataProvider;

        public CachedLegacyReferenceDataProvider(ICacheService cache, IReferenceDataProvider referenceDataProvider)
        {
            _cache = cache;
            _referenceDataProvider = referenceDataProvider;
        }

        public IEnumerable<ReferenceDataItem> GetReferenceData(string type)
        {
            return _cache.Get(CacheKey, _referenceDataProvider.GetReferenceData, type);
        }
    }
}