﻿namespace TraktApiSharp.Tests.Experimental.Requests.Users.OAuth
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TraktApiSharp.Experimental.Requests.Users.OAuth;
    using TraktApiSharp.Objects.Get.Users;

    [TestClass]
    public class TraktUserFollowingRequestTests
    {
        [TestMethod, TestCategory("Requests"), TestCategory("Users")]
        public void TestTraktUserFollowingRequestIsNotAbstract()
        {
            typeof(TraktUserFollowingRequest).IsAbstract.Should().BeFalse();
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Users")]
        public void TestTraktUserFollowingRequestIsSealed()
        {
            typeof(TraktUserFollowingRequest).IsSealed.Should().BeTrue();
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Users")]
        public void TestTraktUserFollowingRequestIsSubclassOfATraktUsersListGetRequest()
        {
            typeof(TraktUserFollowingRequest).IsSubclassOf(typeof(ATraktUsersListGetRequest<TraktUserFollower>)).Should().BeTrue();
        }
    }
}