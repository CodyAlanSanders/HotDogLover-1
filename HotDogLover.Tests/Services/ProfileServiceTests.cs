using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotDogLover.Services;
using HotDogLover.Models;
using System.Collections.Generic;

namespace HotDogLover.Tests.Services
{
    [TestClass]
    public class ProfileServiceTests
    {
        [TestMethod]
        public void GetAllProfiles()
        {
            ProfileService profileService = new ProfileService();
            List<Profile> profiles = profileService.ListAll();
            Assert.IsNotNull(profiles);
            Assert.AreEqual(3, profiles.Count);
        }
        [TestMethod]
        public void GetProfile()
        {
            ProfileService profileService = new ProfileService();
            Profile profile = profileService.Get(1);
            Assert.IsNotNull(profile);
            Assert.AreEqual("Wesley Reisz", profile.Name);
            Assert.AreEqual(3, profile.HotDogList.Count);
        }
    }
}
