using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTemple.April.CarModel
{
    class FuelTank : IFuelTank

    {
        public double MaxCapacity = 100;
        public double MinCapacity = 0;
        public double Capacity => throw new NotImplementedException();

        public void Consume(double amount)
        {
            //double Capacity = 0;
            //try
            //{
            //    Consume = 
            //}

            throw new NotImplementedException();
        }
        //public int DoDivision(int num1, int num2)
//{
//    int result = 0;
//    try
//    {
//        result = num1 / num2;
//    }
//    catch (DivideByZeroException ex)
//    {
//        Console.WriteLine(ex.Message);
//        throw ex;
//    }
//    return result;
//}
//    }


        public void Refuel(double amount)
        {
            throw new NotImplementedException();
        }
    }
}

//public static void Question06()
//{
//    int num1 = 100;
//    int num2 = 0;
//    Week3 w = new Week3();
//    try
//    {
//        int result = w.DoDivision(num1, num2);
//    }
//    catch (Exception)
//    {
//        //An empty catch block is referred to as "swallowing" an exception
//    }

//}

//public int DoDivision(int num1, int num2)
//{
//    int result = 0;
//    try
//    {
//        result = num1 / num2;
//    }
//    catch (DivideByZeroException ex)
//    {
//        Console.WriteLine(ex.Message);
//        throw ex;
//    }
//    return result;
//}
//    }
