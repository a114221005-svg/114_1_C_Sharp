using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者按下「計算」按鈕時執行此事件處理函式
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 宣告三個 double 變數，用來儲存三次測驗分數
            double test1, test2, test3;

            try
            {                 // 直接將三個文字方塊的內容轉換為 double 型別
                // 注意：若輸入非數值，程式會拋出例外
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);
            }
            catch (FormatException)
            {
                // 若輸入格式錯誤，顯示錯誤訊息並結束函式
                MessageBox.Show("請輸入有效的數值。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (OverflowException)
            {
                // 若輸入數值過大或過小，顯示錯誤訊息並結束函式
                MessageBox.Show("輸入的數值過大或過小。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // 直接將三個文字方塊的內容轉換為 double 型別
            // 注意：若輸入非數值，程式會拋出例外
            test1 = double.Parse(test1TextBox.Text);
            test2 = double.Parse(test2TextBox.Text);
            test3 = double.Parse(test3TextBox.Text);

                // 計算三個分數的平均值
            double average = (test1 + test2 + test3) / 3.0;

            // 將平均分數格式化為兩位小數，並顯示在 averageLabel 標籤上
            averageLabel.Text = average.ToString("n2");
        }
        Catch (Exception ex)
        {             // 捕捉其他未預期的例外，顯示錯誤訊息
            MessageBox.Show(ex.Message, " 例外發生 ");
        }



        // 當使用者按下「清除」按鈕時執行此事件處理函式
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空三個測驗分數的文字方塊及平均分數標籤
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
            //將游標焦點設回第一個輸入框
            test1TextBox.Focus();
        }

        // 當使用者按下「離開」按鈕時執行此事件處理函式
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單，結束程式
            this.Close();
        }
    }
}
