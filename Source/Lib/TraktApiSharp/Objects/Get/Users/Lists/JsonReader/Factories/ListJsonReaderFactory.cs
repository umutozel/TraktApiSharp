﻿namespace TraktApiSharp.Objects.Get.Users.Lists.JsonReader.Factories
{
    using Objects.JsonReader;

    internal class ListJsonReaderFactory : IJsonReaderFactory<ITraktList>
    {
        public IObjectJsonReader<ITraktList> CreateObjectReader() => new ListObjectJsonReader();

        public IArrayJsonReader<ITraktList> CreateArrayReader() => new ListArrayJsonReader();
    }
}
