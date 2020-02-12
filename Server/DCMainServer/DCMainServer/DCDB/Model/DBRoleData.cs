using SQLite;

namespace DC.Model
{
    [ModelCls]
    public class DBRoleData
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        public int role_id { get; set; }

        public int max_hp { get; set; }
        public int max_mp { get; set; }
        public int hp { get; set; }
        public int mp { get; set; }

        public int physic_atk { get; set; }
        public int magic_atk { get; set; }
        public int physic_defense { get; set; }
        public int magic_defense { get; set; }
    }
}