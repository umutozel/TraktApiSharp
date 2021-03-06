﻿namespace TraktApiSharp.Objects.Get.Episodes.JsonReader.Factories
{
    using Objects.JsonReader;

    internal class EpisodeJsonReaderFactory : IJsonReaderFactory<ITraktEpisode>
    {
        public IObjectJsonReader<ITraktEpisode> CreateObjectReader() => new EpisodeObjectJsonReader();

        public IArrayJsonReader<ITraktEpisode> CreateArrayReader() => new EpisodeArrayJsonReader();
    }
}
