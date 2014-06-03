using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace FPMobile.Class
{
    [Table]
    public class Users
    {
        [Column(IsPrimaryKey=true, IsDbGenerated=true,DbType= "INT NOT NULL Identity")]
        public int IdUser { set; get; }

        [Column]
        public string Name { set; get; }

        [Column]
        public int Score { set; get; }
    }

    public class UsersContext : DataContext
    {
        public Table<Users> user;
        public UsersContext(string connectionstring) : base(connectionstring) { }
    }
}
