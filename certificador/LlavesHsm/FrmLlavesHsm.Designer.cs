namespace LlavesHsm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.LvAliases = new System.Windows.Forms.ListView();
            this.llavesprivadas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.llavespublicas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CtxListaLlaves = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CtxBorrarObjeto = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LblEnc = new System.Windows.Forms.Label();
            this.BtnActLlaves = new System.Windows.Forms.Button();
            this.CbEnc = new System.Windows.Forms.ComboBox();
            this.btnRuta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.RbCert = new System.Windows.Forms.RadioButton();
            this.RbPrivada = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.TxtKeyPairAlias = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.TxtLlaveSimetrica = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.TxtChallenge = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.BtnCrearCsr = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.CbPub2 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CbPriv2 = new System.Windows.Forms.ComboBox();
            this.TxtCn = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtO2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtO = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtUniqueIdentifier = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtSn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtOU = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txtRutaCert = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtFirma = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CbPrivadas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTexto = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.CtxListaLlaves.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(10, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(633, 366);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.LvAliases);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(625, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Objetos en el HSM";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Detalle:";
            // 
            // LvAliases
            // 
            this.LvAliases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LvAliases.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.llavesprivadas,
            this.llavespublicas});
            this.LvAliases.ContextMenuStrip = this.CtxListaLlaves;
            this.LvAliases.Cursor = System.Windows.Forms.Cursors.Default;
            this.LvAliases.LargeImageList = this.imageList1;
            this.LvAliases.Location = new System.Drawing.Point(20, 44);
            this.LvAliases.Margin = new System.Windows.Forms.Padding(2);
            this.LvAliases.Name = "LvAliases";
            this.LvAliases.Size = new System.Drawing.Size(583, 220);
            this.LvAliases.SmallImageList = this.imageList1;
            this.LvAliases.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.LvAliases.StateImageList = this.imageList1;
            this.LvAliases.TabIndex = 14;
            this.LvAliases.TileSize = new System.Drawing.Size(1, 1);
            this.LvAliases.UseCompatibleStateImageBehavior = false;
            this.LvAliases.View = System.Windows.Forms.View.Details;
            // 
            // llavesprivadas
            // 
            this.llavesprivadas.Text = "Alias";
            this.llavesprivadas.Width = 200;
            // 
            // llavespublicas
            // 
            this.llavespublicas.Text = "Tipo de objeto";
            this.llavespublicas.Width = 150;
            // 
            // CtxListaLlaves
            // 
            this.CtxListaLlaves.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtxBorrarObjeto});
            this.CtxListaLlaves.Name = "CtxListaLlaves";
            this.CtxListaLlaves.Size = new System.Drawing.Size(118, 26);
            this.CtxListaLlaves.Opening += new System.ComponentModel.CancelEventHandler(this.CtxListaLlaves_Opening);
            // 
            // CtxBorrarObjeto
            // 
            this.CtxBorrarObjeto.Name = "CtxBorrarObjeto";
            this.CtxBorrarObjeto.Size = new System.Drawing.Size(152, 22);
            this.CtxBorrarObjeto.Text = "Eliminar";
            this.CtxBorrarObjeto.Click += new System.EventHandler(this.CtxBorrarObjeto_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.DarkGray;
            this.imageList1.Images.SetKeyName(0, "key");
            this.imageList1.Images.SetKeyName(1, "cert");
            this.imageList1.Images.SetKeyName(2, "image_preview.jpg");
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Image = global::LlavesHsm.Properties.Resources.arrow_rotate_anticlockwise;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(512, 280);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 40);
            this.button4.TabIndex = 13;
            this.button4.Text = "Actualizar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button12);
            this.tabPage2.Controls.Add(this.LblEnc);
            this.tabPage2.Controls.Add(this.BtnActLlaves);
            this.tabPage2.Controls.Add(this.CbEnc);
            this.tabPage2.Controls.Add(this.btnRuta);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtAlias);
            this.tabPage2.Controls.Add(this.lblContra);
            this.tabPage2.Controls.Add(this.txtcontra);
            this.tabPage2.Controls.Add(this.RbCert);
            this.tabPage2.Controls.Add(this.RbPrivada);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtRuta);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(625, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Subir Objetos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LblEnc
            // 
            this.LblEnc.AutoSize = true;
            this.LblEnc.Location = new System.Drawing.Point(50, 213);
            this.LblEnc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEnc.Name = "LblEnc";
            this.LblEnc.Size = new System.Drawing.Size(119, 15);
            this.LblEnc.TabIndex = 20;
            this.LblEnc.Text = "Encriptar con la llave:";
            this.LblEnc.Click += new System.EventHandler(this.label5_Click);
            // 
            // BtnActLlaves
            // 
            this.BtnActLlaves.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnActLlaves.Image = global::LlavesHsm.Properties.Resources.arrow_rotate_anticlockwise;
            this.BtnActLlaves.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActLlaves.Location = new System.Drawing.Point(450, 204);
            this.BtnActLlaves.Margin = new System.Windows.Forms.Padding(2);
            this.BtnActLlaves.Name = "BtnActLlaves";
            this.BtnActLlaves.Size = new System.Drawing.Size(91, 40);
            this.BtnActLlaves.TabIndex = 7;
            this.BtnActLlaves.Text = "Actualizar";
            this.BtnActLlaves.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnActLlaves.UseVisualStyleBackColor = true;
            this.BtnActLlaves.Click += new System.EventHandler(this.button6_Click);
            // 
            // CbEnc
            // 
            this.CbEnc.FormattingEnabled = true;
            this.CbEnc.Location = new System.Drawing.Point(189, 211);
            this.CbEnc.Name = "CbEnc";
            this.CbEnc.Size = new System.Drawing.Size(242, 23);
            this.CbEnc.TabIndex = 6;
            // 
            // btnRuta
            // 
            this.btnRuta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuta.Location = new System.Drawing.Point(450, 85);
            this.btnRuta.Margin = new System.Windows.Forms.Padding(2);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(30, 28);
            this.btnRuta.TabIndex = 3;
            this.btnRuta.Text = "...";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Alias:";
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(189, 129);
            this.txtAlias.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(242, 23);
            this.txtAlias.TabIndex = 4;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(99, 171);
            this.lblContra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(70, 15);
            this.lblContra.TabIndex = 16;
            this.lblContra.Text = "Contraseña:";
            // 
            // txtcontra
            // 
            this.txtcontra.Location = new System.Drawing.Point(189, 169);
            this.txtcontra.Margin = new System.Windows.Forms.Padding(2);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.PasswordChar = '*';
            this.txtcontra.Size = new System.Drawing.Size(242, 23);
            this.txtcontra.TabIndex = 5;
            // 
            // RbCert
            // 
            this.RbCert.AutoSize = true;
            this.RbCert.Location = new System.Drawing.Point(263, 41);
            this.RbCert.Margin = new System.Windows.Forms.Padding(2);
            this.RbCert.Name = "RbCert";
            this.RbCert.Size = new System.Drawing.Size(83, 19);
            this.RbCert.TabIndex = 1;
            this.RbCert.Text = "Certificado";
            this.RbCert.UseVisualStyleBackColor = true;
            this.RbCert.CheckedChanged += new System.EventHandler(this.RbPrivada_CheckedChanged);
            // 
            // RbPrivada
            // 
            this.RbPrivada.AutoSize = true;
            this.RbPrivada.Checked = true;
            this.RbPrivada.Location = new System.Drawing.Point(122, 41);
            this.RbPrivada.Margin = new System.Windows.Forms.Padding(2);
            this.RbPrivada.Name = "RbPrivada";
            this.RbPrivada.Size = new System.Drawing.Size(94, 19);
            this.RbPrivada.TabIndex = 0;
            this.RbPrivada.TabStop = true;
            this.RbPrivada.Text = "Llave Privada";
            this.RbPrivada.UseVisualStyleBackColor = true;
            this.RbPrivada.CheckedChanged += new System.EventHandler(this.RbPrivada_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ruta del archivo:";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(189, 87);
            this.txtRuta.Margin = new System.Windows.Forms.Padding(2);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(242, 23);
            this.txtRuta.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Image = global::LlavesHsm.Properties.Resources.key_add;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(450, 264);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 41);
            this.button3.TabIndex = 8;
            this.button3.Text = "Subir";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button10);
            this.tabPage3.Controls.Add(this.TxtKeyPairAlias);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.TxtLlaveSimetrica);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(625, 338);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Crear Objetos";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // button10
            // 
            this.button10.Image = global::LlavesHsm.Properties.Resources.key_add;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(478, 65);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(91, 39);
            this.button10.TabIndex = 16;
            this.button10.Text = "Crear";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // TxtKeyPairAlias
            // 
            this.TxtKeyPairAlias.Location = new System.Drawing.Point(270, 71);
            this.TxtKeyPairAlias.Name = "TxtKeyPairAlias";
            this.TxtKeyPairAlias.Size = new System.Drawing.Size(178, 23);
            this.TxtKeyPairAlias.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(131, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 15);
            this.label17.TabIndex = 14;
            this.label17.Text = "Par de llaves";
            // 
            // button5
            // 
            this.button5.Image = global::LlavesHsm.Properties.Resources.key_add;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(478, 16);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 39);
            this.button5.TabIndex = 13;
            this.button5.Text = "Crear";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // TxtLlaveSimetrica
            // 
            this.TxtLlaveSimetrica.Location = new System.Drawing.Point(270, 22);
            this.TxtLlaveSimetrica.Name = "TxtLlaveSimetrica";
            this.TxtLlaveSimetrica.Size = new System.Drawing.Size(178, 23);
            this.TxtLlaveSimetrica.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Alias de la llave simetrica (DES3)";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button11);
            this.tabPage5.Controls.Add(this.TxtChallenge);
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.BtnCrearCsr);
            this.tabPage5.Controls.Add(this.button9);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.CbPub2);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.CbPriv2);
            this.tabPage5.Controls.Add(this.TxtCn);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.TxtO2);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.TxtO);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.TxtUniqueIdentifier);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.TxtSn);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.TxtOU);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(625, 338);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Generar CSR";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Image = global::LlavesHsm.Properties.Resources.key_add;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(278, 294);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(144, 39);
            this.button11.TabIndex = 29;
            this.button11.Text = "Crear por Software";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // TxtChallenge
            // 
            this.TxtChallenge.Location = new System.Drawing.Point(150, 252);
            this.TxtChallenge.Name = "TxtChallenge";
            this.TxtChallenge.Size = new System.Drawing.Size(407, 23);
            this.TxtChallenge.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 255);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 15);
            this.label18.TabIndex = 27;
            this.label18.Text = "Challenge Password";
            // 
            // BtnCrearCsr
            // 
            this.BtnCrearCsr.Image = global::LlavesHsm.Properties.Resources.key_add;
            this.BtnCrearCsr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCrearCsr.Location = new System.Drawing.Point(466, 294);
            this.BtnCrearCsr.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCrearCsr.Name = "BtnCrearCsr";
            this.BtnCrearCsr.Size = new System.Drawing.Size(91, 39);
            this.BtnCrearCsr.TabIndex = 26;
            this.BtnCrearCsr.Text = "Crear";
            this.BtnCrearCsr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCrearCsr.UseVisualStyleBackColor = true;
            this.BtnCrearCsr.Click += new System.EventHandler(this.BtnCrearCsr_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Image = global::LlavesHsm.Properties.Resources.arrow_rotate_anticlockwise;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(406, 6);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(91, 40);
            this.button9.TabIndex = 25;
            this.button9.Text = "Actualizar";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 45);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 15);
            this.label16.TabIndex = 24;
            this.label16.Text = "Alias LlavePública";
            // 
            // CbPub2
            // 
            this.CbPub2.FormattingEnabled = true;
            this.CbPub2.Location = new System.Drawing.Point(150, 45);
            this.CbPub2.Name = "CbPub2";
            this.CbPub2.Size = new System.Drawing.Size(242, 23);
            this.CbPub2.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 16);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 15);
            this.label15.TabIndex = 22;
            this.label15.Text = "Alias Llave Privada";
            // 
            // CbPriv2
            // 
            this.CbPriv2.FormattingEnabled = true;
            this.CbPriv2.Location = new System.Drawing.Point(150, 16);
            this.CbPriv2.Name = "CbPriv2";
            this.CbPriv2.Size = new System.Drawing.Size(242, 23);
            this.CbPriv2.TabIndex = 21;
            // 
            // TxtCn
            // 
            this.TxtCn.Location = new System.Drawing.Point(150, 223);
            this.TxtCn.Name = "TxtCn";
            this.TxtCn.Size = new System.Drawing.Size(407, 23);
            this.TxtCn.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(107, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 15);
            this.label14.TabIndex = 10;
            this.label14.Text = "CN";
            // 
            // TxtO2
            // 
            this.TxtO2.Location = new System.Drawing.Point(150, 194);
            this.TxtO2.Name = "TxtO2";
            this.TxtO2.Size = new System.Drawing.Size(407, 23);
            this.TxtO2.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(85, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 15);
            this.label13.TabIndex = 8;
            this.label13.Text = "2.5.4.41";
            // 
            // TxtO
            // 
            this.TxtO.Location = new System.Drawing.Point(150, 165);
            this.TxtO.Name = "TxtO";
            this.TxtO.Size = new System.Drawing.Size(407, 23);
            this.TxtO.TabIndex = 7;
            this.TxtO.Text = "SERVICIO DE ADMINISTRACION TRIBUTARIA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(115, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "O";
            // 
            // TxtUniqueIdentifier
            // 
            this.TxtUniqueIdentifier.Location = new System.Drawing.Point(150, 136);
            this.TxtUniqueIdentifier.Name = "TxtUniqueIdentifier";
            this.TxtUniqueIdentifier.Size = new System.Drawing.Size(407, 23);
            this.TxtUniqueIdentifier.TabIndex = 5;
            this.TxtUniqueIdentifier.Text = "SAT970701NN3 / GATF730321GG5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(85, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "2.5.4.45";
            // 
            // TxtSn
            // 
            this.TxtSn.Location = new System.Drawing.Point(150, 107);
            this.TxtSn.Name = "TxtSn";
            this.TxtSn.Size = new System.Drawing.Size(407, 23);
            this.TxtSn.TabIndex = 3;
            this.TxtSn.Text = " / GATF730321HJCRRR01";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Serial Number";
            // 
            // TxtOU
            // 
            this.TxtOU.Location = new System.Drawing.Point(150, 78);
            this.TxtOU.Name = "TxtOU";
            this.TxtOU.Size = new System.Drawing.Size(407, 23);
            this.TxtOU.TabIndex = 1;
            this.TxtOU.Text = "PACNLC091211KC657202";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(107, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "OU";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button8);
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Controls.Add(this.txtRutaCert);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.TxtFirma);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.CbPrivadas);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.TxtTexto);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(625, 338);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Probar";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(496, 296);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "Verificar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(462, 296);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(28, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "...";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtRutaCert
            // 
            this.txtRutaCert.Location = new System.Drawing.Point(104, 297);
            this.txtRutaCert.Name = "txtRutaCert";
            this.txtRutaCert.Size = new System.Drawing.Size(352, 23);
            this.txtRutaCert.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Certificado";
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Image = global::LlavesHsm.Properties.Resources.arrow_rotate_anticlockwise;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(330, 5);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 40);
            this.button6.TabIndex = 8;
            this.button6.Text = "Actualizar";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Resultado";
            // 
            // TxtFirma
            // 
            this.TxtFirma.Location = new System.Drawing.Point(104, 185);
            this.TxtFirma.Multiline = true;
            this.TxtFirma.Name = "TxtFirma";
            this.TxtFirma.Size = new System.Drawing.Size(467, 100);
            this.TxtFirma.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(496, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Firmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // CbPrivadas
            // 
            this.CbPrivadas.FormattingEnabled = true;
            this.CbPrivadas.Location = new System.Drawing.Point(104, 15);
            this.CbPrivadas.Name = "CbPrivadas";
            this.CbPrivadas.Size = new System.Drawing.Size(221, 23);
            this.CbPrivadas.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Llave";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Texto a Firmar";
            // 
            // TxtTexto
            // 
            this.TxtTexto.Location = new System.Drawing.Point(104, 50);
            this.TxtTexto.Multiline = true;
            this.TxtTexto.Name = "TxtTexto";
            this.TxtTexto.Size = new System.Drawing.Size(467, 97);
            this.TxtTexto.TabIndex = 0;
            this.TxtTexto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Image = global::LlavesHsm.Properties.Resources.door_in;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(548, 381);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cerrar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button12
            // 
            this.button12.Image = global::LlavesHsm.Properties.Resources.key_add;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(272, 264);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(159, 41);
            this.button12.TabIndex = 21;
            this.button12.Text = "Subir en claro";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 429);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subir Llaves al HSM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.CtxListaLlaves.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton RbCert;
        private System.Windows.Forms.RadioButton RbPrivada;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.ListView LvAliases;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader llavesprivadas;
        private System.Windows.Forms.ColumnHeader llavespublicas;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox TxtLlaveSimetrica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbEnc;
        private System.Windows.Forms.Button BtnActLlaves;
        private System.Windows.Forms.ContextMenuStrip CtxListaLlaves;
        private System.Windows.Forms.ToolStripMenuItem CtxBorrarObjeto;
        private System.Windows.Forms.Label LblEnc;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox TxtTexto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtFirma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CbPrivadas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtRutaCert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox CbPub2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CbPriv2;
        private System.Windows.Forms.TextBox TxtCn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtO2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtO;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtUniqueIdentifier;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtSn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtOU;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnCrearCsr;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox TxtKeyPairAlias;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxtChallenge;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}

