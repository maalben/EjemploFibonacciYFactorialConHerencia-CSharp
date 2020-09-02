namespace EjemploFibonacciConHerencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnverserie = new System.Windows.Forms.Button();
            this.ltb1 = new System.Windows.Forms.ListBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblfactorial = new System.Windows.Forms.Label();
            this.btncalcularfactorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serie Fibonacci";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa un número";
            // 
            // txtnumero
            // 
            this.txtnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.txtnumero.Location = new System.Drawing.Point(320, 126);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(160, 68);
            this.txtnumero.TabIndex = 2;
            // 
            // btnverserie
            // 
            this.btnverserie.Location = new System.Drawing.Point(410, 200);
            this.btnverserie.Name = "btnverserie";
            this.btnverserie.Size = new System.Drawing.Size(160, 47);
            this.btnverserie.TabIndex = 3;
            this.btnverserie.Text = "Ver Serie";
            this.btnverserie.UseVisualStyleBackColor = true;
            this.btnverserie.Click += new System.EventHandler(this.btnverserie_Click);
            // 
            // ltb1
            // 
            this.ltb1.FormattingEnabled = true;
            this.ltb1.Location = new System.Drawing.Point(601, 38);
            this.ltb1.Name = "ltb1";
            this.ltb1.Size = new System.Drawing.Size(154, 381);
            this.ltb1.TabIndex = 4;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(435, 40);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(160, 47);
            this.btnlimpiar.TabIndex = 5;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Serie Fibonacci:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label4.Location = new System.Drawing.Point(45, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resultado factorial:";
            // 
            // lblfactorial
            // 
            this.lblfactorial.AutoSize = true;
            this.lblfactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblfactorial.Location = new System.Drawing.Point(45, 334);
            this.lblfactorial.Name = "lblfactorial";
            this.lblfactorial.Size = new System.Drawing.Size(136, 39);
            this.lblfactorial.TabIndex = 8;
            this.lblfactorial.Text = "factorial";
            this.lblfactorial.Visible = false;
            // 
            // btncalcularfactorial
            // 
            this.btncalcularfactorial.Location = new System.Drawing.Point(228, 200);
            this.btncalcularfactorial.Name = "btncalcularfactorial";
            this.btncalcularfactorial.Size = new System.Drawing.Size(160, 47);
            this.btncalcularfactorial.TabIndex = 9;
            this.btncalcularfactorial.Text = "Calcular Factorial";
            this.btncalcularfactorial.UseVisualStyleBackColor = true;
            this.btncalcularfactorial.Click += new System.EventHandler(this.btncalcularfactorial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 432);
            this.Controls.Add(this.btncalcularfactorial);
            this.Controls.Add(this.lblfactorial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.ltb1);
            this.Controls.Add(this.btnverserie);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnverserie;
        private System.Windows.Forms.ListBox ltb1;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblfactorial;
        private System.Windows.Forms.Button btncalcularfactorial;
    }
}

