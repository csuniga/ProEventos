using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {
            new Evento() {
                EventoId = 1,
                Tema = "Angular",
                Local = "Colider",
                Lote = "1º Lotes",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "foto.png",
            },
            new Evento() {
                EventoId = 2,
                Tema = "Csharp",
                Local = "sinop",
                Lote = "2º Lotes",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(5).ToString(),
                ImagemURL = "foto.jpeg",
            }
        };

        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "value";
        }

        [HttpPut]
        public string Put()
        {
            return "value";
        }

        [HttpDelete]
        public string Delete()
        {
            return "value";
        }
    }
}
