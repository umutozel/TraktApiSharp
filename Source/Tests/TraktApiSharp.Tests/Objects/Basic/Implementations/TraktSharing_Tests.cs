﻿namespace TraktApiSharp.Tests.Objects.Basic.Implementations
{
    using FluentAssertions;
    using System.Threading.Tasks;
    using Traits;
    using TraktApiSharp.Objects.Basic;
    using TraktApiSharp.Objects.Basic.Implementations;
    using TraktApiSharp.Objects.Basic.JsonReader;
    using Xunit;

    [Category("Objects.Basic.Implementations")]
    public class TraktSharing_Tests
    {
        [Fact]
        public void Test_TraktSharing_Implements_ITraktSharing_Interface()
        {
            typeof(TraktSharing).GetInterfaces().Should().Contain(typeof(ITraktSharing));
        }

        [Fact]
        public void Test_TraktSharing_Default_Constructor()
        {
            var traktSharing = new TraktSharing();

            traktSharing.Facebook.Should().BeNull();
            traktSharing.Twitter.Should().BeNull();
            traktSharing.Google.Should().BeNull();
            traktSharing.Tumblr.Should().BeNull();
            traktSharing.Medium.Should().BeNull();
            traktSharing.Slack.Should().BeNull();
        }

        [Fact]
        public async Task Test_TraktSharing_From_Json()
        {
            var jsonReader = new SharingObjectJsonReader();
            var traktSharing = await jsonReader.ReadObjectAsync(JSON) as TraktSharing;

            traktSharing.Should().NotBeNull();
            traktSharing.Facebook.Should().BeTrue();
            traktSharing.Twitter.Should().BeTrue();
            traktSharing.Google.Should().BeTrue();
            traktSharing.Tumblr.Should().BeTrue();
            traktSharing.Medium.Should().BeTrue();
            traktSharing.Slack.Should().BeTrue();
        }

        private const string JSON =
            @"{
                ""facebook"": true,
                ""twitter"": true,
                ""google"": true,
                ""tumblr"": true,
                ""medium"": true,
                ""slack"": true
              }";
    }
}
