
using System.Collections.Generic;

namespace SOLID.DependencyInversion.Right
{
    class EnemyRepository : IEnemyRepository
    {
        List<string> enemies = new List<string> { "wizard", "cockroach", "lizzard", "wolf" };
        string[] enemies2 = new string[] { "wizard", "cockroach", "lizzard", "wolf" };

        public List<string> GetEnemies()
        {
            return enemies;
        }

        public string[] GetEnemies2()
        {
            return enemies2;
        }
    }
}
