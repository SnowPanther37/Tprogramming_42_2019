using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Corvette : Ship
    {
        public Corvette()
        : base("Unnamed")
        {
        }

        public Corvette(string name)
        : base(name, 1)
        {
        }

        public Corvette(string name, double length)
        : this(name, length, 1)
        {
        }

        public Corvette(string name, double length, double displacement)
        {
            Name = name;
            Length = length;
            Displacement = displacement;
        }

        public override double Length
        {
            get
            {
                return base.Length;
            }

            set
            {
                if (value >= 0 && value <= 150)
                {
                    base.Length = value;
                }
                else
                {
                    throw new System.Exception("Wrong lenght");
                }
            }
        }

        public override double Displacement
        {
            get
            {
                return base.Displacement;
            }

            set
            {
                if (value >= 0 && value <= 2800)
                {
                    base.Displacement = value;
                }
                else
                {
                    throw new System.Exception("Wrong displacement");
                }
            }
        }

        public override void SayShip()
        {
            Console.WriteLine($"Корвет: {Name}, Длина: {Length} м., Водоизмещение: {Displacement} т.");
        }
    }
}