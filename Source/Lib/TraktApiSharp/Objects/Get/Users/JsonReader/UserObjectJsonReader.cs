﻿namespace TraktApiSharp.Objects.Get.Users.JsonReader
{
    using Implementations;
    using Newtonsoft.Json;
    using Objects.JsonReader;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    internal class UserObjectJsonReader : IObjectJsonReader<ITraktUser>
    {
        private const string PROPERTY_NAME_USERNAME = "username";
        private const string PROPERTY_NAME_IS_PRIVATE = "private";
        private const string PROPERTY_NAME_IDS = "ids";
        private const string PROPERTY_NAME_NAME = "name";
        private const string PROPERTY_NAME_IS_VIP = "vip";
        private const string PROPERTY_NAME_IS_VIP_EP = "vip_ep";
        private const string PROPERTY_NAME_JOINED_AT = "joined_at";
        private const string PROPERTY_NAME_LOCATION = "location";
        private const string PROPERTY_NAME_ABOUT = "about";
        private const string PROPERTY_NAME_GENDER = "gender";
        private const string PROPERTY_NAME_AGE = "age";
        private const string PROPERTY_NAME_IMAGES = "images";

        public Task<ITraktUser> ReadObjectAsync(string json, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (string.IsNullOrEmpty(json))
                return Task.FromResult(default(ITraktUser));

            using (var reader = new StringReader(json))
            using (var jsonReader = new JsonTextReader(reader))
            {
                return ReadObjectAsync(jsonReader, cancellationToken);
            }
        }

        public Task<ITraktUser> ReadObjectAsync(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (stream == null)
                return Task.FromResult(default(ITraktUser));

            using (var streamReader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(streamReader))
            {
                return ReadObjectAsync(jsonReader, cancellationToken);
            }
        }

        public async Task<ITraktUser> ReadObjectAsync(JsonTextReader jsonReader, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (jsonReader == null)
                return await Task.FromResult(default(ITraktUser));

            if (await jsonReader.ReadAsync(cancellationToken) && jsonReader.TokenType == JsonToken.StartObject)
            {
                var idsReader = new UserIdsObjectJsonReader();
                var imagesReader = new UserImagesObjectJsonReader();

                ITraktUser traktUser = new TraktUser();

                while (await jsonReader.ReadAsync(cancellationToken) && jsonReader.TokenType == JsonToken.PropertyName)
                {
                    var propertyName = jsonReader.Value.ToString();

                    switch (propertyName)
                    {
                        case PROPERTY_NAME_USERNAME:
                            traktUser.Username = await jsonReader.ReadAsStringAsync(cancellationToken);
                            break;
                        case PROPERTY_NAME_IS_PRIVATE:
                            traktUser.IsPrivate = await jsonReader.ReadAsBooleanAsync(cancellationToken);
                            break;
                        case PROPERTY_NAME_IDS:
                            traktUser.Ids = await idsReader.ReadObjectAsync(jsonReader, cancellationToken);
                            break;
                        case PROPERTY_NAME_NAME:
                            traktUser.Name = await jsonReader.ReadAsStringAsync(cancellationToken);
                            break;
                        case PROPERTY_NAME_IS_VIP:
                            traktUser.IsVIP = await jsonReader.ReadAsBooleanAsync(cancellationToken);
                            break;
                        case PROPERTY_NAME_IS_VIP_EP:
                            traktUser.IsVIP_EP = await jsonReader.ReadAsBooleanAsync(cancellationToken);
                            break;
                        case PROPERTY_NAME_JOINED_AT:
                            {
                                var value = await JsonReaderHelper.ReadDateTimeValueAsync(jsonReader, cancellationToken);

                                if (value.First)
                                    traktUser.JoinedAt = value.Second;

                                break;
                            }
                        case PROPERTY_NAME_LOCATION:
                            traktUser.Location = await jsonReader.ReadAsStringAsync(cancellationToken);
                            break;
                        case PROPERTY_NAME_ABOUT:
                            traktUser.About = await jsonReader.ReadAsStringAsync(cancellationToken);
                            break;
                        case PROPERTY_NAME_GENDER:
                            traktUser.Gender = await jsonReader.ReadAsStringAsync(cancellationToken);
                            break;
                        case PROPERTY_NAME_AGE:
                            traktUser.Age = await jsonReader.ReadAsInt32Async(cancellationToken);
                            break;
                        case PROPERTY_NAME_IMAGES:
                            traktUser.Images = await imagesReader.ReadObjectAsync(jsonReader, cancellationToken);
                            break;
                        default:
                            await JsonReaderHelper.ReadAndIgnoreInvalidContentAsync(jsonReader, cancellationToken);
                            break;
                    }
                }

                return traktUser;
            }

            return await Task.FromResult(default(ITraktUser));
        }
    }
}
