using ApiServicio.Business.Contracts;
using ApiServicio.Models;
using ApiServicio.Service.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiServicio.Service.Clases
{
    public class RolService : IRolService
    {
        private readonly IRolRepository _IRolRepository;
        public RolService(IRolRepository tempI) 
        { 
            _IRolRepository = tempI;
        }
        public Task<List<Rol>> GetList() 
        {
            return _IRolRepository.GetList();
        }
        public Task<Rol> AgregaActualiza(Rol l, string t) 
        {
            return _IRolRepository.AgregaActualiza(l,t);
        }




    }
}
