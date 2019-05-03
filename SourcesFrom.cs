using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using System.Data.SqlClient;
using System.Configuration;
using Facebook;

namespace DXData_Hub
{
    public partial class SourcesFrom : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private const string AppId = "1817061198534250";
        private const string ExtendedPermissions = "user_about_me,publish_actions";
        public SourcesFrom()
        {
            InitializeComponent();
            
        }

        private void Source_TypeTextEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            navigationFrame.SelectedPageIndex = Source_TypeTextEdit.SelectedIndex;
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        
        private void AuthenticationTypetextEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RDB_AuthenticationTypetextEdit.SelectedIndex == 0)
            {
                RDB_UserIDtextEdit.Enabled = RDB_PasswordTextEdit.Enabled= false;
            }
            else
                RDB_UserIDtextEdit.Enabled = RDB_PasswordTextEdit.Enabled = true;
            
        }


        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            Source_TypeTextEdit.EditValue = "Relational Data";
            Source_NameTextEdit.Text = String.Empty;
            RDB_ProviderTextEdit.EditValue = null;
            RDB_ServerNameTextEdit.Text = String.Empty;
            RDB_AuthenticationTypetextEdit.EditValue = null;
            RDB_DataBaseNameTextEdit.Text = String.Empty;
            RDB_UserIDtextEdit.Text = String.Empty;
            RDB_PasswordTextEdit.Text = String.Empty;
            RDB_Con_StrTextEdit.Text = String.Empty;
            LD_DatasetTextEdit.Text = null;
            LD_EndpointUrlTextEdit.Text= String.Empty;
            LD_LimitNbrResultsSpinEdit.Text = "1";

        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DXData_Hub.Properties.Settings.Mapping_SchemaConnectionString"].ConnectionString;
            switch (Source_TypeTextEdit.EditValue)
            {
                case "Relational Data":
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        SqlCommand cmd = new SqlCommand("spDataSource_RelationalData_Insert", con);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Source_Type", "RelationalData");
                        cmd.Parameters.AddWithValue("@Source_Name", Source_NameTextEdit.Text);
                        cmd.Parameters.AddWithValue("@Provider", RDB_ProviderTextEdit.Text);
                        cmd.Parameters.AddWithValue("@Server", RDB_ServerNameTextEdit.Text);
                        cmd.Parameters.AddWithValue("@User ", RDB_UserIDtextEdit.Text);
                        cmd.Parameters.AddWithValue("@Password", RDB_PasswordTextEdit.Text);
                        cmd.Parameters.AddWithValue("@Con_Name ", "Conn_2_"+ Source_NameTextEdit.Text);
                        cmd.Parameters.AddWithValue("@Con_Str ", RDB_Con_StrTextEdit.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("The Data Source [" + Source_NameTextEdit.Text + "] was succesfuly added", "New Data Source", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bbiReset_ItemClick(sender, e);
                    break;

                case "Linked Data":   
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        SqlCommand cmd = new SqlCommand("spDataSource_LinkedData_Insert", con);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Source_Type", "LinkedData");
                        cmd.Parameters.AddWithValue("@Source_Name", Source_NameTextEdit.Text);
                        cmd.Parameters.AddWithValue("@Endpoint_URL", LD_EndpointUrlTextEdit.Text);
                        cmd.Parameters.AddWithValue("@NbrOf_Results ", LD_LimitNbrResultsSpinEdit.Value);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("The Data Set [" + Source_NameTextEdit.Text + "] was succesfuly added", "New Data Set", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bbiReset_ItemClick(sender, e);
                    break;
                case "Social Data":
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        SqlCommand cmd = new SqlCommand("spDataSource_SocialData_Insert", con);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Source_Type", "SocialData");
                        cmd.Parameters.AddWithValue("@Source_Name", Source_NameTextEdit.Text);
                        cmd.Parameters.AddWithValue("@API_Type", SD_API_TypeTextEdit.Text);
                        cmd.Parameters.AddWithValue("@API_URL", SD_APIUrlTextEdit.Text);
                        cmd.Parameters.AddWithValue("@API_Key", SD_AccesTokenMemoEdit.Text);
                        cmd.Parameters.AddWithValue("@NbrOf_Results", SD_NbrOfResultasSpinEdit.Value);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("The Data Set [" + Source_NameTextEdit.Text + "] was succesfuly added", "New Data Set", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bbiReset_ItemClick(sender, e);
                    break;
            }
        }

        private void Con_StrTextEdit_Click(object sender, EventArgs e)
        {
          SqlConnectionStringBuilder sqlBuilder =
          new SqlConnectionStringBuilder();

            if (!string.IsNullOrWhiteSpace(RDB_ServerNameTextEdit.Text))
            {
                sqlBuilder.DataSource = RDB_ServerNameTextEdit.Text;

                if (!string.IsNullOrWhiteSpace(RDB_DataBaseNameTextEdit.Text))
                {
                    sqlBuilder.InitialCatalog = RDB_DataBaseNameTextEdit.Text;
                }
                sqlBuilder.IntegratedSecurity =
                              RDB_AuthenticationTypetextEdit.SelectedText == "Windows" ? true : false;

                // For SQL Server authentication, need a user Id and password
                if (sqlBuilder.IntegratedSecurity == false)
                {
                    sqlBuilder.UserID = RDB_UserIDtextEdit.Text;
                    sqlBuilder.Password = RDB_PasswordTextEdit.Text;
                }
            }
            RDB_Con_StrTextEdit.Text = sqlBuilder.ConnectionString;
        }

        private void LD_DatasetTextEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LD_DatasetTextEdit.SelectedIndex == 0)
            {
                LD_EndpointUrlTextEdit.Text = "http://dbpedia.org/sparql";
            }
            else
            if (LD_DatasetTextEdit.SelectedIndex == 1)
            {
                LD_EndpointUrlTextEdit.Text = "http://geosparql.org/";
            }
        }

        private void SD_ServiceTextEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SD_ServiceTextEdit.SelectedIndex)
            {
                case 0:
                    {
                        SD_APIUrlTextEdit.Text = "https://graph.facebook.com/v2.8";
                        SD_API_TypeTextEdit.Text = "REST";
                    }
                    break;
                case 1:
                    {
                        SD_APIUrlTextEdit.Text = "https://api.linkedin.com/v1";
                    }
                    break;
                case 2:
                    {
                        SD_APIUrlTextEdit.Text = "https://kgsearch.googleapis.com/v1";
                    }
                    break;
                case 3:
                    {
                        SD_APIUrlTextEdit.Text = "https://api.twitter.com/1.1";
                    }
                    break;
            }
        }
//--------------------------------- Facebook Login -------------------------------------------//

        private void SD_LoginBtn_Click(object sender, EventArgs e)
        {
            var fbLoginDlg = new FacebookLoginDialog(AppId, ExtendedPermissions);
            fbLoginDlg.ShowDialog();
            TakeLoggedInAction(fbLoginDlg.FacebookOAuthResult);
        }

        private void TakeLoggedInAction(FacebookOAuthResult facebookOAuthResult)
        {
            if (facebookOAuthResult == null)
            {
                MessageBox.Show("Cancelled!");
                return;
            }
            if (facebookOAuthResult.IsSuccess)
            {
                SD_AccesTokenMemoEdit.Text = facebookOAuthResult.AccessToken;
            }
            else
            {
                MessageBox.Show(facebookOAuthResult.ErrorDescription);
            }
        }
    }
}