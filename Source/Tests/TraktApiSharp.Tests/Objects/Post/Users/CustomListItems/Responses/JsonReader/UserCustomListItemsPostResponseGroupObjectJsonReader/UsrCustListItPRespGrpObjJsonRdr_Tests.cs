﻿namespace TraktApiSharp.Tests.Objects.Post.Users.CustomListItems.Responses.JsonReader
{
    using FluentAssertions;
    using Traits;
    using TraktApiSharp.Objects.JsonReader;
    using TraktApiSharp.Objects.Post.Users.CustomListItems.Responses;
    using TraktApiSharp.Objects.Post.Users.CustomListItems.Responses.JsonReader;
    using Xunit;

    [Category("Objects.Post.Users.CustomListItems.Responses.JsonReader")]
    public partial class UserCustomListItemsPostResponseGroupObjectJsonReader_Tests
    {
        [Fact]
        public void Test_UserCustomListItemsPostResponseGroupObjectJsonReader_Implements_IObjectJsonReader_Interface()
        {
            typeof(UserCustomListItemsPostResponseGroupObjectJsonReader).GetInterfaces().Should().Contain(typeof(IObjectJsonReader<ITraktUserCustomListItemsPostResponseGroup>));
        }
    }
}
