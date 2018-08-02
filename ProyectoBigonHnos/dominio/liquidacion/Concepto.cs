namespace ProyectoBigonHnos.dominio.liquidacion
{
    class Concepto
    {
        //public int IdConcepto { get; set; }
        public TipoConcepto Tipo { get; set; }
        public string Descripcion { get; set; } 
        public double porcentaje { get; set; }
        public bool Obligatorio { get; set; }

        public Concepto(TipoConcepto tipo, string descripcion, double porcentaje, bool obligatorio)
        {
            Tipo = tipo; 
            Descripcion = descripcion;
            porcentaje = porcentaje;
            Obligatorio = obligatorio;
        }
    }

    enum TipoConcepto 
    {
        DESCUENTO,
        REMUNERATIVO,
        NO_REMUNERATIVO
    };
}
