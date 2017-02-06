﻿namespace TraktApiSharp.Tests.Requests.Users.OAuth
{
    using FluentAssertions;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using TraktApiSharp.Experimental.Requests.Users.OAuth;
    using TraktApiSharp.Objects.Get.Collection;
    using TraktApiSharp.Requests;
    using TraktApiSharp.Requests.Params;
    using TraktApiSharp.Tests.Traits;
    using Xunit;

    [Category("Requests.Users.OAuth")]
    public class TraktUserCollectionShowsRequest_Tests
    {
        [Fact]
        public void Test_TraktUserCollectionShowsRequest_Is_Not_Abstract()
        {
            typeof(TraktUserCollectionShowsRequest).IsAbstract.Should().BeFalse();
        }

        [Fact]
        public void Test_TraktUserCollectionShowsRequest_Is_Sealed()
        {
            typeof(TraktUserCollectionShowsRequest).IsSealed.Should().BeTrue();
        }

        [Fact]
        public void Test_TraktUserCollectionShowsRequest_Inherits_ATraktUsersGetRequest_1()
        {
            typeof(TraktUserCollectionShowsRequest).IsSubclassOf(typeof(ATraktUsersGetRequest<TraktCollectionShow>)).Should().BeTrue();
        }

        [Fact]
        public void Test_TraktUserCollectionShowsRequest_Has_Username_Property()
        {
            var sortingPropertyInfo = typeof(TraktUserCollectionShowsRequest)
                    .GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                    .Where(p => p.Name == "Username")
                    .FirstOrDefault();

            sortingPropertyInfo.CanRead.Should().BeTrue();
            sortingPropertyInfo.CanWrite.Should().BeTrue();
            sortingPropertyInfo.PropertyType.Should().Be(typeof(string));
        }

        [Fact]
        public void Test_TraktUserCollectionShowsRequest_Has_AuthorizationRequirement_Optional()
        {
            var request = new TraktUserCollectionShowsRequest();
            request.AuthorizationRequirement.Should().Be(TraktAuthorizationRequirement.Optional);
        }

        [Fact]
        public void Test_TraktUserCollectionShowsRequest_Has_Valid_UriTemplate()
        {
            var request = new TraktUserCollectionShowsRequest();
            request.UriTemplate.Should().Be("users/{username}/collection/shows{?extended}");
        }

        [Fact]
        public void Test_TraktUserCollectionShowsRequest_Returns_Valid_UriPathParameters()
        {
            // without extended info
            var request = new TraktUserCollectionShowsRequest { Username = "username" };
            request.GetUriPathParameters().Should().NotBeNull()
                                                   .And.HaveCount(1)
                                                   .And.Contain(new Dictionary<string, object>
                                                   {
                                                       ["username"] = "username"
                                                   });

            // with extended info
            var extendedInfo = new TraktExtendedInfo { Full = true };
            request = new TraktUserCollectionShowsRequest { Username = "username", ExtendedInfo = extendedInfo };

            request.GetUriPathParameters().Should().NotBeNull()
                                                   .And.HaveCount(2)
                                                   .And.Contain(new Dictionary<string, object>
                                                   {
                                                       ["username"] = "username",
                                                       ["extended"] = extendedInfo.ToString()
                                                   });
        }

        [Fact]
        public void Test_TraktUserCollectionShowsRequest_Validate_Throws_Exceptions()
        {
            // username is null
            var requestMock = new TraktUserCollectionShowsRequest();

            Action act = () => requestMock.Validate();
            act.ShouldThrow<ArgumentNullException>();

            // empty username
            requestMock = new TraktUserCollectionShowsRequest { Username = string.Empty };

            act = () => requestMock.Validate();
            act.ShouldThrow<ArgumentException>();

            // username with spaces
            requestMock = new TraktUserCollectionShowsRequest { Username = "invalid username" };

            act = () => requestMock.Validate();
            act.ShouldThrow<ArgumentException>();
        }
    }
}
