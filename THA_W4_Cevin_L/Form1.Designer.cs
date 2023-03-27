namespace THA_W4_Cevin_L
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbChooseCountry = new System.Windows.Forms.ComboBox();
            this.cmbChooseTeam = new System.Windows.Forms.ComboBox();
            this.cbPlayerPosition = new System.Windows.Forms.ComboBox();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.txtTeamCountry = new System.Windows.Forms.TextBox();
            this.txtTeamCity = new System.Windows.Forms.TextBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.txtPlayerNumber = new System.Windows.Forms.TextBox();
            this.lstPlayer = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnAddPlayers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soccer Team List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Country:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose Team:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adding Team";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Team Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Team Country:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Team City:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(674, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Adding Players";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(674, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Player Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(674, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Player Number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(674, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Player Potision:";
            // 
            // cmbChooseCountry
            // 
            this.cmbChooseCountry.FormattingEnabled = true;
            this.cmbChooseCountry.Location = new System.Drawing.Point(133, 58);
            this.cmbChooseCountry.Name = "cmbChooseCountry";
            this.cmbChooseCountry.Size = new System.Drawing.Size(121, 24);
            this.cmbChooseCountry.TabIndex = 11;
            this.cmbChooseCountry.SelectedIndexChanged += new System.EventHandler(this.cmbChooseCountry_SelectedIndexChanged);
            // 
            // cmbChooseTeam
            // 
            this.cmbChooseTeam.FormattingEnabled = true;
            this.cmbChooseTeam.Location = new System.Drawing.Point(133, 96);
            this.cmbChooseTeam.Name = "cmbChooseTeam";
            this.cmbChooseTeam.Size = new System.Drawing.Size(121, 24);
            this.cmbChooseTeam.TabIndex = 12;
            this.cmbChooseTeam.SelectedIndexChanged += new System.EventHandler(this.cmbChooseTeam_SelectedIndexChanged);
            // 
            // cbPlayerPosition
            // 
            this.cbPlayerPosition.FormattingEnabled = true;
            this.cbPlayerPosition.Location = new System.Drawing.Point(780, 115);
            this.cbPlayerPosition.Name = "cbPlayerPosition";
            this.cbPlayerPosition.Size = new System.Drawing.Size(121, 24);
            this.cbPlayerPosition.TabIndex = 13;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(410, 58);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(100, 22);
            this.txtTeamName.TabIndex = 14;
            // 
            // txtTeamCountry
            // 
            this.txtTeamCountry.Location = new System.Drawing.Point(410, 85);
            this.txtTeamCountry.Name = "txtTeamCountry";
            this.txtTeamCountry.Size = new System.Drawing.Size(100, 22);
            this.txtTeamCountry.TabIndex = 15;
            // 
            // txtTeamCity
            // 
            this.txtTeamCity.Location = new System.Drawing.Point(410, 115);
            this.txtTeamCity.Name = "txtTeamCity";
            this.txtTeamCity.Size = new System.Drawing.Size(100, 22);
            this.txtTeamCity.TabIndex = 16;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(780, 52);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(121, 22);
            this.txtPlayerName.TabIndex = 17;
            // 
            // txtPlayerNumber
            // 
            this.txtPlayerNumber.Location = new System.Drawing.Point(780, 85);
            this.txtPlayerNumber.Name = "txtPlayerNumber";
            this.txtPlayerNumber.Size = new System.Drawing.Size(121, 22);
            this.txtPlayerNumber.TabIndex = 18;
            // 
            // lstPlayer
            // 
            this.lstPlayer.FormattingEnabled = true;
            this.lstPlayer.ItemHeight = 16;
            this.lstPlayer.Location = new System.Drawing.Point(25, 165);
            this.lstPlayer.Name = "lstPlayer";
            this.lstPlayer.Size = new System.Drawing.Size(300, 212);
            this.lstPlayer.TabIndex = 19;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(25, 383);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 20;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(410, 165);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(75, 23);
            this.btnAddTeam.TabIndex = 21;
            this.btnAddTeam.Text = "Add";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // btnAddPlayers
            // 
            this.btnAddPlayers.Location = new System.Drawing.Point(780, 165);
            this.btnAddPlayers.Name = "btnAddPlayers";
            this.btnAddPlayers.Size = new System.Drawing.Size(75, 23);
            this.btnAddPlayers.TabIndex = 22;
            this.btnAddPlayers.Text = "Add";
            this.btnAddPlayers.UseVisualStyleBackColor = true;
            this.btnAddPlayers.Click += new System.EventHandler(this.btnAddPlayers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 540);
            this.Controls.Add(this.btnAddPlayers);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstPlayer);
            this.Controls.Add(this.txtPlayerNumber);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.txtTeamCity);
            this.Controls.Add(this.txtTeamCountry);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.cbPlayerPosition);
            this.Controls.Add(this.cmbChooseTeam);
            this.Controls.Add(this.cmbChooseCountry);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbChooseCountry;
        private System.Windows.Forms.ComboBox cmbChooseTeam;
        private System.Windows.Forms.ComboBox cbPlayerPosition;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.TextBox txtTeamCountry;
        private System.Windows.Forms.TextBox txtTeamCity;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.TextBox txtPlayerNumber;
        private System.Windows.Forms.ListBox lstPlayer;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnAddPlayers;
    }
}

