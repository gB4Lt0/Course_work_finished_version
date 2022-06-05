using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_1
{
    public abstract class File : IEquatable<File>
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public double Price { get; protected set; }
        public TypesOfFiles FileType { get; protected set; }
        protected File(Guid id, string name, string description, double price, TypesOfFiles typesOfFiles)
        {
            Name = name;
            Description = description;
            Price = price;
            FileType = typesOfFiles;
            Id = id;
        }

        public abstract string GetInfo();

        public bool Equals(File? other)
        {
            if (other == null)
                return false;

            return Id.Equals(other.Id);
        }
    }
}
