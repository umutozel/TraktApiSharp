﻿namespace TraktApiSharp.Tests.Requests.Shows
{
    using FluentAssertions;
    using System;
    using System.Collections.Generic;
    using Traits;
    using TraktApiSharp.Objects.Get.Episodes;
    using TraktApiSharp.Requests.Interfaces;
    using TraktApiSharp.Requests.Parameters;
    using TraktApiSharp.Requests.Shows;
    using Xunit;

    [Category("Requests.Shows")]
    public class ShowLastEpisodeRequest_Tests
    {
        [Fact]
        public void Test_ShowLastEpisodeRequest_Is_Not_Abstract()
        {
            typeof(ShowLastEpisodeRequest).IsAbstract.Should().BeFalse();
        }

        [Fact]
        public void Test_ShowLastEpisodeRequest_Is_Sealed()
        {
            typeof(ShowLastEpisodeRequest).IsSealed.Should().BeTrue();
        }

        [Fact]
        public void Test_ShowLastEpisodeRequest_Inherits_AShowRequest_1()
        {
            typeof(ShowLastEpisodeRequest).IsSubclassOf(typeof(AShowRequest<ITraktEpisode>)).Should().BeTrue();
        }

        [Fact]
        public void Test_ShowLastEpisodeRequest_Implements_ISupportsExtendedInfo_Interface()
        {
            typeof(ShowLastEpisodeRequest).GetInterfaces().Should().Contain(typeof(ISupportsExtendedInfo));
        }

        [Fact]
        public void Test_ShowLastEpisodeRequest_Has_Valid_UriTemplate()
        {
            var request = new ShowLastEpisodeRequest();
            request.UriTemplate.Should().Be("shows/{id}/last_episode{?extended}");
        }

        [Fact]
        public void Test_ShowLastEpisodeRequest_Returns_Valid_UriPathParameters()
        {
            // without extended info
            var request = new ShowLastEpisodeRequest { Id = "123" };

            request.GetUriPathParameters().Should().NotBeNull()
                                                   .And.HaveCount(1)
                                                   .And.Contain(new Dictionary<string, object>
                                                   {
                                                       ["id"] = "123"
                                                   });

            // with extended info
            var extendedInfo = new TraktExtendedInfo { Full = true };
            request = new ShowLastEpisodeRequest { Id = "123", ExtendedInfo = extendedInfo };

            request.GetUriPathParameters().Should().NotBeNull()
                                                   .And.HaveCount(2)
                                                   .And.Contain(new Dictionary<string, object>
                                                   {
                                                       ["id"] = "123",
                                                       ["extended"] = extendedInfo.ToString()
                                                   });
        }

        [Fact]
        public void Test_ShowLastEpisodeRequest_Validate_Throws_Exceptions()
        {
            // id is null
            var request = new ShowLastEpisodeRequest();

            Action act = () => request.Validate();
            act.ShouldThrow<ArgumentNullException>();

            // empty id
            request = new ShowLastEpisodeRequest { Id = string.Empty };

            act = () => request.Validate();
            act.ShouldThrow<ArgumentException>();

            // id with spaces
            request = new ShowLastEpisodeRequest { Id = "invalid id" };
            act.ShouldThrow<ArgumentException>();
        }
    }
}
