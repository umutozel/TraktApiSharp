﻿namespace TraktApiSharp.Objects.Post.Responses.Implementations
{
    using Get.Seasons;

    public class TraktPostResponseNotFoundSeason : ITraktPostResponseNotFoundSeason
    {
        public ITraktSeasonIds Ids { get; set; }
    }
}
