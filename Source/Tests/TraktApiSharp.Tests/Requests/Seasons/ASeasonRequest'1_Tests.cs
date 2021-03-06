﻿namespace TraktApiSharp.Tests.Requests.Seasons
{
    using FluentAssertions;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Traits;
    using TraktApiSharp.Requests.Base;
    using TraktApiSharp.Requests.Interfaces;
    using TraktApiSharp.Requests.Seasons;
    using Xunit;

    [Category("Requests.Seasons")]
    public class ASeasonRequest_1_Tests
    {
        internal class SeasonRequestMock : ASeasonRequest<int>
        {
            public override string UriTemplate { get { throw new NotImplementedException(); } }
        }

        [Fact]
        public void Test_ASeasonRequest_1_IsAbstract()
        {
            typeof(ASeasonRequest<>).IsAbstract.Should().BeTrue();
        }

        [Fact]
        public void Test_ASeasonRequest_1_Has_GenericTypeParameter()
        {
            typeof(ASeasonRequest<>).ContainsGenericParameters.Should().BeTrue();
            typeof(ASeasonRequest<int>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(1);
        }

        [Fact]
        public void Test_ASeasonRequest_1_Inherits_AGetRequest_1()
        {
            typeof(ASeasonRequest<int>).IsSubclassOf(typeof(AGetRequest<int>)).Should().BeTrue();
        }

        [Fact]
        public void Test_ASeasonRequest_1_Implements_IHasId_Interface()
        {
            typeof(ASeasonRequest<>).GetInterfaces().Should().Contain(typeof(IHasId));
        }

        [Fact]
        public void Test_ASeasonRequest_1_Has_AuthorizationRequirement_NotRequired()
        {
            var requestMock = new SeasonRequestMock();
            requestMock.AuthorizationRequirement.Should().Be(AuthorizationRequirement.NotRequired);
        }

        [Fact]
        public void Test_ASeasonRequest_1_Returns_Valid_RequestObjectType()
        {
            var requestMock = new SeasonRequestMock();
            requestMock.RequestObjectType.Should().Be(RequestObjectType.Seasons);
        }

        [Fact]
        public void Test_ASeasonRequest_1_Has_SeasonNumber_Property()
        {
            var propertyInfo = typeof(ASeasonRequest<>)
                    .GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                    .Where(p => p.Name == "SeasonNumber")
                    .FirstOrDefault();

            propertyInfo.CanRead.Should().BeTrue();
            propertyInfo.CanWrite.Should().BeTrue();
            propertyInfo.PropertyType.Should().Be(typeof(uint));
        }

        [Fact]
        public void Test_ASeasonRequest_1_Returns_Valid_UriPathParameters()
        {
            // with implicit season number
            var requestMock = new SeasonRequestMock { Id = "123" };

            requestMock.GetUriPathParameters().Should().NotBeNull()
                                                       .And.HaveCount(2)
                                                       .And.Contain(new Dictionary<string, object>
                                                       {
                                                           ["id"] = "123",
                                                           ["season"] = "0"
                                                       });

            // with explicit season number
            requestMock = new SeasonRequestMock { Id = "123", SeasonNumber = 2 };

            requestMock.GetUriPathParameters().Should().NotBeNull()
                                                       .And.HaveCount(2)
                                                       .And.Contain(new Dictionary<string, object>
                                                       {
                                                           ["id"] = "123",
                                                           ["season"] = "2"
                                                       });
        }

        [Fact]
        public void Test_ASeasonRequest_1_Validate_Throws_Exceptions()
        {
            // id is null
            var requestMock = new SeasonRequestMock();

            Action act = () => requestMock.Validate();
            act.ShouldThrow<ArgumentNullException>();

            // empty id
            requestMock = new SeasonRequestMock { Id = string.Empty };

            act = () => requestMock.Validate();
            act.ShouldThrow<ArgumentException>();

            // id with spaces
            requestMock = new SeasonRequestMock { Id = "invalid id" };

            act = () => requestMock.Validate();
            act.ShouldThrow<ArgumentException>();
        }
    }
}
