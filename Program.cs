
using System.Runtime.CompilerServices;
using BOOK.Class;
/**

Console.WriteLine("Kitob nomini kiriting");
string name = Console.ReadLine();
Console.WriteLine("Qanchaga sotib olmoqchisiz");
int narx = Convert.ToInt32(Console.ReadLine());
Book book = new Book(name, narx);

book.Author = "Malikshox";
book.Price = 236;
book.DisplayInfo();
book.DefirencePriceCalculate(narx);
*/

Console.WriteLine("Mashina Modelini kiriteng: ");
string model = Console.ReadLine();
Console.WriteLine("Mashina shlab chiqarilgan yilini kiriteng: ");
int years = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Mashina narxini kiriteng: ");
decimal price = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Mashina maksimal tezligini kiriteng: ");
decimal speed = Convert.ToDecimal(Console.ReadLine());

Car car = new Car(model, years, price, speed);
Console.WriteLine("Mashina haqida ma'lumot:");
Console.WriteLine(car.GetCarInfo());
Console.WriteLine("Necha yillik narx pasayishini chiqaray:");
int Year = Convert.ToInt32(Console.ReadLine());
car.CalculateDepreciation(Year);

