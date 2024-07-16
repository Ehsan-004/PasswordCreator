using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordCreator
{
    public partial class Form1 : Form
    {
        public char[] lowers = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        public char[] uppers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public char[] numbers = "0123456789".ToCharArray();
        public char[] specialChars = "!@#$%^&*()_+-=[]{}|;:,.<>/?".ToCharArray();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        public static void ShuffleList<T>(List<T> list)
        {
            // Create a random number generator
            Random rng = new Random();

            // Shuffle the list using the Fisher-Yates shuffle algorithm
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            List<char> options = new List<char>();

            if (cb_lowercase.Checked)
                options.AddRange(lowers);

            if (cb_uppercase.Checked)
                options.AddRange(uppers);

            if (cb_special.Checked)
                options.AddRange(specialChars);

            if (cb_numbers.Checked)
                options.AddRange(numbers);

            string password = "";

            int leng = Decimal.ToInt32(length_of_password.Value);

            ShuffleList(options);

            Random rand = new Random();
            int random_number;

            for (int i = 0 ; i < leng ; i++)
            {
                random_number = rand.Next(options.Count);
                password += options[i];
            }

            //MessageBox.Show(password);

            tb_password.Text = password;
        }
    }
}
