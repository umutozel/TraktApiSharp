﻿namespace TraktApiSharp.Tests.Objects.Get.People.Credits.Interfaces
{
    using FluentAssertions;
    using System.Collections.Generic;
    using System.Linq;
    using Traits;
    using TraktApiSharp.Objects.Get.People.Credits;
    using Xunit;

    [Category("Objects.Get.People.Credits.Interfaces")]
    public class ITraktPersonMovieCreditsCrew_Tests
    {
        [Fact]
        public void Test_ITraktPersonMovieCreditsCrew_Is_Interface()
        {
            typeof(ITraktPersonMovieCreditsCrew).IsInterface.Should().BeTrue();
        }

        [Fact]
        public void Test_ITraktPersonMovieCreditsCrew_Has_Production_Property()
        {
            var propertyInfo = typeof(ITraktPersonMovieCreditsCrew).GetProperties().FirstOrDefault(p => p.Name == "Production");

            propertyInfo.CanRead.Should().BeTrue();
            propertyInfo.CanWrite.Should().BeTrue();
            propertyInfo.PropertyType.Should().Be(typeof(IEnumerable<ITraktPersonMovieCreditsCrewItem>));
        }

        [Fact]
        public void Test_ITraktPersonMovieCreditsCrew_Has_Art_Property()
        {
            var propertyInfo = typeof(ITraktPersonMovieCreditsCrew).GetProperties().FirstOrDefault(p => p.Name == "Art");

            propertyInfo.CanRead.Should().BeTrue();
            propertyInfo.CanWrite.Should().BeTrue();
            propertyInfo.PropertyType.Should().Be(typeof(IEnumerable<ITraktPersonMovieCreditsCrewItem>));
        }

        [Fact]
        public void Test_ITraktPersonMovieCreditsCrew_Has_Crew_Property()
        {
            var propertyInfo = typeof(ITraktPersonMovieCreditsCrew).GetProperties().FirstOrDefault(p => p.Name == "Crew");

            propertyInfo.CanRead.Should().BeTrue();
            propertyInfo.CanWrite.Should().BeTrue();
            propertyInfo.PropertyType.Should().Be(typeof(IEnumerable<ITraktPersonMovieCreditsCrewItem>));
        }

        [Fact]
        public void Test_ITraktPersonMovieCreditsCrew_Has_CostumeAndMakeup_Property()
        {
            var propertyInfo = typeof(ITraktPersonMovieCreditsCrew).GetProperties().FirstOrDefault(p => p.Name == "CostumeAndMakeup");

            propertyInfo.CanRead.Should().BeTrue();
            propertyInfo.CanWrite.Should().BeTrue();
            propertyInfo.PropertyType.Should().Be(typeof(IEnumerable<ITraktPersonMovieCreditsCrewItem>));
        }

        [Fact]
        public void Test_ITraktPersonMovieCreditsCrew_Has_Directing_Property()
        {
            var propertyInfo = typeof(ITraktPersonMovieCreditsCrew).GetProperties().FirstOrDefault(p => p.Name == "Directing");

            propertyInfo.CanRead.Should().BeTrue();
            propertyInfo.CanWrite.Should().BeTrue();
            propertyInfo.PropertyType.Should().Be(typeof(IEnumerable<ITraktPersonMovieCreditsCrewItem>));
        }

        [Fact]
        public void Test_ITraktPersonMovieCreditsCrew_Has_Writing_Property()
        {
            var propertyInfo = typeof(ITraktPersonMovieCreditsCrew).GetProperties().FirstOrDefault(p => p.Name == "Writing");

            propertyInfo.CanRead.Should().BeTrue();
            propertyInfo.CanWrite.Should().BeTrue();
            propertyInfo.PropertyType.Should().Be(typeof(IEnumerable<ITraktPersonMovieCreditsCrewItem>));
        }

        [Fact]
        public void Test_ITraktPersonMovieCreditsCrew_Has_Sound_Property()
        {
            var propertyInfo = typeof(ITraktPersonMovieCreditsCrew).GetProperties().FirstOrDefault(p => p.Name == "Sound");

            propertyInfo.CanRead.Should().BeTrue();
            propertyInfo.CanWrite.Should().BeTrue();
            propertyInfo.PropertyType.Should().Be(typeof(IEnumerable<ITraktPersonMovieCreditsCrewItem>));
        }

        [Fact]
        public void Test_ITraktPersonMovieCreditsCrew_Has_Camera_Property()
        {
            var propertyInfo = typeof(ITraktPersonMovieCreditsCrew).GetProperties().FirstOrDefault(p => p.Name == "Camera");

            propertyInfo.CanRead.Should().BeTrue();
            propertyInfo.CanWrite.Should().BeTrue();
            propertyInfo.PropertyType.Should().Be(typeof(IEnumerable<ITraktPersonMovieCreditsCrewItem>));
        }

        [Fact]
        public void Test_ITraktPersonMovieCreditsCrew_Has_Lighting_Property()
        {
            var propertyInfo = typeof(ITraktPersonMovieCreditsCrew).GetProperties().FirstOrDefault(p => p.Name == "Lighting");

            propertyInfo.CanRead.Should().BeTrue();
            propertyInfo.CanWrite.Should().BeTrue();
            propertyInfo.PropertyType.Should().Be(typeof(IEnumerable<ITraktPersonMovieCreditsCrewItem>));
        }

        [Fact]
        public void Test_ITraktPersonMovieCreditsCrew_Has_VisualEffects_Property()
        {
            var propertyInfo = typeof(ITraktPersonMovieCreditsCrew).GetProperties().FirstOrDefault(p => p.Name == "VisualEffects");

            propertyInfo.CanRead.Should().BeTrue();
            propertyInfo.CanWrite.Should().BeTrue();
            propertyInfo.PropertyType.Should().Be(typeof(IEnumerable<ITraktPersonMovieCreditsCrewItem>));
        }

        [Fact]
        public void Test_ITraktPersonMovieCreditsCrew_Has_Editing_Property()
        {
            var propertyInfo = typeof(ITraktPersonMovieCreditsCrew).GetProperties().FirstOrDefault(p => p.Name == "Editing");

            propertyInfo.CanRead.Should().BeTrue();
            propertyInfo.CanWrite.Should().BeTrue();
            propertyInfo.PropertyType.Should().Be(typeof(IEnumerable<ITraktPersonMovieCreditsCrewItem>));
        }
    }
}
