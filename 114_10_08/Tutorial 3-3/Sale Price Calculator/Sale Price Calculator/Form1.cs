using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    // Form1 類別，代表主視窗表單
    public partial class Form1 : Form
    {
        // 建構函式：初始化表單元件
        public Form1()
        {
            InitializeComponent(); // 初始化所有視窗元件
        }

        // 當使用者點擊「計算折後價格」按鈕時觸發的事件處理函式
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 此處尚未實作計算邏輯
            decimal originalPrice;
            decimal discountPercentage;
            decimal salePrice;

            // 嘗試將使用者輸入的原價和折扣百分比轉換為 decimal 型別
            originalPrice = decimal.Parse(originalPriceTextBox.Text);
            discountPercentage = decimal.Parse(discountPercentageTextBox.Text);

            // 計算折後價格
            salePrice = originalPrice * (1 - discountPercentage / 100.0m);

            // 將計算結果顯示在 salePriceLabel 上，格式化為貨幣形式
            salePriceLabel.Text = salePrice.ToString("C");
        }

        // 當使用者點擊「離開」按鈕時觸發的事件處理函式
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單，結束程式
            this.Close();
        }

        // 當使用者點擊顯示折後價格的 Label 時觸發的事件處理函式
        private void salePriceLabel_Click(object sender, EventArgs e)
        {
            // 目前未有任何操作，通常 Label 不需要點擊事件
        }
    }
}
