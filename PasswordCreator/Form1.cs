using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public List<char> options = new List<char>();

        public bool use_lower = false;
        public bool use_upper = false;
        public bool use_numbers = false;
        public bool use_chars = false;

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
            // AI generated code!
            Random rng = new Random();

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
            if (use_numbers)
                options.AddRange(numbers);
            if(use_lower)
                options.AddRange(lowers);
            if (use_upper)
                options.AddRange(uppers);
            if (use_chars)
                options.AddRange(specialChars);


            if (!options.Any())
            {
                MessageBox.Show(
                    "choose at least one type of characters!", 
                    "no type error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                    );
                return;
            }

            if (Decimal.ToInt32(length_of_password.Value) <= 0)
            {
                MessageBox.Show(
                    "length of password can't be 0!",
                    "length error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

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

            tb_password.Text = password;
        }

        private void cb_lowercase_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_lowercase.Checked)
            {
                use_lower = true;
            }
            else
            {
                use_lower = false;
            }
        }

        private void cb_uppercase_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_uppercase.Checked)
            {
                use_upper = true;
            }
            else
            {
                use_upper = false;
            }
        }

        private void cb_numbers_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_numbers.Checked)
            {
                use_numbers = true;
            }
            else
            {
                use_numbers = false;
            }
        }

        private void cb_special_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_special.Checked)
            {
                use_chars = true;
            }
            else
            {
                use_chars = false;
            }
        }
    }
}
