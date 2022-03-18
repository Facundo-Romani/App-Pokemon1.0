namespace AppPokemon
{
    partial class FrmAltaPokemon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtDescipcion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbDebilidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDebilidad = new System.Windows.Forms.Label();
            this.pbxAltaPoke = new System.Windows.Forms.PictureBox();
            this.txtUrlimagen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAltaPoke)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion:";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(142, 43);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(153, 26);
            this.TxtNumero.TabIndex = 0;
            // 
            // TxtDescipcion
            // 
            this.TxtDescipcion.Location = new System.Drawing.Point(142, 135);
            this.TxtDescipcion.Name = "TxtDescipcion";
            this.TxtDescipcion.Size = new System.Drawing.Size(153, 26);
            this.TxtDescipcion.TabIndex = 2;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(142, 90);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(153, 26);
            this.TxtNombre.TabIndex = 1;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(78, 325);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(85, 40);
            this.BtnAceptar.TabIndex = 5;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(210, 325);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(85, 40);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(142, 221);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(153, 28);
            this.cmbTipo.TabIndex = 3;
            // 
            // cmbDebilidad
            // 
            this.cmbDebilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDebilidad.FormattingEnabled = true;
            this.cmbDebilidad.Location = new System.Drawing.Point(142, 267);
            this.cmbDebilidad.Name = "cmbDebilidad";
            this.cmbDebilidad.Size = new System.Drawing.Size(153, 28);
            this.cmbDebilidad.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo:";
            // 
            // lblDebilidad
            // 
            this.lblDebilidad.AutoSize = true;
            this.lblDebilidad.Location = new System.Drawing.Point(28, 267);
            this.lblDebilidad.Name = "lblDebilidad";
            this.lblDebilidad.Size = new System.Drawing.Size(79, 20);
            this.lblDebilidad.TabIndex = 11;
            this.lblDebilidad.Text = "Debilidad:";
            // 
            // pbxAltaPoke
            // 
            this.pbxAltaPoke.Location = new System.Drawing.Point(327, 43);
            this.pbxAltaPoke.Name = "pbxAltaPoke";
            this.pbxAltaPoke.Size = new System.Drawing.Size(279, 322);
            this.pbxAltaPoke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAltaPoke.TabIndex = 12;
            this.pbxAltaPoke.TabStop = false;
            // 
            // txtUrlimagen
            // 
            this.txtUrlimagen.Location = new System.Drawing.Point(142, 179);
            this.txtUrlimagen.Name = "txtUrlimagen";
            this.txtUrlimagen.Size = new System.Drawing.Size(153, 26);
            this.txtUrlimagen.TabIndex = 13;
            this.txtUrlimagen.Leave += new System.EventHandler(this.txtUrlimagen_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Url imagen";
            // 
            // FrmAltaPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(652, 432);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUrlimagen);
            this.Controls.Add(this.pbxAltaPoke);
            this.Controls.Add(this.lblDebilidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDebilidad);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtDescipcion);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAltaPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Pokemon";
            this.Load += new System.EventHandler(this.FrmAltaPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAltaPoke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.TextBox TxtDescipcion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbDebilidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDebilidad;
        private System.Windows.Forms.PictureBox pbxAltaPoke;
        private System.Windows.Forms.TextBox txtUrlimagen;
        private System.Windows.Forms.Label label5;
    }
}