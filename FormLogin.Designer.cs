
namespace Proyecto_Plusmar
{
    partial class FormLogin
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
            this.txtNombreLogin = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnAceptarLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CLAVE";
            // 
            // txtNombreLogin
            // 
            this.txtNombreLogin.Location = new System.Drawing.Point(115, 9);
            this.txtNombreLogin.Name = "txtNombreLogin";
            this.txtNombreLogin.Size = new System.Drawing.Size(118, 20);
            this.txtNombreLogin.TabIndex = 2;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(115, 64);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(112, 20);
            this.txtClave.TabIndex = 3;
            // 
            // btnAceptarLogin
            // 
            this.btnAceptarLogin.Location = new System.Drawing.Point(119, 125);
            this.btnAceptarLogin.Name = "btnAceptarLogin";
            this.btnAceptarLogin.Size = new System.Drawing.Size(107, 40);
            this.btnAceptarLogin.TabIndex = 4;
            this.btnAceptarLogin.Text = "INGRESAR";
            this.btnAceptarLogin.UseVisualStyleBackColor = true;
            this.btnAceptarLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 207);
            this.Controls.Add(this.btnAceptarLogin);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtNombreLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreLogin;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnAceptarLogin;
    }
}

