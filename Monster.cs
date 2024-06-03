namespace BossMonsterII;

public class Monster
{
  // fields
    private string[] _names = [ "Goblin", "Orc", "Troll", "Zombie", "Skeleton" ];
    private int _maxDamage;

    // static properties
    public static int Count { get; set; } = 10;

    // properties
    public string Name { get; }
    public int Health { get; set; }

    public Monster()
    {
        Name = RandomName();
        Health = new Random().Next(10, 25);
        _maxDamage = new Random().Next(5, 10);
    }

    private string RandomName()
    {
        Random random = new Random();
        int index = random.Next(_names.Length);
        return _names[index];
    }

    public void Attack(Player player)
    {
        int damage = new Random().Next(1, _maxDamage);
        player.Health -= damage;
        Console.WriteLine($"{Name} attacks {player.Name} for {damage} damage!");
    }
}

