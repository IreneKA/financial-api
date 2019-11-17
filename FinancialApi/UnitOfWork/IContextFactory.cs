using FinancialApi.Models;

namespace FinancialApi.UnitOfWork
{
    public interface IContextFactory
    {
        AccountContext CreateContext();
    }
}