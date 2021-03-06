﻿namespace TraktApiSharp.Objects.Get.Episodes.JsonReader.Factories
{
    using Objects.JsonReader;
    using System;

    internal class EpisodeIdsJsonReaderFactory : IJsonReaderFactory<ITraktEpisodeIds>
    {
        public IObjectJsonReader<ITraktEpisodeIds> CreateObjectReader() => new EpisodeIdsObjectJsonReader();

        public IArrayJsonReader<ITraktEpisodeIds> CreateArrayReader()
        {
            throw new NotSupportedException($"A array json reader for {nameof(ITraktEpisodeIds)} is not supported.");
        }
    }
}
