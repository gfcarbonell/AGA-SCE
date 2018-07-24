using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sce_aga_server.Services
{
    interface IEntidad<T>
    {
        T Save(T entidad);
        T Update(T entidad);
        void Delete(int Id);
        ICollection<T> Get();
        bool Exist(int Id);
    }
}
