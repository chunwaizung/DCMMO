using System;

namespace DC
{
    public partial class ParamsCfgMgr : Singleton<ParamsCfgMgr>
    {
        protected override void OnInit()
        {
            
        }

        public string Get(int id)
        {
            var cfg = GetParamsConfigByID(id);
            if (cfg == null)
            {
                throw new Exception("no such id: " + id);
            }

            return cfg.Value;
        }

        public int GetInt(int id)
        {
            return int.Parse(Get(id));
        }

        public long GetLong(int id)
        {
            return long.Parse(Get(id));
        }

        public float GetFloat(int id)
        {
            return float.Parse(Get(id));
        }

        public double GetDouble(int id)
        {
            return double.Parse(Get(id));
        }
    }
}