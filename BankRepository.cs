
namespace bankproj
{
    class BankRepository : IBankRepository
    {
        List<SBAccount> sBAccounts=new List<SBAccount>();
        List<SBTranaction> sBTranactions=new List<SBTranaction>();
        public void DepositAmount(int accno, int amt,int c)
        {
            foreach(SBAccount i in sBAccounts)
            {
                if(i.AccountNumber==accno)
                {
                    i.CurrentBalance+=amt;
                    sBTranactions.Add(new SBTranaction(c,DateTime.Now,accno,i.CurrentBalance,"Deposit"));
                    break;
                }
                
            }
            
        }

        public SBAccount GetAccountDetails(int accno)
        {
            int c=0;
            foreach(SBAccount i in sBAccounts)
            {
                if(i.AccountNumber==accno)
                {
                    c++;
                    Console.WriteLine(i);
                    break;
                }
            }
            if(c==0)
            {
                Console.WriteLine("Account not found");
            }
            return new SBAccount();
        }

        public List<SBAccount> GetAllAccounts()
        {
            return sBAccounts;
        }

        public List<SBTranaction> GetTransactions(int accno)
        {
            List<SBTranaction> t=new List<SBTranaction>();
            foreach(SBTranaction i in sBTranactions)
            {
                if(i.AccountNumber==accno)
                {
                    t.Add(i);
                }
            }
            return t;
        }

        public void NewAccount(SBAccount acc)
        {
            sBAccounts.Add(new SBAccount(acc.AccountNumber,acc.CustomerName,acc.CustomerAddress,acc.CurrentBalance));
        }

        public void WithdrawAmount(int accno, int amt,int c)
        {
            foreach(SBAccount i in sBAccounts)
            {
                if(i.AccountNumber==accno)
                {
                    i.CurrentBalance-=amt;
                    sBTranactions.Add(new SBTranaction(c,DateTime.Now,accno,i.CurrentBalance,"Withdraw"));
                    break;
                }
                
            }
        }
    }
}