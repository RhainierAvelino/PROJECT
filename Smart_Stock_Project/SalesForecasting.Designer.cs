//SalesForecasting.Designer.cs
namespace Smart_Stock_Project
{
    partial class SalesForecasting
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
            // Dispose of timer and connection when the UserControl is disposed
            refreshTimer?.Stop();
            refreshTimer?.Dispose();
            connect?.Close();
            connect?.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelControls = new System.Windows.Forms.Panel();
            this.btnRunAnalysis = new System.Windows.Forms.Button();
            this.btnRefreshData = new System.Windows.Forms.Button();
            this.btnExportReport = new System.Windows.Forms.Button();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.panelSummaryCards = new System.Windows.Forms.Panel();
            this.cardTotalProducts = new System.Windows.Forms.Panel();
            this.lblTotalProductsTitle = new System.Windows.Forms.Label();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.cardCriticalItems = new System.Windows.Forms.Panel();
            this.lblCriticalItemsTitle = new System.Windows.Forms.Label();
            this.lblCriticalItems = new System.Windows.Forms.Label();
            this.cardReorderItems = new System.Windows.Forms.Panel();
            this.lblReorderItemsTitle = new System.Windows.Forms.Label();
            this.lblReorderItems = new System.Windows.Forms.Label();
            this.cardAccuracy = new System.Windows.Forms.Panel();
            this.lblAvgAccuracyTitle = new System.Windows.Forms.Label();
            this.lblAvgAccuracy = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabForecastResults = new System.Windows.Forms.TabPage();
            this.panelForecastContent = new System.Windows.Forms.Panel();
            this.dgvForecastResults = new System.Windows.Forms.DataGridView();
            this.tabCriticalItems = new System.Windows.Forms.TabPage();
            this.panelCriticalContent = new System.Windows.Forms.Panel();
            this.dgvCriticalItems = new System.Windows.Forms.DataGridView();
            this.panelCriticalHeader = new System.Windows.Forms.Panel();
            this.lblCriticalItemsHeader = new System.Windows.Forms.Label();
            this.lblCriticalDescription = new System.Windows.Forms.Label();
            this.tabReorderRecommendations = new System.Windows.Forms.TabPage();
            this.panelReorderContent = new System.Windows.Forms.Panel();
            this.dgvReorderRecommendations = new System.Windows.Forms.DataGridView();
            this.panelReorderHeader = new System.Windows.Forms.Panel();
            this.lblReorderHeader = new System.Windows.Forms.Label();
            this.lblReorderDescription = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.panelSummaryCards.SuspendLayout();
            this.cardTotalProducts.SuspendLayout();
            this.cardCriticalItems.SuspendLayout();
            this.cardReorderItems.SuspendLayout();
            this.cardAccuracy.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabForecastResults.SuspendLayout();
            this.panelForecastContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForecastResults)).BeginInit();
            this.tabCriticalItems.SuspendLayout();
            this.panelCriticalContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCriticalItems)).BeginInit();
            this.panelCriticalHeader.SuspendLayout();
            this.tabReorderRecommendations.SuspendLayout();
            this.panelReorderContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReorderRecommendations)).BeginInit();
            this.panelReorderHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1121, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(359, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📈 Smart Stock Sales Forecasting";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblSubtitle.Location = new System.Drawing.Point(25, 50);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(460, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Intelligent demand forecasting and inventory optimization for Old Yorkers";
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelControls.Controls.Add(this.btnRunAnalysis);
            this.panelControls.Controls.Add(this.btnRefreshData);
            this.panelControls.Controls.Add(this.btnExportReport);
            this.panelControls.Controls.Add(this.btnClearHistory);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(0, 80);
            this.panelControls.Name = "panelControls";
            this.panelControls.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelControls.Size = new System.Drawing.Size(1121, 70);
            this.panelControls.TabIndex = 1;
            // 
            // btnRunAnalysis
            // 
            this.btnRunAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnRunAnalysis.FlatAppearance.BorderSize = 0;
            this.btnRunAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunAnalysis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRunAnalysis.ForeColor = System.Drawing.Color.White;
            this.btnRunAnalysis.Location = new System.Drawing.Point(20, 15);
            this.btnRunAnalysis.Name = "btnRunAnalysis";
            this.btnRunAnalysis.Size = new System.Drawing.Size(180, 40);
            this.btnRunAnalysis.TabIndex = 0;
            this.btnRunAnalysis.Text = "🔄 Run New Analysis";
            this.btnRunAnalysis.UseVisualStyleBackColor = false;
            this.btnRunAnalysis.Click += new System.EventHandler(this.btnRunAnalysis_Click);
            // 
            // btnRefreshData
            // 
            this.btnRefreshData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRefreshData.FlatAppearance.BorderSize = 0;
            this.btnRefreshData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshData.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefreshData.ForeColor = System.Drawing.Color.White;
            this.btnRefreshData.Location = new System.Drawing.Point(220, 15);
            this.btnRefreshData.Name = "btnRefreshData";
            this.btnRefreshData.Size = new System.Drawing.Size(140, 40);
            this.btnRefreshData.TabIndex = 1;
            this.btnRefreshData.Text = "↻ Refresh Data";
            this.btnRefreshData.UseVisualStyleBackColor = false;
            this.btnRefreshData.Click += new System.EventHandler(this.btnRefreshData_Click);
            // 
            // btnExportReport
            // 
            this.btnExportReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnExportReport.FlatAppearance.BorderSize = 0;
            this.btnExportReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExportReport.ForeColor = System.Drawing.Color.White;
            this.btnExportReport.Location = new System.Drawing.Point(380, 15);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(160, 40);
            this.btnExportReport.TabIndex = 2;
            this.btnExportReport.Text = "📊 Export Report";
            this.btnExportReport.UseVisualStyleBackColor = false;
            this.btnExportReport.Click += new System.EventHandler(this.btnExportReport_Click);
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClearHistory.FlatAppearance.BorderSize = 0;
            this.btnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClearHistory.ForeColor = System.Drawing.Color.White;
            this.btnClearHistory.Location = new System.Drawing.Point(560, 15);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(140, 40);
            this.btnClearHistory.TabIndex = 3;
            this.btnClearHistory.Text = "🗑️ Clear History";
            this.btnClearHistory.UseVisualStyleBackColor = false;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.White;
            this.panelStatus.Controls.Add(this.lblStatus);
            this.panelStatus.Controls.Add(this.progressBar);
            this.panelStatus.Controls.Add(this.lblLastUpdated);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Location = new System.Drawing.Point(0, 150);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelStatus.Size = new System.Drawing.Size(1121, 70);
            this.panelStatus.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblStatus.Location = new System.Drawing.Point(20, 15);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(136, 20);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Ready for analysis";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(20, 40);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(400, 8);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 1;
            this.progressBar.Visible = false;
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastUpdated.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLastUpdated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblLastUpdated.Location = new System.Drawing.Point(723, 15);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(380, 19);
            this.lblLastUpdated.TabIndex = 2;
            this.lblLastUpdated.Text = "No analysis performed yet";
            this.lblLastUpdated.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblLastUpdated.Click += new System.EventHandler(this.lblLastUpdated_Click);
            // 
            // panelSummaryCards
            // 
            this.panelSummaryCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelSummaryCards.Controls.Add(this.cardTotalProducts);
            this.panelSummaryCards.Controls.Add(this.cardCriticalItems);
            this.panelSummaryCards.Controls.Add(this.cardReorderItems);
            this.panelSummaryCards.Controls.Add(this.cardAccuracy);
            this.panelSummaryCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSummaryCards.Location = new System.Drawing.Point(0, 220);
            this.panelSummaryCards.Name = "panelSummaryCards";
            this.panelSummaryCards.Padding = new System.Windows.Forms.Padding(20);
            this.panelSummaryCards.Size = new System.Drawing.Size(1121, 120);
            this.panelSummaryCards.TabIndex = 3;
            // 
            // cardTotalProducts
            // 
            this.cardTotalProducts.BackColor = System.Drawing.Color.White;
            this.cardTotalProducts.Controls.Add(this.lblTotalProductsTitle);
            this.cardTotalProducts.Controls.Add(this.lblTotalProducts);
            this.cardTotalProducts.Location = new System.Drawing.Point(20, 20);
            this.cardTotalProducts.Name = "cardTotalProducts";
            this.cardTotalProducts.Size = new System.Drawing.Size(260, 80);
            this.cardTotalProducts.TabIndex = 0;
            // 
            // lblTotalProductsTitle
            // 
            this.lblTotalProductsTitle.AutoSize = true;
            this.lblTotalProductsTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalProductsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblTotalProductsTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTotalProductsTitle.Name = "lblTotalProductsTitle";
            this.lblTotalProductsTitle.Size = new System.Drawing.Size(105, 15);
            this.lblTotalProductsTitle.TabIndex = 0;
            this.lblTotalProductsTitle.Text = "Products Analyzed";
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.AutoSize = true;
            this.lblTotalProducts.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblTotalProducts.Location = new System.Drawing.Point(15, 35);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(28, 32);
            this.lblTotalProducts.TabIndex = 1;
            this.lblTotalProducts.Text = "0";
            // 
            // cardCriticalItems
            // 
            this.cardCriticalItems.BackColor = System.Drawing.Color.White;
            this.cardCriticalItems.Controls.Add(this.lblCriticalItemsTitle);
            this.cardCriticalItems.Controls.Add(this.lblCriticalItems);
            this.cardCriticalItems.Location = new System.Drawing.Point(290, 20);
            this.cardCriticalItems.Name = "cardCriticalItems";
            this.cardCriticalItems.Size = new System.Drawing.Size(260, 80);
            this.cardCriticalItems.TabIndex = 1;
            // 
            // lblCriticalItemsTitle
            // 
            this.lblCriticalItemsTitle.AutoSize = true;
            this.lblCriticalItemsTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCriticalItemsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblCriticalItemsTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCriticalItemsTitle.Name = "lblCriticalItemsTitle";
            this.lblCriticalItemsTitle.Size = new System.Drawing.Size(76, 15);
            this.lblCriticalItemsTitle.TabIndex = 0;
            this.lblCriticalItemsTitle.Text = "Critical Items";
            // 
            // lblCriticalItems
            // 
            this.lblCriticalItems.AutoSize = true;
            this.lblCriticalItems.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCriticalItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblCriticalItems.Location = new System.Drawing.Point(15, 35);
            this.lblCriticalItems.Name = "lblCriticalItems";
            this.lblCriticalItems.Size = new System.Drawing.Size(28, 32);
            this.lblCriticalItems.TabIndex = 1;
            this.lblCriticalItems.Text = "0";
            // 
            // cardReorderItems
            // 
            this.cardReorderItems.BackColor = System.Drawing.Color.White;
            this.cardReorderItems.Controls.Add(this.lblReorderItemsTitle);
            this.cardReorderItems.Controls.Add(this.lblReorderItems);
            this.cardReorderItems.Location = new System.Drawing.Point(560, 20);
            this.cardReorderItems.Name = "cardReorderItems";
            this.cardReorderItems.Size = new System.Drawing.Size(260, 80);
            this.cardReorderItems.TabIndex = 2;
            // 
            // lblReorderItemsTitle
            // 
            this.lblReorderItemsTitle.AutoSize = true;
            this.lblReorderItemsTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblReorderItemsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblReorderItemsTitle.Location = new System.Drawing.Point(15, 15);
            this.lblReorderItemsTitle.Name = "lblReorderItemsTitle";
            this.lblReorderItemsTitle.Size = new System.Drawing.Size(92, 15);
            this.lblReorderItemsTitle.TabIndex = 0;
            this.lblReorderItemsTitle.Text = "Reorder Needed";
            // 
            // lblReorderItems
            // 
            this.lblReorderItems.AutoSize = true;
            this.lblReorderItems.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblReorderItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblReorderItems.Location = new System.Drawing.Point(15, 35);
            this.lblReorderItems.Name = "lblReorderItems";
            this.lblReorderItems.Size = new System.Drawing.Size(28, 32);
            this.lblReorderItems.TabIndex = 1;
            this.lblReorderItems.Text = "0";
            // 
            // cardAccuracy
            // 
            this.cardAccuracy.BackColor = System.Drawing.Color.White;
            this.cardAccuracy.Controls.Add(this.lblAvgAccuracyTitle);
            this.cardAccuracy.Controls.Add(this.lblAvgAccuracy);
            this.cardAccuracy.Location = new System.Drawing.Point(830, 20);
            this.cardAccuracy.Name = "cardAccuracy";
            this.cardAccuracy.Size = new System.Drawing.Size(260, 80);
            this.cardAccuracy.TabIndex = 3;
            // 
            // lblAvgAccuracyTitle
            // 
            this.lblAvgAccuracyTitle.AutoSize = true;
            this.lblAvgAccuracyTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAvgAccuracyTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblAvgAccuracyTitle.Location = new System.Drawing.Point(15, 15);
            this.lblAvgAccuracyTitle.Name = "lblAvgAccuracyTitle";
            this.lblAvgAccuracyTitle.Size = new System.Drawing.Size(102, 15);
            this.lblAvgAccuracyTitle.TabIndex = 0;
            this.lblAvgAccuracyTitle.Text = "Average Accuracy";
            // 
            // lblAvgAccuracy
            // 
            this.lblAvgAccuracy.AutoSize = true;
            this.lblAvgAccuracy.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblAvgAccuracy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblAvgAccuracy.Location = new System.Drawing.Point(15, 35);
            this.lblAvgAccuracy.Name = "lblAvgAccuracy";
            this.lblAvgAccuracy.Size = new System.Drawing.Size(70, 32);
            this.lblAvgAccuracy.TabIndex = 1;
            this.lblAvgAccuracy.Text = "0.0%";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabForecastResults);
            this.tabControlMain.Controls.Add(this.tabCriticalItems);
            this.tabControlMain.Controls.Add(this.tabReorderRecommendations);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tabControlMain.Location = new System.Drawing.Point(0, 340);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1121, 398);
            this.tabControlMain.TabIndex = 4;
            // 
            // tabForecastResults
            // 
            this.tabForecastResults.Controls.Add(this.panelForecastContent);
            this.tabForecastResults.Location = new System.Drawing.Point(4, 24);
            this.tabForecastResults.Name = "tabForecastResults";
            this.tabForecastResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabForecastResults.Size = new System.Drawing.Size(1113, 370);
            this.tabForecastResults.TabIndex = 0;
            this.tabForecastResults.Text = "All Forecast Results";
            this.tabForecastResults.UseVisualStyleBackColor = true;
            // 
            // panelForecastContent
            // 
            this.panelForecastContent.Controls.Add(this.dgvForecastResults);
            this.panelForecastContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForecastContent.Location = new System.Drawing.Point(3, 3);
            this.panelForecastContent.Name = "panelForecastContent";
            this.panelForecastContent.Size = new System.Drawing.Size(1107, 364);
            this.panelForecastContent.TabIndex = 1;
            // 
            // dgvForecastResults
            // 
            this.dgvForecastResults.AllowUserToAddRows = false;
            this.dgvForecastResults.AllowUserToDeleteRows = false;
            this.dgvForecastResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvForecastResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvForecastResults.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvForecastResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvForecastResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvForecastResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvForecastResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForecastResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvForecastResults.EnableHeadersVisualStyles = false;
            this.dgvForecastResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.dgvForecastResults.Location = new System.Drawing.Point(0, 0);
            this.dgvForecastResults.Name = "dgvForecastResults";
            this.dgvForecastResults.ReadOnly = true;
            this.dgvForecastResults.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgvForecastResults.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvForecastResults.RowTemplate.Height = 25;
            this.dgvForecastResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvForecastResults.Size = new System.Drawing.Size(1107, 364);
            this.dgvForecastResults.TabIndex = 0;
            // 
            // tabCriticalItems
            // 
            this.tabCriticalItems.Controls.Add(this.panelCriticalContent);
            this.tabCriticalItems.Controls.Add(this.panelCriticalHeader);
            this.tabCriticalItems.Location = new System.Drawing.Point(4, 24);
            this.tabCriticalItems.Name = "tabCriticalItems";
            this.tabCriticalItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabCriticalItems.Size = new System.Drawing.Size(1113, 370);
            this.tabCriticalItems.TabIndex = 1;
            this.tabCriticalItems.Text = "Critical Items";
            this.tabCriticalItems.UseVisualStyleBackColor = true;
            // 
            // panelCriticalContent
            // 
            this.panelCriticalContent.Controls.Add(this.dgvCriticalItems);
            this.panelCriticalContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCriticalContent.Location = new System.Drawing.Point(3, 63);
            this.panelCriticalContent.Name = "panelCriticalContent";
            this.panelCriticalContent.Size = new System.Drawing.Size(1107, 304);
            this.panelCriticalContent.TabIndex = 2;
            // 
            // dgvCriticalItems
            // 
            this.dgvCriticalItems.AllowUserToAddRows = false;
            this.dgvCriticalItems.AllowUserToDeleteRows = false;
            this.dgvCriticalItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCriticalItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCriticalItems.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCriticalItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCriticalItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCriticalItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCriticalItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCriticalItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCriticalItems.EnableHeadersVisualStyles = false;
            this.dgvCriticalItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.dgvCriticalItems.Location = new System.Drawing.Point(0, 0);
            this.dgvCriticalItems.Name = "dgvCriticalItems";
            this.dgvCriticalItems.ReadOnly = true;
            this.dgvCriticalItems.RowHeadersVisible = false;
            this.dgvCriticalItems.RowTemplate.Height = 25;
            this.dgvCriticalItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCriticalItems.Size = new System.Drawing.Size(1107, 304);
            this.dgvCriticalItems.TabIndex = 0;
            this.dgvCriticalItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCriticalItems_CellContentClick);
            // 
            // panelCriticalHeader
            // 
            this.panelCriticalHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelCriticalHeader.Controls.Add(this.lblCriticalItemsHeader);
            this.panelCriticalHeader.Controls.Add(this.lblCriticalDescription);
            this.panelCriticalHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCriticalHeader.Location = new System.Drawing.Point(3, 3);
            this.panelCriticalHeader.Name = "panelCriticalHeader";
            this.panelCriticalHeader.Padding = new System.Windows.Forms.Padding(10);
            this.panelCriticalHeader.Size = new System.Drawing.Size(1107, 60);
            this.panelCriticalHeader.TabIndex = 1;
            // 
            // lblCriticalItemsHeader
            // 
            this.lblCriticalItemsHeader.AutoSize = true;
            this.lblCriticalItemsHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCriticalItemsHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblCriticalItemsHeader.Location = new System.Drawing.Point(10, 10);
            this.lblCriticalItemsHeader.Name = "lblCriticalItemsHeader";
            this.lblCriticalItemsHeader.Size = new System.Drawing.Size(185, 21);
            this.lblCriticalItemsHeader.TabIndex = 0;
            this.lblCriticalItemsHeader.Text = "⚠️ Critical Stock Alerts";
            // 
            // lblCriticalDescription
            // 
            this.lblCriticalDescription.AutoSize = true;
            this.lblCriticalDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCriticalDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblCriticalDescription.Location = new System.Drawing.Point(10, 35);
            this.lblCriticalDescription.Name = "lblCriticalDescription";
            this.lblCriticalDescription.Size = new System.Drawing.Size(380, 15);
            this.lblCriticalDescription.TabIndex = 1;
            this.lblCriticalDescription.Text = "These items are at critical stock levels and require immediate attention.";
            // 
            // tabReorderRecommendations
            // 
            this.tabReorderRecommendations.Controls.Add(this.panelReorderContent);
            this.tabReorderRecommendations.Controls.Add(this.panelReorderHeader);
            this.tabReorderRecommendations.Location = new System.Drawing.Point(4, 24);
            this.tabReorderRecommendations.Name = "tabReorderRecommendations";
            this.tabReorderRecommendations.Padding = new System.Windows.Forms.Padding(3);
            this.tabReorderRecommendations.Size = new System.Drawing.Size(1113, 370);
            this.tabReorderRecommendations.TabIndex = 2;
            this.tabReorderRecommendations.Text = "Reorder Recommendations";
            this.tabReorderRecommendations.UseVisualStyleBackColor = true;
            // 
            // panelReorderContent
            // 
            this.panelReorderContent.Controls.Add(this.dgvReorderRecommendations);
            this.panelReorderContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReorderContent.Location = new System.Drawing.Point(3, 63);
            this.panelReorderContent.Name = "panelReorderContent";
            this.panelReorderContent.Size = new System.Drawing.Size(1107, 304);
            this.panelReorderContent.TabIndex = 2;
            // 
            // dgvReorderRecommendations
            // 
            this.dgvReorderRecommendations.AllowUserToAddRows = false;
            this.dgvReorderRecommendations.AllowUserToDeleteRows = false;
            this.dgvReorderRecommendations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReorderRecommendations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReorderRecommendations.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvReorderRecommendations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReorderRecommendations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvReorderRecommendations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReorderRecommendations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReorderRecommendations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReorderRecommendations.EnableHeadersVisualStyles = false;
            this.dgvReorderRecommendations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.dgvReorderRecommendations.Location = new System.Drawing.Point(0, 0);
            this.dgvReorderRecommendations.Name = "dgvReorderRecommendations";
            this.dgvReorderRecommendations.ReadOnly = true;
            this.dgvReorderRecommendations.RowHeadersVisible = false;
            this.dgvReorderRecommendations.RowTemplate.Height = 25;
            this.dgvReorderRecommendations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReorderRecommendations.Size = new System.Drawing.Size(1107, 304);
            this.dgvReorderRecommendations.TabIndex = 0;
            // 
            // panelReorderHeader
            // 
            this.panelReorderHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.panelReorderHeader.Controls.Add(this.lblReorderHeader);
            this.panelReorderHeader.Controls.Add(this.lblReorderDescription);
            this.panelReorderHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReorderHeader.Location = new System.Drawing.Point(3, 3);
            this.panelReorderHeader.Name = "panelReorderHeader";
            this.panelReorderHeader.Padding = new System.Windows.Forms.Padding(10);
            this.panelReorderHeader.Size = new System.Drawing.Size(1107, 60);
            this.panelReorderHeader.TabIndex = 1;
            // 
            // lblReorderHeader
            // 
            this.lblReorderHeader.AutoSize = true;
            this.lblReorderHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblReorderHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblReorderHeader.Location = new System.Drawing.Point(10, 10);
            this.lblReorderHeader.Name = "lblReorderHeader";
            this.lblReorderHeader.Size = new System.Drawing.Size(244, 21);
            this.lblReorderHeader.TabIndex = 0;
            this.lblReorderHeader.Text = "📦 Reorder Recommendations";
            // 
            // lblReorderDescription
            // 
            this.lblReorderDescription.AutoSize = true;
            this.lblReorderDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblReorderDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblReorderDescription.Location = new System.Drawing.Point(10, 35);
            this.lblReorderDescription.Name = "lblReorderDescription";
            this.lblReorderDescription.Size = new System.Drawing.Size(415, 15);
            this.lblReorderDescription.TabIndex = 1;
            this.lblReorderDescription.Text = "These items are below their reorder point or identified as high/critical priority" +
    ".";
            // 
            // SalesForecasting
            // 
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panelSummaryCards);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panelHeader);
            this.Name = "SalesForecasting";
            this.Size = new System.Drawing.Size(1121, 738);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelControls.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.panelSummaryCards.ResumeLayout(false);
            this.cardTotalProducts.ResumeLayout(false);
            this.cardTotalProducts.PerformLayout();
            this.cardCriticalItems.ResumeLayout(false);
            this.cardCriticalItems.PerformLayout();
            this.cardReorderItems.ResumeLayout(false);
            this.cardReorderItems.PerformLayout();
            this.cardAccuracy.ResumeLayout(false);
            this.cardAccuracy.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabForecastResults.ResumeLayout(false);
            this.panelForecastContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvForecastResults)).EndInit();
            this.tabCriticalItems.ResumeLayout(false);
            this.panelCriticalContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCriticalItems)).EndInit();
            this.panelCriticalHeader.ResumeLayout(false);
            this.panelCriticalHeader.PerformLayout();
            this.tabReorderRecommendations.ResumeLayout(false);
            this.panelReorderContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReorderRecommendations)).EndInit();
            this.panelReorderHeader.ResumeLayout(false);
            this.panelReorderHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button btnRunAnalysis;
        private System.Windows.Forms.Button btnRefreshData;
        private System.Windows.Forms.Button btnExportReport;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblLastUpdated;
        private System.Windows.Forms.Panel panelSummaryCards;
        private System.Windows.Forms.Panel cardTotalProducts;
        private System.Windows.Forms.Label lblTotalProductsTitle;
        private System.Windows.Forms.Label lblTotalProducts;
        private System.Windows.Forms.Panel cardCriticalItems;
        private System.Windows.Forms.Label lblCriticalItemsTitle;
        private System.Windows.Forms.Label lblCriticalItems;
        private System.Windows.Forms.Panel cardReorderItems;
        private System.Windows.Forms.Label lblReorderItemsTitle;
        private System.Windows.Forms.Label lblReorderItems;
        private System.Windows.Forms.Panel cardAccuracy;
        private System.Windows.Forms.Label lblAvgAccuracyTitle;
        private System.Windows.Forms.Label lblAvgAccuracy;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabForecastResults;
        private System.Windows.Forms.DataGridView dgvForecastResults;
        private System.Windows.Forms.TabPage tabCriticalItems;
        private System.Windows.Forms.Panel panelCriticalHeader;
        private System.Windows.Forms.Label lblCriticalItemsHeader;
        private System.Windows.Forms.Label lblCriticalDescription;
        private System.Windows.Forms.DataGridView dgvCriticalItems;
        private System.Windows.Forms.TabPage tabReorderRecommendations;
        private System.Windows.Forms.Panel panelReorderHeader;
        private System.Windows.Forms.Label lblReorderHeader;
        private System.Windows.Forms.Label lblReorderDescription;
        private System.Windows.Forms.DataGridView dgvReorderRecommendations;
        private System.Windows.Forms.Panel panelForecastContent;
        private System.Windows.Forms.Panel panelCriticalContent;
        private System.Windows.Forms.Panel panelReorderContent;
    }
}