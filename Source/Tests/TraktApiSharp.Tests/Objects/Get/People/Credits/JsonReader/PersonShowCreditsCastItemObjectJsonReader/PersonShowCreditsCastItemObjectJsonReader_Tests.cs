﻿namespace TraktApiSharp.Tests.Objects.Get.People.Credits.JsonReader
{
    using FluentAssertions;
    using Traits;
    using TraktApiSharp.Objects.Get.People.Credits;
    using TraktApiSharp.Objects.Get.People.Credits.JsonReader;
    using TraktApiSharp.Objects.JsonReader;
    using Xunit;

    [Category("Objects.Get.People.Credits.JsonReader")]
    public partial class PersonShowCreditsCastItemObjectJsonReader_Tests
    {
        [Fact]
        public void Test_PersonShowCreditsCastItemObjectJsonReader_Implements_IObjectJsonReader_Interface()
        {
            typeof(PersonShowCreditsCastItemObjectJsonReader).GetInterfaces().Should().Contain(typeof(IObjectJsonReader<ITraktPersonShowCreditsCastItem>));
        }
    }
}
