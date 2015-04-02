using System;
namespace HotDogLover.Services
{
    public interface IProfileService
    {
        void Add(HotDogLover.Models.Profile profile);
        void AddDog(HotDogLover.Models.Profile profile, HotDogLover.Models.HotDog dog);
        HotDogLover.Models.Profile Get(int id);
        System.Collections.Generic.List<HotDogLover.Models.Profile> ListAll();
        void Remove(HotDogLover.Models.Profile profile);
        void Update(HotDogLover.Models.Profile profile);
    }
}
