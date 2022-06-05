using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_1.DTOs.Disks
{
    public class VideoDiskDTO
    {
        public VideoDiskDTO(VideoFileDTO file, RentalStatus rentalStatus)
        {
            File = file;
            RentalStatus = rentalStatus;
        }

        public VideoFileDTO File { get; set; }
        public RentalStatus RentalStatus { get; set; }
    }
}
