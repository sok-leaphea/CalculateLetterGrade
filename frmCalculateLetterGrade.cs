using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateLetterGrade
{
    public partial class frmCalculateLetterGrade : Form
    {
        public frmCalculateLetterGrade()
        {
            InitializeComponent();
        }

        private void btnCalculateLetterGrade_Click(object sender, EventArgs e)
        {
            decimal NumberGrade = Convert.ToDecimal(txtNumericGrade.Text);
            string LetterGrade = "";

            if (NumberGrade >= 90 && NumberGrade <= 100)
                LetterGrade = "A";
            else if (NumberGrade >= 80 && NumberGrade < 90)
                LetterGrade = "B";
            else if (NumberGrade >= 70 && NumberGrade < 80)
                LetterGrade = "C";
            else if (NumberGrade >= 60 && NumberGrade < 70)
                LetterGrade = "D";
            else if (NumberGrade < 60)
                LetterGrade = "F";
            lblLetterGrade.Text = LetterGrade.ToString();
            txtNumericGrade.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
