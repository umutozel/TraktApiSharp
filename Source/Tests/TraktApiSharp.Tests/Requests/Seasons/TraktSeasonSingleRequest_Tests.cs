﻿namespace TraktApiSharp.Tests.Requests.Seasons
{
    using FluentAssertions;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using TraktApiSharp.Experimental.Requests.Interfaces;
    using TraktApiSharp.Experimental.Requests.Seasons;
    using TraktApiSharp.Objects.Get.Shows.Episodes;
    using TraktApiSharp.Requests.Params;
    using TraktApiSharp.Tests.Traits;
    using Xunit;

    [Category("Requests.Seasons")]
    public class TraktSeasonSingleRequest_Tests
    {
        [Fact]
        public void Test_TraktSeasonSingleRequest_IsNotAbstract()
        {
            typeof(TraktSeasonSingleRequest).IsAbstract.Should().BeFalse();
        }

        [Fact]
        public void Test_TraktSeasonSingleRequest_IsSealed()
        {
            typeof(TraktSeasonSingleRequest).IsSealed.Should().BeTrue();
        }

        [Fact]
        public void Test_TraktSeasonSingleRequest_Inherits_ATraktSeasonRequest_1()
        {
            typeof(TraktSeasonSingleRequest).IsSubclassOf(typeof(ATraktSeasonRequest<TraktEpisode>)).Should().BeTrue();
        }

        [Fact]
        public void Test_TraktSeasonSingleRequest_Implements_ITraktSupportsExtendedInfo_Interface()
        {
            typeof(TraktSeasonSingleRequest).GetInterfaces().Should().Contain(typeof(ITraktSupportsExtendedInfo));
        }

        [Fact]
        public void Test_TraktSeasonSingleRequest_Has_Valid_UriTemplate()
        {
            var request = new TraktSeasonSingleRequest();
            request.UriTemplate.Should().Be("shows/{id}/seasons/{season}{?extended,translations}");
        }

        [Fact]
        public void Test_TraktSeasonSingleRequest_Has_TranslationLanguageCode_Property()
        {
            var sortingPropertyInfo = typeof(TraktSeasonSingleRequest)
                    .GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                    .Where(p => p.Name == "TranslationLanguageCode")
                    .FirstOrDefault();

            sortingPropertyInfo.CanRead.Should().BeTrue();
            sortingPropertyInfo.CanWrite.Should().BeTrue();
            sortingPropertyInfo.PropertyType.Should().Be(typeof(string));
        }

        [Fact]
        public void Test_TraktSeasonSingleRequest_Validate_Throws_Exceptions()
        {
            // id is null
            var request = new TraktSeasonSingleRequest();

            Action act = () => request.Validate();
            act.ShouldThrow<ArgumentNullException>();

            // empty id
            request = new TraktSeasonSingleRequest { Id = string.Empty };

            act = () => request.Validate();
            act.ShouldThrow<ArgumentException>();

            // id with spaces
            request = new TraktSeasonSingleRequest { Id = "invalid id" };

            act = () => request.Validate();
            act.ShouldThrow<ArgumentException>();
        }

        [Theory, ClassData(typeof(TraktSeasonSingleRequest_TestData))]
        public void Test_TraktSeasonSingleRequest_Returns_Valid_UriPathParameters(IDictionary<string, object> values,
                                                                                  IDictionary<string, object> expected)
        {
            values.Should().NotBeNull().And.HaveCount(expected.Count);

            if (expected.Count > 0)
                values.Should().Contain(expected);
        }

        public class TraktSeasonSingleRequest_TestData : IEnumerable<object[]>
        {
            private const string _id = "123";
            private const uint _seasonNumber = 1;
            private static readonly TraktExtendedInfo _extendedInfo = new TraktExtendedInfo { Full = true };
            private const string _languageCode = "en";

            private static readonly TraktSeasonSingleRequest _request1 = new TraktSeasonSingleRequest
            {
                Id = _id,
                SeasonNumber = _seasonNumber
            };

            private static readonly TraktSeasonSingleRequest _request2 = new TraktSeasonSingleRequest
            {
                Id = _id,
                SeasonNumber = _seasonNumber,
                ExtendedInfo = _extendedInfo
            };

            private static readonly TraktSeasonSingleRequest _request3 = new TraktSeasonSingleRequest
            {
                Id = _id,
                SeasonNumber = _seasonNumber,
                TranslationLanguageCode = _languageCode
            };

            private static readonly TraktSeasonSingleRequest _request4 = new TraktSeasonSingleRequest
            {
                Id = _id,
                SeasonNumber = _seasonNumber,
                ExtendedInfo = _extendedInfo,
                TranslationLanguageCode = _languageCode
            };

            private static readonly List<object[]> _data = new List<object[]>();

            public TraktSeasonSingleRequest_TestData()
            {
                SetupPathParamters();
            }

            private void SetupPathParamters()
            {
                var strSeasonNumber = _seasonNumber.ToString();
                var strExtendedInfo = _extendedInfo.ToString();

                _data.Add(new object[] { _request1.GetUriPathParameters(), new Dictionary<string, object>
                    {
                        ["id"] = _id,
                        ["season"] = strSeasonNumber
                    }});

                _data.Add(new object[] { _request2.GetUriPathParameters(), new Dictionary<string, object>
                    {
                        ["id"] = _id,
                        ["season"] = strSeasonNumber,
                        ["extended"] = strExtendedInfo
                    }});

                _data.Add(new object[] { _request3.GetUriPathParameters(), new Dictionary<string, object>
                    {
                        ["id"] = _id,
                        ["season"] = strSeasonNumber,
                        ["translations"] = _languageCode
                    }});

                _data.Add(new object[] { _request4.GetUriPathParameters(), new Dictionary<string, object>
                    {
                        ["id"] = _id,
                        ["season"] = strSeasonNumber,
                        ["extended"] = strExtendedInfo,
                        ["translations"] = _languageCode
                    }});
            }

            public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}