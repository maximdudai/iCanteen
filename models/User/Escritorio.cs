using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace PSI_DA_PL_B.models.User
{
    public class Escritorio
    {
        [Key]
        public int Id { get; set; }
        public string Localizacao { get; set; }

        public string Cacifo { get; set; }

        public int total_users { get; set; } = 0;

        public bool showData { get; set; }

        public Escritorio()
        {

        }

        public Escritorio(string localizacao, string cacifo, bool showData = false)
        {
            Localizacao = localizacao;
            Cacifo = cacifo;
            this.showData = showData;
        }

        public override string ToString()
        {
            if(showData)
            return $"{this.Localizacao} #{this.Cacifo} -> {this.total_users}";
            else
                return $"{this.Localizacao} #{this.Cacifo}";
        }
    }
}
