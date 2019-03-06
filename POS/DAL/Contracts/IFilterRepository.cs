﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.Entities;

namespace DAL.Contracts
{
    public interface IFilterRepository:IGenericRepository<Filter>
    {
        Filter GetUser(int iduser, int idconsult);
        DataTable Execute(string transactSql);
    }
}
