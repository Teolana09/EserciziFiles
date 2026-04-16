namespace EserciziFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DateTime ora = DateTime.Now;
            string utente;
            string sistema;
            string Risoluzione;

            string cartella = "Configurazione";
            string nomeFile = "impostazioni.log";
            if (!Directory.Exists(cartella))
            {
                Directory.CreateDirectory(cartella);
            }
            string path = Path.Combine(cartella, nomeFile);
            
            
            Console.WriteLine("--------------------------------------------------------------------");
            List<string> info_sistema = new List<string>();
            using (StreamReader sr = new StreamReader("info_sistema.txt"))
            {
                string riga = sr.ReadLine();
                while (riga != null)
                {
                    info_sistema.Add(riga);      
                    riga = sr.ReadLine(); 
                }
            }            
            
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("[SESSION START]" + ora);
                
                sw.WriteLine("Utente = >" + info_sistema[0]);
                sw.WriteLine("Sistema = >" + info_sistema[1]);
                sw.WriteLine("Risoluzione = >" + info_sistema[2]);
                sw.WriteLine("LINGUA => IT\r\nLIVELLO => ADMIN\r\nAUTOSAVE => ATTIVO\r\n");
                sw.WriteLine("--------------------");
                sw.WriteLine("EOF");


            }

        }
    }
}
