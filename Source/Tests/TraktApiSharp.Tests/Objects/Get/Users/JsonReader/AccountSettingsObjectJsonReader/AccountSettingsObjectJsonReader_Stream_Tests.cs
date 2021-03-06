﻿namespace TraktApiSharp.Tests.Objects.Get.Users.JsonReader
{
    using FluentAssertions;
    using System.IO;
    using System.Threading.Tasks;
    using TestUtils;
    using Traits;
    using TraktApiSharp.Objects.Get.Users.JsonReader;
    using Xunit;

    [Category("Objects.Get.Users.JsonReader")]
    public partial class AccountSettingsObjectJsonReader_Tests
    {
        [Fact]
        public async Task Test_AccountSettingsObjectJsonReader_ReadObject_From_Stream_Complete()
        {
            var jsonReader = new AccountSettingsObjectJsonReader();

            using (var stream = JSON_COMPLETE.ToStream())
            {
                var userAccountSettings = await jsonReader.ReadObjectAsync(stream);

                userAccountSettings.Should().NotBeNull();
                userAccountSettings.TimeZoneId.Should().Be("America/Los_Angeles");
                userAccountSettings.Time24Hr.Should().BeTrue();
                userAccountSettings.CoverImage.Should().Be("https://walter.trakt.us/images/movies/000/001/545/fanarts/original/0abb604492.jpg?1406095042");
            }
        }

        [Fact]
        public async Task Test_AccountSettingsObjectJsonReader_ReadObject_From_Stream_Incomplete_1()
        {
            var jsonReader = new AccountSettingsObjectJsonReader();

            using (var stream = JSON_INCOMPLETE_1.ToStream())
            {
                var userAccountSettings = await jsonReader.ReadObjectAsync(stream);

                userAccountSettings.Should().NotBeNull();
                userAccountSettings.TimeZoneId.Should().BeNull();
                userAccountSettings.Time24Hr.Should().BeTrue();
                userAccountSettings.CoverImage.Should().Be("https://walter.trakt.us/images/movies/000/001/545/fanarts/original/0abb604492.jpg?1406095042");
            }
        }

        [Fact]
        public async Task Test_AccountSettingsObjectJsonReader_ReadObject_From_Stream_Incomplete_2()
        {
            var jsonReader = new AccountSettingsObjectJsonReader();

            using (var stream = JSON_INCOMPLETE_2.ToStream())
            {
                var userAccountSettings = await jsonReader.ReadObjectAsync(stream);

                userAccountSettings.Should().NotBeNull();
                userAccountSettings.TimeZoneId.Should().Be("America/Los_Angeles");
                userAccountSettings.Time24Hr.Should().BeNull();
                userAccountSettings.CoverImage.Should().Be("https://walter.trakt.us/images/movies/000/001/545/fanarts/original/0abb604492.jpg?1406095042");
            }
        }

        [Fact]
        public async Task Test_AccountSettingsObjectJsonReader_ReadObject_From_Stream_Incomplete_3()
        {
            var jsonReader = new AccountSettingsObjectJsonReader();

            using (var stream = JSON_INCOMPLETE_3.ToStream())
            {
                var userAccountSettings = await jsonReader.ReadObjectAsync(stream);

                userAccountSettings.Should().NotBeNull();
                userAccountSettings.TimeZoneId.Should().Be("America/Los_Angeles");
                userAccountSettings.Time24Hr.Should().BeTrue();
                userAccountSettings.CoverImage.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_AccountSettingsObjectJsonReader_ReadObject_From_Stream_Incomplete_4()
        {
            var jsonReader = new AccountSettingsObjectJsonReader();

            using (var stream = JSON_INCOMPLETE_4.ToStream())
            {
                var userAccountSettings = await jsonReader.ReadObjectAsync(stream);

                userAccountSettings.Should().NotBeNull();
                userAccountSettings.TimeZoneId.Should().Be("America/Los_Angeles");
                userAccountSettings.Time24Hr.Should().BeNull();
                userAccountSettings.CoverImage.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_AccountSettingsObjectJsonReader_ReadObject_From_Stream_Incomplete_5()
        {
            var jsonReader = new AccountSettingsObjectJsonReader();

            using (var stream = JSON_INCOMPLETE_5.ToStream())
            {
                var userAccountSettings = await jsonReader.ReadObjectAsync(stream);

                userAccountSettings.Should().NotBeNull();
                userAccountSettings.TimeZoneId.Should().BeNull();
                userAccountSettings.Time24Hr.Should().BeTrue();
                userAccountSettings.CoverImage.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_AccountSettingsObjectJsonReader_ReadObject_From_Stream_Incomplete_6()
        {
            var jsonReader = new AccountSettingsObjectJsonReader();

            using (var stream = JSON_INCOMPLETE_6.ToStream())
            {
                var userAccountSettings = await jsonReader.ReadObjectAsync(stream);

                userAccountSettings.Should().NotBeNull();
                userAccountSettings.TimeZoneId.Should().BeNull();
                userAccountSettings.Time24Hr.Should().BeNull();
                userAccountSettings.CoverImage.Should().Be("https://walter.trakt.us/images/movies/000/001/545/fanarts/original/0abb604492.jpg?1406095042");
            }
        }

        [Fact]
        public async Task Test_AccountSettingsObjectJsonReader_ReadObject_From_Stream_Not_Valid_1()
        {
            var jsonReader = new AccountSettingsObjectJsonReader();

            using (var stream = JSON_NOT_VALID_1.ToStream())
            {
                var userAccountSettings = await jsonReader.ReadObjectAsync(stream);

                userAccountSettings.Should().NotBeNull();
                userAccountSettings.TimeZoneId.Should().BeNull();
                userAccountSettings.Time24Hr.Should().BeTrue();
                userAccountSettings.CoverImage.Should().Be("https://walter.trakt.us/images/movies/000/001/545/fanarts/original/0abb604492.jpg?1406095042");
            }
        }

        [Fact]
        public async Task Test_AccountSettingsObjectJsonReader_ReadObject_From_Stream_Not_Valid_2()
        {
            var jsonReader = new AccountSettingsObjectJsonReader();

            using (var stream = JSON_NOT_VALID_2.ToStream())
            {
                var userAccountSettings = await jsonReader.ReadObjectAsync(stream);

                userAccountSettings.Should().NotBeNull();
                userAccountSettings.TimeZoneId.Should().Be("America/Los_Angeles");
                userAccountSettings.Time24Hr.Should().BeNull();
                userAccountSettings.CoverImage.Should().Be("https://walter.trakt.us/images/movies/000/001/545/fanarts/original/0abb604492.jpg?1406095042");
            }
        }

        [Fact]
        public async Task Test_AccountSettingsObjectJsonReader_ReadObject_From_Stream_Not_Valid_3()
        {
            var jsonReader = new AccountSettingsObjectJsonReader();

            using (var stream = JSON_NOT_VALID_3.ToStream())
            {
                var userAccountSettings = await jsonReader.ReadObjectAsync(stream);

                userAccountSettings.Should().NotBeNull();
                userAccountSettings.TimeZoneId.Should().Be("America/Los_Angeles");
                userAccountSettings.Time24Hr.Should().BeTrue();
                userAccountSettings.CoverImage.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_AccountSettingsObjectJsonReader_ReadObject_From_Stream_Not_Valid_4()
        {
            var jsonReader = new AccountSettingsObjectJsonReader();

            using (var stream = JSON_NOT_VALID_4.ToStream())
            {
                var userAccountSettings = await jsonReader.ReadObjectAsync(stream);

                userAccountSettings.Should().NotBeNull();
                userAccountSettings.TimeZoneId.Should().BeNull();
                userAccountSettings.Time24Hr.Should().BeNull();
                userAccountSettings.CoverImage.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_AccountSettingsObjectJsonReader_ReadObject_From_Stream_Null()
        {
            var jsonReader = new AccountSettingsObjectJsonReader();

            var userAccountSettings = await jsonReader.ReadObjectAsync(default(Stream));
            userAccountSettings.Should().BeNull();
        }

        [Fact]
        public async Task Test_AccountSettingsObjectJsonReader_ReadObject_From_Stream_Empty()
        {
            var jsonReader = new AccountSettingsObjectJsonReader();

            using (var stream = string.Empty.ToStream())
            {
                var userAccountSettings = await jsonReader.ReadObjectAsync(stream);
                userAccountSettings.Should().BeNull();
            }
        }
    }
}
