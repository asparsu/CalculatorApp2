using Microsoft.VisualBasic;
using System.Data;
using System.Drawing.Text;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace CalculatorApp2
{
    /// <summary>
    /// 電卓フォムクラス
    /// </summary>
    /// <remarks>
    /// Rev1.0.0 2024/6/3 プラナウ
    /// </remarks>
    public partial class frmCalculator : Form
    {
        /// <summary>
        /// Expression をセットするストリング
        /// </summary>
        /// /// <remarks>
        /// Rev1.0.0 2024/6/3 プラナウ
        /// </remarks>
        private string mExpression = string.Empty;

        /// <summary>
        /// 結果があるかをチェックする。True=結果ある。False=結果がない。
        /// </summary>
        /// <remarks>
        /// Rev1.0.0 2024/6/3 プラナウ
        /// </remarks>
        private bool IsResultgenerated = false;

        /// <summary>
        /// 結果を保存する変数
        /// </summary>
        /// <remarks>
        /// Rev1.0.0 2024/6/3 プラナウ
        /// </remarks>
        private double? dblResult = 0;

        /// <summary>
        /// 電卓リセットフラグ True=電卓リセットする False = 電卓リセットしない
        /// </summary>
        /// <remarks>
        /// Rev1.0.0 2024/6/3 プラナウ
        /// </remarks>
        private bool mShouldReset = false;


        /// <summary>
        /// デイフォルトコンストラクタ
        /// </summary>
        /// /// <remarks>
        /// Rev1.0.0 2024/3/6 プラナウ
        /// </remarks>
        public frmCalculator()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
         /// <summary>
        /// 数字入力ボタン
        /// </summary>
        /// <remarks>
        /// Rev1.0.0 2024/6/3 プラナウ
        /// </remarks>]
        private void NumButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (mShouldReset)
                {
                    txtResult.Clear();
                    txtResult.Text = "0";
                    mExpression = string.Empty;
                    dblResult = null;
                    IsResultgenerated = false;
                    lblResult.Text = string.Empty;
                    mShouldReset = false;
                }

                if (txtResult.Text == "0")
                {
                    txtResult.Clear();
                }

                Button btnNum = (Button)sender;

                if (IsResultgenerated == true)
                {
                    txtResult.Clear();
                    IsResultgenerated = false;
                    txtResult.Text = btnNum.Text;
                    mExpression = btnNum.Text;
                    lblResult.Text = mExpression;
                }
                else
                {
                    string currentOperand = Regex.Replace(txtResult.Text, @"[^\d]", string.Empty);
                    int currentOperandLength = currentOperand.Length;

                    if (currentOperandLength < 3)
                    {
                        txtResult.Text += btnNum.Text;
                        mExpression += btnNum.Text;
                        lblResult.Text = mExpression;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// 演算子を選択
        /// </summary>
        /// <remarks>
        /// Rev1.0.0 2024/6/3 プラナウ
        /// </remarks>
        private void OperatorClick(object sender, EventArgs e)
        {
            try
            {
                if (mShouldReset == true)
                {
                    return;
                }

                if (IsResultgenerated == true)
                {
                    IsResultgenerated = false;
                }
                Button optbutton = (Button)sender;

                //オペランドは3桁以上であれば、演算式入力できない
                int operandCount = mExpression.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries).Length;

                if (3 <= operandCount)
                {
                    return;
                }

                //同じ演算式を２回入力できない。------------------------------------------------------------------>
                if (!string.IsNullOrEmpty(mExpression))
                {
                    if (IsOperator(mExpression[mExpression.Length - 1].ToString()))
                    {
                        if ((optbutton.Text!= mExpression[mExpression.Length - 1].ToString()))
                        {
                            mExpression = mExpression.Remove(mExpression.Length - 1) + optbutton.Text;
                            lblResult.Text = mExpression;
                        }
                    }
                    else
                    {
                        txtResult.Clear();
                        mExpression += optbutton.Text;
                        lblResult.Text = mExpression;
                    }
                }
                else
                {
                    MessageBox.Show("Enter An Operand First");
                }
                //<------------------------------------------------------------------------------------------------

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 演算式があるかをチェックする
        /// </summary>
        /// <param name="c">計算式の最後の一文字</param>
        /// <returns>True:演算式である False:演算式ではない</returns>
        /// <remarks>
        /// Rev1.0.0 2024/6/3 プラナウ
        /// </remarks>
        private bool IsOperator(string c)
        {
            try
            {
                String[] operators = { "+", "-", "*", "/" };
                return operators.Contains(c);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

         /// <summary>
        /// 演算結果を表示する
        /// </summary>
        /// <remarks>
        /// Rev1.0.0 2024/6/3 プラナウ
        /// </remarks>
        private void ButtonEqualCLick(object sender, EventArgs e)
        {
            try
            {
                if (IsResultgenerated == true)
                {
                    return;
                }
                string strtemp = string.Empty;


                if (string.IsNullOrWhiteSpace(mExpression))
                {

                    return;
                }

                DataTable objDt = new DataTable();


                dblResult = Convert.ToDouble(objDt.Compute(mExpression, string.Empty));

                
                //計算結果は0又は、infinityであるかをチェックする
                if (dblResult.HasValue && double.IsInfinity(dblResult.Value) || (dblResult.HasValue && double.IsNaN(dblResult.Value)))
                {
                    txtResult.Text = String.Empty;
                    MessageBox.Show("Cant divide by Zero!");
                    return;
                }

                //小数点台４位まで有効
                dblResult = Math.Round(dblResult.Value, 4);


                txtResult.Text = dblResult.ToString();



                //計算結果は3桁以上であれば、オペランド１としてセットすることができない。
                string strresultlen = dblResult.ToString();

                strresultlen = Regex.Replace(strresultlen, @"[^\d\.]", string.Empty);

                string[] parts = strresultlen.Split('.');

                if (parts.Length > 0)
                {
                    string leftOfDecimal = parts[0];

                    if (leftOfDecimal.Length > 3)
                    {
                        mShouldReset = true;
                        return;
                    }
                }

                mExpression = dblResult.ToString();

                strtemp = mExpression;


                lblResult.Text = lblResult.Text + "=" + strtemp;

                IsResultgenerated = true;

            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid expression format: {ex.Message}");

            }
            catch (InvalidExpressionException ex)
            {
                MessageBox.Show("Incomplete Operation!");

            }


            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");

            }
        }

        /// <summary>
        /// 電卓をもとに戻るつまりリセットするメソッド
        /// </summary>
        /// <remarks>
        /// Rev1.0.0 2024/6/3 プラナウ
        /// </remarks>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Clear();
                txtResult.Text = "0";
                mExpression = string.Empty;
                dblResult = null;
                IsResultgenerated = false;
                lblResult.Text = string.Empty;
                mShouldReset = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
