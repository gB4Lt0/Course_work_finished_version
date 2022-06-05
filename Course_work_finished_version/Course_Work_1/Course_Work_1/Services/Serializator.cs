using Newtonsoft.Json;
using System;

namespace Course_Work_1
{
    public class Serializator<T>
    {
        private readonly string _path;

        public Serializator(string path)
        {
            _path = path;
        }

        public void Serialize(T model)
        {
            var jsonContent = JsonConvert.SerializeObject(model);

            System.IO.File.WriteAllText(_path, jsonContent);
        }

        public T Deserialize()
        {
            string jsonContent = System.IO.File.ReadAllText(_path);

            if (jsonContent == null)
                throw new NullReferenceException();

            T? data = JsonConvert.DeserializeObject<T>(jsonContent);

            if (data == null)
                throw new NullReferenceException();

            return data;
        }
    }
}
