using System;
using System.Collections.Generic;
using System.Text;

namespace Players_and_monsters
{
    class DarkKnight:Knight
    {
        public DarkKnight(string username, int level) : base(username, level)
        {
            this.username = username;
            this.level = level;
        }
    }
}
