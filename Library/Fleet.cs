using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class Fleet
    {
        static int maxFlights = 7;
        static int maxPlanes = 7;

        public static List<Airplane> airplanes;
        public static int MaxFlights => maxFlights;

        public static int MaxPlanes => maxPlanes;

        static Fleet()
        {
            //--------------------------- AIRPLANE 1
                        
            Airplane plane = new Airplane("Do 17-A1", 50, 1, 2000, false, false, "do_17z_7.png");

            //--------------------------- AIRPLANE 2
                        
            Airplane plane2 = new Airplane("Do 17-X5", 50, 1, 2000, true, true, "do_17z_7.png");

            //--------------------------- AIRPLANE 3
                        
            Airplane plane3 = new Airplane("HE 111-9", 80, 1, 2000, true, true,"he-111h-6.png");

            //--------------------------- AIRPLANE 4
                        
            Airplane plane4 = new Airplane("BF 110-5", 120, 1, 2000, true, true,"bf-110f-2.png");

            //--------------------------- AIRPLANE 5
                        
            Airplane plane5 = new Airplane("HS 129-B", 56, 1, 2000, true, true,"hs-129b-2.png");

            //--------------------------- AIRPLANE 6
                        
            Airplane plane6 = new Airplane("ME 410-Z", 62, 2, 2000, true, true,"me-410a-1_u4.png");

            //--------------------------- AIRPLANE 7
                        
            Airplane plane7 = new Airplane("JU 118-T", 100, 2, 2000, true, true,"ju-188a-2.png");

            //--------------------------- AIRPLANE 8

            Airplane plane8 = new Airplane("Da Plane", 10, 0, 500, false, false);


            airplanes = new List<Airplane>() { plane, plane2, plane3, plane4, plane5, plane6, plane7, plane8 };
        }
    }
}
