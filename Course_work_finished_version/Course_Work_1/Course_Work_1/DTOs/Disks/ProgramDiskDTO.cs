using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_1.DTOs.Disks
{
    public class ProgramDiskDTO
    {
        public ProgramDiskDTO(ProgramFileDTO file, RentalStatus rentalStatus)
        {
            File = file;
            RentalStatus = rentalStatus;
        }

        public ProgramFileDTO File { get; set; }
        public RentalStatus RentalStatus { get; set; }
    }
}
