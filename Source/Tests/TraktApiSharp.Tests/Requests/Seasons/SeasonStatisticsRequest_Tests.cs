﻿namespace TraktApiSharp.Tests.Requests.Seasons
{
    using FluentAssertions;
    using System;
    using System.Collections.Generic;
    using Traits;
    using TraktApiSharp.Objects.Basic;
    using TraktApiSharp.Requests.Seasons;
    using Xunit;

    [Category("Requests.Seasons")]
    public class SeasonStatisticsRequest_Tests
    {
        [Fact]
        public void Test_SeasonStatisticsRequest_IsNotAbstract()
        {
            typeof(SeasonStatisticsRequest).IsAbstract.Should().BeFalse();
        }

        [Fact]
        public void Test_SeasonStatisticsRequest_IsSealed()
        {
            typeof(SeasonStatisticsRequest).IsSealed.Should().BeTrue();
        }

        [Fact]
        public void Test_SeasonStatisticsRequest_Inherits_ASeasonRequest_1()
        {
            typeof(SeasonStatisticsRequest).IsSubclassOf(typeof(ASeasonRequest<ITraktStatistics>)).Should().BeTrue();
        }

        [Fact]
        public void Test_SeasonStatisticsRequest_Has_Valid_UriTemplate()
        {
            var request = new SeasonStatisticsRequest();
            request.UriTemplate.Should().Be("shows/{id}/seasons/{season}/stats");
        }

        [Fact]
        public void Test_SeasonStatisticsRequest_Returns_Valid_UriPathParameters()
        {
            // with implicit season number
            var request = new SeasonStatisticsRequest { Id = "123" };

            request.GetUriPathParameters().Should().NotBeNull()
                                                   .And.HaveCount(2)
                                                   .And.Contain(new Dictionary<string, object>
                                                   {
                                                       ["id"] = "123",
                                                       ["season"] = "0"
                                                   });

            // with explicit season number
            request = new SeasonStatisticsRequest { Id = "123", SeasonNumber = 2 };

            request.GetUriPathParameters().Should().NotBeNull()
                                                   .And.HaveCount(2)
                                                   .And.Contain(new Dictionary<string, object>
                                                   {
                                                       ["id"] = "123",
                                                       ["season"] = "2"
                                                   });
        }

        [Fact]
        public void Test_SeasonStatisticsRequest_Validate_Throws_Exceptions()
        {
            // id is null
            var request = new SeasonStatisticsRequest();

            Action act = () => request.Validate();
            act.ShouldThrow<ArgumentNullException>();

            // empty id
            request = new SeasonStatisticsRequest { Id = string.Empty };

            act = () => request.Validate();
            act.ShouldThrow<ArgumentException>();

            // id with spaces
            request = new SeasonStatisticsRequest { Id = "invalid id" };

            act = () => request.Validate();
            act.ShouldThrow<ArgumentException>();
        }
    }
}
