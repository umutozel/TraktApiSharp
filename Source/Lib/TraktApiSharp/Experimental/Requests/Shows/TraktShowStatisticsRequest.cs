﻿namespace TraktApiSharp.Experimental.Requests.Shows
{
    using Base.Get;
    using Interfaces;
    using Objects.Basic;
    using TraktApiSharp.Requests;

    internal sealed class TraktShowStatisticsRequest : ATraktSingleItemGetByIdRequest<TraktStatistics>, ITraktObjectRequest
    {
        internal TraktShowStatisticsRequest(TraktClient client) : base(client) { }

        public override TraktAuthorizationRequirement AuthorizationRequirement => TraktAuthorizationRequirement.NotRequired;

        public override TraktRequestObjectType RequestObjectType => TraktRequestObjectType.Shows;

        public override string UriTemplate => "shows/{id}/stats";
    }
}