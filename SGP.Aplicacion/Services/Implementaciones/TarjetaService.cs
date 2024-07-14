using AutoMapper;
using SGP.Aplicacion.Dtos;
using SGP.Aplicacion.Helpers;
using SGP.Aplicacion.Services.Interfaces;
using SGP.Aplicacion.Validations;
using SGP.Dominio.Contratos;
using SGP.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Aplicacion.Services.Implementaciones
{
    public class TarjetaService : ITarjetaService
    {
        private readonly IRepository<Tarjeta> _repository;
        private readonly IMapper _mapper;
        private const int _usuarioId = 1; //TODO: Modificar por el codigo del usuario autenticado

        public TarjetaService(IRepository<Tarjeta> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<TarjetaDto> Get(int id)
        {
            var model = await _repository.Get(id);
            return _mapper.Map<TarjetaDto>(model);
        }

        public async Task<bool> Exists(int id)
        {
            return await _repository.Get(id) != null;
        }

        public async Task Activate(int id)
        {
            var tarjeta = await _repository.Get(id);
            BaseEntityHelper.SetActive(tarjeta, _usuarioId);
            await _repository.Update(tarjeta);
        }

        public async Task Inactivate(int id)
        {
            var tarjeta = await _repository.Get(id);
            BaseEntityHelper.SetInactive(tarjeta, _usuarioId);
            await _repository.Update(tarjeta);
        }

        public async Task Save(TarjetaDto dto)
        {
            if (dto.Id.Equals(0))
            {
                var newTarjeta = _mapper.Map<Tarjeta>(dto);
                BaseEntityHelper.SetCreated(newTarjeta, _usuarioId);
                await _repository.Add(newTarjeta);
            }
            else
            {
                var updatedTarjeta = _mapper.Map<Tarjeta>(dto);
                BaseEntityHelper.SetUpdated(updatedTarjeta, _usuarioId);
                await _repository.Update(updatedTarjeta);
            }
        }

        public async Task<(bool isValid, string message)> Validate(int? id, TarjetaDto dto)
        {
            var validations = new List<(bool isValid, string message)>();

            var validator = new TarjetaValidators();
            var result = await validator.ValidateAsync(dto);
            validations.Add((result.IsValid, string.Join(Environment.NewLine, result.Errors.Select(x => $"Campo {x.PropertyName} invalido. Error: {x.ErrorMessage}"))));

            return (isValid: validations.All(x => x.isValid),
                    message: string.Join(Environment.NewLine, validations.Where(x => !x.isValid).Select(x => x.message)));
        }
    }
}
