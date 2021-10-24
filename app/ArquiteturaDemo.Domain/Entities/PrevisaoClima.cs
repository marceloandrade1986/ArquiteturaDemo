using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquiteturaDemo.Domain.Entities
{
    public class PrevisaoClima
    {
        public int ID { get; set; }
        public EnumClima Clima { get; set; }
        public decimal TemperaturaMinima { get; set; }
        public decimal TemperaturaMaxima { get; set; }
        public DateTime DataPrevisao { get; set; }
        public virtual Cidade Cidade { get; set; }
        public int CidadeId { get; set; }
    }
}
