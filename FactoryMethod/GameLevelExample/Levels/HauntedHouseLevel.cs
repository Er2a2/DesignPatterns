using GameLevelExample.Enemies;

namespace GameLevelExample.Levels;

public class HauntedHouseLevel : Level
{
    public override IEnemy CreateEnemy()
    {
        return new Ghost();
    }
}
