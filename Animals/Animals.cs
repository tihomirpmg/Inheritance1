using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private int? age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Gender
        {
            get { return this.gender; }
            set
            {
                this.gender = value ?? throw new Invalid();
            }
        }

        public int? Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new Invalid();
                }
                this.age = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value ?? throw new Invalid();
            }
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}")
                .AppendLine($"{this.Name} {this.Age} {this.Gender}")
                .Append(this.ProduceSound());
            return sb.ToString();
        }
    }
}
