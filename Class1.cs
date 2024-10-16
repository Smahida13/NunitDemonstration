using System.Xml.Linq;
    namespace NUnitDemonstration
    {
    //Surushti Mahida
        public static class Triangle
        {
            public static string ValidTriangle(int firstAngle, int secondAngle, int
            thirdAngle)
            {
                string result;
                if ((firstAngle + secondAngle - thirdAngle) == 90)
                {
                    result = "The triangle is rightangle.";
                }
                else
                {
                    result = "The triangle is NOT rightangle.";
                }
                return result;
            }
        }
    }


