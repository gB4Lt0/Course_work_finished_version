using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_1
{
    public class FileDTO
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("file_type")]
        public TypesOfFiles FileType { get; set; }

        [JsonProperty("disk?")]
        public DiskDTO DiskDTO { get; set; }

        protected FileDTO(Guid id, string name, string description, double price, TypesOfFiles typesOfFiles)
        {
            Name = name;
            Description = description;
            Price = price;
            FileType = typesOfFiles;
            Id = id;
        }
    }
}
