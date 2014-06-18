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
        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "INT NOT NULL Identity")]
        public int IdUser { set; get; }

        [Column(CanBeNull = false)]
        public string Name { set; get; }

        [Column]
        public int LastLevel { set; get; }

        [Column]
        public int Score { set; get; }

        [Column]
        public int Hint { set; get; }

        [Column]
        public bool RegionAceh { set; get; }

        [Column]
        public bool RegionSumut { set; get; }

        [Column]
        public bool RegionRiau { set; get; }

        [Column]
        public bool RegionSumsel { set; get; }

        [Column]
        public bool RegionJakarta { set; get; }

        [Column]
        public bool RegionJateng { set; get; }

        [Column]
        public bool RegionJatim { set; get; }

        [Column]
        public bool RegionSulut { set; get; }

        [Column]
        public bool RegionSulteng { set; get; }

        [Column]
        public bool RegionSultenggara { set; get; }

        [Column]
        public bool RegionSulsel { set; get; }
    }

    public class UsersContext : DataContext
    {
        public Table<Users> user;
        public UsersContext(string connectionstring) : base(connectionstring) { }
    }
}
