using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class frmBMI : Form
    {
        public frmBMI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            
            // 驗證輸入
            bool isHeightValid = double.TryParse(txtHeight.Text, out double height);
            bool isWeightValid = double.TryParse(txtWeight.Text, out double weight);
            bool isAgeValid = int.TryParse(txtAge.Text, out int age);

            if (!isHeightValid || height <= 0)
            {
                MessageBox.Show("身高輸入錯誤，請輸入大於 0 的有效數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }       

            if (!isWeightValid || weight <= 0)
            {
                MessageBox.Show("體重輸入錯誤，請輸入大於 0 的有效數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!isAgeValid || age <= 0)
            {
                MessageBox.Show("年齡輸入錯誤，請輸入大於 0 的有效數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 計算 BMI 和 BMR
            if (isHeightValid && isWeightValid && isAgeValid)
            {
                // 計算 BMR (Mifflin-St Jeor)
                double bmr = 10 * weight + 6.25 * height - 5 * age;
                bmr += rdoMale.Checked ? 5 : -161;
                lblBMRResult.Text = $"{bmr:F1} kcal";

                height /= 100;

                double bmi = weight / (height * height);
                // 根據 BMI 的值來決定結果
                string[] strResultList = { "體重過輕", "健康體位", "體位過重", "輕度肥胖", "中度肥胖", "重度肥胖" };
                Color[] colorList = { Color.Blue, Color.Green, Color.Orange, Color.DarkOrange, Color.Red, Color.Purple };

                string strResult = "";
                Color colorResult = Color.Black;
                int resultIndex = 0;
      
                if (bmi < 18.5)
                {
                    resultIndex = 0;
                }
                else if (bmi < 24)
                {
                    resultIndex = 1;
                }
                else if (bmi < 27)
                {
                    resultIndex = 2;
                }
                else if (bmi < 30)
                {
                    resultIndex = 3;
    }
                else if (bmi < 35)
                {
                    resultIndex = 4;
                }
                else
                {
                    resultIndex = 5;
                }
                // 根據結果索引來設定結果字串和顏色
                strResult = strResultList[resultIndex];
                colorResult = colorList[resultIndex];

                lblResult.Text = $"{bmi:F2}({strResult})";
                lblResult.BackColor = colorResult;
            }
            else
            {   // 如果輸入無效，顯示錯誤訊息
                MessageBox.Show("請輸入有效的數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }
    }
       
}
