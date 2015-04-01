using HotDogLover.dal;
using HotDogLover.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotDogLover.Services
{
    public class ProfileService : IProfileService
    {
        private hotdogEntities db = new hotdogEntities();

        public void Add(Models.Profile profile)
        {
            throw new NotImplementedException();
        }

        public void AddDog(Models.Profile profile, Models.HotDog dog)
        {
            throw new NotImplementedException();
        }

        public Models.Profile Get(int id)
        {
            var profile = db.Profiles.Find(id);
            var hotdog = db.HotDogs.Find(profile.HotDogID);
            Models.HotDog modelHotDog = MappingUtil.hotDogDal2Model(hotdog);

            Models.Profile modelProfile = new Models.Profile() { 
                Bio = profile.Bio,
                Name = profile.Name,
                Picture = profile.Picture,
                ProfileID = (int)profile.ProfileID,
                FavoriteHotDog = modelHotDog,
                HotDogList = MappingUtil.hotDogDal2Model(profile.HotDogs)
            };
            return modelProfile;
        }

        public List<Models.Profile> ListAll()
        {
            var profiles = db.Profiles.ToList();

            List<Models.Profile> modelProfiles = new List<Models.Profile>();
            foreach (Profile profile in profiles) {
                Models.Profile modelProfile = new Models.Profile()
                {
                    Bio = profile.Bio,
                    Name = profile.Name,
                    Picture = profile.Picture,
                    ProfileID = (int)profile.ProfileID
                };
                modelProfiles.Add(modelProfile);
            }

            return modelProfiles;
        }

        public void Remove(Models.Profile profile)
        {
            throw new NotImplementedException();
        }

        public void Update(Models.Profile profile)
        {
            throw new NotImplementedException();
        }
    }
}