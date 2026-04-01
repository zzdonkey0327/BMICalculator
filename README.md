# BMI計算機
# BMI & BMR 計算機 (Health Calculator)

## 專案簡介
這是一個使用 C# Windows Forms 開發的輕量級桌面應用程式。旨在幫助使用者快速、準確地計算**身體質量指數 (BMI)** 與**基礎代謝率 (BMR)**。

本專案具備現代化的扁平化使用者介面 (UI)，並內建完善的防呆機制，確保使用者能獲得流暢且直覺的操作體驗。計算結果會根據衛福部的標準，透過不同的顏色直覺地顯示使用者的健康體位。

### 功能特色
* **BMI 計算與體位判定**：自動計算 BMI 數值，並依據標準顯示「體重過輕、健康體位、體位過重、輕度/中度/重度肥胖」，同時搭配顏色視覺回饋。
* **BMR 基礎代謝率計算**：採用精確的 Mifflin-St Jeor 公式，依據性別、年齡、身高、體重計算每日所需的基础代謝卡路里。
* **輸入防呆機制**：全面採用 `NumericUpDown` 控制項，從根本杜絕英文字母或特殊符號等無效輸入，提升程式穩定性。
* **快捷操作**：支援鍵盤 `Enter` 鍵直接執行計算，並提供一鍵「清除重填」功能。

---

## 執行說明

### 開發環境與依賴
* **開發工具**：Visual Studio 2026
* **框架**：.NET Framework / .NET (Windows Forms)
* **作業系統**：Windows 11

### 操作方式
1. 輸入您的身高 (cm)、體重 (kg)、年齡，並選擇性別。
2. 點擊「開始計算」或按 Enter 即可查看健康數據。
3. 可以直接點選「清除重填」開始下一次的計算。
<img width="608" height="724" alt="image" src="https://github.com/user-attachments/assets/34114172-b1c9-4c7c-b87d-48010d9571e7" />
<img width="608" height="724" alt="image" src="https://github.com/user-attachments/assets/34114172-b1c9-4c7c-b87d-48010d9571e7" />


