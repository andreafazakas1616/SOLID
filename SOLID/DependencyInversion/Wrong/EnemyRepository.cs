using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion.Wrong
{
    class EnemyRepository
    {
        List<string> enemies = new List<string> { "wizard", "cockroach", "lizzard", "wolf" };
        //string[] enemies2 = new string[] { "wizard", "cockroach", "lizzard", "wolf" };

        public List<string> GetEnemies()
        {
            return enemies;
        }

        //public string[] GetEnemies2()
        //{
        //    return enemies2;
        //}
    }
}
