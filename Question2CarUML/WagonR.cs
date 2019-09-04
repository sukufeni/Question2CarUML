namespace Question2CarUML
{
    internal class WagonR : Car
    {
        public WagonR(int milenage) : base(milenage)
        {
            this.IsSedan = false;
            this.Seats = "4";
            this.Milenage = milenage;
        }

        internal override string GetMilenage()
        {
            return this.Milenage + " kmpl";
        }
    }
}
