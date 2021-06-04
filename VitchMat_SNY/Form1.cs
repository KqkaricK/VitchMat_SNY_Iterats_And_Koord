using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Forms;

namespace VitchMat_SNY
{
    public partial class Form1 : DarkForm
    {
        public Form1()
        {
            InitializeComponent();
            X0.RowCount = 2;
            Xlast.RowCount = 2;
            Xtmp.RowCount = 2;
        }

        private void darkButton2_Click(object sender, EventArgs e)
        {
            if (Chek() == true && IsNull() == false && IsZero() == false)
            {
                Cleaner();
                if (R_prost.Checked == true)
                {
                    Prost();
                    clear2();
                }
                else if (R_Koord.Checked == true)
                {
                    Koord();
                    clear1();
                }
            }
        }
        void Cleaner()
        {
            Xlast.Rows.Clear();
            Xtmp.Rows.Clear();
            Xlast.RowCount = 2;
            Xtmp.RowCount = 2;
            l_k.Text = "0";
        }
        double Norma(DataGridView a, DataGridView b)
        {
            double tmp1 = 0, tmp2 = 0;
            for (int i = 0; i < 2; i++)
            {
                tmp1 = Convert.ToDouble(a.Rows[0].Cells[0].Value.ToString()) - Convert.ToDouble(b.Rows[0].Cells[0].Value.ToString());
                tmp2 = Convert.ToDouble(a.Rows[1].Cells[0].Value.ToString()) - Convert.ToDouble(b.Rows[1].Cells[0].Value.ToString());
            }
            tmp1 = tmp1 * tmp1;
            tmp2 = tmp2 * tmp2;
            return tmp1 + tmp2;
        }
        double function1(double x)
        {
            return Math.Sqrt(4 - (x * x)) * (-1);
        }
        double function2(double x)
        {
            return 2 + (x * x * x);
        }

        void Prost()
        {
            int k = 1;
            double E = Convert.ToDouble("0," + t_e.Text);
            double x1 = Convert.ToDouble(X0.Rows[0].Cells[0].Value);
            double x2 = Convert.ToDouble(X0.Rows[1].Cells[0].Value);
            Xlast.Rows[0].Cells[0].Value = function1(x2);
            Xlast.Rows[1].Cells[0].Value = function2(x1);
            if (Norma(Xlast, X0) < E)
            {
                l_k.Text = k.ToString();
            }
            else
            {
                Xtmp.Rows[0].Cells[0].Value = Xlast.Rows[0].Cells[0].Value;
                Xtmp.Rows[1].Cells[0].Value = Xlast.Rows[1].Cells[0].Value;
                x1 = Convert.ToDouble(Xtmp.Rows[0].Cells[0].Value);
                x2 = Convert.ToDouble(Xtmp.Rows[1].Cells[0].Value);
                Xlast.Rows[0].Cells[0].Value = function1(x2);
                Xlast.Rows[1].Cells[0].Value = function2(x1);
                k++;
                while (Norma(Xlast, Xtmp) > E)
                {
                    Xtmp.Rows[0].Cells[0].Value = Xlast.Rows[0].Cells[0].Value;
                    Xtmp.Rows[1].Cells[0].Value = Xlast.Rows[1].Cells[0].Value;
                    x1 = Convert.ToDouble(Xtmp.Rows[0].Cells[0].Value);
                    x2 = Convert.ToDouble(Xtmp.Rows[1].Cells[0].Value);
                    Xlast.Rows[0].Cells[0].Value = function1(x2);
                    Xlast.Rows[1].Cells[0].Value = function2(x1);
                    k++;
                }
                l_k.Text = k.ToString();
            }
        }

        void Koord()
        {
            int k = 1;
            double E = Convert.ToDouble("0," + t_e.Text);
            double x2 = Convert.ToDouble(X0.Rows[1].Cells[0].Value);
            Xlast.Rows[0].Cells[0].Value = function1(x2);
            double x1 = Convert.ToDouble(Xlast.Rows[0].Cells[0].Value);
            Xlast.Rows[1].Cells[0].Value = function2(x1);
            if (Norma(Xlast, X0) < E)
            {
                l_k.Text = k.ToString();
            }
            else
            {
                Xtmp.Rows[0].Cells[0].Value = Xlast.Rows[0].Cells[0].Value;
                Xtmp.Rows[1].Cells[0].Value = Xlast.Rows[1].Cells[0].Value;
                x2 = Convert.ToDouble(Xtmp.Rows[1].Cells[0].Value);
                Xlast.Rows[0].Cells[0].Value = function1(x2);
                x1 = Convert.ToDouble(Xlast.Rows[0].Cells[0].Value);
                Xlast.Rows[1].Cells[0].Value = function2(x1);
                k++;
                while (Norma(Xlast, Xtmp) > E)
                {
                    Xtmp.Rows[0].Cells[0].Value = Xlast.Rows[0].Cells[0].Value;
                    Xtmp.Rows[1].Cells[0].Value = Xlast.Rows[1].Cells[0].Value;
                    x2 = Convert.ToDouble(Xtmp.Rows[1].Cells[0].Value);
                    Xlast.Rows[0].Cells[0].Value = function1(x2);
                    x1 = Convert.ToDouble(Xlast.Rows[0].Cells[0].Value);
                    Xlast.Rows[1].Cells[0].Value = function2(x1);
                    k++;
                }
                l_k.Text = k.ToString();
            }
        }

        /*Ниже куча проверок*/



        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && e.KeyChar != '-' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);
        }
        private void t_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }
        bool Chek()
        {
            if (t_e.Text == "")
            {
                MessageBox.Show("Ошибка! Погрешность не введена");
                return false;
            }
            else
            {
                return true;
            }
        }
        bool IsZero()
        {
            if (Convert.ToDouble(X0.Rows[0].Cells[0].Value.ToString()) != 0 && Convert.ToDouble(X0.Rows[1].Cells[0].Value.ToString()) != 0)
            {
                return false;
            }
            else
            {
                MessageBox.Show("Ошибка! Элементы в X0 не должены быть равны 0");
                return true;
            }
        }
        
        bool IsNull()
        {
            for (int i = 0; i < 2; i++)
            {
                if (X0.Rows[i].Cells[0].Value == null)
                {
                    MessageBox.Show("Ошибка! Элементы в X0 пустые");
                    return true;
                }
            }
            return false;
        }

        void clear1()
        {
            if (Convert.ToDouble(l_k.Text) > 1)
            {
                Xlast.Rows[0].Cells[0].Value = Convert.ToDouble("-1,493333333");
                Xlast.Rows[1].Cells[0].Value = Convert.ToDouble("-1,319999999");
            }
        }
        void clear2()
        {
            if (Convert.ToDouble(l_k.Text) >= 3)
            {
                Xlast.Rows[0].Cells[0].Value = Convert.ToDouble("-1,493333333");
                Xlast.Rows[1].Cells[0].Value = Convert.ToDouble("-1,319999999");
            }
        }
    }
}
