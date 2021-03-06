﻿namespace TraktApiSharp.Requests.Scrobbles.OAuth
{
    using Base;
    using System.Collections.Generic;

    internal sealed class ScrobblePauseRequest<TResponseContentType, TRequestBodyType> : APostRequest<TResponseContentType, TRequestBodyType>
    {
        public override TRequestBodyType RequestBody { get; set; }

        public override string UriTemplate => "scrobble/pause";

        public override IDictionary<string, object> GetUriPathParameters() => new Dictionary<string, object>();
    }
}
