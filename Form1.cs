using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ICSharpCode.TextEditor.Document;
using System.IO;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void rnkEd_Load(object sender, EventArgs e)
        {
            
            string dizin = Application.StartupPath;
            FileSyntaxModeProvider renklendirici;
            if (Directory.Exists(dizin))
            {
                renklendirici = new FileSyntaxModeProvider(dizin);
                HighlightingManager.Manager.AddSyntaxModeFileProvider(renklendirici);
                //rnkEd.SetHighlighting();
                
            }
            
            
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rnkEd.Text);
        }

        private void yapistirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rnkEd.Text = Clipboard.GetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                rnkEd.SetHighlighting(radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                rnkEd.SetHighlighting(radioButton2.Text);
            }
            else if (radioButton3.Checked == true)
            {
                rnkEd.SetHighlighting(radioButton3.Text);
            }
            else if (radioButton4.Checked == true)
            {
                rnkEd.SetHighlighting(radioButton4.Text);
            }
            else if (radioButton5.Checked == true)
            {
                rnkEd.SetHighlighting(radioButton5.Text);
            }
            else if (radioButton8.Checked == true)
            {
                rnkEd.SetHighlighting(radioButton8.Text);
            }
            else if (radioButton7.Checked == true)
            {
                rnkEd.SetHighlighting(radioButton7.Text);
            }
            else if (radioButton6.Checked == true)
            {
                rnkEd.SetHighlighting(radioButton6.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Title = "Dosyayı Kaydet...";
            kaydet.Filter = "(*.cs)|*.cs|(*.php)|*.php|(*.cpp)|*.cpp|(*.c)|*.c|(*.h)|*.h|(*.hpp)|*.hpp|(*.html)|*.html|(*.sql)|*.sql|(*.js)|*.js|(*.css)|*.css|(*.xml)|*.xml|Tüm dosyalar(*.*)|*.*";
            kaydet.FilterIndex = 2;
            kaydet.InitialDirectory = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            kaydet.ShowDialog();
            rnkEd.SaveFile(kaydet.FileName);
            
            
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            try
            {
                dosyaAc.Title = "Dosya Seçiniz...";
                dosyaAc.Filter = "(*.cs)|*.cs|(*.php)|*.php|(*.cpp)|*.cpp|(*.c)|*.c|(*.h)|*.h|(*.hpp)|*.hpp|(*.html)|*.html|(*.sql)|*.sql|(*.js)|*.js|(*.css)|*.css|(*.xml)|*.xml|Tüm dosyalar(*.*)|*.*";
                dosyaAc.FilterIndex = 2;
                dosyaAc.InitialDirectory = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
                dosyaAc.Multiselect = true;
                dosyaAc.ShowDialog();
                rnkEd.LoadFile(dosyaAc.FileName);
                this.Text = dosyaAc.FileName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Dosya Secmediniz");
            }
        }

    }
}
