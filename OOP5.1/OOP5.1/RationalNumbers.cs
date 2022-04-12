using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5._1
{
    public class RationalNumbers
    {
        private int numerator;
        private int denominator;

        public RationalNumbers(int x, int y)
        {
            numerator = x;
            denominator = y;
        }

        public override string ToString()
        {
            return string.Format("({0} / {1})",
                numerator, denominator);
        }

        public static RationalNumbers operator *(RationalNumbers a, int b)
        {
            return new RationalNumbers(a.numerator * b, a.denominator);
        }

        public static RationalNumbers operator *(int a, RationalNumbers b)
        {
            return b * a;
        }

        public static implicit operator RationalNumbers(double d)
        {
            int integerPart = (int)d;
            RationalNumbers @int = new RationalNumbers(integerPart, 1);

            double fractionalPart = d - integerPart;
            string fractPartStr = Convert.ToString(fractionalPart);
            int counter = 0;
            for (int i = 0; i < fractPartStr.Length; i++)
            {
                counter++;
                if (fractPartStr[i] == ',') counter = 0;
            }
            RationalNumbers @fraction = new RationalNumbers((int)(fractionalPart * 10),
                counter * 10);
            return @int + @fraction;
        }

        public static RationalNumbers operator +(RationalNumbers a, RationalNumbers b)
        {
            RationalNumbers z = new RationalNumbers(a.numerator * b.denominator
                + b.numerator * a.denominator,
                a.denominator * b.denominator);

            while (true)
            {
                if (z.numerator % 10 == 0 && z.denominator % 10 == 0)
                {
                    z.numerator = z.numerator / 10;
                    z.denominator = z.denominator / 10;
                }
                else break;
            }
            return z;
        }

        public static RationalNumbers operator -(RationalNumbers a, RationalNumbers b)
        {
            return new RationalNumbers(a.numerator * b.denominator
                - b.numerator * a.denominator,
                a.denominator * b.denominator);
        }

        public static RationalNumbers operator *(RationalNumbers a, RationalNumbers b)
        {
            return new RationalNumbers(a.numerator * b.numerator,
                a.denominator * b.denominator);
        }

        public static RationalNumbers operator /(RationalNumbers a, RationalNumbers b)
        {
            RationalNumbers temp = new RationalNumbers(b.denominator, b.numerator);
            return a * temp;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            RationalNumbers p = obj as RationalNumbers;
            if (p == null) return false;
            return ((numerator == p.numerator)
                && (denominator == p.denominator));
        }

        public override int GetHashCode()
        {
            return numerator ^ denominator;
        }

        public static bool operator ==(RationalNumbers p1, RationalNumbers p2)
        {
            if (ReferenceEquals(p1, p2)) return true;
            if ((object)p1 == null) return false;
            return p1.Equals(p2);
        }

        public static bool operator !=(RationalNumbers p1, RationalNumbers p2)
        {
            return (!(p1 == p2));
        }




    }
}
