﻿namespace TraktApiSharp.Objects.Get.Users.Statistics.JsonReader.Factories
{
    using Objects.JsonReader;
    using System;

    internal class TraktUserEpisodesStatisticsJsonReaderFactory : ITraktJsonReaderFactory<ITraktUserEpisodesStatistics>
    {
        public ITraktObjectJsonReader<ITraktUserEpisodesStatistics> CreateObjectReader() => new TraktUserEpisodesStatisticsObjectJsonReader();

        public ITraktArrayJsonReader<ITraktUserEpisodesStatistics> CreateArrayReader()
        {
            throw new NotSupportedException($"A array json reader for {nameof(ITraktUserEpisodesStatistics)} is not supported.");
        }
    }
}
