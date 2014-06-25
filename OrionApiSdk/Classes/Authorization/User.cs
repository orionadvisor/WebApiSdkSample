using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrionApiSdk.Classes.Enums;

namespace OrionApiSdk.Classes.Authorization
{
    public class User
    {
        public Entity entity { get; set; }
        public object entityId { get; set; }
        public string userName { get; set; }
        public string loginUserId { get; set; }
        public int databaseCount { get; set; }
        public int userId { get; set; }
        public int userDetailId { get; set; }
        public int alClientId { get; set; }
        public string alClientName { get; set; }
        public string userGuid { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
    }
}
