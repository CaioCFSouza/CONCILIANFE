
namespace ConciliaNfeBig
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dir_busca = new System.Windows.Forms.TextBox();
			this.dir_salva = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cnpj_consulta = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.nota_consulta = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.lista_notas_encontradas = new System.Windows.Forms.TextBox();
			this.nao_encontradas = new System.Windows.Forms.TextBox();
			this.consultar_notas = new System.Windows.Forms.Button();
			this.limpar = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(233, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "Consulta NF-e conciliação";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label2.Location = new System.Drawing.Point(15, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Diretório busca:";
			// 
			// dir_busca
			// 
			this.dir_busca.Location = new System.Drawing.Point(18, 70);
			this.dir_busca.Multiline = true;
			this.dir_busca.Name = "dir_busca";
			this.dir_busca.Size = new System.Drawing.Size(594, 23);
			this.dir_busca.TabIndex = 2;
			this.dir_busca.TextChanged += new System.EventHandler(this.dir_busca_TextChanged);
			// 
			// dir_salva
			// 
			this.dir_salva.Location = new System.Drawing.Point(18, 117);
			this.dir_salva.Multiline = true;
			this.dir_salva.Name = "dir_salva";
			this.dir_salva.Size = new System.Drawing.Size(594, 23);
			this.dir_salva.TabIndex = 4;
			this.dir_salva.TextChanged += new System.EventHandler(this.dir_salva_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label3.Location = new System.Drawing.Point(15, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(185, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "Diretório salva notas encontradas:";
			// 
			// cnpj_consulta
			// 
			this.cnpj_consulta.Location = new System.Drawing.Point(18, 161);
			this.cnpj_consulta.Multiline = true;
			this.cnpj_consulta.Name = "cnpj_consulta";
			this.cnpj_consulta.Size = new System.Drawing.Size(594, 23);
			this.cnpj_consulta.TabIndex = 6;
			this.cnpj_consulta.TextChanged += new System.EventHandler(this.cnpj_consulta_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label4.Location = new System.Drawing.Point(15, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 15);
			this.label4.TabIndex = 5;
			this.label4.Text = "CNPJ consulta:";
			// 
			// nota_consulta
			// 
			this.nota_consulta.Location = new System.Drawing.Point(18, 205);
			this.nota_consulta.Multiline = true;
			this.nota_consulta.Name = "nota_consulta";
			this.nota_consulta.Size = new System.Drawing.Size(594, 114);
			this.nota_consulta.TabIndex = 8;
			this.nota_consulta.TextChanged += new System.EventHandler(this.nota_consulta_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label5.Location = new System.Drawing.Point(15, 187);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 15);
			this.label5.TabIndex = 7;
			this.label5.Text = "Notas consulta:";
			// 
			// lista_notas_encontradas
			// 
			this.lista_notas_encontradas.Location = new System.Drawing.Point(18, 344);
			this.lista_notas_encontradas.Multiline = true;
			this.lista_notas_encontradas.Name = "lista_notas_encontradas";
			this.lista_notas_encontradas.Size = new System.Drawing.Size(291, 94);
			this.lista_notas_encontradas.TabIndex = 10;
			this.lista_notas_encontradas.TextChanged += new System.EventHandler(this.lista_notas_encontradas_TextChanged);
			// 
			// nao_encontradas
			// 
			this.nao_encontradas.Location = new System.Drawing.Point(321, 344);
			this.nao_encontradas.Multiline = true;
			this.nao_encontradas.Name = "nao_encontradas";
			this.nao_encontradas.Size = new System.Drawing.Size(291, 94);
			this.nao_encontradas.TabIndex = 11;
			this.nao_encontradas.TextChanged += new System.EventHandler(this.nao_encontradas_TextChanged);
			// 
			// consultar_notas
			// 
			this.consultar_notas.Location = new System.Drawing.Point(713, 415);
			this.consultar_notas.Name = "consultar_notas";
			this.consultar_notas.Size = new System.Drawing.Size(75, 23);
			this.consultar_notas.TabIndex = 12;
			this.consultar_notas.Text = "Consultar";
			this.consultar_notas.UseVisualStyleBackColor = true;
			this.consultar_notas.Click += new System.EventHandler(this.consultar_notas_Click);
			// 
			// limpar
			// 
			this.limpar.Location = new System.Drawing.Point(632, 415);
			this.limpar.Name = "limpar";
			this.limpar.Size = new System.Drawing.Size(75, 23);
			this.limpar.TabIndex = 13;
			this.limpar.Text = "Limpar Filtro";
			this.limpar.UseVisualStyleBackColor = true;
			this.limpar.Click += new System.EventHandler(this.limpar_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label6.Location = new System.Drawing.Point(16, 326);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(109, 15);
			this.label6.TabIndex = 14;
			this.label6.Text = "Notas encontradas:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label7.Location = new System.Drawing.Point(318, 326);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(132, 15);
			this.label7.TabIndex = 15;
			this.label7.Text = "Notas não encontradas:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.limpar);
			this.Controls.Add(this.consultar_notas);
			this.Controls.Add(this.nao_encontradas);
			this.Controls.Add(this.lista_notas_encontradas);
			this.Controls.Add(this.nota_consulta);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cnpj_consulta);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dir_salva);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dir_busca);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Concilia NFe";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox dir_busca;
		private System.Windows.Forms.TextBox dir_salva;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox cnpj_consulta;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox nota_consulta;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox lista_notas_encontradas;
		private System.Windows.Forms.TextBox nao_encontradas;
		private System.Windows.Forms.Button consultar_notas;
		private System.Windows.Forms.Button limpar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
	}
}

