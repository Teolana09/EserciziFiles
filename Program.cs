namespace EserciziFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cartella = "Configrazione";
            string nomeFile = "impostazioni.log";
            if (!Directory.Exists(cartella))
            {
                Directory.CreateDirectory(cartella);
            }
            string path = Path.Combine(cartella, nomeFile);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            
        }
    }
}
