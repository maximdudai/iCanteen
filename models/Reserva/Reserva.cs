using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PSI_DA_PL_B.models.Menu;

namespace PSI_DA_PL_B.models.Reserva
{
    internal class Reserva
    {
        [Key]
        public int Id { get; set; }

        // 0 = nao tem multa
        // > 0 = tem multa
        [Range(0, 2)]
        public int Multa {  get; set; }

        public List<MenuCantina.MenuCantina> menu { get; set; }

        public List<Prato> pratos { get; set; }

        public List<Extra> extras { get; set; }


        //Reserva res = new Reserva(lista_datas, utilizador_id, tipo_ )

        // assim que e feita a reserva, faz-se uma prereserva e assim que e feita reserva, o stock atualiza-se
        // o cliente entra e e possivel adicionar mais items a reserva
        // a reserva e confirmada
        // vai para fatura com os items reservados sem alterar base de dados
        // tem que aparecer o total (soma items fatura) + items fatura (descricao de cada item)
        // informacao sobre o tipo da reserva (almoco / jantar)
        // botoes para 
    }
}
