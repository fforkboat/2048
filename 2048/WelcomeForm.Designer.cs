namespace _2048
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.buttonWild = new System.Windows.Forms.Button();
            this.buttonItems = new System.Windows.Forms.Button();
            this.buttonGeneral = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHighestScores = new System.Windows.Forms.Button();
            this.tableLayoutPanelScores = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelWildScore = new System.Windows.Forms.Label();
            this.labelGeneralScore = new System.Windows.Forms.Label();
            this.labelItemsScore = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanelScores.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonWild
            // 
            this.buttonWild.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonWild.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonWild.FlatAppearance.BorderSize = 0;
            this.buttonWild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWild.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWild.Location = new System.Drawing.Point(150, 291);
            this.buttonWild.Name = "buttonWild";
            this.buttonWild.Size = new System.Drawing.Size(145, 37);
            this.buttonWild.TabIndex = 3;
            this.buttonWild.Text = "Wild Mode";
            this.buttonWild.UseVisualStyleBackColor = false;
            this.buttonWild.Click += new System.EventHandler(this.buttonWild_Click);
            // 
            // buttonItems
            // 
            this.buttonItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonItems.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonItems.FlatAppearance.BorderSize = 0;
            this.buttonItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonItems.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItems.Location = new System.Drawing.Point(150, 334);
            this.buttonItems.Name = "buttonItems";
            this.buttonItems.Size = new System.Drawing.Size(145, 37);
            this.buttonItems.TabIndex = 2;
            this.buttonItems.Text = "Items Mode";
            this.buttonItems.UseVisualStyleBackColor = false;
            this.buttonItems.Click += new System.EventHandler(this.buttonItems_Click);
            // 
            // buttonGeneral
            // 
            this.buttonGeneral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGeneral.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonGeneral.FlatAppearance.BorderSize = 0;
            this.buttonGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGeneral.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGeneral.Location = new System.Drawing.Point(150, 248);
            this.buttonGeneral.Name = "buttonGeneral";
            this.buttonGeneral.Size = new System.Drawing.Size(145, 37);
            this.buttonGeneral.TabIndex = 1;
            this.buttonGeneral.Text = "General Mode";
            this.buttonGeneral.UseVisualStyleBackColor = false;
            this.buttonGeneral.Click += new System.EventHandler(this.buttonGeneral_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.SlateGray;
            this.label3.Font = new System.Drawing.Font("杨任东竹石体-Medium", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(35, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 80);
            this.label3.TabIndex = 18;
            this.label3.Text = "2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("杨任东竹石体-Medium", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(134, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 80);
            this.label2.TabIndex = 19;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.MediumPurple;
            this.label4.Font = new System.Drawing.Font("杨任东竹石体-Medium", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(232, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 80);
            this.label4.TabIndex = 20;
            this.label4.Text = "4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.Salmon;
            this.label5.Font = new System.Drawing.Font("杨任东竹石体-Medium", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(329, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 80);
            this.label5.TabIndex = 21;
            this.label5.Text = "8";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(16, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 10);
            this.label1.TabIndex = 22;
            // 
            // buttonHighestScores
            // 
            this.buttonHighestScores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHighestScores.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonHighestScores.FlatAppearance.BorderSize = 0;
            this.buttonHighestScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHighestScores.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHighestScores.Location = new System.Drawing.Point(150, 387);
            this.buttonHighestScores.Name = "buttonHighestScores";
            this.buttonHighestScores.Size = new System.Drawing.Size(145, 37);
            this.buttonHighestScores.TabIndex = 23;
            this.buttonHighestScores.Text = "Highest Scores";
            this.buttonHighestScores.UseVisualStyleBackColor = false;
            this.buttonHighestScores.Click += new System.EventHandler(this.buttonHighestScores_Click);
            // 
            // tableLayoutPanelScores
            // 
            this.tableLayoutPanelScores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelScores.ColumnCount = 2;
            this.tableLayoutPanelScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.89147F));
            this.tableLayoutPanelScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.10853F));
            this.tableLayoutPanelScores.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanelScores.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanelScores.Controls.Add(this.labelWildScore, 1, 1);
            this.tableLayoutPanelScores.Controls.Add(this.labelGeneralScore, 1, 0);
            this.tableLayoutPanelScores.Controls.Add(this.labelItemsScore, 1, 2);
            this.tableLayoutPanelScores.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanelScores.Location = new System.Drawing.Point(97, 248);
            this.tableLayoutPanelScores.Name = "tableLayoutPanelScores";
            this.tableLayoutPanelScores.RowCount = 3;
            this.tableLayoutPanelScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.58823F));
            this.tableLayoutPanelScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.41177F));
            this.tableLayoutPanelScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelScores.Size = new System.Drawing.Size(258, 123);
            this.tableLayoutPanelScores.TabIndex = 24;
            this.tableLayoutPanelScores.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label6.Size = new System.Drawing.Size(111, 33);
            this.label6.TabIndex = 25;
            this.label6.Text = "General Mode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 82);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label8.Size = new System.Drawing.Size(97, 33);
            this.label8.TabIndex = 27;
            this.label8.Text = "Items Mode";
            // 
            // labelWildScore
            // 
            this.labelWildScore.AutoSize = true;
            this.labelWildScore.BackColor = System.Drawing.Color.Transparent;
            this.labelWildScore.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWildScore.Location = new System.Drawing.Point(172, 41);
            this.labelWildScore.Name = "labelWildScore";
            this.labelWildScore.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelWildScore.Size = new System.Drawing.Size(20, 33);
            this.labelWildScore.TabIndex = 29;
            this.labelWildScore.Text = "0";
            // 
            // labelGeneralScore
            // 
            this.labelGeneralScore.AutoSize = true;
            this.labelGeneralScore.BackColor = System.Drawing.Color.Transparent;
            this.labelGeneralScore.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGeneralScore.Location = new System.Drawing.Point(172, 0);
            this.labelGeneralScore.Name = "labelGeneralScore";
            this.labelGeneralScore.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelGeneralScore.Size = new System.Drawing.Size(20, 33);
            this.labelGeneralScore.TabIndex = 28;
            this.labelGeneralScore.Text = "0";
            // 
            // labelItemsScore
            // 
            this.labelItemsScore.AutoSize = true;
            this.labelItemsScore.BackColor = System.Drawing.Color.Transparent;
            this.labelItemsScore.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemsScore.Location = new System.Drawing.Point(172, 82);
            this.labelItemsScore.Name = "labelItemsScore";
            this.labelItemsScore.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelItemsScore.Size = new System.Drawing.Size(20, 33);
            this.labelItemsScore.TabIndex = 30;
            this.labelItemsScore.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 41);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label7.Size = new System.Drawing.Size(91, 33);
            this.label7.TabIndex = 26;
            this.label7.Text = "Wild Mode";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(-21, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 162);
            this.label10.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(437, 44);
            this.label9.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(209, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 43);
            this.label11.TabIndex = 28;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(437, 446);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tableLayoutPanelScores);
            this.Controls.Add(this.buttonHighestScores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonItems);
            this.Controls.Add(this.buttonWild);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonGeneral);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "WelcomeForm";
            this.Sizable = false;
            this.Text = "2048";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WelcomeForm_FormClosed);
            this.tableLayoutPanelScores.ResumeLayout(false);
            this.tableLayoutPanelScores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonWild;
        private System.Windows.Forms.Button buttonItems;
        private System.Windows.Forms.Button buttonGeneral;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHighestScores;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelScores;
        private System.Windows.Forms.Label labelWildScore;
        private System.Windows.Forms.Label labelGeneralScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelItemsScore;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}