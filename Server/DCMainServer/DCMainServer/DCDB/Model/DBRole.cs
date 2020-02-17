using SQLite;

namespace DC.Model
{
    [ModelCls]
    public class DBRole : BaseModel
    {
        [PrimaryKey,AutoIncrement]
        public int id { get; set; }

        [Indexed]
        public long user_id { get; set; }

        public int job_type { get; set; }

        public int level { get; set; }

        /// <summary>
        /// 当前的经验，每次升级置0
        /// </summary>
        public long exp { get; set; }

        public string name { get; set; }

        /// <summary>
        /// /玩家最后所在关卡
        /// </summary>
        public int lastLevelId { get; set; }

        public int lastPosX { get; set; }

        public int lastPosY { get; set; }
    }
}