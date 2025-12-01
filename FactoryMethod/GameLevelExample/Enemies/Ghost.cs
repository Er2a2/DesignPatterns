namespace GameLevelExample.Enemies;

public class Ghost : IEnemy
{
    public void Attack()
    {
        Console.WriteLine("Ghost Attack!");
    }

    public void Scream()
    {
        Console.WriteLine("Scream Attack!");
    }
}
