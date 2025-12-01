//client
using GameLevelExample.Levels;


// Using Simple Factory approach (deciding the level type externally)
Level level1 = LevelFactory.CreateLevel(levelNumber: 1);
level1.EncounterEnemy();


// Using Factory Method directly through subclassing
Level level2 = new HauntedHouseLevel();
level2.EncounterEnemy();