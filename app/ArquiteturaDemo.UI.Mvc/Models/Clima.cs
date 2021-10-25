using ArquiteturaDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArquiteturaDemo.UI.Mvc.Models
{
    public class Clima
    {
        public List<PrevisaoClima> CidadesMaisQuentes = new List<PrevisaoClima>();
        public List<PrevisaoClima> CidadesMaisFrias = new List<PrevisaoClima>();
        public List<PrevisaoClima> UltimasSetePrevisoes = new List<PrevisaoClima>();
    }
}