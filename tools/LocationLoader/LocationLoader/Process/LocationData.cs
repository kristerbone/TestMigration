﻿using System;
using Nest;

namespace LocationLoader.Process
{
    /// <summary>
    /// DTO for mapping elasticsearch index to
    /// </summary>
    internal class LocationData
    {
        [ElasticProperty(Name = "name", Type = FieldType.string_type, Store = true, Index = FieldIndexOption.analyzed)]
        public string Name { get; set; }

        [ElasticProperty(Name = "county", Type = FieldType.string_type, Store = true, Index = FieldIndexOption.analyzed)]
        public string County { get; set; }

        [ElasticProperty(Name = "country", Type = FieldType.string_type, Store = true, Index = FieldIndexOption.not_analyzed)]
        public string Country { get; set; }

        [ElasticProperty(Name = "longitude", Type = FieldType.double_type, Store = true, Index = FieldIndexOption.not_analyzed)]
        public double Longitude { get; set; }

        [ElasticProperty(Name = "latitude", Type = FieldType.double_type, Store = true, Index = FieldIndexOption.not_analyzed)]
        public double Latitude { get; set; }

        [ElasticProperty(Name = "postcode", Type = FieldType.string_type, Store = true, Index = FieldIndexOption.analyzed)]
        public string Postcode { get; set; }
    }
}
