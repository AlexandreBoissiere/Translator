using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TranslateStarter_Click(object sender, EventArgs e)
        {
            string toTranslate = ToTranslate.Text;
            string language = InputLang.Text;
            string outLang = OutputLang.Text;

            toTranslate = toTranslate.Replace("\n", "");

            TranslatorCore.Core core = new TranslatorCore.Core(toTranslate, language, outLang, out string output);

            Translated.Text = output;
        }
    }
}
