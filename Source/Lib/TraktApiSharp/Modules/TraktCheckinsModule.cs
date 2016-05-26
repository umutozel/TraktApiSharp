﻿namespace TraktApiSharp.Modules
{
    using Objects.Basic;
    using Objects.Get.Movies;
    using Objects.Get.Shows;
    using Objects.Get.Shows.Episodes;
    using Objects.Post.Checkins;
    using Objects.Post.Checkins.Responses;
    using Requests.WithOAuth.Checkins;
    using System;
    using System.Threading.Tasks;

    public class TraktCheckinsModule : TraktBaseModule
    {
        public TraktCheckinsModule(TraktClient client) : base(client) { }

        public async Task<TraktMovieCheckinPostResponse> CheckinMovieAsync(TraktMovie movie, string appVersion, DateTime appBuildDate,
                                                                           string message = null, TraktSharing sharing = null,
                                                                           string foursquareVenueID = null, string foursquareVenueName = null)
        {
            Validate(movie, appVersion);

            return await QueryAsync(new TraktCheckinRequest<TraktMovieCheckinPostResponse, TraktMovieCheckinPost>(Client)
            {
                RequestBody = new TraktMovieCheckinPost
                {
                    Movie = new TraktMovie
                    {
                        Title = movie.Title,
                        Year = movie.Year,
                        Ids = movie.Ids
                    },
                    Message = message,
                    Sharing = sharing,
                    FoursquareVenueId = foursquareVenueID,
                    FoursquareVenueName = foursquareVenueName,
                    AppVersion = appVersion,
                    AppDate = appBuildDate.ToString("yyyy-MM-dd")
                }
            });
        }

        public async Task<TraktEpisodeCheckinPostResponse> CheckinEpisodeAsync(TraktEpisode episode, string appVersion, DateTime appBuildDate,
                                                                               string message = null, TraktSharing sharing = null,
                                                                               string foursquareVenueID = null, string foursquareVenueName = null)
        {
            Validate(episode, appVersion);

            return await QueryAsync(new TraktCheckinRequest<TraktEpisodeCheckinPostResponse, TraktEpisodeCheckinPost>(Client)
            {
                RequestBody = new TraktEpisodeCheckinPost
                {
                    Episode = new TraktEpisode
                    {
                        Ids = episode.Ids,
                        SeasonNumber = episode.SeasonNumber,
                        Number = episode.Number
                    },
                    Show = null,
                    Message = message,
                    Sharing = sharing,
                    FoursquareVenueId = foursquareVenueID,
                    FoursquareVenueName = foursquareVenueName,
                    AppVersion = appVersion,
                    AppDate = appBuildDate.ToString("yyyy-MM-dd")
                }
            });
        }

        public async Task<TraktEpisodeCheckinPostResponse> CheckinEpisodeAsync(TraktEpisode episode, TraktShow show,
                                                                               string appVersion, DateTime appBuildDate,
                                                                               string message = null, TraktSharing sharing = null,
                                                                               string foursquareVenueID = null, string foursquareVenueName = null)
        {
            Validate(episode, show, appVersion);

            return await QueryAsync(new TraktCheckinRequest<TraktEpisodeCheckinPostResponse, TraktEpisodeCheckinPost>(Client)
            {
                RequestBody = new TraktEpisodeCheckinPost
                {
                    Episode = new TraktEpisode
                    {
                        Ids = episode.Ids,
                        SeasonNumber = episode.SeasonNumber,
                        Number = episode.Number
                    },
                    Show = new TraktShow { Title = show.Title },
                    Message = message,
                    Sharing = sharing,
                    FoursquareVenueId = foursquareVenueID,
                    FoursquareVenueName = foursquareVenueName,
                    AppVersion = appVersion,
                    AppDate = appBuildDate.ToString("yyyy-MM-dd")
                }
            });
        }

        public async Task DeleteActiveCheckinsAsync()
        {
            await QueryAsync(new TraktCheckinsDeleteRequest(Client));
        }

        private void Validate(TraktMovie movie, string appVersion)
        {
            if (movie == null)
                throw new ArgumentNullException("movie", "movie instance must not be null");

            if (string.IsNullOrEmpty(movie.Title))
                throw new ArgumentException("movie title not valid", "movie");

            if (movie.Year <= 0)
                throw new ArgumentException("movie year not valid", "movie");

            if (movie.Ids == null)
                throw new ArgumentNullException("movie.Ids", "movie.Ids must not be null");

            if (!movie.Ids.HasAnyId)
                throw new ArgumentException("movie.Ids have no valid id", "movie");

            if (string.IsNullOrEmpty(appVersion))
                throw new ArgumentException("app version not valid", "appVersion");
        }

        private void Validate(TraktEpisode episode, string appVersion)
        {
            if (episode == null)
                throw new ArgumentNullException("episode", "episode instance must not be null");

            if (episode.Ids == null)
                throw new ArgumentNullException("episode.Ids", "episode.Ids must not be null");

            if (!episode.Ids.HasAnyId)
                throw new ArgumentException("episode.Ids have no valid id", "episode");

            if (episode.SeasonNumber < 0)
                throw new ArgumentException("episode season number not valid", "episode");

            if (episode.Number < 0)
                throw new ArgumentException("episode number not valid", "episode");

            if (string.IsNullOrEmpty(appVersion))
                throw new ArgumentException("app version not valid", "appVersion");
        }

        private void Validate(TraktEpisode episode, TraktShow show, string appVersion)
        {
            Validate(episode, appVersion);

            if (show == null)
                throw new ArgumentNullException("show", "show instance must not be null");

            if (string.IsNullOrEmpty(show.Title))
                throw new ArgumentException("show title not valid", "show");
        }
    }
}