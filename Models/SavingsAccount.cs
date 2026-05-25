using Models.Accounts;

namespace Models.SavingsAccount;

class SavingsAccount : Account
{
    public SavingsAccount(string ownerName, decimal balance) : base(ownerName, balance) { }

    public override void WithDraw(decimal amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Not enough balance");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew : {amount}$");
            ShowBalance();
        }
    }

    public override void ShowBalance()
    {
        Console.WriteLine($"SavingsAccount balance: {Balance}");
    }
}