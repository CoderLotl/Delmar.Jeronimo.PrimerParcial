using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class Fleet
    {
        static int maxFlights = 8;
        static int maxPlanes = 8;
                
        public static int MaxFlights { get => maxFlights; set => maxFlights = value; }
        public static int MaxPlanes { get => maxPlanes; set => maxPlanes = value; }

        public static List<Airplane> GenerateFleet()
        {
            //--------------------------- AIRPLANE 1

            Airplane plane = new Airplane("Do 17-A1", 50, 1, 2000, false, false, "do_17z_7");

            //--------------------------- AIRPLANE 2

            Airplane plane2 = new Airplane("Do 17-X5", 50, 1, 2000, true, true, "do_17z_7");

            //--------------------------- AIRPLANE 3

            Airplane plane3 = new Airplane("HE 111-9", 80, 1, 2000, true, true, "he_111h_6");

            //--------------------------- AIRPLANE 4

            Airplane plane4 = new Airplane("BF 110-5", 120, 1, 2000, true, true, "bf_110f_2");

            //--------------------------- AIRPLANE 5

            Airplane plane5 = new Airplane("HS 129-B", 56, 1, 2000, true, true, "hs_129b_2");

            //--------------------------- AIRPLANE 6

            Airplane plane6 = new Airplane("ME 410-Z", 62, 2, 2000, true, true, "me_410a_1_u4");

            //--------------------------- AIRPLANE 7

            Airplane plane7 = new Airplane("JU 118-T", 100, 2, 2000, true, true, "ju_188a_2");

            //--------------------------- AIRPLANE 8

            Airplane plane8 = new Airplane("Da Plane", 10, 0, 500, false, false);


            return new List<Airplane>() { plane, plane2, plane3, plane4, plane5, plane6, plane7, plane8 };
        }
    }
}
