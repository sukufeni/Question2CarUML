using System.Text;

namespace Question2CarUML
{
    internal abstract class Car
    {
        protected bool IsSedan { get; set; }
        protected string Seats { get; set; }
        public int Milenage { get; set; }
        internal virtual bool GetIsSedan()
        {
            return this.IsSedan;
        }
        internal virtual string GetSeats()
        {
            return this.Seats;
        }
        internal abstract string GetMilenage();

        public Car(int milenage)
        {
            this.Milenage = milenage;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(" is");
            builder.Append(this.IsSedan ? " " : " not Sedan,");
            builder.Append($" is {this.Seats}-seater, ");
            builder.Append($" and has a mileage of around: " + GetMilenage());
            return builder.ToString();
        }
    }
}
