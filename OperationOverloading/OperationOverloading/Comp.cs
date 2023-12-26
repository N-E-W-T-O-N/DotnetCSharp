using System.Net.WebSockets;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace O
{
    internal class Comp
    {
        private decimal _real;
        private decimal _img;

        public Comp(decimal v1, decimal v2)
        {
            this._real = v1;
            this._img = v2;
        }
        public decimal Real { get { return this._real; } }
        public decimal Img { get => _img; }
        public decimal Mod { get => (decimal)Math.Sqrt((double)(_real * _real + _img * _img)); }
        public override string ToString()
        {
            return $"{Real} + {Img}i";
        }
        public static bool operator <(Comp a, Comp b)
        {
            return (a.Real * a.Real + a.Img * a.Img) < (b.Real * b.Real + b.Img * b.Img);
        }
        public static bool operator ==(Comp a, Comp b)
        {
            return (a.Real ==b.Real)&&(b.Img == a.Img);
        }
        public static bool operator !=(Comp a, Comp b)
        {
            return  (a.Real!=b.Real)||(b.Img!=a.Img);
        }
        public static bool operator >(Comp a, Comp b)
        {
            return (a.Real * a.Real + a.Img * a.Img) > (b.Real * b.Real + b.Img * b.Img);
        }
        public static Comp operator +(Comp a, Comp b)
        { return new Comp(a.Real + b.Real, a.Img + b.Img); }

        public static Comp operator -(Comp a, Comp b)
        { return new Comp(a.Real - b.Real, a.Img - b.Img);
        }

        public static Comp operator *(Comp x, Comp y)
        { return new Comp(x.Real * y.Real - x.Img * y.Img, x.Img * y.Img + x.Real * y.Real);
        }

        public static Comp operator *(Comp x, decimal y)//mulrtiply a decimal in real and imaginary
        {

            return new Comp(x.Real * y, x.Img * y);
        }


        public static Comp operator -(Comp c)
        {
            //return new Comp(c.Real, -c.Img);
             c._img=-c.Img;
            return c;
        }
        
        public static Comp operator --(Comp c)
        {
            return new Comp(-c.Real, -c.Img);
        }
        public static Comp operator ++(Comp c)
        {
            return new Comp(Math.Abs(c.Real), Math.Abs(c.Img));
        }
        public static Comp operator /(Comp x, Comp y)
        {
            decimal denominator = y.Real * y.Real + y.Img * y.Img;
            decimal realPart = (x.Real * y.Real + x.Img * y.Img) / denominator;
            decimal imgPart = (x.Img * y.Real - x.Real * y.Img) / denominator;
            return new Comp(realPart, imgPart);
        }

    }
}
/*/// <summary>
/// Complex numbers
/// Written by Matt, 2022
/// </summary>
struct complex
{
    public double Re, Im;
    public complex(double re, double im)
    {
        this.Re = re; this.Im = im;
    }


    public static implicit operator complex((double real, double imag) c) 
            => new complex(c.real, c.imag); // via tuples (re, im)

    public override string ToString() 
        => $"{this.Re.ToString().Trim()} {(this.Im < 0 ? "-" : "+")} {Math.Abs(this.Im)}i";
    
    /// <summary>Tries to convert string expressions like "2+3i" or "5-7i" to complex</summary>
    public static bool TryParse(string complexNr, out complex result) 
    {
        bool success = false;
        result = (0, 0);
        try
        {
            result = Parse(complexNr);
            success = true;
        } catch {}
        return success;
    }

    /// <summary>Converts string expressions like "2+3i" or "5-7i" to complex</summary>
    public static complex Parse(string complexNr)
    {
        complex result = (0, 0);
        try
        {
            if (complexNr.Contains("-")) complexNr = complexNr.Replace("-", "+-");
            var tr = complexNr.Split("+").Select(s => s.Trim()).ToArray();
            var realStr = tr[0]; var imagStr = tr[1].TrimEnd('i').Trim();
            result = (double.Parse(realStr), double.Parse(imagStr));
        } 
        catch (Exception ex)
        {
            throw new SyntaxErrorException("Invalid syntax for complex number. Allowed is 'a+bi' or 'a-bi'", ex);   
        }
        return result;
    }
    
    public override bool Equals(object obj)
    {
        return (obj == null) ? false : (this == (complex)obj);
    }

    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(this.Re); hash.Add(this.Im);
        return hash.ToHashCode();
    }
}
References (Mandelbrot algorithms to measure performance of "complex" library):

Mandelbrot set (Python, but understandable for C# programmers too)
Mandelbrot algorithms (Pseudocode)
Share
Improve*/