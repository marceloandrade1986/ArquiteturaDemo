using ArquiteturaDemo.Domain.Interfaces;
using ArquiteturaDemo.UI.Mvc.Models;
using System;
using System.Web.Mvc;

namespace ArquiteturaDemo.UI.Mvc.Controllers
{
    public class ClimaController : Controller
    {
        public IPrevisaoClimaRepository PrevisaoClimaRepository { get; set; }
        public ClimaController(IPrevisaoClimaRepository previsaoRepository)
        {
            PrevisaoClimaRepository = previsaoRepository;
        }

        
        // GET: Clima
        public ActionResult Index()
        {
            int cidadeId = 1; //SÃO PAULO

            Clima clima = new Clima();
            clima.CidadesMaisFrias = PrevisaoClimaRepository.CidadesMaisFrias();
            clima.CidadesMaisQuentes = PrevisaoClimaRepository.CidadesMaisQuentes();
            clima.UltimasSetePrevisoes = PrevisaoClimaRepository.Previsao7dias(cidadeId);

            return View(clima);
        }

        public ActionResult Index(FormCollection formCollection)
        {
            string cidadeString = formCollection["cidadeId"];

            int cidadeInt =  Convert.ToInt32(cidadeString);

            Clima clima = new Clima();

            clima.CidadesMaisFrias = PrevisaoClimaRepository.CidadesMaisFrias();
            clima.CidadesMaisQuentes = PrevisaoClimaRepository.CidadesMaisQuentes();
            clima.UltimasSetePrevisoes = PrevisaoClimaRepository.Previsao7dias(cidadeInt);

            return View(clima);
        }


    }
}