using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_1.DTOs
{
    public class GameFileDTO : FileDTO
    {
        public GameFileDTO(Guid id, string name, string description, double price, TypesOfFiles typesOfFiles, GameCategories gameCategory) : base(id, name, description, price, typesOfFiles)
        {
            GameCategory = gameCategory;
        }

        [JsonProperty("game_category")]
        public GameCategories GameCategory { get; set; }
    }
}
