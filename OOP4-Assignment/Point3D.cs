using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_Assignment
{
    internal class Points3D : IComparable, ICloneable
    {
        public int NumO1 { get; set; }
        public int NumO2 { get; set; }
        public int NumO3 { get; set; }

        public Points3D(int x, int y, int z)
        {
            NumO1 = x;

            NumO2 = y;

            NumO3 = z;
        }



        public object Clone()
        {
            return new Points3D(NumO1, NumO2, NumO3);
        }





        public int CompareTo(object? obj)
        {
            if (obj == null)
                return 1;

            Points3D PassedPoint = obj as Points3D;

            if (PassedPoint != null)
            {
                int result = NumO1.CompareTo(PassedPoint.NumO1);

                if (result == 0)
                {
                    result = NumO2.CompareTo(PassedPoint.NumO2);

                    if (result == 0)
                    {
                        result = NumO3.CompareTo(PassedPoint.NumO3);
                    }
                }
                return result;
            }
            else
            {
                throw new ArgumentException(" Object is not Point3D ");
            }
        }





        public Points3D() : this(0, 0, 0) { }
        public Points3D(int x) : this(x, 0, 0) { }
        public Points3D(int x, int y) : this(x, y, 0) { }



        public override string ToString()
        {
            return $"Point Coordinates Is :  {NumO1} :: {NumO2} :: {NumO3}";
        }

    }
}
