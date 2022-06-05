using Course_Work_1.Adapters.Abstract;
using Course_Work_1.DTOs.Disks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_1.Adapters.Disks
{
    public class VideoDiskAdapter : IAdapter<Disk, VideoDiskDTO>
    {
        public VideoDiskDTO ConvertToDTO(Disk model)
        {
            IAdapter<VideoFile, VideoFileDTO> adapter = new VideoFileAdapter();

            return new VideoDiskDTO(adapter.ConvertToDTO((VideoFile)model.File), model.RentalStatus);
        }

        public Disk ConvertToModel(VideoDiskDTO dto)
        {
            IAdapter<VideoFile, VideoFileDTO> adapter = new VideoFileAdapter();

            return new Disk(dto.RentalStatus, adapter.ConvertToModel(dto.File));
        }

    }
}
