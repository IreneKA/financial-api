using FinancialApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialApi.Data
{
    public class DbInitializer
    {
        public static void Initialize(AccountContext context)
        {
            context.Database.EnsureCreated();

            // проверяет, добавлены ли в базу данных аккаунты
            if (context.Accounts.Any())
            {
                return; 
            }

            Random rand = new Random();

            var accounts = new Account[]
            {
            new Account{LastName="Тредиаковский",FirstName="Давид",Patronymic="Святославович", Birthday = DateTime.Parse("1985-02-20"),Balance = 0},
            new Account{LastName="Яцунова",FirstName="Людмила",Patronymic="Антониновна", Birthday = DateTime.Parse("1969-01-30"),Balance = 0},
            new Account{LastName="Рассказова",FirstName="Алина",Patronymic="Виталиевна", Birthday = DateTime.Parse("1961-01-12"),Balance = 0},
            new Account{LastName="Коржаева",FirstName="Доминика",Patronymic="Захаровна", Birthday = DateTime.Parse("1954-10-06"),Balance = 0},
            new Account{LastName="Разин",FirstName="Эрнест",Patronymic="Михаилович", Birthday = DateTime.Parse("1974-04-03"),Balance = 0},
            new Account{LastName="Абумайлов",FirstName="Евсей",Patronymic="Федотович", Birthday = DateTime.Parse("1999-01-01"),Balance = 0},
            new Account{LastName="Даньшов",FirstName="Всеволод",Patronymic="Эдуардович", Birthday = DateTime.Parse("1987-06-16"),Balance = 0},
            new Account{LastName="Филимонов",FirstName="Мирослав",Patronymic="Куприянович", Birthday = DateTime.Parse("1975-09-03"),Balance = 0},
            new Account{LastName="Толбоев",FirstName="Рубен",Patronymic="Несторович", Birthday = DateTime.Parse("1973-03-19"),Balance = 0},
            new Account{LastName="Ванин",FirstName="Федот",Patronymic="Данилевич", Birthday = DateTime.Parse("1992-11-13"),Balance = 0},
            new Account{LastName="Клименко",FirstName="Влада",Patronymic="Ростиславовна", Birthday = DateTime.Parse("1971-11-02"),Balance = 0},
            new Account{LastName="Силиванова",FirstName="Рада",Patronymic="Глебовна", Birthday = DateTime.Parse("1979-04-25"),Balance = 0},
            new Account{LastName="Сухарев",FirstName="Родион",Patronymic="Артемиевич", Birthday = DateTime.Parse("1990-08-07"),Balance = 0},
            new Account{LastName="Зарубина",FirstName="Лиана",Patronymic="Василиевна", Birthday = DateTime.Parse("1951-04-20"),Balance = 0},
            new Account{LastName="Глазков",FirstName="Юлиан",Patronymic="Ираклиевич", Birthday = DateTime.Parse("1994-06-21"),Balance = 0},
            new Account{LastName="Ямковой",FirstName="Эдуард",Patronymic="Аполлинариевич", Birthday = DateTime.Parse("1962-02-15"),Balance = 0},
            new Account{LastName="Дёмшина",FirstName="Яна",Patronymic="Николаевна", Birthday = DateTime.Parse("1962-02-26"),Balance = 0},
            new Account{LastName="Гребнева",FirstName="Владислава",Patronymic="Карповна", Birthday = DateTime.Parse("1993-04-07"),Balance = 0},
            new Account{LastName="Иньшов",FirstName="Фома",Patronymic="Венедиктович", Birthday = DateTime.Parse("1976-08-27"),Balance = 0},
            new Account{LastName="Голованова",FirstName="Бронислава",Patronymic="Геннадиевна", Birthday = DateTime.Parse("1988-09-13"),Balance = 0},
            new Account{LastName="Панкин",FirstName="Гавриил",Patronymic="Евлампиевич", Birthday = DateTime.Parse("1987-10-26"),Balance = 0},
            new Account{LastName="Фонвизина",FirstName="Диана",Patronymic="Елизаровна", Birthday = DateTime.Parse("1987-08-04"),Balance = 0},
            new Account{LastName="Фоменков",FirstName="Аскольд",Patronymic="Самуилович", Birthday = DateTime.Parse("1954-03-01"),Balance = 0},
            new Account{LastName="Коршунова",FirstName="Владислава",Patronymic="Ростиславовна", Birthday = DateTime.Parse("1979-02-06"),Balance = 0},
            new Account{LastName="Цой",FirstName="Ксения",Patronymic="Давидовна", Birthday = DateTime.Parse("1986-09-11"),Balance = 0},
            new Account{LastName="Гребенщикова",FirstName="Юнона",Patronymic="Владленовна", Birthday = DateTime.Parse("1962-03-19"),Balance = 0},
            new Account{LastName="Столярова",FirstName="Агафья",Patronymic="Казимировна", Birthday = DateTime.Parse("1974-01-15"),Balance = 0},
            new Account{LastName="Чужинова",FirstName="Таисия",Patronymic="Тимуровна", Birthday = DateTime.Parse("1953-08-25"),Balance = 0},
            new Account{LastName="Фунтусов",FirstName="Всеволод",Patronymic="Арсениевич", Birthday = DateTime.Parse("1955-01-17"),Balance = 0},
            new Account{LastName="Васнецова",FirstName="Мария",Patronymic="Святославовна", Birthday = DateTime.Parse("1972-11-20"),Balance = 0},
            new Account{LastName="Бондарчука",FirstName="Зоя",Patronymic="Брониславовна", Birthday = DateTime.Parse("1970-06-08"),Balance = 0},
            new Account{LastName="Карташёва",FirstName="Ираида",Patronymic="Василиевна", Birthday = DateTime.Parse("1984-08-03"),Balance = 0},
            new Account{LastName="Корнилова",FirstName="Всеслава",Patronymic="Алексеевна", Birthday = DateTime.Parse("1971-02-05"),Balance = 0},
            new Account{LastName="Липов",FirstName="Прокофий",Patronymic="Макарович", Birthday = DateTime.Parse("1970-06-18"),Balance = 0},
            new Account{LastName="Увакин",FirstName="Фадей",Patronymic="Остапович", Birthday = DateTime.Parse("1958-07-24"),Balance = 0},
            new Account{LastName="Иволгин",FirstName="Борис",Patronymic="Саввевич", Birthday = DateTime.Parse("1990-06-27"),Balance = 0},
            new Account{LastName="Саянова",FirstName="Ева",Patronymic="Фомевна", Birthday = DateTime.Parse("1990-03-08"),Balance = 0},
            new Account{LastName="Топорков",FirstName="Валентин",Patronymic="Ильевич", Birthday = DateTime.Parse("1990-04-05"),Balance = 0},
            new Account{LastName="Тамаркин",FirstName="Аскольд",Patronymic="Аникитевич", Birthday = DateTime.Parse("1954-07-08"),Balance = 0},
            new Account{LastName="Витвинина",FirstName="Рената",Patronymic="Германовна", Birthday = DateTime.Parse("1983-08-15"),Balance = 0},
            new Account{LastName="Брюханова",FirstName="Берта",Patronymic="Петровна", Birthday = DateTime.Parse("1961-02-16"),Balance = 0},
            new Account{LastName="Сушилова",FirstName="Ефросинья",Patronymic="Семеновна", Birthday = DateTime.Parse("1963-05-22"),Balance = 0},
            new Account{LastName="Гачегова",FirstName="Каролина",Patronymic="Анатолиевна", Birthday = DateTime.Parse("1982-06-17"),Balance = 0},
            new Account{LastName="Вольваков",FirstName="Георгий",Patronymic="Захарович", Birthday = DateTime.Parse("1965-10-05"),Balance = 0},
            new Account{LastName="Кирилов",FirstName="Лев",Patronymic="Сигизмундович", Birthday = DateTime.Parse("1967-06-21"),Balance = 0},
            new Account{LastName="Санькова",FirstName="Наталия",Patronymic="Николаевна", Birthday = DateTime.Parse("1984-09-07"),Balance = 0},
            new Account{LastName="Сподарева",FirstName="Любовь",Patronymic="Борисовна", Birthday = DateTime.Parse("1967-07-21"),Balance = 0},
            new Account{LastName="Серебрякова",FirstName="Христина",Patronymic="Семеновна", Birthday = DateTime.Parse("2001-08-31"),Balance = 0},
            new Account{LastName="Дресвянин",FirstName="Елизар",Patronymic="Панкратиевич", Birthday = DateTime.Parse("1983-12-07"),Balance = 0},
            new Account{LastName="Доскаль",FirstName="Глеб",Patronymic="Мирославович", Birthday = DateTime.Parse("1992-05-28"),Balance = 0},
            };
            foreach (Account s in accounts)
            {
                s.Balance= rand.Next(0, 1000000);
            }
            foreach (Account s in accounts)
            {
                context.Accounts.Add(s);
            }
            context.SaveChanges();
        }
    }
}
