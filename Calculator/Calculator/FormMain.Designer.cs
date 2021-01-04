namespace Calculator
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.workNumBox = new System.Windows.Forms.TextBox();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.stateNum = new System.Windows.Forms.Label();
            this.statesList = new System.Windows.Forms.ListBox();
            this.undoButton = new System.Windows.Forms.Button();
            this.repeatButton = new System.Windows.Forms.Button();
            this.EmptyButton = new System.Windows.Forms.Button();
            this.numbersListBox = new System.Windows.Forms.ListBox();
            this.addNumber = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteLastButton = new System.Windows.Forms.Button();
            this.deleteAllButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Load = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.squareButton = new System.Windows.Forms.Button();
            this.powerNButton = new System.Windows.Forms.Button();
            this.logNButton = new System.Windows.Forms.Button();
            this.factButton = new System.Windows.Forms.Button();
            this.sqrtNButton = new System.Windows.Forms.Button();
            this.medianaButton = new System.Windows.Forms.Button();
            this.standartDeviationButton = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressTextLabel = new System.Windows.Forms.Label();
            this.loadBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // workNumBox
            // 
            this.workNumBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.workNumBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.workNumBox.CausesValidation = false;
            this.workNumBox.Location = new System.Drawing.Point(81, 27);
            this.workNumBox.Name = "workNumBox";
            this.workNumBox.Size = new System.Drawing.Size(100, 20);
            this.workNumBox.TabIndex = 0;
            this.workNumBox.Text = "0";
            this.workNumBox.TextChanged += new System.EventHandler(this.workNumBox_TextChanged);
            this.workNumBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.workNumBox_KeyPress);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.plusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plusButton.Location = new System.Drawing.Point(188, 63);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(64, 45);
            this.plusButton.TabIndex = 2;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.minusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minusButton.Location = new System.Drawing.Point(188, 114);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(64, 45);
            this.minusButton.TabIndex = 3;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.multiplyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiplyButton.Location = new System.Drawing.Point(188, 165);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(64, 45);
            this.multiplyButton.TabIndex = 4;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.divideButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divideButton.Location = new System.Drawing.Point(188, 216);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(64, 45);
            this.divideButton.TabIndex = 5;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = false;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // stateNum
            // 
            this.stateNum.AutoSize = true;
            this.stateNum.Location = new System.Drawing.Point(280, 42);
            this.stateNum.Name = "stateNum";
            this.stateNum.Size = new System.Drawing.Size(24, 13);
            this.stateNum.TabIndex = 6;
            this.stateNum.Text = "0/0";
            // 
            // statesList
            // 
            this.statesList.FormattingEnabled = true;
            this.statesList.Location = new System.Drawing.Point(283, 63);
            this.statesList.Name = "statesList";
            this.statesList.Size = new System.Drawing.Size(94, 199);
            this.statesList.TabIndex = 7;
            this.statesList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.statesList_MouseDoubleClick);
            // 
            // undoButton
            // 
            this.undoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.undoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.undoButton.Location = new System.Drawing.Point(0, 27);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(65, 29);
            this.undoButton.TabIndex = 8;
            this.undoButton.Text = "UnDo";
            this.undoButton.UseVisualStyleBackColor = false;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // repeatButton
            // 
            this.repeatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.repeatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.repeatButton.Location = new System.Drawing.Point(187, 24);
            this.repeatButton.Name = "repeatButton";
            this.repeatButton.Size = new System.Drawing.Size(65, 29);
            this.repeatButton.TabIndex = 9;
            this.repeatButton.Text = "Repeat";
            this.repeatButton.UseVisualStyleBackColor = false;
            this.repeatButton.Click += new System.EventHandler(this.repeatButton_Click);
            // 
            // EmptyButton
            // 
            this.EmptyButton.Location = new System.Drawing.Point(399, 12);
            this.EmptyButton.Name = "EmptyButton";
            this.EmptyButton.Size = new System.Drawing.Size(10, 10);
            this.EmptyButton.TabIndex = 10;
            this.EmptyButton.Text = "Original                        ";
            this.EmptyButton.UseVisualStyleBackColor = true;
            this.EmptyButton.Visible = false;
            // 
            // numbersListBox
            // 
            this.numbersListBox.FormattingEnabled = true;
            this.numbersListBox.Location = new System.Drawing.Point(0, 356);
            this.numbersListBox.Name = "numbersListBox";
            this.numbersListBox.Size = new System.Drawing.Size(386, 238);
            this.numbersListBox.TabIndex = 11;
            // 
            // addNumber
            // 
            this.addNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.addNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.addNumber.Location = new System.Drawing.Point(71, 318);
            this.addNumber.Name = "addNumber";
            this.addNumber.Size = new System.Drawing.Size(84, 20);
            this.addNumber.TabIndex = 12;
            this.addNumber.Text = "0";
            this.addNumber.TextChanged += new System.EventHandler(this.addNumber_TextChanged);
            this.addNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addNumber_KeyPress);
            this.addNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.addNumber_KeyUp);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Location = new System.Drawing.Point(0, 313);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(65, 29);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteLastButton
            // 
            this.deleteLastButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteLastButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteLastButton.Location = new System.Drawing.Point(172, 313);
            this.deleteLastButton.Name = "deleteLastButton";
            this.deleteLastButton.Size = new System.Drawing.Size(65, 29);
            this.deleteLastButton.TabIndex = 14;
            this.deleteLastButton.Text = "C";
            this.deleteLastButton.UseVisualStyleBackColor = false;
            this.deleteLastButton.Click += new System.EventHandler(this.deleteLastButton_Click);
            // 
            // deleteAllButton
            // 
            this.deleteAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteAllButton.Location = new System.Drawing.Point(243, 313);
            this.deleteAllButton.Name = "deleteAllButton";
            this.deleteAllButton.Size = new System.Drawing.Size(65, 29);
            this.deleteAllButton.TabIndex = 15;
            this.deleteAllButton.Text = "CE";
            this.deleteAllButton.UseVisualStyleBackColor = false;
            this.deleteAllButton.Click += new System.EventHandler(this.deleteAllButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(386, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Save,
            this.menu_Load});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menu_Save
            // 
            this.menu_Save.Name = "menu_Save";
            this.menu_Save.Size = new System.Drawing.Size(100, 22);
            this.menu_Save.Text = "Save";
            this.menu_Save.Click += new System.EventHandler(this.menu_Save_Click);
            // 
            // menu_Load
            // 
            this.menu_Load.Name = "menu_Load";
            this.menu_Load.Size = new System.Drawing.Size(100, 22);
            this.menu_Load.Text = "Load";
            this.menu_Load.Click += new System.EventHandler(this.menu_Load_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text files(*.txt)|*.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text files(*.txt)|*.txt";
            // 
            // squareButton
            // 
            this.squareButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.squareButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.squareButton.Location = new System.Drawing.Point(118, 63);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(64, 45);
            this.squareButton.TabIndex = 17;
            this.squareButton.Text = "sqrure";
            this.squareButton.UseVisualStyleBackColor = false;
            this.squareButton.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // powerNButton
            // 
            this.powerNButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.powerNButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.powerNButton.Location = new System.Drawing.Point(118, 114);
            this.powerNButton.Name = "powerNButton";
            this.powerNButton.Size = new System.Drawing.Size(64, 45);
            this.powerNButton.TabIndex = 18;
            this.powerNButton.Text = "powerN";
            this.powerNButton.UseVisualStyleBackColor = false;
            this.powerNButton.Click += new System.EventHandler(this.powerNButton_Click);
            // 
            // logNButton
            // 
            this.logNButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.logNButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logNButton.Location = new System.Drawing.Point(49, 63);
            this.logNButton.Name = "logNButton";
            this.logNButton.Size = new System.Drawing.Size(64, 45);
            this.logNButton.TabIndex = 19;
            this.logNButton.Text = "logN";
            this.logNButton.UseVisualStyleBackColor = false;
            this.logNButton.Click += new System.EventHandler(this.logNButton_Click);
            // 
            // factButton
            // 
            this.factButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.factButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.factButton.Location = new System.Drawing.Point(49, 114);
            this.factButton.Name = "factButton";
            this.factButton.Size = new System.Drawing.Size(64, 45);
            this.factButton.TabIndex = 20;
            this.factButton.Text = "fact";
            this.factButton.UseVisualStyleBackColor = false;
            this.factButton.Click += new System.EventHandler(this.factButton_Click);
            // 
            // sqrtNButton
            // 
            this.sqrtNButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sqrtNButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sqrtNButton.Location = new System.Drawing.Point(118, 165);
            this.sqrtNButton.Name = "sqrtNButton";
            this.sqrtNButton.Size = new System.Drawing.Size(64, 45);
            this.sqrtNButton.TabIndex = 21;
            this.sqrtNButton.Text = "sqrt";
            this.sqrtNButton.UseVisualStyleBackColor = false;
            this.sqrtNButton.Click += new System.EventHandler(this.sqrtButton_Click);
            // 
            // medianaButton
            // 
            this.medianaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.medianaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.medianaButton.Location = new System.Drawing.Point(49, 165);
            this.medianaButton.Name = "medianaButton";
            this.medianaButton.Size = new System.Drawing.Size(64, 45);
            this.medianaButton.TabIndex = 22;
            this.medianaButton.Text = "mediana";
            this.medianaButton.UseVisualStyleBackColor = false;
            this.medianaButton.Click += new System.EventHandler(this.medianaButton_Click);
            // 
            // standartDeviationButton
            // 
            this.standartDeviationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.standartDeviationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.standartDeviationButton.Location = new System.Drawing.Point(49, 217);
            this.standartDeviationButton.Name = "standartDeviationButton";
            this.standartDeviationButton.Size = new System.Drawing.Size(64, 45);
            this.standartDeviationButton.TabIndex = 23;
            this.standartDeviationButton.Text = "stDev";
            this.standartDeviationButton.UseVisualStyleBackColor = false;
            this.standartDeviationButton.Click += new System.EventHandler(this.standartDeviationButton_Click);
            // 
            // sqrtButton
            // 
            this.sqrtButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sqrtButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sqrtButton.Location = new System.Drawing.Point(118, 216);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(64, 45);
            this.sqrtButton.TabIndex = 24;
            this.sqrtButton.Text = "sqrtN";
            this.sqrtButton.UseVisualStyleBackColor = false;
            this.sqrtButton.Click += new System.EventHandler(this.sqrtNButton_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // progressTextLabel
            // 
            this.progressTextLabel.AutoSize = true;
            this.progressTextLabel.Location = new System.Drawing.Point(146, 213);
            this.progressTextLabel.Name = "progressTextLabel";
            this.progressTextLabel.Size = new System.Drawing.Size(0, 13);
            this.progressTextLabel.TabIndex = 26;
            // 
            // loadBackgroundWorker
            // 
            this.loadBackgroundWorker.WorkerReportsProgress = true;
            this.loadBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadBackgroundWorker_DoWork);
            this.loadBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.loadBackgroundWorker_ProgressChanged);
            this.loadBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.loadBackgroundWorker_RunWorkerCompleted);
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.progressBar.Location = new System.Drawing.Point(0, 283);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(386, 19);
            this.progressBar.TabIndex = 27;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(311, 315);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 28;
            this.button.Text = "button";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(386, 592);
            this.Controls.Add(this.button);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.progressTextLabel);
            this.Controls.Add(this.sqrtButton);
            this.Controls.Add(this.standartDeviationButton);
            this.Controls.Add(this.medianaButton);
            this.Controls.Add(this.sqrtNButton);
            this.Controls.Add(this.factButton);
            this.Controls.Add(this.logNButton);
            this.Controls.Add(this.powerNButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.deleteAllButton);
            this.Controls.Add(this.deleteLastButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addNumber);
            this.Controls.Add(this.numbersListBox);
            this.Controls.Add(this.EmptyButton);
            this.Controls.Add(this.repeatButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.statesList);
            this.Controls.Add(this.stateNum);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.workNumBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox workNumBox;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Label stateNum;
        private System.Windows.Forms.ListBox statesList;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button repeatButton;
        private System.Windows.Forms.Button EmptyButton;
        private System.Windows.Forms.ListBox numbersListBox;
        private System.Windows.Forms.TextBox addNumber;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteLastButton;
        private System.Windows.Forms.Button deleteAllButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_Save;
        private System.Windows.Forms.ToolStripMenuItem menu_Load;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button powerNButton;
        private System.Windows.Forms.Button logNButton;
        private System.Windows.Forms.Button factButton;
        private System.Windows.Forms.Button sqrtNButton;
        private System.Windows.Forms.Button medianaButton;
        private System.Windows.Forms.Button standartDeviationButton;
        private System.Windows.Forms.Button sqrtButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label progressTextLabel;
        private System.ComponentModel.BackgroundWorker loadBackgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button button;
    }
}

