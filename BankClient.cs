namespace bankproj
{
    class BankClient
    {
        public static void Main()
        {
            IBankRepository s=new BankRepository();
            int c=0;
            while(true)
            {
                int acc=1;
                Console.WriteLine("Press 1 to create account, 2 to Get account details, 3 to deposit, 4 to withdraw, 5 to transaction statement, 6 to exit");
                int x=Convert.ToInt32(Console.ReadLine());
                if(x==1)
                {
                    Console.WriteLine("Enter name");
                    string? name=Console.ReadLine();
                    Console.WriteLine("Enter place");
                    string? add=Console.ReadLine();
                    Console.WriteLine("Enter starting Balance");
                    int x1=Convert.ToInt32(Console.ReadLine());
                    s.NewAccount(new SBAccount(acc,name,add,x1));
                    acc++;
                }
                if(x==2)
                {
                    Console.WriteLine("Enter account number which you want to search");
                    int y=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(s.GetAccountDetails(y));
                }
                if(x==3)
                {
                    c++;
                    Console.WriteLine("Enter account number in which you want to deposit");
                    int d=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Amount you want to deposit");
                    int d1=Convert.ToInt32(Console.ReadLine());
                    s.DepositAmount(d,d1,c);
                }
                if(x==4)
                {
                    c++;
                    Console.WriteLine("Enter account number in which you want to withdraw");
                    int d=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Amount you want to withdraw");
                    int d1=Convert.ToInt32(Console.ReadLine());
                    s.WithdrawAmount(d,d1,c);
                }
                if(x==5)
                {
                    Console.WriteLine("Enter account number in which you want transactions");
                    int d=Convert.ToInt32(Console.ReadLine());
                    List<SBTranaction> l=s.GetTransactions(d);
                    foreach(SBTranaction v in l)
                    {
                        Console.WriteLine(v);
                    }
                }
                if(x==6)
                {
                    break;
                }
            }
        }
    }
}