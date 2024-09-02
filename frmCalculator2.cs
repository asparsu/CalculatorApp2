using Microsoft.VisualBasic;
using System.Data;
using System.Drawing.Text;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace CalculatorApp2
{
    public partial class frmCalculator2 : Form
    {
        /// <summary>
        /// Expression をセットするストリング
        /// </summary>
        private string mExpression = string.Empty;

        /// <summary>
        /// 結果があるかをチェックする。True=結果ある。False=結果がない。
        /// </summary>
        /// <remarks>
        /// Rev1.0.0 2024/04/24 プラナウ
        /// </remarks>
        private bool IsResultgenerated = false;

        /// <summary>
        /// デイフォルトコンストラクタ
        /// </summary>
        /// /// <remarks>
        /// Rev1.0.0 2024/04/18 プラナウ
        /// </remarks>
        public frmCalculator2()
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
        /// Rev1.0.0 2024/04/18 プラナウ
        /// </remarks>
        private void NumButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (txtResult.Text == "0")
                {
                    txtResult.Clear();

                }

                Button btnNum = (Button)sender;

                int operandCount = mExpression.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries).Length;
                if (operandCount >= 3)
                {
                    MessageBox.Show("Maximum number of operands (3) reached.");
                    return;

                }

                string currentOperand = txtResult.Text;
                if (currentOperand.Length >= 7)
                {
                    MessageBox.Show("Maximum number of digits (7) reached.");
                    return;
                }


                if (IsResultgenerated == true)
                {
                    txtResult.Clear();
                    txtResult.Text = btnNum.Text;
                    mExpression = btnNum.Text;
                    IsResultgenerated = false;
                }
                else
                {
                    txtResult.Text += btnNum.Text;
                    mExpression += btnNum.Text;
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
        /// Rev1.0.0 2024/04/18 プラナウ
        /// </remarks>
        private void OperatorClick(object sender, EventArgs e)
        {
            try
            {
                if(IsResultgenerated == true) 
                {
                 IsResultgenerated=false;
                }
                Button optbutton = (Button)sender;
                if (!string.IsNullOrEmpty(mExpression))
                {
                    if (IsOperator(mExpression[mExpression.Length - 1]))
                    {
                        if ((optbutton.Text[0] != mExpression[mExpression.Length - 1]))
                        {
                            mExpression = mExpression.Remove(mExpression.Length - 1) + optbutton.Text;
                        }
                    }
                    else
                    {
                        txtResult.Clear();
                        mExpression += optbutton.Text;
                    }
                }
                else
                {
                    MessageBox.Show("Enter An Operand First");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private bool IsOperator(char c)
        {
            try
            {
              char[] operators = ['+', '-', '*', '/'];
              return operators.Contains(c);
            }
            catch (Exception ex)
            {
             
                throw;
               
            }
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            // Your event handling code here
        }



        /// <summary>
        /// 演算結果を表示する
        /// </summary>
        /// <remarks>
        /// Rev1.0.0 2024/04/18 プラナウ
        /// </remarks>
        private void ButtonEqualCLick(object sender, EventArgs e)
        {
            try
            {
                double dblResult = 0;
                DataTable objDt = new DataTable();

                dblResult = Convert.ToDouble(objDt.Compute(mExpression, string.Empty));
                txtResult.Text = dblResult.ToString();

                
                mExpression = dblResult.ToString();
                IsResultgenerated = true;


            }
            catch (Exception ex)
            {
                {
                    if(ex is SyntaxErrorException)
                    {
                        MessageBox.Show("Incomplete Operation!");
                    }
                }
            }
        }
    }
}
