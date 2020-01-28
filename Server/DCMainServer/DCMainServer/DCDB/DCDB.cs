using System.Linq;
using DC.Model;
using SQLite;

namespace DC
{
    public class DCDB : Singleton<DCDB>
    {

        private SQLiteConnection mCon;

        public SQLiteConnection GetCon()
        {
            return mCon;
        }

        protected override void OnInit()
        {
            
        }

        public void Setup(string db_path)
        {
            mCon = new SQLiteConnection(db_path);
            var types = GetType().Assembly.GetTypes().Where(t=>t.GetCustomAttributes(typeof(ModelCls),false).Length > 0);
            foreach (var modelType in types)
            {
                mCon.CreateTable(modelType);
            }
        }

        public void TestQuery()
        {
            mCon.Table<Role>().Where(r => r.user_id == 1);
        }

        public bool Execute(string sql)
        {
//            new SQLiteCommandBuilder()
            var cmd = new SQLiteCommand(mCon);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            return true;
        }

    }

}
