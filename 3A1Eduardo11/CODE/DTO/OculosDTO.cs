using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3A1Eduardo11.CODE.DTO
{
    class OculosDTO
    {
        private int _id;
        private string _nome;
        private string _categoria;
        private string _valor;
        private string _lancamento;

        public int id { get => _id; set => _id = value; }
        public string nome { get => _nome; set => _nome = value; }
        public string categoria { get => _categoria; set => _categoria = value; }
        public string valor { get => _valor; set => _valor = value; }
        public string lancamento { get => _lancamento; set => _lancamento = value; }
    }
}
