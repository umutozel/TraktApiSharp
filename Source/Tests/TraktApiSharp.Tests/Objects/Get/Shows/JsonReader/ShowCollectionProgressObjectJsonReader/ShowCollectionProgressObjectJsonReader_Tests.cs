﻿namespace TraktApiSharp.Tests.Objects.Get.Shows.JsonReader
{
    using FluentAssertions;
    using Traits;
    using TraktApiSharp.Objects.Get.Shows;
    using TraktApiSharp.Objects.Get.Shows.JsonReader;
    using TraktApiSharp.Objects.JsonReader;
    using Xunit;

    [Category("Objects.Get.Shows.JsonReader")]
    public partial class ShowCollectionProgressObjectJsonReader_Tests
    {
        [Fact]
        public void Test_ShowCollectionProgressObjectJsonReader_Implements_IObjectJsonReader_Interface()
        {
            typeof(ShowCollectionProgressObjectJsonReader).GetInterfaces().Should().Contain(typeof(IObjectJsonReader<ITraktShowCollectionProgress>));
        }
    }
}
