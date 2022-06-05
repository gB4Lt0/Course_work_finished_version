using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_1.Adapters.Abstract
{
    public interface IAdapter<TMODEL, TDTO>
    {
        TDTO ConvertToDTO(TMODEL model);
        TMODEL ConvertToModel(TDTO dto);
    }
}
