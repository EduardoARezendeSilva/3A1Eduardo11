using _3A1Eduardo11.CODE.DAL;
using _3A1Eduardo11.CODE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3A1Eduardo11.CODE.BLL
{
    class OculosBLL
    {
        Conexao conexao = new Conexao();
        public void Inserir(OculosDTO OculosDTO)
        {
            string inserir = $"insert into oculos values (null, '{OculosDTO.nome}', '{OculosDTO.categoria}', {OculosDTO.valor}, {OculosDTO.lancamento})";
            conexao.ExecutarComando(inserir);
        }
        public void Alterar(OculosDTO OculosDTO)
        {
            string update = $"update oculos set nome = '{OculosDTO.nome}', categoria = '{OculosDTO.categoria}', valor = {OculosDTO.valor}, lancamento = {OculosDTO.lancamento} where id = {OculosDTO.id}";
            conexao.ExecutarComando(update);
        }
        public void Deletar(OculosDTO OculosDTO)
        {
            string delete = $"delete from oculos where id = {OculosDTO.id}";
            conexao.ExecutarComando(delete);
        }
        public DataTable Listar()
        {
            string sql = "select * from oculos";
            return conexao.ExecutarConsulta(sql);
        }
    }
}
