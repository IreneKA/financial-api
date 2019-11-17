using System;

namespace FinancialApi.Models
{
    public class Account
    {
        public Guid Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birthday { get; set; }
        public double Balance { get; set; }

        public static Account CreateFromRequest(AccountRequest request)
        {
            return new Account()
            {
                Id = Guid.NewGuid(),
                LastName = request.LastName,
                FirstName = request.FirstName,
                Patronymic = request.Patronymic,
                Birthday = request.Birthday,
                Balance = 0
            };
        }
    }
}
