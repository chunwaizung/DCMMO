using SQLite;

namespace DC.Model
{
    [ModelCls]
    public class DBTask : BaseModel
    {
        [PrimaryKey,AutoIncrement]
        public int id { get; set; }

        [Indexed]
        public int role_id { get; set; }

        public string name { get; set; }

        public int progress { get; set; }

        public int state { get; set; }
    }
}