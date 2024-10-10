namespace C4_EN
{
    public class Proyecto
    {
        public int Id { get; set; }
        public string NombreProyecto { get; set; }
        public float CostoTotal { get; set; }
        public bool Descuento { get; set; }
        public string EstadoPago { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }

        public Proyecto()
        {

        }

        public Proyecto(string nombreProyecto, float costoTotal, bool descuento, string estadoPago, DateTime fechaInicio, DateTime fechaFinal)
        {
            NombreProyecto = nombreProyecto;
            CostoTotal = costoTotal;
            Descuento = descuento;
            EstadoPago = estadoPago;
            FechaInicio = fechaInicio;
            FechaFinal = fechaFinal;
        }
    }
}
