using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using EyeonOps.database;
using EyeonOps.models;
using Microsoft.Data.Sqlite;

namespace EyeonOps.data
{
    internal class UserAccess
    {
        private SqliteConnection systemConnection;
        public UserAccess()
        {
            systemConnection = Database.InitializeSystem();
        }
        public User GetUserbyUserName(string UserName)
        {
            return systemConnection.QueryFirstOrDefault<User>("SELECT * FROM `Users` WHERE Username=@UserName",new {UserName});
        }
        public bool AddUser(User user)
        {
            string query = @"
            INSERT INTO Users (Username, Password, FullName, Role, Email, Active)
            VALUES (@Username, @Password, @FullName, @Role, @Email, 1);";

            try
            {
                int rows = systemConnection.Execute(query, new
                {
                    user.Username,
                    user.Password,
                    user.FullName,
                    user.Role,
                    user.Email
                });
                return rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public List<User> GetAllUsers()
        {
            return systemConnection.Query<User>("SELECT ID, Username, FullName, Email, Role, Active FROM `Users`").ToList();
        }
        public bool DeleteUser(int id)
        {
            string query = "DELETE FROM Users WHERE ID = @ID";

            try
            {
                int rows = systemConnection.Execute(query, new { ID = id });
                return rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting user:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
