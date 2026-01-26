public class Deposits
{
    private double _balance;
    private double _depositAmount;
    public void DepositingMoney()
    {
        _balance += _depositAmount;
    }
    public double PrintBalance()
    {
        return _balance;
    }

    public Deposits(double balance, double deposit)
    {
        _balance = balance;
        _depositAmount = deposit;
    }
}