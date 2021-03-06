﻿namespace TraktApiSharp.Objects.Get.Collections.JsonReader
{
    using Basic.JsonReader;
    using Collections.Implementations;
    using Newtonsoft.Json;
    using Objects.JsonReader;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    internal class CollectionShowEpisodeObjectJsonReader : IObjectJsonReader<ITraktCollectionShowEpisode>
    {
        private const string PROPERTY_NAME_NUMBER = "number";
        private const string PROPERTY_NAME_COLLECTED_AT = "collected_at";
        private const string PROPERTY_NAME_METADATA = "metadata";

        public Task<ITraktCollectionShowEpisode> ReadObjectAsync(string json, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (string.IsNullOrEmpty(json))
                return Task.FromResult(default(ITraktCollectionShowEpisode));

            using (var reader = new StringReader(json))
            using (var jsonReader = new JsonTextReader(reader))
            {
                return ReadObjectAsync(jsonReader, cancellationToken);
            }
        }

        public Task<ITraktCollectionShowEpisode> ReadObjectAsync(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (stream == null)
                return Task.FromResult(default(ITraktCollectionShowEpisode));

            using (var streamReader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(streamReader))
            {
                return ReadObjectAsync(jsonReader, cancellationToken);
            }
        }

        public async Task<ITraktCollectionShowEpisode> ReadObjectAsync(JsonTextReader jsonReader, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (jsonReader == null)
                return await Task.FromResult(default(ITraktCollectionShowEpisode));

            if (await jsonReader.ReadAsync(cancellationToken) && jsonReader.TokenType == JsonToken.StartObject)
            {
                var metadataObjectReader = new MetadataObjectJsonReader();

                ITraktCollectionShowEpisode traktCollectionShowEpisode = new TraktCollectionShowEpisode();

                while (await jsonReader.ReadAsync(cancellationToken) && jsonReader.TokenType == JsonToken.PropertyName)
                {
                    var propertyName = jsonReader.Value.ToString();

                    switch (propertyName)
                    {
                        case PROPERTY_NAME_NUMBER:
                            traktCollectionShowEpisode.Number = await jsonReader.ReadAsInt32Async(cancellationToken);
                            break;
                        case PROPERTY_NAME_COLLECTED_AT:
                            {
                                var value = await JsonReaderHelper.ReadDateTimeValueAsync(jsonReader, cancellationToken);

                                if (value.First)
                                    traktCollectionShowEpisode.CollectedAt = value.Second;

                                break;
                            }
                        case PROPERTY_NAME_METADATA:
                            traktCollectionShowEpisode.Metadata = await metadataObjectReader.ReadObjectAsync(jsonReader, cancellationToken);
                            break;
                        default:
                            await JsonReaderHelper.ReadAndIgnoreInvalidContentAsync(jsonReader, cancellationToken);
                            break;
                    }
                }

                return traktCollectionShowEpisode;
            }

            return await Task.FromResult(default(ITraktCollectionShowEpisode));
        }
    }
}
