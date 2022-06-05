using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_1
{
    public class DiskShop
    {
        public List<Disk> DiskList { get; private set; }

        public DiskShop(List<Disk> disks)
        {
            DiskList = disks;
        }

        public void AddDisk(Disk disk)
        {
            DiskList.Add(disk);
        }

        public void RemoveDisk(Disk disk)
        {
            DiskList.Remove(disk);
        }

        public void RentDisk(Disk disk)
        {
            if (disk.RentalStatus == RentalStatus.OnSale)
            {
                disk.ChangeRentalStatus(RentalStatus.Rented);
            }
        }

        public void RentRefund(Disk disk)
        {
            if (disk.RentalStatus == RentalStatus.Rented)
            {
                disk.ChangeRentalStatus(RentalStatus.OnSale);
            }
        }

        public List<File> GetSoldFiles()
        {
            List<File> files = new List<File>();

            foreach (var disk in DiskList)
            {
                if (disk.RentalStatus == RentalStatus.Sold) files.Add(disk.File);
            }

            return files;
        }

        public List<File> GetOnSaleFiles()
        {
            List<File> files = new List<File>();

            foreach (var disk in DiskList)
            {
                if (disk.RentalStatus == RentalStatus.OnSale) files.Add(disk.File);
            }

            return files;
        }

        public List<File> GetRentedFiles()
        {
            List<File> files = new List<File>();

            foreach (var disk in DiskList)
            {
                if (disk.RentalStatus == RentalStatus.Rented) files.Add(disk.File);
            }

            return files;
        }

        public void SellDisk(Disk disk)
        {
            if (disk.RentalStatus == RentalStatus.OnSale || disk.RentalStatus == RentalStatus.Rented)
            {
                disk.ChangeRentalStatus(RentalStatus.Sold);
            }
        }

        public void SellDiskByFile(File file)
        {
            foreach (var item in DiskList)
            {
                if (item.File.Equals(file))
                {
                   SellDisk(item);
                    return;
                }
            }
        }

        internal void UnRentDiskByFile(File file)
        {
            foreach (var item in DiskList)
            {
                if (item.File.Equals(file))
                { 
                    RentRefund(item);
                    return;
                }

            }
        }

        public void RemoveDiskByFile(File selectedItem)
        {
            foreach (var item in DiskList)
            {
                if (item.File.Equals(selectedItem))
                {
                    RemoveDisk(item);
                    return;
                }
            }
        }

        public void RentDiskByFile(File file)
        {
            foreach (var item in DiskList)
            {
                if (item.File.Equals(file))
                {
                    RentDisk(item);
                    return;
                }
            }
        }

        public List<File> GetFiles()
        {
            List<File> files = new List<File>();

            foreach (var disk in DiskList)
            {
                files.Add(disk.File);
            }
            return files;
        }

    }
}
