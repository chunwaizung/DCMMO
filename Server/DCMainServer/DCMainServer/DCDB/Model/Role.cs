using SQLite;

namespace DC.Model
{
    [ModelCls]
    public class Role
    {
        [PrimaryKey,AutoIncrement]
        public int id { get; set; }

        [Indexed]
        public long user_id { get; set; }

        public int job_type { get; set; }

        public int level { get; set; }

        public string name { get; set; }

    }
}