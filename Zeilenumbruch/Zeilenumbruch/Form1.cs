using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zeilenumbruch
{
    public partial class Form1 : Form
    {
        Brecher brecher;
        private int _laenge;
        public Form1()
        {
            InitializeComponent();
        }

        public void btn1_Click(object sender, EventArgs e)
        {
            if (CheckStringForEmpty(TextBox1.Text) == false && CheckStringForEmpty(TextBox3.Text) == false)
            {
                if (ParsableToInteger(TextBox3.Text) == true)
                {
                    if (IntegerIsNotZero(Convert.ToInt32(TextBox3.Text)))
                    {
                        TextUmbrechen();
                    }
                    else
                    {
                        Fehlerausgabe("Ungültige Zeichenlänge. Bitte geben sie eine höhere Zahl als 0 an!");
                    }
                }
                else
                {
                    Fehlerausgabe("Ungültige Zeichenlänge. Bitte geben sie eine Zahl ein!");
                }
            }
            else 
            {
                Fehlerausgabe("Ungültige Angaben! Bitte geben sie einen Text und eine Zeichenlänge ein!");
            }
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) 
            {
                String file = openFileDialog1.FileName;
                try
                {
                    TextBox1.Text = File.ReadAllText(file);
                }
                catch (IOException)
                {
                    Fehlerausgabe("Die Datei konnte nicht gelesen werden!");
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            String name = saveFileDialog1.FileName;
            File.WriteAllText(name, TextBox2.Text);
        }

        public void TextUmbrechen()
        {
            brecher = new Brecher(TextBox1.Text);
            _laenge = Convert.ToInt32(TextBox3.Text);
            TextBox2.Text = brecher.Umbrechen(_laenge);
        }

        public bool CheckStringForEmpty(String fieldText) 
        {
            if (fieldText == String.Empty || fieldText == null)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public bool ParsableToInteger(String fieldText)
        {
            if (!Int32.TryParse(fieldText, out _laenge))
            {
                return false;
            }
            else 
            {
                return true;
            }
        }

        public bool IntegerIsNotZero(int number)
        {
            if (number != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Fehlerausgabe(String Meldung) 
        {
            MessageBox.Show(Meldung, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
