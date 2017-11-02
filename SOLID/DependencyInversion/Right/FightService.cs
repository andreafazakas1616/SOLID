using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion.Right
{
    class FightService
    {
        private readonly IEnemyRepository _repository;
        public FightService(IEnemyRepository repository)
        {
            _repository = repository;
        }

        public void AddEnemyToFight()
        {
            _repository.GetEnemies().Add("lizard");
        }
    }
}
