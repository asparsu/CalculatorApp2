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
        /// Expression ���Z�b�g����X�g�����O
        /// </summary>
        private string mExpression = string.Empty;

        /// <summary>
        /// ���ʂ����邩���`�F�b�N����BTrue=���ʂ���BFalse=���ʂ��Ȃ��B
        /// </summary>
        /// <remarks>
        /// Rev1.0.0 2024/04/24 �v���i�E
        /// </remarks>
        private bool IsResultgenerated = false;

        /// <summary>
        /// �f�C�t�H���g�R���X�g���N�^
        /// </summary>
        /// /// <remarks>
        /// Rev1.0.0 2024/04/18 �v���i�E
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
        /// �������̓{�^��
        /// </summary>
        /// <remarks>
        /// Rev1.0.0 2024/04/18 �v���i�E
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
        /// ���Z�q��I��
        /// </summary>
        /// <remarks>
        /// Rev1.0.0 2024/04/18 �v���i�E
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
        /// ���Z���ʂ�\������
        /// </summary>
        /// <remarks>
        /// Rev1.0.0 2024/04/18 �v���i�E
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
