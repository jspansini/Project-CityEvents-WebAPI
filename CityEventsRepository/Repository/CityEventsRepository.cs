﻿using CityEventsService.Dto;
using CityEventsService.Entitys;
using CityEventsService.Interfaces;
using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityEventsInfraData.Repository
{
    public class CityEventRepository : ICityEventsRepository
    {
        private readonly string _stringConnection;
        public CityEventRepository()
        {
            _stringConnection = Environment.GetEnvironmentVariable("DATABASE_CONFIG");
        }
        public async Task<bool> AdicionarEvento(CityEventsEntitys evento)
        {
            string query = @"INSERT INTO CityEvent(title,description, dateHourEvent, local, address, price,status) 
             VALUES (@title, @description, @dateHourEvent, @local, @address, @price,true)";
            DynamicParameters parametros = new(evento);

            using MySqlConnection conn = new(_stringConnection);
            int linhasAfetadas = await conn.ExecuteAsync(query, parametros);
            return linhasAfetadas > 0;
        }

        //Task<IEnumerable<CityEventsEntitys>> ICityEventsRepository.ConsultaPorLocalEData(string local, DateTime data)
        //{ 
        //    string query = @"SELECT * FROM CityEvent where local = @local and DATE(dateHourEvent) = @data";
        //    DynamicParameters parametros = new();
        //    parametros.Add("local", local);
        //    parametros.Add("data", data);
        //    using MySqlConnection conn = new(_stringConnection);
        //    return (IEnumerable<CityEventsEntitys>)conn.Query<CityEventsEntitys>(query, parametros).ToList();
        //}

        public async Task<List<CityEventsEntitys>> ConsultaPorPrecoEData(decimal precoMin, decimal precoMax, DateTime data)
        {
            string query = "SELECT * FROM CityEvent where DATE(dateHourEvent) = @data and price between @precoMin and @precoMax";
            DynamicParameters parametros = new();
            parametros.Add("data", data);
            parametros.Add("precoMin", precoMin);
            parametros.Add("precoMax", precoMax);
            using MySqlConnection conn = new(_stringConnection);
            return (conn.Query<CityEventsEntitys>(query, parametros)).ToList();
        }

        public async Task<List<CityEventsEntitys>> ConsultaPorTitulo(string titulo)
        {
            string query = "SELECT * FROM CityEvent where title like @titulo";
            titulo = $"%{titulo}%";
            DynamicParameters parametros = new();
            parametros.Add("titulo", titulo);
            using MySqlConnection conn = new(_stringConnection);
            return (conn.Query<CityEventsEntitys>(query, parametros)).ToList();
        }

        public async Task<bool> EditarEvento(CityEventsEntitys evento, int id)
        {
            string query = "UPDATE CityEvent set title=@title,description=@description, dateHourEvent=@dateHourEvent, local=@local, address=@address, price=@price where idEvent=@id";
            DynamicParameters parametros = new(evento);
            parametros.Add("id", id);
            using MySqlConnection conn = new(_stringConnection);
            int linhasAfetadas = await conn.ExecuteAsync(query, parametros);
            return linhasAfetadas > 0;
        }

        public async Task<bool> ExcluirEvento(int id)
        {
            string query = "DELETE FROM CityEvent WHERE idEvent = @id";
            DynamicParameters parametros = new();
            parametros.Add("id", id);
            using MySqlConnection conn = new(_stringConnection);
            int linhasAfetadas = await conn.ExecuteAsync(query, parametros);
            return linhasAfetadas > 0;
        }
        public async Task<bool> InativarEvento(int id)
        {
            string query = "UPDATE CityEvent set status = false WHERE IdEvent = @id";
            DynamicParameters parametros = new();
            parametros.Add("id", id);
            using MySqlConnection conn = new(_stringConnection);
            int linhasAfetadas = await conn.ExecuteAsync(query, parametros);
            return linhasAfetadas > 0;
        }
        public async Task<bool> ConsultaReservasNoEvento(int idEvento)
        {
            string query = "SELECT * FROM EventReservation  WHERE idEvent = @idEvento";
            DynamicParameters parametros = new();
            parametros.Add("idEvento", idEvento);
            using MySqlConnection conn = new(_stringConnection);
            return conn.QueryFirstOrDefault(query, parametros) == null;
        }


        //falta implementar
        Task<IEnumerable<CityEventsEntitys>> ICityEventsRepository.ConsultaPorLocalEData(string local, DateTime data)
        {
            throw new NotImplementedException();
        }

        Task<List<CityEventsEntitys>> ICityEventsRepository.ConsultaPorPrecoEData(decimal precoMin, decimal precoMax, DateTime data)
        {
            throw new NotImplementedException();
        }
    }
}

