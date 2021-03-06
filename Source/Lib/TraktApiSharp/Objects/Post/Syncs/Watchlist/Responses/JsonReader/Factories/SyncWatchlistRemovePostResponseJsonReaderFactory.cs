﻿namespace TraktApiSharp.Objects.Post.Syncs.Watchlist.Responses.JsonReader.Factories
{
    using Objects.JsonReader;
    using System;

    internal class SyncWatchlistRemovePostResponseJsonReaderFactory : IJsonReaderFactory<ITraktSyncWatchlistRemovePostResponse>
    {
        public IObjectJsonReader<ITraktSyncWatchlistRemovePostResponse> CreateObjectReader() => new SyncWatchlistRemovePostResponseObjectJsonReader();

        public IArrayJsonReader<ITraktSyncWatchlistRemovePostResponse> CreateArrayReader()
        {
            throw new NotSupportedException($"A array json reader for {nameof(ITraktSyncWatchlistRemovePostResponse)} is not supported.");
        }
    }
}
