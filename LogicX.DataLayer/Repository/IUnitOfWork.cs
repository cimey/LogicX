using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicX.DataLayer.Repository
{
    public interface IUnitOfWork : IDisposable
    {

        void Begin();
        void Save();
        void End();
        void Cancel();
    }
}
