public class BankAccount
{
  public string accountNumber { get; set; }
  //public decimal balance { get; set; }
  private decimal balance { get; set; }

  public decimal getBalance() {
    return balance;
  }
public void makeDeposit(decimal newDeposit) {
  if (newDeposit < 0) {
    // balance = balance;
    throw new Exception("Invalid deposit amount");
  } else {
    balance += newDeposit;
  }
}

  // constructor
  public BankAccount() {
    accountNumber = "unknown";
    balance = 100.99m;
  }

  public BankAccount(string newAccountName) {
    accountNumber = newAccountName;
    balance = 100.99m;
  }

  public BankAccount(decimal startingBalance) {
    accountNumber = "unknown";
    balance = 100.99m;

    if (startingBalance >= 10000) {
      balance = startingBalance + 2000;
    } else {
      balance = startingBalance + 100;
    }

  }

};