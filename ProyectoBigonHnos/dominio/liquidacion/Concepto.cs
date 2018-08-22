namespace ProyectoBigonHnos.dominio.liquidacion
{
    class Concepto
    {
        public int IdConcepto { get; set; }
        public TipoConcepto Tipo { get; set; }
        public string Descripcion { get; set; } 
        public double Porcentaje { get; set; }
        public bool Obligatorio { get; set; }

        public Concepto(TipoConcepto tipo, string descripcion, double porcentaje, bool obligatorio)
        {
            Tipo = tipo; 
            Descripcion = descripcion;
            Obligatorio = obligatorio;

            SetPorcentaje(porcentaje);
        }

        public double aplicarPorcentaje(double valorBase)
        {
            if (Porcentaje == 0)
                return valorBase;

            return Porcentaje * valorBase;
        }
        
        private void SetPorcentaje(double porcentaje)
        {
            Porcentaje = porcentaje/100;
        }

        public override string ToString()
        {
            return string.Format("TIPO:{0}\nDESCRIPCION: {1}\nPORCENTAJE: {2}\nOBLIGATORIO: {3}", 
                Tipo, 
                Descripcion, 
                Porcentaje, 
                Obligatorio);
        }
    }

    enum TipoConcepto 
    {
        DESCUENTO,
        REMUNERATIVO,
        NO_REMUNERATIVO
    };
}
