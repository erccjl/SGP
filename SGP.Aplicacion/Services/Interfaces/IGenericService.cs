﻿using SGP.Aplicacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Aplicacion.Services.Interfaces
{
    public interface IGenericService<TDto>
        where TDto : BaseDto
    {
        Task<TDto> Get(int id);
        Task<bool> Exists(int id);
        Task Activate(int id);
        Task Inactivate(int id);
        Task Save(TDto dto);
        Task<(bool isValid, string message)> Validate(int? id, TDto dto);
    }
}
