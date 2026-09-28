using System;

class BankAccount
{
    public string bank_number;
    public string user;
    public double balance = 0;
    public BankAccount(string bank_number, string user, double balance)
    {
        this.bank_number = bank_number;
        this.user = user;
        this.balance = balance;
    }
    public void Income(double number) => balance += number;
    public void Outcome(double number) 
    {
        if (number > balance) Console.WriteLine("Số dư không đủ");
        else balance -= number;
    }
    public void Info()
    {
        Console.WriteLine($"\nChủ tài khoản: {user}\nSố tài khoản: {bank_number}\nSố dư khả dụng: {balance}");
    }
}