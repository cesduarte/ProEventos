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
        
        public IEnumerable<Evento> evento = new Evento[]
        {
            new Evento()
            {
                EventoID = 1,
                Local = "Jacareí",
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                Tema = "Angular 11 e .NET",
                QtdPessoas = 250,
                Lote = "1º Lote",
                ImagemURL = "Foto.png",
            },
            new Evento()
            {
                EventoID = 2,
                Local = "SJC",
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                Tema = "Angular 11",
                QtdPessoas = 250,
                Lote = "2º Lote",
                ImagemURL = "Foto2.png",
            }
        };

        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return evento;
        }
         [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return evento.Where(s=>s.EventoID == id);
        }
        [HttpPost]
        public string Post()
        {
             return "Value";
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
             return "Value";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
             return "Value";
        }
    }
}
