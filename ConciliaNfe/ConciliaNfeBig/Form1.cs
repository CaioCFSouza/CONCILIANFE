using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConciliaNfeBig
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void dir_busca_TextChanged(object sender, EventArgs e)
		{

		}

		private void dir_salva_TextChanged(object sender, EventArgs e)
		{

		}

		private void cnpj_consulta_TextChanged(object sender, EventArgs e)
		{

		}

		private void nota_consulta_TextChanged(object sender, EventArgs e)
		{

		}

		private void lista_notas_encontradas_TextChanged(object sender, EventArgs e)
		{

		}

		private void nao_encontradas_TextChanged(object sender, EventArgs e)
		{

		}

		private void consultar_notas_Click(object sender, EventArgs e)
		{
			lista_notas_encontradas.Clear();
			string pegaDir = recPasta();
			string pegaCnpj = recCnpj();
			string pegaNota = recNota();
			string copiaNota = recCaminhoCopiaNfe();

			var acessaPasta = lerDir(pegaDir, pegaCnpj);
			var arqDestino = "";
			try
			{
				//Consulta notas por CNPJ
				foreach (string entrada in acessaPasta)
				{
					arqDestino = Path.GetFileName(entrada);

					//Copia notas por CNPJ
					File.Copy(entrada, copiaNota + "\\" + arqDestino, true);

				}
			}
			catch
			{
				MessageBox.Show("Por favor, exclua os registros copiados.");
			}

			procuraNota(copiaNota, pegaNota);
			comparaNotas(pegaNota);
		}
		private string recPasta()
		{
			string retDir = dir_busca.Text;
			return retDir;
		}

		private string recCnpj()
		{
			string retCnpj = cnpj_consulta.Text;
			return retCnpj;
		}
		private string recNota()
		{
			string retNota = nota_consulta.Text;
			return retNota;
		}

		private string recCaminhoCopiaNfe()
		{
			string retCopia = dir_salva.Text;
			return retCopia;
		}

		private void limpar_Click(object sender, EventArgs e)
		{
			excluiXmlsSalvos();
		}

		private string[] lerDir(string path, string cnpj)
		{
			try
			{

				if (path == null || path == "")
				{
					MessageBox.Show("Por favor, digite o caminho.");
				}
				string[] retorna_dados = Directory.GetFiles(path, "*" + cnpj + "*", SearchOption.AllDirectories);

				return retorna_dados;

			}
			catch
			{
				MessageBox.Show("Diretório não é valido.");
				string[] ret = { "" };
				return ret;
			}

			//Consulta notas
		}

		private string[] procuraNota(string path, string nota)
		{
			try
			{
				string[] retornaNotas = null;
				string[] listaGetFiles = null;

				string dirFinal = "";
				dirFinal = dir_salva.Text + @"\xmlsConciliados";

				var salvaArquivoDestino = "";

				if (path == null || path == "")
				{
					MessageBox.Show("Por favor, digite o caminho.");
				}
				Directory.CreateDirectory(dirFinal);


				if (Directory.Exists(dirFinal))
				{
					Directory.Delete(dirFinal);
					Directory.CreateDirectory(dirFinal);

					string pegaCnpj = recCnpj();

					int cont = 0;

					string[] pegaNotasFormat = nota.Split(',');
					for (int j = 0; j < pegaNotasFormat.Length; j++)
					{
						listaGetFiles = Directory.GetFiles(path, "*" + pegaNotasFormat[j] + "*", SearchOption.AllDirectories);

						foreach (string recebeListaGetFiles in listaGetFiles)
						{
							//notas_encontradas.Items.Add(Path.GetFileName(recebeListaGetFiles));
							lista_notas_encontradas.Text += pegaNotasFormat[j] + ",";
							salvaArquivoDestino = Path.GetFileName(recebeListaGetFiles);
							File.Copy(recebeListaGetFiles, dirFinal + "\\" + salvaArquivoDestino, true);
							cont += 1;
						}
					}
					string contConvert = cont.ToString();
					MessageBox.Show(contConvert + " Notas encontradas para o CNPJ " + pegaCnpj);
				}

				return retornaNotas;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro: " + ex);
				string[] ret = { "" };
				return ret;
			}
		}

		private void comparaNotas(string notas)
		{
			nao_encontradas.Clear();
			string[] pegaNotasFormat = notas.Split(',');
			string[] notasEncontradas = lista_notas_encontradas.Text.Split(',');

			//Le - Compara dados entre arrays
			for (int i = 0; i < pegaNotasFormat.Length; i++)
			{
				for (int k = 0; k < notasEncontradas.Length; k++)
				{
					//Acrescenta OK se igual
					if (pegaNotasFormat[i] == notasEncontradas[k])
					{
						pegaNotasFormat[i] = pegaNotasFormat[i] + "OK";
					}
				}
			}

			var lista = pegaNotasFormat.ToList();
			//Remove posicoes com OK
			for (int l = 0; l < pegaNotasFormat.Length; l++)
			{
				if (pegaNotasFormat[l].Contains("OK"))
				{
					lista.Remove(pegaNotasFormat[l]);
				}

			}

			foreach (string listaDados in lista)
			{
				nao_encontradas.Text += listaDados + ",";
			}
		}

		private void excluiXmlsSalvos()
		{
			//Deleta xmls pasta xmlsConciliados
			string[] deletaNotasConciladas = null;
			var pegaNomeNotas = "";

			string dirFinal = "";
			dirFinal = dir_salva.Text + @"\xmlsConciliados";

			try
			{

				deletaNotasConciladas = Directory.GetFiles(dirFinal, "*", SearchOption.AllDirectories);

				for (int m = 0; m < deletaNotasConciladas.Length; m++)
				{
					pegaNomeNotas = Path.GetFileName(deletaNotasConciladas[m]);
					File.Delete(dirFinal + "\\" + pegaNomeNotas);
				}

				//Deleta todos os xmls 
				string[] deletaNotas = null;
				var deletaNotasGeral = "";
				string copiaNota = recCaminhoCopiaNfe();

				deletaNotas = Directory.GetFiles(copiaNota, "*", SearchOption.AllDirectories);

				for (int n = 0; n < deletaNotas.Length; n++)
				{
					deletaNotasGeral = Path.GetFileName(deletaNotas[n]);
					File.Delete(copiaNota + "\\" + deletaNotasGeral);
				}
				Directory.Delete(dirFinal);
				lista_notas_encontradas.Clear();
				nao_encontradas.Clear();
			}	catch
			{
				MessageBox.Show("Não existe dados para limpar.");
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
