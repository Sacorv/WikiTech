﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WikiTech.Entidades;

namespace WikiTech.Logica
{
    public interface IArticuloServicio
    {
        Task<List<Articulo>> ObtenerArticulos();

        Task<Articulo> BuscarArticulo(int id);

    }

    public class ArticuloServicio : IArticuloServicio
    {
        public async Task<List<Articulo>> ObtenerArticulos()
        {
            List<Articulo> listaArticulos = new List<Articulo>();

            var endpoint = "https://localhost:7164/api/articulo";
            JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true};

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(endpoint);

                if (response.IsSuccessStatusCode)
                {
                    var json_res = await response.Content.ReadAsStringAsync();
                    var res = JsonSerializer.Deserialize<List<Articulo>>(json_res, options);
                    listaArticulos = res; 
                }
            }
            return listaArticulos;
        }


        public async Task<Articulo> BuscarArticulo(int id)
        {
            string endpoint = $"https://localhost:7164/api/articulo/{id}";
            Articulo buscado = null;

            JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(endpoint);

                if (response.IsSuccessStatusCode)
                {
                    var json_res = await response.Content.ReadAsStringAsync();
                    var res = JsonSerializer.Deserialize<Articulo>(json_res, options);
                    buscado = res;
                }
            }

            return buscado;

        }
    }
}