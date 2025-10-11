namespace Software_Lab4_Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ComboBoxW.SelectedIndex = 0;
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            double Zoo = 0;
            double X = Convert.ToDouble(TextBoxX.Text);
            double Y = Convert.ToDouble(TextBoxY.Text);
            int N = Convert.ToInt32(TextBoxN.Text);
            double W = Convert.ToDouble(ComboBoxW.SelectedItem);
            double T = Convert.ToDouble(ListBoxT.SelectedItem);

            if (RadioButton1.Checked)
            {
                Zoo = 0;
                double item = 0;
                for (int i = 0; i < N; i++)
                {
                    item = (i % 2 == 0) ? Y : X;
                    Zoo += Math.Pow(-1, i % 2) * Math.Pow(item, i);
                }
            }
            else
            {
                Zoo = W * X - T * Y + 7;
            }
            TextBoxZoo.Text = Zoo.ToString();
        }
    }
}
