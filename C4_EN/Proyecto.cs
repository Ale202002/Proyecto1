namespace C4_EN
{
    public class Proyecto
    {
        private int id;
        private string nombreProyecto;
        private float costoTotal;
        private bool descuento;
        private string estadoPago;
        private DateTime fechaInicio;
        private DateTime fechaFinal;

        public Proyecto()
        {

        }

        public int Id { get => id; set => id = value; }
        public string NombreProyecto { get => nombreProyecto; set => nombreProyecto = value; }
        public float CostoTotal { get => costoTotal; set => costoTotal = value; }
        public bool Descuento { get => descuento; set => descuento = value; }
        public string EstadoPago { get => estadoPago; set => estadoPago = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFinal { get => fechaFinal; set => fechaFinal = value; }
    }
}
