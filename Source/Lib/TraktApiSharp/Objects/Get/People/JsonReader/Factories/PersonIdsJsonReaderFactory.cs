﻿namespace TraktApiSharp.Objects.Get.People.JsonReader.Factories
{
    using Objects.JsonReader;
    using System;

    internal class PersonIdsJsonReaderFactory : IJsonReaderFactory<ITraktPersonIds>
    {
        public IObjectJsonReader<ITraktPersonIds> CreateObjectReader() => new PersonIdsObjectJsonReader();

        public IArrayJsonReader<ITraktPersonIds> CreateArrayReader()
        {
            throw new NotSupportedException($"A array json reader for {nameof(ITraktPersonIds)} is not supported.");
        }
    }
}
