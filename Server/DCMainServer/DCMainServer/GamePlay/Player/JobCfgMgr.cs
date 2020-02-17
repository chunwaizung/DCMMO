using System.Collections.Generic;
using DC.Collections.Generic;

namespace DC
{
    public partial class JobCfgMgr : Singleton<JobCfgMgr>
    {
        private Dictionary<string, JobConfigDefine> mJobLvToCfg;

        protected override void OnInit()
        {
            base.OnInit();
            
            mJobLvToCfg = new Dictionary<string, JobConfigDefine>();

            foreach (var define in JobConfig)
            {
                mJobLvToCfg.Add(define.JobType + "_" + define.Level, define);
            }
        }

        public JobConfigDefine Get(int job, int lv)
        {
            return mJobLvToCfg.GetValEx(job + "_" + lv);
        }


    }
}