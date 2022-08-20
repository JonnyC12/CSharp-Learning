using System;
using System.IO;
using System.Globalization;
namespace simpleLog

{
    class LogClass
    {
        private string Path;
        public LogClass(string Path)
        {
            this.Path = Path;
            CreateFile();
        }
        private void CreateFile()
        {
            if (!File.Exists(Path))
            {
                File.Create(Path);
            }
        }
        public void Write(string? date)
        {
            CultureInfo esp = new CultureInfo("es-Es");
            DateTime stringToDate = Convert.ToDateTime(date, esp);
            File.AppendAllText(Path, $"Fecha del log: {stringToDate.ToString("dddd", esp)},{stringToDate.Day} de {stringToDate.ToString("MMMM", esp)} de {stringToDate.Year.ToString()} \n");
        }

        public string Read()
        {
            string contain = File.ReadAllText(Path);
            return contain;
        }

    }
}