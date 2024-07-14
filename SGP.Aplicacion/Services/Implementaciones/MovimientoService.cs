using AutoMapper;
using FluentValidation;
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
    public class MovimientoService : IMovimientoService
    {
        private readonly IRepository<Movimiento> _repository;
        private readonly IMapper _mapper;
        private const int _usuarioId = 1; //TODO: Modificar por el codigo del usuario autenticado

        public MovimientoService(IRepository<Movimiento> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<MovimientoDto> Get(int id)
        {
            var model = await _repository.Get(id);
            return _mapper.Map<MovimientoDto>(model);
        }

        public async Task<bool> Exists(int id)
        {
            return await _repository.Get(id) != null;
        }

        public async Task Activate(int id)
        {
            var movimiento = await _repository.Get(id);
            BaseEntityHelper.SetActive(movimiento, _usuarioId);
            await _repository.Update(movimiento);
        }

        public async Task Inactivate(int id)
        {
            var movimiento = await _repository.Get(id);
            BaseEntityHelper.SetInactive(movimiento, _usuarioId);
            await _repository.Update(movimiento);
        }

        public async Task Save(MovimientoDto dto)
        {
            if (dto.Id.Equals(0))
            {
                var newMovimiento = _mapper.Map<Movimiento>(dto);
                BaseEntityHelper.SetCreated(newMovimiento, _usuarioId);
                await _repository.Add(newMovimiento);
            }
            else
            {
                var updatedMovimiento = _mapper.Map<Movimiento>(dto);
                BaseEntityHelper.SetUpdated(updatedMovimiento, _usuarioId);
                await _repository.Update(updatedMovimiento);
            }
        }

        public async Task<(bool isValid, string message)> Validate(int? id, MovimientoDto dto)
        {
            var validations = new List<(bool isValid, string message)>();

            var validator = new MovimientoValidators();
            var result = await validator.ValidateAsync(dto);
            validations.Add((result.IsValid, string.Join(Environment.NewLine, result.Errors.Select(x => $"Campo {x.PropertyName} invalido. Error: {x.ErrorMessage}"))));

            return (isValid: validations.All(x => x.isValid),
                    message: string.Join(Environment.NewLine, validations.Where(x => !x.isValid).Select(x => x.message)));
        }

    }
}
