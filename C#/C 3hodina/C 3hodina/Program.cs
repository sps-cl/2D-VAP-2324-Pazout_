using System;

namespace C 3hodina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiste realnou cast prvniho komplexniho cisla");
            double RealNum1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Napiste imaginarni cast prvniho komplexni cislo");
            double ImaginaryNum1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Napiste realnou cast druheho komplexniho cisla");
            double RealNum2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Napiste imaginarni cast druheho komplexniho cisla");
            double ImaginaryNum2 = double.Parse(Console.ReadLine());

            ComplexNumber ComplexNum1 = new ComplexNumber(RealNum1, ImaginaryNum1);
            ComplexNumber ComplexNum2 = new ComplexNumber(RealNum2, ImaginaryNum2);

            ComplexNum1.Add(ComplexNum2);
            Console.WriteLine($"Soucet komplexnich cisel je {ComplexNum1.Real} + {ComplexNum1.Imaginary} ");

            ComplexNum1.Subtract(ComplexNum2);
            Console.WriteLine($"Rozdil komplexnich cisel je {ComplexNum1.Real} - {ComplexNum1.Imaginary}");

            ComplexNum1.Multiply(ComplexNum2);
            Console.WriteLine($"Soucin komplexnich cisel je {ComplexNum1.Real} * {ComplexNum1.Imaginary}");

            ComplexNum1.Division(ComplexNum2);
            Console.WriteLine($"Podil komplexnich cisel je {ComplexNum1.Real} / {ComplexNum1.Imaginary}");

            Console.ReadKey();
        }
    }

    class ComplexNumber
    {
        public double Real;
        public double Imaginary;

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public void Add(ComplexNumber other)
        {
            Real += other.Real;
            Imaginary += other.Imaginary;
        }

        public void Subtract(ComplexNumber other)
        {
            Real -= other.Real;
            Imaginary -= other.Imaginary;
        }

        public void Multiply(ComplexNumber other)
        {
            Real = Real * other.Real - Imaginary - other.Imaginary;
            Imaginary = Imaginary * other.Imaginary - Real * other.Real;
        }

        public void Division(ComplexNumber other)
        {
            double TempReal = Real * other.Real + Imaginary * other.Imaginary;
            double TempReal2 = Math.Pow(other.Real, 2) + Math.Pow(other.Imaginary, 2);
            Real = TempReal / TempReal2;

            Double TempImag = Imaginary * other.Real - Real * other.Imaginary;
            Double TempImag2 = Math.Pow(other.Real, 2) + Math.Pow(other.Imaginary, 2);
            Imaginary = TempImag / TempImag2;
        }
    }
}