namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            playerWins = new Label();
            cpuWins = new Label();
            cell1 = new Button();
            cell2 = new Button();
            cell3 = new Button();
            cell4 = new Button();
            cell5 = new Button();
            cell6 = new Button();
            cell7 = new Button();
            cell8 = new Button();
            cell9 = new Button();
            restart = new Button();
            CPUTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // playerWins
            // 
            playerWins.AutoSize = true;
            playerWins.BackColor = Color.Transparent;
            playerWins.Font = new Font("Segoe Script", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            playerWins.ForeColor = Color.DarkBlue;
            playerWins.Location = new Point(12, 9);
            playerWins.Name = "playerWins";
            playerWins.Size = new Size(91, 32);
            playerWins.TabIndex = 0;
            playerWins.Text = "Player:";
            // 
            // cpuWins
            // 
            cpuWins.AutoSize = true;
            cpuWins.BackColor = Color.Transparent;
            cpuWins.Font = new Font("Segoe Script", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cpuWins.ForeColor = Color.DarkSlateGray;
            cpuWins.Location = new Point(294, 9);
            cpuWins.Name = "cpuWins";
            cpuWins.Size = new Size(64, 32);
            cpuWins.TabIndex = 1;
            cpuWins.Text = "CPU:";
            // 
            // cell1
            // 
            cell1.Font = new Font("Segoe Script", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cell1.Location = new Point(12, 53);
            cell1.Name = "cell1";
            cell1.Size = new Size(110, 106);
            cell1.TabIndex = 2;
            cell1.Text = "?";
            cell1.UseVisualStyleBackColor = true;
            cell1.Click += playerClickBtn;
            // 
            // cell2
            // 
            cell2.Font = new Font("Segoe Script", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cell2.Location = new Point(132, 53);
            cell2.Name = "cell2";
            cell2.Size = new Size(110, 106);
            cell2.TabIndex = 3;
            cell2.Text = "?";
            cell2.UseVisualStyleBackColor = true;
            cell2.Click += playerClickBtn;
            // 
            // cell3
            // 
            cell3.Font = new Font("Segoe Script", 24F);
            cell3.Location = new Point(248, 53);
            cell3.Name = "cell3";
            cell3.Size = new Size(110, 106);
            cell3.TabIndex = 4;
            cell3.Text = "?";
            cell3.UseVisualStyleBackColor = true;
            cell3.Click += playerClickBtn;
            // 
            // cell4
            // 
            cell4.Font = new Font("Segoe Script", 24F);
            cell4.Location = new Point(16, 165);
            cell4.Name = "cell4";
            cell4.Size = new Size(110, 106);
            cell4.TabIndex = 5;
            cell4.Text = "?";
            cell4.UseVisualStyleBackColor = true;
            cell4.Click += playerClickBtn;
            // 
            // cell5
            // 
            cell5.Font = new Font("Segoe Script", 24F);
            cell5.Location = new Point(132, 165);
            cell5.Name = "cell5";
            cell5.Size = new Size(110, 106);
            cell5.TabIndex = 6;
            cell5.Text = "?";
            cell5.UseVisualStyleBackColor = true;
            cell5.Click += playerClickBtn;
            // 
            // cell6
            // 
            cell6.Font = new Font("Segoe Script", 24F);
            cell6.Location = new Point(248, 165);
            cell6.Name = "cell6";
            cell6.Size = new Size(110, 106);
            cell6.TabIndex = 7;
            cell6.Text = "?";
            cell6.UseVisualStyleBackColor = true;
            cell6.Click += playerClickBtn;
            // 
            // cell7
            // 
            cell7.Font = new Font("Segoe Script", 24F);
            cell7.Location = new Point(16, 277);
            cell7.Name = "cell7";
            cell7.Size = new Size(110, 106);
            cell7.TabIndex = 8;
            cell7.Text = "?";
            cell7.UseVisualStyleBackColor = true;
            cell7.Click += playerClickBtn;
            // 
            // cell8
            // 
            cell8.Font = new Font("Segoe Script", 24F);
            cell8.Location = new Point(132, 277);
            cell8.Name = "cell8";
            cell8.Size = new Size(110, 106);
            cell8.TabIndex = 9;
            cell8.Text = "?";
            cell8.UseVisualStyleBackColor = true;
            cell8.Click += playerClickBtn;
            // 
            // cell9
            // 
            cell9.Font = new Font("Segoe Script", 24F);
            cell9.Location = new Point(248, 277);
            cell9.Name = "cell9";
            cell9.Size = new Size(110, 106);
            cell9.TabIndex = 10;
            cell9.Text = "?";
            cell9.UseVisualStyleBackColor = true;
            cell9.Click += playerClickBtn;
            // 
            // restart
            // 
            restart.Font = new Font("Segoe Script", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            restart.Location = new Point(83, 414);
            restart.Name = "restart";
            restart.Size = new Size(211, 42);
            restart.TabIndex = 11;
            restart.Text = "Restart";
            restart.UseVisualStyleBackColor = true;
            restart.Click += restartGame;
            // 
            // CPUTimer
            // 
            CPUTimer.Interval = 1000;
            CPUTimer.Tick += cpuMove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 499);
            Controls.Add(restart);
            Controls.Add(cell9);
            Controls.Add(cell8);
            Controls.Add(cell7);
            Controls.Add(cell6);
            Controls.Add(cell5);
            Controls.Add(cell4);
            Controls.Add(cell3);
            Controls.Add(cell2);
            Controls.Add(cell1);
            Controls.Add(cpuWins);
            Controls.Add(playerWins);
            Name = "Form1";
            Text = "Tic Tac Toe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label playerWins;
        private Label cpuWins;
        private Button cell1;
        private Button cell2;
        private Button cell3;
        private Button cell4;
        private Button cell5;
        private Button cell6;
        private Button cell7;
        private Button cell8;
        private Button cell9;
        private System.Windows.Forms.Timer CPUTimer;
        private Button restart;
    }
}
