using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_1.DTOs
{
    public class ProgramFileDTO : FileDTO
    {
        public ProgramFileDTO(Guid id, string name, string description, double price, TypesOfFiles typesOfFiles, TypesOfPrograms typeOfProgram) : base(id, name, description, price, typesOfFiles)
        {
            TypeOfProgram = typeOfProgram;
        }

        [JsonProperty("type_of_program")]
        public TypesOfPrograms TypeOfProgram { get; set; }
    }
}
