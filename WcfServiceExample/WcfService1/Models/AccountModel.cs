using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.Models
{
    public class AccountModel
    {
        private List<Account> accounts = new List<Account>();
        public AccountModel()
        {
            accounts.Add(new Account { UserName="Intesar",Password="123456"});
            accounts.Add(new Account { UserName = "Alam", Password = "123456" });
        }
        public bool Login(string UserName, string Password)
        {
            return accounts.Count(acc => acc.UserName.Equals(UserName) && acc.Password.Equals(Password))>0 ;
        }
    }
}