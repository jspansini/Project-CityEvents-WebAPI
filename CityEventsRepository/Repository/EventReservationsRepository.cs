using CityEvents.Service.DTO;
using CityEventsService.Dto;
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
    public class EventReservationRepository : IEventReservationRepository
    {
        private readonly string _stringConnection;
        public EventReservationRepository()
        {
            _stringConnection = Environment.GetEnvironmentVariable("DATABASE_CONFIG");
        }

        public Task<IEnumerable<EventReservationEntitys>> ConsultReservation(string nome, string tituloEvento)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteReservation(int id)
        {
            string query = "DELETE FROM EventReservation where id = @id";
            DynamicParameters parametro = new(id);
            using MySqlConnection conn = new(_stringConnection);
            int linhasAfetadas = await conn.ExecuteAsync(query, parametro);
            return linhasAfetadas > 0;
        }

        public async Task<bool> EditReservation(int id, int quantidade)
        {
            string query = "UPDATE EventReservation SET Quantity = @quantidade where idReservation = @id";
            DynamicParameters parametro = new(id);
            parametro.Add("quantidade", quantidade);
            using MySqlConnection conn = new(_stringConnection);
            int linhasAfetadas = await conn.ExecuteAsync(query, parametro);
            return linhasAfetadas > 0;
        }
        
        public async Task<bool> AddReservation(EventReservDTO reserve)
        {
            string query = "INSERT INTO EventReservation (IdEvent,PersonName,Quantity) VALUES (@IdEvent,@PersonName,@Quantity)";
            DynamicParameters parametro = new(reserve);
            using MySqlConnection conn = new(_stringConnection);
            int linhasAfetadas = await conn.ExecuteAsync(query, parametro);
            return linhasAfetadas > 0;
        }

        public async Task<bool> ValidateStatus(int idEvento)
        {
            string query = "SELECT * FROM CityEvent where idEvent = @idEvento";
            DynamicParameters parametro = new();
            parametro.Add("idEvento", idEvento);
            using MySqlConnection conn = new(_stringConnection);
            var valor = await conn.QueryFirstOrDefaultAsync<CityEventDTO>(query, parametro);
            return valor.Status;
        }

        public Task<bool> ValidaStatusEvento(int idEvent)
        {
            throw new NotImplementedException();
        }
    }
}