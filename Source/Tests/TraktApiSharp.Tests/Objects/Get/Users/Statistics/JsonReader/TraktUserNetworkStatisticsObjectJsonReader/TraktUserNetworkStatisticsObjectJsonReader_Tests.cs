﻿namespace TraktApiSharp.Tests.Objects.Get.Users.Statistics.JsonReader
{
    using FluentAssertions;
    using Traits;
    using TraktApiSharp.Objects.Get.Users.Statistics;
    using TraktApiSharp.Objects.Get.Users.Statistics.JsonReader;
    using TraktApiSharp.Objects.JsonReader;
    using Xunit;

    [Category("Objects.Get.Users.Statistics.JsonReader")]
    public partial class TraktUserNetworkStatisticsObjectJsonReader_Tests
    {
        [Fact]
        public void Test_TraktUserNetworkStatisticsObjectJsonReader_Implements_ITraktObjectJsonReader_Interface()
        {
            typeof(TraktUserNetworkStatisticsObjectJsonReader).GetInterfaces().Should().Contain(typeof(ITraktObjectJsonReader<ITraktUserNetworkStatistics>));
        }
    }
}
