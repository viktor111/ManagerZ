using ManagerZ.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerZ.Services
{
    interface ISqlProduct
    {
        List<Product> GetAll();

        Product GetOneByName(string name);

        string UpdateById(int id, string propertyToUpdate, string data);

        DataTable GetAllDataAdapter();
    }
}
