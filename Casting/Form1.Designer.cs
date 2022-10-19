namespace Casting
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblImplicita = new System.Windows.Forms.Label();
            this.lblNumberImplicita = new System.Windows.Forms.Label();
            this.txtExplicita = new System.Windows.Forms.TextBox();
            this.btnExplicita = new System.Windows.Forms.Button();
            this.lblNumberExplicita = new System.Windows.Forms.Label();
            this.lblExplicita = new System.Windows.Forms.Label();
            this.btnImplicita = new System.Windows.Forms.Button();
            this.txtImplicita = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(263, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Casting en C#";
            // 
            // lblImplicita
            // 
            this.lblImplicita.AutoSize = true;
            this.lblImplicita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImplicita.Location = new System.Drawing.Point(53, 87);
            this.lblImplicita.Name = "lblImplicita";
            this.lblImplicita.Size = new System.Drawing.Size(250, 29);
            this.lblImplicita.TabIndex = 1;
            this.lblImplicita.Text = "Conversión implícita";
            // 
            // lblNumberImplicita
            // 
            this.lblNumberImplicita.AutoSize = true;
            this.lblNumberImplicita.Location = new System.Drawing.Point(29, 132);
            this.lblNumberImplicita.Name = "lblNumberImplicita";
            this.lblNumberImplicita.Size = new System.Drawing.Size(304, 25);
            this.lblNumberImplicita.TabIndex = 2;
            this.lblNumberImplicita.Text = "Ingrese un número sin decimales:";
            // 
            // txtExplicita
            // 
            this.txtExplicita.Location = new System.Drawing.Point(441, 174);
            this.txtExplicita.Name = "txtExplicita";
            this.txtExplicita.Size = new System.Drawing.Size(306, 29);
            this.txtExplicita.TabIndex = 3;
            // 
            // btnExplicita
            // 
            this.btnExplicita.Location = new System.Drawing.Point(482, 218);
            this.btnExplicita.Name = "btnExplicita";
            this.btnExplicita.Size = new System.Drawing.Size(224, 62);
            this.btnExplicita.TabIndex = 4;
            this.btnExplicita.Text = "Conversión explícita";
            this.btnExplicita.UseVisualStyleBackColor = true;
            this.btnExplicita.Click += new System.EventHandler(this.btnExplicita_Click);
            // 
            // lblNumberExplicita
            // 
            this.lblNumberExplicita.AutoSize = true;
            this.lblNumberExplicita.Location = new System.Drawing.Point(436, 132);
            this.lblNumberExplicita.Name = "lblNumberExplicita";
            this.lblNumberExplicita.Size = new System.Drawing.Size(311, 25);
            this.lblNumberExplicita.TabIndex = 6;
            this.lblNumberExplicita.Text = "Ingrese un número con decimales:";
            // 
            // lblExplicita
            // 
            this.lblExplicita.AutoSize = true;
            this.lblExplicita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicita.Location = new System.Drawing.Point(467, 87);
            this.lblExplicita.Name = "lblExplicita";
            this.lblExplicita.Size = new System.Drawing.Size(249, 29);
            this.lblExplicita.TabIndex = 5;
            this.lblExplicita.Text = "Conversión explícita";
            // 
            // btnImplicita
            // 
            this.btnImplicita.Location = new System.Drawing.Point(67, 218);
            this.btnImplicita.Name = "btnImplicita";
            this.btnImplicita.Size = new System.Drawing.Size(224, 62);
            this.btnImplicita.TabIndex = 8;
            this.btnImplicita.Text = "Conversión implícita";
            this.btnImplicita.UseVisualStyleBackColor = true;
            this.btnImplicita.Click += new System.EventHandler(this.btnImplicita_Click);
            // 
            // txtImplicita
            // 
            this.txtImplicita.Location = new System.Drawing.Point(30, 174);
            this.txtImplicita.Name = "txtImplicita";
            this.txtImplicita.Size = new System.Drawing.Size(299, 29);
            this.txtImplicita.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 323);
            this.Controls.Add(this.btnImplicita);
            this.Controls.Add(this.txtImplicita);
            this.Controls.Add(this.lblNumberExplicita);
            this.Controls.Add(this.lblExplicita);
            this.Controls.Add(this.btnExplicita);
            this.Controls.Add(this.txtExplicita);
            this.Controls.Add(this.lblNumberImplicita);
            this.Controls.Add(this.lblImplicita);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Casting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblImplicita;
        private System.Windows.Forms.Label lblNumberImplicita;
        private System.Windows.Forms.TextBox txtExplicita;
        private System.Windows.Forms.Button btnExplicita;
        private System.Windows.Forms.Label lblNumberExplicita;
        private System.Windows.Forms.Label lblExplicita;
        private System.Windows.Forms.Button btnImplicita;
        private System.Windows.Forms.TextBox txtImplicita;
    }
}

