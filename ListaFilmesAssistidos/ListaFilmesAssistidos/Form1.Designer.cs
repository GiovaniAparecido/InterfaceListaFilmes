namespace ListaFilmesAssistidos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup58 = new System.Windows.Forms.ListViewGroup("Ação", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup59 = new System.Windows.Forms.ListViewGroup("Aventura", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup60 = new System.Windows.Forms.ListViewGroup("Comédia", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup61 = new System.Windows.Forms.ListViewGroup("Terror", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup62 = new System.Windows.Forms.ListViewGroup("Suspense", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup63 = new System.Windows.Forms.ListViewGroup("Documentário", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup64 = new System.Windows.Forms.ListViewGroup("Infantil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup65 = new System.Windows.Forms.ListViewGroup("Romance", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup66 = new System.Windows.Forms.ListViewGroup("Ficçãocientífica", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup67 = new System.Windows.Forms.ListViewGroup("Ação", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup68 = new System.Windows.Forms.ListViewGroup("Aventura", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup69 = new System.Windows.Forms.ListViewGroup("Comédia", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup70 = new System.Windows.Forms.ListViewGroup("Terror", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup71 = new System.Windows.Forms.ListViewGroup("Suspense", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup72 = new System.Windows.Forms.ListViewGroup("Documentário", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup73 = new System.Windows.Forms.ListViewGroup("Infantil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup74 = new System.Windows.Forms.ListViewGroup("Romanse", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup75 = new System.Windows.Forms.ListViewGroup("Ficçãocientífica", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup76 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.generocbox = new System.Windows.Forms.ComboBox();
            this.localtxt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nometxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bteditar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.btsalvar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.CNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CGenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLocal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.LNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LGênero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LLocalAssistido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.generocbox);
            this.groupBox1.Controls.Add(this.localtxt);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.nometxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Digite os dados a serem salvos sobre o filme!";
            // 
            // generocbox
            // 
            this.generocbox.FormattingEnabled = true;
            this.generocbox.Items.AddRange(new object[] {
            "Ação",
            "Aventura",
            "Comédia",
            "Documentário",
            "FicçãoCientífica",
            "Infantil",
            "Romance",
            "Suspense",
            "Terror"});
            this.generocbox.Location = new System.Drawing.Point(9, 71);
            this.generocbox.Name = "generocbox";
            this.generocbox.Size = new System.Drawing.Size(121, 21);
            this.generocbox.TabIndex = 10;
            this.generocbox.SelectedIndexChanged += new System.EventHandler(this.generocbox_SelectedIndexChanged_1);
            // 
            // localtxt
            // 
            this.localtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.localtxt.Location = new System.Drawing.Point(9, 111);
            this.localtxt.Name = "localtxt";
            this.localtxt.Size = new System.Drawing.Size(436, 20);
            this.localtxt.TabIndex = 9;
            this.localtxt.TextChanged += new System.EventHandler(this.localtxt_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(90, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // nometxt
            // 
            this.nometxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nometxt.Location = new System.Drawing.Point(9, 32);
            this.nometxt.Name = "nometxt";
            this.nometxt.Size = new System.Drawing.Size(436, 20);
            this.nometxt.TabIndex = 4;
            this.nometxt.TextChanged += new System.EventHandler(this.nometxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Local assistido";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(145, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gênero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // bteditar
            // 
            this.bteditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bteditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bteditar.Enabled = false;
            this.bteditar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bteditar.Location = new System.Drawing.Point(405, 160);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(75, 23);
            this.bteditar.TabIndex = 3;
            this.bteditar.Text = "&Editar";
            this.bteditar.UseVisualStyleBackColor = true;
            this.bteditar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeletar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btDeletar.Enabled = false;
            this.btDeletar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btDeletar.Location = new System.Drawing.Point(324, 160);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(75, 23);
            this.btDeletar.TabIndex = 1;
            this.btDeletar.Text = "&Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btsalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btsalvar.Location = new System.Drawing.Point(243, 160);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(75, 23);
            this.btsalvar.TabIndex = 0;
            this.btsalvar.Text = "&Salvar";
            this.btsalvar.UseVisualStyleBackColor = true;
            this.btsalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CNome,
            this.CGenero,
            this.CData,
            this.CLocal});
            this.listView1.FullRowSelect = true;
            listViewGroup58.Header = "Ação";
            listViewGroup58.Name = "Ação";
            listViewGroup59.Header = "Aventura";
            listViewGroup59.Name = "Aventura";
            listViewGroup60.Header = "Comédia";
            listViewGroup60.Name = "Comédia";
            listViewGroup61.Header = "Terror";
            listViewGroup61.Name = "Terror";
            listViewGroup62.Header = "Suspense";
            listViewGroup62.Name = "Suspense";
            listViewGroup63.Header = "Documentário";
            listViewGroup63.Name = "Documentário";
            listViewGroup64.Header = "Infantil";
            listViewGroup64.Name = "Infantil";
            listViewGroup65.Header = "Romance";
            listViewGroup65.Name = "Romance";
            listViewGroup66.Header = "Ficçãocientífica";
            listViewGroup66.Name = "Ficçãocientífica";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup58,
            listViewGroup59,
            listViewGroup60,
            listViewGroup61,
            listViewGroup62,
            listViewGroup63,
            listViewGroup64,
            listViewGroup65,
            listViewGroup66});
            this.listView1.Location = new System.Drawing.Point(12, 189);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(468, 153);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // CNome
            // 
            this.CNome.Text = "Nome";
            this.CNome.Width = 162;
            // 
            // CGenero
            // 
            this.CGenero.Text = "Gênero";
            this.CGenero.Width = 91;
            // 
            // CData
            // 
            this.CData.Text = "Data";
            this.CData.Width = 84;
            // 
            // CLocal
            // 
            this.CLocal.Text = "Local Assistido";
            this.CLocal.Width = 189;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LNome,
            this.LGênero,
            this.LData,
            this.LLocalAssistido});
            listViewGroup67.Header = "Ação";
            listViewGroup67.Name = "Ação";
            listViewGroup68.Header = "Aventura";
            listViewGroup68.Name = "Aventura";
            listViewGroup69.Header = "Comédia";
            listViewGroup69.Name = "Comédia";
            listViewGroup70.Header = "Terror";
            listViewGroup70.Name = "Terror";
            listViewGroup71.Header = "Suspense";
            listViewGroup71.Name = "Suspense";
            listViewGroup72.Header = "Documentário";
            listViewGroup72.Name = "Documentário";
            listViewGroup73.Header = "Infantil";
            listViewGroup73.Name = "Infantil";
            listViewGroup74.Header = "Romanse";
            listViewGroup74.Name = "Romance";
            listViewGroup75.Header = "Ficçãocientífica";
            listViewGroup75.Name = "Ficçãocientífica";
            listViewGroup76.Header = "ListViewGroup";
            listViewGroup76.Name = "listViewGroup1";
            this.listView2.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup67,
            listViewGroup68,
            listViewGroup69,
            listViewGroup70,
            listViewGroup71,
            listViewGroup72,
            listViewGroup73,
            listViewGroup74,
            listViewGroup75,
            listViewGroup76});
            this.listView2.Location = new System.Drawing.Point(226, 402);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(828, 131);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.Visible = false;
            // 
            // LNome
            // 
            this.LNome.Text = "Nome";
            this.LNome.Width = 158;
            // 
            // LGênero
            // 
            this.LGênero.Text = "Gênero";
            this.LGênero.Width = 119;
            // 
            // LData
            // 
            this.LData.Text = "Data";
            this.LData.Width = 114;
            // 
            // LLocalAssistido
            // 
            this.LLocalAssistido.Text = "Local Assistido";
            this.LLocalAssistido.Width = 203;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(492, 354);
            this.Controls.Add(this.bteditar);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Cadastro de filmes assistidos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nometxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btsalvar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader CNome;
        private System.Windows.Forms.ColumnHeader CGenero;
        private System.Windows.Forms.ColumnHeader CData;
        private System.Windows.Forms.ColumnHeader CLocal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader LNome;
        private System.Windows.Forms.ColumnHeader LGênero;
        private System.Windows.Forms.ColumnHeader LData;
        private System.Windows.Forms.ColumnHeader LLocalAssistido;
        private System.Windows.Forms.TextBox localtxt;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox generocbox;
    }
}

