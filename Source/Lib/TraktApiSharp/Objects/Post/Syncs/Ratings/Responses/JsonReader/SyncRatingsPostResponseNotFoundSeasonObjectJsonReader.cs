﻿namespace TraktApiSharp.Objects.Post.Syncs.Ratings.Responses.JsonReader
{
    using Get.Seasons.JsonReader;
    using Implementations;
    using Newtonsoft.Json;
    using Objects.JsonReader;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    internal class SyncRatingsPostResponseNotFoundSeasonObjectJsonReader : IObjectJsonReader<ITraktSyncRatingsPostResponseNotFoundSeason>
    {
        private const string PROPERTY_NAME_RATING = "rating";
        private const string PROPERTY_NAME_IDS = "ids";

        public Task<ITraktSyncRatingsPostResponseNotFoundSeason> ReadObjectAsync(string json, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (string.IsNullOrEmpty(json))
                return Task.FromResult(default(ITraktSyncRatingsPostResponseNotFoundSeason));

            using (var reader = new StringReader(json))
            using (var jsonReader = new JsonTextReader(reader))
            {
                return ReadObjectAsync(jsonReader, cancellationToken);
            }
        }

        public Task<ITraktSyncRatingsPostResponseNotFoundSeason> ReadObjectAsync(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (stream == null)
                return Task.FromResult(default(ITraktSyncRatingsPostResponseNotFoundSeason));

            using (var streamReader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(streamReader))
            {
                return ReadObjectAsync(jsonReader, cancellationToken);
            }
        }

        public async Task<ITraktSyncRatingsPostResponseNotFoundSeason> ReadObjectAsync(JsonTextReader jsonReader, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (jsonReader == null)
                return await Task.FromResult(default(ITraktSyncRatingsPostResponseNotFoundSeason));

            if (await jsonReader.ReadAsync(cancellationToken) && jsonReader.TokenType == JsonToken.StartObject)
            {
                var seasonIdsReader = new SeasonIdsObjectJsonReader();
                ITraktSyncRatingsPostResponseNotFoundSeason syncRatingsPostResponseNotFoundSeason = new TraktSyncRatingsPostResponseNotFoundSeason();

                while (await jsonReader.ReadAsync(cancellationToken) && jsonReader.TokenType == JsonToken.PropertyName)
                {
                    var propertyName = jsonReader.Value.ToString();

                    switch (propertyName)
                    {
                        case PROPERTY_NAME_RATING:
                            syncRatingsPostResponseNotFoundSeason.Rating = await jsonReader.ReadAsInt32Async(cancellationToken);
                            break;
                        case PROPERTY_NAME_IDS:
                            syncRatingsPostResponseNotFoundSeason.Ids = await seasonIdsReader.ReadObjectAsync(jsonReader, cancellationToken);
                            break;
                        default:
                            await JsonReaderHelper.ReadAndIgnoreInvalidContentAsync(jsonReader, cancellationToken);
                            break;
                    }
                }

                return syncRatingsPostResponseNotFoundSeason;
            }

            return await Task.FromResult(default(ITraktSyncRatingsPostResponseNotFoundSeason));
        }
    }
}
