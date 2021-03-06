﻿namespace TraktApiSharp.Objects.Get.Shows.JsonReader.Factories
{
    using Objects.JsonReader;

    internal class ShowTranslationJsonReaderFactory : IJsonReaderFactory<ITraktShowTranslation>
    {
        public IObjectJsonReader<ITraktShowTranslation> CreateObjectReader() => new ShowTranslationObjectJsonReader();

        public IArrayJsonReader<ITraktShowTranslation> CreateArrayReader() => new ShowTranslationArrayJsonReader();
    }
}
