using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Peasant : Person
{
    public int productivity;
    public int age;

    public Peasant(string name, int age, int productivity)
        : base(name, age)
    {
        this.Age = age;
        this.Productivity = productivity;
    }
    public int Age
    {
        get { return this.age; }
        set
        {
            if (value > 110)
            {
                throw new ArgumentException("Age cannot be greater than 110!");
            }
            this.age = value;
        }
    }
    public int Productivity
    {
        get { return this.productivity; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Productivity cannot be less or equal to 0!");
            }
            this.productivity = value;

        }
    }
    public override string ToString()
    {
        return $"{base.ToString()}\nProductivity: {Productivity}";
    }
}

