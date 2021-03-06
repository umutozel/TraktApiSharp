﻿namespace TraktApiSharp.Objects.Get.Movies.JsonReader.Factories
{
    using Objects.JsonReader;

    internal class MostPWCMovieJsonReaderFactory : IJsonReaderFactory<ITraktMostPWCMovie>
    {
        public IObjectJsonReader<ITraktMostPWCMovie> CreateObjectReader() => new MostPWCMovieObjectJsonReader();

        public IArrayJsonReader<ITraktMostPWCMovie> CreateArrayReader() => new MostPWCMovieArrayJsonReader();
    }
}
