using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcorewebapp.Models
{
    public class HomeModel
    {
        public int id { get; set; }
        public string Nome { get; set; }

        public List<HomeModel> GetAll()
        {
            HomeModel item;
            List<HomeModel> lista = new List<HomeModel>();

            item = new HomeModel();
            item.id = 1;
            item.Nome = "Denis";
            lista.Add(item);

            item = new HomeModel();
            item.id = 2;
            item.Nome = "Aluno";
            lista.Add(item);

            return lista;

        }

    }
}
