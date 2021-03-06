﻿namespace TraktApiSharp.Tests.Requests.Users.OAuth
{
    using FluentAssertions;
    using System;
    using System.Collections.Generic;
    using Traits;
    using TraktApiSharp.Requests.Base;
    using TraktApiSharp.Requests.Interfaces;
    using TraktApiSharp.Requests.Users.OAuth;
    using Xunit;

    [Category("Requests.Users.OAuth")]
    public class AUsersPostByIdRequest_1_Tests
    {
        internal class UsersPostByIdRequestMock : AUsersPostByIdRequest<int, float>
        {
            public override string UriTemplate { get { throw new NotImplementedException(); } }
            public override RequestObjectType RequestObjectType { get { throw new NotImplementedException(); } }
        }

        [Fact]
        public void Test_AUsersPostByIdRequest_1_Is_Abstract()
        {
            typeof(AUsersPostByIdRequest<,>).IsAbstract.Should().BeTrue();
        }

        [Fact]
        public void Test_AUsersPostByIdRequest_1_Has_GenericTypeParameter()
        {
            typeof(AUsersPostByIdRequest<,>).ContainsGenericParameters.Should().BeTrue();
            typeof(AUsersPostByIdRequest<int, float>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(2);
        }

        [Fact]
        public void Test_AUsersPostByIdRequest_1_Inherits_APostRequest_2()
        {
            typeof(AUsersPostByIdRequest<int, float>).IsSubclassOf(typeof(APostRequest<int, float>)).Should().BeTrue();
        }

        [Fact]
        public void Test_AUsersPostByIdRequest_1_Implements_IHasId_Interface()
        {
            typeof(AUsersPostByIdRequest<,>).GetInterfaces().Should().Contain(typeof(IHasId));
        }

        [Fact]
        public void Test_AUsersPostByIdRequest_1_Has_AuthorizationRequirement_Required()
        {
            var request = new UsersPostByIdRequestMock();
            request.AuthorizationRequirement.Should().Be(AuthorizationRequirement.Required);
        }

        [Fact]
        public void Test_AUsersPostByIdRequest_1_Returns_Valid_UriPathParameters()
        {
            var requestMock = new UsersPostByIdRequestMock { Id = "123" };

            requestMock.GetUriPathParameters().Should().NotBeNull()
                                                       .And.HaveCount(1)
                                                       .And.Contain(new Dictionary<string, object>
                                                       {
                                                           ["id"] = "123"
                                                       });
        }

        [Fact]
        public void Test_AUsersPostByIdRequest_1_Validate_Throws_Exceptions()
        {
            // id is null
            var requestMock = new UsersPostByIdRequestMock();

            Action act = () => requestMock.Validate();
            act.ShouldThrow<ArgumentNullException>();

            // empty id
            requestMock = new UsersPostByIdRequestMock { Id = string.Empty };

            act = () => requestMock.Validate();
            act.ShouldThrow<ArgumentException>();

            // id with spaces
            requestMock = new UsersPostByIdRequestMock { Id = "invalid id" };

            act = () => requestMock.Validate();
            act.ShouldThrow<ArgumentException>();
        }
    }
}
