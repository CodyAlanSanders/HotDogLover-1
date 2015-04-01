using System;
namespace HotDogLover.Services
{
    interface IHotDogService
    {
        void Add(HotDogLover.Models.HotDog hotdog);
        HotDogLover.Models.HotDog Get(int id);
        System.Collections.Generic.List<HotDogLover.Models.HotDog> listAll();
        void Remove(HotDogLover.Models.HotDog hotdog);
    }
}
