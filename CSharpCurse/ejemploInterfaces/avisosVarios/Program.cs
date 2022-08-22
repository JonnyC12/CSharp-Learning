using avisosVarios;


AvisosTrafico tipo = new AvisosTrafico();

tipo.MostrarAvisos();
AvisosTrafico personalizado = new AvisosTrafico("El rey", "el rey demanda su prensencia", DateTime.Now.ToShortDateString());

Console.WriteLine(personalizado.GetFechas());
personalizado.MostrarAvisos();