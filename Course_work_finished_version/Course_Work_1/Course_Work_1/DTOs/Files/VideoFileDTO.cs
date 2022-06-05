using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_1
{
    public class VideoFileDTO : FileDTO
    {
        public VideoFileDTO(Guid id, string name, string description, double price, TypesOfFiles typesOfFiles, TypesOfVideos typeOfVideo) : base(id, name, description, price, typesOfFiles)
        {
            TypeOfVideo = typeOfVideo;
        }

        [JsonProperty("type_of_video")]
        public TypesOfVideos TypeOfVideo { get; set; }
    }
}
