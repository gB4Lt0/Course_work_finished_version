using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_1.Services.Abstract
{
    public interface IDataSaver
    {
        void SaveData(List<Disk> disks);

        List<Disk> LoadData();
    }
}
