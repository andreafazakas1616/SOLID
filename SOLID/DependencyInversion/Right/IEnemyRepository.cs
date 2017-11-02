
using System.Collections.Generic;

namespace SOLID.DependencyInversion.Right
{
    interface IEnemyRepository
    {
        List<string> GetEnemies();
        string[] GetEnemies2();
    }
}
