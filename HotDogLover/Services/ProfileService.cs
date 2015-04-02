using HotDogLover.dal;
using HotDogLover.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotDogLover.Services
{
    public class ProfileService : IProfileService
    {
        private hotdogEntities db = new hotdogEntities();

        public List<Models.Profile> ListAll()
        {
            List<Models.Profile> modelProfiles = new List<Models.Profile>();
            var profiles = db.Profiles.ToList();
            foreach (dal.Profile profile in profiles) {
                Models.Profile modelProfile = new Models.Profile()
                {
                    Bio= profile.Bio,
                    FavoriteHotDog = new Models.HotDog(),
                    HotDogList = new List<Models.HotDog>(),
                    Name = profile.Name,
                    Picture = profile.Picture,
                    ProfileID = (int)profile.ProfileID
                };
                modelProfiles.Add(modelProfile);
            }

            return modelProfiles;
        }

        public Models.Profile Get(int id)
        {
            if (id == 0) {
                return new Models.Profile();
            }

            Profile profile = db.Profiles.Find(id);
            Models.Profile modelProfile = new Models.Profile() {
                Bio = profile.Bio,
                FavoriteHotDog = ViewModelUtil.MapHotDogDal2View(db.HotDogs.Find(profile.HotDogID)),
                HotDogList = ViewModelUtil.MapHotDogDal2View(profile.HotDogs),
                Name = profile.Name,
                Picture = profile.Picture,
                ProfileID = (int)profile.ProfileID
            };
            return modelProfile;
        }


        public void Add(Models.Profile profile)
        {
            throw new NotImplementedException();
        }

        public void AddDog(Models.Profile profile, Models.HotDog dog)
        {
            throw new NotImplementedException();
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