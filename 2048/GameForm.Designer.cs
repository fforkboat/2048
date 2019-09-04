namespace _2048
{
    partial class GameForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.timerForSlide = new System.Windows.Forms.Timer(this.components);
            this.labelC = new System.Windows.Forms.Label();
            this.labelCurrentScore = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.labelHighestScore = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHintMessage = new System.Windows.Forms.Label();
            this.labelDoubleClick = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.labelMultiply = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanelItems = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxLock = new System.Windows.Forms.PictureBox();
            this.flowLayoutItemPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.timerForMultiply = new System.Windows.Forms.Timer(this.components);
            this.panelGameArea = new System.Windows.Forms.Panel();
            this.pictureBoxGameBg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonHome = new System.Windows.Forms.Button();
            this.timerForWildMode = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanelItems.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLock)).BeginInit();
            this.panelGameArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameBg)).BeginInit();
            this.SuspendLayout();
            // 
            // timerForSlide
            // 
            this.timerForSlide.Interval = 1;
            this.timerForSlide.Tick += new System.EventHandler(this.timerForSlide_Tick);
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.BackColor = System.Drawing.Color.Transparent;
            this.labelC.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelC.Location = new System.Drawing.Point(4, 6);
            this.labelC.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(165, 30);
            this.labelC.TabIndex = 12;
            this.labelC.Text = "Current Score:";
            // 
            // labelCurrentScore
            // 
            this.labelCurrentScore.AutoSize = true;
            this.labelCurrentScore.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCurrentScore.Location = new System.Drawing.Point(177, 6);
            this.labelCurrentScore.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.labelCurrentScore.Name = "labelCurrentScore";
            this.labelCurrentScore.Size = new System.Drawing.Size(24, 28);
            this.labelCurrentScore.TabIndex = 13;
            this.labelCurrentScore.Text = "0";
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.BackColor = System.Drawing.Color.Transparent;
            this.labelH.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH.Location = new System.Drawing.Point(4, 6);
            this.labelH.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(130, 24);
            this.labelH.TabIndex = 6;
            this.labelH.Text = "Highest Score:";
            // 
            // labelHighestScore
            // 
            this.labelHighestScore.AutoSize = true;
            this.labelHighestScore.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighestScore.Location = new System.Drawing.Point(142, 6);
            this.labelHighestScore.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.labelHighestScore.Name = "labelHighestScore";
            this.labelHighestScore.Size = new System.Drawing.Size(45, 20);
            this.labelHighestScore.TabIndex = 15;
            this.labelHighestScore.Text = "2000";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanelItems);
            this.panel1.Location = new System.Drawing.Point(529, 135);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 450);
            this.panel1.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(4, 172);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(288, 4);
            this.label10.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(4, 271);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 4);
            this.label7.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(4, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 4);
            this.label6.TabIndex = 21;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelHintMessage, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelDoubleClick, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 279);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.23256F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.76744F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(287, 168);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hint:";
            // 
            // labelHintMessage
            // 
            this.labelHintMessage.AutoSize = true;
            this.labelHintMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelHintMessage.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHintMessage.ForeColor = System.Drawing.Color.Black;
            this.labelHintMessage.Location = new System.Drawing.Point(4, 47);
            this.labelHintMessage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.labelHintMessage.Name = "labelHintMessage";
            this.labelHintMessage.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.labelHintMessage.Size = new System.Drawing.Size(276, 78);
            this.labelHintMessage.TabIndex = 16;
            this.labelHintMessage.Text = "Use direction keys (up,down,left,right) to control the flow of all cells.";
            // 
            // labelDoubleClick
            // 
            this.labelDoubleClick.AutoSize = true;
            this.labelDoubleClick.BackColor = System.Drawing.Color.Transparent;
            this.labelDoubleClick.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoubleClick.Location = new System.Drawing.Point(4, 135);
            this.labelDoubleClick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDoubleClick.Name = "labelDoubleClick";
            this.labelDoubleClick.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labelDoubleClick.Size = new System.Drawing.Size(255, 31);
            this.labelDoubleClick.TabIndex = 21;
            this.labelDoubleClick.Text = "Double click here to cancel.";
            this.labelDoubleClick.Visible = false;
            this.labelDoubleClick.DoubleClick += new System.EventHandler(this.labelDoubleClick_DoubleClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 10);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(267, 151);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.labelMultiply);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 33);
            this.panel2.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Scores:";
            // 
            // labelMultiply
            // 
            this.labelMultiply.AutoSize = true;
            this.labelMultiply.BackColor = System.Drawing.Color.Transparent;
            this.labelMultiply.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMultiply.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelMultiply.Location = new System.Drawing.Point(213, 2);
            this.labelMultiply.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.labelMultiply.Name = "labelMultiply";
            this.labelMultiply.Size = new System.Drawing.Size(36, 29);
            this.labelMultiply.TabIndex = 16;
            this.labelMultiply.Text = "*2";
            this.labelMultiply.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.labelC);
            this.flowLayoutPanel1.Controls.Add(this.labelCurrentScore);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 45);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(259, 102);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.labelH);
            this.flowLayoutPanel2.Controls.Add(this.labelHighestScore);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 44);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(251, 34);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // tableLayoutPanelItems
            // 
            this.tableLayoutPanelItems.ColumnCount = 1;
            this.tableLayoutPanelItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelItems.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanelItems.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanelItems.Location = new System.Drawing.Point(9, 180);
            this.tableLayoutPanelItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanelItems.Name = "tableLayoutPanelItems";
            this.tableLayoutPanelItems.RowCount = 2;
            this.tableLayoutPanelItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.18391F));
            this.tableLayoutPanelItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.81609F));
            this.tableLayoutPanelItems.Size = new System.Drawing.Size(267, 88);
            this.tableLayoutPanelItems.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 4);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Items:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.61194F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.38806F));
            this.tableLayoutPanel4.Controls.Add(this.pictureBoxLock, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutItemPanel, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 32);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(259, 51);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // pictureBoxLock
            // 
            this.pictureBoxLock.BackgroundImage = global::_2048.Properties.Resources.forbid;
            this.pictureBoxLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxLock.Location = new System.Drawing.Point(205, 4);
            this.pictureBoxLock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxLock.Name = "pictureBoxLock";
            this.pictureBoxLock.Size = new System.Drawing.Size(50, 43);
            this.pictureBoxLock.TabIndex = 16;
            this.pictureBoxLock.TabStop = false;
            this.pictureBoxLock.Visible = false;
            // 
            // flowLayoutItemPanel
            // 
            this.flowLayoutItemPanel.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutItemPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutItemPanel.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutItemPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutItemPanel.Name = "flowLayoutItemPanel";
            this.flowLayoutItemPanel.Size = new System.Drawing.Size(192, 43);
            this.flowLayoutItemPanel.TabIndex = 18;
            // 
            // timerForMultiply
            // 
            this.timerForMultiply.Interval = 10000;
            this.timerForMultiply.Tick += new System.EventHandler(this.timerForMultiply_Tick);
            // 
            // panelGameArea
            // 
            this.panelGameArea.BackColor = System.Drawing.Color.Transparent;
            this.panelGameArea.Controls.Add(this.pictureBoxGameBg);
            this.panelGameArea.Enabled = false;
            this.panelGameArea.Location = new System.Drawing.Point(15, 135);
            this.panelGameArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelGameArea.Name = "panelGameArea";
            this.panelGameArea.Size = new System.Drawing.Size(476, 450);
            this.panelGameArea.TabIndex = 16;
            // 
            // pictureBoxGameBg
            // 
            this.pictureBoxGameBg.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGameBg.Image")));
            this.pictureBoxGameBg.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxGameBg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxGameBg.Name = "pictureBoxGameBg";
            this.pictureBoxGameBg.Size = new System.Drawing.Size(480, 450);
            this.pictureBoxGameBg.TabIndex = 4;
            this.pictureBoxGameBg.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(811, 14);
            this.label1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(12, 600);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(811, 14);
            this.label4.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightSlateGray;
            this.label5.Location = new System.Drawing.Point(499, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 419);
            this.label5.TabIndex = 20;
            // 
            // buttonHome
            // 
            this.buttonHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(787, 39);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(37, 32);
            this.buttonHome.TabIndex = 14;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // timerForWildMode
            // 
            this.timerForWildMode.Interval = 3000;
            this.timerForWildMode.Tick += new System.EventHandler(this.timerForWildMode_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 625);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelGameArea);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameForm";
            this.Sizable = false;
            this.Text = "2048";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyUp);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanelItems.ResumeLayout(false);
            this.tableLayoutPanelItems.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLock)).EndInit();
            this.panelGameArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameBg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerForSlide;
        private System.Windows.Forms.PictureBox pictureBoxGameBg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelCurrentScore;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label labelHighestScore;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label labelMultiply;
        private System.Windows.Forms.Label labelHintMessage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutItemPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Timer timerForMultiply;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox pictureBoxLock;
        private System.Windows.Forms.Panel panelGameArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDoubleClick;
        private System.Windows.Forms.Timer timerForWildMode;
    }
}

