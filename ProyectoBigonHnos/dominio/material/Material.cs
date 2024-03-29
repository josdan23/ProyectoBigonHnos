﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    public class Material
    {
        public int IdMaterial { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int StockDisponible { get; set; }
        public int StockMinimo { get; set; }
        public int Cantidad;
        public string tipoUnidad{get;set;}

        public Material(string descripcion, double precio, int stockDisponible, int stockMinimo, string unidad)
        {
            Descripcion = descripcion;
            Precio = precio;
            StockDisponible = stockDisponible;
            StockMinimo = stockMinimo;
            Cantidad = stockDisponible;
            this.tipoUnidad = unidad;
        }

        public Material(string descripcion, int cantidad, double precio, int stockDisponible, int stockMinimo, string unidad)
        {
            Descripcion = descripcion;
            Precio = precio;
            StockDisponible = stockDisponible;
            StockMinimo = stockMinimo;
            Cantidad = cantidad;
            this.tipoUnidad = unidad;
        }

        public override string ToString()
        {
            String mensaje = string.Format(
                "\nDESCRIPCIÓN DEL MATERIAL\n" +
                "Id Material: {0}\n" +
                "Descripción: {1}\n" +
                "Cantidad: {2}\n" +
                "Precio: {3}" +
                "Stock Disponible: {4}" +
                "Stock Minimo: {5}\n",
                IdMaterial,
                Descripcion,
                Cantidad,
                Precio,
                StockDisponible,
                StockMinimo);

            return mensaje;
        }


        public enum TipoUnidad
        {
            CM2,
            UNIDAD,
            PROBANDNO
        };

    }
}
