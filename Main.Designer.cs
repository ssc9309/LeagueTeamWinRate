namespace LeagueTeamWinRate
{
    partial class Main
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
            this.tbx_SearchChamp = new System.Windows.Forms.TextBox();
            this.lbx_ListOfChamp = new System.Windows.Forms.ListBox();
            this.lbx_Team1 = new System.Windows.Forms.ListBox();
            this.lbx_Team2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Team1Add = new System.Windows.Forms.Button();
            this.btn_Team1Remove = new System.Windows.Forms.Button();
            this.btn_Team2Add = new System.Windows.Forms.Button();
            this.btn_Team2Remove = new System.Windows.Forms.Button();
            this.lbl_Team1WinRate = new System.Windows.Forms.Label();
            this.lbl_Team2WinRate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_SearchChamp
            // 
            this.tbx_SearchChamp.Location = new System.Drawing.Point(34, 43);
            this.tbx_SearchChamp.Name = "tbx_SearchChamp";
            this.tbx_SearchChamp.Size = new System.Drawing.Size(120, 20);
            this.tbx_SearchChamp.TabIndex = 0;
            this.tbx_SearchChamp.TextChanged += new System.EventHandler(this.tbx_SearchChamp_TextChanged);
            // 
            // lbx_ListOfChamp
            // 
            this.lbx_ListOfChamp.FormattingEnabled = true;
            this.lbx_ListOfChamp.Location = new System.Drawing.Point(34, 100);
            this.lbx_ListOfChamp.Name = "lbx_ListOfChamp";
            this.lbx_ListOfChamp.Size = new System.Drawing.Size(120, 264);
            this.lbx_ListOfChamp.TabIndex = 1;
            // 
            // lbx_Team1
            // 
            this.lbx_Team1.FormattingEnabled = true;
            this.lbx_Team1.Location = new System.Drawing.Point(292, 69);
            this.lbx_Team1.Name = "lbx_Team1";
            this.lbx_Team1.Size = new System.Drawing.Size(120, 95);
            this.lbx_Team1.TabIndex = 2;
            // 
            // lbx_Team2
            // 
            this.lbx_Team2.FormattingEnabled = true;
            this.lbx_Team2.Location = new System.Drawing.Point(292, 269);
            this.lbx_Team2.Name = "lbx_Team2";
            this.lbx_Team2.Size = new System.Drawing.Size(120, 95);
            this.lbx_Team2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Team 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Team 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Search";
            // 
            // btn_Team1Add
            // 
            this.btn_Team1Add.Location = new System.Drawing.Point(192, 90);
            this.btn_Team1Add.Name = "btn_Team1Add";
            this.btn_Team1Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Team1Add.TabIndex = 7;
            this.btn_Team1Add.Text = "Add";
            this.btn_Team1Add.UseVisualStyleBackColor = true;
            this.btn_Team1Add.Click += new System.EventHandler(this.btn_Team1Add_Click);
            // 
            // btn_Team1Remove
            // 
            this.btn_Team1Remove.Location = new System.Drawing.Point(192, 141);
            this.btn_Team1Remove.Name = "btn_Team1Remove";
            this.btn_Team1Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Team1Remove.TabIndex = 8;
            this.btn_Team1Remove.Text = "Remove";
            this.btn_Team1Remove.UseVisualStyleBackColor = true;
            this.btn_Team1Remove.Click += new System.EventHandler(this.btn_Team1Remove_Click);
            // 
            // btn_Team2Add
            // 
            this.btn_Team2Add.Location = new System.Drawing.Point(192, 242);
            this.btn_Team2Add.Name = "btn_Team2Add";
            this.btn_Team2Add.Size = new System.Drawing.Size(75, 34);
            this.btn_Team2Add.TabIndex = 9;
            this.btn_Team2Add.Text = "Add";
            this.btn_Team2Add.UseVisualStyleBackColor = true;
            this.btn_Team2Add.Click += new System.EventHandler(this.btn_Team2Add_Click);
            // 
            // btn_Team2Remove
            // 
            this.btn_Team2Remove.Location = new System.Drawing.Point(192, 296);
            this.btn_Team2Remove.Name = "btn_Team2Remove";
            this.btn_Team2Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Team2Remove.TabIndex = 10;
            this.btn_Team2Remove.Text = "Remove";
            this.btn_Team2Remove.UseVisualStyleBackColor = true;
            // 
            // lbl_Team1WinRate
            // 
            this.lbl_Team1WinRate.AutoSize = true;
            this.lbl_Team1WinRate.Location = new System.Drawing.Point(451, 100);
            this.lbl_Team1WinRate.Name = "lbl_Team1WinRate";
            this.lbl_Team1WinRate.Size = new System.Drawing.Size(35, 13);
            this.lbl_Team1WinRate.TabIndex = 11;
            this.lbl_Team1WinRate.Text = "label4";
            // 
            // lbl_Team2WinRate
            // 
            this.lbl_Team2WinRate.AutoSize = true;
            this.lbl_Team2WinRate.Location = new System.Drawing.Point(454, 305);
            this.lbl_Team2WinRate.Name = "lbl_Team2WinRate";
            this.lbl_Team2WinRate.Size = new System.Drawing.Size(35, 13);
            this.lbl_Team2WinRate.TabIndex = 12;
            this.lbl_Team2WinRate.Text = "label5";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 427);
            this.Controls.Add(this.lbl_Team2WinRate);
            this.Controls.Add(this.lbl_Team1WinRate);
            this.Controls.Add(this.btn_Team2Remove);
            this.Controls.Add(this.btn_Team2Add);
            this.Controls.Add(this.btn_Team1Remove);
            this.Controls.Add(this.btn_Team1Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbx_Team2);
            this.Controls.Add(this.lbx_Team1);
            this.Controls.Add(this.lbx_ListOfChamp);
            this.Controls.Add(this.tbx_SearchChamp);
            this.Name = "Main";
            this.Text = "Team WinRate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_SearchChamp;
        private System.Windows.Forms.ListBox lbx_ListOfChamp;
        private System.Windows.Forms.ListBox lbx_Team1;
        private System.Windows.Forms.ListBox lbx_Team2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Team1Add;
        private System.Windows.Forms.Button btn_Team1Remove;
        private System.Windows.Forms.Button btn_Team2Add;
        private System.Windows.Forms.Button btn_Team2Remove;
        private System.Windows.Forms.Label lbl_Team1WinRate;
        private System.Windows.Forms.Label lbl_Team2WinRate;
    }
}

