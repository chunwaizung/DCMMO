using System.Collections.Generic;

namespace DC
{
    public class StrengthInfo : StringMemModel
    {
        public int level;

        private Dictionary<int,int> mTypeToVal;

        public override void Deserialize(string content)
        {
            base.Deserialize(content);
            if (null == mTypeToVal)
            {
                mTypeToVal = new Dictionary<int, int>();
            }
            else
            {
                mTypeToVal.Clear();
            }


        }

    }
}