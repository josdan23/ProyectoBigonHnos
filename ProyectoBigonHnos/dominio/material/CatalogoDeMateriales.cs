﻿using ProyectoBigonHnos.data;
using ProyectoBigonHnos.data.MaterialDao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBigonHnos.dominio
{
    public class CatalogoDeMateriales
    {
        public static CatalogoDeMateriales catalogo;
        private PersistenciaFacade persistencia;

        public CatalogoDeMateriales()
        {
            persistencia = PersistenciaFacade.getInstance();
        }

        public static CatalogoDeMateriales getInstancia()
        {
            if (catalogo is null)
            {
                catalogo = new CatalogoDeMateriales();
            }
            return catalogo;
        }

        public Material obtenerMaterial(int idMaterial)
        {
            return persistencia.obtenerObjeto<Material>(idMaterial);
        }

        public void mostrarCatalogo()
        {
            foreach (Material material in persistencia.obtenerTodos<Material>())
            {
                Console.WriteLine(material);
            }
        }

        public void crearMaterial(string descripcion, double precio, int stockDisponible, int stockMinimo, String unidad)
        {
            persistencia.registrarObjeto(new Material(descripcion, precio, stockDisponible, stockMinimo, unidad));

        }

        public void borrarMaterial(int idMaterial)
        {
            persistencia.eliminarObjeto<Material>(idMaterial);
        }

        public void editarMaterial(int id, string descripcion,  double precio, int stockDisponible, int stockMinimo, string unidad)
        {
            Material materialRecuperado = persistencia.obtenerObjeto<Material>(id);
            materialRecuperado.Descripcion = descripcion;
            materialRecuperado.Precio = precio;
            materialRecuperado.StockDisponible = stockDisponible;
            materialRecuperado.StockMinimo = stockMinimo;
            materialRecuperado.tipoUnidad = unidad;
            //Material material = new Material(descripcion, precio, stockDisponible, stockMinimo, unidad);
            //material.IdMaterial = id;
            persistencia.actualiarObjeto(materialRecuperado);
        }

        public List<Material> obtenerMateriales()
        {
            return persistencia.obtenerTodos<Material>();
        }
    }
}
