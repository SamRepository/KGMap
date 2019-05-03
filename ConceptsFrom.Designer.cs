namespace DXData_Hub
{
    partial class ConceptsFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataLayoutConcepts = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.lookUpEdit_VocburalyID = new DevExpress.XtraEditors.LookUpEdit();
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.vocabularysBindingSource = new System.Windows.Forms.BindingSource();
            this.gS_Concepts = new DXData_Hub.App_Data.Main_DataSet();
            this.textEdit_ConceptName = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_Synonymes = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEdit_SubConceptID = new DevExpress.XtraEditors.LookUpEdit();
            this.conceptsBindingSource = new System.Windows.Forms.BindingSource();
            this.MemoTextEdit_Comment = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.vocabularysTableAdapter = new DXData_Hub.App_Data.Main_DataSetTableAdapters.VocabularysTableAdapter();
            this.concepts_TableAdapter = new DXData_Hub.App_Data.Main_DataSetTableAdapters.Concepts_TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutConcepts)).BeginInit();
            this.dataLayoutConcepts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_VocburalyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vocabularysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gS_Concepts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_ConceptName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Synonymes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_SubConceptID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoTextEdit_Comment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutConcepts
            // 
            this.dataLayoutConcepts.AllowCustomization = false;
            this.dataLayoutConcepts.Controls.Add(this.lookUpEdit_VocburalyID);
            this.dataLayoutConcepts.Controls.Add(this.textEdit_ConceptName);
            this.dataLayoutConcepts.Controls.Add(this.textEdit_Synonymes);
            this.dataLayoutConcepts.Controls.Add(this.lookUpEdit_SubConceptID);
            this.dataLayoutConcepts.Controls.Add(this.MemoTextEdit_Comment);
            this.dataLayoutConcepts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutConcepts.Location = new System.Drawing.Point(0, 143);
            this.dataLayoutConcepts.Name = "dataLayoutConcepts";
            this.dataLayoutConcepts.Root = this.layoutControlGroup1;
            this.dataLayoutConcepts.Size = new System.Drawing.Size(519, 197);
            this.dataLayoutConcepts.TabIndex = 0;
            // 
            // lookUpEdit_VocburalyID
            // 
            this.lookUpEdit_VocburalyID.Location = new System.Drawing.Point(92, 12);
            this.lookUpEdit_VocburalyID.MenuManager = this.mainRibbonControl;
            this.lookUpEdit_VocburalyID.Name = "lookUpEdit_VocburalyID";
            this.lookUpEdit_VocburalyID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.lookUpEdit_VocburalyID.Properties.Appearance.Options.UseTextOptions = true;
            this.lookUpEdit_VocburalyID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lookUpEdit_VocburalyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_VocburalyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vocabulary_Id", "Vocabulary_Id", 10, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vocabulary_Name", "Vocabulary_Name", 30, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vocabulary_URI", "Vocabulary_URI", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit_VocburalyID.Properties.DataSource = this.vocabularysBindingSource;
            this.lookUpEdit_VocburalyID.Properties.DisplayMember = "Vocabulary_Name";
            this.lookUpEdit_VocburalyID.Properties.NullText = "";
            this.lookUpEdit_VocburalyID.Properties.ValueMember = "Vocabulary_Id";
            this.lookUpEdit_VocburalyID.Size = new System.Drawing.Size(76, 20);
            this.lookUpEdit_VocburalyID.StyleController = this.dataLayoutConcepts;
            this.lookUpEdit_VocburalyID.TabIndex = 11;
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiSave,
            this.bbiReset,
            this.bbiClose});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 10;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(519, 143);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 2;
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset";
            this.bbiReset.Id = 5;
            this.bbiReset.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiReset.Name = "bbiReset";
            this.bbiReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReset_ItemClick);
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 7;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            this.bbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiClose_ItemClick);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup});
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Home";
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSave);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiReset);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiClose);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.ShowCaptionButton = false;
            this.mainRibbonPageGroup.Text = "Tasks";
            // 
            // vocabularysBindingSource
            // 
            this.vocabularysBindingSource.DataMember = "Vocabularys";
            this.vocabularysBindingSource.DataSource = this.gS_Concepts;
            // 
            // gS_Concepts
            // 
            this.gS_Concepts.DataSetName = "Main_DataSet";
            this.gS_Concepts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textEdit_ConceptName
            // 
            this.textEdit_ConceptName.Location = new System.Drawing.Point(252, 12);
            this.textEdit_ConceptName.MenuManager = this.mainRibbonControl;
            this.textEdit_ConceptName.Name = "textEdit_ConceptName";
            this.textEdit_ConceptName.Size = new System.Drawing.Size(86, 20);
            this.textEdit_ConceptName.StyleController = this.dataLayoutConcepts;
            this.textEdit_ConceptName.TabIndex = 12;
            // 
            // textEdit_Synonymes
            // 
            this.textEdit_Synonymes.Location = new System.Drawing.Point(92, 36);
            this.textEdit_Synonymes.MenuManager = this.mainRibbonControl;
            this.textEdit_Synonymes.Name = "textEdit_Synonymes";
            this.textEdit_Synonymes.Size = new System.Drawing.Size(415, 20);
            this.textEdit_Synonymes.StyleController = this.dataLayoutConcepts;
            this.textEdit_Synonymes.TabIndex = 13;
            // 
            // lookUpEdit_SubConceptID
            // 
            this.lookUpEdit_SubConceptID.Location = new System.Drawing.Point(422, 12);
            this.lookUpEdit_SubConceptID.MenuManager = this.mainRibbonControl;
            this.lookUpEdit_SubConceptID.Name = "lookUpEdit_SubConceptID";
            this.lookUpEdit_SubConceptID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lookUpEdit_SubConceptID.Properties.Appearance.Options.UseTextOptions = true;
            this.lookUpEdit_SubConceptID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lookUpEdit_SubConceptID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_SubConceptID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Concept_Id", "Concept_Id", 10, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Concept_Name", "Concept_Name", 30, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit_SubConceptID.Properties.DataSource = this.conceptsBindingSource;
            this.lookUpEdit_SubConceptID.Properties.DisplayMember = "Concept_Name";
            this.lookUpEdit_SubConceptID.Properties.NullText = "";
            this.lookUpEdit_SubConceptID.Properties.ValueMember = "Concept_Id";
            this.lookUpEdit_SubConceptID.Size = new System.Drawing.Size(85, 20);
            this.lookUpEdit_SubConceptID.StyleController = this.dataLayoutConcepts;
            this.lookUpEdit_SubConceptID.TabIndex = 15;
            // 
            // conceptsBindingSource
            // 
            this.conceptsBindingSource.DataMember = "Concepts_";
            this.conceptsBindingSource.DataSource = this.gS_Concepts;
            // 
            // MemoTextEdit_Comment
            // 
            this.MemoTextEdit_Comment.Location = new System.Drawing.Point(12, 76);
            this.MemoTextEdit_Comment.MenuManager = this.mainRibbonControl;
            this.MemoTextEdit_Comment.Name = "MemoTextEdit_Comment";
            this.MemoTextEdit_Comment.Size = new System.Drawing.Size(495, 109);
            this.MemoTextEdit_Comment.StyleController = this.dataLayoutConcepts;
            this.MemoTextEdit_Comment.TabIndex = 14;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(519, 197);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem6,
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(499, 177);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textEdit_ConceptName;
            this.layoutControlItem4.Location = new System.Drawing.Point(160, 0);
            this.layoutControlItem4.Name = "ItemForConcept_Name";
            this.layoutControlItem4.Size = new System.Drawing.Size(170, 24);
            this.layoutControlItem4.Text = "Concept Name";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.textEdit_Synonymes;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "ItemForSynSet";
            this.layoutControlItem5.Size = new System.Drawing.Size(499, 24);
            this.layoutControlItem5.Text = "Synonymes";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.lookUpEdit_SubConceptID;
            this.layoutControlItem7.Location = new System.Drawing.Point(330, 0);
            this.layoutControlItem7.Name = "ItemForSubConceptOf_Id";
            this.layoutControlItem7.Size = new System.Drawing.Size(169, 24);
            this.layoutControlItem7.Text = "Sub Concept Of";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.MemoTextEdit_Comment;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem6.Name = "ItemForComment";
            this.layoutControlItem6.Size = new System.Drawing.Size(499, 129);
            this.layoutControlItem6.Text = "Definition";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lookUpEdit_VocburalyID;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "ItemForVocabulary_Id";
            this.layoutControlItem3.Size = new System.Drawing.Size(160, 24);
            this.layoutControlItem3.Text = "Vocabulary";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(77, 13);
            // 
            // vocabularysTableAdapter
            // 
            this.vocabularysTableAdapter.ClearBeforeFill = true;
            // 
            // concepts_TableAdapter
            // 
            this.concepts_TableAdapter.ClearBeforeFill = true;
            // 
            // ConceptsFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(519, 340);
            this.Controls.Add(this.dataLayoutConcepts);
            this.Controls.Add(this.mainRibbonControl);
            this.Name = "ConceptsFrom";
            this.Ribbon = this.mainRibbonControl;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConceptsFrom_FormClosing);
            this.Load += new System.EventHandler(this.ConceptsFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutConcepts)).EndInit();
            this.dataLayoutConcepts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_VocburalyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vocabularysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gS_Concepts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_ConceptName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Synonymes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_SubConceptID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoTextEdit_Comment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutConcepts;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_VocburalyID;
        private DevExpress.XtraEditors.TextEdit textEdit_ConceptName;
        private DevExpress.XtraEditors.TextEdit textEdit_Synonymes;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_SubConceptID;
        private DevExpress.XtraEditors.MemoEdit MemoTextEdit_Comment;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private App_Data.Main_DataSet gS_Concepts;
        private System.Windows.Forms.BindingSource vocabularysBindingSource;
        private App_Data.Main_DataSetTableAdapters.VocabularysTableAdapter vocabularysTableAdapter;
        private System.Windows.Forms.BindingSource conceptsBindingSource;
        private App_Data.Main_DataSetTableAdapters.Concepts_TableAdapter concepts_TableAdapter;
    }
}