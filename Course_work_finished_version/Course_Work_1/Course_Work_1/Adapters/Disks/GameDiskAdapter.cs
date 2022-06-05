using Course_Work_1.Adapters.Abstract;
using Course_Work_1.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_1.Adapters.Disks
{
    public class GameDiskAdapter : IAdapter<Disk, GameDiskDTO>
    {
        public GameDiskDTO ConvertToDTO(Disk model)
        {
            IAdapter<GameFile, GameFileDTO> adapter = new GameFileAdapter();

            return new GameDiskDTO(adapter.ConvertToDTO((GameFile)model.File), model.RentalStatus);
        }

        public Disk ConvertToModel(GameDiskDTO dto)
        {
            IAdapter<GameFile, GameFileDTO> adapter = new GameFileAdapter();

            return new Disk(dto.RentalStatus, adapter.ConvertToModel(dto.File));
        }
    }
}
