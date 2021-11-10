using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_11
{
    class Triangle
    {
        public int AngleOne { get; set; }
        public int AngleTwo { get; set; }
        public int AngleThree { get; set; }
        public static int counterSharp { get; set; }
        public static int counterRect { get; set; }
        public static int counterUnsharp { get; set; }

        public Triangle(int angleOne, int angleTwo, int angleThree)
        {
            AngleOne = angleOne;
            AngleTwo = angleTwo;
            AngleThree = angleThree;
            Count();
        }

        public void Count()
        {
            if (AngleOne == 90 || AngleTwo == 90 || AngleThree == 90)
            {
                counterRect++;
            }
            else if (AngleOne < 90 && AngleTwo < 90 && AngleThree < 90)
            {
                counterSharp++;
            }
            else
            {
                counterUnsharp++;
            }
        }
        public bool SharpTriangle()
        {
            if (AngleOne < 90 && AngleTwo < 90 && AngleThree < 90)
            {
                return true;
            }
            else return false;
            
        }

        public bool RectTriangle()
        {
            if (AngleOne == 90 || AngleTwo == 90 || AngleThree == 90)
            {
                return true;
            }
            return false;
        }
        public bool UnsharpTriangle()
        {
            if (!SharpTriangle() && !RectTriangle())
            {
                return true;
            }
            else return false;
        }

        public override string ToString()
        {
            return $"{AngleOne}, {AngleTwo}, {AngleThree}";
        }
    }
}
