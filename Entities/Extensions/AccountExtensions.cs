using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Extensions
{
    public static class AccountExtensions
    {
        public static void Map(this Account dbAccount, Account account)
        {
            dbAccount.Id = account.Id;
            dbAccount.AccountType = account.AccountType;
            dbAccount.OwnerId = account.OwnerId;
        }
    }
}
