namespace P3_TanVu_Nguyen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvListWeatherInfo = new DataGridView();
            columnHeaderID = new DataGridViewTextBoxColumn();
            columnHeaderDate = new DataGridViewTextBoxColumn();
            columnHeaderCity = new DataGridViewTextBoxColumn();
            columnHeaderState = new DataGridViewTextBoxColumn();
            columnHeaderTemp = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            btnSortData = new Button();
            btnAnalysis = new Button();
            btnClose = new Button();
            btnRemoveAll = new Button();
            btnEdit = new Button();
            btnLowTemp = new Button();
            btnRemove = new Button();
            btnFind = new Button();
            btnHighTemp = new Button();
            txtSearch = new TextBox();
            gbxAvgTemp = new GroupBox();
            btnAverageChart = new Button();
            lblRRegionOutput = new Label();
            lblWIOutput = new Label();
            lblIAOutput = new Label();
            lblSDOutput = new Label();
            lblNDOutput = new Label();
            lblRegion = new Label();
            lblWI = new Label();
            lblIA = new Label();
            lblSD = new Label();
            lblND = new Label();
            lblMNOutput = new Label();
            lblMN = new Label();
            gbxWeatherInfo = new GroupBox();
            chkWindy = new CheckBox();
            chkRainy = new CheckBox();
            dtpSunset = new DateTimePicker();
            dtpSunrise = new DateTimePicker();
            chkCloudy = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            txtHumidity = new TextBox();
            label1 = new Label();
            btnClear = new Button();
            btnAddInfo = new Button();
            dtpDate = new DateTimePicker();
            txtTemp = new TextBox();
            cbxState = new ComboBox();
            txtCity = new TextBox();
            lblDate = new Label();
            lblTemp = new Label();
            lblState = new Label();
            lblCity = new Label();
            btnIconMoreDetail = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListWeatherInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbxAvgTemp.SuspendLayout();
            gbxWeatherInfo.SuspendLayout();
            SuspendLayout();
            // 
            // dgvListWeatherInfo
            // 
            dgvListWeatherInfo.AllowUserToResizeColumns = false;
            dgvListWeatherInfo.AllowUserToResizeRows = false;
            dgvListWeatherInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListWeatherInfo.Columns.AddRange(new DataGridViewColumn[] { columnHeaderID, columnHeaderDate, columnHeaderCity, columnHeaderState, columnHeaderTemp });
            dgvListWeatherInfo.Location = new Point(12, 351);
            dgvListWeatherInfo.Name = "dgvListWeatherInfo";
            dgvListWeatherInfo.RowTemplate.Height = 25;
            dgvListWeatherInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListWeatherInfo.Size = new Size(418, 209);
            dgvListWeatherInfo.TabIndex = 74;
            // 
            // columnHeaderID
            // 
            columnHeaderID.DataPropertyName = "Id";
            columnHeaderID.HeaderText = "ID";
            columnHeaderID.Name = "columnHeaderID";
            columnHeaderID.ReadOnly = true;
            columnHeaderID.Resizable = DataGridViewTriState.False;
            columnHeaderID.Width = 30;
            // 
            // columnHeaderDate
            // 
            columnHeaderDate.DataPropertyName = "Date";
            columnHeaderDate.HeaderText = "Date";
            columnHeaderDate.Name = "columnHeaderDate";
            columnHeaderDate.Width = 70;
            // 
            // columnHeaderCity
            // 
            columnHeaderCity.DataPropertyName = "City";
            columnHeaderCity.HeaderText = "City";
            columnHeaderCity.Name = "columnHeaderCity";
            columnHeaderCity.Width = 115;
            // 
            // columnHeaderState
            // 
            columnHeaderState.DataPropertyName = "State";
            columnHeaderState.HeaderText = "State";
            columnHeaderState.Name = "columnHeaderState";
            columnHeaderState.Width = 60;
            // 
            // columnHeaderTemp
            // 
            columnHeaderTemp.DataPropertyName = "Temperature";
            columnHeaderTemp.HeaderText = "Temperature";
            columnHeaderTemp.Name = "columnHeaderTemp";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(241, 248);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 69);
            pictureBox1.TabIndex = 76;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // btnSortData
            // 
            btnSortData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSortData.Location = new Point(119, 566);
            btnSortData.Name = "btnSortData";
            btnSortData.Size = new Size(100, 25);
            btnSortData.TabIndex = 6;
            btnSortData.Text = "Sort Data";
            btnSortData.UseVisualStyleBackColor = true;
            // 
            // btnAnalysis
            // 
            btnAnalysis.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAnalysis.Location = new Point(12, 566);
            btnAnalysis.Name = "btnAnalysis";
            btnAnalysis.Size = new Size(100, 25);
            btnAnalysis.TabIndex = 5;
            btnAnalysis.Text = "Analysis";
            btnAnalysis.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(329, 597);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 25);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnRemoveAll
            // 
            btnRemoveAll.Location = new Point(223, 597);
            btnRemoveAll.Name = "btnRemoveAll";
            btnRemoveAll.Size = new Size(100, 25);
            btnRemoveAll.TabIndex = 11;
            btnRemoveAll.Text = "Remove All";
            btnRemoveAll.UseVisualStyleBackColor = true;
            btnRemoveAll.Click += btnRemoveAll_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(329, 566);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 25);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit Record";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnLowTemp
            // 
            btnLowTemp.Location = new Point(117, 597);
            btnLowTemp.Name = "btnLowTemp";
            btnLowTemp.Size = new Size(100, 25);
            btnLowTemp.TabIndex = 10;
            btnLowTemp.Text = "Lowest Temp";
            btnLowTemp.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(223, 566);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(100, 25);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "Remove Record";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(329, 322);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(100, 25);
            btnFind.TabIndex = 4;
            btnFind.Text = "Find Record";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // btnHighTemp
            // 
            btnHighTemp.Location = new Point(12, 597);
            btnHighTemp.Name = "btnHighTemp";
            btnHighTemp.Size = new Size(100, 25);
            btnHighTemp.TabIndex = 9;
            btnHighTemp.Text = "Highest Temp";
            btnHighTemp.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 322);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(311, 23);
            txtSearch.TabIndex = 3;
            // 
            // gbxAvgTemp
            // 
            gbxAvgTemp.Controls.Add(btnAverageChart);
            gbxAvgTemp.Controls.Add(lblRRegionOutput);
            gbxAvgTemp.Controls.Add(lblWIOutput);
            gbxAvgTemp.Controls.Add(lblIAOutput);
            gbxAvgTemp.Controls.Add(lblSDOutput);
            gbxAvgTemp.Controls.Add(lblNDOutput);
            gbxAvgTemp.Controls.Add(lblRegion);
            gbxAvgTemp.Controls.Add(lblWI);
            gbxAvgTemp.Controls.Add(lblIA);
            gbxAvgTemp.Controls.Add(lblSD);
            gbxAvgTemp.Controls.Add(lblND);
            gbxAvgTemp.Controls.Add(lblMNOutput);
            gbxAvgTemp.Controls.Add(lblMN);
            gbxAvgTemp.Location = new Point(241, 12);
            gbxAvgTemp.Name = "gbxAvgTemp";
            gbxAvgTemp.Size = new Size(189, 234);
            gbxAvgTemp.TabIndex = 1;
            gbxAvgTemp.TabStop = false;
            gbxAvgTemp.Text = "Average Temperature";
            gbxAvgTemp.Visible = false;
            // 
            // btnAverageChart
            // 
            btnAverageChart.Location = new Point(54, 202);
            btnAverageChart.Name = "btnAverageChart";
            btnAverageChart.Size = new Size(115, 25);
            btnAverageChart.TabIndex = 0;
            btnAverageChart.Text = "Average Chart";
            btnAverageChart.UseVisualStyleBackColor = true;
            // 
            // lblRRegionOutput
            // 
            lblRRegionOutput.BorderStyle = BorderStyle.FixedSingle;
            lblRRegionOutput.Location = new Point(54, 172);
            lblRRegionOutput.Name = "lblRRegionOutput";
            lblRRegionOutput.Size = new Size(115, 23);
            lblRRegionOutput.TabIndex = 32;
            lblRRegionOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWIOutput
            // 
            lblWIOutput.BorderStyle = BorderStyle.FixedSingle;
            lblWIOutput.Location = new Point(54, 142);
            lblWIOutput.Name = "lblWIOutput";
            lblWIOutput.Size = new Size(115, 23);
            lblWIOutput.TabIndex = 29;
            lblWIOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIAOutput
            // 
            lblIAOutput.BorderStyle = BorderStyle.FixedSingle;
            lblIAOutput.Location = new Point(54, 112);
            lblIAOutput.Name = "lblIAOutput";
            lblIAOutput.Size = new Size(115, 23);
            lblIAOutput.TabIndex = 27;
            lblIAOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSDOutput
            // 
            lblSDOutput.BorderStyle = BorderStyle.FixedSingle;
            lblSDOutput.Location = new Point(54, 82);
            lblSDOutput.Name = "lblSDOutput";
            lblSDOutput.Size = new Size(115, 23);
            lblSDOutput.TabIndex = 25;
            lblSDOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNDOutput
            // 
            lblNDOutput.BorderStyle = BorderStyle.FixedSingle;
            lblNDOutput.Location = new Point(54, 52);
            lblNDOutput.Name = "lblNDOutput";
            lblNDOutput.Size = new Size(115, 23);
            lblNDOutput.TabIndex = 23;
            lblNDOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.Location = new Point(4, 171);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(44, 15);
            lblRegion.TabIndex = 30;
            lblRegion.Text = "Region";
            // 
            // lblWI
            // 
            lblWI.AutoSize = true;
            lblWI.Location = new Point(27, 142);
            lblWI.Name = "lblWI";
            lblWI.Size = new Size(21, 15);
            lblWI.TabIndex = 28;
            lblWI.Text = "WI";
            // 
            // lblIA
            // 
            lblIA.AutoSize = true;
            lblIA.Location = new Point(30, 113);
            lblIA.Name = "lblIA";
            lblIA.Size = new Size(18, 15);
            lblIA.TabIndex = 26;
            lblIA.Text = "IA";
            // 
            // lblSD
            // 
            lblSD.AutoSize = true;
            lblSD.Location = new Point(27, 84);
            lblSD.Name = "lblSD";
            lblSD.Size = new Size(21, 15);
            lblSD.TabIndex = 24;
            lblSD.Text = "SD";
            // 
            // lblND
            // 
            lblND.AutoSize = true;
            lblND.Location = new Point(24, 55);
            lblND.Name = "lblND";
            lblND.Size = new Size(24, 15);
            lblND.TabIndex = 22;
            lblND.Text = "ND";
            // 
            // lblMNOutput
            // 
            lblMNOutput.BorderStyle = BorderStyle.FixedSingle;
            lblMNOutput.Location = new Point(54, 22);
            lblMNOutput.Name = "lblMNOutput";
            lblMNOutput.Size = new Size(115, 23);
            lblMNOutput.TabIndex = 21;
            lblMNOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMN
            // 
            lblMN.AutoSize = true;
            lblMN.Location = new Point(21, 26);
            lblMN.Name = "lblMN";
            lblMN.Size = new Size(27, 15);
            lblMN.TabIndex = 20;
            lblMN.Text = "MN";
            // 
            // gbxWeatherInfo
            // 
            gbxWeatherInfo.Controls.Add(chkWindy);
            gbxWeatherInfo.Controls.Add(chkRainy);
            gbxWeatherInfo.Controls.Add(dtpSunset);
            gbxWeatherInfo.Controls.Add(dtpSunrise);
            gbxWeatherInfo.Controls.Add(chkCloudy);
            gbxWeatherInfo.Controls.Add(label3);
            gbxWeatherInfo.Controls.Add(label2);
            gbxWeatherInfo.Controls.Add(txtHumidity);
            gbxWeatherInfo.Controls.Add(label1);
            gbxWeatherInfo.Controls.Add(btnClear);
            gbxWeatherInfo.Controls.Add(btnAddInfo);
            gbxWeatherInfo.Controls.Add(dtpDate);
            gbxWeatherInfo.Controls.Add(txtTemp);
            gbxWeatherInfo.Controls.Add(cbxState);
            gbxWeatherInfo.Controls.Add(txtCity);
            gbxWeatherInfo.Controls.Add(lblDate);
            gbxWeatherInfo.Controls.Add(lblTemp);
            gbxWeatherInfo.Controls.Add(lblState);
            gbxWeatherInfo.Controls.Add(lblCity);
            gbxWeatherInfo.Location = new Point(12, 12);
            gbxWeatherInfo.Name = "gbxWeatherInfo";
            gbxWeatherInfo.Size = new Size(225, 305);
            gbxWeatherInfo.TabIndex = 0;
            gbxWeatherInfo.TabStop = false;
            gbxWeatherInfo.Text = "Weather Information";
            // 
            // chkWindy
            // 
            chkWindy.AutoSize = true;
            chkWindy.Location = new Point(90, 235);
            chkWindy.Name = "chkWindy";
            chkWindy.Size = new Size(60, 19);
            chkWindy.TabIndex = 9;
            chkWindy.Text = "Windy";
            chkWindy.UseVisualStyleBackColor = true;
            // 
            // chkRainy
            // 
            chkRainy.AutoSize = true;
            chkRainy.Location = new Point(158, 235);
            chkRainy.Name = "chkRainy";
            chkRainy.Size = new Size(55, 19);
            chkRainy.TabIndex = 10;
            chkRainy.Text = "Rainy";
            chkRainy.UseVisualStyleBackColor = true;
            // 
            // dtpSunset
            // 
            dtpSunset.CustomFormat = "hh:mm";
            dtpSunset.Format = DateTimePickerFormat.Time;
            dtpSunset.Location = new Point(92, 199);
            dtpSunset.Name = "dtpSunset";
            dtpSunset.ShowUpDown = true;
            dtpSunset.Size = new Size(115, 23);
            dtpSunset.TabIndex = 7;
            // 
            // dtpSunrise
            // 
            dtpSunrise.CustomFormat = "";
            dtpSunrise.Format = DateTimePickerFormat.Time;
            dtpSunrise.Location = new Point(92, 170);
            dtpSunrise.Name = "dtpSunrise";
            dtpSunrise.ShowUpDown = true;
            dtpSunrise.Size = new Size(115, 23);
            dtpSunrise.TabIndex = 6;
            // 
            // chkCloudy
            // 
            chkCloudy.AutoSize = true;
            chkCloudy.Location = new Point(18, 235);
            chkCloudy.Name = "chkCloudy";
            chkCloudy.Size = new Size(64, 19);
            chkCloudy.TabIndex = 8;
            chkCloudy.Text = "Cloudy";
            chkCloudy.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 203);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 24;
            label3.Text = "Sunset";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 174);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 22;
            label2.Text = "Sunrise";
            // 
            // txtHumidity
            // 
            txtHumidity.Location = new Point(92, 141);
            txtHumidity.Name = "txtHumidity";
            txtHumidity.Size = new Size(115, 23);
            txtHumidity.TabIndex = 5;
            txtHumidity.KeyPress += txtHumidity_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 145);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 20;
            label1.Text = "Humidity (%)";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(114, 259);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 40);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddInfo
            // 
            btnAddInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddInfo.Location = new Point(6, 259);
            btnAddInfo.Name = "btnAddInfo";
            btnAddInfo.Size = new Size(105, 40);
            btnAddInfo.TabIndex = 11;
            btnAddInfo.Text = "Add New";
            btnAddInfo.UseVisualStyleBackColor = true;
            btnAddInfo.Click += btnAddInfo_Click;
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(92, 83);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(115, 23);
            dtpDate.TabIndex = 3;
            // 
            // txtTemp
            // 
            txtTemp.Location = new Point(92, 112);
            txtTemp.Name = "txtTemp";
            txtTemp.Size = new Size(115, 23);
            txtTemp.TabIndex = 4;
            txtTemp.KeyPress += txtTemp_KeyPress;
            // 
            // cbxState
            // 
            cbxState.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxState.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxState.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxState.FormattingEnabled = true;
            cbxState.Items.AddRange(new object[] { "IA", "MN", "ND", "SD", "WI" });
            cbxState.Location = new Point(92, 25);
            cbxState.Name = "cbxState";
            cbxState.Size = new Size(115, 23);
            cbxState.Sorted = true;
            cbxState.TabIndex = 1;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(92, 54);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(115, 23);
            txtCity.TabIndex = 2;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(55, 87);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(31, 15);
            lblDate.TabIndex = 18;
            lblDate.Text = "Date";
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.Location = new Point(15, 116);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(71, 15);
            lblTemp.TabIndex = 17;
            lblTemp.Text = "Temp (in °F)";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new Point(53, 29);
            lblState.Name = "lblState";
            lblState.Size = new Size(33, 15);
            lblState.TabIndex = 16;
            lblState.Text = "State";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(58, 58);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(28, 15);
            lblCity.TabIndex = 15;
            lblCity.Text = "City";
            // 
            // btnIconMoreDetail
            // 
            btnIconMoreDetail.BackgroundImage = Properties.Resources.icon_flat_vector;
            btnIconMoreDetail.BackgroundImageLayout = ImageLayout.Zoom;
            btnIconMoreDetail.Location = new Point(364, 248);
            btnIconMoreDetail.Name = "btnIconMoreDetail";
            btnIconMoreDetail.Size = new Size(65, 69);
            btnIconMoreDetail.TabIndex = 2;
            btnIconMoreDetail.UseVisualStyleBackColor = true;
            btnIconMoreDetail.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(444, 631);
            Controls.Add(btnIconMoreDetail);
            Controls.Add(pictureBox1);
            Controls.Add(btnSortData);
            Controls.Add(dgvListWeatherInfo);
            Controls.Add(btnAnalysis);
            Controls.Add(btnClose);
            Controls.Add(btnRemoveAll);
            Controls.Add(btnEdit);
            Controls.Add(btnLowTemp);
            Controls.Add(btnRemove);
            Controls.Add(btnFind);
            Controls.Add(btnHighTemp);
            Controls.Add(txtSearch);
            Controls.Add(gbxAvgTemp);
            Controls.Add(gbxWeatherInfo);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Weather Analysis Version 2";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListWeatherInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbxAvgTemp.ResumeLayout(false);
            gbxAvgTemp.PerformLayout();
            gbxWeatherInfo.ResumeLayout(false);
            gbxWeatherInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnSortData;
        private DataGridView dgvListWeatherInfo;
        private Button btnAnalysis;
        private Button btnClose;
        private Button btnRemoveAll;
        private Button btnEdit;
        private Button btnLowTemp;
        private Button btnRemove;
        private Button btnFind;
        private Button btnHighTemp;
        private TextBox txtSearch;
        private GroupBox gbxAvgTemp;
        private Button btnAverageChart;
        private Label lblRRegionOutput;
        private Label lblWIOutput;
        private Label lblIAOutput;
        private Label lblSDOutput;
        private Label lblNDOutput;
        private Label lblRegion;
        private Label lblWI;
        private Label lblIA;
        private Label lblSD;
        private Label lblND;
        private Label lblMNOutput;
        private Label lblMN;
        private GroupBox gbxWeatherInfo;
        private CheckBox chkWindy;
        private CheckBox chkRainy;
        private DateTimePicker dtpSunset;
        private DateTimePicker dtpSunrise;
        private CheckBox chkCloudy;
        private Label label3;
        private Label label2;
        private TextBox txtHumidity;
        private Label label1;
        private Button btnClear;
        private Button btnAddInfo;
        private DateTimePicker dtpDate;
        private TextBox txtTemp;
        private ComboBox cbxState;
        private TextBox txtCity;
        private Label lblDate;
        private Label lblTemp;
        private Label lblState;
        private Label lblCity;
        private Button btnIconMoreDetail;
        private DataGridViewTextBoxColumn columnHeaderID;
        private DataGridViewTextBoxColumn columnHeaderDate;
        private DataGridViewTextBoxColumn columnHeaderCity;
        private DataGridViewTextBoxColumn columnHeaderState;
        private DataGridViewTextBoxColumn columnHeaderTemp;
    }
}
