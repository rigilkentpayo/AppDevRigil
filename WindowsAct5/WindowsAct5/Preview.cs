using System.Xml.Linq;

namespace WindowsAct5
{
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
        }

        public void SetValues(string Name, string Country, string Gender,
 string Hobby, string Status)
        {
            lblName.Text = Name;
            lblCountry.Text = Country;
            lblGender.Text = Gender;
            lblHobby.Text = Hobby;
            lblStatus.Text = Status;
        }

        private void Preview_Load(object sender, EventArgs e)
        {

        }
    }
}
