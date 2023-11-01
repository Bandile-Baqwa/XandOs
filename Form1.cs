namespace XandOs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
        }

        //public enum Player
        //{
        //    X,
        //    O
        //}
        private Button[] buttons;

        private bool isPlayerTurn = true;

        private bool CheckForWinner(string symbol)
        {
            //this is to check the rows

            for (int i = 0; i < 3; i++)
            {
                if (buttons[i * 3].Text == symbol && buttons[i * 3 + 1].Text == symbol && buttons[i * 3 + 2].Text == symbol)
                    return true;
            }
            // this is to check thr columns
            for (int i = 0; i < 3; i++)
            {
                if (buttons[i].Text == symbol && buttons[i + 3].Text == symbol && buttons[i + 6].Text == symbol)
                    return true;
            }

            // this is to check for diaginals
            if (buttons[0].Text == symbol && buttons[4].Text == symbol && buttons[8].Text == symbol)
                return true;
            if (buttons[2].Text == symbol && buttons[4].Text == symbol && buttons[6].Text == symbol)
                return true;

            return false;
        }

        private void ComputerMove()
        {
            Random rand = new Random();
            int index;
            do
            {
                index = rand.Next(0, 9);
            } while (buttons[index].Text != "");

            buttons[index].Text = "O";
            isPlayerTurn = true;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }

        private void btnPvAI_Click(object sender, EventArgs e)
        {
            lblPTwo.Text = "AI";




        }

        private void btnPvP_Click(object sender, EventArgs e)
        {

        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {
            ResetGame();
            lblPTwo.Text = "Player 2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (isPlayerTurn && button.Text == "")
            {
                button.Text = "X";
                isPlayerTurn = false;

                if (CheckForWinner("X"))
                {
                    MessageBox.Show("You WIN!!");
                    ResetGame();
                    return;
                }
            }

            if (!isPlayerTurn)
            {
                ComputerMove();
                if (CheckForWinner("O"))
                {
                    MessageBox.Show("AI WINS !!!");
                    ResetGame();
                    return;
                }
            }


        }

        private void ResetGame()
        {
            foreach (Button button in buttons)
            {
                button.Text = "";
            }
            isPlayerTurn = true;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }

}