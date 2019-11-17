using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FinancialApi.Models;
using FinancialApi.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace FinancialApi.Services
{
    public class AccountService : IAccountService
    {
        private readonly IContextFactory contextFactory;
        
        public AccountService(IContextFactory contextFactory)
        {
            this.contextFactory = contextFactory;
        }
        
        public async Task<Account> GetAccount(Guid id)
        {
            using (var context = contextFactory.CreateContext())
            {
                var account = await context.Accounts.FindAsync(id);

                if (account == null)
                {
                    throw new Exception("Аккаунт с таким Id не найден.");
                }

                return account;
            }
        }

        public async Task<List<Account>> GetAccounts()
        {
            using (var context = contextFactory.CreateContext())
            {
                return await context.Accounts.ToListAsync();
            }
        }

        public async Task<double> GetBalance(Guid id)
        {
            using (var context = contextFactory.CreateContext())
            {
                var account = await context.Accounts.FindAsync(id);

                if (account == null)
                {
                    throw new Exception("Аккаунт с таким Id не найден.");
                }

                return account.Balance;
            }
        }

        public async Task<Account> RegisterAccount(AccountRequest request)
        {
            var account = Account.CreateFromRequest(request);

            using (var context = contextFactory.CreateContext())
            {
                await context.Accounts.AddAsync(account);
                await context.SaveChangesAsync();

                var createdAccount = await context.Accounts.FirstOrDefaultAsync(x => x.Id == account.Id);

                return createdAccount;
            }
        }

        public async Task Increase(Guid id, double count)
        {
            if (count < 0)
            {
                throw new Exception("Сумма пополнения не может быть меньше нуля.");
            }

            using (var context = contextFactory.CreateContext())
            {
                var account = await context.Accounts.FirstOrDefaultAsync(x => x.Id == id);

                if (account == null)
                {
                    throw new Exception("Аккаунт с таким Id не найден.");
                }

                account.Balance += count;

                await context.SaveChangesAsync();
            }
        }

        public async Task Reduce(Guid id, double count)
        {
            if (count < 0)
            {
                throw new Exception("Сумма списания не может быть меньше нуля.");
            }

            using (var context = contextFactory.CreateContext())
            {
                var account = await context.Accounts.FirstOrDefaultAsync(x => x.Id == id);

                if (account == null)
                {
                    throw new Exception("Аккаунт с таким Id не найден.");
                }

                var balance = account.Balance - count;

                if (balance < 0)
                {
                    throw new Exception("Недостаточно средств.");
                }

                account.Balance = balance;

                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteAccount(Guid id)
        {
            using (var context = contextFactory.CreateContext())
            {
                var account = await context.Accounts.FindAsync(id);

                if (account == null)
                {
                    throw new Exception("Аккаунт с таким Id не найден.");
                }

                context.Accounts.Remove(account);
                await context.SaveChangesAsync();
            }
        }
    }
}