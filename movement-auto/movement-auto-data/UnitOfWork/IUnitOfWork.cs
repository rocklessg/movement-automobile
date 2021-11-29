using System;
using System.Threading.Tasks;

namespace movement_auto_data
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
