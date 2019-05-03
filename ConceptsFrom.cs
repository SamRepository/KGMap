using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using System.IO;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraLayout;
using System.Configuration;
using System.Data.SqlClient;

namespace DXData_Hub
{
    public partial class ConceptsFrom : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ConceptsFrom()
        {
            InitializeComponent(); 
        }
        private void ConceptsFrom_Load(object sender, EventArgs e)
        {
            this.concepts_TableAdapter.Fill(this.gS_Concepts.Concepts_);
            this.vocabularysTableAdapter.Fill(this.gS_Concepts.Vocabularys);
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lookUpEdit_VocburalyID.EditValue = null;
            textEdit_ConceptName.Text = String.Empty;
            lookUpEdit_SubConceptID.EditValue = null;
            textEdit_Synonymes.Text = String.Empty;
            MemoTextEdit_Comment.Text = String.Empty;
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DXData_Hub.Properties.Settings.Mapping_SchemaConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spConcepts_Insert", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Vocabulary_Id", lookUpEdit_VocburalyID.EditValue);
                cmd.Parameters.AddWithValue("@Concept_Name", textEdit_ConceptName.Text);
                cmd.Parameters.AddWithValue("@SubConceptOf_Id", lookUpEdit_SubConceptID.EditValue);
                cmd.Parameters.AddWithValue("@SynSet ", textEdit_Synonymes.Text);
                cmd.Parameters.AddWithValue("@Comment ", MemoTextEdit_Comment.Text);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("The Concept ["+ textEdit_ConceptName.Text +"] was succesfuly added", "New Concept", MessageBoxButtons.OK, MessageBoxIcon.Information);
            concepts_TableAdapter.Fill(this.gS_Concepts.Concepts_);
            lookUpEdit_SubConceptID.Refresh();
            bbiReset_ItemClick(sender, e);
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bbiSave_ItemClick(sender,e);
            bbiReset_ItemClick(sender, e);
        }

        private void ConceptsFrom_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }  
}
