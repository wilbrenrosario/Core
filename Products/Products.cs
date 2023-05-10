namespace Products
{
    public class Products
    {
        public DateTime Date { get; set; }

        public double Precio { get; set; }

        public double Impuestos => 0.16 * Precio;

        public string? Nombre { get; set; }
    }
}