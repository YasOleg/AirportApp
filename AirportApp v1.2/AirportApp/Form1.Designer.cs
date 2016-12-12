namespace AirportApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgvTableInfo = new System.Windows.Forms.DataGridView();
            this.btnAddInfo = new System.Windows.Forms.Button();
            this.btnDelInfo = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWarning = new System.Windows.Forms.Button();
            this.tbWarning = new System.Windows.Forms.TextBox();
            this.WarningTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTableInfo
            // 
            this.dgvTableInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableInfo.Location = new System.Drawing.Point(45, 239);
            this.dgvTableInfo.Name = "dgvTableInfo";
            this.dgvTableInfo.Size = new System.Drawing.Size(822, 196);
            this.dgvTableInfo.TabIndex = 0;
            // 
            // btnAddInfo
            // 
            this.btnAddInfo.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddInfo.Location = new System.Drawing.Point(45, 153);
            this.btnAddInfo.Name = "btnAddInfo";
            this.btnAddInfo.Size = new System.Drawing.Size(100, 38);
            this.btnAddInfo.TabIndex = 1;
            this.btnAddInfo.Text = "Add Information";
            this.btnAddInfo.UseVisualStyleBackColor = false;
            this.btnAddInfo.Click += new System.EventHandler(this.btnAddInfo_Click);
            // 
            // btnDelInfo
            // 
            this.btnDelInfo.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDelInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelInfo.Location = new System.Drawing.Point(151, 153);
            this.btnDelInfo.Name = "btnDelInfo";
            this.btnDelInfo.Size = new System.Drawing.Size(100, 38);
            this.btnDelInfo.TabIndex = 2;
            this.btnDelInfo.Text = "Del Information";
            this.btnDelInfo.UseVisualStyleBackColor = false;
            this.btnDelInfo.Click += new System.EventHandler(this.btnDelInfo_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::AirportApp.Properties.Resources.Search_Filled_50;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(151, 197);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(43, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(45, 207);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 20);
            this.tbSearch.TabIndex = 4;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(730, 210);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(137, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load Info";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(357, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "AIRPORT ";
            // 
            // btnWarning
            // 
            this.btnWarning.AllowDrop = true;
            this.btnWarning.BackColor = System.Drawing.Color.Red;
            this.btnWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWarning.Location = new System.Drawing.Point(767, 45);
            this.btnWarning.Name = "btnWarning";
            this.btnWarning.Size = new System.Drawing.Size(100, 49);
            this.btnWarning.TabIndex = 7;
            this.btnWarning.Text = "Warning button!!!";
            this.btnWarning.UseVisualStyleBackColor = false;
            this.btnWarning.Click += new System.EventHandler(this.btnWarning_Click);
            // 
            // tbWarning
            // 
            this.tbWarning.Location = new System.Drawing.Point(654, 19);
            this.tbWarning.Name = "tbWarning";
            this.tbWarning.Size = new System.Drawing.Size(213, 20);
            this.tbWarning.TabIndex = 8;
            // 
            // WarningTimer
            // 
            this.WarningTimer.Tick += new System.EventHandler(this.WarningTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AirportApp.Properties.Resources._2560x1600_828183__www_ArtFile_ru_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 447);
            this.Controls.Add(this.tbWarning);
            this.Controls.Add(this.btnWarning);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelInfo);
            this.Controls.Add(this.btnAddInfo);
            this.Controls.Add(this.dgvTableInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "AirportApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvTableInfo;
        private System.Windows.Forms.Button btnAddInfo;
        private System.Windows.Forms.Button btnDelInfo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWarning;
        private System.Windows.Forms.TextBox tbWarning;
        private System.Windows.Forms.Timer WarningTimer;
    }
}

