using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_1
{
    public class GameFile : File
    {
        public GameFile(Guid id, string name, string description, double price, TypesOfFiles typesOfFiles, GameCategories gameCategory) : base(id, name, description, price, typesOfFiles)
        {
            GameCategory = gameCategory;
        }
        public GameCategories GameCategory { get; private set; }
        public override string GetInfo()
        {
            return $"Game price: {Price}\nGame category: {GameCategory}" ;
            
        }
    }
}
