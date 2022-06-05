using Course_Work_1.Services.Abstract;
using System;
using System.Collections.Generic;

namespace Course_Work_1.Services
{
    public class DataSaver : IDataSaver
    {
        private readonly string _disks_path;

        public DataSaver(string path) 
        {
            _disks_path = path;
        }

        public List<Disk> LoadData()
        {
            try
            {
                Serializator<DiskDTO> serializator = new Serializator<DiskDTO>(_disks_path);

                DiskDTO diskDTO = serializator.Deserialize();

                return diskDTO.GetModels();
            }
            catch (Exception)
            {
                return new List<Disk>();
            }     
        }

        public void SaveData(List<Disk> disks)
        {
            DiskDTO diskDTO = new DiskDTO();

            diskDTO.Initialize(disks);

            Serializator<DiskDTO> serializator = new Serializator<DiskDTO>(_disks_path);
            serializator.Serialize(diskDTO);
        }
    }
}
