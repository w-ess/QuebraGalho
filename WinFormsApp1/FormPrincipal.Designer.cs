namespace WinFormsApp1
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            button1 = new Button();
            textBase64 = new RichTextBox();
            tabPage2 = new TabPage();
            textFormatacao = new RichTextBox();
            button2 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(2, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 438);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBase64);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 410);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Conversor";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 61);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "base64:";
            // 
            // button1
            // 
            button1.Location = new Point(15, 24);
            button1.Name = "button1";
            button1.Size = new Size(131, 23);
            button1.TabIndex = 2;
            button1.Text = "Converter para pdf";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBase64
            // 
            textBase64.Location = new Point(15, 79);
            textBase64.Name = "textBase64";
            textBase64.Size = new Size(756, 229);
            textBase64.TabIndex = 1;
            textBase64.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(textFormatacao);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 410);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Formatação";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textFormatacao
            // 
            textFormatacao.Location = new Point(6, 52);
            textFormatacao.Name = "textFormatacao";
            textFormatacao.Size = new Size(780, 350);
            textFormatacao.TabIndex = 0;
            textFormatacao.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(12, 19);
            button2.Name = "button2";
            button2.Size = new Size(95, 23);
            button2.TabIndex = 1;
            button2.Text = "Formatar Json";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "FormPrincipal";
            Text = "Quebra Galho";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private Button button1;
        private RichTextBox textBase64;
        private Button button2;
        private RichTextBox textFormatacao;
    }
}