﻿namespace TraktApiSharp.Objects.Get.People.Credits.JsonReader.Factories
{
    using Objects.JsonReader;
    using System;

    internal class PersonMovieCreditsCrewJsonReaderFactory : IJsonReaderFactory<ITraktPersonMovieCreditsCrew>
    {
        public IObjectJsonReader<ITraktPersonMovieCreditsCrew> CreateObjectReader() => new PersonMovieCreditsCrewObjectJsonReader();

        public IArrayJsonReader<ITraktPersonMovieCreditsCrew> CreateArrayReader()
        {
            throw new NotSupportedException($"A array json reader for {nameof(ITraktPersonMovieCreditsCrew)} is not supported.");
        }
    }
}
