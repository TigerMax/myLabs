using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Shenon
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void readLetters(string filename)
        {
            try {
                using (StreamReader stream = new StreamReader(filename))
                {
                    String line = stream.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Файл не удалось прочесть. Ошибка:");
                Console.WriteLine(e.Message);

            }
        }
    }
}
