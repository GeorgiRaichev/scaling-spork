using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public abstract class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name
        {
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new ArgumentException("Name should be between 3 and 30 characters!");
                }
                this.name = value;
            }
            get
            {
                return this.name;
            }
        }

        public int Age
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age should be 0 or positive!");
                }
                this.age = value;
            }
            get
            {
                return this.age;
            }
        }

        public override string ToString()
        {
            /*
             * Name: {Name}
               Age: {Age}
             */
            return $"Name: {this.Name}\nAge: {this.Age}";
        }
    }

