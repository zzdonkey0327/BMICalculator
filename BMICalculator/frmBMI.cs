using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BMICalculator
{
    public partial class frmBMI : Form
    {
        public frmBMI()
        {
            InitializeComponent();
            // 程式啟動時載入預設值
            ResetForm();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // 取得輸入數值 (因為已經換成 NumericUpDown，保證是有效數字，不需 TryParse)
            double height = (double)numHeight.Value;
            double weight = (double)numWeight.Value;
            int age = (int)numAge.Value;

            // 基礎防呆：確保不是 0
            if (height <= 0 || weight <= 0 || age <= 0)
            {
                MessageBox.Show("身高、體重與年齡必須大於 0。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- 計算 BMR (Mifflin-St Jeor) ---
            double bmr = 10 * weight + 6.25 * height - 5 * age;
            bmr += rdoMale.Checked ? 5 : -161;
            lblBMRResult.Text = $"{bmr:F1} kcal";

            // --- 計算 BMI ---
            height /= 100; // 換算成公尺
            double bmi = weight / (height * height);

            // 根據 BMI 的值來決定結果 (保留您原本的陣列邏輯)
            string[] strResultList = { "體重過輕", "健康體位", "體位過重", "輕度肥胖", "中度肥胖", "重度肥胖" };
            Color[] colorList = { Color.Blue, Color.Green, Color.Orange, Color.DarkOrange, Color.Red, Color.Purple };

            int resultIndex = 0;
            if (bmi < 18.5) resultIndex = 0;
            else if (bmi < 24) resultIndex = 1;
            else if (bmi < 27) resultIndex = 2;
            else if (bmi < 30) resultIndex = 3;
            else if (bmi < 35) resultIndex = 4;
            else resultIndex = 5;

            // 根據結果索引來設定結果字串和顏色
            string strResult = strResultList[resultIndex];
            Color colorResult = colorList[resultIndex];

            lblResult.Text = $"{bmi:F2} ({strResult})";
            lblResult.BackColor = colorResult;
            lblResult.ForeColor = Color.White; // 確保文字在深色背景上夠清楚
        }

        // 新增：清除重設按鈕事件
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        // 新增：重設介面的獨立方法
        private void ResetForm()
        {
            numHeight.Value = 170m;
            numWeight.Value = 65m;
            numAge.Value = 25m;
            rdoMale.Checked = true;

            lblResult.Text = "";
            lblResult.BackColor = SystemColors.Control;
            lblBMRResult.Text = "";
        }
    }
}