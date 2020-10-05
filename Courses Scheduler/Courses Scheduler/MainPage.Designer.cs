namespace Courses_Scheduler
{
    partial class MainPage
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
            this.CourseLB = new System.Windows.Forms.Label();
            this.CourseCB = new System.Windows.Forms.ComboBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.RefreshBT = new System.Windows.Forms.Button();
            this.ScheduleBT = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CloseIcon = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Due = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseLB
            // 
            this.CourseLB.AutoSize = true;
            this.CourseLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.CourseLB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CourseLB.Location = new System.Drawing.Point(145, 88);
            this.CourseLB.Name = "CourseLB";
            this.CourseLB.Size = new System.Drawing.Size(59, 19);
            this.CourseLB.TabIndex = 16;
            this.CourseLB.Text = "Course:";
            this.CourseLB.Click += new System.EventHandler(this.Category_Click);
            // 
            // CourseCB
            // 
            this.CourseCB.FormattingEnabled = true;
            this.CourseCB.Location = new System.Drawing.Point(233, 88);
            this.CourseCB.Name = "CourseCB";
            this.CourseCB.Size = new System.Drawing.Size(254, 21);
            this.CourseCB.TabIndex = 15;
            this.CourseCB.SelectedIndexChanged += new System.EventHandler(this.CategoryCB_SelectedIndexChanged);
            // 
            // Grid
            // 
            this.Grid.AllowUserToOrderColumns = true;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course,
            this.Date,
            this.Due});
            this.Grid.Location = new System.Drawing.Point(60, 144);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(543, 148);
            this.Grid.TabIndex = 17;
            // 
            // RefreshBT
            // 
            this.RefreshBT.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.RefreshBT.FlatAppearance.BorderSize = 0;
            this.RefreshBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBT.ForeColor = System.Drawing.SystemColors.Control;
            this.RefreshBT.Location = new System.Drawing.Point(195, 331);
            this.RefreshBT.Name = "RefreshBT";
            this.RefreshBT.Size = new System.Drawing.Size(114, 30);
            this.RefreshBT.TabIndex = 18;
            this.RefreshBT.Text = "Refresh";
            this.RefreshBT.UseVisualStyleBackColor = false;
            this.RefreshBT.Click += new System.EventHandler(this.RefreshBT_Click);
            // 
            // ScheduleBT
            // 
            this.ScheduleBT.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ScheduleBT.FlatAppearance.BorderSize = 0;
            this.ScheduleBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScheduleBT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleBT.ForeColor = System.Drawing.SystemColors.Control;
            this.ScheduleBT.Location = new System.Drawing.Point(357, 331);
            this.ScheduleBT.Name = "ScheduleBT";
            this.ScheduleBT.Size = new System.Drawing.Size(114, 30);
            this.ScheduleBT.TabIndex = 19;
            this.ScheduleBT.Text = "Schedule";
            this.ScheduleBT.UseVisualStyleBackColor = false;
            this.ScheduleBT.Click += new System.EventHandler(this.ScheduleBT_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.TopPanel.BackgroundImage = global::Courses_Scheduler.Properties.Resources.Top_Panel;
            this.TopPanel.Controls.Add(this.CloseIcon);
            this.TopPanel.Controls.Add(this.Minimize);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(660, 45);
            this.TopPanel.TabIndex = 3;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // CloseIcon
            // 
            this.CloseIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseIcon.BackColor = System.Drawing.Color.White;
            this.CloseIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseIcon.ErrorImage = global::Courses_Scheduler.Properties.Resources.Close1;
            this.CloseIcon.Image = global::Courses_Scheduler.Properties.Resources.Close1;
            this.CloseIcon.Location = new System.Drawing.Point(628, 12);
            this.CloseIcon.Name = "CloseIcon";
            this.CloseIcon.Size = new System.Drawing.Size(20, 20);
            this.CloseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseIcon.TabIndex = 6;
            this.CloseIcon.TabStop = false;
            this.CloseIcon.Click += new System.EventHandler(this.CloseIcon_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.BackColor = System.Drawing.Color.White;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Image = global::Courses_Scheduler.Properties.Resources.Minimize;
            this.Minimize.Location = new System.Drawing.Point(602, 12);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(20, 20);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimize.TabIndex = 7;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Course
            // 
            this.Course.HeaderText = "Course";
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            this.Course.Width = 200;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Due
            // 
            this.Due.HeaderText = "Due";
            this.Due.Name = "Due";
            this.Due.ReadOnly = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.ScheduleBT);
            this.Controls.Add(this.RefreshBT);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.CourseLB);
            this.Controls.Add(this.CourseCB);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox CloseIcon;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.Label CourseLB;
        private System.Windows.Forms.ComboBox CourseCB;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button RefreshBT;
        private System.Windows.Forms.Button ScheduleBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Due;
    }
}