using Microsoft.IdentityModel.Protocols.WSIdentity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Animal
    {
        private string name;
        public Animal(string name)
        {
            this.Name = name;
            
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value ?? throw new InvalidInputException();
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}")
                .AppendLine($"{this.Name}");
            return sb.ToString();
        }
    }
}
