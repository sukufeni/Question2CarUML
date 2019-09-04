using System;

namespace Question2CarUML
{
    class Program
    {

        static void Main(string[] args)
        {
            int carType = 0;
            int Carmilenage = 0;

            WagonR wagon;
            InnovaCrysta crysta;
            HondaCity city;
            //0 - WagonR
            //1 - HondaCity
            //2 - InnovaCrysta

            #region Car Instantiation
            carType = GetCarType();

            //Milenage
            Carmilenage = GetCarmilenage();

            switch (carType)
            {
                case 0:
                    wagon = new WagonR(Carmilenage);
                    Console.WriteLine("WagonR " + wagon.ToString());
                    break;
                case 1:
                    city = new HondaCity(Carmilenage);
                    Console.WriteLine("Honda City " + city.ToString());
                    break;
                case 2:
                    crysta = new InnovaCrysta(Carmilenage);
                    Console.WriteLine("InnovaCrystal " + crysta.ToString());
                    break;
            }
            #endregion
            Console.ReadLine();
        }

        private static int GetCarmilenage()
        {
            int Carmilenage;
            Console.WriteLine("Now, Please input the car Milenage");
            int.TryParse(Console.ReadLine(), out Carmilenage);
            while (Carmilenage > 30 || Carmilenage < 5)
            {
                Console.WriteLine("The car Milenage must be between 5 and 30!");
                int.TryParse(Console.ReadLine(), out Carmilenage);
            }

            return Carmilenage;
        }

        private static int GetCarType()
        {
            int carType;
            Console.WriteLine(@"Please, provide: 
            0 - WagonR
            1 - HondaCity
            2 - InnovaCrysta");
            int.TryParse(Console.ReadLine(), out carType);
            return carType;
        }
    }
}
