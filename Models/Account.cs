namespace Models.Accounts;

abstract class Account
{
    public string OwnerName {get; set;}
    public decimal Balance {get; set;}

    public Account(string ownerName, decimal balance)
    {
        OwnerName = ownerName;
        Balance = balance;
    }

    public abstract void WithDraw(decimal amount);

    public virtual void ShowBalance()
    {
        Console.WriteLine($"Balance : {Balance}");
    }

    public void Deposit(decimal amount)
    {   
        Balance += amount;
        Console.WriteLine($"Deposit : {amount}");
        ShowBalance();
    }
}
