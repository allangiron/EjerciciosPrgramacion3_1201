
namespace EjerciciosPrgramacion3_1201
{
    partial class FrmArreglos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.CB_agregar = new System.Windows.Forms.ComboBox();
            this.Btn_ordenarAscendente = new System.Windows.Forms.Button();
            this.Cb_ordenarAscendente = new System.Windows.Forms.ComboBox();
            this.Cb_ordenarDescendente = new System.Windows.Forms.ComboBox();
            this.Btn_ordenarDescendente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.Location = new System.Drawing.Point(109, 93);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(84, 23);
            this.Btn_agregar.TabIndex = 0;
            this.Btn_agregar.Text = "Agregar";
            this.Btn_agregar.UseVisualStyleBackColor = true;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // CB_agregar
            // 
            this.CB_agregar.FormattingEnabled = true;
            this.CB_agregar.Location = new System.Drawing.Point(83, 131);
            this.CB_agregar.Name = "CB_agregar";
            this.CB_agregar.Size = new System.Drawing.Size(137, 21);
            this.CB_agregar.TabIndex = 1;
            // 
            // Btn_ordenarAscendente
            // 
            this.Btn_ordenarAscendente.Location = new System.Drawing.Point(109, 194);
            this.Btn_ordenarAscendente.Name = "Btn_ordenarAscendente";
            this.Btn_ordenarAscendente.Size = new System.Drawing.Size(84, 35);
            this.Btn_ordenarAscendente.TabIndex = 2;
            this.Btn_ordenarAscendente.Text = "Ordenar Ascendente";
            this.Btn_ordenarAscendente.UseVisualStyleBackColor = true;
            this.Btn_ordenarAscendente.Click += new System.EventHandler(this.Btn_ordenarAscendente_Click);
            // 
            // Cb_ordenarAscendente
            // 
            this.Cb_ordenarAscendente.FormattingEnabled = true;
            this.Cb_ordenarAscendente.Location = new System.Drawing.Point(83, 249);
            this.Cb_ordenarAscendente.Name = "Cb_ordenarAscendente";
            this.Cb_ordenarAscendente.Size = new System.Drawing.Size(137, 21);
            this.Cb_ordenarAscendente.TabIndex = 1;
            // 
            // Cb_ordenarDescendente
            // 
            this.Cb_ordenarDescendente.FormattingEnabled = true;
            this.Cb_ordenarDescendente.Location = new System.Drawing.Point(83, 358);
            this.Cb_ordenarDescendente.Name = "Cb_ordenarDescendente";
            this.Cb_ordenarDescendente.Size = new System.Drawing.Size(137, 21);
            this.Cb_ordenarDescendente.TabIndex = 1;
            // 
            // Btn_ordenarDescendente
            // 
            this.Btn_ordenarDescendente.Location = new System.Drawing.Point(109, 303);
            this.Btn_ordenarDescendente.Name = "Btn_ordenarDescendente";
            this.Btn_ordenarDescendente.Size = new System.Drawing.Size(84, 35);
            this.Btn_ordenarDescendente.TabIndex = 2;
            this.Btn_ordenarDescendente.Text = "Ordenar Descendente";
            this.Btn_ordenarDescendente.UseVisualStyleBackColor = true;
            this.Btn_ordenarDescendente.Click += new System.EventHandler(this.Btn_ordenarDescendente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ordenar Nombres Alfabeticamente";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(334, 404);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_ordenarDescendente);
            this.Controls.Add(this.Btn_ordenarAscendente);
            this.Controls.Add(this.Cb_ordenarDescendente);
            this.Controls.Add(this.Cb_ordenarAscendente);
            this.Controls.Add(this.CB_agregar);
            this.Controls.Add(this.Btn_agregar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.ComboBox CB_agregar;
        private System.Windows.Forms.Button Btn_ordenarAscendente;
        private System.Windows.Forms.ComboBox Cb_ordenarAscendente;
        private System.Windows.Forms.ComboBox Cb_ordenarDescendente;
        private System.Windows.Forms.Button Btn_ordenarDescendente;
        private System.Windows.Forms.Label label1;
    }
}

