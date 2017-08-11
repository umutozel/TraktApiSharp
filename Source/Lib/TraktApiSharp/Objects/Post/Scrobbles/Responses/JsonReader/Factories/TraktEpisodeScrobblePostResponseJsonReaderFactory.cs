﻿namespace TraktApiSharp.Objects.Post.Scrobbles.Responses.JsonReader.Factories
{
    using Objects.JsonReader;
    using System;

    internal class TraktEpisodeScrobblePostResponseJsonReaderFactory : ITraktJsonReaderFactory<ITraktEpisodeScrobblePostResponse>
    {
        public ITraktObjectJsonReader<ITraktEpisodeScrobblePostResponse> CreateObjectReader() => new TraktEpisodeScrobblePostResponseObjectJsonReader();

        public ITraktArrayJsonReader<ITraktEpisodeScrobblePostResponse> CreateArrayReader()
        {
            throw new NotSupportedException($"A array json reader for {nameof(ITraktEpisodeScrobblePostResponse)} is not supported.");
        }
    }
}