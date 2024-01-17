using ApiServicio.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiServicio.Business.Contracts
{
    public interface IRolRepository
    {
        Task<List<Rol>> GetList();
        Task<Rol> AgregaActualiza(Rol l, string t);

    }
}
