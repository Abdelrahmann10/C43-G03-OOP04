namespace OOP4_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 -  First Project



            // 1 -  

            //Points3D Point = new Points3D() { NumO1 = 15 , NumO2 = 20 , NumO3 = 25 };
            //Console.WriteLine(Point.ToString());




            // 2 -

            //Points3D PO1 = new Points3D();
            //Points3D PO2 = new Points3D();





            //// 3 -


            //static Points3D ReadFromUser()
            //{
            //    int x, y, z;

            //    while (true)
            //    {
            //        Console.Write(" Enter X coordinate : ");

            //        if (int.TryParse(Console.ReadLine(), out x))
            //            break;
            //        else
            //            Console.WriteLine("Enter a valid Intiger.");
            //    }


            //    while (true)
            //    {
            //        Console.Write(" Enter Y coordinate : ");

            //        if (int.TryParse(Console.ReadLine(), out y))
            //           break;
            //        else
            //            Console.WriteLine(" Enter a valid Intiger.");
            //    }

            //    while (true)
            //    {
            //        Console.Write(" Enter Z coordinate: ");

            //        if (int.TryParse(Console.ReadLine(), out z))
            //            break;
            //        else
            //            Console.WriteLine(" Enter a valid Intiger. ");
            //    }

            //    return new Points3D( x, y, z);
            //}







            //// 4 -

            //if (PO1 == PO2)
            //{
            //    Console.WriteLine(" PO1 Is Equal PO2 ");
            //}
            //else 
            //{
            //    Console.WriteLine(" PO1 is not eqaul PO2 " );
            //}




            // 5 -

            //Points3D[] Arr = { Point , PO1 , PO2 };

            //Array.Sort(Arr);


            #endregion


            #region 2 -  Second Project

            //Console.WriteLine($"Addition Is : {Maths.Add(20, 25)} ");

            //Console.WriteLine($"Subtract Is : {Maths.Subtract(10, 6)} ");

            //Console.WriteLine($"Multiply Is : {Maths.Multiply(15, 3)} ");

            //Console.WriteLine($"Divide Is   : {Maths.DivideBy(0, 5)} ");


            #endregion


            #region 3 -  Third Project

            Duration Duration01 = new Duration(5, 20, 35);
            Duration Duration02 = new Duration(10, 15, 30);
            Duration Duration03 = new Duration(11, 11, 11);


            Console.WriteLine($" DurationO1 :{Duration01.ToString()} ");
            Console.WriteLine($" DurationO2 :{Duration02.ToString()} ");
            Console.WriteLine($" DurationO3 :{Duration03.ToString()} ");

            Console.WriteLine("\n");

            if (Duration01.Equals(Duration02))
            {

                Console.WriteLine(" DurationO1 Is Equal Duration Two ");

            }

            if (Duration01.Equals(Duration03))
            {
                Console.WriteLine(" DurationO1 Is Equal DurationO3  ");
            }


            Console.WriteLine($" DurationO1 HashCode IS : {Duration01.GetHashCode()} ");
            Console.WriteLine($" DurationO2 HashCode IS : {Duration02.GetHashCode()} ");


            Console.WriteLine("\n");

            Duration DO1 = new Duration(1, 10, 15);
            Console.WriteLine(DO1.ToString());

            Duration DO2 = new Duration(3600);
            Console.WriteLine(DO2.ToString());

            Duration DO3 = new Duration(7800);
            Console.WriteLine(DO3.ToString());

            Duration DO4 = new Duration(666);
            Console.WriteLine(DO4.ToString());

            #endregion


            #region 4 -  Forth Project


            DO3 = DO1 + DO2;
            Console.WriteLine(DO3.ToString());

            DO3 = DO1 + 7800;
            Console.WriteLine(DO3.ToString());

            DO3 = 666 + DO3;
            Console.WriteLine(DO3.ToString());

            DO3 = ++DO1;
            Console.WriteLine(DO3.ToString());

            DO3 = --DO2;
            Console.WriteLine(DO3.ToString());

            DO1 = DO1 - DO2;
            Console.WriteLine(DO1.ToString());


            Console.WriteLine("\n");


            if (DO1 > DO2)
            {
                Console.WriteLine("DO1 Is Greater than DO2.");
            }
            else if (DO1 <= DO2)
            {
                Console.WriteLine("DO1 is less than or equal to DO2.");
            }
            else
            {
                Console.WriteLine("DO1 Has Non-Zero Value.");
            }


            DateTime Obj = (DateTime)DO1;

            Console.WriteLine(Obj.ToString());


            #endregion
        }
    }
}
