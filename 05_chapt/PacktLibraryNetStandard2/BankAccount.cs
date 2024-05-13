using Packt.Shared;
public class BankAccount
{
    public string? AccountName; //instance member
    public decimal Balance; // instance member
    public static decimal InterestRate;  // shared member defaults to zero
}
