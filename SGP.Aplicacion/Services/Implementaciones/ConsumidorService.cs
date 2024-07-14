using AutoMapper;
using SGP.Aplicacion.Dtos;
using SGP.Aplicacion.Helpers;
using SGP.Aplicacion.Services.Interfaces;
using SGP.Dominio.Contratos;
using SGP.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Aplicacion.Services.Implementaciones
{
    public class ConsumidorService : IConsumidorService
    {
        private readonly IRepository<Consumidor> _repository;
        private readonly IMapper _mapper;
        private const int _usuarioId = 1; //TODO: Modificar por el codigo del usuario autenticado

        public ConsumidorService(IRepository<Consumidor> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<ConsumidorDto> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(int id)
        {
            throw new NotImplementedException();
        }

        public Task Activate(int id)
        {
            throw new NotImplementedException();
        }

        public Task Inactivate(int id)
        {
            throw new NotImplementedException();
        }

        public Task Save(ConsumidorDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<(bool isValid, string message)> Validate(int? id, ConsumidorDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
