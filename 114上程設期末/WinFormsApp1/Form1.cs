using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // 出拳列舉
        enum Choice
        {
            Rock,
            Paper,
            Scissors
        }

        Random random = new Random();

        Choice computerChoice;
        Choice playerChoice;

        int playerWinCount = 0;
        int computerWinCount = 0;

        public Form1()
        {
            InitializeComponent();
            // 若 Designer 未綁定 Load 事件，可在此確保綁定
            this.Load += Form1_Load;
        }

        // 表單初始化
        private void Form1_Load(object? sender, EventArgs e)
        {
            computerPictureBox.Image = null;
            playerPictureBox.Image = null;
            resultLabel.Text = "";
        }

        // ======================
        // 核心功能方法
        // ======================

        // 電腦隨機出拳
        private void getCompChoice()
        {
            computerChoice = (Choice)random.Next(0, 3);
        }

        // 顯示電腦圖片
        private void showComputerImage()
        {
            switch (computerChoice)
            {
                case Choice.Rock:
                    computerPictureBox.Image = Properties.Resources.石頭__2_;
                    break;
                case Choice.Paper:
                    computerPictureBox.Image = Properties.Resources.布;
                    break;
                case Choice.Scissors:
                    computerPictureBox.Image = Properties.Resources.剪刀;
                    break;
            }
        }

        // 顯示玩家圖片
        private void showPlayerImage()
        {
            switch (playerChoice)
            {
                case Choice.Rock:
                    playerPictureBox.Image = Properties.Resources.石頭__2_;
                    break;
                case Choice.Paper:
                    playerPictureBox.Image = Properties.Resources.布;
                    break;
                case Choice.Scissors:
                    playerPictureBox.Image = Properties.Resources.剪刀;
                    break;
            }
        }

        // 判斷勝負並計分
        private void showWinner()
        {
            if (playerChoice == computerChoice)
            {
                resultLabel.Text = "平手";
                return;
            }

            if ((playerChoice == Choice.Rock && computerChoice == Choice.Scissors) ||
                (playerChoice == Choice.Scissors && computerChoice == Choice.Paper) ||
                (playerChoice == Choice.Paper && computerChoice == Choice.Rock))
            {
                resultLabel.Text = "玩家贏";
                playerWinCount++;
            }
            else
            {
                resultLabel.Text = "電腦贏";
                computerWinCount++;
            }
        }

        // 共用回合流程
        private void playRound()
        {
            getCompChoice();
            showComputerImage();
            showPlayerImage();
            showWinner();
        }

        // ======================
        // 按鈕事件
        // ======================

        private void stoneButton_Click(object? sender, EventArgs e)
        {
            playerChoice = Choice.Rock;
            playRound();
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            playerChoice = Choice.Paper;
            playRound();
        }

        private void scissorButton_Click(object sender, EventArgs e)
        {
            playerChoice = Choice.Scissors;
            playRound();
        }

        private void exitButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                $"遊戲結束！\n\n玩家贏了 {playerWinCount} 次\n電腦贏了 {computerWinCount} 次",
                "遊戲統計",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            Application.Exit();
        }

        // ======================
        // 控制項事件
        // ======================

        // resultLabel 點擊事件
        private void resultLabel_Click(object sender, EventArgs e)
        {
            // 範例：點擊結果標籤顯示目前比分（可依需求修改或留空）
            MessageBox.Show($"目前比分\n玩家：{playerWinCount}\n電腦：{computerWinCount}", "比分", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
