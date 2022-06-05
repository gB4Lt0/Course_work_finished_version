using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_1
{
    public class ProgramFile : File
    {
        public ProgramFile(Guid id, string name, string description, double price, TypesOfFiles typesOfFiles, TypesOfPrograms typeOfProgram) : base(id, name, description, price, typesOfFiles)
        {
            TypeOfProgram = typeOfProgram;
        }
        public TypesOfPrograms TypeOfProgram  { get; private set; }
        public override string GetInfo()
        {
            return $"Program price: {Price}\nProgram type: {TypeOfProgram}";
        }
    }
}
