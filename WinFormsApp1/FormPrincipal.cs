namespace WinFormsApp1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllBytes(@"c:\Temp\arquivo.pdf", Convert.FromBase64String(textBase64.Text));
        }
    }
}