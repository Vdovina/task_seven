using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_seven
{
    public partial class Bul_Function : Form
    {
        static int[,] matrix;
        static int starcount = 0;

        public Bul_Function()
        {
            InitializeComponent();
            calculate.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
            if (Convert.ToInt32(Math.Log(textBox1.Text.Length, 2)) == Math.Log(textBox1.Text.Length, 2) && textBox1.Text.Length != 1) calculate.Enabled = true;
            else calculate.Enabled = false;
        }

        private void one_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
            if (Convert.ToInt32(Math.Log(textBox1.Text.Length, 2)) == Math.Log(textBox1.Text.Length, 2)
                && textBox1.Text.Length != 1 && starcount > 0) calculate.Enabled = true;
            else calculate.Enabled = false;
        }

        private void star_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
            starcount++;
            if (Convert.ToInt32(Math.Log(textBox1.Text.Length, 2)) == Math.Log(textBox1.Text.Length, 2)
                && textBox1.Text.Length != 1 && starcount > 0) calculate.Enabled = true;
            else calculate.Enabled = false;
            //if (starcount >= Math.Log(textBox1.Text.Length, 2)) star.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == '*' || e.KeyChar == '\b') e.Handled = false;
            else e.Handled = true;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text.Length > 0)
                if (Convert.ToInt32(Math.Log(textBox1.Text.Length, 2)) == Math.Log(textBox1.Text.Length, 2)
                    && textBox1.Text.Length != 1 && starcount > 0) calculate.Enabled = true;
                else calculate.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            starcount = 0;
            answer.Text = "";
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            int[,] starset = BoolSet((int)Math.Pow(2, starcount));
            int[] position = new int[starcount];
            int pos = 0;
            // remember the positions of stars
            for (int index = 0; index < textBox1.Text.Length; index++)
            {
                 if (textBox1.Text[index] == '*')
                 {
                     position[pos] = index;
                     pos++;
                 }
            }
            string finale = textBox1.Text;
            for (int i = 0; i < Math.Pow(2, starcount); i++) // для каждой строки матрицы возможных подставлений вместо звездочек
            {
                for (int j = 0; j < starcount; j++) // для каждой звездочки - замена
                {
                    string f = starset[i, j].ToString();
                    finale = finale.Remove(position[j], 1).Insert(position[j], f);
                }
                bool result = IsMonotonus(finale, true); // проверка получившегося вектора на монотонность
                if (result) answer.Text += finale + "\n";
            }
            if (answer.Text == "") answer.Text = "Данная функция\n не может быть \nдоопределена до \nмонотонной";

            calculate.Enabled = false;
        }

        

        private bool IsMonotonus(string vector, bool ok)
        {
            if (!ok) return false;
            int halfsize = vector.Length / 2; // поовина длины строки
            // devide a vector into two
            string right = vector.Substring(0, halfsize);
            string left = vector.Substring(halfsize, vector.Length - halfsize);

            if (right.Length > 1 && left.Length > 1) // если длина полувектора больше 1 
            {
                // вызываются рекурсии для правого и левого векторов поочерёдно 
                ok = IsMonotonus(right, ok); if (!ok) return false;
                // сравниваются элементы с одинаковыми индексами
                for (int i = 0; i < halfsize; i++)
                {
                    if (Convert.ToInt16(right[i]) <= Convert.ToInt16(left[i])) ok = true; else return false;
                }
                ok = IsMonotonus(left, ok); if (!ok) return false;
            }
            else // если длина полувектора = 1, то сравниваются правый и левый между собой
            {
                if (Convert.ToInt16(right) > Convert.ToInt16(left)) return false;
            }
            return ok;

        }

        private int[,] BoolSet (int length) // матрица, заполненная наборами значений булевой функции
        {
            int degree = (int)Math.Log(length, 2);
            matrix = new int[length, degree];
            int x; // a number of elements in each group
            for (int i = 0; i < degree; i++) // cycle filling the matrix of meanings for bool function
            {
                int j = 0;
                bool boolmean = false; // false - 0, true - 1
                x = Convert.ToInt32(length / Math.Pow(2, i + 1));
                while (j < length)
                {
                    for (int k = j; k < j + x; k++)
                    {
                        if (boolmean) matrix[k, i] = 1; else matrix[k, i] = 0;
                    }
                    boolmean = !boolmean;
                    j += x;
                }
            }
            return matrix;
        }
    }
}
