using System.Text.Json;
using System.Xml;

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

        private void button2_Click(object sender, EventArgs e)
        {
            var objeto = JsonSerializer.Deserialize<Object>(textFormatacao.Text);
            textFormatacao.Text = JsonSerializer.Serialize(objeto, new JsonSerializerOptions { WriteIndented = true });            
        }
    }
}