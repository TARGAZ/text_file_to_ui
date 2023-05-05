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
            // If there is more attribute of a user and if they are variable, I'll probably only use one string[]
            // and then use a for loop to get the data
            for (int i = 0; i < UserStringData.Length; i++)
            {
                //Keep only the data after the '='
                int index = UserStringData[i].LastIndexOf('=');
                if(index >= 0)
                {
                    if(i == 6)
                    {
                        //Read the user role specification attribute before the '='
                        user.RoleSpecificationAtribut = UserStringData[i].Substring(0, index);
                    }
                    UserStringData[i] = UserStringData[i].Substring(index+1);
                }
            }

            //Put the data inside the user object
            user.FullName = UserStringData[0];
            user.FullName += ' ';
            user.FullName += UserStringData[1];

            user.YearsOfBirth = UserStringData[2];

            user.City = UserStringData[3];

            user.Faculty = UserStringData[4];

            user.Role = UserStringData[5];

            user.Atribut = UserStringData[6];
        }

        public UserParser() { }
    }
}
