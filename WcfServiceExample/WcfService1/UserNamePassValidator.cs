using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Web;
using WcfService1.Models;

namespace WcfService1
{
    public class UserNamePassValidator : UserNamePasswordValidator
    {
        public override void Validate(string UserName, string Password)
        {
            AccountModel account = new AccountModel();
            if (account.Login(UserName, Password))
                return;
            throw new SecurityTokenException("Invalid User");
        }
    }
}