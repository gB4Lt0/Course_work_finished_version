using Course_Work_1.Adapters.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_1.Adapters
{
    public class VideoFileAdapter : IAdapter<VideoFile, VideoFileDTO>
    {
        public VideoFileDTO ConvertToDTO(VideoFile model)
        {
            return new VideoFileDTO(model.Id, model.Name, model.Description, model.Price, model.FileType, model.TypeOfVideo);
        }

        public VideoFile ConvertToModel(VideoFileDTO dto)
        {
            return new VideoFile(dto.Id, dto.Name, dto.Description, dto.Price, dto.FileType, dto.TypeOfVideo);
        }
    }
}
