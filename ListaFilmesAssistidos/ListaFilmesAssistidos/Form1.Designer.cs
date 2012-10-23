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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Ação", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Aventura", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Comédia", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Terror", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Suspense", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Documentário", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Infantil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Romance", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("Ficçãocientífica", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("Ação", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup11 = new System.Windows.Forms.ListViewGroup("Aventura", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup12 = new System.Windows.Forms.ListViewGroup("Comédia", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup13 = new System.Windows.Forms.ListViewGroup("Terror", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup14 = new System.Windows.Forms.ListViewGroup("Suspense", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup15 = new System.Windows.Forms.ListViewGroup("Documentário", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup16 = new System.Windows.Forms.ListViewGroup("Infantil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup17 = new System.Windows.Forms.ListViewGroup("Romanse", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup18 = new System.Windows.Forms.ListViewGroup("Ficçãocientífica", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup19 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.localtxt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.generocbox = new System.Windows.Forms.ComboBox();
            this.nometxt = new System.Windows.Forms.TextBox();
            this.lbl_Local = new System.Windows.Forms.Label();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.lbl_Genero = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.localtxt);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.generocbox);
            this.groupBox1.Controls.Add(this.nometxt);
            this.groupBox1.Controls.Add(this.lbl_Local);
            this.groupBox1.Controls.Add(this.lbl_Data);
            this.groupBox1.Controls.Add(this.lbl_Genero);
            this.groupBox1.Controls.Add(this.lbl_Titulo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Digite os dados a serem salvos sobre o filme!";
            // 
            // localtxt
            // 
            this.localtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.localtxt.Location = new System.Drawing.Point(21, 111);
            this.localtxt.Name = "localtxt";
            this.localtxt.Size = new System.Drawing.Size(441, 20);
            this.localtxt.TabIndex = 4;
            this.localtxt.Enter += new System.EventHandler(this.localtxt_Enter_1);
            this.localtxt.Leave += new System.EventHandler(this.localtxt_Leave_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 3;
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
            this.generocbox.Location = new System.Drawing.Point(21, 71);
            this.generocbox.Name = "generocbox";
            this.generocbox.Size = new System.Drawing.Size(121, 21);
            this.generocbox.TabIndex = 2;
            this.generocbox.Enter += new System.EventHandler(this.generocbox_Enter);
            this.generocbox.Leave += new System.EventHandler(this.generocbox_Leave);
            // 
            // nometxt
            // 
            this.nometxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nometxt.Location = new System.Drawing.Point(21, 32);
            this.nometxt.Name = "nometxt";
            this.nometxt.Size = new System.Drawing.Size(441, 20);
            this.nometxt.TabIndex = 1;
            this.nometxt.Enter += new System.EventHandler(this.nometxt_Enter);
            this.nometxt.Leave += new System.EventHandler(this.nometxt_Leave);
            // 
            // lbl_Local
            // 
            this.lbl_Local.AutoSize = true;
            this.lbl_Local.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Local.Location = new System.Drawing.Point(18, 95);
            this.lbl_Local.Name = "lbl_Local";
            this.lbl_Local.Size = new System.Drawing.Size(76, 13);
            this.lbl_Local.TabIndex = 3;
            this.lbl_Local.Text = "Local assistido";
            // 
            // lbl_Data
            // 
            this.lbl_Data.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Data.Location = new System.Drawing.Point(147, 54);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(30, 13);
            this.lbl_Data.TabIndex = 2;
            this.lbl_Data.Text = "Data";
            this.lbl_Data.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_Genero
            // 
            this.lbl_Genero.AutoSize = true;
            this.lbl_Genero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Genero.Location = new System.Drawing.Point(18, 55);
            this.lbl_Genero.Name = "lbl_Genero";
            this.lbl_Genero.Size = new System.Drawing.Size(42, 13);
            this.lbl_Genero.TabIndex = 1;
            this.lbl_Genero.Text = "Gênero";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Titulo.Location = new System.Drawing.Point(18, 16);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(35, 13);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Título";
            // 
            // bteditar
            // 
            this.bteditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bteditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bteditar.Enabled = false;
            this.bteditar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bteditar.Location = new System.Drawing.Point(410, 160);
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
            this.btDeletar.Location = new System.Drawing.Point(329, 160);
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
            this.btsalvar.Location = new System.Drawing.Point(248, 160);
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
            listViewGroup1.Header = "Ação";
            listViewGroup1.Name = "Ação";
            listViewGroup2.Header = "Aventura";
            listViewGroup2.Name = "Aventura";
            listViewGroup3.Header = "Comédia";
            listViewGroup3.Name = "Comédia";
            listViewGroup4.Header = "Terror";
            listViewGroup4.Name = "Terror";
            listViewGroup5.Header = "Suspense";
            listViewGroup5.Name = "Suspense";
            listViewGroup6.Header = "Documentário";
            listViewGroup6.Name = "Documentário";
            listViewGroup7.Header = "Infantil";
            listViewGroup7.Name = "Infantil";
            listViewGroup8.Header = "Romance";
            listViewGroup8.Name = "Romance";
            listViewGroup9.Header = "Ficçãocientífica";
            listViewGroup9.Name = "Ficçãocientífica";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8,
            listViewGroup9});
            this.listView1.Location = new System.Drawing.Point(12, 189);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(473, 153);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // CNome
            // 
            this.CNome.Text = "Nome";
            this.CNome.Width = 116;
            // 
            // CGenero
            // 
            this.CGenero.Text = "Gênero";
            this.CGenero.Width = 100;
            // 
            // CData
            // 
            this.CData.Text = "Data";
            this.CData.Width = 107;
            // 
            // CLocal
            // 
            this.CLocal.Text = "Local Assistido";
            this.CLocal.Width = 135;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LNome,
            this.LGênero,
            this.LData,
            this.LLocalAssistido});
            listViewGroup10.Header = "Ação";
            listViewGroup10.Name = "Ação";
            listViewGroup11.Header = "Aventura";
            listViewGroup11.Name = "Aventura";
            listViewGroup12.Header = "Comédia";
            listViewGroup12.Name = "Comédia";
            listViewGroup13.Header = "Terror";
            listViewGroup13.Name = "Terror";
            listViewGroup14.Header = "Suspense";
            listViewGroup14.Name = "Suspense";
            listViewGroup15.Header = "Documentário";
            listViewGroup15.Name = "Documentário";
            listViewGroup16.Header = "Infantil";
            listViewGroup16.Name = "Infantil";
            listViewGroup17.Header = "Romanse";
            listViewGroup17.Name = "Romance";
            listViewGroup18.Header = "Ficçãocientífica";
            listViewGroup18.Name = "Ficçãocientífica";
            listViewGroup19.Header = "ListViewGroup";
            listViewGroup19.Name = "listViewGroup1";
            this.listView2.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup10,
            listViewGroup11,
            listViewGroup12,
            listViewGroup13,
            listViewGroup14,
            listViewGroup15,
            listViewGroup16,
            listViewGroup17,
            listViewGroup18,
            listViewGroup19});
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
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btsalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(497, 354);
            this.Controls.Add(this.bteditar);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(513, 392);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lbl_Local;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.Label lbl_Genero;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btsalvar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader CNome;
        private System.Windows.Forms.ColumnHeader CGenero;
        private System.Windows.Forms.ColumnHeader CData;
        private System.Windows.Forms.ColumnHeader CLocal;
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader LNome;
        private System.Windows.Forms.ColumnHeader LGênero;
        private System.Windows.Forms.ColumnHeader LData;
        private System.Windows.Forms.ColumnHeader LLocalAssistido;
        private System.Windows.Forms.ComboBox generocbox;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox localtxt;
    }
}

