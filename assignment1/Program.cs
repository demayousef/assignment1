Console.WriteLine("enter your invoice amount");
double amount= Convert.ToDouble(Console.ReadLine());

if (amount<= 0)
{
    Console.WriteLine($"invalid amount : {amount}");
}
else if(amount >= 500)
{
    double offer = amount * 20;

}
else if(amount < 500 && amount >= 300)
{

}
else if(amount < 300)
{

}
