
namespace InterestMaintenanceUI
{
    partial class InterestDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterestDashBoard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            this.interestIns_codeComboBox = new System.Windows.Forms.ComboBox();
            this.interestStatusComboBox = new System.Windows.Forms.ComboBox();
            this.interestStartDateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.interestEndDateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SearchFilterButton = new System.Windows.Forms.Button();
            this.FilterGroupBox = new System.Windows.Forms.GroupBox();
            this.clearFilterData = new System.Windows.Forms.Button();
            this.interestInstrumentLabel = new System.Windows.Forms.Label();
            this.interestStatusLabel = new System.Windows.Forms.Label();
            this.interestStartDateLabel = new System.Windows.Forms.Label();
            this.interestEndDateLabel = new System.Windows.Forms.Label();
            this.newInterestButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.interestDashboardTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.reloadPicBox = new System.Windows.Forms.PictureBox();
            this.interestDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EffectiveDateFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchInterestTextField = new System.Windows.Forms.TextBox();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewDisableButtonColumn1 = new InterestMaintenanceUI.Extensions.DataGridViewDisableButtonColumn();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.approveBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cancelBtn = new InterestMaintenanceUI.Extensions.DataGridViewDisableButtonColumn();
            this.deleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FilterGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reloadPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interestDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // interestIns_codeComboBox
            // 
            this.interestIns_codeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.interestIns_codeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.interestIns_codeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.interestIns_codeComboBox.FormattingEnabled = true;
            this.interestIns_codeComboBox.Location = new System.Drawing.Point(11, 54);
            this.interestIns_codeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.interestIns_codeComboBox.Name = "interestIns_codeComboBox";
            this.interestIns_codeComboBox.Size = new System.Drawing.Size(149, 30);
            this.interestIns_codeComboBox.TabIndex = 2;
            // 
            // interestStatusComboBox
            // 
            this.interestStatusComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.interestStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.interestStatusComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.interestStatusComboBox.FormattingEnabled = true;
            this.interestStatusComboBox.Location = new System.Drawing.Point(11, 114);
            this.interestStatusComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.interestStatusComboBox.Name = "interestStatusComboBox";
            this.interestStatusComboBox.Size = new System.Drawing.Size(149, 30);
            this.interestStatusComboBox.TabIndex = 3;
            // 
            // interestStartDateDatePicker
            // 
            this.interestStartDateDatePicker.CustomFormat = " ";
            this.interestStartDateDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.interestStartDateDatePicker.Location = new System.Drawing.Point(11, 172);
            this.interestStartDateDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.interestStartDateDatePicker.Name = "interestStartDateDatePicker";
            this.interestStartDateDatePicker.Size = new System.Drawing.Size(149, 28);
            this.interestStartDateDatePicker.TabIndex = 4;
            this.interestStartDateDatePicker.ValueChanged += new System.EventHandler(this.interestStartDateDatePicker_ValueChanged);
            // 
            // interestEndDateDatePicker
            // 
            this.interestEndDateDatePicker.CustomFormat = " ";
            this.interestEndDateDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.interestEndDateDatePicker.Location = new System.Drawing.Point(11, 231);
            this.interestEndDateDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.interestEndDateDatePicker.Name = "interestEndDateDatePicker";
            this.interestEndDateDatePicker.Size = new System.Drawing.Size(149, 28);
            this.interestEndDateDatePicker.TabIndex = 5;
            this.interestEndDateDatePicker.ValueChanged += new System.EventHandler(this.interestEndDateDatePicker_ValueChanged);
            // 
            // SearchFilterButton
            // 
            this.SearchFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.SearchFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchFilterButton.ForeColor = System.Drawing.Color.White;
            this.SearchFilterButton.Location = new System.Drawing.Point(11, 270);
            this.SearchFilterButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchFilterButton.Name = "SearchFilterButton";
            this.SearchFilterButton.Size = new System.Drawing.Size(74, 26);
            this.SearchFilterButton.TabIndex = 6;
            this.SearchFilterButton.Text = "Search";
            this.SearchFilterButton.UseVisualStyleBackColor = false;
            this.SearchFilterButton.Click += new System.EventHandler(this.SearchFilterButton_Click);
            // 
            // FilterGroupBox
            // 
            this.FilterGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterGroupBox.Controls.Add(this.clearFilterData);
            this.FilterGroupBox.Controls.Add(this.interestInstrumentLabel);
            this.FilterGroupBox.Controls.Add(this.interestStatusLabel);
            this.FilterGroupBox.Controls.Add(this.interestStartDateLabel);
            this.FilterGroupBox.Controls.Add(this.interestEndDateLabel);
            this.FilterGroupBox.Controls.Add(this.interestIns_codeComboBox);
            this.FilterGroupBox.Controls.Add(this.SearchFilterButton);
            this.FilterGroupBox.Controls.Add(this.interestStatusComboBox);
            this.FilterGroupBox.Controls.Add(this.interestEndDateDatePicker);
            this.FilterGroupBox.Controls.Add(this.interestStartDateDatePicker);
            this.FilterGroupBox.Location = new System.Drawing.Point(812, 8);
            this.FilterGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.FilterGroupBox.Name = "FilterGroupBox";
            this.FilterGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.FilterGroupBox.Size = new System.Drawing.Size(173, 316);
            this.FilterGroupBox.TabIndex = 5;
            this.FilterGroupBox.TabStop = false;
            this.FilterGroupBox.Text = "Filter Interest";
            // 
            // clearFilterData
            // 
            this.clearFilterData.BackColor = System.Drawing.Color.Gainsboro;
            this.clearFilterData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFilterData.Location = new System.Drawing.Point(87, 270);
            this.clearFilterData.Margin = new System.Windows.Forms.Padding(2);
            this.clearFilterData.Name = "clearFilterData";
            this.clearFilterData.Size = new System.Drawing.Size(74, 26);
            this.clearFilterData.TabIndex = 9;
            this.clearFilterData.Text = "Clear";
            this.clearFilterData.UseVisualStyleBackColor = false;
            this.clearFilterData.Click += new System.EventHandler(this.clearFilterData_Click);
            // 
            // interestInstrumentLabel
            // 
            this.interestInstrumentLabel.AutoSize = true;
            this.interestInstrumentLabel.ForeColor = System.Drawing.Color.Black;
            this.interestInstrumentLabel.Location = new System.Drawing.Point(7, 30);
            this.interestInstrumentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.interestInstrumentLabel.Name = "interestInstrumentLabel";
            this.interestInstrumentLabel.Size = new System.Drawing.Size(93, 22);
            this.interestInstrumentLabel.TabIndex = 8;
            this.interestInstrumentLabel.Text = "Instrument";
            // 
            // interestStatusLabel
            // 
            this.interestStatusLabel.AutoSize = true;
            this.interestStatusLabel.BackColor = System.Drawing.Color.White;
            this.interestStatusLabel.ForeColor = System.Drawing.Color.Black;
            this.interestStatusLabel.Location = new System.Drawing.Point(7, 90);
            this.interestStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.interestStatusLabel.Name = "interestStatusLabel";
            this.interestStatusLabel.Size = new System.Drawing.Size(61, 22);
            this.interestStatusLabel.TabIndex = 7;
            this.interestStatusLabel.Text = "Status";
            // 
            // interestStartDateLabel
            // 
            this.interestStartDateLabel.AutoSize = true;
            this.interestStartDateLabel.ForeColor = System.Drawing.Color.Black;
            this.interestStartDateLabel.Location = new System.Drawing.Point(7, 148);
            this.interestStartDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.interestStartDateLabel.Name = "interestStartDateLabel";
            this.interestStartDateLabel.Size = new System.Drawing.Size(91, 22);
            this.interestStartDateLabel.TabIndex = 6;
            this.interestStartDateLabel.Text = "Start Date";
            // 
            // interestEndDateLabel
            // 
            this.interestEndDateLabel.AutoSize = true;
            this.interestEndDateLabel.ForeColor = System.Drawing.Color.Black;
            this.interestEndDateLabel.Location = new System.Drawing.Point(7, 208);
            this.interestEndDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.interestEndDateLabel.Name = "interestEndDateLabel";
            this.interestEndDateLabel.Size = new System.Drawing.Size(90, 22);
            this.interestEndDateLabel.TabIndex = 5;
            this.interestEndDateLabel.Text = "End Date ";
            // 
            // newInterestButton
            // 
            this.newInterestButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.newInterestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newInterestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.newInterestButton.FlatAppearance.BorderSize = 0;
            this.newInterestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newInterestButton.ForeColor = System.Drawing.Color.White;
            this.newInterestButton.Location = new System.Drawing.Point(14, 23);
            this.newInterestButton.Margin = new System.Windows.Forms.Padding(2);
            this.newInterestButton.Name = "newInterestButton";
            this.newInterestButton.Size = new System.Drawing.Size(98, 31);
            this.newInterestButton.TabIndex = 1;
            this.newInterestButton.Text = "New";
            this.newInterestButton.UseVisualStyleBackColor = false;
            this.newInterestButton.Click += new System.EventHandler(this.newInterestButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.interestDashboardTitle);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 105);
            this.panel2.TabIndex = 7;
            // 
            // interestDashboardTitle
            // 
            this.interestDashboardTitle.AutoSize = true;
            this.interestDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestDashboardTitle.Location = new System.Drawing.Point(30, 25);
            this.interestDashboardTitle.Name = "interestDashboardTitle";
            this.interestDashboardTitle.Size = new System.Drawing.Size(288, 54);
            this.interestDashboardTitle.TabIndex = 0;
            this.interestDashboardTitle.Text = "Interest Module";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.searchInterestTextField);
            this.panel3.Controls.Add(this.reloadPicBox);
            this.panel3.Controls.Add(this.interestDataGridView);
            this.panel3.Controls.Add(this.FilterGroupBox);
            this.panel3.Controls.Add(this.newInterestButton);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(24, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(998, 343);
            this.panel3.TabIndex = 8;
            // 
            // reloadPicBox
            // 
            this.reloadPicBox.Image = ((System.Drawing.Image)(resources.GetObject("reloadPicBox.Image")));
            this.reloadPicBox.Location = new System.Drawing.Point(774, 21);
            this.reloadPicBox.Name = "reloadPicBox";
            this.reloadPicBox.Size = new System.Drawing.Size(32, 30);
            this.reloadPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reloadPicBox.TabIndex = 6;
            this.reloadPicBox.TabStop = false;
            this.reloadPicBox.Click += new System.EventHandler(this.reloadPicBox_Click);
            // 
            // interestDataGridView
            // 
            this.interestDataGridView.AllowUserToAddRows = false;
            this.interestDataGridView.AllowUserToDeleteRows = false;
            this.interestDataGridView.AllowUserToResizeColumns = false;
            this.interestDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.Color.Black;
            this.interestDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle41;
            this.interestDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.interestDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.interestDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.interestDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.interestDataGridView.ColumnHeadersHeight = 34;
            this.interestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.interestDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Description,
            this.EffectiveDateFormat,
            this.Status,
            this.editBtn,
            this.approveBtn,
            this.cancelBtn,
            this.deleteBtn});
            this.interestDataGridView.GridColor = System.Drawing.Color.White;
            this.interestDataGridView.Location = new System.Drawing.Point(14, 62);
            this.interestDataGridView.MultiSelect = false;
            this.interestDataGridView.Name = "interestDataGridView";
            this.interestDataGridView.ReadOnly = true;
            this.interestDataGridView.RowHeadersVisible = false;
            this.interestDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle46.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.Color.Black;
            this.interestDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle46;
            this.interestDataGridView.RowTemplate.Height = 28;
            this.interestDataGridView.ShowEditingIcon = false;
            this.interestDataGridView.Size = new System.Drawing.Size(793, 252);
            this.interestDataGridView.TabIndex = 0;
            this.interestDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.interestDataGridView_CellClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 63;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Instrument";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // EffectiveDateFormat
            // 
            this.EffectiveDateFormat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EffectiveDateFormat.DataPropertyName = "EffectiveDateFormat";
            this.EffectiveDateFormat.HeaderText = "Effective Date";
            this.EffectiveDateFormat.MinimumWidth = 8;
            this.EffectiveDateFormat.Name = "EffectiveDateFormat";
            this.EffectiveDateFormat.ReadOnly = true;
            this.EffectiveDateFormat.Width = 158;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 97;
            // 
            // searchInterestTextField
            // 
            this.searchInterestTextField.BackColor = System.Drawing.SystemColors.Window;
            this.searchInterestTextField.ForeColor = System.Drawing.Color.LightGray;
            this.searchInterestTextField.Location = new System.Drawing.Point(371, 24);
            this.searchInterestTextField.Name = "searchInterestTextField";
            this.searchInterestTextField.Size = new System.Drawing.Size(395, 28);
            this.searchInterestTextField.TabIndex = 8;
            this.searchInterestTextField.Text = "Search...";
            this.searchInterestTextField.TextChanged += new System.EventHandler(this.searchInterestTextField_TextChanged);
            this.searchInterestTextField.Enter += new System.EventHandler(this.searchInterestTextField_Enter);
            this.searchInterestTextField.Leave += new System.EventHandler(this.searchInterestTextField_Leave);
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle47;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.MinimumWidth = 8;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "EDIT";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Width = 8;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle48;
            this.dataGridViewButtonColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.MinimumWidth = 8;
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Text = "APPROVE";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn2.Width = 8;
            // 
            // dataGridViewDisableButtonColumn1
            // 
            this.dataGridViewDisableButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle49.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle49.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewDisableButtonColumn1.DefaultCellStyle = dataGridViewCellStyle49;
            this.dataGridViewDisableButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewDisableButtonColumn1.HeaderText = "";
            this.dataGridViewDisableButtonColumn1.MinimumWidth = 8;
            this.dataGridViewDisableButtonColumn1.Name = "dataGridViewDisableButtonColumn1";
            this.dataGridViewDisableButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDisableButtonColumn1.Text = "CANCEL";
            this.dataGridViewDisableButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewDisableButtonColumn1.Width = 8;
            // 
            // dataGridViewButtonColumn3
            // 
            this.dataGridViewButtonColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle50.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle50.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle50.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewButtonColumn3.DefaultCellStyle = dataGridViewCellStyle50;
            this.dataGridViewButtonColumn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn3.HeaderText = "";
            this.dataGridViewButtonColumn3.MinimumWidth = 8;
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            this.dataGridViewButtonColumn3.Text = "DELETE";
            this.dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn3.Width = 8;
            // 
            // editBtn
            // 
            this.editBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.White;
            this.editBtn.DefaultCellStyle = dataGridViewCellStyle42;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.HeaderText = "";
            this.editBtn.MinimumWidth = 8;
            this.editBtn.Name = "editBtn";
            this.editBtn.ReadOnly = true;
            this.editBtn.Text = "EDIT";
            this.editBtn.UseColumnTextForButtonValue = true;
            this.editBtn.Width = 8;
            // 
            // approveBtn
            // 
            this.approveBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.White;
            this.approveBtn.DefaultCellStyle = dataGridViewCellStyle43;
            this.approveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approveBtn.HeaderText = "";
            this.approveBtn.MinimumWidth = 8;
            this.approveBtn.Name = "approveBtn";
            this.approveBtn.ReadOnly = true;
            this.approveBtn.Text = "APPROVE";
            this.approveBtn.UseColumnTextForButtonValue = true;
            this.approveBtn.Width = 8;
            // 
            // cancelBtn
            // 
            this.cancelBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.Color.White;
            this.cancelBtn.DefaultCellStyle = dataGridViewCellStyle44;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.HeaderText = "";
            this.cancelBtn.MinimumWidth = 8;
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.ReadOnly = true;
            this.cancelBtn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.UseColumnTextForButtonValue = true;
            this.cancelBtn.Width = 8;
            // 
            // deleteBtn
            // 
            this.deleteBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.Color.White;
            this.deleteBtn.DefaultCellStyle = dataGridViewCellStyle45;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.HeaderText = "";
            this.deleteBtn.MinimumWidth = 8;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ReadOnly = true;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseColumnTextForButtonValue = true;
            this.deleteBtn.Width = 8;
            // 
            // InterestDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 498);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "InterestDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interest Dashboard";
            this.FilterGroupBox.ResumeLayout(false);
            this.FilterGroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reloadPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interestDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox interestIns_codeComboBox;
        private System.Windows.Forms.ComboBox interestStatusComboBox;
        private System.Windows.Forms.DateTimePicker interestStartDateDatePicker;
        private System.Windows.Forms.DateTimePicker interestEndDateDatePicker;
        private System.Windows.Forms.Button SearchFilterButton;
        private System.Windows.Forms.GroupBox FilterGroupBox;
        private System.Windows.Forms.Label interestInstrumentLabel;
        private System.Windows.Forms.Label interestStatusLabel;
        private System.Windows.Forms.Label interestStartDateLabel;
        private System.Windows.Forms.Label interestEndDateLabel;
        private System.Windows.Forms.Button newInterestButton;
        private System.Windows.Forms.Button clearFilterData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView interestDataGridView;
        private System.Windows.Forms.Label interestDashboardTitle;
        private System.Windows.Forms.PictureBox reloadPicBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffectiveDateFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn editBtn;
        private System.Windows.Forms.DataGridViewButtonColumn approveBtn;
        private Extensions.DataGridViewDisableButtonColumn cancelBtn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteBtn;
        private System.Windows.Forms.TextBox searchInterestTextField;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private Extensions.DataGridViewDisableButtonColumn dataGridViewDisableButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn3;
    }
}

