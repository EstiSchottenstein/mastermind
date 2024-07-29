namespace RecordKeeperWinForm
{
    partial class frmPresident
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblCaptionParty = new System.Windows.Forms.Label();
            this.lblCaptionNum = new System.Windows.Forms.Label();
            this.lblCaptionFirstName = new System.Windows.Forms.Label();
            this.lblCaptionLastName = new System.Windows.Forms.Label();
            this.lblCaptionDateBorn = new System.Windows.Forms.Label();
            this.lblCaptionTermStart = new System.Windows.Forms.Label();
            this.lblCaptionTermEnd = new System.Windows.Forms.Label();
            this.lblParty = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtDateBorn = new System.Windows.Forms.TextBox();
            this.txtDateDied = new System.Windows.Forms.TextBox();
            this.txtTermStart = new System.Windows.Forms.TextBox();
            this.txtTermEnd = new System.Windows.Forms.TextBox();
            this.lblCaptionDateDied = new System.Windows.Forms.Label();
            this.tblMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.Controls.Add(this.lblCaptionParty, 0, 0);
            this.tblMain.Controls.Add(this.lblCaptionNum, 0, 1);
            this.tblMain.Controls.Add(this.lblCaptionFirstName, 0, 2);
            this.tblMain.Controls.Add(this.lblCaptionLastName, 0, 3);
            this.tblMain.Controls.Add(this.lblCaptionDateBorn, 0, 4);
            this.tblMain.Controls.Add(this.lblCaptionTermStart, 0, 6);
            this.tblMain.Controls.Add(this.lblCaptionTermEnd, 0, 7);
            this.tblMain.Controls.Add(this.lblParty, 1, 0);
            this.tblMain.Controls.Add(this.lblNum, 1, 1);
            this.tblMain.Controls.Add(this.txtFirstName, 1, 2);
            this.tblMain.Controls.Add(this.txtLastName, 1, 3);
            this.tblMain.Controls.Add(this.txtDateBorn, 1, 4);
            this.tblMain.Controls.Add(this.txtDateDied, 1, 5);
            this.tblMain.Controls.Add(this.txtTermStart, 1, 6);
            this.tblMain.Controls.Add(this.txtTermEnd, 1, 7);
            this.tblMain.Controls.Add(this.lblCaptionDateDied, 0, 5);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 8;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(488, 301);
            this.tblMain.TabIndex = 0;
            // 
            // lblCaptionParty
            // 
            this.lblCaptionParty.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionParty.AutoSize = true;
            this.lblCaptionParty.Location = new System.Drawing.Point(3, 0);
            this.lblCaptionParty.Name = "lblCaptionParty";
            this.lblCaptionParty.Size = new System.Drawing.Size(56, 28);
            this.lblCaptionParty.TabIndex = 0;
            this.lblCaptionParty.Text = "Party";
            // 
            // lblCaptionNum
            // 
            this.lblCaptionNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionNum.AutoSize = true;
            this.lblCaptionNum.Location = new System.Drawing.Point(3, 28);
            this.lblCaptionNum.Name = "lblCaptionNum";
            this.lblCaptionNum.Size = new System.Drawing.Size(55, 28);
            this.lblCaptionNum.TabIndex = 1;
            this.lblCaptionNum.Text = "Num";
            // 
            // lblCaptionFirstName
            // 
            this.lblCaptionFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionFirstName.AutoSize = true;
            this.lblCaptionFirstName.Location = new System.Drawing.Point(3, 62);
            this.lblCaptionFirstName.Name = "lblCaptionFirstName";
            this.lblCaptionFirstName.Size = new System.Drawing.Size(106, 28);
            this.lblCaptionFirstName.TabIndex = 2;
            this.lblCaptionFirstName.Text = "First Name";
            // 
            // lblCaptionLastName
            // 
            this.lblCaptionLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionLastName.AutoSize = true;
            this.lblCaptionLastName.Location = new System.Drawing.Point(3, 102);
            this.lblCaptionLastName.Name = "lblCaptionLastName";
            this.lblCaptionLastName.Size = new System.Drawing.Size(103, 28);
            this.lblCaptionLastName.TabIndex = 3;
            this.lblCaptionLastName.Text = "Last Name";
            // 
            // lblCaptionDateBorn
            // 
            this.lblCaptionDateBorn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionDateBorn.AutoSize = true;
            this.lblCaptionDateBorn.Location = new System.Drawing.Point(3, 142);
            this.lblCaptionDateBorn.Name = "lblCaptionDateBorn";
            this.lblCaptionDateBorn.Size = new System.Drawing.Size(99, 28);
            this.lblCaptionDateBorn.TabIndex = 4;
            this.lblCaptionDateBorn.Text = "Date Born";
            // 
            // lblCaptionTermStart
            // 
            this.lblCaptionTermStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionTermStart.AutoSize = true;
            this.lblCaptionTermStart.Location = new System.Drawing.Point(3, 222);
            this.lblCaptionTermStart.Name = "lblCaptionTermStart";
            this.lblCaptionTermStart.Size = new System.Drawing.Size(100, 28);
            this.lblCaptionTermStart.TabIndex = 6;
            this.lblCaptionTermStart.Text = "Term Start";
            // 
            // lblCaptionTermEnd
            // 
            this.lblCaptionTermEnd.AutoSize = true;
            this.lblCaptionTermEnd.Location = new System.Drawing.Point(3, 263);
            this.lblCaptionTermEnd.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblCaptionTermEnd.Name = "lblCaptionTermEnd";
            this.lblCaptionTermEnd.Size = new System.Drawing.Size(92, 28);
            this.lblCaptionTermEnd.TabIndex = 7;
            this.lblCaptionTermEnd.Text = "Term End";
            // 
            // lblParty
            // 
            this.lblParty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblParty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblParty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblParty.Location = new System.Drawing.Point(115, 0);
            this.lblParty.Name = "lblParty";
            this.lblParty.Size = new System.Drawing.Size(370, 28);
            this.lblParty.TabIndex = 8;
            // 
            // lblNum
            // 
            this.lblNum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNum.Location = new System.Drawing.Point(115, 28);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(370, 28);
            this.lblNum.TabIndex = 9;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstName.Location = new System.Drawing.Point(115, 59);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(370, 34);
            this.txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastName.Location = new System.Drawing.Point(115, 99);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(370, 34);
            this.txtLastName.TabIndex = 11;
            // 
            // txtDateBorn
            // 
            this.txtDateBorn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateBorn.Location = new System.Drawing.Point(115, 139);
            this.txtDateBorn.Name = "txtDateBorn";
            this.txtDateBorn.Size = new System.Drawing.Size(370, 34);
            this.txtDateBorn.TabIndex = 12;
            // 
            // txtDateDied
            // 
            this.txtDateDied.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateDied.Location = new System.Drawing.Point(115, 179);
            this.txtDateDied.Name = "txtDateDied";
            this.txtDateDied.Size = new System.Drawing.Size(370, 34);
            this.txtDateDied.TabIndex = 13;
            // 
            // txtTermStart
            // 
            this.txtTermStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTermStart.Location = new System.Drawing.Point(115, 219);
            this.txtTermStart.Name = "txtTermStart";
            this.txtTermStart.Size = new System.Drawing.Size(370, 34);
            this.txtTermStart.TabIndex = 14;
            // 
            // txtTermEnd
            // 
            this.txtTermEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTermEnd.Location = new System.Drawing.Point(115, 259);
            this.txtTermEnd.Name = "txtTermEnd";
            this.txtTermEnd.Size = new System.Drawing.Size(370, 34);
            this.txtTermEnd.TabIndex = 15;
            // 
            // lblCaptionDateDied
            // 
            this.lblCaptionDateDied.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionDateDied.AutoSize = true;
            this.lblCaptionDateDied.Location = new System.Drawing.Point(3, 182);
            this.lblCaptionDateDied.Name = "lblCaptionDateDied";
            this.lblCaptionDateDied.Size = new System.Drawing.Size(99, 28);
            this.lblCaptionDateDied.TabIndex = 5;
            this.lblCaptionDateDied.Text = "Date Died";
            // 
            // frmPresident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 301);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPresident";
            this.Text = "President";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionParty;
        private Label lblCaptionNum;
        private Label lblCaptionFirstName;
        private Label lblCaptionLastName;
        private Label lblCaptionDateBorn;
        private Label lblCaptionTermStart;
        private Label lblCaptionTermEnd;
        private Label lblParty;
        private Label lblNum;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtDateBorn;
        private TextBox txtDateDied;
        private TextBox txtTermStart;
        private TextBox txtTermEnd;
        private Label lblCaptionDateDied;
    }
}