using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Maths_Formula
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("SimpleQuadratic(4f) = " + SimpleQuadratic(4f));
            float value1 = 0;
            float value2 = 0;
            QuadraticCurve(7f, -5f, -9f, ref value1, ref value2);
            Console.WriteLine("QuadraticCurve(7f, -5f, -9f,value1,value2) = " + value1 +", "+ value2);
            Console.WriteLine("BasicLinearBlend(-3f, 4f, .05f) = " + BasicLinearBlend(-3f, 4f, .05f));
            Point p1 = new Point();
            p1.x = -9;
            p1.y = 7;
            Point p2 = new Point();
            p2.x = 6;
            p2.y = -1;
            Console.WriteLine("DistanceBetweenTwoPoints(p1, p2) = "+ DistanceBetweenTwoPoints(p1, p2));


            Point3 point1 = new Point3();
            point1.x = -2;
            point1.y = -5;
            point1.z = 5;
            Point3 point2 = new Point3();
            point2.x = -7;
            point2.y = 2;
            point2.z = -4;
            Console.WriteLine("InnerProduct(point1, point2) = " + InnerProduct(point1, point2));

            Plane plane1 = new Plane();
            plane1.a = -.727393f;
            plane1.b = .5819144f;
            plane1.c = .3636965f;
            plane1.d = 0;


            Point3 point3 = new Point3();
            point3.x = 8;
            point3.y = 0;
            point3.z = 3;

            // 0.727393 , 0.5819144 , 0.3636965 , 0) Point(8 , 0 , 3) = -4.728055Plane

            Console.WriteLine("PlanePointDistance(plane1, point3) = " +PlanePointDistance(plane1, point3));

            Console.WriteLine("CubicBezierCurve(-0.45f, 0.2f, 0f, 0.05f, 0.4f) = " + CubicBezierCurve(-0.45f, 0.2f, 0f, 0.05f, 0.4f));

            Console.ReadKey();
        }
        public static float GetSquareRoot(float number) {
            if (number<0)
            {
                number = number  *-1;
            }
            float root = 1;
            int i = 0;
            while (true)
            {
                i = i + 1;
                root = (number / root + root) / 2;
                if (i == number + 1) { break; }
            }
            return root;
        }
        private static float SimpleQuadratic(float x) {
            return x*x +2*x -7;
        }


        private static bool QuadraticCurve(float a, float b, float c, ref float v, ref float w)
        {
            if (a == 0 || b * b - 4 * a * c < 0)
            {
                v = float.NaN;
                w = float.NaN;
                return false;
            }
            //float Value = GetSquareRoot(b * b - 4 * a * c);
            float Value = (float)Math.Sqrt(b * b - 4 * a * c);
            if (Value<0)
            {
                return false;
            }
            v = (-b + Value) / (2 * a);
            w = (-b - Value) / (2 * a);
            return true;
        }

        private static float BasicLinearBlend(float s, float e, float t) {
            return s+t*(e-s);
        }



        private static float DistanceBetweenTwoPoints(Point p1, Point p2)
        {
            float x = p1.x - p2.x;
            float y = p1.y - p2.y;
            return (float)Math.Sqrt(x*x+y*y);
            //return GetSquareRoot(((p2.x - p1.x) * (p2.x - p1.x)) + ((p2.y - p1.y) * (p2.y - p1.y)));
        }



        private static float InnerProduct(Point3 p1, Point3 p2)
        {
            return (p1.x*p2.x) + (p1.y * p2.y) + (p1.z * p2.z);
        }

        private static float PlanePointDistance(Plane plane, Point3 point)
        {
            if (plane.a*+plane.b+plane.c ==0)
            {
                return float.NaN;
            }
            return ((plane.a * point.x) + (plane.b * point.y) + (plane.c * point.z) + plane.d) /
                ((float)Math.Sqrt((plane.a * plane.a) + (plane.b * plane.b) + (plane.c * plane.c)));
        }

        private static float CubicBezierCurve(float t, float p0, float p1, float p2, float p3) {
            float invertT = 1.0f - t;
            float valueOne = invertT * invertT * invertT * p0;
            float valueTwo = 3.0f * invertT * invertT * t * p1;
            float valueThree = 3.0f *  invertT * t * t * p2;
            float valueFour = t * t * t * p3;

            return valueOne + valueTwo + valueThree + valueFour;
        }
        struct Point
        {
            public float x;
            public float y;
        }
        struct Point3
        {
            public float x;
            public float y;
            public float z;
        }
        struct Plane
        {
            public float a;
            public float b;
            public float c;
            public float d;
        }
    }
}
