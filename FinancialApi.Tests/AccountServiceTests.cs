using System.Linq;
using System.Threading.Tasks;
using FinancialApi.Data;
using FinancialApi.Models;
using FinancialApi.Services;
using FinancialApi.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace FinancialApi.Tests
{
    public class AccountServiceTests
    {
        private readonly IAccountService service;
        
        public AccountServiceTests()
        {
            var options = new DbContextOptionsBuilder<AccountContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;

            var contextFactory = new ContextFactory(options);
            service = new AccountService(contextFactory);
        }

        [Fact]
        public async Task ReduceAndIncrease_DoReduceIncreaseFor50Users_SuccessReduceIncreaseForEveryUsers()
        {
            int threadsCount = 10;

            var requests = DbInitializer.CreateAccounts();

            requests.AsParallel().WithDegreeOfParallelism(threadsCount)
                .ForAll(request => { service.RegisterAccount(request); });

            var accounts = await service.GetAccounts();

            double increaseValue = 1000;
            double reduceValue = 500;
            accounts.AsParallel().WithDegreeOfParallelism(threadsCount)
                .ForAll(account =>
                {
                    service.Increase(account.Id, increaseValue);
                    service.Reduce(account.Id, reduceValue);
                });

            var resultAccounts = await service.GetAccounts();

            Assert.Equal(50, resultAccounts.Count);
            Assert.All(resultAccounts, account =>
                Assert.Equal(500, account.Balance));
        }
    }
}