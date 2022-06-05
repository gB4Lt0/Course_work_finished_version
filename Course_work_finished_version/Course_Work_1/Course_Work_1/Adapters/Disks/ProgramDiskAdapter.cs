using Course_Work_1.Adapters.Abstract;
using Course_Work_1.DTOs;
using Course_Work_1.DTOs.Disks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_1.Adapters.Disks
{
    public class ProgramDiskAdapter : IAdapter<Disk, ProgramDiskDTO>
    {
        public ProgramDiskDTO ConvertToDTO(Disk model)
        {
            IAdapter<ProgramFile, ProgramFileDTO> adapter = new ProgramFileAdapter();

            return new ProgramDiskDTO(adapter.ConvertToDTO((ProgramFile)model.File), model.RentalStatus);
        }

        public Disk ConvertToModel(ProgramDiskDTO dto)
        {
            IAdapter<ProgramFile, ProgramFileDTO> adapter = new ProgramFileAdapter();

            return new Disk(dto.RentalStatus, adapter.ConvertToModel(dto.File));
        }
    }
}
