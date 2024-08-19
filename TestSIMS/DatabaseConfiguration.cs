using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_SIMS2
{
    public static class DatabaseConfiguration
    {
        public static string ConnectionString => "Data Source=MSI\\TAYSQL;Initial Catalog=Student;Integrated Security=True;Trust Server Certificate=True";
    }

}
