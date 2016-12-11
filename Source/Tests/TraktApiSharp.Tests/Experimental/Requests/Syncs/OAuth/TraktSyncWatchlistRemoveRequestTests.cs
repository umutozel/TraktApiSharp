﻿namespace TraktApiSharp.Tests.Experimental.Requests.Syncs.OAuth
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TraktApiSharp.Experimental.Requests.Syncs.OAuth;

    [TestClass]
    public class TraktSyncWatchlistRemoveRequestTests
    {
        [TestMethod, TestCategory("Requests"), TestCategory("Syncs")]
        public void TestTraktSyncWatchlistRemoveRequestIsNotAbstract()
        {
            typeof(TraktSyncWatchlistRemoveRequest).IsAbstract.Should().BeFalse();
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Syncs")]
        public void TestTraktSyncWatchlistRemoveRequestIsSealed()
        {
            typeof(TraktSyncWatchlistRemoveRequest).IsSealed.Should().BeTrue();
        }
    }
}
