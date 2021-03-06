﻿namespace TraktApiSharp.Tests.Objects.Basic.Implementations
{
    using FluentAssertions;
    using System.Threading.Tasks;
    using Traits;
    using TraktApiSharp.Enums;
    using TraktApiSharp.Objects.Basic;
    using TraktApiSharp.Objects.Basic.Implementations;
    using TraktApiSharp.Objects.Basic.JsonReader;
    using Xunit;

    [Category("Objects.Basic.Implementations")]
    public class TraktMetadata_Tests
    {
        [Fact]
        public void Test_TraktMetadata_Implements_ITraktMetadata_Interface()
        {
            typeof(TraktMetadata).GetInterfaces().Should().Contain(typeof(ITraktMetadata));
        }

        [Fact]
        public void Test_TraktMetadata_Default_Constructor()
        {
            var traktMetadata = new TraktMetadata();

            traktMetadata.MediaType.Should().BeNull();
            traktMetadata.MediaResolution.Should().BeNull();
            traktMetadata.Audio.Should().BeNull();
            traktMetadata.AudioChannels.Should().BeNull();
            traktMetadata.ThreeDimensional.Should().BeNull();
        }

        [Fact]
        public async Task Test_TraktMetadata_From_Json()
        {
            var jsonReader = new MetadataObjectJsonReader();
            var traktMetadata = await jsonReader.ReadObjectAsync(JSON) as TraktMetadata;

            traktMetadata.Should().NotBeNull();
            traktMetadata.MediaType.Should().Be(TraktMediaType.Digital);
            traktMetadata.MediaResolution.Should().Be(TraktMediaResolution.HD_720p);
            traktMetadata.Audio.Should().Be(TraktMediaAudio.AAC);
            traktMetadata.AudioChannels.Should().Be(TraktMediaAudioChannel.Channels_5_1);
            traktMetadata.ThreeDimensional.Should().BeTrue();
        }

        private const string JSON =
            @"{
                ""media_type"": ""digital"",
                ""resolution"": ""hd_720p"",
                ""audio"": ""aac"",
                ""audio_channels"": ""5.1"",
                ""3d"": true
              }";
    }
}
