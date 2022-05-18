using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToeTeacher
{
    public partial class Form1 : Form
    {
        private enum WinStatus
        {
            Tie, 
            X,
            O,
        }

        private int _formX, _formY;
        private bool XTurn = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void WindowButton_MouseClick(object sender, MouseEventArgs e)
        {
            switch (((Control)sender).Tag)
            {
                case "Close":
                    Application.Exit();
                    break;
                case "Minimize":
                    this.WindowState = FormWindowState.Minimized;
                    break;
            }
        }

        private void WindowButton_MouseEnter(object sender, EventArgs e)
        {
            switch (((Control)sender).Tag)
            {
                case "Close":
                    CloseButton.BackgroundImage = Properties.Resources.CloseWindow_Hovered;
                    break;
                case "Minimize":
                    MinimizeButton.BackgroundImage = Properties.Resources.Minimize_Hovered;
                    break;
            }
        }

        private void WindowButton_MouseLeave(object sender, EventArgs e)
        {
            switch (((Control)sender).Tag)
            {
                case "Close":
                    CloseButton.BackgroundImage = Properties.Resources.CloseWindow_Night;
                    break;
                case "Minimize":
                    MinimizeButton.BackgroundImage = Properties.Resources.Minimize_Night;
                    break;
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _formX = Cursor.Position.X - this.Location.X;
                _formY = Cursor.Position.Y - this.Location.Y;
                MoveWindow.Start();
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            MoveWindow.Stop();
        }

        private void TicTacToeButton_MouseClick(object sender, MouseEventArgs e)
        {
            UI.TicTacToePanel SelectedTile = (UI.TicTacToePanel)sender;
            SelectedTile.CurrentState = XTurn ? UI.TicTacToePanel.TicTacToeState.X : UI.TicTacToePanel.TicTacToeState.O;
            SelectedTile.Enabled = false;
            XTurn = !XTurn;
            CheckCorrectAnswers();
        }

        public void ResetGame()
        {
            Row1Tile1.CurrentState = UI.TicTacToePanel.TicTacToeState.None;
            Row1Tile1.Enabled = true;
            Row1Tile2.CurrentState = UI.TicTacToePanel.TicTacToeState.None;
            Row1Tile2.Enabled = true;
            Row1Tile3.CurrentState = UI.TicTacToePanel.TicTacToeState.None;
            Row1Tile3.Enabled = true;

            Row2Tile1.CurrentState = UI.TicTacToePanel.TicTacToeState.None;
            Row2Tile1.Enabled = true;
            Row2Tile2.CurrentState = UI.TicTacToePanel.TicTacToeState.None;
            Row2Tile2.Enabled = true;
            Row2Tile3.CurrentState = UI.TicTacToePanel.TicTacToeState.None;
            Row2Tile3.Enabled = true;

            Row3Tile1.CurrentState = UI.TicTacToePanel.TicTacToeState.None;
            Row3Tile1.Enabled = true;
            Row3Tile2.CurrentState = UI.TicTacToePanel.TicTacToeState.None;
            Row3Tile2.Enabled = true;
            Row3Tile3.CurrentState = UI.TicTacToePanel.TicTacToeState.None;
            Row3Tile3.Enabled = true;

            XTurn = true;
            TicTacToeEndPanel1.Hide();
        }

        private void EndGame(WinStatus winner)
        {
            Row1Tile1.Enabled = false;
            Row1Tile2.Enabled = false;
            Row1Tile3.Enabled = false;

            Row2Tile1.Enabled = false;
            Row2Tile2.Enabled = false;
            Row2Tile3.Enabled = false;

            Row3Tile1.Enabled = false;
            Row3Tile2.Enabled = false;
            Row3Tile3.Enabled = false;
            TicTacToeEndPanel1.Show();
            switch(winner)
            {
                case WinStatus.Tie:
                    WinningText.Text = "Tie!";
                    break;
                case WinStatus.X:
                    WinningText.Text = "Winner: ✖!";
                    break;
                case WinStatus.O:
                    WinningText.Text = "Winner: O!";
                    break;
            }
        }

        public void CheckCorrectAnswers()
        {
            #region VerticalChecks
            if (Row1Tile1.CurrentState == Row1Tile2.CurrentState && Row1Tile2.CurrentState == Row1Tile3.CurrentState)
            {
                if (Row1Tile1.CurrentState == UI.TicTacToePanel.TicTacToeState.O)
                {
                    ScorePanelPlayer2.Score++;
                    EndGame(WinStatus.O);
                }
                else if (Row1Tile1.CurrentState == UI.TicTacToePanel.TicTacToeState.X)
                {
                    ScorePanelPlayer1.Score++;
                    EndGame(WinStatus.X);
                }
            }
            else if (Row2Tile1.CurrentState == Row2Tile2.CurrentState && Row2Tile2.CurrentState == Row2Tile3.CurrentState)
            {
                if (Row2Tile1.CurrentState == UI.TicTacToePanel.TicTacToeState.O)
                {
                    ScorePanelPlayer2.Score++;
                    EndGame(WinStatus.O);
                }
                else if (Row2Tile1.CurrentState == UI.TicTacToePanel.TicTacToeState.X)
                {
                    ScorePanelPlayer1.Score++;
                    EndGame(WinStatus.X);
                }
            }
            else if (Row3Tile1.CurrentState == Row3Tile2.CurrentState && Row3Tile2.CurrentState == Row3Tile3.CurrentState)
            {
                if (Row3Tile1.CurrentState == UI.TicTacToePanel.TicTacToeState.O)
                {
                    ScorePanelPlayer2.Score++;
                    EndGame(WinStatus.O);
                }
                else if (Row3Tile1.CurrentState == UI.TicTacToePanel.TicTacToeState.X)
                {
                    ScorePanelPlayer1.Score++;
                    EndGame(WinStatus.X);
                }
            }
            #endregion
            #region HorizontalChecks
            if (Row1Tile1.CurrentState == Row2Tile1.CurrentState && Row2Tile1.CurrentState == Row3Tile1.CurrentState)
            {
                if (Row1Tile1.CurrentState == UI.TicTacToePanel.TicTacToeState.O)
                {
                    ScorePanelPlayer2.Score++;
                    EndGame(WinStatus.O);
                }
                else if (Row1Tile1.CurrentState == UI.TicTacToePanel.TicTacToeState.X)
                {
                    ScorePanelPlayer1.Score++;
                    EndGame(WinStatus.X);
                }
            }
            else if (Row1Tile2.CurrentState == Row2Tile2.CurrentState && Row2Tile2.CurrentState == Row3Tile2.CurrentState)
            {
                if (Row1Tile2.CurrentState == UI.TicTacToePanel.TicTacToeState.O)
                {
                    ScorePanelPlayer2.Score++;
                    EndGame(WinStatus.O);
                }
                else if (Row1Tile2.CurrentState == UI.TicTacToePanel.TicTacToeState.X)
                {
                    ScorePanelPlayer1.Score++;
                    EndGame(WinStatus.X);
                }
            }
            else if (Row1Tile3.CurrentState == Row2Tile3.CurrentState && Row2Tile3.CurrentState == Row3Tile3.CurrentState)
            {
                if (Row1Tile3.CurrentState == UI.TicTacToePanel.TicTacToeState.O)
                {
                    ScorePanelPlayer2.Score++;
                    EndGame(WinStatus.O);
                }
                else if (Row1Tile3.CurrentState == UI.TicTacToePanel.TicTacToeState.X)
                {
                    ScorePanelPlayer1.Score++;
                    EndGame(WinStatus.X);
                }
            }
            #endregion
            #region OtherChecks
            if (Row1Tile1.CurrentState == Row2Tile2.CurrentState && Row2Tile2.CurrentState == Row3Tile3.CurrentState)
            {
                if (Row1Tile1.CurrentState == UI.TicTacToePanel.TicTacToeState.O)
                {
                    ScorePanelPlayer2.Score++;
                    EndGame(WinStatus.O);
                }
                else if (Row1Tile1.CurrentState == UI.TicTacToePanel.TicTacToeState.X)
                {
                    ScorePanelPlayer1.Score++;
                    EndGame(WinStatus.X);
                }
            }
            else if (Row3Tile1.CurrentState == Row2Tile2.CurrentState && Row2Tile2.CurrentState == Row1Tile3.CurrentState)
            {
                if (Row3Tile1.CurrentState == UI.TicTacToePanel.TicTacToeState.O)
                {
                    ScorePanelPlayer2.Score++;
                    EndGame(WinStatus.O);
                }
                else if (Row3Tile1.CurrentState == UI.TicTacToePanel.TicTacToeState.X)
                {
                    ScorePanelPlayer1.Score++;
                    EndGame(WinStatus.X);
                }
            }
            else
            {
                bool NoTilesLeft = true;
                foreach (Control tile in this.Controls)
                {
                    if (tile.Tag?.ToString() == "tile")
                    {
                        if (((UI.TicTacToePanel)tile).CurrentState == UI.TicTacToePanel.TicTacToeState.None)
                        {
                            NoTilesLeft = false;
                            break;
                        }
                    }
                }
                if (NoTilesLeft)
                    EndGame(WinStatus.Tie);
            }
            #endregion
        }

        private void PlayAgainButton_MouseClick(object sender, MouseEventArgs e)
        {
            ResetGame();
        }

        private void ExitButton_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ExitButton.Refresh();
            PlayAgainButton.Refresh();
        }

        private void MoveWindow_Tick(object sender, EventArgs e)
        {
            this.Location = new Point(Cursor.Position.X - _formX, Cursor.Position.Y - _formY);
        }
    }
}
