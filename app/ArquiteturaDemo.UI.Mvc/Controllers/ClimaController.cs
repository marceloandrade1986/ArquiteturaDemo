using ArquiteturaDemo.Domain.Interfaces;
using ArquiteturaDemo.UI.Mvc.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace ArquiteturaDemo.UI.Mvc.Controllers
{
    public class ClimaController : Controller
    {
        public IPrevisaoClimaRepository _previsaoClimaRepository { get; set; }

        private ICidadeRepository _cidadeRepository;

        public ClimaController(IPrevisaoClimaRepository previsaoRepository, ICidadeRepository  cidadeRepository)
        {
            _previsaoClimaRepository = previsaoRepository;
            _cidadeRepository = cidadeRepository;
        }

        
        // GET: Clima
        [HttpGet]
        public ActionResult Index()
        {
            int cidadeId = 1; //SÃO PAULO

            Clima clima = new Clima();
            clima.CidadesMaisFrias = _previsaoClimaRepository.CidadesMaisFrias();
            clima.CidadesMaisQuentes = _previsaoClimaRepository.CidadesMaisQuentes();
            clima.UltimasSetePrevisoes = _previsaoClimaRepository.Previsao7dias(cidadeId);
            clima.Cidades = new SelectList(_cidadeRepository.Get().ToList(), "Id", "Nome") ;

            return View(clima);
        }

        [HttpPost]
        public ActionResult Index(FormCollection formCollection)
        {
            int cidadeInt =  Convert.ToInt32(formCollection["cidadeId"]);

            Clima clima = new Clima();

            clima.CidadesMaisFrias = _previsaoClimaRepository.CidadesMaisFrias();
            clima.CidadesMaisQuentes = _previsaoClimaRepository.CidadesMaisQuentes();
            clima.UltimasSetePrevisoes = _previsaoClimaRepository.Previsao7dias(cidadeInt);
            clima.Cidades = new SelectList(_cidadeRepository.Get().ToList(), "Id", "Nome");


            return View(clima);
        }


    }
}