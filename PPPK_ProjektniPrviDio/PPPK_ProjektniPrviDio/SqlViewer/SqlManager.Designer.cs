
namespace Zadatak0102
{
    partial class SqlManager
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
            this.tbCommandLine = new System.Windows.Forms.TextBox();
            this.BtnExecute = new System.Windows.Forms.Button();
            this.flpData = new System.Windows.Forms.FlowLayoutPanel();
            this.CbDatabases = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbTableColums = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LbTables = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.tbInfoMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCommandLine
            // 
            this.tbCommandLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCommandLine.Location = new System.Drawing.Point(213, 105);
            this.tbCommandLine.Multiline = true;
            this.tbCommandLine.Name = "tbCommandLine";
            this.tbCommandLine.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCommandLine.Size = new System.Drawing.Size(415, 519);
            this.tbCommandLine.TabIndex = 0;
            // 
            // BtnExecute
            // 
            this.BtnExecute.Location = new System.Drawing.Point(473, 76);
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.Size = new System.Drawing.Size(75, 23);
            this.BtnExecute.TabIndex = 1;
            this.BtnExecute.Text = "Execute";
            this.BtnExecute.UseVisualStyleBackColor = true;
            this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // flpData
            // 
            this.flpData.AutoScroll = true;
            this.flpData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpData.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpData.Location = new System.Drawing.Point(643, 105);
            this.flpData.Name = "flpData";
            this.flpData.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.flpData.Size = new System.Drawing.Size(422, 384);
            this.flpData.TabIndex = 2;
            this.flpData.WrapContents = false;
            // 
            // CbDatabases
            // 
            this.CbDatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDatabases.FormattingEnabled = true;
            this.CbDatabases.Location = new System.Drawing.Point(78, 29);
            this.CbDatabases.Name = "CbDatabases";
            this.CbDatabases.Size = new System.Drawing.Size(142, 21);
            this.CbDatabases.TabIndex = 5;
            this.CbDatabases.SelectedIndexChanged += new System.EventHandler(this.CbDatabases_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Databases:";
            // 
            // LbTableColums
            // 
            this.LbTableColums.FormattingEnabled = true;
            this.LbTableColums.Location = new System.Drawing.Point(20, 386);
            this.LbTableColums.Margin = new System.Windows.Forms.Padding(2);
            this.LbTableColums.Name = "LbTableColums";
            this.LbTableColums.Size = new System.Drawing.Size(178, 238);
            this.LbTableColums.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 357);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Table Columns:";
            // 
            // LbTables
            // 
            this.LbTables.FormattingEnabled = true;
            this.LbTables.Location = new System.Drawing.Point(20, 105);
            this.LbTables.Margin = new System.Windows.Forms.Padding(2);
            this.LbTables.Name = "LbTables";
            this.LbTables.Size = new System.Drawing.Size(178, 225);
            this.LbTables.TabIndex = 19;
            this.LbTables.SelectedIndexChanged += new System.EventHandler(this.LbTables_SelectedIndexChanged);
            this.LbTables.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LbTables_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tables:";
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(554, 77);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(74, 23);
            this.BtnClear.TabIndex = 23;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // tbInfoMessage
            // 
            this.tbInfoMessage.Location = new System.Drawing.Point(643, 508);
            this.tbInfoMessage.Multiline = true;
            this.tbInfoMessage.Name = "tbInfoMessage";
            this.tbInfoMessage.ReadOnly = true;
            this.tbInfoMessage.Size = new System.Drawing.Size(422, 120);
            this.tbInfoMessage.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Query;";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(640, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Results:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(640, 492);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Messages:";
            // 
            // SqlManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 654);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbInfoMessage);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.LbTableColums);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LbTables);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbDatabases);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpData);
            this.Controls.Add(this.BtnExecute);
            this.Controls.Add(this.tbCommandLine);
            this.Name = "SqlManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SqlManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SqlManager_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCommandLine;
        private System.Windows.Forms.Button BtnExecute;
        private System.Windows.Forms.FlowLayoutPanel flpData;
        private System.Windows.Forms.ComboBox CbDatabases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LbTableColums;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LbTables;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.TextBox tbInfoMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}