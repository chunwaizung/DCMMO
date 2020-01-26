using System;
using SQLite;

namespace DC.Model
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public long ID { get; set; }

        [Indexed]
        public string Token { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public DateTime CreatedTime { get; set; }

    }
}