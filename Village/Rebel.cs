using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    internal class Rebel : Person
{
    public int harm;
    public int age;
    public Rebel(string name, int age, int harm)
        : base(name, age)
    {
        this.Age = age;
        this.Harm = harm;
    }
    public int Age
    {
        get { return this.age; }
        set
        {
            if (value > 50)
            {
                throw new ArgumentException("Age should be less or equal to 50!");
            }
            this.age = value;
        }
    }
    public int Harm
    {
        get { return this.harm; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Harm should be greater than 0!");
            }
            this.harm = value;

        }
    }
    public override string ToString()
    {
        return $"{base.ToString()}\nHarm: {Harm}";
    }
}

