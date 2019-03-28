using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Messages.Comum
{
    public abstract class BaseResponse
    {
        public bool Error { get; set; }
        public List<string> ErrorMessages { get; set; }
    }
}
