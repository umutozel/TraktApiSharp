﻿namespace TraktApiSharp.Objects.Get.People.JsonReader.Factories
{
    using Objects.JsonReader;
    using System;

    internal class PersonJsonReaderFactory : IJsonReaderFactory<ITraktPerson>
    {
        public IObjectJsonReader<ITraktPerson> CreateObjectReader() => new PersonObjectJsonReader();

        public IArrayJsonReader<ITraktPerson> CreateArrayReader()
        {
            throw new NotSupportedException($"A array json reader for {nameof(ITraktPerson)} is not supported.");
        }
    }
}
