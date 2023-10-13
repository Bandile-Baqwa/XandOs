namespace XandOs
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            lblPlayerTurn = new Label();
            btnResetGame = new Button();
            lblPOne = new Label();
            lblPTwo = new Label();
            timer = new System.Windows.Forms.Timer(components);
            btnPvAI = new Button();
            btnPvP = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(51, 37);
            button1.Name = "button1";
            button1.Size = new Size(81, 68);
            button1.TabIndex = 0;
            button1.Tag = "field";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseClick += button1_MouseClick;
            // 
            // button2
            // 
            button2.Location = new Point(136, 37);
            button2.Name = "button2";
            button2.Size = new Size(81, 68);
            button2.TabIndex = 1;
            button2.Tag = "field";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            button2.MouseClick += button1_MouseClick;
            // 
            // button3
            // 
            button3.Location = new Point(221, 37);
            button3.Name = "button3";
            button3.Size = new Size(81, 68);
            button3.TabIndex = 2;
            button3.Tag = "field";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            button3.MouseClick += button1_MouseClick;
            // 
            // button4
            // 
            button4.Location = new Point(51, 112);
            button4.Name = "button4";
            button4.Size = new Size(81, 68);
            button4.TabIndex = 3;
            button4.Tag = "field";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            button4.MouseClick += button1_MouseClick;
            // 
            // button5
            // 
            button5.Location = new Point(136, 112);
            button5.Name = "button5";
            button5.Size = new Size(81, 68);
            button5.TabIndex = 4;
            button5.Tag = "field";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button1_Click;
            button5.MouseClick += button1_MouseClick;
            // 
            // button6
            // 
            button6.Location = new Point(221, 112);
            button6.Name = "button6";
            button6.Size = new Size(81, 68);
            button6.TabIndex = 5;
            button6.Tag = "field";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button1_Click;
            button6.MouseClick += button1_MouseClick;
            // 
            // button7
            // 
            button7.Location = new Point(51, 185);
            button7.Name = "button7";
            button7.Size = new Size(81, 68);
            button7.TabIndex = 6;
            button7.Tag = "field";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button1_Click;
            button7.MouseClick += button1_MouseClick;
            // 
            // button8
            // 
            button8.Location = new Point(136, 185);
            button8.Name = "button8";
            button8.Size = new Size(81, 68);
            button8.TabIndex = 7;
            button8.Tag = "field";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button1_Click;
            button8.MouseClick += button1_MouseClick;
            // 
            // button9
            // 
            button9.Location = new Point(221, 185);
            button9.Name = "button9";
            button9.Size = new Size(81, 68);
            button9.TabIndex = 8;
            button9.Tag = "field";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button1_Click;
            button9.MouseClick += button1_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(351, 37);
            label1.Name = "label1";
            label1.Size = new Size(112, 39);
            label1.TabIndex = 9;
            label1.Text = "Players";
            label1.Click += label1_Click;
            // 
            // lblPlayerTurn
            // 
            lblPlayerTurn.AutoSize = true;
            lblPlayerTurn.Location = new Point(374, 90);
            lblPlayerTurn.Name = "lblPlayerTurn";
            lblPlayerTurn.Size = new Size(0, 15);
            lblPlayerTurn.TabIndex = 10;
            // 
            // btnResetGame
            // 
            btnResetGame.Location = new Point(358, 185);
            btnResetGame.Name = "btnResetGame";
            btnResetGame.Size = new Size(90, 23);
            btnResetGame.TabIndex = 11;
            btnResetGame.Text = "Reset Game";
            btnResetGame.UseVisualStyleBackColor = true;
            btnResetGame.Click += btnResetGame_Click;
            // 
            // lblPOne
            // 
            lblPOne.AutoSize = true;
            lblPOne.Location = new Point(338, 118);
            lblPOne.Name = "lblPOne";
            lblPOne.Size = new Size(48, 15);
            lblPOne.TabIndex = 13;
            lblPOne.Text = "Player 1";
            lblPOne.Click += label3_Click;
            // 
            // lblPTwo
            // 
            lblPTwo.AutoSize = true;
            lblPTwo.Location = new Point(415, 118);
            lblPTwo.Name = "lblPTwo";
            lblPTwo.Size = new Size(48, 15);
            lblPTwo.TabIndex = 14;
            lblPTwo.Text = "Player 2";
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // btnPvAI
            // 
            btnPvAI.Location = new Point(415, 261);
            btnPvAI.Name = "btnPvAI";
            btnPvAI.Size = new Size(57, 23);
            btnPvAI.TabIndex = 15;
            btnPvAI.Text = "PvAI";
            btnPvAI.UseVisualStyleBackColor = true;
            btnPvAI.Click += btnPvAI_Click;
            // 
            // btnPvP
            // 
            btnPvP.Location = new Point(317, 261);
            btnPvP.Name = "btnPvP";
            btnPvP.Size = new Size(57, 23);
            btnPvP.TabIndex = 16;
            btnPvP.Text = "PvP";
            btnPvP.UseVisualStyleBackColor = true;
            btnPvP.Click += btnPvP_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 294);
            Controls.Add(btnPvP);
            Controls.Add(btnPvAI);
            Controls.Add(lblPTwo);
            Controls.Add(lblPOne);
            Controls.Add(btnResetGame);
            Controls.Add(lblPlayerTurn);
            Controls.Add(label1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "X and Os";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
        private Label lblPlayerTurn;
        private Button btnResetGame;
        private Label lblPOne;
        private Label lblPTwo;
        private System.Windows.Forms.Timer timer;
        private Button btnPvAI;
        private Button btnPvP;
    }
}