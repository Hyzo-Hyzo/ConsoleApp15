using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp15
{
    namespace GiftAssistant
    {
        class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }

            public Product(string name, decimal price)
            {
                Name = name;
                Price = price;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Ласкаво просимо до Помічника з подарунками!");
                Console.WriteLine("Введіть, будь ласка, кого ви хочете привітати (мама, батько, сестра, брат, кращий друг):");
                string recipient = Console.ReadLine();

                Console.WriteLine("Введіть, будь ласка, свято, на яке потрібно придбати подарунок (день народження, новий рік, день ангела, Хелловін):");
                string occasion = Console.ReadLine();

                Console.WriteLine("Введіть, будь ласка, бажаний вік отримувача (наприклад, 25):");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Введіть, будь ласка, бажану суму для подарунка (наприклад, 1):");
                decimal budget = decimal.Parse(Console.ReadLine());

                List<Product> products = GetProducts(recipient, occasion, age);
                List<string> giftIdeas = GetGiftIdeas(products, budget);

                Console.WriteLine("Ось список ідей для подарунків:");
                foreach (string gift in giftIdeas)
                {
                    Console.WriteLine("- " + gift);
                }

                Console.WriteLine("Дякую за використання Помічника з подарунками. Гарного святкування!");

                Console.ReadLine();
            }

            static List<Product> GetProducts(string recipient, string occasion, int age)
            {
                List<Product> products = new List<Product>();

                if (recipient == "мама")
                {
                    if (occasion == "день народження")
                    {
                        if (age >= 0 && age <= 10)
                        {
                            products.Add(new Product("Лялька", 200));
                            products.Add(new Product("Книжка для дітей", 150));
                            products.Add(new Product("Кольорові олівці", 100));
                            products.Add(new Product("М'яка іграшка", 300));
                            products.Add(new Product("Дитячий набір для творчості", 250));
                        }
                        else if (age >= 11 && age <= 16)
                        {
                            products.Add(new Product("Книга фентезі", 350));
                            products.Add(new Product("Набір для розмальовки по номерах", 300));
                            products.Add(new Product("Стильні сережки", 200));
                            products.Add(new Product("Комплект одягу", 500));
                            products.Add(new Product("Ігрова консоль", 1000));
                        }
                        else if (age >= 17 && age <= 18)
                        {
                            products.Add(new Product("Ароматична свічка", 150));
                            products.Add(new Product("Набір для манікюру", 200));
                            products.Add(new Product("Книга по саморозвитку", 250));
                            products.Add(new Product("Сумка", 400));
                            products.Add(new Product("Подарунковий сертифікат на масаж", 800));
                        }
                        else if (age >= 19 && age <= 30)
                        {
                            products.Add(new Product("Косметичний набір", 300));
                            products.Add(new Product("Книга бестселер", 250));
                            products.Add(new Product("Блузка", 500));
                            products.Add(new Product("Подорож", 5000));
                            products.Add(new Product("Фітнес-браслет", 1000));
                        }
                        else if (age >= 30 && age <= 65)
                        {
                            products.Add(new Product("Шарф", 200));
                            products.Add(new Product("Парфуми", 600));
                            products.Add(new Product("Коштовні прикраси", 1000));
                            products.Add(new Product("Сумка", 800));
                            products.Add(new Product("Спа-сеанс", 2000));
                        }
                        else if (age >= 66 && age <= 100)
                        {
                            products.Add(new Product("Книга класики", 150));
                            products.Add(new Product("Комплект чаю", 200));
                            products.Add(new Product("М'який плед", 300));
                            products.Add(new Product("Подарункова кошик з продуктами", 500));
                            products.Add(new Product("Садовий набір", 400));
                        }
                    }
                    else if (occasion == "новий рік")
                    {
                        if (age >= 0 && age <= 10)
                        {
                            products.Add(new Product("Набір для творчості", 250));
                            products.Add(new Product("Плюшева іграшка", 200));
                            products.Add(new Product("Набір картик з вітаннями", 150));
                            products.Add(new Product("Іграшкова машинка", 300));
                            products.Add(new Product("Книжка з казками", 200));
                        }
                        else if (age >= 11 && age <= 16)
                        {
                            products.Add(new Product("Новорічний гірлянда", 300));
                            products.Add(new Product("Скейтборд", 800));
                            products.Add(new Product("Настільна гра", 500));
                            products.Add(new Product("Косметичний набір", 400));
                            products.Add(new Product("Музичний інструмент", 1000));
                        }
                        else if (age >= 17 && age <= 18)
                        {
                            products.Add(new Product("Святкова сукня", 1000));
                            products.Add(new Product("Декоративна косметика", 600));
                            products.Add(new Product("Аксесуари для волосся", 200));
                            products.Add(new Product("Парфуми", 800));
                            products.Add(new Product("Коштовні прикраси", 1500));
                        }
                        else if (age >= 19 && age <= 30)
                        {
                            products.Add(new Product("Стильна сумка", 800));
                            products.Add(new Product("Подарунковий сертифікат на шопінг", 1000));
                            products.Add(new Product("Набір для чаювання", 400));
                            products.Add(new Product("Фітнес-постер", 200));
                            products.Add(new Product("Книга по саморозвитку", 250));
                        }
                        else if (age >= 30 && age <= 65)
                        {
                            products.Add(new Product("Косметичний набір", 500));
                            products.Add(new Product("Масажний крісло", 3000));
                            products.Add(new Product("Книга-бестселер", 300));
                            products.Add(new Product("Парфуми", 600));
                            products.Add(new Product("Абонемент в спортзал", 1000));
                        }
                        else if (age >= 66 && age <= 100)
                        {
                            products.Add(new Product("Скатертина з новорічним малюнком", 150));
                            products.Add(new Product("Набір для приготування кулінарних шедеврів", 200));
                            products.Add(new Product("Подарунковий набір з чаєм", 300));
                            products.Add(new Product("Вишукані конфети", 400));
                            products.Add(new Product("Книга рецептів", 250));
                        }
                    }
                    else if (occasion == "день ангела")
                    {
                        if (age >= 0 && age <= 10)
                        {
                            products.Add(new Product("Музична іграшка", 300));
                            products.Add(new Product("Набір для творчості", 250));
                            products.Add(new Product("Книга для дітей", 200));
                            products.Add(new Product("Плюшева іграшка", 200));
                            products.Add(new Product("Конструктор", 400));
                        }
                        else if (age >= 11 && age <= 16)
                        {
                            products.Add(new Product("Стильний годинник", 800));
                            products.Add(new Product("Музичний інструмент", 1000));
                            products.Add(new Product("Книга-бестселер", 400));
                            products.Add(new Product("Набір для творчості", 350));
                            products.Add(new Product("Мобільний телефон", 1500));
                        }
                        else if (age >= 17 && age <= 18)
                        {
                            products.Add(new Product("Подарунковий сертифікат на одяг", 1000));
                            products.Add(new Product("Коштовні прикраси", 1500));
                            products.Add(new Product("Стильна сумка", 800));
                            products.Add(new Product("Парфуми", 600));
                            products.Add(new Product("Смарт-годинник", 1000));
                        }
                        else if (age >= 19 && age <= 30)
                        {
                            products.Add(new Product("Спортивні товари", 500));
                            products.Add(new Product("Книга по саморозвитку", 250));
                            products.Add(new Product("Електронна книга", 400));
                            products.Add(new Product("Подорож", 5000));
                            products.Add(new Product("Косметичний набір", 300));
                        }
                        else if (age >= 30 && age <= 65)
                        {
                            products.Add(new Product("Парфуми", 600));
                            products.Add(new Product("Масажний крісло", 3000));
                            products.Add(new Product("Книга класики", 300));
                            products.Add(new Product("Спа-сеанс", 2000));
                            products.Add(new Product("Подарунковий сертифікат на послуги салону краси", 1000));
                        }
                        else if (age >= 66 && age <= 100)
                        {
                            products.Add(new Product("Квіти", 200));
                            products.Add(new Product("Книга поезій", 150));
                            products.Add(new Product("Солодкі подарунки", 300));
                            products.Add(new Product("Косметичний набір", 500));
                            products.Add(new Product("Кулон зі шпилькою", 400));
                        }
                    }
                    else if (occasion == "Хелловін")
                    {
                        if (age >= 0 && age <= 10)
                        {
                            products.Add(new Product("Костюм маленької відьми", 400));
                            products.Add(new Product("Маскарадний костюм піратки", 500));
                            products.Add(new Product("Книга жахів для дітей", 300));
                            products.Add(new Product("Набір для малювання монстрів", 200));
                            products.Add(new Product("Плюшевий зловісний монстр", 250));
                        }
                        else if (age >= 11 && age <= 16)
                        {
                            products.Add(new Product("Костюм зомбі", 600));
                            products.Add(new Product("Маска жахів", 300));
                            products.Add(new Product("Настільна гра жахів", 500));
                            products.Add(new Product("Книга жахів для підлітків", 400));
                            products.Add(new Product("Скейтборд зі зображенням черепа", 800));
                        }
                        else if (age >= 17 && age <= 18)
                        {
                            products.Add(new Product("Костюм вампіра", 1000));
                            products.Add(new Product("Маска зловісного клоуна", 600));
                            products.Add(new Product("Ароматизатор повітря в формі павука", 200));
                            products.Add(new Product("Книга жахів", 800));
                            products.Add(new Product("Декоративний косметичний набір", 500));
                        }
                        else if (age >= 19 && age <= 30)
                        {
                            products.Add(new Product("Страшний футболка", 300));
                            products.Add(new Product("Костюм привида", 500));
                            products.Add(new Product("Набір для макіяжу з ефектом крові", 400));
                            products.Add(new Product("Книга страшних історій", 250));
                            products.Add(new Product("Запис на вечірку-квест", 1000));
                        }
                        else if (age >= 30 && age <= 65)
                        {
                            products.Add(new Product("Крихітна ліхтарик", 200));
                            products.Add(new Product("Кіносеанс у стилі жахів", 600));
                            products.Add(new Product("Набір для розмальовки страшних малюнків", 300));
                            products.Add(new Product("Книга страшних романів", 300));
                            products.Add(new Product("Спа-сеанс з використанням засобів з ефектом крові", 2000));
                        }
                        else if (age >= 66 && age <= 100)
                        {
                            products.Add(new Product("Подарункова коробка зі страшними сюрпризами", 500));
                            products.Add(new Product("Книга страшних поезій", 150));
                            products.Add(new Product("Містична статуетка", 400));
                            products.Add(new Product("Маскарадна костюмна фуражка", 200));
                            products.Add(new Product("Подарунковий сертифікат на екскурсію до страшного місця", 800));
                        }
                    }
                }
                else if (recipient == "батько")
                {
                    // Додайте варіанти подарунків для батька для кожного віку та свята
                    // ...
                }
                else if (recipient == "сестра")
                {
                    // Додайте варіанти подарунків для сестри для кожного віку та свята
                    // ...
                }
                else if (recipient == "брат")
                {
                    // Додайте варіанти подарунків для брата для кожного віку та свята
                    // ...
                }
                else if (recipient == "кращий друг")
                {
                    // Додайте варіанти подарунків для кращого друга для кожного віку та свята
                    // ...
                }

                return products;
            }

            static List<string> GetGiftIdeas(List<Product> products, decimal budget)
            {
                List<string> giftIdeas = new List<string>();

                foreach (Product product in products)
                {
                    if (product.Price <= budget)
                    {
                        giftIdeas.Add(product.Name);
                    }
                }

                return giftIdeas;
            }
        }
    }
}