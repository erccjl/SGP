﻿namespace SGP.Dominio.Entidades
{
    public class Categoria : BaseEntity
    {
        public string Descripcion {  get; set; }

        public virtual List<Movimiento>? Movimientos { get; set;}
    }
}
