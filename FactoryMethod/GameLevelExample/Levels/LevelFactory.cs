namespace GameLevelExample.Levels;

public static class LevelFactory
{
    public static Level CreateLevel(int levelNumber)
    {
        return levelNumber switch
        {
            1 => new CaveLevel(),
            2 => new HauntedHouseLevel(),
            _ => throw new ArgumentOutOfRangeException(nameof(levelNumber), "Unsupported level number")
        };
    }
}
