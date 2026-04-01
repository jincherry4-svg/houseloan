namespace houseloan
{
    public partial class houseloan : Form
    {
        public houseloan()
        {
            InitializeComponent();
        }

        private void btncount_Click(object sender, EventArgs e)
        {
            try
            {
                // --- 1. 讀取基礎輸入 ---
                double housePrice = double.Parse(tbtotalprice.Text);
                double downPaymentInput = double.Parse(tbselfprice.Text); // 使用者輸入的那個數值
                double annualRate = double.Parse(tbrate.Text);
                int years = int.Parse(tbloanterm.Text);
                int graceYears = string.IsNullOrEmpty(tbgrace.Text) ? 0 : int.Parse(tbgrace.Text);

                // --- 2. 處理自備款與貸款總額 (關鍵修改) ---
                double loanAmount = 0;

                // 假設 cbDownPaymentType.SelectedIndex == 0 是 "%"
                if (cbself.SelectedIndex == 0)
                {
                    // 比例計算：總價 * (1 - 比例%)
                    // 例如：1000萬 * (1 - 20/100) = 800萬
                    loanAmount = housePrice * (1 - (downPaymentInput / 100));
                }
                else
                {
                    // 金額計算：總價 - 自備款金額
                    // 注意：如果你 UI 提示是「萬元」，記得這裡要 * 10000
                    loanAmount = housePrice - downPaymentInput;
                }

                // --- 3. 核心計算邏輯 ---
                double monthlyRate = annualRate / 100 / 12;
                int totalMonths = years * 12;
                int graceMonths = graceYears * 12;
                int remainingMonths = totalMonths - graceMonths;

                double monthlyPayment = 0;

                // 計算寬限期後的每月還款 (本息平均攤還)
                if (remainingMonths > 0)
                {
                    monthlyPayment = loanAmount * (Math.Pow(1 + monthlyRate, remainingMonths) * monthlyRate)
                                    / (Math.Pow(1 + monthlyRate, remainingMonths) - 1);
                }

                // --- 4. 計算首期資訊 ---
                double firstMonthInterest = loanAmount * monthlyRate; // 首期利息
                double firstMonthPrincipal = 0;

                if (graceMonths > 0)
                {
                    // 寬限期內：首期本金為 0，每月還款僅為利息
                    firstMonthPrincipal = 0;
                    // 額外提醒：如果現在在寬限期內，lblpriceperm (每月應繳) 可能要顯示「利息」還是「寬限期後本息」？
                    // 通常試算器會顯示「寬限期內繳：XXX，寬限期後繳：OOO」
                }
                else
                {
                    // 無寬限期：首期本金 = 每月還款 - 首期利息
                    firstMonthPrincipal = monthlyPayment - firstMonthInterest;
                }

                // --- 5. 計算總支出 ---
                // 總利息 = (寬限期利息總和) + (還款期利息總和)
                double totalInterest = (loanAmount * monthlyRate * graceMonths) + (monthlyPayment * remainingMonths - loanAmount);
                double totalRepayment = loanAmount + totalInterest;

                // --- 6. 顯示結果 ---
                lbltotalloan.Text = loanAmount.ToString("N2");

                // 如果有寬限期，這裡顯示「寬限期後」的金額，或你可以視需求調整
                lblpriceperm.Text = monthlyPayment.ToString("N2");

                lblfirstinterest.Text = firstMonthInterest.ToString("N2");
                lblfirstprice.Text = firstMonthPrincipal.ToString("N2");
                lbltotalinterest.Text = totalInterest.ToString("N2");
                lbltotalback.Text = totalRepayment.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("請輸入正確的數字格式，並確認欄位皆已填寫。", "提示");
            }
        }
    }
}
