namespace DC.Model
{
    [ModelCls]
    public class DBRoleEquip : BaseModel
    {
        public int id { get; set; }
        
        public int role_id { get; set; }

        public int equip_type { get; set; }
        /// <summary>
        /// 强化信息
        /// </summary>
        public string strength_info { get; set; }

        /// <summary>
        /// 石头信息
        /// </summary>
        public string stone_info { get; set; }
        
    }
}