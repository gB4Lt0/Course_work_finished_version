using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_1
{
    public class VideoFile : File
    {
        public VideoFile(Guid id,string name, string description, double price, TypesOfFiles typesOfFiles, TypesOfVideos typeOfVideo) : base(id, name, description, price, typesOfFiles)
        {
            TypeOfVideo = typeOfVideo;
        }
        public TypesOfVideos TypeOfVideo { get; private set; }
        public override string GetInfo()
        {
            return $"Video price: {Price}\nVideo genre: {TypeOfVideo}";
        }
    }
}
