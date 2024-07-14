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
    public class MovimientoProfile : Profile
    {
        public MovimientoProfile()
        {
            CreateMap<MovimientoDto, Movimiento>()
                .ForMember(c => c.CreatedDate, option => option.Ignore())
                .ReverseMap();


            CreateMap<CuotaDto, Cuota>()
                .ForMember(c => c.CreatedDate, option => option.Ignore())
                .ReverseMap();

            CreateMap<CuentaDto, Cuenta>()
                .ForMember(c => c.CreatedDate, option => option.Ignore())
                .ReverseMap();

            CreateMap<CategoriaDto, Categoria>()
                .ForMember(c => c.CreatedDate, option => option.Ignore())
                .ReverseMap();
        }
    }
}
