using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Helper
{
    public static class Bonus
    {

        public static int HasBonus(int work)
        {
            if (work <= 50)
            {
                return 1;
            }
            return 2;
        }
    }

    public static class Learn
    {
        public static bool HasCertificateAndReturnBonus(string val)
        {
            if (val == ".NET")
            {
                return true;
            }
            return false;
        }
    }
}
