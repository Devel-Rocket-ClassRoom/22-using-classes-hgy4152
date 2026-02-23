using System;

// README.md를 읽고 아래에 코드를 작성하세요.


BankAccount account = new BankAccount("123-456-789", "홍길동");
account.ShowInfo();
account.Deposit(50000);
account.Deposit(30000);
account.Withdraw(20000);
account.Withdraw(100000);
account.Deposit(-1000);
account.ShowInfo();

class BankAccount
{
    public string AccountNumber { get; }
    public string OwnerName { get; }
    public int Balance { get; } = 0;
    private int amount = 0;

    public BankAccount(string accountNumber, string ownerName)
    {
        this.AccountNumber = accountNumber;
        OwnerName = ownerName;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"[계좌 정보] {AccountNumber}({OwnerName}) - 잔액: {amount}원");
    }

    public void Deposit(int amount)
    {
        if (amount > 0)
        {
            this.amount += amount;

            Console.WriteLine($"{amount}원 입금 완료. 잔액: {this.amount}원");
        }
        else
        {
            Console.WriteLine("입금 금액은 0보다 커야 합니다");
        }
    }

    public void Withdraw(int amount)
    {
        if (amount > 0 && this.amount >= amount)
        {
            this.amount -= amount;

            Console.WriteLine($"{amount}원 출금 완료. 잔액: {this.amount}원");
        }
        else
        {
            Console.WriteLine("잔액이 부족합니다.");
        }
    }
}

