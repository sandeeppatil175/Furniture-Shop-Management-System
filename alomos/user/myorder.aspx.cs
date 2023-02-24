using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.OleDb;

public partial class user_myorder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SearchByTagButton_Click(object sender, EventArgs e)
    {
        String strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\jayesh\\fjayesh.mdb";
        OleDbConnection conn = new OleDbConnection(strConn);
        conn.Open();
        OleDbCommand cmd = new OleDbCommand("Select * FROM orders WHERE o_id=@SearchByTagTB", conn);

        try
        {

            OleDbParameter search = new OleDbParameter();
            search.ParameterName = "@SearchByTagTB";
            search.Value = SearchByTagTB.Text.Trim();

            cmd.Parameters.Add(search);
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            gvPatients.DataSource = dt;
            gvPatients.DataBind();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
        finally
        {
            //Connection Object Closed
            conn.Close();
        }
    }
}
