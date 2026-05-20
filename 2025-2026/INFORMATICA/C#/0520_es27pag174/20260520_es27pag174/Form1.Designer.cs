namespace _20260520_es27pag174
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvElencoProf = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScuola = new System.Windows.Forms.TextBox();
            this.dgvCercaProf = new System.Windows.Forms.DataGridView();
            this.btnCerca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElencoProf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCercaProf)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elenco Docenti";
            // 
            // dgvElencoProf
            // 
            this.dgvElencoProf.AllowUserToAddRows = false;
            this.dgvElencoProf.AllowUserToDeleteRows = false;
            this.dgvElencoProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElencoProf.Location = new System.Drawing.Point(13, 42);
            this.dgvElencoProf.Name = "dgvElencoProf";
            this.dgvElencoProf.ReadOnly = true;
            this.dgvElencoProf.RowHeadersVisible = false;
            this.dgvElencoProf.RowHeadersWidth = 51;
            this.dgvElencoProf.RowTemplate.Height = 24;
            this.dgvElencoProf.Size = new System.Drawing.Size(743, 323);
            this.dgvElencoProf.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome scuola:";
            // 
            // txtScuola
            // 
            this.txtScuola.Location = new System.Drawing.Point(184, 387);
            this.txtScuola.Name = "txtScuola";
            this.txtScuola.Size = new System.Drawing.Size(182, 22);
            this.txtScuola.TabIndex = 3;
            // 
            // dgvCercaProf
            // 
            this.dgvCercaProf.AllowUserToAddRows = false;
            this.dgvCercaProf.AllowUserToDeleteRows = false;
            this.dgvCercaProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCercaProf.Location = new System.Drawing.Point(18, 434);
            this.dgvCercaProf.Name = "dgvCercaProf";
            this.dgvCercaProf.ReadOnly = true;
            this.dgvCercaProf.RowHeadersVisible = false;
            this.dgvCercaProf.RowHeadersWidth = 51;
            this.dgvCercaProf.RowTemplate.Height = 24;
            this.dgvCercaProf.Size = new System.Drawing.Size(738, 160);
            this.dgvCercaProf.TabIndex = 4;
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(400, 387);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(136, 23);
            this.btnCerca.TabIndex = 5;
            this.btnCerca.Text = "Esegui ricerca";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 616);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.dgvCercaProf);
            this.Controls.Add(this.txtScuola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvElencoProf);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvElencoProf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCercaProf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.txtMateria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnContaMateria = new System.Windows.Forms.Button();

            // label3
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 610);
            this.label3.Name = "label3";
            this.label3.Text = "Nome materia:";

            // txtMateria
            this.txtMateria.Location = new System.Drawing.Point(184, 614);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(182, 22);
            this.txtMateria.TabIndex = 6;

            // btnContaMateria
            this.btnContaMateria.Location = new System.Drawing.Point(400, 614);
            this.btnContaMateria.Name = "btnContaMateria";
            this.btnContaMateria.Size = new System.Drawing.Size(136, 23);
            this.btnContaMateria.TabIndex = 7;
            this.btnContaMateria.Text = "Conta per materia";
            this.btnContaMateria.UseVisualStyleBackColor = true;
            this.btnContaMateria.Click += new System.EventHandler(this.btnContaMateria_Click);

            // aggiorna ClientSize per ospitare i nuovi controlli
            this.ClientSize = new System.Drawing.Size(774, 660);

            // aggiungi i controlli al form
            this.Controls.Add(this.btnContaMateria);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.label3);


        }

        #endregion
        // dichiara i campi in fondo al Designer
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Button btnContaMateria;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvElencoProf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScuola;
        private System.Windows.Forms.DataGridView dgvCercaProf;
        private System.Windows.Forms.Button btnCerca;

            
    }
}