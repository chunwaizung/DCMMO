using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DC.Model;

namespace DC
{
    public class PlayerDB : BaseDB<PlayerDB>
    {
        public DBUser AddUser(string token)
        {
            var user = new DBUser();
            user.CreatedTime = DateTime.UtcNow;
            user.Token = token;
            Con.Insert(user);
            return user;
        }

        public DBUser GetUser(string token)
        {
            return GetSingle<DBUser>(item => item.Token.Equals(token));
        }

        public List<DBRole> GetRoles(long user_id)
        {
            return GetList<DBRole>(item => item.user_id == user_id);
        }

        public DBRole AddRole(long user_id, int job, string name)
        {
            var role = new DBRole();
            role.user_id = user_id;
            role.job_type = job;
            role.name = name;
            role.level = 1;
            Con.Insert(role);
            return role;
        }

        public DBRole GetRole(int role_id)
        {
            return GetSingle<DBRole>(item => item.id == role_id);
        }

        public DBRoleData GetRoleData(int role_id)
        {
            return GetSingle<DBRoleData>(item => item.role_id == role_id);
        }

        public void SaveRoleData(DBRoleData data)
        {
            Con.Insert(data);
        }
    }
}