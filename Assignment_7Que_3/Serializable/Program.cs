using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Demo
{
    
    [Serializable]
    
    class Check
    {
        public int identity;
        public String nam;
        static void Main(string[] args)
        {
            
            Check ob = new Check();
            ob.identity = 10;
            ob.nam = "Shobha";
            
            IFormatter format = new BinaryFormatter();
            Stream stream1 = new FileStream(@"E:\Example.txt", FileMode.Create, FileAccess.Write);
           
            format.Serialize(stream1, ob);
            stream1.Close();
           
            stream1 = new FileStream(@"E:\Example.txt", FileMode.Open, FileAccess.Read);
           
            Check ob1 = (Check)format.Deserialize(stream1);
            
            Console.WriteLine(ob1.identity);
            Console.WriteLine(ob1.nam);
            Console.ReadKey();
        }
    }
}
