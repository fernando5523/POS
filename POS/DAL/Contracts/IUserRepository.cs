using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    using DAL.Entities;
    public interface IUserRepository: IRepositoryGeneric<User>
    {
    }
}
