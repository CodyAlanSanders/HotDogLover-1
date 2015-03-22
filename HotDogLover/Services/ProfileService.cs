using HotDogLover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotDogLover.Services
{
    public class ProfileService
    {
        private static List<Profile> profiles;
        private static HotDogService hotDogService;
        static ProfileService() {
            hotDogService = new HotDogService();
            profiles = new List<Profile>();

            List<HotDog> myFavs = new List<HotDog>();
            myFavs.Add(hotDogService.Get(1));
            myFavs.Add(hotDogService.Get(2));
            myFavs.Add(hotDogService.Get(3));

            Profile p1 = new Profile() { 
                Name="Wesley Reisz",
                Bio="Bacon ipsum dolor amet brisket shankle ribeye hamburger shoulder alcatra. Leberkas beef turkey, tail pork chop flank porchetta shankle turducken. Pancetta salami frankfurter, leberkas pork chop ham hock shoulder short loin strip steak brisket pork belly capicola ground round spare ribs rump. Andouille alcatra cow pork chop cupim, pancetta capicola shank. Andouille picanha pastrami biltong ham. Meatball sirloin shank cow short loin doner. Pork strip steak boudin ham leberkas fatback. Strip steak pork loin meatloaf shoulder capicola fatback. Strip steak capicola hamburger, ground round kielbasa t-bone ham hock ham. Meatball rump sausage drumstick turkey pastrami filet mignon pig biltong. Jowl kielbasa bacon kevin, jerky filet mignon pork chop chuck chicken beef pig shoulder. Tail alcatra porchetta chicken jowl doner meatball. Tongue shank andouille ribeye, alcatra tail meatball picanha porchetta pancetta pastrami kevin.",
                Picture = "http://www.wesleyreisz.com/images/atsea.jpg",
                ProfileID = 1,
                FavoriteHotDog = hotDogService.Get(1),
                HotDogList = myFavs
            };
            profiles.Add(p1);

            myFavs = new List<HotDog>();
            myFavs.Add(hotDogService.Get(1));
            myFavs.Add(hotDogService.Get(3));

            Profile p2 = new Profile()
            {
                Name = "Bobby Bacon",
                Bio = "Bacon ipsum dolor amet brisket shankle ribeye hamburger shoulder alcatra. Leberkas beef turkey, tail pork chop flank porchetta shankle turducken. Pancetta salami frankfurter, leberkas pork chop ham hock shoulder short loin strip steak brisket pork belly capicola ground round spare ribs rump. Andouille alcatra cow pork chop cupim, pancetta capicola shank. Andouille picanha pastrami biltong ham. Meatball sirloin shank cow short loin doner. Pork strip steak boudin ham leberkas fatback. Strip steak pork loin meatloaf shoulder capicola fatback. Strip steak capicola hamburger, ground round kielbasa t-bone ham hock ham. Meatball rump sausage drumstick turkey pastrami filet mignon pig biltong. Jowl kielbasa bacon kevin, jerky filet mignon pork chop chuck chicken beef pig shoulder. Tail alcatra porchetta chicken jowl doner meatball. Tongue shank andouille ribeye, alcatra tail meatball picanha porchetta pancetta pastrami kevin.",
                Picture = "http://blog.estately.com/assets/kevin-bacon-art-jason-mecier.jpg",
                ProfileID = 2,
                FavoriteHotDog = hotDogService.Get(3),
                HotDogList = myFavs
            };
            profiles.Add(p2);

            myFavs = new List<HotDog>();
            myFavs.Add(hotDogService.Get(2));

            Profile p3 = new Profile()
            {
                Name = "Valorie Vegan",
                Bio = "Bacon ipsum dolor amet brisket shankle ribeye hamburger shoulder alcatra. Leberkas beef turkey, tail pork chop flank porchetta shankle turducken. Pancetta salami frankfurter, leberkas pork chop ham hock shoulder short loin strip steak brisket pork belly capicola ground round spare ribs rump. Andouille alcatra cow pork chop cupim, pancetta capicola shank. Andouille picanha pastrami biltong ham. Meatball sirloin shank cow short loin doner. Pork strip steak boudin ham leberkas fatback. Strip steak pork loin meatloaf shoulder capicola fatback. Strip steak capicola hamburger, ground round kielbasa t-bone ham hock ham. Meatball rump sausage drumstick turkey pastrami filet mignon pig biltong. Jowl kielbasa bacon kevin, jerky filet mignon pork chop chuck chicken beef pig shoulder. Tail alcatra porchetta chicken jowl doner meatball. Tongue shank andouille ribeye, alcatra tail meatball picanha porchetta pancetta pastrami kevin.",
                Picture = "http://delavegart.com/communities/3/000/001/042/293//images/6013306.jpg",
                ProfileID = 3,
                FavoriteHotDog = hotDogService.Get(2),
                HotDogList = myFavs
            };
            profiles.Add(p3);
        }

        public List<Profile> ListAll() {
            return profiles;
        }
        public Profile Get(int id) {
            Profile foundProfile = new Profile();
            foreach (Profile profile in profiles) {
                if (profile.ProfileID == id) {
                    foundProfile = profile;
                }
            }
            return foundProfile;
        }
    }
}