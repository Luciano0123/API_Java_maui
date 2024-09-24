using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study.Models
{
    public class Conexao
    {
        public long id { get; set; }
        public DateTime DataCriacao { get; set; }
        public Monitor idMonitor { get; set; }

    }
}
