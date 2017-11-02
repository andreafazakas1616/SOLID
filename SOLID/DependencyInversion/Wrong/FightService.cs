

namespace SOLID.DependencyInversion.Wrong
{
    class FightService
    {
        EnemyRepository repository = new EnemyRepository();

        public void AddEnemyToFight()
        {
            repository.GetEnemies();
        }
    }
}
