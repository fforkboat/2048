using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace _2048
{
    public partial class GameForm : MaterialForm
    {
        public GameForm()
        {
            InitializeComponent();

            setMode();
            addCell();
            isToTerminateProcess = true;
        }

        /// <summary>
        /// 设定游戏模式
        /// </summary>
        private void setMode()
        {
            if (gameMode == GameMode.General)
            {
                tableLayoutPanelItems.Visible = false;
                labelHintMessage.Text = generalModeHint;
                labelHighestScore.Text = Properties.Settings.Default.HighestScoreGeneral.ToString();
            }

            else if (gameMode == GameMode.Wild)
            {
                tableLayoutPanelItems.Visible = false;
                labelHintMessage.Text = wildModeHint;
                timerForWildMode.Enabled = true;
                labelHighestScore.Text = Properties.Settings.Default.HighestScoreWild.ToString();
            }

            else if (gameMode == GameMode.Items)
            {
                labelHintMessage.Text = itemsModeHint;
                labelHighestScore.Text = Properties.Settings.Default.HighestScoreItems.ToString();
            }
        }

        /// <summary>
        /// 添加方块
        /// </summary>
        private void addCell()
        {
            if (cellAmount == 16)
            {
                var form = new GameOverDialog(this);   // gameover
                form.StartPosition = FormStartPosition.CenterScreen;
                form.ShowDialog();
            }
            else
            { 
                Random random = new Random();
                int indexX, indexY;

                Label cell = new Label();
                cell.Font = new System.Drawing.Font("杨任东竹石体-Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                cell.Size = new System.Drawing.Size(80, 80);
                cell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                cell.Name = "label" + "-" + cellIndex.ToString();
                cell.Click += cell_Click;

                // 随机得到2、4
                int labelNumber = random.Next(1, 3) * 2;
                cell.Text = labelNumber.ToString();
                if (labelNumber == 2)
                    cell.BackColor = Color.FromArgb(255, 141, 238, 238);
                else
                    cell.BackColor = Color.FromArgb(255, 118, 238, 198);

                // 随机得到位置
                do
                {
                    indexX = random.Next(1, 5);
                    indexY = random.Next(1, 5);
                } while (cells[indexX - 1, indexY - 1] != null);
                cells[indexX - 1, indexY - 1] = cell;
                int locationX = (indexX - 1) * 80 + 8 * indexX;
                int locationY = (indexY - 1) * 80 + 8 * indexY;
                cell.Location = new Point(locationX, locationY);

                cellIndex++;
                cellAmount++;

                panelGameArea.Controls.Add(cell);
                cell.BringToFront();


            }
        }

        /// <summary>
        /// 解决方向键不响应的问题
        /// </summary>
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Up || keyData == Keys.Down || keyData == Keys.Left || keyData == Keys.Right)
            {
                return false;
            }
            else
            {
                return base.ProcessDialogKey(keyData);
            }
        }

        /// <summary>
        /// 按下方向键的事件处理函数
        /// </summary>
        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {                 
            if (e.KeyCode == Keys.Left && isLeftEnabled && i == 0)
            {
                moveCells(Direction.Left);

                isLeftEnabled = false;
            }
            if (e.KeyCode == Keys.Right && isRightEnabled && i == 0)
            {
                moveCells(Direction.Right);

                isRightEnabled = false;
            }
            if (e.KeyCode == Keys.Up && isUpEnabled && i == 0)
            {
                moveCells(Direction.Up);

                isUpEnabled = false;
            }
            if (e.KeyCode == Keys.Down && isDownEnabled && i == 0)
            {
                moveCells(Direction.Down);

                isDownEnabled = false;
            }

        }

        /// <summary>
        /// 搭配keydown使用，为了防止连续按键出错，只能在上一次移动完成后才能进行下一次操作
        /// </summary>
        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                isLeftEnabled = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                isRightEnabled = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                isUpEnabled = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                isDownEnabled = true;
            }
        }
        
        /// <summary>
        /// 移动方块， 根据不同的移动方向确定遍历方块数组的顺序
        /// </summary>
        private void moveCells(Direction direction)
        {
            if (direction == Direction.Left)
            {
                moveDirection = Direction.Left;

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (cells[i, j] != null)
                        {
                            for (int k = 0; k < i; k++)
                            {
                                if (cells[k, j] == null)
                                {
                                    cellsToMove.Add(cells[i, j], i - k);
                                    cells[k, j] = cells[i, j];
                                    cells[i, j] = null;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            else if (direction == Direction.Right)
            {
                moveDirection = Direction.Right;

                for (int i = 3; i >= 0; i--)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (cells[i, j] != null)
                        {
                            for (int k = 3; k > i; k--)
                            {
                                if (cells[k, j] == null)
                                {
                                    cellsToMove.Add(cells[i, j], k - i);
                                    cells[k, j] = cells[i, j];
                                    cells[i, j] = null;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            else if (direction == Direction.Up)
            {
                moveDirection = Direction.Up;

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (cells[j, i] != null)
                        {
                            for (int k = 0; k < i; k++)
                            {
                                if (cells[j, k] == null)
                                {
                                    cellsToMove.Add(cells[j, i], i - k);
                                    cells[j, k] = cells[j, i];
                                    cells[j, i] = null;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            else if (direction == Direction.Down)
            {
                moveDirection = Direction.Down;

                for (int i = 3; i >= 0; i--)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (cells[j, i] != null)
                        {
                            for (int k = 3; k > i; k--)
                            {
                                if (cells[j, k] == null)
                                {
                                    cellsToMove.Add(cells[j, i], k - i);
                                    cells[j, k] = cells[j, i];
                                    cells[j, i] = null;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            timerForSlide.Enabled = true;
        }

        /// <summary>
        /// 配合movecells()使用，提供滑动效果。每次移动时钟 tick 11次
        /// </summary>
        private void timerForSlide_Tick(object sender, EventArgs e)
        {
            i++;

            if (moveDirection == Direction.Left)
            {
                Label cell;
                foreach (KeyValuePair<Label, int> item in cellsToMove)
                {
                    cell = item.Key;
                    cell.Location = new Point(cell.Location.X - 8 * item.Value, cell.Location.Y);
                }
            }
            else if (moveDirection == Direction.Right)
            {
                Label cell;
                foreach (KeyValuePair<Label, int> item in cellsToMove)
                {
                    cell = item.Key;
                    cell.Location = new Point(cell.Location.X + 8 * item.Value, cell.Location.Y);
                }
            }
            else if (moveDirection == Direction.Up)
            {
                Label cell;
                foreach (KeyValuePair<Label, int> item in cellsToMove)
                {
                    cell = item.Key;
                    cell.Location = new Point(cell.Location.X, cell.Location.Y - 8 * item.Value);
                }
            }
            else if (moveDirection == Direction.Down)
            {
                Label cell;
                foreach (KeyValuePair<Label, int> item in cellsToMove)
                {
                    cell = item.Key;
                    cell.Location = new Point(cell.Location.X, cell.Location.Y + 8 * item.Value);
                }
            }

            if (i == 11)
            {
                timerForSlide.Enabled = false;
                i = 0;
                cellsToMove.Clear();

                combineCells(moveDirection);
                addCell();
            }
        }

        /// <summary>
        /// 将相同数字的方块结合
        /// </summary>
        private void combineCells(Direction direction)
        {
            if (direction == Direction.Left)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (cells[i, j] != null && cells[i+1, j] != null && cells[i, j].Text == cells[i+1, j].Text)
                        {
                            cells[i, j].Text = (int.Parse(cells[i, j].Text) * 2).ToString();
                            panelGameArea.Controls.Remove(cells[i + 1, j]);
                            cells[i + 1, j] = null;
                            for (int k = i + 2; k < 4; k++)
                            {
                                if (cells[k, j] != null)
                                {
                                    cells[k, j].Location = new Point(cells[k, j].Location.X - 88, cells[k, j].Location.Y);
                                    cells[k - 1, j] = cells[k, j];
                                    cells[k, j] = null;
                                }
                            }
                            cellAmount--;
                            labelCurrentScore.Text = (int.Parse(labelCurrentScore.Text) + int.Parse(cells[i, j].Text) * magnification).ToString();
                            changeColor(cells[i, j], int.Parse(cells[i, j].Text));
                        }
                    }
                }
            }
            else if (direction == Direction.Right)
            {
                for (int i = 3; i > 0; i--)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (cells[i, j] != null && cells[i - 1, j] != null && cells[i, j].Text == cells[i - 1, j].Text)
                        {
                            cells[i, j].Text = (int.Parse(cells[i, j].Text) * 2).ToString();
                            panelGameArea.Controls.Remove(cells[i - 1, j]);
                            cells[i - 1, j] = null;
                            for (int k = i - 2; k >= 0; k--)
                            {
                               if (cells[k, j] != null)
                               {
	                               cells[k, j].Location = new Point(cells[k, j].Location.X + 88, cells[k, j].Location.Y);
	                               cells[k + 1, j] = cells[k, j];
	                               cells[k, j] = null;
                               }
                            }
                            cellAmount--;
                            labelCurrentScore.Text = (int.Parse(labelCurrentScore.Text) + int.Parse(cells[i, j].Text) * magnification).ToString();
                            changeColor(cells[i, j], int.Parse(cells[i, j].Text));
                        }
                    }
                }
            }
            else if (direction == Direction.Up)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                       if (cells[j, i] != null && cells[j, i + 1] != null && cells[j,i].Text == cells[j, i + 1].Text)
                        {
                            cells[j, i].Text = (int.Parse(cells[j, i].Text) * 2).ToString();
                            panelGameArea.Controls.Remove(cells[j, i + 1]);
                            cells[j, i + 1] = null;
                            for (int k = i + 2; k < 4; k++)
                            {
                                if (cells[j, k] != null)
                                {
	                                cells[j, k].Location = new Point(cells[j, k].Location.X, cells[j, k].Location.Y - 88);
	                                cells[j, k - 1] = cells[j, k];
	                                cells[j, k] = null;
                                }
                            }
                            cellAmount--;
                            labelCurrentScore.Text = (int.Parse(labelCurrentScore.Text) + int.Parse(cells[j, i].Text) * magnification).ToString();
                            changeColor(cells[j, i], int.Parse(cells[j, i].Text));
                        }
                    }
                }
            }
            else if (direction == Direction.Down)
            {
                for (int i = 3; i > 0; i--)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (cells[j, i] != null && cells[j, i - 1] != null && cells[j, i].Text == cells[j, i - 1].Text)
                        {
                            cells[j, i].Text = (int.Parse(cells[j, i].Text) * 2).ToString();
                            panelGameArea.Controls.Remove(cells[j, i - 1]);
                            cells[j, i - 1] = null;
                            for (int k = i - 2; k >= 0; k--)
                            {
                                if (cells[j, k] != null)
                                {
	                                cells[j, k].Location = new Point(cells[j, k].Location.X, cells[j, k].Location.Y + 88);
	                                cells[j, k + 1] = cells[j, k];
	                                cells[j, k] = null;
                                }
                            }
                            cellAmount--;
                            labelCurrentScore.Text = (int.Parse(labelCurrentScore.Text) + int.Parse(cells[j, i].Text) * magnification).ToString();
                            changeColor(cells[j, i], int.Parse(cells[j, i].Text));
                        }
                    }
                }
            }

            addItem();
        }

        /// <summary>
        /// combine后改变颜色
        /// </summary>
        private void changeColor(Label label, int score)
        {
            if (score == 4)
            {
                label.BackColor = Color.FromArgb(255, 118, 238, 198);
            }
            if (score == 8)
            {
                label.BackColor = Color.FromArgb(255, 102, 205, 170);
            }
            if (score == 16)
            {
                label.BackColor = Color.FromArgb(255, 69, 139, 116);
            }
            if (score == 32)
            {
                label.BackColor = Color.FromArgb(255, 193, 255, 193);
            }
            if (score == 64)
            {
                label.BackColor = Color.FromArgb(255, 151, 255, 255);
            }
            if (score == 128)
            {
                label.BackColor = Color.FromArgb(255, 105, 139, 105);
            }
            if (score == 256)
            {
                label.BackColor = Color.FromArgb(255, 192, 255, 62);
            }
            if (score == 512)
            {
                label.BackColor = Color.FromArgb(255, 105, 139, 34);
            }
            if (score == 1024)
            {
                label.BackColor = Color.FromArgb(255, 225, 246, 143);
            }
            if (score == 2048)
            {
                label.BackColor = Color.FromArgb(255, 139, 134, 78);
            }
            if (score == 4096)
            {
                label.BackColor = Color.FromArgb(255, 255, 64, 64);
            }
        }
        
        /// <summary>
        ///  添加道具
        /// </summary>
        private void addItem()
        {
            itemIndex++;
            if (itemIndex % 5 == 0 && flowLayoutItemPanel.Controls.Count < 3 && !isUsingItem)
            {
                Random random = new Random();
                int num = random.Next(0, 3);
                Button item = new Button();

                // *2 
                if (num == 0)
                {
                    item.BackColor = System.Drawing.Color.White;
                    item.FlatAppearance.BorderSize = 0;
                    item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    item.Image = Properties.Resources.x2;
                    item.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
                    item.Name = "item" + "-" + itemIndex.ToString();
                    item.Size = new System.Drawing.Size(37, 32);
                    item.TabIndex = 0;
                    item.UseVisualStyleBackColor = false;
                    item.Click += itemMultiply_Click;
                }
                // 转换
                else if (num == 1)
                {
                    item.BackColor = System.Drawing.Color.White;
                    item.FlatAppearance.BorderSize = 0;
                    item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    item.Image = Properties.Resources.swap;
                    item.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
                    item.Name = "item" + "-" + itemIndex.ToString();
                    item.Size = new System.Drawing.Size(37, 32);
                    item.TabIndex = 0;
                    item.UseVisualStyleBackColor = false;
                    item.Click += itemSwap_Click;
                }
                // 炸弹
                else if (num == 2)
                {
                    item.BackColor = System.Drawing.Color.White;
                    item.FlatAppearance.BorderSize = 0;
                    item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    item.Image = Properties.Resources.bomb;
                    item.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
                    item.Name = "item" + "-" + itemIndex.ToString();
                    item.Size = new System.Drawing.Size(37, 32);
                    item.TabIndex = 0;
                    item.UseVisualStyleBackColor = false;
                    item.Click += itemBomb_Click;
                }

                flowLayoutItemPanel.Controls.Add(item);
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            saveScore();

            isToTerminateProcess = false;
            this.Close();

            var form = new WelcomeForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void itemMultiply_Click(object sender, EventArgs e)
        {
            itemCategory = ItemCategory.Multiply;
            isUsingItem = true;

            magnification = 2;
            timerForMultiply.Enabled = true;
            labelMultiply.Visible = true;
            flowLayoutItemPanel.Enabled = false;
            pictureBoxLock.Visible = true;

            labelHintMessage.Text = hintForItemMultiply;
            labelHintMessage.ForeColor = Color.OrangeRed;

            flowLayoutItemPanel.Controls.Remove((Control)sender);
        }

        private void itemSwap_Click(object sender, EventArgs e)
        {
            itemCategory = ItemCategory.Swap;
            isUsingItem = true;
            itemToRemove = (Button)sender;

            flowLayoutItemPanel.Enabled = false;
            pictureBoxLock.Visible = true;
            panelGameArea.Enabled = true;
            labelDoubleClick.Visible = true;

            labelHintMessage.Text = hintForItemSwap;
            labelHintMessage.ForeColor = Color.OrangeRed;
        }

        private void itemBomb_Click(object sender, EventArgs e)
        {
            itemCategory = ItemCategory.Bomb;
            itemToRemove = (Button)sender;
            isUsingItem = true;

            flowLayoutItemPanel.Enabled = false;
            pictureBoxLock.Visible = true;
            panelGameArea.Enabled = true;
            labelDoubleClick.Visible = true;

            labelHintMessage.Text = hintForItemBomb;
            labelHintMessage.ForeColor = Color.OrangeRed;            
        }

        /// <summary>
        /// 取消道具的选定状态
        /// </summary>
        private void labelDoubleClick_DoubleClick(object sender, EventArgs e)
        {
            isUsingItem = false;
            flowLayoutItemPanel.Enabled = true;
            pictureBoxLock.Visible = false;
            panelGameArea.Enabled = false;

            changeHint();
            labelDoubleClick.Visible = false;
        }

        /// <summary>
        /// 配合swap道具和bomb道具使用
        /// </summary>
        private void cell_Click(object sender, EventArgs e)
        {
            if (itemCategory == ItemCategory.Swap)
            {
                if (clickIndex == 0)
                {
                    Label cell = (Label)sender;
                    cell.Font = new System.Drawing.Font("杨任东竹石体-Medium", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    cell.ForeColor = Color.White;

                    cellClicked = cell;
                    clickIndex = 1;
                }
                else if (clickIndex == 1)
                {
                    Label cell = (Label)sender;
                    Color color = cell.BackColor;
                    string text = cell.Text;

                    cell.BackColor = cellClicked.BackColor;
                    cell.Text = cellClicked.Text;
                    cellClicked.BackColor = color;
                    cellClicked.Text = text;
                    cellClicked.Font = new System.Drawing.Font("杨任东竹石体-Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

                    isUsingItem = false;
                    clickIndex = 0;
                    flowLayoutItemPanel.Enabled = true;
                    pictureBoxLock.Visible = false;
                    panelGameArea.Enabled = false;
                    flowLayoutItemPanel.Controls.Remove(itemToRemove);
                    changeHint();
                }
            }
            else if (itemCategory == ItemCategory.Bomb)
            {
                Label cell = (Label)sender;

                panelGameArea.Controls.Remove(cell);
                int indexX = (cell.Location.X + 80) / 88;
                int indexY = (cell.Location.Y + 80) / 88;
                cells[indexX - 1, indexY - 1] = null;
                cellAmount--;
                labelCurrentScore.Text = (int.Parse(labelCurrentScore.Text) + int.Parse(cell.Text)).ToString();

                isUsingItem = false;
                flowLayoutItemPanel.Enabled = true;
                pictureBoxLock.Visible = false;
                panelGameArea.Enabled = false;
                flowLayoutItemPanel.Controls.Remove(itemToRemove);
                changeHint();
            }
            labelDoubleClick.Visible = false;
        }

        private void changeHint()
        {
            if (gameMode == GameMode.General)
            {
                labelHintMessage.Text = generalModeHint;
            }
            else if (gameMode == GameMode.Wild)
            {
                labelHintMessage.Text = wildModeHint;
            }
            else if (gameMode == GameMode.Items)
            {
                labelHintMessage.Text = itemsModeHint;
            }
            labelHintMessage.ForeColor = Color.Black;

        }

        private void timerForMultiply_Tick(object sender, EventArgs e)
        {
            magnification = 1;
            timerForMultiply.Enabled = false;
            isUsingItem = false;
            labelMultiply.Visible = false;
            flowLayoutItemPanel.Enabled = true;
            pictureBoxLock.Visible = false;

            changeHint();

        }

        private void timerForWildMode_Tick(object sender, EventArgs e)
        {
            addCell();
        }

        private void saveScore()
        {
            if (gameMode == GameMode.General)
            {
                if (int.Parse(labelCurrentScore.Text) > Properties.Settings.Default.HighestScoreGeneral)
                {
                    Properties.Settings.Default.HighestScoreGeneral = int.Parse(labelCurrentScore.Text);
                }
            }
            else if (gameMode == GameMode.Wild)
            {
                if (int.Parse(labelCurrentScore.Text) > Properties.Settings.Default.HighestScoreWild)
                {
                    Properties.Settings.Default.HighestScoreWild = int.Parse(labelCurrentScore.Text);
                }
            }
            else if (gameMode == GameMode.Items)
            {
                if (int.Parse(labelCurrentScore.Text) > Properties.Settings.Default.HighestScoreItems)
                {
                    Properties.Settings.Default.HighestScoreItems = int.Parse(labelCurrentScore.Text);
                }
            }
            Properties.Settings.Default.Save();
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            saveScore();
            if (isToTerminateProcess)
            {
                System.Environment.Exit(0);

            }
        }

        private enum Direction{
            Left,
            Right,
            Up,
            Down
        }
        private enum ItemCategory
        {
            Multiply,
            Swap,
            Bomb
        }

        public static GameMode gameMode;
        private Direction moveDirection;
        private ItemCategory itemCategory;
        private Label cellClicked;         // 用于swap道具
        private Button itemToRemove;       // 用于移除道具控件

        private Label[,] cells = new Label[4, 4];
        private Dictionary<Label, int> cellsToMove = new Dictionary<Label, int>();

        private int i = 0;
        private int itemIndex = 0;         // 用于给道具命名
        private int clickIndex = 0;        // 用于swap道具
        private int cellIndex = 0;         // 用于给格子命名
        private int cellAmount = 0;        // 用于统计格子的数量
        private int magnification = 1;     // 用于 *2道具

        public static bool isToTerminateProcess = true;
        private bool isUsingItem = false;
        //配合keydown和keypress使用
        private bool isLeftEnabled = true;
        private bool isRightEnabled = true;
        private bool isUpEnabled = true;
        private bool isDownEnabled = true;

        string generalModeHint = "Use direction keys (up,down,left,right) to control the flow of all cells. When all grids are filled, you lose.";
        string wildModeHint = "In this mode, every 3 seconds a new cell will be added automaticly.";
        string hintForItemMultiply = "In next 10 seconds, the points you get will be multiplied.";
        string hintForItemSwap = "You can change the positions of two cells by touching them one by one.";
        string hintForItemBomb = "Remove one cell by touching it.";
        string itemsModeHint = "In this mode, you will obtain a random item every five steps";

    }
}
