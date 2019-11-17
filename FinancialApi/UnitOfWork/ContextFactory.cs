using FinancialApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FinancialApi.UnitOfWork
{
    public class ContextFactory : IContextFactory
    {
        private readonly DbContextOptions options;
        
        public ContextFactory(DbContextOptions options)
        {
            this.options = options;
        }
        
        public AccountContext CreateContext()
        {
            var context = new AccountContext(options);
            return context;
        }
    }
}