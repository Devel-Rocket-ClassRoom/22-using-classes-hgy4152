using System;
using static System.Net.Mime.MediaTypeNames;

// README.md를 읽고 아래에 코드를 작성하세요.




GameCharacter hero = new GameCharacter("용사", 5);
GameCharacter monster = new GameCharacter("고블린", 3);

hero.ShowStatus();
monster.ShowStatus();

Console.WriteLine("\n=== 전투 시작 ===");

hero.Attack(monster);
monster.ShowStatus();

hero.Attack(monster);
monster.ShowStatus();

hero.Attack(monster);
monster.ShowStatus();

hero.Attack(monster);
monster.ShowStatus();

class GameCharacter
{
    public string Name { get; }
    public int Level { get; }
    public int MaxHp { get { return Level * 100; } }
    public int CurrentHp { get { return _currentHp; } }
    private int _currentHp;
    public int AttackPower { get { return Level * 10; } }
    public bool IsAlive { get { return CurrentHp > 0; } }


    public GameCharacter(string name, int level)
    {
        Name = name;
        Level = level;
        _currentHp = MaxHp; 
    }


    public void Attack(GameCharacter target)
    {
        
        target.TakeDamage(AttackPower);
        Console.WriteLine($"{Name}이(가) {target.Name}에게 {AttackPower} 데미지를 입혔습니다!");
    }

    public void TakeDamage(int damage)
    {
        _currentHp -= damage;

        if(this._currentHp < 0)
            this._currentHp = 0;
    }

    public void ShowStatus()
    {
        Console.WriteLine($"[{Name}] Lv.{Level} - HP: {CurrentHp}/{MaxHp}, 공격력: {AttackPower}");
    }
}