﻿namespace TraktApiSharp.Objects.Post.Syncs.Collection.Responses.JsonReader.Factories
{
    using Objects.JsonReader;
    using System;

    internal class SyncCollectionPostResponseJsonReaderFactory : IJsonReaderFactory<ITraktSyncCollectionPostResponse>
    {
        public IObjectJsonReader<ITraktSyncCollectionPostResponse> CreateObjectReader() => new SyncCollectionPostResponseObjectJsonReader();

        public IArrayJsonReader<ITraktSyncCollectionPostResponse> CreateArrayReader()
        {
            throw new NotSupportedException($"A array json reader for {nameof(ITraktSyncCollectionPostResponse)} is not supported.");
        }
    }
}
