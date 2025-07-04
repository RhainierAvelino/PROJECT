namespace Smart_Stock_Project
{
    partial class AprioriAnalysis
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelLeftSide = new System.Windows.Forms.Panel();
            this.groupBoxRecommendations = new System.Windows.Forms.GroupBox();
            this.listViewRecommendations = new System.Windows.Forms.ListView();
            this.columnRank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnWhenCustomerBuys = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTheyAlsoBuy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSuccessRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRevenueBoost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnActionNeeded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelAnalysisControl = new System.Windows.Forms.Panel();
            this.lblAnalysisStatus = new System.Windows.Forms.Label();
            this.progressBarAnalysis = new System.Windows.Forms.ProgressBar();
            this.btnRunAnalysis = new System.Windows.Forms.Button();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelFilters = new System.Windows.Forms.TableLayoutPanel();
            this.lblDateRange = new System.Windows.Forms.Label();
            this.panelDateRange = new System.Windows.Forms.Panel();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.lblRecommendationType = new System.Windows.Forms.Label();
            this.comboBoxConfidenceFilter = new System.Windows.Forms.ComboBox();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.comboBoxCategoryFilter = new System.Windows.Forms.ComboBox();
            this.panelRightSide = new System.Windows.Forms.Panel();
            this.groupBoxInsights = new System.Windows.Forms.GroupBox();
            this.richTextBoxBusinessInsights = new System.Windows.Forms.RichTextBox();
            this.panelExport = new System.Windows.Forms.Panel();
            this.btnExportReport = new System.Windows.Forms.Button();
            this.panelStats = new System.Windows.Forms.Panel();
            this.panelStat3 = new System.Windows.Forms.Panel();
            this.lblPotentialRevenue = new System.Windows.Forms.Label();
            this.lblStatLabel3 = new System.Windows.Forms.Label();
            this.panelStat2 = new System.Windows.Forms.Panel();
            this.lblHighValue = new System.Windows.Forms.Label();
            this.lblStatLabel2 = new System.Windows.Forms.Label();
            this.panelStat1 = new System.Windows.Forms.Panel();
            this.lblTotalOpportunities = new System.Windows.Forms.Label();
            this.lblStatLabel1 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelLeftSide.SuspendLayout();
            this.groupBoxRecommendations.SuspendLayout();
            this.panelAnalysisControl.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            this.tableLayoutPanelFilters.SuspendLayout();
            this.panelDateRange.SuspendLayout();
            this.panelRightSide.SuspendLayout();
            this.groupBoxInsights.SuspendLayout();
            this.panelExport.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.panelStat3.SuspendLayout();
            this.panelStat2.SuspendLayout();
            this.panelStat1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Controls.Add(this.panelStats);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(1121, 738);
            this.panelMain.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.splitContainer);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(20, 240);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelContent.Size = new System.Drawing.Size(1081, 478);
            this.panelContent.TabIndex = 2;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 10);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panelLeftSide);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panelRightSide);
            this.splitContainer.Size = new System.Drawing.Size(1081, 468);
            this.splitContainer.SplitterDistance = 620;
            this.splitContainer.TabIndex = 0;
            // 
            // panelLeftSide
            // 
            this.panelLeftSide.Controls.Add(this.groupBoxRecommendations);
            this.panelLeftSide.Controls.Add(this.panelAnalysisControl);
            this.panelLeftSide.Controls.Add(this.groupBoxFilters);
            this.panelLeftSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeftSide.Location = new System.Drawing.Point(0, 0);
            this.panelLeftSide.Name = "panelLeftSide";
            this.panelLeftSide.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panelLeftSide.Size = new System.Drawing.Size(620, 468);
            this.panelLeftSide.TabIndex = 0;
            // 
            // groupBoxRecommendations
            // 
            this.groupBoxRecommendations.BackColor = System.Drawing.Color.White;
            this.groupBoxRecommendations.Controls.Add(this.listViewRecommendations);
            this.groupBoxRecommendations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRecommendations.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRecommendations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.groupBoxRecommendations.Location = new System.Drawing.Point(0, 220);
            this.groupBoxRecommendations.Name = "groupBoxRecommendations";
            this.groupBoxRecommendations.Padding = new System.Windows.Forms.Padding(20, 15, 20, 20);
            this.groupBoxRecommendations.Size = new System.Drawing.Size(610, 248);
            this.groupBoxRecommendations.TabIndex = 2;
            this.groupBoxRecommendations.TabStop = false;
            this.groupBoxRecommendations.Text = "💡 Smart Bundling Recommendations";
            this.groupBoxRecommendations.Enter += new System.EventHandler(this.groupBoxRecommendations_Enter);
            // 
            // listViewRecommendations
            // 
            this.listViewRecommendations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.listViewRecommendations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewRecommendations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnRank,
            this.columnWhenCustomerBuys,
            this.columnTheyAlsoBuy,
            this.columnSuccessRate,
            this.columnRevenueBoost,
            this.columnActionNeeded});
            this.listViewRecommendations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRecommendations.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewRecommendations.FullRowSelect = true;
            this.listViewRecommendations.GridLines = true;
            this.listViewRecommendations.HideSelection = false;
            this.listViewRecommendations.Location = new System.Drawing.Point(20, 35);
            this.listViewRecommendations.Name = "listViewRecommendations";
            this.listViewRecommendations.Size = new System.Drawing.Size(570, 193);
            this.listViewRecommendations.TabIndex = 0;
            this.listViewRecommendations.UseCompatibleStateImageBehavior = false;
            this.listViewRecommendations.View = System.Windows.Forms.View.Details;
            // 
            // columnRank
            // 
            this.columnRank.Text = "#";
            this.columnRank.Width = 30;
            // 
            // columnWhenCustomerBuys
            // 
            this.columnWhenCustomerBuys.Text = "When Customer Buys";
            this.columnWhenCustomerBuys.Width = 130;
            // 
            // columnTheyAlsoBuy
            // 
            this.columnTheyAlsoBuy.Text = "They Also Buy";
            this.columnTheyAlsoBuy.Width = 130;
            // 
            // columnSuccessRate
            // 
            this.columnSuccessRate.Text = "Success Rate";
            this.columnSuccessRate.Width = 80;
            // 
            // columnRevenueBoost
            // 
            this.columnRevenueBoost.Text = "Revenue Boost";
            this.columnRevenueBoost.Width = 90;
            // 
            // columnActionNeeded
            // 
            this.columnActionNeeded.Text = "Action Needed";
            this.columnActionNeeded.Width = 190;
            // 
            // panelAnalysisControl
            // 
            this.panelAnalysisControl.BackColor = System.Drawing.Color.White;
            this.panelAnalysisControl.Controls.Add(this.lblAnalysisStatus);
            this.panelAnalysisControl.Controls.Add(this.progressBarAnalysis);
            this.panelAnalysisControl.Controls.Add(this.btnRunAnalysis);
            this.panelAnalysisControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAnalysisControl.Location = new System.Drawing.Point(0, 140);
            this.panelAnalysisControl.Name = "panelAnalysisControl";
            this.panelAnalysisControl.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelAnalysisControl.Size = new System.Drawing.Size(610, 80);
            this.panelAnalysisControl.TabIndex = 1;
            // 
            // lblAnalysisStatus
            // 
            this.lblAnalysisStatus.AutoSize = true;
            this.lblAnalysisStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalysisStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblAnalysisStatus.Location = new System.Drawing.Point(498, 29);
            this.lblAnalysisStatus.Name = "lblAnalysisStatus";
            this.lblAnalysisStatus.Size = new System.Drawing.Size(95, 15);
            this.lblAnalysisStatus.TabIndex = 2;
            this.lblAnalysisStatus.Text = "Ready to analyze";
            this.lblAnalysisStatus.Visible = false;
            // 
            // progressBarAnalysis
            // 
            this.progressBarAnalysis.Location = new System.Drawing.Point(240, 25);
            this.progressBarAnalysis.Name = "progressBarAnalysis";
            this.progressBarAnalysis.Size = new System.Drawing.Size(251, 20);
            this.progressBarAnalysis.TabIndex = 1;
            this.progressBarAnalysis.Visible = false;
            // 
            // btnRunAnalysis
            // 
            this.btnRunAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnRunAnalysis.FlatAppearance.BorderSize = 0;
            this.btnRunAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunAnalysis.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunAnalysis.ForeColor = System.Drawing.Color.White;
            this.btnRunAnalysis.Location = new System.Drawing.Point(20, 15);
            this.btnRunAnalysis.Name = "btnRunAnalysis";
            this.btnRunAnalysis.Size = new System.Drawing.Size(200, 40);
            this.btnRunAnalysis.TabIndex = 0;
            this.btnRunAnalysis.Text = "🔄 Run New Analysis";
            this.btnRunAnalysis.UseVisualStyleBackColor = false;
            this.btnRunAnalysis.Click += new System.EventHandler(this.btnRunAnalysis_Click);
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.BackColor = System.Drawing.Color.White;
            this.groupBoxFilters.Controls.Add(this.tableLayoutPanelFilters);
            this.groupBoxFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFilters.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.groupBoxFilters.Location = new System.Drawing.Point(0, 0);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Padding = new System.Windows.Forms.Padding(20, 15, 20, 20);
            this.groupBoxFilters.Size = new System.Drawing.Size(610, 140);
            this.groupBoxFilters.TabIndex = 0;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "🔍 Analysis Settings";
            // 
            // tableLayoutPanelFilters
            // 
            this.tableLayoutPanelFilters.ColumnCount = 2;
            this.tableLayoutPanelFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelFilters.Controls.Add(this.lblDateRange, 0, 0);
            this.tableLayoutPanelFilters.Controls.Add(this.panelDateRange, 1, 0);
            this.tableLayoutPanelFilters.Controls.Add(this.lblRecommendationType, 0, 1);
            this.tableLayoutPanelFilters.Controls.Add(this.comboBoxConfidenceFilter, 1, 1);
            this.tableLayoutPanelFilters.Controls.Add(this.lblProductCategory, 0, 2);
            this.tableLayoutPanelFilters.Controls.Add(this.comboBoxCategoryFilter, 1, 2);
            this.tableLayoutPanelFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFilters.Location = new System.Drawing.Point(20, 35);
            this.tableLayoutPanelFilters.Name = "tableLayoutPanelFilters";
            this.tableLayoutPanelFilters.RowCount = 3;
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFilters.Size = new System.Drawing.Size(570, 85);
            this.tableLayoutPanelFilters.TabIndex = 0;
            // 
            // lblDateRange
            // 
            this.lblDateRange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDateRange.AutoSize = true;
            this.lblDateRange.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblDateRange.Location = new System.Drawing.Point(3, 4);
            this.lblDateRange.Name = "lblDateRange";
            this.lblDateRange.Size = new System.Drawing.Size(106, 19);
            this.lblDateRange.TabIndex = 0;
            this.lblDateRange.Text = "📅 Date Range:";
            // 
            // panelDateRange
            // 
            this.panelDateRange.Controls.Add(this.dateTimePickerTo);
            this.panelDateRange.Controls.Add(this.lblTo);
            this.panelDateRange.Controls.Add(this.dateTimePickerFrom);
            this.panelDateRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDateRange.Location = new System.Drawing.Point(174, 3);
            this.panelDateRange.Name = "panelDateRange";
            this.panelDateRange.Size = new System.Drawing.Size(393, 22);
            this.panelDateRange.TabIndex = 1;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(151, 0);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(120, 23);
            this.dateTimePickerTo.TabIndex = 2;
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.OnFilterChanged);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTo.Location = new System.Drawing.Point(126, 4);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(18, 15);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "to";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(0, 0);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(120, 23);
            this.dateTimePickerFrom.TabIndex = 0;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.OnFilterChanged);
            // 
            // lblRecommendationType
            // 
            this.lblRecommendationType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRecommendationType.AutoSize = true;
            this.lblRecommendationType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecommendationType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblRecommendationType.Location = new System.Drawing.Point(3, 32);
            this.lblRecommendationType.Name = "lblRecommendationType";
            this.lblRecommendationType.Size = new System.Drawing.Size(142, 19);
            this.lblRecommendationType.TabIndex = 2;
            this.lblRecommendationType.Text = "🎯 Recommendation:";
            // 
            // comboBoxConfidenceFilter
            // 
            this.comboBoxConfidenceFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxConfidenceFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConfidenceFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxConfidenceFilter.FormattingEnabled = true;
            this.comboBoxConfidenceFilter.Location = new System.Drawing.Point(174, 31);
            this.comboBoxConfidenceFilter.Name = "comboBoxConfidenceFilter";
            this.comboBoxConfidenceFilter.Size = new System.Drawing.Size(393, 23);
            this.comboBoxConfidenceFilter.TabIndex = 3;
            this.comboBoxConfidenceFilter.SelectedIndexChanged += new System.EventHandler(this.OnFilterChanged);
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblProductCategory.Location = new System.Drawing.Point(3, 61);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(143, 19);
            this.lblProductCategory.TabIndex = 4;
            this.lblProductCategory.Text = "🏷️ Product Category:";
            // 
            // comboBoxCategoryFilter
            // 
            this.comboBoxCategoryFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoryFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategoryFilter.FormattingEnabled = true;
            this.comboBoxCategoryFilter.Location = new System.Drawing.Point(174, 59);
            this.comboBoxCategoryFilter.Name = "comboBoxCategoryFilter";
            this.comboBoxCategoryFilter.Size = new System.Drawing.Size(393, 23);
            this.comboBoxCategoryFilter.TabIndex = 5;
            this.comboBoxCategoryFilter.SelectedIndexChanged += new System.EventHandler(this.OnFilterChanged);
            // 
            // panelRightSide
            // 
            this.panelRightSide.Controls.Add(this.groupBoxInsights);
            this.panelRightSide.Controls.Add(this.panelExport);
            this.panelRightSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightSide.Location = new System.Drawing.Point(0, 0);
            this.panelRightSide.Name = "panelRightSide";
            this.panelRightSide.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelRightSide.Size = new System.Drawing.Size(457, 468);
            this.panelRightSide.TabIndex = 0;
            // 
            // groupBoxInsights
            // 
            this.groupBoxInsights.BackColor = System.Drawing.Color.White;
            this.groupBoxInsights.Controls.Add(this.richTextBoxBusinessInsights);
            this.groupBoxInsights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInsights.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInsights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.groupBoxInsights.Location = new System.Drawing.Point(10, 0);
            this.groupBoxInsights.Name = "groupBoxInsights";
            this.groupBoxInsights.Padding = new System.Windows.Forms.Padding(20, 15, 20, 20);
            this.groupBoxInsights.Size = new System.Drawing.Size(447, 398);
            this.groupBoxInsights.TabIndex = 0;
            this.groupBoxInsights.TabStop = false;
            this.groupBoxInsights.Text = "📊 Business Insights Report";
            // 
            // richTextBoxBusinessInsights
            // 
            this.richTextBoxBusinessInsights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.richTextBoxBusinessInsights.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxBusinessInsights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxBusinessInsights.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxBusinessInsights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.richTextBoxBusinessInsights.Location = new System.Drawing.Point(20, 35);
            this.richTextBoxBusinessInsights.Name = "richTextBoxBusinessInsights";
            this.richTextBoxBusinessInsights.ReadOnly = true;
            this.richTextBoxBusinessInsights.Size = new System.Drawing.Size(407, 343);
            this.richTextBoxBusinessInsights.TabIndex = 0;
            this.richTextBoxBusinessInsights.Text = "📋 Run analysis to see detailed business insights and recommendations...";
            this.richTextBoxBusinessInsights.TextChanged += new System.EventHandler(this.richTextBoxBusinessInsights_TextChanged);
            // 
            // panelExport
            // 
            this.panelExport.BackColor = System.Drawing.Color.White;
            this.panelExport.Controls.Add(this.btnExportReport);
            this.panelExport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelExport.Location = new System.Drawing.Point(10, 398);
            this.panelExport.Name = "panelExport";
            this.panelExport.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelExport.Size = new System.Drawing.Size(447, 70);
            this.panelExport.TabIndex = 1;
            // 
            // btnExportReport
            // 
            this.btnExportReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnExportReport.FlatAppearance.BorderSize = 0;
            this.btnExportReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportReport.ForeColor = System.Drawing.Color.White;
            this.btnExportReport.Location = new System.Drawing.Point(20, 15);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(140, 40);
            this.btnExportReport.TabIndex = 0;
            this.btnExportReport.Text = "📄 Export Report";
            this.btnExportReport.UseVisualStyleBackColor = false;
            this.btnExportReport.Click += new System.EventHandler(this.btnExportReport_Click);
            // 
            // panelStats
            // 
            this.panelStats.Controls.Add(this.panelStat3);
            this.panelStats.Controls.Add(this.panelStat2);
            this.panelStats.Controls.Add(this.panelStat1);
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStats.Location = new System.Drawing.Point(20, 120);
            this.panelStats.Name = "panelStats";
            this.panelStats.Padding = new System.Windows.Forms.Padding(0, 10, 0, 20);
            this.panelStats.Size = new System.Drawing.Size(1081, 120);
            this.panelStats.TabIndex = 1;
            // 
            // panelStat3
            // 
            this.panelStat3.BackColor = System.Drawing.Color.White;
            this.panelStat3.Controls.Add(this.lblPotentialRevenue);
            this.panelStat3.Controls.Add(this.lblStatLabel3);
            this.panelStat3.Location = new System.Drawing.Point(743, 10);
            this.panelStat3.Name = "panelStat3";
            this.panelStat3.Padding = new System.Windows.Forms.Padding(25, 20, 25, 15);
            this.panelStat3.Size = new System.Drawing.Size(338, 90);
            this.panelStat3.TabIndex = 2;
            // 
            // lblPotentialRevenue
            // 
            this.lblPotentialRevenue.AutoSize = true;
            this.lblPotentialRevenue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotentialRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblPotentialRevenue.Location = new System.Drawing.Point(25, 20);
            this.lblPotentialRevenue.Name = "lblPotentialRevenue";
            this.lblPotentialRevenue.Size = new System.Drawing.Size(50, 32);
            this.lblPotentialRevenue.TabIndex = 0;
            this.lblPotentialRevenue.Text = "₱ 0";
            // 
            // lblStatLabel3
            // 
            this.lblStatLabel3.AutoSize = true;
            this.lblStatLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblStatLabel3.Location = new System.Drawing.Point(25, 57);
            this.lblStatLabel3.Name = "lblStatLabel3";
            this.lblStatLabel3.Size = new System.Drawing.Size(179, 19);
            this.lblStatLabel3.TabIndex = 1;
            this.lblStatLabel3.Text = "💰 Monthly Revenue Boost";
            // 
            // panelStat2
            // 
            this.panelStat2.BackColor = System.Drawing.Color.White;
            this.panelStat2.Controls.Add(this.lblHighValue);
            this.panelStat2.Controls.Add(this.lblStatLabel2);
            this.panelStat2.Location = new System.Drawing.Point(370, 10);
            this.panelStat2.Name = "panelStat2";
            this.panelStat2.Padding = new System.Windows.Forms.Padding(25, 20, 25, 15);
            this.panelStat2.Size = new System.Drawing.Size(338, 90);
            this.panelStat2.TabIndex = 1;
            this.panelStat2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelStat2_Paint);
            // 
            // lblHighValue
            // 
            this.lblHighValue.AutoSize = true;
            this.lblHighValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.lblHighValue.Location = new System.Drawing.Point(25, 20);
            this.lblHighValue.Name = "lblHighValue";
            this.lblHighValue.Size = new System.Drawing.Size(33, 37);
            this.lblHighValue.TabIndex = 0;
            this.lblHighValue.Text = "0";
            // 
            // lblStatLabel2
            // 
            this.lblStatLabel2.AutoSize = true;
            this.lblStatLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblStatLabel2.Location = new System.Drawing.Point(25, 57);
            this.lblStatLabel2.Name = "lblStatLabel2";
            this.lblStatLabel2.Size = new System.Drawing.Size(168, 19);
            this.lblStatLabel2.TabIndex = 1;
            this.lblStatLabel2.Text = "🎯 High-Success Combos";
            // 
            // panelStat1
            // 
            this.panelStat1.BackColor = System.Drawing.Color.White;
            this.panelStat1.Controls.Add(this.lblTotalOpportunities);
            this.panelStat1.Controls.Add(this.lblStatLabel1);
            this.panelStat1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStat1.Location = new System.Drawing.Point(0, 10);
            this.panelStat1.Name = "panelStat1";
            this.panelStat1.Padding = new System.Windows.Forms.Padding(25, 20, 25, 15);
            this.panelStat1.Size = new System.Drawing.Size(338, 90);
            this.panelStat1.TabIndex = 0;
            // 
            // lblTotalOpportunities
            // 
            this.lblTotalOpportunities.AutoSize = true;
            this.lblTotalOpportunities.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOpportunities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblTotalOpportunities.Location = new System.Drawing.Point(25, 20);
            this.lblTotalOpportunities.Name = "lblTotalOpportunities";
            this.lblTotalOpportunities.Size = new System.Drawing.Size(33, 37);
            this.lblTotalOpportunities.TabIndex = 0;
            this.lblTotalOpportunities.Text = "0";
            // 
            // lblStatLabel1
            // 
            this.lblStatLabel1.AutoSize = true;
            this.lblStatLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblStatLabel1.Location = new System.Drawing.Point(25, 57);
            this.lblStatLabel1.Name = "lblStatLabel1";
            this.lblStatLabel1.Size = new System.Drawing.Size(194, 19);
            this.lblStatLabel1.TabIndex = 1;
            this.lblStatLabel1.Text = "💡 Sales Opportunities Found";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblLastUpdated);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(20, 20);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(30, 25, 30, 20);
            this.panelHeader.Size = new System.Drawing.Size(1081, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastUpdated.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastUpdated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblLastUpdated.Location = new System.Drawing.Point(700, 45);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(350, 23);
            this.lblLastUpdated.TabIndex = 2;
            this.lblLastUpdated.Text = "Analysis Status: Not Run Yet";
            this.lblLastUpdated.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLastUpdated.TextChanged += new System.EventHandler(this.lblLastUpdated_TextChanged);
            this.lblLastUpdated.Click += new System.EventHandler(this.lblLastUpdated_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblSubtitle.Location = new System.Drawing.Point(38, 70);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(513, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Discover which items customers buy together to boost your sales and profits";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(563, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🛒 Smart Product Bundling Insights";
            // 
            // AprioriAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "AprioriAnalysis";
            this.Size = new System.Drawing.Size(1121, 738);
            this.panelMain.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelLeftSide.ResumeLayout(false);
            this.groupBoxRecommendations.ResumeLayout(false);
            this.panelAnalysisControl.ResumeLayout(false);
            this.panelAnalysisControl.PerformLayout();
            this.groupBoxFilters.ResumeLayout(false);
            this.tableLayoutPanelFilters.ResumeLayout(false);
            this.tableLayoutPanelFilters.PerformLayout();
            this.panelDateRange.ResumeLayout(false);
            this.panelDateRange.PerformLayout();
            this.panelRightSide.ResumeLayout(false);
            this.groupBoxInsights.ResumeLayout(false);
            this.panelExport.ResumeLayout(false);
            this.panelStats.ResumeLayout(false);
            this.panelStat3.ResumeLayout(false);
            this.panelStat3.PerformLayout();
            this.panelStat2.ResumeLayout(false);
            this.panelStat2.PerformLayout();
            this.panelStat1.ResumeLayout(false);
            this.panelStat1.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblLastUpdated;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Panel panelStat1;
        private System.Windows.Forms.Label lblTotalOpportunities;
        private System.Windows.Forms.Label lblStatLabel1;
        private System.Windows.Forms.Panel panelStat2;
        private System.Windows.Forms.Label lblHighValue;
        private System.Windows.Forms.Label lblStatLabel2;
        private System.Windows.Forms.Panel panelStat3;
        private System.Windows.Forms.Label lblPotentialRevenue;
        private System.Windows.Forms.Label lblStatLabel3;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelLeftSide;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFilters;
        private System.Windows.Forms.Label lblDateRange;
        private System.Windows.Forms.Panel panelDateRange;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label lblRecommendationType;
        private System.Windows.Forms.ComboBox comboBoxConfidenceFilter;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.ComboBox comboBoxCategoryFilter;
        private System.Windows.Forms.Panel panelAnalysisControl;
        private System.Windows.Forms.Button btnRunAnalysis;
        private System.Windows.Forms.ProgressBar progressBarAnalysis;
        private System.Windows.Forms.Label lblAnalysisStatus;
        private System.Windows.Forms.GroupBox groupBoxRecommendations;
        private System.Windows.Forms.ListView listViewRecommendations;
        private System.Windows.Forms.ColumnHeader columnRank;
        private System.Windows.Forms.ColumnHeader columnWhenCustomerBuys;
        private System.Windows.Forms.ColumnHeader columnTheyAlsoBuy;
        private System.Windows.Forms.ColumnHeader columnSuccessRate;
        private System.Windows.Forms.ColumnHeader columnRevenueBoost;
        private System.Windows.Forms.ColumnHeader columnActionNeeded;
        private System.Windows.Forms.Panel panelRightSide;
        private System.Windows.Forms.GroupBox groupBoxInsights;
        private System.Windows.Forms.RichTextBox richTextBoxBusinessInsights;
        private System.Windows.Forms.Panel panelExport;
        private System.Windows.Forms.Button btnExportReport;
    }
}