using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    int RandNo = 0;
    [WebMethod]
    public static string Get_CurrentPosition(string RecordType, string ID, string strFromDate, string strToDate)
    {
        
        string str = string.Empty;

        Random random = new Random();
        int i= Convert.ToInt32(random.Next(10, 1000));

        str += "28.6667" + i + "@77.217" + i + "#25.6667@79.2167";


        return str;

    }
   
}
