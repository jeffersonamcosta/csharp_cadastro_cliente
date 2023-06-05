namespace TESTE_DEV_PDVNET
{
    partial class CLIENTES
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CLIENTES));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.form_CLI_NOME = new System.Windows.Forms.TextBox();
            this.form_CLI_SEXO = new System.Windows.Forms.ComboBox();
            this.form_CLI_COD = new System.Windows.Forms.TextBox();
            this.form_CLI_TELEFONE = new System.Windows.Forms.TextBox();
            this.form_CLI_EMAIL = new System.Windows.Forms.TextBox();
            this.form_CLI_NASCIMENTO = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.form_END_CEP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.form_END_ENDERECO = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.form_END_NUMERO = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.form_END_COMPLEMENTO = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.form_END_BAIRRO = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.form_END_CIDADE = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.form_END_UF = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.form_bt_incluir = new System.Windows.Forms.Button();
            this.form_bt_limpar = new System.Windows.Forms.Button();
            this.form_bt_pesquisar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EDITAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.form_END_PAIS = new System.Windows.Forms.ComboBox();
            this.FORM_INATIVOS = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // form_CLI_NOME
            // 
            resources.ApplyResources(this.form_CLI_NOME, "form_CLI_NOME");
            this.form_CLI_NOME.Name = "form_CLI_NOME";
            // 
            // form_CLI_SEXO
            // 
            this.form_CLI_SEXO.FormattingEnabled = true;
            this.form_CLI_SEXO.Items.AddRange(new object[] {
            resources.GetString("form_CLI_SEXO.Items"),
            resources.GetString("form_CLI_SEXO.Items1"),
            resources.GetString("form_CLI_SEXO.Items2")});
            resources.ApplyResources(this.form_CLI_SEXO, "form_CLI_SEXO");
            this.form_CLI_SEXO.Name = "form_CLI_SEXO";
            // 
            // form_CLI_COD
            // 
            resources.ApplyResources(this.form_CLI_COD, "form_CLI_COD");
            this.form_CLI_COD.Name = "form_CLI_COD";
            this.form_CLI_COD.TextChanged += new System.EventHandler(this.DigitaSomenteNumeros);
            this.form_CLI_COD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextKeyPress);
            // 
            // form_CLI_TELEFONE
            // 
            resources.ApplyResources(this.form_CLI_TELEFONE, "form_CLI_TELEFONE");
            this.form_CLI_TELEFONE.Name = "form_CLI_TELEFONE";
            this.form_CLI_TELEFONE.TextChanged += new System.EventHandler(this.DigitaSomenteNumeros);
            // 
            // form_CLI_EMAIL
            // 
            resources.ApplyResources(this.form_CLI_EMAIL, "form_CLI_EMAIL");
            this.form_CLI_EMAIL.Name = "form_CLI_EMAIL";
            // 
            // form_CLI_NASCIMENTO
            // 
            resources.ApplyResources(this.form_CLI_NASCIMENTO, "form_CLI_NASCIMENTO");
            this.form_CLI_NASCIMENTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.form_CLI_NASCIMENTO.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.form_CLI_NASCIMENTO.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.form_CLI_NASCIMENTO.Name = "form_CLI_NASCIMENTO";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // form_END_CEP
            // 
            resources.ApplyResources(this.form_END_CEP, "form_END_CEP");
            this.form_END_CEP.Name = "form_END_CEP";
            this.form_END_CEP.TextChanged += new System.EventHandler(this.DigitaSomenteNumeros);
            this.form_END_CEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextKeyPress);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // form_END_ENDERECO
            // 
            resources.ApplyResources(this.form_END_ENDERECO, "form_END_ENDERECO");
            this.form_END_ENDERECO.Name = "form_END_ENDERECO";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // form_END_NUMERO
            // 
            resources.ApplyResources(this.form_END_NUMERO, "form_END_NUMERO");
            this.form_END_NUMERO.Name = "form_END_NUMERO";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // form_END_COMPLEMENTO
            // 
            resources.ApplyResources(this.form_END_COMPLEMENTO, "form_END_COMPLEMENTO");
            this.form_END_COMPLEMENTO.Name = "form_END_COMPLEMENTO";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // form_END_BAIRRO
            // 
            resources.ApplyResources(this.form_END_BAIRRO, "form_END_BAIRRO");
            this.form_END_BAIRRO.Name = "form_END_BAIRRO";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // form_END_CIDADE
            // 
            resources.ApplyResources(this.form_END_CIDADE, "form_END_CIDADE");
            this.form_END_CIDADE.Name = "form_END_CIDADE";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // form_END_UF
            // 
            this.form_END_UF.FormattingEnabled = true;
            this.form_END_UF.Items.AddRange(new object[] {
            resources.GetString("form_END_UF.Items"),
            resources.GetString("form_END_UF.Items1"),
            resources.GetString("form_END_UF.Items2"),
            resources.GetString("form_END_UF.Items3"),
            resources.GetString("form_END_UF.Items4"),
            resources.GetString("form_END_UF.Items5"),
            resources.GetString("form_END_UF.Items6"),
            resources.GetString("form_END_UF.Items7"),
            resources.GetString("form_END_UF.Items8"),
            resources.GetString("form_END_UF.Items9"),
            resources.GetString("form_END_UF.Items10"),
            resources.GetString("form_END_UF.Items11"),
            resources.GetString("form_END_UF.Items12"),
            resources.GetString("form_END_UF.Items13"),
            resources.GetString("form_END_UF.Items14"),
            resources.GetString("form_END_UF.Items15"),
            resources.GetString("form_END_UF.Items16"),
            resources.GetString("form_END_UF.Items17"),
            resources.GetString("form_END_UF.Items18"),
            resources.GetString("form_END_UF.Items19"),
            resources.GetString("form_END_UF.Items20"),
            resources.GetString("form_END_UF.Items21"),
            resources.GetString("form_END_UF.Items22"),
            resources.GetString("form_END_UF.Items23"),
            resources.GetString("form_END_UF.Items24"),
            resources.GetString("form_END_UF.Items25"),
            resources.GetString("form_END_UF.Items26"),
            resources.GetString("form_END_UF.Items27")});
            resources.ApplyResources(this.form_END_UF, "form_END_UF");
            this.form_END_UF.Name = "form_END_UF";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // form_bt_incluir
            // 
            resources.ApplyResources(this.form_bt_incluir, "form_bt_incluir");
            this.form_bt_incluir.Name = "form_bt_incluir";
            this.form_bt_incluir.UseVisualStyleBackColor = true;
            this.form_bt_incluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_bt_limpar
            // 
            resources.ApplyResources(this.form_bt_limpar, "form_bt_limpar");
            this.form_bt_limpar.Name = "form_bt_limpar";
            this.form_bt_limpar.UseVisualStyleBackColor = true;
            this.form_bt_limpar.Click += new System.EventHandler(this.form_bt_inativar_Click);
            // 
            // form_bt_pesquisar
            // 
            resources.ApplyResources(this.form_bt_pesquisar, "form_bt_pesquisar");
            this.form_bt_pesquisar.Name = "form_bt_pesquisar";
            this.form_bt_pesquisar.UseVisualStyleBackColor = true;
            this.form_bt_pesquisar.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excluir,
            this.EDITAR});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Excluir
            // 
            this.Excluir.DataPropertyName = "x";
            this.Excluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.Excluir, "Excluir");
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Excluir.Text = "x";
            // 
            // EDITAR
            // 
            resources.ApplyResources(this.EDITAR, "EDITAR");
            this.EDITAR.Name = "EDITAR";
            this.EDITAR.ReadOnly = true;
            this.EDITAR.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // form_END_PAIS
            // 
            this.form_END_PAIS.FormattingEnabled = true;
            this.form_END_PAIS.Items.AddRange(new object[] {
            resources.GetString("form_END_PAIS.Items"),
            resources.GetString("form_END_PAIS.Items1"),
            resources.GetString("form_END_PAIS.Items2"),
            resources.GetString("form_END_PAIS.Items3"),
            resources.GetString("form_END_PAIS.Items4"),
            resources.GetString("form_END_PAIS.Items5"),
            resources.GetString("form_END_PAIS.Items6"),
            resources.GetString("form_END_PAIS.Items7"),
            resources.GetString("form_END_PAIS.Items8"),
            resources.GetString("form_END_PAIS.Items9"),
            resources.GetString("form_END_PAIS.Items10"),
            resources.GetString("form_END_PAIS.Items11"),
            resources.GetString("form_END_PAIS.Items12"),
            resources.GetString("form_END_PAIS.Items13"),
            resources.GetString("form_END_PAIS.Items14"),
            resources.GetString("form_END_PAIS.Items15"),
            resources.GetString("form_END_PAIS.Items16"),
            resources.GetString("form_END_PAIS.Items17"),
            resources.GetString("form_END_PAIS.Items18"),
            resources.GetString("form_END_PAIS.Items19"),
            resources.GetString("form_END_PAIS.Items20"),
            resources.GetString("form_END_PAIS.Items21"),
            resources.GetString("form_END_PAIS.Items22"),
            resources.GetString("form_END_PAIS.Items23"),
            resources.GetString("form_END_PAIS.Items24"),
            resources.GetString("form_END_PAIS.Items25"),
            resources.GetString("form_END_PAIS.Items26"),
            resources.GetString("form_END_PAIS.Items27"),
            resources.GetString("form_END_PAIS.Items28"),
            resources.GetString("form_END_PAIS.Items29"),
            resources.GetString("form_END_PAIS.Items30"),
            resources.GetString("form_END_PAIS.Items31"),
            resources.GetString("form_END_PAIS.Items32"),
            resources.GetString("form_END_PAIS.Items33"),
            resources.GetString("form_END_PAIS.Items34"),
            resources.GetString("form_END_PAIS.Items35"),
            resources.GetString("form_END_PAIS.Items36"),
            resources.GetString("form_END_PAIS.Items37"),
            resources.GetString("form_END_PAIS.Items38"),
            resources.GetString("form_END_PAIS.Items39"),
            resources.GetString("form_END_PAIS.Items40"),
            resources.GetString("form_END_PAIS.Items41"),
            resources.GetString("form_END_PAIS.Items42"),
            resources.GetString("form_END_PAIS.Items43"),
            resources.GetString("form_END_PAIS.Items44"),
            resources.GetString("form_END_PAIS.Items45"),
            resources.GetString("form_END_PAIS.Items46"),
            resources.GetString("form_END_PAIS.Items47"),
            resources.GetString("form_END_PAIS.Items48"),
            resources.GetString("form_END_PAIS.Items49"),
            resources.GetString("form_END_PAIS.Items50"),
            resources.GetString("form_END_PAIS.Items51"),
            resources.GetString("form_END_PAIS.Items52"),
            resources.GetString("form_END_PAIS.Items53"),
            resources.GetString("form_END_PAIS.Items54"),
            resources.GetString("form_END_PAIS.Items55"),
            resources.GetString("form_END_PAIS.Items56"),
            resources.GetString("form_END_PAIS.Items57"),
            resources.GetString("form_END_PAIS.Items58"),
            resources.GetString("form_END_PAIS.Items59"),
            resources.GetString("form_END_PAIS.Items60"),
            resources.GetString("form_END_PAIS.Items61"),
            resources.GetString("form_END_PAIS.Items62"),
            resources.GetString("form_END_PAIS.Items63"),
            resources.GetString("form_END_PAIS.Items64"),
            resources.GetString("form_END_PAIS.Items65"),
            resources.GetString("form_END_PAIS.Items66"),
            resources.GetString("form_END_PAIS.Items67"),
            resources.GetString("form_END_PAIS.Items68"),
            resources.GetString("form_END_PAIS.Items69"),
            resources.GetString("form_END_PAIS.Items70"),
            resources.GetString("form_END_PAIS.Items71"),
            resources.GetString("form_END_PAIS.Items72"),
            resources.GetString("form_END_PAIS.Items73"),
            resources.GetString("form_END_PAIS.Items74"),
            resources.GetString("form_END_PAIS.Items75"),
            resources.GetString("form_END_PAIS.Items76"),
            resources.GetString("form_END_PAIS.Items77"),
            resources.GetString("form_END_PAIS.Items78"),
            resources.GetString("form_END_PAIS.Items79"),
            resources.GetString("form_END_PAIS.Items80"),
            resources.GetString("form_END_PAIS.Items81"),
            resources.GetString("form_END_PAIS.Items82"),
            resources.GetString("form_END_PAIS.Items83"),
            resources.GetString("form_END_PAIS.Items84"),
            resources.GetString("form_END_PAIS.Items85"),
            resources.GetString("form_END_PAIS.Items86"),
            resources.GetString("form_END_PAIS.Items87"),
            resources.GetString("form_END_PAIS.Items88"),
            resources.GetString("form_END_PAIS.Items89"),
            resources.GetString("form_END_PAIS.Items90"),
            resources.GetString("form_END_PAIS.Items91"),
            resources.GetString("form_END_PAIS.Items92"),
            resources.GetString("form_END_PAIS.Items93"),
            resources.GetString("form_END_PAIS.Items94"),
            resources.GetString("form_END_PAIS.Items95"),
            resources.GetString("form_END_PAIS.Items96"),
            resources.GetString("form_END_PAIS.Items97"),
            resources.GetString("form_END_PAIS.Items98"),
            resources.GetString("form_END_PAIS.Items99"),
            resources.GetString("form_END_PAIS.Items100"),
            resources.GetString("form_END_PAIS.Items101"),
            resources.GetString("form_END_PAIS.Items102"),
            resources.GetString("form_END_PAIS.Items103"),
            resources.GetString("form_END_PAIS.Items104"),
            resources.GetString("form_END_PAIS.Items105"),
            resources.GetString("form_END_PAIS.Items106"),
            resources.GetString("form_END_PAIS.Items107"),
            resources.GetString("form_END_PAIS.Items108"),
            resources.GetString("form_END_PAIS.Items109"),
            resources.GetString("form_END_PAIS.Items110"),
            resources.GetString("form_END_PAIS.Items111"),
            resources.GetString("form_END_PAIS.Items112"),
            resources.GetString("form_END_PAIS.Items113"),
            resources.GetString("form_END_PAIS.Items114"),
            resources.GetString("form_END_PAIS.Items115"),
            resources.GetString("form_END_PAIS.Items116"),
            resources.GetString("form_END_PAIS.Items117"),
            resources.GetString("form_END_PAIS.Items118"),
            resources.GetString("form_END_PAIS.Items119"),
            resources.GetString("form_END_PAIS.Items120"),
            resources.GetString("form_END_PAIS.Items121"),
            resources.GetString("form_END_PAIS.Items122"),
            resources.GetString("form_END_PAIS.Items123"),
            resources.GetString("form_END_PAIS.Items124"),
            resources.GetString("form_END_PAIS.Items125"),
            resources.GetString("form_END_PAIS.Items126"),
            resources.GetString("form_END_PAIS.Items127"),
            resources.GetString("form_END_PAIS.Items128"),
            resources.GetString("form_END_PAIS.Items129"),
            resources.GetString("form_END_PAIS.Items130"),
            resources.GetString("form_END_PAIS.Items131"),
            resources.GetString("form_END_PAIS.Items132"),
            resources.GetString("form_END_PAIS.Items133"),
            resources.GetString("form_END_PAIS.Items134"),
            resources.GetString("form_END_PAIS.Items135"),
            resources.GetString("form_END_PAIS.Items136"),
            resources.GetString("form_END_PAIS.Items137"),
            resources.GetString("form_END_PAIS.Items138"),
            resources.GetString("form_END_PAIS.Items139"),
            resources.GetString("form_END_PAIS.Items140"),
            resources.GetString("form_END_PAIS.Items141"),
            resources.GetString("form_END_PAIS.Items142"),
            resources.GetString("form_END_PAIS.Items143"),
            resources.GetString("form_END_PAIS.Items144"),
            resources.GetString("form_END_PAIS.Items145"),
            resources.GetString("form_END_PAIS.Items146"),
            resources.GetString("form_END_PAIS.Items147"),
            resources.GetString("form_END_PAIS.Items148"),
            resources.GetString("form_END_PAIS.Items149"),
            resources.GetString("form_END_PAIS.Items150"),
            resources.GetString("form_END_PAIS.Items151"),
            resources.GetString("form_END_PAIS.Items152"),
            resources.GetString("form_END_PAIS.Items153"),
            resources.GetString("form_END_PAIS.Items154"),
            resources.GetString("form_END_PAIS.Items155"),
            resources.GetString("form_END_PAIS.Items156"),
            resources.GetString("form_END_PAIS.Items157"),
            resources.GetString("form_END_PAIS.Items158"),
            resources.GetString("form_END_PAIS.Items159"),
            resources.GetString("form_END_PAIS.Items160"),
            resources.GetString("form_END_PAIS.Items161"),
            resources.GetString("form_END_PAIS.Items162"),
            resources.GetString("form_END_PAIS.Items163"),
            resources.GetString("form_END_PAIS.Items164"),
            resources.GetString("form_END_PAIS.Items165"),
            resources.GetString("form_END_PAIS.Items166"),
            resources.GetString("form_END_PAIS.Items167"),
            resources.GetString("form_END_PAIS.Items168"),
            resources.GetString("form_END_PAIS.Items169"),
            resources.GetString("form_END_PAIS.Items170"),
            resources.GetString("form_END_PAIS.Items171"),
            resources.GetString("form_END_PAIS.Items172"),
            resources.GetString("form_END_PAIS.Items173"),
            resources.GetString("form_END_PAIS.Items174"),
            resources.GetString("form_END_PAIS.Items175"),
            resources.GetString("form_END_PAIS.Items176"),
            resources.GetString("form_END_PAIS.Items177"),
            resources.GetString("form_END_PAIS.Items178"),
            resources.GetString("form_END_PAIS.Items179"),
            resources.GetString("form_END_PAIS.Items180"),
            resources.GetString("form_END_PAIS.Items181"),
            resources.GetString("form_END_PAIS.Items182"),
            resources.GetString("form_END_PAIS.Items183"),
            resources.GetString("form_END_PAIS.Items184"),
            resources.GetString("form_END_PAIS.Items185"),
            resources.GetString("form_END_PAIS.Items186"),
            resources.GetString("form_END_PAIS.Items187"),
            resources.GetString("form_END_PAIS.Items188"),
            resources.GetString("form_END_PAIS.Items189"),
            resources.GetString("form_END_PAIS.Items190"),
            resources.GetString("form_END_PAIS.Items191"),
            resources.GetString("form_END_PAIS.Items192"),
            resources.GetString("form_END_PAIS.Items193"),
            resources.GetString("form_END_PAIS.Items194"),
            resources.GetString("form_END_PAIS.Items195"),
            resources.GetString("form_END_PAIS.Items196"),
            resources.GetString("form_END_PAIS.Items197"),
            resources.GetString("form_END_PAIS.Items198"),
            resources.GetString("form_END_PAIS.Items199"),
            resources.GetString("form_END_PAIS.Items200"),
            resources.GetString("form_END_PAIS.Items201"),
            resources.GetString("form_END_PAIS.Items202"),
            resources.GetString("form_END_PAIS.Items203"),
            resources.GetString("form_END_PAIS.Items204"),
            resources.GetString("form_END_PAIS.Items205"),
            resources.GetString("form_END_PAIS.Items206"),
            resources.GetString("form_END_PAIS.Items207"),
            resources.GetString("form_END_PAIS.Items208"),
            resources.GetString("form_END_PAIS.Items209"),
            resources.GetString("form_END_PAIS.Items210"),
            resources.GetString("form_END_PAIS.Items211"),
            resources.GetString("form_END_PAIS.Items212"),
            resources.GetString("form_END_PAIS.Items213"),
            resources.GetString("form_END_PAIS.Items214"),
            resources.GetString("form_END_PAIS.Items215"),
            resources.GetString("form_END_PAIS.Items216"),
            resources.GetString("form_END_PAIS.Items217"),
            resources.GetString("form_END_PAIS.Items218"),
            resources.GetString("form_END_PAIS.Items219"),
            resources.GetString("form_END_PAIS.Items220"),
            resources.GetString("form_END_PAIS.Items221"),
            resources.GetString("form_END_PAIS.Items222"),
            resources.GetString("form_END_PAIS.Items223"),
            resources.GetString("form_END_PAIS.Items224"),
            resources.GetString("form_END_PAIS.Items225"),
            resources.GetString("form_END_PAIS.Items226"),
            resources.GetString("form_END_PAIS.Items227"),
            resources.GetString("form_END_PAIS.Items228"),
            resources.GetString("form_END_PAIS.Items229"),
            resources.GetString("form_END_PAIS.Items230"),
            resources.GetString("form_END_PAIS.Items231"),
            resources.GetString("form_END_PAIS.Items232"),
            resources.GetString("form_END_PAIS.Items233"),
            resources.GetString("form_END_PAIS.Items234"),
            resources.GetString("form_END_PAIS.Items235"),
            resources.GetString("form_END_PAIS.Items236"),
            resources.GetString("form_END_PAIS.Items237"),
            resources.GetString("form_END_PAIS.Items238"),
            resources.GetString("form_END_PAIS.Items239"),
            resources.GetString("form_END_PAIS.Items240"),
            resources.GetString("form_END_PAIS.Items241"),
            resources.GetString("form_END_PAIS.Items242"),
            resources.GetString("form_END_PAIS.Items243"),
            resources.GetString("form_END_PAIS.Items244"),
            resources.GetString("form_END_PAIS.Items245"),
            resources.GetString("form_END_PAIS.Items246"),
            resources.GetString("form_END_PAIS.Items247"),
            resources.GetString("form_END_PAIS.Items248"),
            resources.GetString("form_END_PAIS.Items249"),
            resources.GetString("form_END_PAIS.Items250"),
            resources.GetString("form_END_PAIS.Items251"),
            resources.GetString("form_END_PAIS.Items252"),
            resources.GetString("form_END_PAIS.Items253"),
            resources.GetString("form_END_PAIS.Items254"),
            resources.GetString("form_END_PAIS.Items255"),
            resources.GetString("form_END_PAIS.Items256"),
            resources.GetString("form_END_PAIS.Items257"),
            resources.GetString("form_END_PAIS.Items258"),
            resources.GetString("form_END_PAIS.Items259")});
            resources.ApplyResources(this.form_END_PAIS, "form_END_PAIS");
            this.form_END_PAIS.Name = "form_END_PAIS";
            // 
            // FORM_INATIVOS
            // 
            resources.ApplyResources(this.FORM_INATIVOS, "FORM_INATIVOS");
            this.FORM_INATIVOS.Name = "FORM_INATIVOS";
            this.FORM_INATIVOS.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // CLIENTES
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.Controls.Add(this.label15);
            this.Controls.Add(this.FORM_INATIVOS);
            this.Controls.Add(this.form_END_PAIS);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.form_bt_pesquisar);
            this.Controls.Add(this.form_bt_limpar);
            this.Controls.Add(this.form_bt_incluir);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.form_END_UF);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.form_END_CIDADE);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.form_END_BAIRRO);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.form_END_COMPLEMENTO);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.form_END_NUMERO);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.form_END_ENDERECO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.form_END_CEP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.form_CLI_NASCIMENTO);
            this.Controls.Add(this.form_CLI_EMAIL);
            this.Controls.Add(this.form_CLI_TELEFONE);
            this.Controls.Add(this.form_CLI_COD);
            this.Controls.Add(this.form_CLI_SEXO);
            this.Controls.Add(this.form_CLI_NOME);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CLIENTES";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox form_CLI_NOME;
        private System.Windows.Forms.ComboBox form_CLI_SEXO;
        private System.Windows.Forms.TextBox form_CLI_COD;
        private System.Windows.Forms.TextBox form_CLI_TELEFONE;
        private System.Windows.Forms.TextBox form_CLI_EMAIL;
        private System.Windows.Forms.DateTimePicker form_CLI_NASCIMENTO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox form_END_CEP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox form_END_ENDERECO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox form_END_NUMERO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox form_END_COMPLEMENTO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox form_END_BAIRRO;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox form_END_CIDADE;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox form_END_UF;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button form_bt_incluir;
        private System.Windows.Forms.Button form_bt_limpar;
        private System.Windows.Forms.Button form_bt_pesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox form_END_PAIS;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
        private System.Windows.Forms.DataGridViewButtonColumn EDITAR;
        private System.Windows.Forms.CheckBox FORM_INATIVOS;
        private System.Windows.Forms.Label label15;
    }
}

