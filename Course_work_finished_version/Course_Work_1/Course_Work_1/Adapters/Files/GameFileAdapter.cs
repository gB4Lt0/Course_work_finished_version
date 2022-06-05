using Course_Work_1.Adapters.Abstract;
using Course_Work_1.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_1.Adapters
{
    public class GameFileAdapter : IAdapter<GameFile, GameFileDTO>
    {
        public GameFileDTO ConvertToDTO(GameFile model)
        {
            return new GameFileDTO(model.Id, model.Name, model.Description, model.Price, model.FileType, model.GameCategory);
        }

        public GameFile ConvertToModel(GameFileDTO dto)
        {
            return new GameFile(dto.Id, dto.Name, dto.Description, dto.Price, dto.FileType, dto.GameCategory);
        }
    }
}
