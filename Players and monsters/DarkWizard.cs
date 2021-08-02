using System;
using System.Collections.Generic;
using System.Text;

namespace Players_and_monsters
{
    class DarkWizard:Wizard
    {
        public DarkWizard(string username, int level) : base(username, level)
        {
            this.username = username;
            this.level = level;
        }
    }
}
