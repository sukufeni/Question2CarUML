namespace Question2CarUML
{
    internal class HondaCity : Car
    {
        public HondaCity(int milenage) : base(milenage)
        {
            this.IsSedan = true;
            this.Seats = "4";
            this.Milenage = milenage;
        }
        internal override string GetMilenage()
        { 
            return this.Milenage + " kmpl";
        }
    }
}
