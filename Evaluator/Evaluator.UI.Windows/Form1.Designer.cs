namespace Evaluator.UI.Windows
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;

        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnPower;

        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnOpenParen;
        private System.Windows.Forms.Button btnCloseParen;

        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;

        private System.Windows.Forms.Button btnEqual;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();

            // Buttons
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();

            this.btn0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnOpenParen = new System.Windows.Forms.Button();
            this.btnCloseParen = new System.Windows.Forms.Button();

            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();

            this.btnEqual = new System.Windows.Forms.Button();

            // Form properties
            this.SuspendLayout();
            this.Text = "Functions Evaluator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(420, 600);

            // txtDisplay
            this.txtDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Multiline = false;
            this.txtDisplay.Height = 70;
            this.txtDisplay.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDisplay.BackColor = System.Drawing.Color.Black;
            this.txtDisplay.ForeColor = System.Drawing.Color.Lime;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(6);

            // tlpButtons
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.ColumnCount = 4;
            this.tlpButtons.RowCount = 6;
            this.tlpButtons.Padding = new System.Windows.Forms.Padding(6);
            this.tlpButtons.ColumnStyles.Clear();
            for (int i = 0; i < 4; i++)
                this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));

            this.tlpButtons.RowStyles.Clear();
            // 5 regular rows + the last one for a big '='
            for (int i = 0; i < 5; i++)
                this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            // last row '=' (16%)
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));

            // General button style
            void SetupButton(System.Windows.Forms.Button b, string text, bool isOperator = false)
            {
                b.Text = text;
                b.Dock = System.Windows.Forms.DockStyle.Fill;
                b.Margin = new System.Windows.Forms.Padding(6);
                b.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                b.FlatStyle = System.Windows.Forms.FlatStyle.System;
                if (isOperator)
                    b.BackColor = System.Drawing.Color.Orange;
                else
                    b.BackColor = System.Drawing.Color.White;
            }

            // Configure each button (text and look)
            SetupButton(btn7, "7");
            SetupButton(btn8, "8");
            SetupButton(btn9, "9");
            SetupButton(btnDelete, "Delete", true);

            SetupButton(btn4, "4");
            SetupButton(btn5, "5");
            SetupButton(btn6, "6");
            SetupButton(btnClear, "Clear", true);

            SetupButton(btn1, "1");
            SetupButton(btn2, "2");
            SetupButton(btn3, "3");
            SetupButton(btnPower, "^", true);

            SetupButton(btn0, "0");
            SetupButton(btnDot, ".");
            SetupButton(btnOpenParen, "(", true);
            SetupButton(btnCloseParen, ")", true);

            SetupButton(btnMultiply, "*", true);
            SetupButton(btnDivide, "/", true);
            SetupButton(btnPlus, "+", true);
            SetupButton(btnMinus, "-", true);

            SetupButton(btnEqual, "=", true);
            btnEqual.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

            // Add controls to tlpButtons in grid order (col, row)
            // Row 0
            this.tlpButtons.Controls.Add(this.btn7, 0, 0);
            this.tlpButtons.Controls.Add(this.btn8, 1, 0);
            this.tlpButtons.Controls.Add(this.btn9, 2, 0);
            this.tlpButtons.Controls.Add(this.btnDelete, 3, 0);

            // Row 1
            this.tlpButtons.Controls.Add(this.btn4, 0, 1);
            this.tlpButtons.Controls.Add(this.btn5, 1, 1);
            this.tlpButtons.Controls.Add(this.btn6, 2, 1);
            this.tlpButtons.Controls.Add(this.btnClear, 3, 1);

            // Row 2
            this.tlpButtons.Controls.Add(this.btn1, 0, 2);
            this.tlpButtons.Controls.Add(this.btn2, 1, 2);
            this.tlpButtons.Controls.Add(this.btn3, 2, 2);
            this.tlpButtons.Controls.Add(this.btnPower, 3, 2);

            // Row 3
            this.tlpButtons.Controls.Add(this.btn0, 0, 3);
            this.tlpButtons.Controls.Add(this.btnDot, 1, 3);
            this.tlpButtons.Controls.Add(this.btnOpenParen, 2, 3);
            this.tlpButtons.Controls.Add(this.btnCloseParen, 3, 3);

            // Row 4 (operators row)
            this.tlpButtons.Controls.Add(this.btnMultiply, 0, 4);
            this.tlpButtons.Controls.Add(this.btnDivide, 1, 4);
            this.tlpButtons.Controls.Add(this.btnPlus, 2, 4);
            this.tlpButtons.Controls.Add(this.btnMinus, 3, 4);

            // Row 5 '=' spans all 4 columns
            this.tlpButtons.Controls.Add(this.btnEqual, 0, 5);
            this.tlpButtons.SetColumnSpan(this.btnEqual, 4);

            // Assign events
            // number & operator buttons (except Clear, Delete, Equal) use same handler
            this.btn0.Click += new System.EventHandler(this.Button_Click);
            this.btn1.Click += new System.EventHandler(this.Button_Click);
            this.btn2.Click += new System.EventHandler(this.Button_Click);
            this.btn3.Click += new System.EventHandler(this.Button_Click);
            this.btn4.Click += new System.EventHandler(this.Button_Click);
            this.btn5.Click += new System.EventHandler(this.Button_Click);
            this.btn6.Click += new System.EventHandler(this.Button_Click);
            this.btn7.Click += new System.EventHandler(this.Button_Click);
            this.btn8.Click += new System.EventHandler(this.Button_Click);
            this.btn9.Click += new System.EventHandler(this.Button_Click);
            this.btnDot.Click += new System.EventHandler(this.Button_Click);
            this.btnOpenParen.Click += new System.EventHandler(this.Button_Click);
            this.btnCloseParen.Click += new System.EventHandler(this.Button_Click);
            this.btnMultiply.Click += new System.EventHandler(this.Button_Click);
            this.btnDivide.Click += new System.EventHandler(this.Button_Click);
            this.btnPlus.Click += new System.EventHandler(this.Button_Click);
            this.btnMinus.Click += new System.EventHandler(this.Button_Click);
            this.btnPower.Click += new System.EventHandler(this.Button_Click);

            // special handlers
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);

            // Add controls to form
            this.Controls.Add(this.tlpButtons);
            this.Controls.Add(this.txtDisplay);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
