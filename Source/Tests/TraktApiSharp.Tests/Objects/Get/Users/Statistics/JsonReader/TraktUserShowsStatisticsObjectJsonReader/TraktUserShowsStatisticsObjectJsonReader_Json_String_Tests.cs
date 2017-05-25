﻿namespace TraktApiSharp.Tests.Objects.Get.Users.Statistics.JsonReader
{
    using FluentAssertions;
    using System.Threading.Tasks;
    using Traits;
    using TraktApiSharp.Objects.Get.Users.Statistics.JsonReader;
    using Xunit;

    [Category("Objects.Get.Users.Statistics.JsonReader")]
    public partial class TraktUserShowsStatisticsObjectJsonReader_Tests
    {
        [Fact]
        public async Task Test_TraktUserShowsStatisticsObjectJsonReader_ReadObject_From_Json_String_Complete()
        {
            var jsonReader = new TraktUserShowsStatisticsObjectJsonReader();

            var userShowsStatistics = await jsonReader.ReadObjectAsync(JSON_COMPLETE);

            userShowsStatistics.Should().NotBeNull();
            userShowsStatistics.Watched.Should().Be(534);
            userShowsStatistics.Collected.Should().Be(117);
            userShowsStatistics.Ratings.Should().Be(64);
            userShowsStatistics.Comments.Should().Be(14);
        }

        [Fact]
        public async Task Test_TraktUserShowsStatisticsObjectJsonReader_ReadObject_From_Json_String_Incomplete_1()
        {
            var jsonReader = new TraktUserShowsStatisticsObjectJsonReader();

            var userShowsStatistics = await jsonReader.ReadObjectAsync(JSON_INCOMPLETE_1);

            userShowsStatistics.Should().NotBeNull();
            userShowsStatistics.Watched.Should().BeNull();
            userShowsStatistics.Collected.Should().Be(117);
            userShowsStatistics.Ratings.Should().Be(64);
            userShowsStatistics.Comments.Should().Be(14);
        }

        [Fact]
        public async Task Test_TraktUserShowsStatisticsObjectJsonReader_ReadObject_From_Json_String_Incomplete_2()
        {
            var jsonReader = new TraktUserShowsStatisticsObjectJsonReader();

            var userShowsStatistics = await jsonReader.ReadObjectAsync(JSON_INCOMPLETE_2);

            userShowsStatistics.Should().NotBeNull();
            userShowsStatistics.Watched.Should().Be(534);
            userShowsStatistics.Collected.Should().BeNull();
            userShowsStatistics.Ratings.Should().Be(64);
            userShowsStatistics.Comments.Should().Be(14);
        }

        [Fact]
        public async Task Test_TraktUserShowsStatisticsObjectJsonReader_ReadObject_From_Json_String_Incomplete_3()
        {
            var jsonReader = new TraktUserShowsStatisticsObjectJsonReader();

            var userShowsStatistics = await jsonReader.ReadObjectAsync(JSON_INCOMPLETE_3);

            userShowsStatistics.Should().NotBeNull();
            userShowsStatistics.Watched.Should().Be(534);
            userShowsStatistics.Collected.Should().Be(117);
            userShowsStatistics.Ratings.Should().BeNull();
            userShowsStatistics.Comments.Should().Be(14);
        }

        [Fact]
        public async Task Test_TraktUserShowsStatisticsObjectJsonReader_ReadObject_From_Json_String_Incomplete_4()
        {
            var jsonReader = new TraktUserShowsStatisticsObjectJsonReader();

            var userShowsStatistics = await jsonReader.ReadObjectAsync(JSON_INCOMPLETE_4);

            userShowsStatistics.Should().NotBeNull();
            userShowsStatistics.Watched.Should().Be(534);
            userShowsStatistics.Collected.Should().Be(117);
            userShowsStatistics.Ratings.Should().Be(64);
            userShowsStatistics.Comments.Should().BeNull();
        }

        [Fact]
        public async Task Test_TraktUserShowsStatisticsObjectJsonReader_ReadObject_From_Json_String_Incomplete_5()
        {
            var jsonReader = new TraktUserShowsStatisticsObjectJsonReader();

            var userShowsStatistics = await jsonReader.ReadObjectAsync(JSON_INCOMPLETE_5);

            userShowsStatistics.Should().NotBeNull();
            userShowsStatistics.Watched.Should().Be(534);
            userShowsStatistics.Collected.Should().BeNull();
            userShowsStatistics.Ratings.Should().BeNull();
            userShowsStatistics.Comments.Should().BeNull();
        }

        [Fact]
        public async Task Test_TraktUserShowsStatisticsObjectJsonReader_ReadObject_From_Json_String_Incomplete_6()
        {
            var jsonReader = new TraktUserShowsStatisticsObjectJsonReader();

            var userShowsStatistics = await jsonReader.ReadObjectAsync(JSON_INCOMPLETE_6);

            userShowsStatistics.Should().NotBeNull();
            userShowsStatistics.Watched.Should().BeNull();
            userShowsStatistics.Collected.Should().Be(117);
            userShowsStatistics.Ratings.Should().BeNull();
            userShowsStatistics.Comments.Should().BeNull();
        }

        [Fact]
        public async Task Test_TraktUserShowsStatisticsObjectJsonReader_ReadObject_From_Json_String_Incomplete_7()
        {
            var jsonReader = new TraktUserShowsStatisticsObjectJsonReader();

            var userShowsStatistics = await jsonReader.ReadObjectAsync(JSON_INCOMPLETE_7);

            userShowsStatistics.Should().NotBeNull();
            userShowsStatistics.Watched.Should().BeNull();
            userShowsStatistics.Collected.Should().BeNull();
            userShowsStatistics.Ratings.Should().Be(64);
            userShowsStatistics.Comments.Should().BeNull();
        }

        [Fact]
        public async Task Test_TraktUserShowsStatisticsObjectJsonReader_ReadObject_From_Json_String_Incomplete_8()
        {
            var jsonReader = new TraktUserShowsStatisticsObjectJsonReader();

            var userShowsStatistics = await jsonReader.ReadObjectAsync(JSON_INCOMPLETE_8);

            userShowsStatistics.Should().NotBeNull();
            userShowsStatistics.Watched.Should().BeNull();
            userShowsStatistics.Collected.Should().BeNull();
            userShowsStatistics.Ratings.Should().BeNull();
            userShowsStatistics.Comments.Should().Be(14);
        }

        [Fact]
        public async Task Test_TraktUserShowsStatisticsObjectJsonReader_ReadObject_From_Json_String_Not_Valid_1()
        {
            var jsonReader = new TraktUserShowsStatisticsObjectJsonReader();

            var userShowsStatistics = await jsonReader.ReadObjectAsync(JSON_NOT_VALID_1);

            userShowsStatistics.Should().NotBeNull();
            userShowsStatistics.Watched.Should().BeNull();
            userShowsStatistics.Collected.Should().Be(117);
            userShowsStatistics.Ratings.Should().Be(64);
            userShowsStatistics.Comments.Should().Be(14);
        }

        [Fact]
        public async Task Test_TraktUserShowsStatisticsObjectJsonReader_ReadObject_From_Json_String_Not_Valid_2()
        {
            var jsonReader = new TraktUserShowsStatisticsObjectJsonReader();

            var userShowsStatistics = await jsonReader.ReadObjectAsync(JSON_NOT_VALID_2);

            userShowsStatistics.Should().NotBeNull();
            userShowsStatistics.Watched.Should().Be(534);
            userShowsStatistics.Collected.Should().BeNull();
            userShowsStatistics.Ratings.Should().Be(64);
            userShowsStatistics.Comments.Should().Be(14);
        }

        [Fact]
        public async Task Test_TraktUserShowsStatisticsObjectJsonReader_ReadObject_From_Json_String_Not_Valid_3()
        {
            var jsonReader = new TraktUserShowsStatisticsObjectJsonReader();

            var userShowsStatistics = await jsonReader.ReadObjectAsync(JSON_NOT_VALID_3);

            userShowsStatistics.Should().NotBeNull();
            userShowsStatistics.Watched.Should().Be(534);
            userShowsStatistics.Collected.Should().Be(117);
            userShowsStatistics.Ratings.Should().BeNull();
            userShowsStatistics.Comments.Should().Be(14);
        }

        [Fact]
        public async Task Test_TraktUserShowsStatisticsObjectJsonReader_ReadObject_From_Json_String_Not_Valid_4()
        {
            var jsonReader = new TraktUserShowsStatisticsObjectJsonReader();

            var userShowsStatistics = await jsonReader.ReadObjectAsync(JSON_NOT_VALID_4);

            userShowsStatistics.Should().NotBeNull();
            userShowsStatistics.Watched.Should().Be(534);
            userShowsStatistics.Collected.Should().Be(117);
            userShowsStatistics.Ratings.Should().Be(64);
            userShowsStatistics.Comments.Should().BeNull();
        }

        [Fact]
        public async Task Test_TraktUserShowsStatisticsObjectJsonReader_ReadObject_From_Json_String_Not_Valid_5()
        {
            var jsonReader = new TraktUserShowsStatisticsObjectJsonReader();

            var userShowsStatistics = await jsonReader.ReadObjectAsync(JSON_NOT_VALID_5);

            userShowsStatistics.Should().NotBeNull();
            userShowsStatistics.Watched.Should().BeNull();
            userShowsStatistics.Collected.Should().BeNull();
            userShowsStatistics.Ratings.Should().BeNull();
            userShowsStatistics.Comments.Should().BeNull();
        }

        [Fact]
        public async Task Test_TraktUserShowsStatisticsObjectJsonReader_ReadObject_From_Json_String_Null()
        {
            var jsonReader = new TraktUserShowsStatisticsObjectJsonReader();

            var userShowsStatistics = await jsonReader.ReadObjectAsync(default(string));
            userShowsStatistics.Should().BeNull();
        }

        [Fact]
        public async Task Test_TraktUserShowsStatisticsObjectJsonReader_ReadObject_From_Json_String_Empty()
        {
            var jsonReader = new TraktUserShowsStatisticsObjectJsonReader();

            var userShowsStatistics = await jsonReader.ReadObjectAsync(string.Empty);
            userShowsStatistics.Should().BeNull();
        }
    }
}
