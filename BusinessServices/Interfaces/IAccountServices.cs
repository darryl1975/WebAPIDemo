﻿using EFDemo.Helpers;
using EFDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices.Interfaces
{
    public interface IAccountServices
    {
        PagedList<Account> GetAccountsByOwner(Guid ownerId, AccountParameters parameters);
        Account GetAccountByOwner(Guid ownerId, Guid id);
    }
}
