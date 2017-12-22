using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.ComponentModel;

namespace MilkTeaOrderDemo
{
    class IOMethods
    {
        private static IOMethods instance;

        private IOMethods()
        {

        }

        public static IOMethods Instance
        {
            get
            {
                if (instance == null)
                    instance = new IOMethods();
                return instance;
            }
            private set { }
        }

        public void WriteNewData<T>(string path, T obj)
        {
            using (StreamWriter writer = new StreamWriter(path, true, Encoding.UTF8))
            {
                writer.WriteLine(JsonConvert.SerializeObject(obj));
            }
        }

        public void ReadData<T>(string path, ref BindingList<T> list)
        {
            if (File.Exists(path))
            {
                using (StreamReader reader = File.OpenText(path))
                {
                    string input;
                    while ((input = reader.ReadLine()) != null)
                    {
                        list.Add(JsonConvert.DeserializeObject<T>(input));
                    }
                }
            }
        }

        public void EditData<T>(string path, BindingList<T> list)
        {
            string tempfile = Path.GetTempFileName();
            using (var sw = new StreamWriter(tempfile))
            {
                foreach (T a in list)
                {
                    sw.WriteLine(JsonConvert.SerializeObject(a));
                }
            }
            File.Delete(path);
            File.Move(tempfile, path);
        }
    }
}
