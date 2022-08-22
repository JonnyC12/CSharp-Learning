namespace avisosVarios
{
    internal class AvisosTrafico : IAvisos
    {
        private string Remitente;
        private string Mensaje;

        private string Fecha;

        public AvisosTrafico()
        {
            this.Remitente = "DGT";
            this.Mensaje = "Sancion cometida. Pague antes de 3 dias y se beneficiará de una reducción en la sanción";
            this.Fecha = "";

        }
        public AvisosTrafico(string Remitente, string Mensaje, string Fecha)
        {
            this.Remitente = Remitente;
            this.Mensaje = Mensaje;
            this.Fecha = Fecha;
        }
        public void MostrarAvisos()
        {
            Console.WriteLine($"Mensaje {Mensaje} ha sido enviado por {Remitente} el día {Fecha}");
        }
        public string GetFechas()
        {
            return Fecha;
        }
    }
}