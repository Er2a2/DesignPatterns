using GameLevelExample.Enemies;

namespace GameLevelExample.Levels;

public class CaveLevel : Level
{
    public override IEnemy CreateEnemy()
    {
        return new Goblin();
    }
}
