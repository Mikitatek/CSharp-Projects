//Studiati felul in care a fost implementata o clasa pentru lucrul cu numere rationale.
//Apoi, implementati o clasa pentru lucrul cu numere complexe.
//Clasa model – Numere rationale

using System; 
using System.Collections.Generic; 
using System.Linq; using System.Text;

namespace NumberFormats
{
    public class Rational
    {
        #region Constructors
        public Rational()
        {
            this.Denominator = 1;
            this.Numerator = 0;
            this.WholePart = 0;
        }
        public Rational(int numerator, int denominator)
        {
            this.m_numerator = numerator;
            this.m_denominator = denominator;
        }
        #endregion Constructors

        #region Operators
        public static Rational operator +(Rational A, Rational B)
        {
            return new Rational(A.Numerator * B.Denominator + B.Numerator * A.Denominator, A.Denominator * B.Denominator);
        }

        public static Rational operator -(Rational A, Rational B)
        {
            return new Rational(A.Numerator * B.Denominator + B.Numerator * A.Denominator, A.Denominator * B.Denominator);
        }

        public static Rational operator *(Rational A, Rational B)
        {
            return new Rational(A.Numerator * B.Numerator, A.Denominator * B.Denominator);
        }

        public static Rational operator /(Rational A, Rational B)
        {
            return new Rational(A.Numerator * B.Denominator, B.Numerator * A.Denominator);
        }
        public static bool operator ==(Rational A, Rational B)
        {
            return (A.Denominator == B.Denominator && A.Numerator == B.Numerator);
        }

        public static bool operator !=(Rational A, Rational B)
        {
            return (A.Denominator != B.Denominator || A.Numerator != B.Numerator);
        }

        public static bool operator <(Rational A, Rational B)
        {
            return ((double)(A.Numerator / A.Denominator) < (double)(B.Numerator / B.Denominator));
        }

        public static bool operator >(Rational A, Rational B)
        {
            return ((double)(A.Numerator / A.Denominator) < (double)(B.Numerator / B.Denominator));
        }

        public static bool operator <=(Rational A, Rational B)
        {
            return ((double)(A.Numerator / A.Denominator) <= (double)(B.Numerator / B.Denominator));
        }

        public static bool operator >=(Rational A, Rational B)
        {
            return ((double)(A.Numerator / A.Denominator) >= (double)(B.Numerator / B.Denominator));
        }

#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        public override bool Equals(System.Object obj)
#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion operators

        #region Methods
        public override string ToString()
        {
            return String.Format("{0} / {1}", this.Numerator, this.Denominator);
        }

        public static Rational Simplify(Rational x)
        {
            int den = x.Denominator;
            int num = x.Numerator; int divisor = den; // Start division by denominator value
            while (divisor > 2)
            {
                if (num % divisor == 0 && den % divisor == 0)
                { // Condition true if num and den are divisable by same value
                    num /= divisor;
                    den /= divisor;
                }
                divisor--;
            }
            return new Rational(num, den);
        }

        public static string StrFraction(double x)
        {
            double entero, dec;
            double divisor;
            double numerador, denominador;
            int iteration = 0;
            entero = (int)x;
            dec = x - entero;
            numerador = dec * DECIMALS;
            denominador = DECIMALS;
            divisor = 2;
            while (divisor <= numerador)
            {
                if (numerador % divisor == 0 && denominador % divisor == 0)
                {
                    numerador /= divisor;
                    denominador /= divisor;
                }
                else divisor++;
                iteration++;
            }
            if (entero == 0)
                return String.Format("{0}/{1}", numerador, denominador);
            else return String.Format("{0} - {1}/{2}", entero, numerador, denominador);
        }
        public static double ToDecimal(Rational x)
        {
            double divisor = x.Numerator / x.Denominator;
            return divisor;
        }
        #endregion

        #region Properties
        public int Numerator
        {
            get
            {
                return this.m_numerator;
            }
            set
            {
                this.m_numerator = value;
            }
        }
        public int Denominator
        {
            get
            {
                return this.m_denominator;
            }
            set
            {
                this.m_denominator = value;
            }
        }
        public int WholePart
        {
            get
            {
                return this.m_WholePart;
            }
            set
            {
                this.m_WholePart = value;
            }
        }
        #endregion

        #region Fields
        public const int DECIMALS = 100000; // Value to star the denominator division to simplify
        private int m_numerator;
        private int m_denominator;
        private int m_WholePart;
        #endregion
    }

    public class Irational
    {
        #region Constructors
        public Irational()
        {
            this.Denominator = 1;
            this.Numerator = 0;
            this.WholePart = 0;
        }
        public Irational(int numerator, int denominator)
        {
            this.m_numerator = numerator;
            this.m_denominator = denominator;
        }
        #endregion Constructors

        #region Operators
        public static Irational operator +(Irational A, Irational B)
        {
            return new Irational(A.Numerator * B.Denominator + B.Numerator * A.Denominator, A.Denominator * B.Denominator);
        }

        public static Irational operator -(Irational A, Irational B)
        {
            return new Irational(A.Numerator * B.Denominator + B.Numerator * A.Denominator, A.Denominator * B.Denominator);
        }

        public static Irational operator *(Irational A, Irational B)
        {
            return new Irational(A.Numerator * B.Numerator, A.Denominator * B.Denominator);
        }

        public static Irational operator /(Irational A, Irational B)
        {
            return new Irational(A.Numerator * B.Denominator, B.Numerator * A.Denominator);
        }
        public static bool operator ==(Irational A, Irational B)
        {
            return (A.Denominator == B.Denominator && A.Numerator == B.Numerator);
        }

        public static bool operator !=(Irational A, Irational B)
        {
            return (A.Denominator != B.Denominator || A.Numerator != B.Numerator);
        }

        public static bool operator <(Irational A, Irational B)
        {
            return ((double)(A.Numerator / A.Denominator) < (double)(B.Numerator / B.Denominator));
        }

        public static bool operator >(Irational A, Irational B)
        {
            return ((double)(A.Numerator / A.Denominator) < (double)(B.Numerator / B.Denominator));
        }

        public static bool operator <=(Irational A, Irational B)
        {
            return ((double)(A.Numerator / A.Denominator) <= (double)(B.Numerator / B.Denominator));
        }

        public static bool operator >=(Irational A, Irational B)
        {
            return ((double)(A.Numerator / A.Denominator) >= (double)(B.Numerator / B.Denominator));
        }

#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        public override bool Equals(System.Object obj)
#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion operators

        #region Methods
        public override string ToString()
        {
            return String.Format("{0} / {1}", this.Numerator, this.Denominator);
        }

        public static Irational Simplify(Irational x)
        {
            int den = x.Denominator;
            int num = x.Numerator; int divisor = den; // Start division by denominator value
            while (divisor > 2)
            {
                if (num % divisor == 0 && den % divisor == 0)
                { // Condition true if num and den are divisable by same value
                    num /= divisor;
                    den /= divisor;
                }
                divisor--;
            }
            return new Irational(num, den);
        }

        public static string StrFraction(double x)
        {
            double entero, dec;
            double divisor;
            double numerador, denominador;
            int iteration = 0;
            entero = (int)x;
            dec = x - entero;
            numerador = dec * DECIMALS;
            denominador = DECIMALS;
            divisor = 2;
            while (divisor <= numerador)
            {
                if (numerador % divisor == 0 && denominador % divisor == 0)
                {
                    numerador /= divisor;
                    denominador /= divisor;
                }
                else divisor++;
                iteration++;
            }
            if (entero == 0)
                return String.Format("{0}/{1}", numerador, denominador);
            else return String.Format("{0} - {1}/{2}", entero, numerador, denominador);
        }
        public static double ToDecimal(Irational x)
        {
            double divisor = x.Numerator / x.Denominator;
            return divisor;
        }
        #endregion

        #region Properties
        public int Numerator
        {
            get
            {
                return this.m_numerator;
            }
            set
            {
                this.m_numerator = value;
            }
        }
        public int Denominator
        {
            get
            {
                return this.m_denominator;
            }
            set
            {
                this.m_denominator = value;
            }
        }
        public int WholePart
        {
            get
            {
                return this.m_WholePart;
            }
            set
            {
                this.m_WholePart = value;
            }
        }
        #endregion

        #region Fields
        public const int DECIMALS = 100000; // Value to star the denominator division to simplify
        private int m_numerator;
        private int m_denominator;
        private int m_WholePart;
        #endregion
    }
}