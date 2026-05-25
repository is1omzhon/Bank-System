using Models.CreditAccount;
using Models.SavingsAccount;
using Models.Accounts;

Account savings = new SavingsAccount("Nikita", 1000);

savings.ShowBalance();
savings.Deposit(500);
savings.WithDraw(300);
savings.WithDraw(1500);

Console.WriteLine();

Account creditCard = new CreditAccount("Ali", 0);
creditCard.ShowBalance();             
creditCard.WithDraw(6000);                                 
creditCard.Deposit(2000);                    
