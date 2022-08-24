namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            label2.ForeColor = Color.Red;
            label2.Text = "Realizando Calculos";

            var met1 = FolhaDePagamento();
            var met2 = Impostos();
            var met3 = Receitas();
            var met4 = Despesas();
            await met1;
            await met2;
            await met3;
            await met4;

            listBox1.Items.Add(met1.Result);
            listBox1.Items.Add(met2.Result);
            listBox1.Items.Add(met3.Result);
            listBox1.Items.Add(met4.Result);

            button1.Enabled = false;
            label2.ForeColor = Color.Green;
            label2.Text = "Calculos Realizados";
        }

        private async Task <string> FolhaDePagamento()
        {
            await Task.Delay(1000);
            return "Folha de Pagamento = R$5000,00";
        }

        private async Task<string> Impostos()
        {
            await Task.Delay(2000);
            return "Impostos =  R$23,90";
        }

        private async Task<string> Receitas()
        {
            await Task.Delay(3000);
            return "Recitas = R$9400,00";
        }

        private async Task<string> Despesas()
        {
            await Task.Delay(4000);
            return "Despesas = R$800,00";
        }
    }
}