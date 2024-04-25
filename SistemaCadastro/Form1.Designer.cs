namespace SistemaCadastro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNome = new Label();
            labelDataNascimento = new Label();
            labelEstadoCivil = new Label();
            labelTelefone = new Label();
            txtNome = new TextBox();
            txtData = new DateTimePicker();
            comboEstadoCivil = new ComboBox();
            txtTelefone = new MaskedTextBox();
            checkCasaP = new CheckBox();
            checkVeiculoP = new CheckBox();
            groupSexo = new GroupBox();
            radioOutro = new RadioButton();
            radioFeminino = new RadioButton();
            radioMasculino = new RadioButton();
            listaCampo = new ListBox();
            btnCadastrar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            groupSexo.SuspendLayout();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.Location = new Point(34, 24);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(70, 30);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            // 
            // labelDataNascimento
            // 
            labelDataNascimento.AutoSize = true;
            labelDataNascimento.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelDataNascimento.Location = new Point(34, 80);
            labelDataNascimento.Name = "labelDataNascimento";
            labelDataNascimento.Size = new Size(174, 30);
            labelDataNascimento.TabIndex = 1;
            labelDataNascimento.Text = "Data Nascimento";
            // 
            // labelEstadoCivil
            // 
            labelEstadoCivil.AutoSize = true;
            labelEstadoCivil.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelEstadoCivil.Location = new Point(34, 136);
            labelEstadoCivil.Name = "labelEstadoCivil";
            labelEstadoCivil.Size = new Size(119, 30);
            labelEstadoCivil.TabIndex = 2;
            labelEstadoCivil.Text = "Estado Civil";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelTelefone.Location = new Point(34, 192);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(91, 30);
            labelTelefone.TabIndex = 3;
            labelTelefone.Text = "Telefone";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(227, 24);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(747, 35);
            txtNome.TabIndex = 4;
            // 
            // txtData
            // 
            txtData.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtData.Location = new Point(227, 79);
            txtData.Name = "txtData";
            txtData.Size = new Size(417, 35);
            txtData.TabIndex = 5;
            // 
            // comboEstadoCivil
            // 
            comboEstadoCivil.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboEstadoCivil.FormattingEnabled = true;
            comboEstadoCivil.Location = new Point(227, 136);
            comboEstadoCivil.Name = "comboEstadoCivil";
            comboEstadoCivil.Size = new Size(234, 38);
            comboEstadoCivil.TabIndex = 6;
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefone.Location = new Point(227, 192);
            txtTelefone.Mask = "(00) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(234, 35);
            txtTelefone.TabIndex = 7;
            // 
            // checkCasaP
            // 
            checkCasaP.AutoSize = true;
            checkCasaP.Location = new Point(227, 243);
            checkCasaP.Name = "checkCasaP";
            checkCasaP.Size = new Size(134, 19);
            checkCasaP.TabIndex = 8;
            checkCasaP.Text = "Possui Casa Própria?";
            checkCasaP.UseVisualStyleBackColor = true;
            // 
            // checkVeiculoP
            // 
            checkVeiculoP.AutoSize = true;
            checkVeiculoP.Location = new Point(227, 268);
            checkVeiculoP.Name = "checkVeiculoP";
            checkVeiculoP.Size = new Size(106, 19);
            checkVeiculoP.TabIndex = 9;
            checkVeiculoP.Text = "Possui Veiculo?";
            checkVeiculoP.UseVisualStyleBackColor = true;
            // 
            // groupSexo
            // 
            groupSexo.Controls.Add(radioOutro);
            groupSexo.Controls.Add(radioFeminino);
            groupSexo.Controls.Add(radioMasculino);
            groupSexo.Location = new Point(227, 293);
            groupSexo.Name = "groupSexo";
            groupSexo.Size = new Size(234, 100);
            groupSexo.TabIndex = 10;
            groupSexo.TabStop = false;
            groupSexo.Text = "Sexo";
            // 
            // radioOutro
            // 
            radioOutro.AutoSize = true;
            radioOutro.Location = new Point(6, 72);
            radioOutro.Name = "radioOutro";
            radioOutro.Size = new Size(56, 19);
            radioOutro.TabIndex = 2;
            radioOutro.TabStop = true;
            radioOutro.Text = "Outro";
            radioOutro.UseVisualStyleBackColor = true;
            // 
            // radioFeminino
            // 
            radioFeminino.AutoSize = true;
            radioFeminino.Location = new Point(6, 47);
            radioFeminino.Name = "radioFeminino";
            radioFeminino.Size = new Size(75, 19);
            radioFeminino.TabIndex = 1;
            radioFeminino.TabStop = true;
            radioFeminino.Text = "Feminino";
            radioFeminino.UseVisualStyleBackColor = true;
            // 
            // radioMasculino
            // 
            radioMasculino.AutoSize = true;
            radioMasculino.Checked = true;
            radioMasculino.Location = new Point(6, 22);
            radioMasculino.Name = "radioMasculino";
            radioMasculino.Size = new Size(80, 19);
            radioMasculino.TabIndex = 0;
            radioMasculino.TabStop = true;
            radioMasculino.Text = "Masculino";
            radioMasculino.UseVisualStyleBackColor = true;
            // 
            // listaCampo
            // 
            listaCampo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            listaCampo.FormattingEnabled = true;
            listaCampo.ItemHeight = 30;
            listaCampo.Location = new Point(34, 510);
            listaCampo.Name = "listaCampo";
            listaCampo.Size = new Size(940, 214);
            listaCampo.TabIndex = 11;
            listaCampo.MouseDoubleClick += listaCampo_MouseDoubleClick;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(94, 427);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(255, 66);
            btnCadastrar.TabIndex = 12;
            btnCadastrar.Text = "Cadastrar/Alterar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluir.Location = new Point(372, 427);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(255, 66);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.Location = new Point(650, 427);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(255, 66);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 749);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(btnCadastrar);
            Controls.Add(listaCampo);
            Controls.Add(groupSexo);
            Controls.Add(checkVeiculoP);
            Controls.Add(checkCasaP);
            Controls.Add(txtTelefone);
            Controls.Add(comboEstadoCivil);
            Controls.Add(txtData);
            Controls.Add(txtNome);
            Controls.Add(labelTelefone);
            Controls.Add(labelEstadoCivil);
            Controls.Add(labelDataNascimento);
            Controls.Add(labelNome);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Alunos";
            Load += Form1_Load;
            groupSexo.ResumeLayout(false);
            groupSexo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private Label labelDataNascimento;
        private Label labelEstadoCivil;
        private Label labelTelefone;
        private TextBox txtNome;
        private DateTimePicker txtData;
        private ComboBox comboEstadoCivil;
        private MaskedTextBox txtTelefone;
        private CheckBox checkCasaP;
        private CheckBox checkVeiculoP;
        private GroupBox groupSexo;
        private RadioButton radioMasculino;
        private RadioButton radioOutro;
        private RadioButton radioFeminino;
        private ListBox listaCampo;
        private Button btnCadastrar;
        private Button btnExcluir;
        private Button btnLimpar;
    }
}
