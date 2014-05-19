﻿namespace SFA.Apprenticeships.Common.Messaging.IntegrationTests.DependencyResolution
{
    using SFA.Apprenticeships.Common.Messaging.IntegrationTests.Consumers;
    using StructureMap.Configuration.DSL;

    public class TestRegistry : Registry
    {
        public TestRegistry()
        {
            For<TestConsumerAsync>().Use<TestConsumerAsync>();
            For<TestConsumerSync>().Use<TestConsumerSync>();
        }
    }
}
