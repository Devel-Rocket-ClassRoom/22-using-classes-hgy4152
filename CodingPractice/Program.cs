using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");


ClassName.MemberName();
Console.WriteLine(Square.GetName("정사각형"));
MyFirstClass.StaticMethod();

MyFirstClass myFirstClass = new MyFirstClass();
myFirstClass.InstanceMethod();

Person person1 = new Person();
person1.Name = "홍길동";
person1.Age = 25;
person1.Introduce();

Person person2 = new Person();
person2.Name = "김철수";
person2.Age = 30;
person2.Introduce();


Point point1 = new Point();
Point point2 = point1;
point1.X = 10;
point2.X = 10;

point1.X = 100;

Console.WriteLine($"point1.X = {point1.X}");
Console.WriteLine($"point2.X = {point2.X}");


PointStruct ps1 = new PointStruct();
ps1.x = 10;
PointStruct ps2 = ps1;
ps2.x = 100;

PointClass pc1 = new PointClass();
pc1.x = 10;
PointClass pc2 = pc1;
pc2.x = 100;

Console.WriteLine($"구조체: ps1.X = {ps1.x}, ps2.X = {ps2.x}");
Console.WriteLine($"클래스: pc1.X = {pc1.x}, pc2.X = {pc2.x}");


Calculator calculator = new Calculator();
calculator.Add(3, 5);
calculator.Multiply(3, 5);

Player player1 = new Player();
Player player2 = new Player("용사", 150);


Stock stock = new Stock();
stock.CurrentPrice = 30;

Console.WriteLine($"주가: {stock.CurrentPrice}");

Product product = new Product();
product.Name = "노트북";
product.Price = 1500000;
Console.WriteLine($"{product.Name}: {product.Price}원 (수량: {product.Quantity})");

Circle circle = new Circle();
circle.Radius = 5;

Console.WriteLine($"반지름: {circle.Radius}, 넓이: {circle.Area}");


Monster mon1 = new Monster();
mon1.Name = "고블린";
mon1.Attack();

Monster mon2 = new Monster { Name = "오크" };
mon2.Attack();

Character character1 = new Character
{
    Name = "용사",
    Level = 10,
    Job = "전사"
};

Console.WriteLine($"{character1.Name} - Lv.{character1.Level} {character1.Job}");

Random random = new Random();

Console.WriteLine($"임의의 정수: {random.Next()}");
Console.WriteLine($"0 ~ 4: {random.Next(5)}");// Next(max)
Console.WriteLine($"1 ~ 9: {random.Next(1,10)}"); // Next(min, max)
Console.WriteLine($"0.0 ~ 1.0: {random.NextDouble():F4}");



Console.WriteLine($"주사위를 5번 굴립니다:");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($" {i + 1}번째: {random.Next(1, 7)}");
}

Person1 per1 = new Person1("Alice"); 
Person1 per2 = new Person1("Bob");

per1.SetFriend(per2);

#region

class ClassName
{

    public static void MemberName()
    {
        Console.WriteLine("클래스의 멤버가 호출되어 실행됩니다.");
    }

}

class Square
{
    public static string GetName(string name)
    {
        return name;
    }
}

class MyFirstClass
{
    public static void StaticMethod()
    {
        Console.WriteLine("[1] 정적 메서드");
    }

    public void InstanceMethod()
    {
        Console.WriteLine("[2] 인스턴스 메섣");
    }
}


class Person
{
    public string Name;
    public int Age;

    public void Introduce()
    {
        Console.WriteLine($"안녕하세요, {Name}입니다. {Age}살 입니다.");
    }

}


class Point
{ 
    public int X;
    public int Y;


}

struct PointStruct
{
    public int x;
    public int y;

}

class PointClass
{
    public int x;
    public int y;
}

class Calculator
{
    public void Add(int a, int b)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }

    public void Multiply(int a, int b)
    {
        Console.WriteLine($"{a} * {b} = {a * b}");
    }
}

class Player
{
    public string Name;
    public int Health;

    public Player()
    {
        Name = "Unknown";
        Health = 100;
    }
    public Player(string name, int health)
    {
        Name = name;
        Health = health;
    }

}



class Stock
{
    public int price;

    public int CurrentPrice
    {
        get {  return price; }
        set {  price = value; }
    }
}

class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; } = 1;

}

class Circle
{
    public double Radius { get; set; }
    public double Area => 3.14 * Radius * Radius;
}

class Monster
{
    public string Name;
    public int Health;

    public void Attack()
    {
        Console.WriteLine($"{Name}이(가) 공격합니다!");
    }
}

class Character
{
    public string Name { get; set; }
    public int Level { get; set; }
    public string Job {  get; set; }


}

#endregion

class Person1
{
    public string Name { get; set; }

    public Person1(string name) 
    {
        this.Name = name;

        
    }

    public void SetFriend(Person1 person)
    {
        person.PrintFriend(this);
    }

    public void PrintFriend(Person1 person)
    {
        Console.WriteLine($"{Name}의 친구는 {person.Name}");
    }
}