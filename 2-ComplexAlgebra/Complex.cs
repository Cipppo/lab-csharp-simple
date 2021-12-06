using System;
using System.Dynamic;

namespace ComplexAlgebra
{
    /// <summary>
    /// A type for representing Complex numbers.
    /// </summary>
    ///
    /// TODO: Model Complex numbers in an object-oriented way and implement this class.
    /// TODO: In other words, you must provide a means for:
    /// TODO: * instantiating complex numbers
    /// TODO: * accessing a complex number's real, and imaginary parts
    /// TODO: * accessing a complex number's modulus, and phase
    /// TODO: * complementing a complex number
    /// TODO: * summing up or subtracting two complex numbers
    /// TODO: * representing a complex number as a string or the form Re +/- iIm
    /// TODO:     - e.g. via the ToString() method
    /// TODO: * checking whether two complex numbers are equal or not
    /// TODO:     - e.g. via the Equals(object) method
    public class Complex
    {
        private int Real { get; }
        private double Imaginary { get; }

        public double Modulus => Math.Sqrt( Real * Real + Imaginary * Imaginary);

        public double Phase => Math.Atan2(this.Real, this.Imaginary);

        public Complex(int real, double imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }

        public Complex Plus(Complex cmplx) => new Complex(this.Real + cmplx.Real, this.Imaginary + cmplx.Imaginary);

        public Complex Minus(Complex cmplx) => new Complex(this.Real - cmplx.Real, this.Imaginary - cmplx.Imaginary);

        public Complex Complement() => new Complex(this.Real, -this.Imaginary);
        
        

    }
}