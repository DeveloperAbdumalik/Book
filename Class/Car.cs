namespace BOOK.Class
{
    public class Car
        {
            private string _model;
            private int _year;
            private Decimal _price;
            private Decimal _speed;

            public string Model { get; set; }
            public int Year { get; set; }
            public decimal Price { get; set; }
            public decimal Speed { get; set; }

            public Car(string model, int year, decimal price, decimal speed)
            {
                Model = model;
                Year = year;
                Price = price;
                Speed = speed;
            }

            public void CalculateDepreciation(int Year)
            {
                decimal depreciatedPrice = Price;
                decimal d;
                for (int i = 1; i <= Year; i++)
                {
                    depreciatedPrice -= depreciatedPrice * 0.1m; 
                    Console.WriteLine($"{i} yil o'tgandan keyin narx: {depreciatedPrice:C}");
                }
                
            }

             public string GetCarInfo()
            {
                return $"Model: {_model}, Year: {_year}, Price: {_price:C}, Speed: {_speed} km/h";
            }


        }

}