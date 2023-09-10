namespace calculadoraaaaaa
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operador;


        public Calculadora()
        {
            InitializeComponent();
        }

        Clases.clsSuma obj = new Clases.clsSuma();
        Clases.clsResta obj2 = new Clases.clsResta();
        Clases.clsMultiplicar obj3 = new Clases.clsMultiplicar();
        Clases.clsDividir obj4 = new Clases.clsDividir();

        private void btn0_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "9";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsumar_Click(object sender, EventArgs e)
        {

            operador = "+";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(tbxScreen.Text);

            double Sum;
            double Res;
            double Mul;
            double Div;

            switch (operador)
            {
                case "+":
                    Sum = obj.Sumar((primero), (segundo));
                    tbxScreen.Text = Sum.ToString();
                    break;
                case "-":
                    Res = obj2.Restar((primero), (segundo));
                    tbxScreen.Text = Res.ToString();
                    break;
                case "*":
                    Mul = obj3.Multiplicar((primero), (segundo));
                    tbxScreen.Text = Mul.ToString();
                    break;
                case "/":
                    Div = obj4.Dividir((primero), (segundo));
                    tbxScreen.Text = Div.ToString();
                    break;
            }

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            tbxScreen.Clear();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text.Length == 1)
                tbxScreen.Text = "";
            else
                tbxScreen.Text = tbxScreen.Text.Substring(0, tbxScreen.Text.Length - 1);
        }
    }
}