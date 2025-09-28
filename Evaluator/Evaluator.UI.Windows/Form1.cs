using System;
using System.Windows.Forms;
using Evaluator.Core;

namespace Evaluator.UI.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Shared event for numeric and operator buttons
        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                // If we already showed a result (contains '=') and the user presses a button,
                // clear to start a new expression.
                if (txtDisplay.Text.Contains("="))
                    txtDisplay.Text = string.Empty;

                txtDisplay.Text += btn.Text;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDisplay.Text))
                return;

            // If it had a result (e.g. "2+2=4") and user presses delete, clear everything
            if (txtDisplay.Text.Contains("="))
            {
                txtDisplay.Text = string.Empty;
                return;
            }

            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                var expression = txtDisplay.Text;

                // If it already has "=", remove the result part
                if (expression.Contains("="))
                    expression = expression.Substring(0, expression.IndexOf('='));

                if (string.IsNullOrWhiteSpace(expression))
                    return;

                double result = ExpressionEvaluator.Evaluate(expression);
                txtDisplay.Text = expression + "=" + result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la expresión: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
