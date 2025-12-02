using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface IForma
    {
        string Descer();
        ICor ICor { get; set; }
    }
}
