using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    using DAL.Entities;
    using DAL.Contracts;
    public class ImageRepository: GenericRepository<Image>, IImageRepository
    {

    }
}
