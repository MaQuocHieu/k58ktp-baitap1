using System;
using System.Windows.Forms;
using PersonalLib; // DLL của em

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            try
            {
                int day = int.Parse(txtDay.Text);
                int month = int.Parse(txtMonth.Text);
                int year = int.Parse(txtYear.Text);

                FunPredict fp = new FunPredict();
                string result = fp.PredictBirthday(day, month, year);

                lblResult.Text = "Ket qua: " + result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }
    }
}
