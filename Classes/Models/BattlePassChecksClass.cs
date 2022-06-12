using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Models
{
    static class BattlePassChecksClass
    {
        static DayOfWeek Date = DateTime.Today.DayOfWeek;
        static bool Ores = false;
        static bool Trounces = false;
        static bool Cooking = false;
        static bool Furniture = false;
        static bool CurrencyRealm = false;
        static bool Bountys = false;
        static bool Request = false;

        static void Done(bool CheckList)
        {
            if (CheckList = !false) { CheckList = true; }
        }
        static void Refresh() {
            if(Date == DayOfWeek.Monday) {
                Ores = false; Trounces = false; Cooking = false; Furniture = false; CurrencyRealm = false; Bountys = false; Request = false;

            }
        }

    }
}
