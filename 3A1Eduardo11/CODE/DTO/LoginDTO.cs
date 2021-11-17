using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3A1Eduardo11.CODE.DTO
{
    class LoginDTO
    {
        private int _id;
        private string _usuario;
        private string _email;
        private string _senha;

        public int id { get => _id; set => _id = value; }
        public string usuario { get => _usuario; set => _usuario = value; }
        public string email { get => _email; set => _email = value; }
        public string senha { get => _senha; set => _senha = value; }
    }
}
