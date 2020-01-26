using SQLite;

namespace DC.Model
{
    public class Role
    {
        [PrimaryKey,AutoIncrement]
        public long id { get; set; }

        public long user_id { get; set; }

        public int job_type { get; set; }

        public int level { get; set; }

    }
}