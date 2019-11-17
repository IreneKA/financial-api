using FinancialApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialApi.Data
{
    public class DbInitializer
    {
        public static AccountRequest[] CreateAccounts()
        {
            var accounts = new []
            {
                new AccountRequest
                {
                    LastName = "Тредиаковский", FirstName = "Давид", Patronymic = "Святославович",
                    Birthday = DateTime.Parse("1985-02-20")
                },
                new AccountRequest
                {
                    LastName = "Яцунова", FirstName = "Людмила", Patronymic = "Антониновна",
                    Birthday = DateTime.Parse("1969-01-30")
                },
                new AccountRequest
                {
                    LastName = "Рассказова", FirstName = "Алина", Patronymic = "Виталиевна",
                    Birthday = DateTime.Parse("1961-01-12")
                },
                new AccountRequest
                {
                    LastName = "Коржаева", FirstName = "Доминика", Patronymic = "Захаровна",
                    Birthday = DateTime.Parse("1954-10-06")
                },
                new AccountRequest
                {
                    LastName = "Разин", FirstName = "Эрнест", Patronymic = "Михаилович",
                    Birthday = DateTime.Parse("1974-04-03")
                },
                new AccountRequest
                {
                    LastName = "Абумайлов", FirstName = "Евсей", Patronymic = "Федотович",
                    Birthday = DateTime.Parse("1999-01-01")
                },
                new AccountRequest
                {
                    LastName = "Даньшов", FirstName = "Всеволод", Patronymic = "Эдуардович",
                    Birthday = DateTime.Parse("1987-06-16")
                },
                new AccountRequest
                {
                    LastName = "Филимонов", FirstName = "Мирослав", Patronymic = "Куприянович",
                    Birthday = DateTime.Parse("1975-09-03")
                },
                new AccountRequest
                {
                    LastName = "Толбоев", FirstName = "Рубен", Patronymic = "Несторович",
                    Birthday = DateTime.Parse("1973-03-19")
                },
                new AccountRequest
                {
                    LastName = "Ванин", FirstName = "Федот", Patronymic = "Данилевич", 
                    Birthday = DateTime.Parse("1992-11-13")
                },
                new AccountRequest
                {
                    LastName = "Клименко", FirstName = "Влада", Patronymic = "Ростиславовна",
                    Birthday = DateTime.Parse("1971-11-02")
                },
                new AccountRequest
                {
                    LastName = "Силиванова", FirstName = "Рада", Patronymic = "Глебовна",
                    Birthday = DateTime.Parse("1979-04-25")
                },
                new AccountRequest
                {
                    LastName = "Сухарев", FirstName = "Родион", Patronymic = "Артемиевич",
                    Birthday = DateTime.Parse("1990-08-07")
                },
                new AccountRequest
                {
                    LastName = "Зарубина", FirstName = "Лиана", Patronymic = "Василиевна",
                    Birthday = DateTime.Parse("1951-04-20")
                },
                new AccountRequest
                {
                    LastName = "Глазков", FirstName = "Юлиан", Patronymic = "Ираклиевич",
                    Birthday = DateTime.Parse("1994-06-21")
                },
                new AccountRequest
                {
                    LastName = "Ямковой", FirstName = "Эдуард", Patronymic = "Аполлинариевич",
                    Birthday = DateTime.Parse("1962-02-15")
                },
                new AccountRequest
                {
                    LastName = "Дёмшина", FirstName = "Яна", Patronymic = "Николаевна", 
                    Birthday = DateTime.Parse("1962-02-26")
                },
                new AccountRequest
                {
                    LastName = "Гребнева", FirstName = "Владислава", Patronymic = "Карповна",
                    Birthday = DateTime.Parse("1993-04-07")
                },
                new AccountRequest
                {
                    LastName = "Иньшов", FirstName = "Фома", Patronymic = "Венедиктович",
                    Birthday = DateTime.Parse("1976-08-27")
                },
                new AccountRequest
                {
                    LastName = "Голованова", FirstName = "Бронислава", Patronymic = "Геннадиевна",
                    Birthday = DateTime.Parse("1988-09-13")
                },
                new AccountRequest
                {
                    LastName = "Панкин", FirstName = "Гавриил", Patronymic = "Евлампиевич",
                    Birthday = DateTime.Parse("1987-10-26")
                },
                new AccountRequest
                {
                    LastName = "Фонвизина", FirstName = "Диана", Patronymic = "Елизаровна",
                    Birthday = DateTime.Parse("1987-08-04")
                },
                new AccountRequest
                {
                    LastName = "Фоменков", FirstName = "Аскольд", Patronymic = "Самуилович",
                    Birthday = DateTime.Parse("1954-03-01")
                },
                new AccountRequest
                {
                    LastName = "Коршунова", FirstName = "Владислава", Patronymic = "Ростиславовна",
                    Birthday = DateTime.Parse("1979-02-06")
                },
                new AccountRequest
                {
                    LastName = "Цой", FirstName = "Ксения", Patronymic = "Давидовна", 
                    Birthday = DateTime.Parse("1986-09-11")
                },
                new AccountRequest
                {
                    LastName = "Гребенщикова", FirstName = "Юнона", Patronymic = "Владленовна",
                    Birthday = DateTime.Parse("1962-03-19")
                },
                new AccountRequest
                {
                    LastName = "Столярова", FirstName = "Агафья", Patronymic = "Казимировна",
                    Birthday = DateTime.Parse("1974-01-15")
                },
                new AccountRequest
                {
                    LastName = "Чужинова", FirstName = "Таисия", Patronymic = "Тимуровна",
                    Birthday = DateTime.Parse("1953-08-25")
                },
                new AccountRequest
                {
                    LastName = "Фунтусов", FirstName = "Всеволод", Patronymic = "Арсениевич",
                    Birthday = DateTime.Parse("1955-01-17")
                },
                new AccountRequest
                {
                    LastName = "Васнецова", FirstName = "Мария", Patronymic = "Святославовна",
                    Birthday = DateTime.Parse("1972-11-20")
                },
                new AccountRequest
                {
                    LastName = "Бондарчука", FirstName = "Зоя", Patronymic = "Брониславовна",
                    Birthday = DateTime.Parse("1970-06-08")
                },
                new AccountRequest
                {
                    LastName = "Карташёва", FirstName = "Ираида", Patronymic = "Василиевна",
                    Birthday = DateTime.Parse("1984-08-03")
                },
                new AccountRequest
                {
                    LastName = "Корнилова", FirstName = "Всеслава", Patronymic = "Алексеевна",
                    Birthday = DateTime.Parse("1971-02-05")
                },
                new AccountRequest
                {
                    LastName = "Липов", FirstName = "Прокофий", Patronymic = "Макарович",
                    Birthday = DateTime.Parse("1970-06-18")
                },
                new AccountRequest
                {
                    LastName = "Увакин", FirstName = "Фадей", Patronymic = "Остапович", 
                    Birthday = DateTime.Parse("1958-07-24")
                },
                new AccountRequest
                {
                    LastName = "Иволгин", FirstName = "Борис", Patronymic = "Саввевич", 
                    Birthday = DateTime.Parse("1990-06-27")
                },
                new AccountRequest
                {
                    LastName = "Саянова", FirstName = "Ева", Patronymic = "Фомевна", 
                    Birthday = DateTime.Parse("1990-03-08")
                },
                new AccountRequest
                {
                    LastName = "Топорков", FirstName = "Валентин", Patronymic = "Ильевич",
                    Birthday = DateTime.Parse("1990-04-05")
                },
                new AccountRequest
                {
                    LastName = "Тамаркин", FirstName = "Аскольд", Patronymic = "Аникитевич",
                    Birthday = DateTime.Parse("1954-07-08")
                },
                new AccountRequest
                {
                    LastName = "Витвинина", FirstName = "Рената", Patronymic = "Германовна",
                    Birthday = DateTime.Parse("1983-08-15")
                },
                new AccountRequest
                {
                    LastName = "Брюханова", FirstName = "Берта", Patronymic = "Петровна",
                    Birthday = DateTime.Parse("1961-02-16")
                },
                new AccountRequest
                {
                    LastName = "Сушилова", FirstName = "Ефросинья", Patronymic = "Семеновна",
                    Birthday = DateTime.Parse("1963-05-22")
                },
                new AccountRequest
                {
                    LastName = "Гачегова", FirstName = "Каролина", Patronymic = "Анатолиевна",
                    Birthday = DateTime.Parse("1982-06-17")
                },
                new AccountRequest
                {
                    LastName = "Вольваков", FirstName = "Георгий", Patronymic = "Захарович",
                    Birthday = DateTime.Parse("1965-10-05")
                },
                new AccountRequest
                {
                    LastName = "Кирилов", FirstName = "Лев", Patronymic = "Сигизмундович",
                    Birthday = DateTime.Parse("1967-06-21")
                },
                new AccountRequest
                {
                    LastName = "Санькова", FirstName = "Наталия", Patronymic = "Николаевна",
                    Birthday = DateTime.Parse("1984-09-07")
                },
                new AccountRequest
                {
                    LastName = "Сподарева", FirstName = "Любовь", Patronymic = "Борисовна",
                    Birthday = DateTime.Parse("1967-07-21")
                },
                new AccountRequest
                {
                    LastName = "Серебрякова", FirstName = "Христина", Patronymic = "Семеновна",
                    Birthday = DateTime.Parse("2001-08-31")
                },
                new AccountRequest
                {
                    LastName = "Дресвянин", FirstName = "Елизар", Patronymic = "Панкратиевич",
                    Birthday = DateTime.Parse("1983-12-07")
                },
                new AccountRequest
                {
                    LastName = "Доскаль", FirstName = "Глеб", Patronymic = "Мирославович",
                    Birthday = DateTime.Parse("1992-05-28")
                },
            };

            return accounts;
        }
    }
}
