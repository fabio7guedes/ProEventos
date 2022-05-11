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
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento() {
                    EventoId = 1,
                    Tema = "Angular 11 e .Net 5",
                    local = "Belo Horizonte",
                    Lote = "1º Lote",
                    QtdePessoas = 250,
                    DataEvento = DateTime.Now.Date.ToString("dd/MM/yyyy")
            },
                new Evento() {
                    EventoId = 2,
                    Tema = "Angular 11 e suas novidades",
                    local = "São Paulo",
                    Lote = "2º Lote",
                    QtdePessoas = 250,
                    DataEvento = DateTime.Now.Date.AddDays(3).ToString("dd/MM/yyyy")
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
            return _evento.Where(w => w.EventoId.Equals(id));
        }
    }
}
