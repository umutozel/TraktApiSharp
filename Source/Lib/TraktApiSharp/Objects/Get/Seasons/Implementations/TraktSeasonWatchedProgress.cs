﻿namespace TraktApiSharp.Objects.Get.Seasons.Implementations
{
    using Episodes;
    using System.Collections.Generic;

    /// <summary>Represents the watched progress of a Trakt season.</summary>
    public class TraktSeasonWatchedProgress : TraktSeasonProgress, ITraktSeasonWatchedProgress
    {
        /// <summary>
        /// Gets or sets the watched episodes. See also <seealso cref="ITraktEpisodeWatchedProgress" />.
        /// <para>Nullable</para>
        /// </summary>
        public IEnumerable<ITraktEpisodeWatchedProgress> Episodes { get; set; }
    }
}
