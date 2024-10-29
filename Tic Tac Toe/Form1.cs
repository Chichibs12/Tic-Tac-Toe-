namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public enum Player
        {
            X,
            O
        }

        Player currentPlayer;
        Random rand = new Random();
        int playerWin = 0;
        int cpuWin = 0;
        List<Button> buttons;


        public Form1()
        {
            InitializeComponent();
            restartGame();
        }

        private void playerClickBtn(object sender, EventArgs e)
        {
            var button = (Button)sender;

            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.LightCyan;
            buttons.Remove(button);
            checkGame();
            CPUTimer.Start();

        }

        private void cpuMove(object sender, EventArgs e)
        {
            if(buttons.Count> 0)
            {
                int index = rand.Next(0, buttons.Count);
                buttons[index].Enabled = false;
                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.LightSalmon; 
                buttons.RemoveAt(index);
                checkGame();
                CPUTimer.Stop();
            }
        }

        private void restartGame(object sender, EventArgs e)
        {
            restartGame();
        }
        private void checkGame()
        {
            if (cell1.Text == "X" && cell2.Text == "X" && cell3.Text == "X"
                || cell4.Text == "X" && cell5.Text == "X" && cell6.Text == "X"
                || cell7.Text == "X" && cell8.Text == "X" && cell9.Text == "X"
                || cell1.Text == "X" && cell4.Text == "X" && cell7.Text == "X"
                || cell2.Text == "X" && cell5.Text == "X" && cell8.Text == "X"
                || cell3.Text == "X" && cell6.Text == "X" && cell9.Text == "X"
                || cell1.Text == "X" && cell5.Text == "X" && cell9.Text == "X"
                || cell3.Text == "X" && cell5.Text == "X" && cell7.Text == "X")
            {
                CPUTimer.Stop();
                MessageBox.Show("PLAYER WINS!!!");
                playerWin++;
                playerWins.Text = "Player: " + playerWin;
                restartGame();
            }
            else if (cell1.Text == "O" && cell2.Text == "O" && cell3.Text == "O"
                || cell4.Text == "O" && cell5.Text == "O" && cell6.Text == "O"
                || cell7.Text == "O" && cell8.Text == "O" && cell9.Text == "O"
                || cell1.Text == "O" && cell4.Text == "O" && cell7.Text == "O"
                || cell2.Text == "O" && cell5.Text == "O" && cell8.Text == "O"
                || cell3.Text == "O" && cell6.Text == "O" && cell9.Text == "O"
                || cell1.Text == "O" && cell5.Text == "O" && cell9.Text == "O"
                || cell3.Text == "O" && cell5.Text == "O" && cell7.Text == "O")
            {
                CPUTimer.Stop();
                MessageBox.Show("CPU WINS!!!");
                cpuWin++;
                cpuWins.Text = "CPU: " + cpuWin;
                restartGame();
            }

        }
        private void restartGame()
        {
            buttons = new List<Button> { cell1, cell2, cell3, cell4, cell5, cell6, cell7, cell8, cell9 };

            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = "?";
                x.BackColor = DefaultBackColor;
            }
        }
    }
}
