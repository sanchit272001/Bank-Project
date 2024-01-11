namespace bankproj
{
    interface IBankRepository
    {
        void NewAccount(SBAccount acc);
        List<SBAccount> GetAllAccounts();
        SBAccount GetAccountDetails(int accno);
        void DepositAmount(int accno,int amt,int id);
        void WithdrawAmount(int accno,int amt,int id);
        List<SBTranaction>GetTransactions(int accno);

    }
}