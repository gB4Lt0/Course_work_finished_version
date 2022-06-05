using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_1.DTOs
{
    public class GameDiskDTO
    {
        public GameDiskDTO(GameFileDTO file, RentalStatus rentalStatus)
        {
            File = file;
            RentalStatus = rentalStatus;
        }

        public GameFileDTO File { get; set; }
        public RentalStatus RentalStatus { get; set; }

        
    }
}
