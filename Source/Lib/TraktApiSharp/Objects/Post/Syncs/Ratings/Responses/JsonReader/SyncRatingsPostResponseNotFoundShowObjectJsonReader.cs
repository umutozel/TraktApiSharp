﻿namespace TraktApiSharp.Objects.Post.Syncs.Ratings.Responses.JsonReader
{
    using Get.Shows.JsonReader;
    using Implementations;
    using Newtonsoft.Json;
    using Objects.JsonReader;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    internal class SyncRatingsPostResponseNotFoundShowObjectJsonReader : IObjectJsonReader<ITraktSyncRatingsPostResponseNotFoundShow>
    {
        private const string PROPERTY_NAME_RATING = "rating";
        private const string PROPERTY_NAME_IDS = "ids";

        public Task<ITraktSyncRatingsPostResponseNotFoundShow> ReadObjectAsync(string json, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (string.IsNullOrEmpty(json))
                return Task.FromResult(default(ITraktSyncRatingsPostResponseNotFoundShow));

            using (var reader = new StringReader(json))
            using (var jsonReader = new JsonTextReader(reader))
            {
                return ReadObjectAsync(jsonReader, cancellationToken);
            }
        }

        public Task<ITraktSyncRatingsPostResponseNotFoundShow> ReadObjectAsync(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (stream == null)
                return Task.FromResult(default(ITraktSyncRatingsPostResponseNotFoundShow));

            using (var streamReader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(streamReader))
            {
                return ReadObjectAsync(jsonReader, cancellationToken);
            }
        }

        public async Task<ITraktSyncRatingsPostResponseNotFoundShow> ReadObjectAsync(JsonTextReader jsonReader, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (jsonReader == null)
                return await Task.FromResult(default(ITraktSyncRatingsPostResponseNotFoundShow));

            if (await jsonReader.ReadAsync(cancellationToken) && jsonReader.TokenType == JsonToken.StartObject)
            {
                var showIdsReader = new ShowIdsObjectJsonReader();
                ITraktSyncRatingsPostResponseNotFoundShow syncRatingsPostResponseNotFoundShow = new TraktSyncRatingsPostResponseNotFoundShow();

                while (await jsonReader.ReadAsync(cancellationToken) && jsonReader.TokenType == JsonToken.PropertyName)
                {
                    var propertyName = jsonReader.Value.ToString();

                    switch (propertyName)
                    {
                        case PROPERTY_NAME_RATING:
                            syncRatingsPostResponseNotFoundShow.Rating = await jsonReader.ReadAsInt32Async(cancellationToken);
                            break;
                        case PROPERTY_NAME_IDS:
                            syncRatingsPostResponseNotFoundShow.Ids = await showIdsReader.ReadObjectAsync(jsonReader, cancellationToken);
                            break;
                        default:
                            await JsonReaderHelper.ReadAndIgnoreInvalidContentAsync(jsonReader, cancellationToken);
                            break;
                    }
                }

                return syncRatingsPostResponseNotFoundShow;
            }

            return await Task.FromResult(default(ITraktSyncRatingsPostResponseNotFoundShow));
        }
    }
}
