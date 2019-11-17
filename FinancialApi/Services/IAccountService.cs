using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FinancialApi.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace FinancialApi.Services
{
    public interface IAccountService
    {
        Task<Account> GetAccount(Guid id);
        Task<List<Account>> GetAccounts();
        Task<double> GetBalance(Guid id);
        Task<Account> RegisterAccount(AccountRequest account);
        Task Increase(Guid id, double count);
        Task Reduce(Guid id, double count);
        Task DeleteAccount(Guid id);
    }
}