using System.Windows.Forms;

namespace DownloadManager
{
	partial class DownloadManagerForm
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
			this.PGroupBox = new System.Windows.Forms.GroupBox();
			this.PDLabel = new System.Windows.Forms.Label();
			this.PSLabel = new System.Windows.Forms.Label();
			this.PCancelButton = new System.Windows.Forms.Button();
			this.PStartButton = new System.Windows.Forms.Button();
			this.PDestinationButton = new System.Windows.Forms.Button();
			this.PSourceButton = new System.Windows.Forms.Button();
			this.PDestinationTextBox = new System.Windows.Forms.TextBox();
			this.PSourceTextBox = new System.Windows.Forms.TextBox();
			this.PDataGridView = new System.Windows.Forms.DataGridView();
			this.FileColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.SDLabel = new System.Windows.Forms.Label();
			this.SSLabel = new System.Windows.Forms.Label();
			this.SCancelButton = new System.Windows.Forms.Button();
			this.SStartButton = new System.Windows.Forms.Button();
			this.SDestinationButton = new System.Windows.Forms.Button();
			this.SSourceButton = new System.Windows.Forms.Button();
			this.SDestinationTextBox = new System.Windows.Forms.TextBox();
			this.SSourceTextBox = new System.Windows.Forms.TextBox();
			this.SDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PDataGridView)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// PGroupBox
			// 
			this.PGroupBox.Controls.Add(this.PDLabel);
			this.PGroupBox.Controls.Add(this.PSLabel);
			this.PGroupBox.Controls.Add(this.PCancelButton);
			this.PGroupBox.Controls.Add(this.PStartButton);
			this.PGroupBox.Controls.Add(this.PDestinationButton);
			this.PGroupBox.Controls.Add(this.PSourceButton);
			this.PGroupBox.Controls.Add(this.PDestinationTextBox);
			this.PGroupBox.Controls.Add(this.PSourceTextBox);
			this.PGroupBox.Controls.Add(this.PDataGridView);
			this.PGroupBox.Location = new System.Drawing.Point(12, 12);
			this.PGroupBox.Name = "PGroupBox";
			this.PGroupBox.Size = new System.Drawing.Size(657, 687);
			this.PGroupBox.TabIndex = 0;
			this.PGroupBox.TabStop = false;
			this.PGroupBox.Text = "Queue with parallel processing";
			// 
			// PDLabel
			// 
			this.PDLabel.AutoSize = true;
			this.PDLabel.Location = new System.Drawing.Point(31, 169);
			this.PDLabel.Name = "PDLabel";
			this.PDLabel.Size = new System.Drawing.Size(135, 17);
			this.PDLabel.TabIndex = 8;
			this.PDLabel.Text = "Destination Directiry";
			// 
			// PSLabel
			// 
			this.PSLabel.AutoSize = true;
			this.PSLabel.Location = new System.Drawing.Point(31, 127);
			this.PSLabel.Name = "PSLabel";
			this.PSLabel.Size = new System.Drawing.Size(109, 17);
			this.PSLabel.TabIndex = 7;
			this.PSLabel.Text = "Source Directiry";
			// 
			// PCancelButton
			// 
			this.PCancelButton.Enabled = false;
			this.PCancelButton.Location = new System.Drawing.Point(499, 30);
			this.PCancelButton.Name = "PCancelButton";
			this.PCancelButton.Size = new System.Drawing.Size(134, 72);
			this.PCancelButton.TabIndex = 6;
			this.PCancelButton.Text = "Cancel";
			this.PCancelButton.UseVisualStyleBackColor = true;
			this.PCancelButton.Click += new System.EventHandler(this.PCancelButton_Click);
			// 
			// PStartButton
			// 
			this.PStartButton.Enabled = false;
			this.PStartButton.Location = new System.Drawing.Point(345, 30);
			this.PStartButton.Name = "PStartButton";
			this.PStartButton.Size = new System.Drawing.Size(134, 72);
			this.PStartButton.TabIndex = 5;
			this.PStartButton.Text = "Start Download";
			this.PStartButton.UseVisualStyleBackColor = true;
			this.PStartButton.Click += new System.EventHandler(this.PStartButton_Click);
			// 
			// PDestinationButton
			// 
			this.PDestinationButton.Location = new System.Drawing.Point(192, 30);
			this.PDestinationButton.Name = "PDestinationButton";
			this.PDestinationButton.Size = new System.Drawing.Size(134, 72);
			this.PDestinationButton.TabIndex = 4;
			this.PDestinationButton.Text = "Select Destination Directory";
			this.PDestinationButton.UseVisualStyleBackColor = true;
			this.PDestinationButton.Click += new System.EventHandler(this.PDestinationButton_Click);
			// 
			// PSourceButton
			// 
			this.PSourceButton.Location = new System.Drawing.Point(34, 30);
			this.PSourceButton.Name = "PSourceButton";
			this.PSourceButton.Size = new System.Drawing.Size(134, 72);
			this.PSourceButton.TabIndex = 3;
			this.PSourceButton.Text = "Select Source Directory";
			this.PSourceButton.UseVisualStyleBackColor = true;
			this.PSourceButton.Click += new System.EventHandler(this.PSourceButton_Click);
			// 
			// PDestinationTextBox
			// 
			this.PDestinationTextBox.Enabled = false;
			this.PDestinationTextBox.Location = new System.Drawing.Point(192, 166);
			this.PDestinationTextBox.Name = "PDestinationTextBox";
			this.PDestinationTextBox.Size = new System.Drawing.Size(441, 22);
			this.PDestinationTextBox.TabIndex = 2;
			// 
			// PSourceTextBox
			// 
			this.PSourceTextBox.Enabled = false;
			this.PSourceTextBox.Location = new System.Drawing.Point(192, 124);
			this.PSourceTextBox.Name = "PSourceTextBox";
			this.PSourceTextBox.Size = new System.Drawing.Size(441, 22);
			this.PSourceTextBox.TabIndex = 1;
			// 
			// PDataGridView
			// 
			this.PDataGridView.AllowUserToAddRows = false;
			this.PDataGridView.AllowUserToDeleteRows = false;
			this.PDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.PDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileColumn,
            this.StatusColumn});
			this.PDataGridView.Location = new System.Drawing.Point(34, 218);
			this.PDataGridView.Name = "PDataGridView";
			this.PDataGridView.ReadOnly = true;
			this.PDataGridView.RowTemplate.Height = 24;
			this.PDataGridView.Size = new System.Drawing.Size(599, 444);
			this.PDataGridView.TabIndex = 0;
			// 
			// FileColumn
			// 
			this.FileColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.FileColumn.HeaderText = "File";
			this.FileColumn.Name = "FileColumn";
			this.FileColumn.ReadOnly = true;
			// 
			// StatusColumn
			// 
			this.StatusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.StatusColumn.HeaderText = "Status";
			this.StatusColumn.Name = "StatusColumn";
			this.StatusColumn.ReadOnly = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.SDLabel);
			this.groupBox2.Controls.Add(this.SCancelButton);
			this.groupBox2.Controls.Add(this.SSLabel);
			this.groupBox2.Controls.Add(this.SDataGridView);
			this.groupBox2.Controls.Add(this.SSourceTextBox);
			this.groupBox2.Controls.Add(this.SStartButton);
			this.groupBox2.Controls.Add(this.SDestinationTextBox);
			this.groupBox2.Controls.Add(this.SDestinationButton);
			this.groupBox2.Controls.Add(this.SSourceButton);
			this.groupBox2.Location = new System.Drawing.Point(694, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(666, 687);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Queue with sequential processing";
			// 
			// SDLabel
			// 
			this.SDLabel.AutoSize = true;
			this.SDLabel.Location = new System.Drawing.Point(26, 169);
			this.SDLabel.Name = "SDLabel";
			this.SDLabel.Size = new System.Drawing.Size(135, 17);
			this.SDLabel.TabIndex = 17;
			this.SDLabel.Text = "Destination Directiry";
			// 
			// SSLabel
			// 
			this.SSLabel.AutoSize = true;
			this.SSLabel.Location = new System.Drawing.Point(26, 127);
			this.SSLabel.Name = "SSLabel";
			this.SSLabel.Size = new System.Drawing.Size(109, 17);
			this.SSLabel.TabIndex = 16;
			this.SSLabel.Text = "Source Directiry";
			// 
			// SCancelButton
			// 
			this.SCancelButton.Enabled = false;
			this.SCancelButton.Location = new System.Drawing.Point(494, 30);
			this.SCancelButton.Name = "SCancelButton";
			this.SCancelButton.Size = new System.Drawing.Size(134, 72);
			this.SCancelButton.TabIndex = 15;
			this.SCancelButton.Text = "Cancel";
			this.SCancelButton.UseVisualStyleBackColor = true;
			this.SCancelButton.Click += new System.EventHandler(this.SCancelButton_Click);
			// 
			// SStartButton
			// 
			this.SStartButton.Enabled = false;
			this.SStartButton.Location = new System.Drawing.Point(340, 30);
			this.SStartButton.Name = "SStartButton";
			this.SStartButton.Size = new System.Drawing.Size(134, 72);
			this.SStartButton.TabIndex = 14;
			this.SStartButton.Text = "Start Download";
			this.SStartButton.UseVisualStyleBackColor = true;
			this.SStartButton.Click += new System.EventHandler(this.SStartButton_Click);
			// 
			// SDestinationButton
			// 
			this.SDestinationButton.Location = new System.Drawing.Point(187, 30);
			this.SDestinationButton.Name = "SDestinationButton";
			this.SDestinationButton.Size = new System.Drawing.Size(134, 72);
			this.SDestinationButton.TabIndex = 13;
			this.SDestinationButton.Text = "Select Destination Directory";
			this.SDestinationButton.UseVisualStyleBackColor = true;
			this.SDestinationButton.Click += new System.EventHandler(this.SDestinationButton_Click);
			// 
			// SSourceButton
			// 
			this.SSourceButton.Location = new System.Drawing.Point(29, 30);
			this.SSourceButton.Name = "SSourceButton";
			this.SSourceButton.Size = new System.Drawing.Size(134, 72);
			this.SSourceButton.TabIndex = 12;
			this.SSourceButton.Text = "Select Source Directory";
			this.SSourceButton.UseVisualStyleBackColor = true;
			this.SSourceButton.Click += new System.EventHandler(this.SSourceButton_Click);
			// 
			// SDestinationTextBox
			// 
			this.SDestinationTextBox.Enabled = false;
			this.SDestinationTextBox.Location = new System.Drawing.Point(187, 166);
			this.SDestinationTextBox.Name = "SDestinationTextBox";
			this.SDestinationTextBox.Size = new System.Drawing.Size(441, 22);
			this.SDestinationTextBox.TabIndex = 11;
			// 
			// SSourceTextBox
			// 
			this.SSourceTextBox.Enabled = false;
			this.SSourceTextBox.Location = new System.Drawing.Point(187, 124);
			this.SSourceTextBox.Name = "SSourceTextBox";
			this.SSourceTextBox.Size = new System.Drawing.Size(441, 22);
			this.SSourceTextBox.TabIndex = 10;
			// 
			// SDataGridView
			// 
			this.SDataGridView.AllowUserToAddRows = false;
			this.SDataGridView.AllowUserToDeleteRows = false;
			this.SDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
			this.SDataGridView.Location = new System.Drawing.Point(29, 218);
			this.SDataGridView.Name = "SDataGridView";
			this.SDataGridView.ReadOnly = true;
			this.SDataGridView.RowTemplate.Height = 24;
			this.SDataGridView.Size = new System.Drawing.Size(599, 444);
			this.SDataGridView.TabIndex = 9;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.HeaderText = "File";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.HeaderText = "Status";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// DownloadManagerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1372, 711);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.PGroupBox);
			this.Name = "DownloadManagerForm";
			this.Text = "Download Manager";
			this.PGroupBox.ResumeLayout(false);
			this.PGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PDataGridView)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox PGroupBox;
		private System.Windows.Forms.DataGridView PDataGridView;
		private System.Windows.Forms.GroupBox groupBox2;
		private TextBox PSourceTextBox;
		private FolderBrowserDialog FolderBrowserDialog;
		private Label PDLabel;
		private Label PSLabel;
		private Button PCancelButton;
		private Button PStartButton;
		private Button PDestinationButton;
		private Button PSourceButton;
		private TextBox PDestinationTextBox;
		private DataGridViewTextBoxColumn FileColumn;
		private DataGridViewTextBoxColumn StatusColumn;
		private Label SDLabel;
		private Button SCancelButton;
		private Label SSLabel;
		private DataGridView SDataGridView;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private TextBox SSourceTextBox;
		private Button SStartButton;
		private TextBox SDestinationTextBox;
		private Button SDestinationButton;
		private Button SSourceButton;
	}
}

