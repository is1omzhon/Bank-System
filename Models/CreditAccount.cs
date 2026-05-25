using Models.Accounts;

namespace Models.CreditAccount;

class CreditAccount : Account
{
    private decimal CreditLimit = -5000;

    public CreditAccount(string ownerName, decimal balance) : base(ownerName, balance) {}

    public override void WithDraw(decimal amount)
    {
        decimal newBalance = Balance - amount;
        
        if (newBalance >= CreditLimit)
        {
            Balance = newBalance;
            Console.WriteLine($"Withdrew: {amount}$");
            ShowBalance();
        }
        else
        {
            Console.WriteLine($"Credit limit exceeded");
        }
    }

    public override void ShowBalance()
    {
        Console.WriteLine($"Sizining credit kartangiz balansi: {Balance}");
    }
}
