namespace Question2CarUML
{
    internal class InnovaCrysta : Car
    {
        public InnovaCrysta(int milenage) : base(milenage)
        {
            this.IsSedan = false;
            this.Seats = "6";
            this.Milenage = milenage;
        }

        internal override string GetMilenage()
        {
            return this.Milenage + " kmpl";
        }
    }
}
