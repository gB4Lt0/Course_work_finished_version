using Course_Work_1.Adapters.Abstract;
using Course_Work_1.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_1.Adapters
{
    public class ProgramFileAdapter : IAdapter<ProgramFile, ProgramFileDTO>
    {
        public ProgramFileDTO ConvertToDTO(ProgramFile model)
        {
            return new ProgramFileDTO(model.Id, model.Name, model.Description, model.Price, model.FileType, model.TypeOfProgram);
        }

        public ProgramFile ConvertToModel(ProgramFileDTO dto)
        {
            return new ProgramFile(dto.Id, dto.Name, dto.Description, dto.Price, dto.FileType, dto.TypeOfProgram);
        }
    }
}
