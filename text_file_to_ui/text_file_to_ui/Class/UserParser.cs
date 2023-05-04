using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace text_file_to_ui.Class
{
    public class UserParser
    {
        public string[] UserStringData;
        public void PaserData(User user)
        {
            for(int i = 0; i < UserStringData.Length; i++)
            {
                int index = UserStringData[i].LastIndexOf('=');
                if(index >= 0)
                {
                    UserStringData[i] = UserStringData[i].Substring(index+1);
                }
            }

            user.FullName = UserStringData[0];
            user.FullName += ' ';
            user.FullName += UserStringData[1];

            user.YearsOfBirth = int.Parse(UserStringData[2]);

            user.CountryOfOrigin = UserStringData[3];

            user.Faculty = UserStringData[4];

            user.Role = UserStringData[5];

            user.FavoriteCourse = UserStringData[6];
        }

        public UserParser() { }
    }
}
