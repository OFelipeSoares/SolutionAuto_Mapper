using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IGeneric<T> where T : class
    {
        Task Adicionar (T Objeto);
        Task Atualizar (T Objeto);
        Task Excluir   (T Objeto);
        Task<T> BuscarPorCodigo(int Id);
        Task<List<T>> ListarTudo();
    }
}
