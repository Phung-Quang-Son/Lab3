using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Bai5
    {
        public class UserProfile
        {
            public string Name { get; set; }
        }
        public class UserService
        {
            public string GetName(UserProfile profile)
            {
                if (profile == null)
                {
                    throw new NullReferenceException("User profile is null.");
                }

                return profile.Name;
            }
        }
    }
}
