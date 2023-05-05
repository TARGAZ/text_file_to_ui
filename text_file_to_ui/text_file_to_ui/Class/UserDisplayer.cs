using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_file_to_ui.Class
{
    public class UserDisplayer
    {
        public User userToDisplay;
        public UserInfoFrom userInfoFrom;

        public UserDisplayer(User userToDisplay, UserInfoFrom userInfoFrom) 
        {
            this.userToDisplay = userToDisplay;
            this.userInfoFrom = userInfoFrom;
        }

        public void DisplayUser()
        {
            //Put the user information inside the text box
            userInfoFrom.txtFullName.Text = userToDisplay.FullName;
            userInfoFrom.txtYearsOfBirth.Text = userToDisplay.YearsOfBirth;
            userInfoFrom.txtCity.Text = userToDisplay.City;
            userInfoFrom.txtFaculty.Text = userToDisplay.Faculty;
            userInfoFrom.txtRole.Text = userToDisplay.Role;
            userInfoFrom.txtRoleSpecificationAtribut.Text = userToDisplay.Atribut;
            userInfoFrom.lbRoleSpecificationAtribut.Text = userToDisplay.RoleSpecificationAtribut;
        }

        
    }
}
