﻿namespace TraktApiSharp.Tests.Requests.Users.OAuth
{
    using FluentAssertions;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using TraktApiSharp.Experimental.Requests.Base;
    using TraktApiSharp.Experimental.Requests.Interfaces;
    using TraktApiSharp.Experimental.Requests.Users.OAuth;
    using TraktApiSharp.Objects.Get.Users.Lists;
    using TraktApiSharp.Objects.Post.Users;
    using TraktApiSharp.Requests;
    using TraktApiSharp.Tests.Traits;
    using Xunit;

    [Category("Requests.Users.OAuth")]
    public class TraktUserCustomListUpdateRequest_Tests
    {
        [Fact]
        public void Test_TraktUserCustomListUpdateRequest_Is_Not_Abstract()
        {
            typeof(TraktUserCustomListUpdateRequest).IsAbstract.Should().BeFalse();
        }

        [Fact]
        public void Test_TraktUserCustomListUpdateRequest_Is_Sealed()
        {
            typeof(TraktUserCustomListUpdateRequest).IsSealed.Should().BeTrue();
        }

        [Fact]
        public void Test_TraktUserCustomListUpdateRequest_Inherits_ATraktPutRequest_2()
        {
            typeof(TraktUserCustomListUpdateRequest).IsSubclassOf(typeof(ATraktPutRequest<TraktList, TraktUserCustomListPost>)).Should().BeTrue();
        }

        [Fact]
        public void Test_TraktUserCustomListUpdateRequest_Implements_ITraktHasId_Interface()
        {
            typeof(TraktUserCustomListUpdateRequest).GetInterfaces().Should().Contain(typeof(ITraktHasId));
        }

        [Fact]
        public void Test_TraktUserCustomListUpdateRequest_Has_Username_Property()
        {
            var sortingPropertyInfo = typeof(TraktUserCustomListUpdateRequest)
                    .GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                    .Where(p => p.Name == "Username")
                    .FirstOrDefault();

            sortingPropertyInfo.CanRead.Should().BeTrue();
            sortingPropertyInfo.CanWrite.Should().BeTrue();
            sortingPropertyInfo.PropertyType.Should().Be(typeof(string));
        }

        [Fact]
        public void Test_TraktUserCustomListUpdateRequest_Has_AuthorizationRequirement_Required()
        {
            var request = new TraktUserCustomListUpdateRequest();
            request.AuthorizationRequirement.Should().Be(TraktAuthorizationRequirement.Required);
        }

        [Fact]
        public void Test_TraktUserCustomListUpdateRequest_Returns_Valid_RequestObjectType()
        {
            var requestMock = new TraktUserCustomListUpdateRequest();
            requestMock.RequestObjectType.Should().Be(TraktRequestObjectType.Lists);
        }

        [Fact]
        public void Test_TraktUserCustomListUpdateRequest_Has_Valid_UriTemplate()
        {
            var request = new TraktUserCustomListUpdateRequest();
            request.UriTemplate.Should().Be("users/{username}/lists/{id}");
        }

        [Fact]
        public void Test_TraktUserCustomListUpdateRequest_Returns_Valid_UriPathParameters()
        {
            var request = new TraktUserCustomListUpdateRequest { Username = "username", Id = "123" };

            request.GetUriPathParameters().Should().NotBeNull()
                                                   .And.HaveCount(2)
                                                   .And.Contain(new Dictionary<string, object>
                                                   {
                                                       ["username"] = "username",
                                                       ["id"] = "123"
                                                   });
        }

        [Fact]
        public void Test_TraktUserCustomListUpdateRequest_Validate_Throws_Exceptions()
        {
            // username is null
            var request = new TraktUserCustomListUpdateRequest { Id = "123" };

            Action act = () => request.Validate();
            act.ShouldThrow<ArgumentNullException>();

            // empty username
            request = new TraktUserCustomListUpdateRequest { Username = string.Empty, Id = "123" };

            act = () => request.Validate();
            act.ShouldThrow<ArgumentException>();

            // username with spaces
            request = new TraktUserCustomListUpdateRequest { Username = "invalid username", Id = "123" };

            act = () => request.Validate();
            act.ShouldThrow<ArgumentException>();

            // id is null
            request = new TraktUserCustomListUpdateRequest { Username = "username" };

            act = () => request.Validate();
            act.ShouldThrow<ArgumentNullException>();

            // empty id
            request = new TraktUserCustomListUpdateRequest { Username = "username", Id = string.Empty };

            act = () => request.Validate();
            act.ShouldThrow<ArgumentException>();

            // id with spaces
            request = new TraktUserCustomListUpdateRequest { Username = "username", Id = "invalid id" };

            act = () => request.Validate();
            act.ShouldThrow<ArgumentException>();
        }
    }
}
