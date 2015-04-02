using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotDogLover.Utils
{
    public class ViewModelUtil
    {
        internal static Models.HotDog MapHotDogDal2View(dal.HotDog hotDog)
        {
            return new Models.HotDog() { 
                HotDogID=(int)hotDog.HotDogID,
                HotDogName=hotDog.Name,
                LastPlaceAte=hotDog.LastPlaceAte,
                LastTimeAte=hotDog.LastAte,
                Rating=5
            };
        }

        internal static List<Models.HotDog> MapHotDogDal2View(ICollection<dal.HotDog> hotdogs)
        {
            List<Models.HotDog>modelHotdogs = new List<Models.HotDog>(); 
            foreach (dal.HotDog hotDog in hotdogs) { 
                Models.HotDog modelHotdog = new Models.HotDog(){
                    HotDogID=(int)hotDog.HotDogID,
                    HotDogName=hotDog.Name,
                    LastPlaceAte=hotDog.LastPlaceAte,
                    LastTimeAte=hotDog.LastAte,
                    Rating=5
                };
                modelHotdogs.Add(modelHotdog);
            }
            return modelHotdogs;
        }
    }
}