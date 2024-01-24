using Dapper;
using Domain.Commands;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        string conexao = @"Server=(localdb)\mssqllocaldb;Database=AluguelVeiculos;Trusted_Connection=True;MultipleActiveResultSets=true";

        public async Task<string> PostAsync(ClienteCommand command)
        {
            string queryInsertCliente = @"
            INSERT INTO CLIENTE(NOME, DATANASCIMENTO, Hablitacao, ESTADO)
            VALUES(@NOME, @DATANASCIMENTO, @Hablitacao, @ESTADO)
            ";

            using(SqlConnection  con = new SqlConnection(conexao))
            {
                con.Execute(queryInsertCliente, new
                {
                    NOME = command.Nome,
                    DATANASCIMENTO = command.DataNascimento,
                    Hablitacao = command.Habilitacao,
                    ESTADO = command.Estado
                });

                return "Cadastro realizado com sucesso";
            }
        }
    }
}
