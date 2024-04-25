using System.Linq.Expressions;

namespace SistemaCadastro
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas;

        public Form1()
        {
            InitializeComponent();

            pessoas = new List<Pessoa>();
            //
            // Caixa de Estado Civil
            //
            comboEstadoCivil.Items.Add("Solteiro");
            comboEstadoCivil.Items.Add("Casado");
            comboEstadoCivil.Items.Add("Divorciado");
            comboEstadoCivil.Items.Add("Viuvo");

            comboEstadoCivil.SelectedIndex = 0;
        }

        //
        // Métodos de cliques dos botões
        //
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //
        // Função do click do botão Cadastrar/Alterar
        // 
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int index = -1;

            // Verificar se a pessao ja esta cadastrada
            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa.Nome == txtNome.Text)
                {
                    index = pessoas.IndexOf(pessoa);
                }
            }
            //
            // Verificar se os campos foram preenchidos
            //

            // Campos Nome
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome.");
                txtNome.Focus();
                return;
            }

            //Campo Telefone
            if (txtTelefone.Text == "(  )      -")
            {
                MessageBox.Show("Preencha o campo Telefone.");
                txtTelefone.Focus();
                return;
            }

            //
            // Verificar qual campo do Sexo foi escolhido pelo usuario
            //
            char sexo;

            if (radioMasculino.Checked)
            {
                sexo = 'M';
            }
            else if (radioFeminino.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'O';
            }

            //
            // Objeto pessao com todos dados preenchidos
            //
            Pessoa p = new Pessoa();
            p.Nome = txtNome.Text;
            p.DataNascimento = txtData.Text;
            p.EstadoCivil = comboEstadoCivil.SelectedItem.ToString();
            p.Telefone = txtTelefone.Text;
            p.CasaPropria = checkCasaP.Checked;
            p.Veiculo = checkVeiculoP.Checked;
            p.Sexo = sexo;

            // Verifica se é um novo cadastro ou se altera um atual
            if (index < 0)
            {
                pessoas.Add(p);
            }
            else
            {
                pessoas[index] = p;
            }

            // Limpa os campos
            btnLimpar_Click(btnLimpar, EventArgs.Empty);

            Listar();
        }

        // 
        // Função Botão excluir
        // 
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int indice = listaCampo.SelectedIndex;
            pessoas.RemoveAt(indice);
            Listar();
        }

        //
        // Função Botão Limpar
        //
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtData.Text = "";
            comboEstadoCivil.SelectedIndex = 0;
            txtTelefone.Text = "";
            checkCasaP.Checked = false;
            checkVeiculoP.Checked = false;
            radioMasculino.Checked = true;
            radioFeminino.Checked = false;
            radioOutro.Checked = false;
            txtNome.Focus();
        }

        //
        // Método para listar a listaCampo com a list pessoas
        //
        private void Listar()
        {
            // Limpa a listBox listaCampo
            listaCampo.Items.Clear();

            // Verificar lista pessoas
            foreach (Pessoa p in pessoas)
            {
                listaCampo.Items.Add(p.Nome);
            }
        }


        // 
        // Função do click da lista para alterar o cadastro
        // 
        private void listaCampo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indice = listaCampo.SelectedIndex;
            Pessoa p = pessoas[indice];

            txtNome.Text = p.Nome;
            txtData.Text = p.DataNascimento;
            comboEstadoCivil.SelectedItem = p.EstadoCivil;
            txtTelefone.Text = p.Telefone;
            checkCasaP.Checked = p.CasaPropria;
            checkVeiculoP.Checked = p.Veiculo;

            switch (p.Sexo)
            {
                case 'M':
                    radioMasculino.Checked = true;
                    break;
                case 'F':
                    radioFeminino.Checked= true;
                    break;
                default:
                    radioOutro.Checked = true;
                    break;
            } 
        }
    }
}
