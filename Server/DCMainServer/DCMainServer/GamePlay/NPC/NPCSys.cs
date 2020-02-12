using System;

namespace DC
{
    public class NPCSys : BaseSys
    {

        //至多10万个npc，假设玩家角色最多1亿
        public int base_index = 100000001;
        private byte[] mIdPool = new byte[10000 * 10];
        private int mCurrentIndex;

        /// <summary>
        /// 生成一个临时的actorID
        /// 从上一个使用的位置开始找，过了范围就从头找
        /// </summary>
        /// <returns></returns>
        public int GenerateTempNpcActorId()
        {
            var initVal = mCurrentIndex;
            while (mIdPool[mCurrentIndex] == 1 && mCurrentIndex < mIdPool.Length)
            {
                mCurrentIndex++;
            }

            if (mCurrentIndex == mIdPool.Length)
            {
                mCurrentIndex = 0;
                while (mIdPool[mCurrentIndex] == 1 && mCurrentIndex < initVal)
                {
                    mCurrentIndex++;
                }

                if (mCurrentIndex == initVal)
                {
                    throw new Exception("npc count is more than max val " + mIdPool.Length);
                }
            }

            return base_index + mCurrentIndex;
        }

        public void ReleaseId(int id)
        {
            var index = id - base_index;
            if (index < 0 || index >= mIdPool.Length)
            {
                DCLog.Log("out range id: " + id);
                return;
            }
            mIdPool[index] = 0;
        }

    }

}
