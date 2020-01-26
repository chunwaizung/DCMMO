using DC.Model;
using SQLite;

namespace DC
{
    public class DCDB
    {
        public const string db_path = "";

        private SQLiteConnection mCon;

        public void Init()
        {
            var db = new SQLiteConnection("foofoo");
            db.CreateTable<User>();
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
