Console.WriteLine("Hello User, welcome to the Bank.");

BankAccount account = new BankAccount(11000);
//account.balance = 100.99m; // m needed after decimal numbers
try {
  account.makeDeposit(-1);
} catch(Exception ex) {
  Console.WriteLine(ex.Message);
}

//Console.WriteLine("You have " + account.balance + " dollars in your account");
//Console.Write($"Your balance is: {account.balance} \n); // \n adds enter keystroke
Console.WriteLine($"Your balance is: ${account.getBalance()}");
Console.WriteLine($"Account Number: {account.accountNumber}");

