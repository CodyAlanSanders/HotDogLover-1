using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotDogLover.utils
{
    public class MappingUtil
    {
        public static Models.HotDog hotDogDal2Model(dal.HotDog dalHotdog) {
            return new Models.HotDog() { 
                HotDogID=(int)dalHotdog.HotDogID,
                HotDogName=dalHotdog.Name,
                LastPlaceAte=dalHotdog.LastPlaceAte,
                LastTimeAte=dalHotdog.LastAte,
                Rating=5
            };
        }

        public static List<Models.HotDog> hotDogDal2Model(ICollection<dal.HotDog> dalHotdogs)
        {
            List<Models.HotDog>modelHotDogs = new List<Models.HotDog>();
            foreach(dal.HotDog dalHotdog in dalHotdogs){
                Models.HotDog modelHotdog = new Models.HotDog(){
                    HotDogID=(int)dalHotdog.HotDogID,
                    HotDogName=dalHotdog.Name,
                    LastPlaceAte=dalHotdog.LastPlaceAte,
                    LastTimeAte=dalHotdog.LastAte,
                    Rating=5 
                };
                modelHotDogs.Add(modelHotdog); ;
            }
            return modelHotDogs;
        }
    }
}