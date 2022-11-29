using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_Rectangle_Cuboid
{
    class Rectangle
    {
        //member variables
        protected double length;
        protected double width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        //Calculating scale
        public virtual double GetScale()
        {
            return 2 * (length + width);
        }
        public virtual double GetArea()
        {
            return length * width;
        }
        public virtual void Display()
        { // virtual method
            Console.WriteLine("Length: {0}", length);
        }
    }
    class Cuboid : Rectangle
    {
        public Rectangle R1{get; set;}
        public Rectangle R2 { get; set; }
        double height;
        protected double Height { 
            get { return  height;} 
            set{
                if (height < 0)
                {
                    try
                    {
                       Math.Abs(height);

                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Negative numbers are not valid");
                    }
                    height = value;
                }


            }
        }
        //Set virtual values
        public  Cuboid(double l, double w, double height) : base(l,w)   
        {
            l = 0;
            w = 0;
            this.Height = height;
            Height = 0;
        }

        public Cuboid(Rectangle r1, double height): base(0,height)
        {
            this.R1 = r1;
            this.Height = height;
        }
        //instance constructor
        public Cuboid(Rectangle r2)
            : base(0,0)
        {

            this.R2 = r2;
        }
        //overrride scale
        public override double GetScale()
        {
            return (width + length + Height) * 4;
        }
        //override Area
        public override double GetArea()
        {
            return ((length * width) * 2) + ((length * Height) * 2) + ((width * height) * 2);
        }
        //get volume
        public double GetVolume()
        {
            double volume=length * Height * width;
            return volume;
        }
        

    }
    class Tester
    {
        static void Main(string[] args)
        {
            Cuboid c1 = new Cuboid(2,2,2);
            Console.WriteLine(c1.GetArea());
            Console.WriteLine( c1.GetVolume());
            Console.WriteLine(c1.GetScale());
           
       
           


        }
    }
}
