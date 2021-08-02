using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Invalid : ArgumentException
    {
        private const string Message = "Invalid input!";

        public Invalid() : base(Message)
        {
        }
    }
}
