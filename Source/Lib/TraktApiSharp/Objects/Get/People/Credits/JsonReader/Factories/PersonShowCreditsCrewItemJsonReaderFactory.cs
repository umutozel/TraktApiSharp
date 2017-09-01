﻿namespace TraktApiSharp.Objects.Get.People.Credits.JsonReader.Factories
{
    using Objects.JsonReader;

    internal class PersonShowCreditsCrewItemJsonReaderFactory : IJsonReaderFactory<ITraktPersonShowCreditsCrewItem>
    {
        public IObjectJsonReader<ITraktPersonShowCreditsCrewItem> CreateObjectReader() => new TraktPersonShowCreditsCrewItemObjectJsonReader();

        public IArrayJsonReader<ITraktPersonShowCreditsCrewItem> CreateArrayReader() => new PersonShowCreditsCrewItemArrayJsonReader();
    }
}
