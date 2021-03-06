﻿namespace TraktApiSharp.Tests.Requests.Parameters
{
    using FluentAssertions;
    using System.Linq;
    using System.Reflection;
    using Traits;
    using TraktApiSharp.Requests.Parameters;
    using Xunit;

    [Category("Requests.Parameters")]
    public class TraktExtendedInfo_Tests
    {
        [Fact]
        public void Test_TraktExtendedInfo_Has_Metadata_Property()
        {
            var propertyInfo = typeof(TraktExtendedInfo)
                    .GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                    .Where(p => p.Name == "Metadata")
                    .FirstOrDefault();

            propertyInfo.CanRead.Should().BeTrue();
            propertyInfo.CanWrite.Should().BeTrue();
            propertyInfo.PropertyType.Should().Be(typeof(bool));
        }

        [Fact]
        public void Test_TraktExtendedInfo_Has_Full_Property()
        {
            var propertyInfo = typeof(TraktExtendedInfo)
                    .GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                    .Where(p => p.Name == "Full")
                    .FirstOrDefault();

            propertyInfo.CanRead.Should().BeTrue();
            propertyInfo.CanWrite.Should().BeTrue();
            propertyInfo.PropertyType.Should().Be(typeof(bool));
        }

        [Fact]
        public void Test_TraktExtendedInfo_Has_NoSeasons_Property()
        {
            var propertyInfo = typeof(TraktExtendedInfo)
                    .GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                    .Where(p => p.Name == "NoSeasons")
                    .FirstOrDefault();

            propertyInfo.CanRead.Should().BeTrue();
            propertyInfo.CanWrite.Should().BeTrue();
            propertyInfo.PropertyType.Should().Be(typeof(bool));
        }

        [Fact]
        public void Test_TraktExtendedInfo_Has_Episodes_Property()
        {
            var propertyInfo = typeof(TraktExtendedInfo)
                    .GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                    .Where(p => p.Name == "Episodes")
                    .FirstOrDefault();

            propertyInfo.CanRead.Should().BeTrue();
            propertyInfo.CanWrite.Should().BeTrue();
            propertyInfo.PropertyType.Should().Be(typeof(bool));
        }

        [Fact]
        public void Test_TraktExtendedInfo_Default_Constructor()
        {
            var extendedInfo = new TraktExtendedInfo();

            extendedInfo.Metadata.Should().BeFalse();
            extendedInfo.Full.Should().BeFalse();
            extendedInfo.NoSeasons.Should().BeFalse();
            extendedInfo.Episodes.Should().BeFalse();
        }

        [Fact]
        public void Test_TraktExtendedInfo_SetMetadata()
        {
            var extendedInfo = new TraktExtendedInfo();

            extendedInfo.SetMetadata().Should().BeSameAs(extendedInfo);

            extendedInfo.Metadata.Should().BeTrue();
            extendedInfo.Full.Should().BeFalse();
            extendedInfo.NoSeasons.Should().BeFalse();
            extendedInfo.Episodes.Should().BeFalse();

            extendedInfo.ResetMetadata().Should().BeSameAs(extendedInfo);

            extendedInfo.Metadata.Should().BeFalse();
            extendedInfo.Full.Should().BeFalse();
            extendedInfo.NoSeasons.Should().BeFalse();
            extendedInfo.Episodes.Should().BeFalse();
        }

        [Fact]
        public void Test_TraktExtendedInfo_SetFull()
        {
            var extendedInfo = new TraktExtendedInfo();

            extendedInfo.SetFull().Should().BeSameAs(extendedInfo);

            extendedInfo.Metadata.Should().BeFalse();
            extendedInfo.Full.Should().BeTrue();
            extendedInfo.NoSeasons.Should().BeFalse();
            extendedInfo.Episodes.Should().BeFalse();

            extendedInfo.ResetFull().Should().BeSameAs(extendedInfo);

            extendedInfo.Metadata.Should().BeFalse();
            extendedInfo.Full.Should().BeFalse();
            extendedInfo.NoSeasons.Should().BeFalse();
            extendedInfo.Episodes.Should().BeFalse();
        }

        [Fact]
        public void Test_TraktExtendedInfo_SetNoSeasons()
        {
            var extendedInfo = new TraktExtendedInfo();

            extendedInfo.SetNoSeasons().Should().BeSameAs(extendedInfo);

            extendedInfo.Metadata.Should().BeFalse();
            extendedInfo.Full.Should().BeFalse();
            extendedInfo.NoSeasons.Should().BeTrue();
            extendedInfo.Episodes.Should().BeFalse();

            extendedInfo.ResetNoSeasons().Should().BeSameAs(extendedInfo);

            extendedInfo.Metadata.Should().BeFalse();
            extendedInfo.Full.Should().BeFalse();
            extendedInfo.NoSeasons.Should().BeFalse();
            extendedInfo.Episodes.Should().BeFalse();
        }

        [Fact]
        public void Test_TraktExtendedInfo_SetEpisodes()
        {
            var extendedInfo = new TraktExtendedInfo();

            extendedInfo.SetEpisodes().Should().BeSameAs(extendedInfo);

            extendedInfo.Metadata.Should().BeFalse();
            extendedInfo.Full.Should().BeFalse();
            extendedInfo.NoSeasons.Should().BeFalse();
            extendedInfo.Episodes.Should().BeTrue();

            extendedInfo.ResetEpisodes().Should().BeSameAs(extendedInfo);

            extendedInfo.Metadata.Should().BeFalse();
            extendedInfo.Full.Should().BeFalse();
            extendedInfo.NoSeasons.Should().BeFalse();
            extendedInfo.Episodes.Should().BeFalse();
        }

        [Fact]
        public void Test_TraktExtendedInfo_HasAnySet()
        {
            var extendedInfo = new TraktExtendedInfo();

            extendedInfo.HasAnySet.Should().BeFalse();

            extendedInfo.Metadata = true;
            extendedInfo.HasAnySet.Should().BeTrue();

            extendedInfo.Reset();
            extendedInfo.Full = true;
            extendedInfo.HasAnySet.Should().BeTrue();

            extendedInfo.Reset();
            extendedInfo.NoSeasons = true;
            extendedInfo.HasAnySet.Should().BeTrue();

            extendedInfo.Reset();
            extendedInfo.Episodes = true;
            extendedInfo.HasAnySet.Should().BeTrue();
        }

        [Fact]
        public void Test_TraktExtendedInfo_Resolve()
        {
            var extendedInfo = new TraktExtendedInfo();

            extendedInfo.Resolve().Should().NotBeNull().And.BeEmpty();

            extendedInfo.SetMetadata();
            extendedInfo.Resolve().Should().NotBeNull().And.HaveCount(1).And.Contain("metadata");

            extendedInfo.SetFull();
            extendedInfo.Resolve().Should().NotBeNull().And.HaveCount(2).And.Contain("metadata", "full");

            extendedInfo.SetNoSeasons();
            extendedInfo.Resolve().Should().NotBeNull().And.HaveCount(3).And.Contain("metadata", "full", "noseasons");

            extendedInfo.SetEpisodes();
            extendedInfo.Resolve().Should().NotBeNull().And.HaveCount(4).And.Contain("metadata", "full", "noseasons", "episodes");
        }

        [Fact]
        public void Test_TraktExtendedInfo_ToString()
        {
            var extendedInfo = new TraktExtendedInfo();

            extendedInfo.ToString().Should().NotBeNull().And.BeEmpty();

            extendedInfo.SetMetadata();
            extendedInfo.ToString().Should().NotBeNull().And.Be("metadata");

            extendedInfo.SetFull();
            extendedInfo.ToString().Should().NotBeNull().And.Be("metadata,full");

            extendedInfo.SetNoSeasons();
            extendedInfo.ToString().Should().NotBeNull().And.Be("metadata,full,noseasons");

            extendedInfo.SetEpisodes();
            extendedInfo.ToString().Should().NotBeNull().And.Be("metadata,full,noseasons,episodes");
        }
    }
}
