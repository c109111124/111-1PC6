using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1PC6
{
    public partial class Test : System.Web.UI.Page
    {
        string[] i_school = new string [3] {"台科","北科","亞東"};
    
        protected void Page_Load(object sender, EventArgs e)
        {

                for (int i_Ct = 0; i_Ct < i_school.Length; i_Ct++)
                {
                    ListItem o_L = new ListItem();
                    o_L.Text = i_school[i_Ct];
                    o_L.Value = i_school[i_Ct];

                    ddl_Test.Items.Add(o_L);

                }
        }


    }
}