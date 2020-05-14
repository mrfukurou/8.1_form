using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string text = Convert.ToString(stroka.Text);

                string pattern = "[0-3][0-9].[0-1][0-9].[1,2][9,0][0-9][0-9]";

                MatchCollection data;
                Regex reg = new Regex(pattern);
                data = reg.Matches(text);
                DateTime s;

                if (!String.IsNullOrWhiteSpace(text))
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        if (DateTime.TryParse(data[i].Value, out s))
                        {
                            string next_date = DateTime.Parse(data[i].Value).AddDays(+1).ToShortDateString();
                            text = text.Replace(data[i].Value, next_date);

                        }
                        else
                            text = text.Replace(data[i].Value, "(Дата некорректна!)");
                    }

                    rez.Text = Convert.ToString(text);
                }
                else { throw new Exception(); }
            }
            catch
            { 
                attention.Text = Convert.ToString("Строка пуста!");
                rez.Clear();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            attention.Clear();
            rez.Clear();
            stroka.Clear();
        }
    }
}
