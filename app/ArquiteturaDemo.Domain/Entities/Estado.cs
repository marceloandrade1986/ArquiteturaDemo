using System.Collections.Generic;

namespace ArquiteturaDemo.Domain.Entities
{

    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
        public virtual List<Cidade> Cidades { get; set; }
    }
}
