using System;

namespace NumeriPeriodici
{
    public class numeri
    {
        public static bool Example1()
        {
            double a = 1.0 / 10.0;
            double prod = a * 10.0;
            if (prod == 1) 
                return true;
            else
                return false;
        }
        public static bool Example2()
        {
            double a = 1.0 / 10.0;
            double sum = a + a + a + a + a + a + a + a + a + a;
            if (sum == 1)
                return true;  //se si lascia true il test non va a buon fine perchè quando va a fare la somma arriva a sum = 0.99999999999999989	
            else
                return false;
        }
    }
}
