﻿namespace TraktApiSharp.Experimental.Requests.Syncs.OAuth
{
    using Objects.Get.Syncs.Playback;
    using System;
    using TraktApiSharp.Requests;

    internal sealed class TraktSyncPlaybackProgressRequest : ATraktSyncListRequest<TraktSyncPlaybackProgressItem>
    {
        internal TraktSyncPlaybackProgressRequest(TraktClient client) : base(client) { }

        public override TraktAuthorizationRequirement AuthorizationRequirement => TraktAuthorizationRequirement.Required;

        public override string UriTemplate
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}