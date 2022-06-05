using Course_Work_1.Adapters;
using Course_Work_1.Adapters.Abstract;
using Course_Work_1.Adapters.Disks;
using Course_Work_1.DTOs;
using Course_Work_1.DTOs.Disks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_1
{
    public class DiskDTO
    {
        public List<GameDiskDTO> GameFiles { get; set; } = new List<GameDiskDTO>();
        public List<VideoDiskDTO> VideoFiles { get; set; } = new List<VideoDiskDTO>();
        public List<ProgramDiskDTO> ProgramFiles { get; set; } = new List<ProgramDiskDTO>();

        public List<Disk> GetModels()
        {
            List<Disk> disks = new List<Disk>();

            IAdapter<Disk, GameDiskDTO> gameAdapter = new GameDiskAdapter();
            IAdapter<Disk, VideoDiskDTO> videoAdapter = new VideoDiskAdapter();
            IAdapter<Disk, ProgramDiskDTO> programAdapter = new ProgramDiskAdapter();

            foreach (var item in GameFiles)
            {
                disks.Add(gameAdapter.ConvertToModel(item));
            }

            foreach (var item in VideoFiles)
            {
                disks.Add(videoAdapter.ConvertToModel(item));
            }

            foreach(var item in ProgramFiles)
            {
                disks.Add(programAdapter.ConvertToModel(item));
            }    

            return disks;
        }

        public void Initialize(List<Disk> files)
        {
            IAdapter<Disk, GameDiskDTO> gameAdapter = new GameDiskAdapter();
            IAdapter<Disk, VideoDiskDTO> videoAdapter = new VideoDiskAdapter();
            IAdapter<Disk, ProgramDiskDTO> programAdapter = new ProgramDiskAdapter();

            foreach (var disk in files)
            {
                if (disk.File is GameFile)
                    GameFiles.Add(gameAdapter.ConvertToDTO(disk));
                if (disk.File is VideoFile)
                    VideoFiles.Add(videoAdapter.ConvertToDTO(disk));
                if (disk.File is ProgramFile)
                    ProgramFiles.Add(programAdapter.ConvertToDTO(disk));
            }
        }


    }
}
