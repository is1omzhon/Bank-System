
abstract class Account
{
    public string OwnerName {get; set;}
    public decimal Balance {get; set;}

    public Account(string ownerName, decimal balance)
    {
        this.OwnerName = ownerName;
        this.Balance = balance;
    }

    public abstract void WithDraw(decimal amount);

    public virtual void ShowBalance()
    {
        Console.WriteLine($"Balance : {Balance}");
    }

    public void Deposit(decimal amount)
    {   
        Balance+=amount;
        Console.WriteLine($"Umimy balance (balance + deposit) : {Balance}");
    }
}

class SavingsAccount : Account 
{
    public SavingsAccount(string ownerName, decimal balance) : base(ownerName, balance){}
    
    public override void WithDraw(decimal amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Not enough balance");
        }
        else
        {
            Balance--;
        };
    }

    public override void ShowBalance()
    {
        base.ShowBalance();
    }
}

