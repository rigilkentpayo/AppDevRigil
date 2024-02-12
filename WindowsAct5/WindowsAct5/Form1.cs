using System.Xml.Linq;

namespace WindowsAct5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Gender, Hobby, Status = "";
            if (radioMale.Checked) Gender = "Male";
            else Gender = "Female";
            if (chkReading.Checked) Hobby = "Reading";
            else Hobby = "Painting";
            if (chkReading.Checked && chkPaint.Checked)
                Hobby = "Reading and Painting";
            if (radioMarried.Checked) Status = "Married";
            else Status = "Unmarried";
            Preview objPreview = new Preview();
            objPreview.SetValues(txtName.Text, cmbCountry.Text, Gender, Hobby, Status);
            objPreview.Show();
        }
    }
}
