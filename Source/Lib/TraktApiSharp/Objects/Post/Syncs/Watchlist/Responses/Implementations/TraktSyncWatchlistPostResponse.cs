﻿namespace TraktApiSharp.Objects.Post.Syncs.Watchlist.Responses.Implementations
{
    using Syncs.Responses;

    /// <summary>
    /// Represents the response for a watchlist post. See also <see cref="TraktSyncWatchlistPost" />.
    /// <para>Contains the number of added, existing and not found movies, shows, seasons and episodes.</para>
    /// </summary>
    public class TraktSyncWatchlistPostResponse : ITraktSyncWatchlistPostResponse
    {
        /// <summary>
        /// A collection containing the number of added movies, shows, seasons and episodes.
        /// <para>Nullable</para>
        /// </summary>
        public ITraktSyncPostResponseGroup Added { get; set; }

        /// <summary>
        /// A collection containing the number of existing movies, shows, seasons and episodes.
        /// <para>Nullable</para>
        /// </summary>
        public ITraktSyncPostResponseGroup Existing { get; set; }

        /// <summary>
        /// A collection containing the ids of movies, shows, seasons and episodes, which were not found.
        /// <para>Nullable</para>
        /// </summary>
        public ITraktSyncPostResponseNotFoundGroup NotFound { get; set; }
    }
}
