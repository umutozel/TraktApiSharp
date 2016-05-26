﻿namespace TraktApiSharp.Requests.WithOAuth.Users
{
    using Base.Get;
    using Enums;
    using Objects.Basic;
    using Objects.Get.Users.Lists;
    using System.Collections.Generic;

    internal class TraktUserCustomListItemsRequest : TraktGetByIdRequest<TraktListResult<TraktListItem>, TraktListItem>
    {
        internal TraktUserCustomListItemsRequest(TraktClient client) : base(client) { }

        protected override TraktAuthenticationRequirement AuthenticationRequirement => TraktAuthenticationRequirement.Optional;

        internal string Username { get; set; }

        internal TraktListItemType? Type { get; set; }

        protected override IDictionary<string, object> GetUriPathParameters()
        {
            var uriParams = base.GetUriPathParameters();

            uriParams.Add("username", Username);

            if (Type.HasValue && Type.Value != TraktListItemType.Unspecified)
                uriParams.Add("type", Type.Value.AsStringUriParameter());

            return uriParams;
        }

        protected override string UriTemplate => "users/{username}/lists/{id}/items{/type}";

        protected override TraktRequestObjectType? RequestObjectType => TraktRequestObjectType.Lists;

        protected override bool IsListResult => true;
    }
}