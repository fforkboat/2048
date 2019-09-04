namespace _2048
{
    partial class GameOverDialog
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
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 72);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Game Over";
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Location = new System.Drawing.Point(59, 148);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(75, 23);
            this.buttonHome.TabIndex = 2;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonAgain
            // 
            this.buttonAgain.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAgain.FlatAppearance.BorderSize = 0;
            this.buttonAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgain.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgain.Location = new System.Drawing.Point(194, 148);
            this.buttonAgain.Name = "buttonAgain";
            this.buttonAgain.Size = new System.Drawing.Size(75, 23);
            this.buttonAgain.TabIndex = 3;
            this.buttonAgain.Text = "Again";
            this.buttonAgain.UseVisualStyleBackColor = false;
            this.buttonAgain.Click += new System.EventHandler(this.buttonAgain_Click);
            // 
            // GameOverDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 219);
            this.Controls.Add(this.buttonAgain);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GameOverDialog";
            this.Text = "GameOverDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonAgain;
    }
}