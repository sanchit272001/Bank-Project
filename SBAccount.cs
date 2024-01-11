namespace bankproj
{
    class SBAccount
    {
        public int AccountNumber{get;set;}
        public string? CustomerName{get;set;}
        public string? CustomerAddress{get;set;}
        public int CurrentBalance{get;set;}
        
        public SBAccount()
        {

        }

        public SBAccount(int accno,string ?name,string? address,int bal)
        {
            AccountNumber=accno;
            CustomerName=name;
            CustomerAddress=address;
            CurrentBalance=bal;
        }

        public override string ToString()
        {
            return AccountNumber+" "+CustomerName+" "+CustomerAddress+" "+CurrentBalance;
        }
    }

    class SBTranaction
    {
        public int TransactionId{get;set;}
        public DateTime TransactionDate{get;set;}
        public int AccountNumber{get;set;}
        public int Amount{get;set;}
        public string? TransactionType{get;set;}

        public SBTranaction()
        {

        }

        public SBTranaction(int tid,DateTime td, int acno,int amt, string ty)
        {
            TransactionId=tid;
            TransactionDate=td;
            AccountNumber=acno;
            Amount=amt;
            TransactionType=ty;
        }

        public override string ToString()
        {
            return TransactionId+" "+TransactionDate+" "+AccountNumber+" "+Amount+" "+TransactionType;
        }
    }
}