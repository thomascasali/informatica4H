﻿namespace CartaIdentitaWF
{
    partial class Main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbComuneID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtCarta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txNumeroID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNascita = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbComuneNascita = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txCognome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCarteId = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txComune = new System.Windows.Forms.TextBox();
            this.lbxComuni = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txCap = new System.Windows.Forms.TextBox();
            this.lbxCarte = new System.Windows.Forms.ListBox();
            this.btnAddPersona = new System.Windows.Forms.Button();
            this.grdPersoneCI = new System.Windows.Forms.DataGridView();
            this.Cognome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comune = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartaIdentita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddCarta = new System.Windows.Forms.Button();
            this.btnAddComune = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPersoneCI)).BeginInit();
            this.SuspendLayout();
            // 
            // cbComuneID
            // 
            this.cbComuneID.FormattingEnabled = true;
            this.cbComuneID.Location = new System.Drawing.Point(475, 82);
            this.cbComuneID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbComuneID.Name = "cbComuneID";
            this.cbComuneID.Size = new System.Drawing.Size(178, 24);
            this.cbComuneID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Comune:";
            // 
            // dtCarta
            // 
            this.dtCarta.Location = new System.Drawing.Point(475, 50);
            this.dtCarta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtCarta.Name = "dtCarta";
            this.dtCarta.Size = new System.Drawing.Size(178, 22);
            this.dtCarta.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data:";
            // 
            // txNumeroID
            // 
            this.txNumeroID.Location = new System.Drawing.Point(475, 118);
            this.txNumeroID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txNumeroID.Name = "txNumeroID";
            this.txNumeroID.Size = new System.Drawing.Size(178, 22);
            this.txNumeroID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nato il:";
            // 
            // dtNascita
            // 
            this.dtNascita.Location = new System.Drawing.Point(141, 118);
            this.dtNascita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNascita.Name = "dtNascita";
            this.dtNascita.Size = new System.Drawing.Size(178, 22);
            this.dtNascita.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Luogo N:";
            // 
            // cbComuneNascita
            // 
            this.cbComuneNascita.FormattingEnabled = true;
            this.cbComuneNascita.Location = new System.Drawing.Point(141, 151);
            this.cbComuneNascita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbComuneNascita.Name = "cbComuneNascita";
            this.cbComuneNascita.Size = new System.Drawing.Size(178, 24);
            this.cbComuneNascita.TabIndex = 7;
            this.cbComuneNascita.SelectedIndexChanged += new System.EventHandler(this.cbComuneNascita_SelectedIndexChanged);
            this.cbComuneNascita.TextUpdate += new System.EventHandler(this.cbComuneNascita_TextUpdate);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cognome:";
            // 
            // txCognome
            // 
            this.txCognome.Location = new System.Drawing.Point(141, 50);
            this.txCognome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txCognome.Name = "txCognome";
            this.txCognome.Size = new System.Drawing.Size(178, 22);
            this.txCognome.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nome:";
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(141, 84);
            this.txNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(178, 22);
            this.txNome.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Carta ID:";
            // 
            // cbCarteId
            // 
            this.cbCarteId.FormattingEnabled = true;
            this.cbCarteId.Location = new System.Drawing.Point(141, 187);
            this.cbCarteId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCarteId.Name = "cbCarteId";
            this.cbCarteId.Size = new System.Drawing.Size(178, 24);
            this.cbCarteId.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Persone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(389, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Carte identità";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(734, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Comuni";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(735, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Nome:";
            // 
            // txComune
            // 
            this.txComune.Location = new System.Drawing.Point(820, 50);
            this.txComune.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txComune.Name = "txComune";
            this.txComune.Size = new System.Drawing.Size(178, 22);
            this.txComune.TabIndex = 1;
            // 
            // lbxComuni
            // 
            this.lbxComuni.FormattingEnabled = true;
            this.lbxComuni.ItemHeight = 16;
            this.lbxComuni.Location = new System.Drawing.Point(820, 186);
            this.lbxComuni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxComuni.Name = "lbxComuni";
            this.lbxComuni.Size = new System.Drawing.Size(178, 84);
            this.lbxComuni.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(736, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 16);
            this.label13.TabIndex = 31;
            this.label13.Text = "CAP:";
            // 
            // txCap
            // 
            this.txCap.Location = new System.Drawing.Point(820, 84);
            this.txCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txCap.Name = "txCap";
            this.txCap.Size = new System.Drawing.Size(178, 22);
            this.txCap.TabIndex = 2;
            // 
            // lbxCarte
            // 
            this.lbxCarte.FormattingEnabled = true;
            this.lbxCarte.ItemHeight = 16;
            this.lbxCarte.Location = new System.Drawing.Point(475, 186);
            this.lbxCarte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxCarte.Name = "lbxCarte";
            this.lbxCarte.Size = new System.Drawing.Size(178, 84);
            this.lbxCarte.TabIndex = 32;
            // 
            // btnAddPersona
            // 
            this.btnAddPersona.Location = new System.Drawing.Point(193, 222);
            this.btnAddPersona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPersona.Name = "btnAddPersona";
            this.btnAddPersona.Size = new System.Drawing.Size(126, 26);
            this.btnAddPersona.TabIndex = 33;
            this.btnAddPersona.Text = "Crea persona";
            this.btnAddPersona.UseVisualStyleBackColor = true;
            this.btnAddPersona.Click += new System.EventHandler(this.btnAddPersona_Click);
            // 
            // grdPersoneCI
            // 
            this.grdPersoneCI.AllowUserToAddRows = false;
            this.grdPersoneCI.AllowUserToOrderColumns = true;
            this.grdPersoneCI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPersoneCI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cognome,
            this.Nome,
            this.DataN,
            this.Comune,
            this.CartaIdentita});
            this.grdPersoneCI.Location = new System.Drawing.Point(60, 286);
            this.grdPersoneCI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdPersoneCI.Name = "grdPersoneCI";
            this.grdPersoneCI.ReadOnly = true;
            this.grdPersoneCI.RowHeadersWidth = 51;
            this.grdPersoneCI.RowTemplate.Height = 28;
            this.grdPersoneCI.Size = new System.Drawing.Size(938, 206);
            this.grdPersoneCI.TabIndex = 34;
            // 
            // Cognome
            // 
            this.Cognome.HeaderText = "Cognome";
            this.Cognome.MinimumWidth = 6;
            this.Cognome.Name = "Cognome";
            this.Cognome.ReadOnly = true;
            this.Cognome.Width = 200;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // DataN
            // 
            this.DataN.HeaderText = "Nato il";
            this.DataN.MinimumWidth = 6;
            this.DataN.Name = "DataN";
            this.DataN.ReadOnly = true;
            this.DataN.Width = 150;
            // 
            // Comune
            // 
            this.Comune.HeaderText = "Luogo Nascita";
            this.Comune.MinimumWidth = 6;
            this.Comune.Name = "Comune";
            this.Comune.ReadOnly = true;
            this.Comune.Width = 200;
            // 
            // CartaIdentita
            // 
            this.CartaIdentita.HeaderText = "Carta ID numero";
            this.CartaIdentita.MinimumWidth = 6;
            this.CartaIdentita.Name = "CartaIdentita";
            this.CartaIdentita.ReadOnly = true;
            this.CartaIdentita.Width = 200;
            // 
            // btnAddCarta
            // 
            this.btnAddCarta.Location = new System.Drawing.Point(526, 151);
            this.btnAddCarta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCarta.Name = "btnAddCarta";
            this.btnAddCarta.Size = new System.Drawing.Size(126, 26);
            this.btnAddCarta.TabIndex = 35;
            this.btnAddCarta.Text = "Crea carta";
            this.btnAddCarta.UseVisualStyleBackColor = true;
            this.btnAddCarta.Click += new System.EventHandler(this.btnAddCarta_Click);
            // 
            // btnAddComune
            // 
            this.btnAddComune.Location = new System.Drawing.Point(871, 120);
            this.btnAddComune.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddComune.Name = "btnAddComune";
            this.btnAddComune.Size = new System.Drawing.Size(126, 26);
            this.btnAddComune.TabIndex = 3;
            this.btnAddComune.Text = "Crea comune";
            this.btnAddComune.UseVisualStyleBackColor = true;
            this.btnAddComune.Click += new System.EventHandler(this.btnAddComune_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 514);
            this.Controls.Add(this.btnAddComune);
            this.Controls.Add(this.btnAddCarta);
            this.Controls.Add(this.grdPersoneCI);
            this.Controls.Add(this.btnAddPersona);
            this.Controls.Add(this.lbxCarte);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txCap);
            this.Controls.Add(this.lbxComuni);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txComune);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCarteId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txCognome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtNascita);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbComuneNascita);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txNumeroID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtCarta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbComuneID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.grdPersoneCI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbComuneID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtCarta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txNumeroID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNascita;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbComuneNascita;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txCognome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCarteId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txComune;
        private System.Windows.Forms.ListBox lbxComuni;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txCap;
        private System.Windows.Forms.ListBox lbxCarte;
        private System.Windows.Forms.Button btnAddPersona;
        private System.Windows.Forms.DataGridView grdPersoneCI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cognome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comune;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartaIdentita;
        private System.Windows.Forms.Button btnAddCarta;
        private System.Windows.Forms.Button btnAddComune;
    }
}

