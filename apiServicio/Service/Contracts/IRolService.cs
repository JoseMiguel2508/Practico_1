using ApiServicio.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiServicio.Service.Contracts
{
    public interface IRolService
    {

        Task<List<Rol>> GetList();
        Task<Rol> AgregaActualiza(Rol l, string t);

    }
}
