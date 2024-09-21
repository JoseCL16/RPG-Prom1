using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG___P1._242
{
    interface IActions
    {
        void Attack(Enemy opponent);
        void SpecialSkill(Enemy opponent);
    }
}