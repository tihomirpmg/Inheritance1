using System;
using System.Collections.Generic;
using System.Text;

namespace Players_and_monsters
{
    class Hero
    {
        public string username;
        public int level;

        public Hero(string username, int level)
        {
            this.Username = username;
            this.Level = level;
        }
        public int Level
        {
            get { return this.level; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Level must be positive!");
                }
                this.level = value;
            }
        }
        public string Username
        {
            get { return this.username; }
            set { this.username = value; }

        }
        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username}  Level: {this.Level}";
        }

    }
}
