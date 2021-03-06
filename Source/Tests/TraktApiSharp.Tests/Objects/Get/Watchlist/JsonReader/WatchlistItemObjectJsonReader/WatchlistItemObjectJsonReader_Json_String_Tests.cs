﻿namespace TraktApiSharp.Tests.Objects.Get.Watchlist.JsonReader
{
    using FluentAssertions;
    using System.Threading.Tasks;
    using Traits;
    using TraktApiSharp.Objects.Get.Watchlist.JsonReader;
    using Xunit;

    [Category("Objects.Get.Watchlist.JsonReader")]
    public partial class WatchlistItemObjectJsonReader_Tests
    {
        [Fact]
        public async Task Test_WatchlistItemObjectJsonReader_ReadObject_From_Json_String_Null()
        {
            var jsonReader = new WatchlistItemObjectJsonReader();

            var traktWatchlistItem = await jsonReader.ReadObjectAsync(default(string));
            traktWatchlistItem.Should().BeNull();
        }

        [Fact]
        public async Task Test_WatchlistItemObjectJsonReader_ReadObject_From_Json_String_Empty()
        {
            var jsonReader = new WatchlistItemObjectJsonReader();

            var traktWatchlistItem = await jsonReader.ReadObjectAsync(string.Empty);
            traktWatchlistItem.Should().BeNull();
        }
    }
}
