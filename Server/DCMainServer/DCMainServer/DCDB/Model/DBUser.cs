using System;
using SQLite;

namespace DC.Model
{
    [ModelCls]
    public class DBUser
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [Indexed]
        public string Token { get; set; }

        public DateTime CreatedTime { get; set; }

    }
}