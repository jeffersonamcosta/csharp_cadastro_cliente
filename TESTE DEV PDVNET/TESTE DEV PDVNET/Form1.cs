using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;


namespace TESTE_DEV_PDVNET
{

    
    public partial class CLIENTES : Form
    {

        private bool sobrescrever = false;// define o compirtamento do botão salvar, false = comando SQL insert,True = comando SQL update

        public CLIENTES()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string db()
        {
            //Pega os dados do arquivo no caminho $path e converte em uma string com as finformacoes para conectar no SQL 
            //Arquivo: C:\CONFIG\BASE.INI
            //Conteudo:
            //02=istancia
            //03 = banco
            //04 = usuario
            //05 = senha

            string path = "C:\\CONFIG\\BASE.INI";
            string linha = "", servidor = "", banco = "", usuario = "", senha = "";
            try
            {

                StreamReader sr = new StreamReader(path);
                linha = sr.ReadLine();
                while (linha != null)
                {

                    if (linha.Contains("02="))
                    {
                        servidor = linha.Replace("02=", "");
                    }
                    if (linha.Contains("03="))
                    {
                        banco = linha.Replace("03=", "");
                    }
                    if (linha.Contains("04="))
                    {
                        usuario = linha.Replace("04=", "");
                    }
                    if (linha.Contains("05="))
                    {
                        senha = linha.Replace("05=", "");
                    }

                    linha = sr.ReadLine();
                }
             
                sr.Close();
          
                string connetionString;
                     
                connetionString = @"Data Source=" + servidor + ";Database=" + banco + ";User ID=" + usuario + ";Password=" + senha;
             
                return connetionString;


            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return "Exception: " + e.Message;
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        
       private void Pesquisar() {

            // Popula o elemento dataGridView1 com informações oriundas do SQL com base nos campos do formulario correspondente
            string query = "";
            query = "SELECT ";
            query += "c.CLI_COD AS 'CPF/CNPJ', c.CLI_NOME AS 'NOME/RAZÃO SOCIAL', c.CLI_EMAIL AS 'EMAIL', c.CLI_SEXO AS 'SEXO', c.CLI_TELEFONE AS 'TELEFONE', c.CLI_D_CADASTRO AS 'D_CADASTRO', c.CLI_ATUALIZACAO AS 'D_ATUALIZACAO', c.CLI_NASCIMENTO AS 'D_NASCIMENTO', e.END_CEP AS 'CEP', e.END_ENDERECO AS 'ENDERECO', e.END_NUMERO AS 'NUMERO', e.END_COMPLEMENTO AS 'COMPLEMENTO', e.END_BAIRRO AS 'BAIRRO', e.END_CIDADE AS 'CIDADE', e.END_UF AS 'UF', e.END_PAIS AS 'PAIS' ";
            query += "FROM CLIENTES as c LEFT JOIN ENDERECO as e ON c.CLI_fk_ENDERECO_PADRAO = e.END_CODIGO WHERE CLI_INATIVO = 0";
            string wheres = " ";
            foreach (Control control in Controls)
            {
                string columnName = control.Name.Replace("form_", "");
                columnName = columnName.Replace("CLI_", "c.CLI_");
                columnName = columnName.Replace("END_", "e.END_");

                if (control is TextBox textBox && !string.IsNullOrEmpty(textBox.Text))
                {

                    wheres += $" AND {columnName} LIKE '%{textBox.Text}%'";
                }
                else if (control is ComboBox comboBox && comboBox.SelectedIndex != -1)
                {
                    wheres += $"  AND {columnName} = '{comboBox.SelectedItem.ToString()}'";
                }
                else if (control is DateTimePicker dateTimePicker && dateTimePicker.Value.ToString("yyyy-MM-dd") != DateTime.Today.ToString("yyyy-MM-dd"))
                {
                    wheres += $" AND {columnName} = '{dateTimePicker.Value.ToString("yyyy-MM-dd")}'";
                }
                else if (control is CheckBox checkBox && checkBox.Checked) {
                    query = query.Replace("CLI_INATIVO = 0", "CLI_INATIVO = 1");
                }
            }
            query += wheres;
            
            try
            {
                SqlConnection con = new SqlConnection(db());
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Visible = true;  
                con.Close();
                dataGridView1.CellFormatting += (sender, e) =>
                {
                    if (e.ColumnIndex == dataGridView1.Columns["Excluir"].Index)
                    {
                        e.Value = "Excluir";
                        if (FORM_INATIVOS.Checked) { e.Value = "Ativar"; }
                    }
                    else if (e.ColumnIndex == dataGridView1.Columns["Editar"].Index)
                    {
                        e.Value = "Editar";
                    }
                };



            }
            catch (Exception k)
            {
                MessageBox.Show("Exception: " + k.Message);

            }
        }


        private void button4_Click(object sender, EventArgs e)
        {

                Pesquisar();
            
        }
        private void ExcluirCliente(string id)
        {   //Update no campo INATIVO do SQL
            const string messagem = "Realmente deseja fazer isso ?";
            var result = MessageBox.Show(messagem, "INATIVAR",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {   
                try
                {
                    SqlConnection con = new SqlConnection(db());
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE CLIENTES SET CLI_INATIVO = @bit WHERE cli_cod = @Id; UPDATE ENDERECO SET END_INATIVO = @bit WHERE end_codigo = @Id", con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@bit", !FORM_INATIVOS.Checked);
                    cmd.ExecuteNonQuery();
                    con.Close();                      
                    Pesquisar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir cliente: " + ex.Message);
                }
            }
            }
            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cada cliente é uma linha no dataGridView1, para cada linha existe um botao exclui e editar que realiza uma ação de acordo com dado da coluna "CPF/CNPJ"(PK da tabela no SQL)
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Excluir"].Index)
            {

                string id = (string)dataGridView1.Rows[e.RowIndex].Cells["CPF/CNPJ"].Value;
                ExcluirCliente(id);
            }

            else if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Editar"].Index)
            {
                string id = (string)dataGridView1.Rows[e.RowIndex].Cells["CPF/CNPJ"].Value;
                CarregarDadosnoForm(id);

            }
            else { }





        }

        private void CarregarDadosnoForm(string id)
        {   //Oriundo do evento de clicar no botão editar, popula os forms do programa com as informacoes da linha do dataGridView1 e set sobrescrever=True.

            try
            {
                SqlConnection con = new SqlConnection(db());
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CLIENTES as c left join ENDERECO as e on c.cli_cod = e.end_codigo WHERE cli_cod = @id ", con);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                form_CLI_COD.Text = reader["CLI_COD"].ToString();
                form_CLI_NOME.Text = reader["CLI_NOME"].ToString();
                form_CLI_TELEFONE.Text = reader["CLI_TELEFONE"].ToString();
                form_CLI_EMAIL.Text = reader["CLI_EMAIL"].ToString();
                form_CLI_SEXO.Text = reader["CLI_SEXO"].ToString();
                form_CLI_NASCIMENTO.Text = reader["CLI_NASCIMENTO"].ToString();

                form_END_CEP.Text = reader["END_CEP"].ToString();
                form_END_ENDERECO.Text = reader["END_ENDERECO"].ToString();
                form_END_NUMERO.Text = reader["END_NUMERO"].ToString();
                form_END_COMPLEMENTO.Text = reader["END_COMPLEMENTO"].ToString();
                form_END_BAIRRO.Text = reader["END_BAIRRO"].ToString();
                form_END_CIDADE.Text = reader["END_CIDADE"].ToString();
                form_END_UF.Text = reader["END_UF"].ToString();
                form_END_PAIS.Text = reader["END_PAIS"].ToString();
                reader.Close();
                con.Close();
                sobrescrever = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar cliente: " + ex.Message);
            }
        }

        private void LimparTela() {
            //limpa os valores dos forms
            sobrescrever= false;
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (control is DataGridView dataGridView)
                {
                    dataGridView.DataSource= null;
                    dataGridView.Visible=false;
                }
                else if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Value = DateTime.Today;
                }

            }

        }

        private void InsertUpdate()
        {//transcreve os dados do forms para a tabela correspondente no banco.
            // SE sobrescrever = false, realiza operação realiza um insert, SE sobrescrever = True, realiza operação realiza um update
            try
            {
                string query = "";
                if (sobrescrever == false)
                {
                    query = "insert into clientes values (@nome, @cod, @tel, getdate(),getdate(),@nasc,@email,@sexo,0,@END_CODIGO,0);" +
                        "insert into endereco values(@END_CODIGO,@END_CEP,@END_ENDERECO,@END_NUMERO,@END_COMPLEMENTO,@END_BAIRRO,@END_CIDADE,@END_UF,@END_PAIS,@END_INATIVO,getdate(),getdate())";
                }
                else if (sobrescrever == true)
                {
                    query = "UPDATE clientes set CLI_NOME = @nome,CLI_TELEFONE = @tel, CLI_ATUALIZACAO = getdate(),CLI_NASCIMENTO = @nasc,CLI_EMAIL = @email,CLI_SEXO = @sexo where cli_cod = @cod;" +
    "update endereco set END_CEP =@END_CEP,END_ENDERECO = @END_ENDERECO,END_NUMERO= @END_NUMERO,END_COMPLEMENTO = @END_COMPLEMENTO,END_BAIRRO=@END_BAIRRO,END_CIDADE = @END_CIDADE,END_UF = @END_UF,END_PAIS = @END_PAIS,END_ATUALIZACAO = getdate() where END_CODIGO = @cod";
                }
                SqlConnection con = new SqlConnection(db());
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nome", form_CLI_NOME.Text.Trim());
                cmd.Parameters.AddWithValue("@cod", form_CLI_COD.Text.Trim());
                cmd.Parameters.AddWithValue("@tel", form_CLI_TELEFONE.Text.Trim());
                cmd.Parameters.AddWithValue("@nasc", form_CLI_NASCIMENTO.Text.Trim());
                cmd.Parameters.AddWithValue("@email", form_CLI_EMAIL.Text.Trim());
                cmd.Parameters.AddWithValue("@sexo", form_CLI_SEXO.Text.Trim());
                cmd.Parameters.AddWithValue("@END_CODIGO", form_CLI_COD.Text.Trim());
                cmd.Parameters.AddWithValue("@END_CEP", form_END_CEP.Text.Trim());
                cmd.Parameters.AddWithValue("@END_ENDERECO", form_END_ENDERECO.Text.Trim());
                cmd.Parameters.AddWithValue("@END_NUMERO", form_END_NUMERO.Text.Trim());
                cmd.Parameters.AddWithValue("@END_COMPLEMENTO", form_END_COMPLEMENTO.Text.Trim());
                cmd.Parameters.AddWithValue("@END_BAIRRO", form_END_BAIRRO.Text.Trim());
                cmd.Parameters.AddWithValue("@END_CIDADE", form_END_CIDADE.Text.Trim());
                cmd.Parameters.AddWithValue("@END_UF", form_END_UF.Text.Trim());
                cmd.Parameters.AddWithValue("@END_PAIS", form_END_PAIS.Text.Trim());
                cmd.Parameters.AddWithValue("@END_INATIVO", 0);
                cmd.ExecuteNonQuery();
                sobrescrever = false;
                Pesquisar();
                MessageBox.Show("Cliente cadastrado");
            }
            catch (SqlException s)
            {
                if (s.Number == 2627)
                {
                    MessageBox.Show("CPF/CNPJ já cadastrado !");
                    Pesquisar();
                }
            }
            

        }


        private void button1_Click(object sender, EventArgs e)
        {   if (ValidarCampos())
                {
                InsertUpdate();
            }
        }

 
        private bool ValidarCampos()
        {
            // Validação do campo CPF
            if (string.IsNullOrEmpty(form_CLI_COD.Text) || !form_CLI_COD.Text.All(char.IsDigit) || form_CLI_COD.Text.Length<11)
            {
                MessageBox.Show("O campo CPF/CNPJ esta incorreto! Use somente numeros");
                form_CLI_COD.Focus();
                return false;
            }

            // Validação do campo Nome
            if (string.IsNullOrEmpty(form_CLI_NOME.Text))
            {
                MessageBox.Show("O campo Nome esta incorreto!");
                form_CLI_NOME.Focus();
                return false;
            }

            // Validação do campo Telefone
            if (!string.IsNullOrEmpty(form_CLI_TELEFONE.Text))
            {
                if (!form_CLI_TELEFONE.Text.All(char.IsDigit) || form_CLI_TELEFONE.Text.Length<10)
                {
                    MessageBox.Show("O campo Telefone esta incorreto! Use somente numeros e com DDD");
                    form_CLI_TELEFONE.Focus();
                    return false;

                }
                }

                return true;
        }
        private void ConsultaCNPJ() {

            //Consome uma API de consulta de CNPJ e formata os dados conforme necessario
            string url = "https://receitaws.com.br/v1/cnpj/" + form_CLI_COD.Text.Trim();
            string[] res = ConsumirApi(url);
            
            if (res!=null)
            {
                bool nomeempresa = true;
                foreach (string linha in res)
                {
                    if (string.IsNullOrEmpty(linha) || !linha.Contains(":")) { continue; }
                    else
                    {
                        
                        string[] v = linha.Split(':');
                        v[0] = v[0].Trim();
                        v[1] = v[1].Trim();
                        if (!string.IsNullOrEmpty(v[0]) || !string.IsNullOrEmpty(v[1]))
                        {

                            if (v[0] == "abertura")
                            {
                                form_CLI_NASCIMENTO.Text = v[1];
                            }
                            else if (v[0] == "nome" && nomeempresa)
                            {
                                form_CLI_NOME.Text = v[1];
                                nomeempresa = false;
                            }
                            else if (v[0] == "logradouro")
                            {
                                form_END_ENDERECO.Text = v[1];
                            }
                            else if (v[0] == "numero")
                            {
                              
                                form_END_NUMERO.Text = v[1];
                            }

                            else if (v[0] == "bairro")
                            {
                                form_END_BAIRRO.Text = v[1];
                            }
                            else if (v[0] == "municipio")
                            {
                                form_END_CIDADE.Text = v[1];
                            }
                            else if (v[0] == "uf")
                            {
                                form_END_UF.Text = v[1];
                                form_END_PAIS.Text = "Basil";
                            }
                            else if (v[0] == "cep")
                            {
                                form_END_CEP.Text = v[1].Replace(".", "").Replace("-", "");
                            }
                            else if (v[0] == "email")
                            {
                                form_CLI_EMAIL.Text = v[1];
                            }
                            else if (v[0] == "telefone")
                            {

                                string[] umnumero = Regex.Replace(v[1], "[()+ -]", "").Split('/');
                                form_CLI_TELEFONE.Text = umnumero[0];

                            }
                            else if (v[0] == "complemento")
                            {
                                form_END_COMPLEMENTO.Text = v[1];

                            }

                        }
                    }
                }

            }
            else { MessageBox.Show(url); }


        }


        private string[] ConsumirApi(string e)
        {//dado uma string (API ja formatada com dados) como entrada, Converte o json para string[] ,retorna o string[] com os dados solicitados.
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(e);
                request.AllowAutoRedirect = false;
                HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

                using (Stream webStream = ChecaServidor.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            string response = responseReader.ReadToEnd();
                            response = Regex.Replace(response, "[{},]", "");
                            response = response.Replace("\"", "");
                            string[] json = response.Split('\n');
                            return json;
                        }

                    }
                    else { return null; }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
                return null;
            }
        }

        private void TextKeyPress(object sender, KeyPressEventArgs e)
        {//defina o comportamento dos campos ao precionar teclas

                TextBox textBox = sender as TextBox;
                if (textBox != null)
                {

                        if (textBox.Name == "form_END_CEP")
                        {
                                    if (e.KeyChar == 13)
                                    {
                                        ConsultaCep();

                                    }
                                else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                                {
                                    e.Handled = true;
                                }
                            }
                        else if (textBox.Name == "form_CLI_COD")
                        {
                    
                                    if (e.KeyChar == 13 && form_CLI_COD.Text.Length == 14)
                                    {
                                        ConsultaCNPJ();
                                    }
                                else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                                {
                                    e.Handled = true;
                                }
                            }
                            else if (textBox.Name == "form_CLI_TELEFONE")
                            {

                                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                                {
                                    e.Handled = true;
                                }
                            }



            }
        }

        private void ConsultaCep()
        {//Consome uma API de consulta de CEP e formata os dados conforme necessario
                        string[] json = ConsumirApi("https://viacep.com.br/ws/" + form_END_CEP.Text + "/json/");
                        if (json!=null)
                        {
                            int i = 0;
                            foreach (var linha in json)
                            {
                                string[] v = linha.Split(":".ToCharArray());

                                if (i == 2)
                                    form_END_ENDERECO.Text = v[1];
                                if (i == 3)
                                    form_END_NUMERO.Text = v[1];
                                if (i == 4)
                                    form_END_BAIRRO.Text = v[1];
                                if (i == 5)
                                    form_END_CIDADE.Text = v[1];
                                if (i == 6)
                                {
                                    form_END_UF.Text = v[1];
                                    form_END_PAIS.Text = "Brasil";
                                    form_END_NUMERO.Focus();
                                }
                                i++;
                            }

                        }

        }


        private void form_bt_inativar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void DigitaSomenteNumeros(object sender, EventArgs e)
        {//Impede a entrada de caracteres incorretos no campo
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string text = textBox.Text;
                string somenteNumeros = Regex.Replace(text, "[^0-9]", "");
                if (text != somenteNumeros)
                {
                    textBox.Text = somenteNumeros;
            
                }
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
