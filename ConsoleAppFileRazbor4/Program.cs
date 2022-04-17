using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleAppFileRazbor4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrasesOut = { "Говно", "залупа", "пенис", "хер", "давалка", "хуй", "блядина" };

            BinaryFormatter binaryFormatter = new BinaryFormatter();

            FileStream fileStreamOut = new FileStream("file.bin", FileMode.OpenOrCreate, FileAccess.Write);

            binaryFormatter.Serialize(fileStreamOut, phrasesOut);

            fileStreamOut.Close();

            FileStream fileStreamIn = new FileStream("file.bin", FileMode.Open, FileAccess.Read);

            string[] phrasesIn = (string[])binaryFormatter.Deserialize(fileStreamIn);

            fileStreamIn.Close();

            for (int i = 0; i < phrasesIn.Length; i++)
            {
                Console.WriteLine(phrasesIn[i]);
            }
            Console.ReadKey();
        }
    }
}
