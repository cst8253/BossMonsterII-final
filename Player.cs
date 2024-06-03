namespace BossMonsterII;

public class Player
{
  // fields
  private int _maxHealth = 50;
  private int _maxMana = 32;
  private int _maxDamage = 10;
  // properties
  public string Name { get; }
  public int Health { get; set; }
  public int Mana { get; set; }

  // constructor
  public Player(string name)
  {
      Name = name;
      Health = _maxHealth;
      Mana = _maxMana;
  }

  // methods
  public void Attack(Monster monster)
  {
      int damage = new Random().Next(1, _maxDamage);
      monster.Health -= damage;
      Console.WriteLine($"{Name} attacked {monster.Name} for {damage} damage!");
  }

  public void Heal()
  {
      if (Mana < 8)
      {
          Console.WriteLine("Not enough mana!");
          return;
      }
      Mana -= 8;
      RestoreHealth();
  }

  public void RestoreHealth()
  {
      int heal = new Random().Next(5, 10);
      Health = Health + heal > _maxHealth ? _maxHealth : Health + heal;
      Console.WriteLine($"{Name} healed for {heal} health!");
  }

  public void RestoreMana()
  {
      int restore = new Random().Next(1, 5);
      Mana = Mana + restore > _maxMana ? _maxMana : Mana + restore;
      Console.WriteLine($"{Name} restored {restore} mana!");
  }

  public void Reset()
  {
      Health = _maxHealth;
      Mana = _maxMana;
  }

  public void PrintStats()
  {
      Console.WriteLine($"Health: {Health}\t\t\t Mana: {Mana}");
  }
}
