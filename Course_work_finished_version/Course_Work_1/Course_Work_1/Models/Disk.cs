using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_1
{
    public class Disk : IEquatable<Disk>
    {
        public File File { get; private set;}    
        public RentalStatus RentalStatus { get; protected set; }
        public TypesOfFiles DiskType => File.FileType;

        public Disk(RentalStatus rentalStatus, File file)
        {
            RentalStatus = rentalStatus;
            File = file;
        }
        public void ChangeRentalStatus(RentalStatus rentalStatus)
        {
            RentalStatus = rentalStatus;
        }

        public bool Equals(Disk? other)
        {
            if (other == null)
                return false;

            return File.Id.Equals(other.File.Id);
        }
    }
}