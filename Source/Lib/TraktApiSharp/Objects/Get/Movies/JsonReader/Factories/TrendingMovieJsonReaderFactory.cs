﻿namespace TraktApiSharp.Objects.Get.Movies.JsonReader.Factories
{
    using Objects.JsonReader;

    internal class TrendingMovieJsonReaderFactory : IJsonReaderFactory<ITraktTrendingMovie>
    {
        public IObjectJsonReader<ITraktTrendingMovie> CreateObjectReader() => new TrendingMovieObjectJsonReader();

        public IArrayJsonReader<ITraktTrendingMovie> CreateArrayReader() => new TrendingMovieArrayJsonReader();
    }
}
