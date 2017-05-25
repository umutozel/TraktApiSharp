﻿namespace TraktApiSharp.Tests.Objects.Get.Users.Statistics.JsonReader
{
    using FluentAssertions;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using TestUtils;
    using Traits;
    using TraktApiSharp.Objects.Get.Users.Statistics.JsonReader;
    using Xunit;

    [Category("Objects.Get.Users.Statistics.JsonReader")]
    public partial class TraktUserRatingsStatisticsObjectJsonReader_Tests
    {
        [Fact]
        public async Task Test_TraktUserRatingsStatisticsObjectJsonReader_ReadObject_From_Stream_Complete()
        {
            var jsonReader = new TraktUserRatingsStatisticsObjectJsonReader();

            using (var stream = JSON_COMPLETE.ToStream())
            {
                var userRatingsStatistics = await jsonReader.ReadObjectAsync(stream);

                userRatingsStatistics.Should().NotBeNull();
                userRatingsStatistics.Total.Should().Be(9257);
                userRatingsStatistics.Distribution.Should().NotBeNull();
                userRatingsStatistics.Distribution.Should().NotBeEmpty();
                userRatingsStatistics.Distribution.Should().HaveCount(10);
                userRatingsStatistics.Distribution.Should().Contain(new Dictionary<string, int>
                {
                    ["1"] = 78,
                    ["2"] = 45,
                    ["3"] = 55,
                    ["4"] = 96,
                    ["5"] = 183,
                    ["6"] = 545,
                    ["7"] = 1361,
                    ["8"] = 2259,
                    ["9"] = 1772,
                    ["10"] = 2863
                });
            }
        }

        [Fact]
        public async Task Test_TraktUserRatingsStatisticsObjectJsonReader_ReadObject_From_Stream_Incomplete_1()
        {
            var jsonReader = new TraktUserRatingsStatisticsObjectJsonReader();

            using (var stream = JSON_INCOMPLETE_1.ToStream())
            {
                var userRatingsStatistics = await jsonReader.ReadObjectAsync(stream);

                userRatingsStatistics.Should().NotBeNull();
                userRatingsStatistics.Total.Should().BeNull();
                userRatingsStatistics.Distribution.Should().NotBeNull();
                userRatingsStatistics.Distribution.Should().NotBeEmpty();
                userRatingsStatistics.Distribution.Should().HaveCount(10);
                userRatingsStatistics.Distribution.Should().Contain(new Dictionary<string, int>
                {
                    ["1"] = 78,
                    ["2"] = 45,
                    ["3"] = 55,
                    ["4"] = 96,
                    ["5"] = 183,
                    ["6"] = 545,
                    ["7"] = 1361,
                    ["8"] = 2259,
                    ["9"] = 1772,
                    ["10"] = 2863
                });
            }
        }

        [Fact]
        public async Task Test_TraktUserRatingsStatisticsObjectJsonReader_ReadObject_From_Stream_Incomplete_2()
        {
            var jsonReader = new TraktUserRatingsStatisticsObjectJsonReader();

            using (var stream = JSON_INCOMPLETE_2.ToStream())
            {
                var userRatingsStatistics = await jsonReader.ReadObjectAsync(stream);

                userRatingsStatistics.Should().NotBeNull();
                userRatingsStatistics.Total.Should().Be(9257);
                userRatingsStatistics.Distribution.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_TraktUserRatingsStatisticsObjectJsonReader_ReadObject_From_Stream_Not_Valid_1()
        {
            var jsonReader = new TraktUserRatingsStatisticsObjectJsonReader();

            using (var stream = JSON_NOT_VALID_1.ToStream())
            {
                var userRatingsStatistics = await jsonReader.ReadObjectAsync(stream);

                userRatingsStatistics.Should().NotBeNull();
                userRatingsStatistics.Total.Should().BeNull();
                userRatingsStatistics.Distribution.Should().NotBeNull();
                userRatingsStatistics.Distribution.Should().NotBeEmpty();
                userRatingsStatistics.Distribution.Should().HaveCount(10);
                userRatingsStatistics.Distribution.Should().Contain(new Dictionary<string, int>
                {
                    ["1"] = 78,
                    ["2"] = 45,
                    ["3"] = 55,
                    ["4"] = 96,
                    ["5"] = 183,
                    ["6"] = 545,
                    ["7"] = 1361,
                    ["8"] = 2259,
                    ["9"] = 1772,
                    ["10"] = 2863
                });
            }
        }

        [Fact]
        public async Task Test_TraktUserRatingsStatisticsObjectJsonReader_ReadObject_From_Stream_Not_Valid_2()
        {
            var jsonReader = new TraktUserRatingsStatisticsObjectJsonReader();

            using (var stream = JSON_NOT_VALID_2.ToStream())
            {
                var userRatingsStatistics = await jsonReader.ReadObjectAsync(stream);

                userRatingsStatistics.Should().NotBeNull();
                userRatingsStatistics.Total.Should().Be(9257);
                userRatingsStatistics.Distribution.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_TraktUserRatingsStatisticsObjectJsonReader_ReadObject_From_Stream_Not_Valid_3()
        {
            var jsonReader = new TraktUserRatingsStatisticsObjectJsonReader();

            using (var stream = JSON_NOT_VALID_3.ToStream())
            {
                var userRatingsStatistics = await jsonReader.ReadObjectAsync(stream);

                userRatingsStatistics.Should().NotBeNull();
                userRatingsStatistics.Total.Should().BeNull();
                userRatingsStatistics.Distribution.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_TraktUserRatingsStatisticsObjectJsonReader_ReadObject_From_Stream_Null()
        {
            var jsonReader = new TraktUserRatingsStatisticsObjectJsonReader();

            var userRatingsStatistics = await jsonReader.ReadObjectAsync(default(Stream));
            userRatingsStatistics.Should().BeNull();
        }

        [Fact]
        public async Task Test_TraktUserRatingsStatisticsObjectJsonReader_ReadObject_From_Stream_Empty()
        {
            var jsonReader = new TraktUserRatingsStatisticsObjectJsonReader();

            using (var stream = string.Empty.ToStream())
            {
                var userRatingsStatistics = await jsonReader.ReadObjectAsync(stream);
                userRatingsStatistics.Should().BeNull();
            }
        }
    }
}
