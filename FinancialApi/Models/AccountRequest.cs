using System;
using System.ComponentModel.DataAnnotations;

namespace FinancialApi.Models
{
    public class AccountRequest
    {
        [Required(ErrorMessage = "Укажите фамилию пользователя")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Укажите имя пользователя")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Укажите отчество пользователя")]
        public string Patronymic { get; set; }
        [Required(ErrorMessage = "Укажите дату рождения пользователя")]
        public DateTime Birthday { get; set; }
    }
}