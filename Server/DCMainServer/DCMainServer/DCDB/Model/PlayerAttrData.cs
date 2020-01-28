using SQLite;

namespace DC.Model
{
    [ModelCls]
    public class PlayerAttrData
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public int role_id { get; set; }
        public int hp { get; set; }
        public int mp { get; set; }
        public int physic_atk { get; set; }
        public int magic_atk { get; set; }
        public int physic_def { get; set; }
        public int magic_def { get; set; }
    }
}