﻿namespace TraktApiSharp.Objects.JsonReader
{
    internal interface IJsonReaderFactory<TReturnType>
    {
        IObjectJsonReader<TReturnType> CreateObjectReader();

        IArrayJsonReader<TReturnType> CreateArrayReader();
    }
}
