using System;
using System.Collections.Generic;
using System.Linq;
using DC.Model;

namespace DC
{
    public class PlayerDB : BaseDB<PlayerDB>
    {
        public User CreateUser(string token)
        {
            var user = new User();
            user.CreatedTime = DateTime.UtcNow;
            user.Token = token;
            Con.Insert(user);
            return user;
        }

        public User GetUser(string token)
        {
            var users = Con.Table<User>().Where(item=>item.Token.Equals(token));
            if (users == null || !users.Any())
            {
                return null;
            }

            return users.First();
        }

        public List<Role> GetRoles(long user_id)
        {
            return Con.Table<Role>().Where(item => item.user_id == user_id).ToList();
        }

        public Role CreateRole(long user_id, int job, string name)
        {
            var role = new Role();
            role.user_id = user_id;
            role.job_type = job;
            role.name = name;
            role.level = 1;
            Con.Insert(role);
            return role;
        }

        public Role GetRole(int role_id)
        {
            var roles = Con.Table<Role>().Where(item => item.id == role_id);
            if (roles.Any())
            {
                return roles.First();
            }

            return null;
        }
    }
}