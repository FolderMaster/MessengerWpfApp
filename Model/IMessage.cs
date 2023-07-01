using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IMessage
    {
        public object Content { get; set; }

        public Contact Contact { get; set; }
    }
}