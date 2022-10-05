
namespace InterestMaintenanceUI
{
    partial class InterestRecordForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.interestHeaderLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.effectiveDatePicker = new System.Windows.Forms.DateTimePicker();
            this.effectiveDateLabel = new System.Windows.Forms.Label();
            this.interestRateSelector = new System.Windows.Forms.NumericUpDown();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.interestSaveButton = new System.Windows.Forms.Button();
            this.instrumentComboBox = new System.Windows.Forms.ComboBox();
            this.instrumentlabel = new System.Windows.Forms.Label();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.restoreDataButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interestRateSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.interestHeaderLabel);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 84);
            this.panel1.TabIndex = 0;
            // 
            // interestHeaderLabel
            // 
            this.interestHeaderLabel.AutoSize = true;
            this.interestHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.interestHeaderLabel.Location = new System.Drawing.Point(27, 30);
            this.interestHeaderLabel.Name = "interestHeaderLabel";
            this.interestHeaderLabel.Size = new System.Drawing.Size(84, 26);
            this.interestHeaderLabel.TabIndex = 0;
            this.interestHeaderLabel.Text = "Interest";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.restoreDataButton);
            this.panel2.Controls.Add(this.errorMessageLabel);
            this.panel2.Controls.Add(this.statusLabel);
            this.panel2.Controls.Add(this.effectiveDatePicker);
            this.panel2.Controls.Add(this.effectiveDateLabel);
            this.panel2.Controls.Add(this.interestRateSelector);
            this.panel2.Controls.Add(this.interestRateLabel);
            this.panel2.Controls.Add(this.interestSaveButton);
            this.panel2.Controls.Add(this.instrumentComboBox);
            this.panel2.Controls.Add(this.instrumentlabel);
            this.panel2.Location = new System.Drawing.Point(29, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 466);
            this.panel2.TabIndex = 0;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(29, 240);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 20);
            this.statusLabel.TabIndex = 6;
            // 
            // effectiveDatePicker
            // 
            this.effectiveDatePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.effectiveDatePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.effectiveDatePicker.CalendarTitleForeColor = System.Drawing.Color.White;
            this.effectiveDatePicker.CustomFormat = " ";
            this.effectiveDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.effectiveDatePicker.Location = new System.Drawing.Point(32, 324);
            this.effectiveDatePicker.Name = "effectiveDatePicker";
            this.effectiveDatePicker.Size = new System.Drawing.Size(247, 26);
            this.effectiveDatePicker.TabIndex = 3;
            this.effectiveDatePicker.ValueChanged += new System.EventHandler(this.effectiveDatePicker_ValueChanged);
            // 
            // effectiveDateLabel
            // 
            this.effectiveDateLabel.AutoSize = true;
            this.effectiveDateLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.effectiveDateLabel.Location = new System.Drawing.Point(27, 279);
            this.effectiveDateLabel.Name = "effectiveDateLabel";
            this.effectiveDateLabel.Size = new System.Drawing.Size(146, 30);
            this.effectiveDateLabel.TabIndex = 5;
            this.effectiveDateLabel.Text = "Effective Date";
            // 
            // interestRateSelector
            // 
            this.interestRateSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.interestRateSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.interestRateSelector.DecimalPlaces = 2;
            this.interestRateSelector.ForeColor = System.Drawing.Color.White;
            this.interestRateSelector.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.interestRateSelector.Location = new System.Drawing.Point(31, 170);
            this.interestRateSelector.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.interestRateSelector.Name = "interestRateSelector";
            this.interestRateSelector.Size = new System.Drawing.Size(248, 26);
            this.interestRateSelector.TabIndex = 2;
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.AutoSize = true;
            this.interestRateLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.interestRateLabel.Location = new System.Drawing.Point(27, 125);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(135, 30);
            this.interestRateLabel.TabIndex = 3;
            this.interestRateLabel.Text = "Interest Rate";
            // 
            // interestSaveButton
            // 
            this.interestSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.interestSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.interestSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.interestSaveButton.ForeColor = System.Drawing.Color.White;
            this.interestSaveButton.Location = new System.Drawing.Point(31, 410);
            this.interestSaveButton.Name = "interestSaveButton";
            this.interestSaveButton.Size = new System.Drawing.Size(131, 39);
            this.interestSaveButton.TabIndex = 2;
            this.interestSaveButton.Text = "SAVE";
            this.interestSaveButton.UseVisualStyleBackColor = false;
            this.interestSaveButton.Click += new System.EventHandler(this.interestSaveButton_Click);
            // 
            // instrumentComboBox
            // 
            this.instrumentComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.instrumentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instrumentComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instrumentComboBox.ForeColor = System.Drawing.Color.White;
            this.instrumentComboBox.FormattingEnabled = true;
            this.instrumentComboBox.Location = new System.Drawing.Point(31, 60);
            this.instrumentComboBox.Name = "instrumentComboBox";
            this.instrumentComboBox.Size = new System.Drawing.Size(248, 28);
            this.instrumentComboBox.TabIndex = 1;
            // 
            // instrumentlabel
            // 
            this.instrumentlabel.AutoSize = true;
            this.instrumentlabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.instrumentlabel.Location = new System.Drawing.Point(27, 25);
            this.instrumentlabel.Name = "instrumentlabel";
            this.instrumentlabel.Size = new System.Drawing.Size(117, 30);
            this.instrumentlabel.TabIndex = 0;
            this.instrumentlabel.Text = "Instrument";
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.errorMessageLabel.Location = new System.Drawing.Point(31, 370);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(52, 20);
            this.errorMessageLabel.TabIndex = 7;
            this.errorMessageLabel.Text = "Errors";
            // 
            // restoreDataButton
            // 
            this.restoreDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreDataButton.BackColor = System.Drawing.Color.Silver;
            this.restoreDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreDataButton.ForeColor = System.Drawing.Color.White;
            this.restoreDataButton.Location = new System.Drawing.Point(168, 410);
            this.restoreDataButton.Name = "restoreDataButton";
            this.restoreDataButton.Size = new System.Drawing.Size(131, 39);
            this.restoreDataButton.TabIndex = 8;
            this.restoreDataButton.Text = "RESTORE";
            this.restoreDataButton.UseVisualStyleBackColor = false;
            this.restoreDataButton.Click += new System.EventHandler(this.restoreDataButton_Click);
            // 
            // InterestRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 602);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InterestRecordForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interest";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interestRateSelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown interestRateSelector;
        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.Button interestSaveButton;
        private System.Windows.Forms.ComboBox instrumentComboBox;
        private System.Windows.Forms.Label instrumentlabel;
        private System.Windows.Forms.Label effectiveDateLabel;
        private System.Windows.Forms.DateTimePicker effectiveDatePicker;
        private System.Windows.Forms.Label interestHeaderLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Button restoreDataButton;
    }
}