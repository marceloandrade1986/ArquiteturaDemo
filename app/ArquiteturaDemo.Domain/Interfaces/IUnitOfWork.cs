using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquiteturaDemo.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        void BeginTransaction();

        void Commit();
    }
}
