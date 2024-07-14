using AutoMapper;
using SGP.Aplicacion.Dtos;
using SGP.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Aplicacion.Mapper
{
    public class TarjetaProfile : Profile
    {
        public TarjetaProfile()
        {
            CreateMap<TarjetaDto, Tarjeta>()
                .ForMember(c => c.CreatedDate, option => option.Ignore())
                .ReverseMap();
        }
    }
}
