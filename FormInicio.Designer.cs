
namespace Proyecto_Plusmar
{
    partial class FormInicio
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
            this.txtNombreInicio = new System.Windows.Forms.TextBox();
            this.txtCantInicio = new System.Windows.Forms.TextBox();
            this.btnContinuarInicio = new System.Windows.Forms.Button();
            this.btnVerRsv = new System.Windows.Forms.Button();
            this.btnVerMicros = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INDIQUE DESTINO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CANT. PASAJEROS";
            // 
            // txtNombreInicio
            // 
            this.txtNombreInicio.Location = new System.Drawing.Point(157, 14);
            this.txtNombreInicio.Name = "txtNombreInicio";
            this.txtNombreInicio.Size = new System.Drawing.Size(173, 20);
            this.txtNombreInicio.TabIndex = 2;
            // 
            // txtCantInicio
            // 
            this.txtCantInicio.Location = new System.Drawing.Point(157, 80);
            this.txtCantInicio.Name = "txtCantInicio";
            this.txtCantInicio.Size = new System.Drawing.Size(51, 20);
            this.txtCantInicio.TabIndex = 3;
            // 
            // btnContinuarInicio
            // 
            this.btnContinuarInicio.Location = new System.Drawing.Point(32, 136);
            this.btnContinuarInicio.Name = "btnContinuarInicio";
            this.btnContinuarInicio.Size = new System.Drawing.Size(114, 38);
            this.btnContinuarInicio.TabIndex = 4;
            this.btnContinuarInicio.Text = "CONTINUAR";
            this.btnContinuarInicio.UseVisualStyleBackColor = true;
            this.btnContinuarInicio.Click += new System.EventHandler(this.btnContinuarInicio_Click);
            // 
            // btnVerRsv
            // 
            this.btnVerRsv.Location = new System.Drawing.Point(343, 146);
            this.btnVerRsv.Name = "btnVerRsv";
            this.btnVerRsv.Size = new System.Drawing.Size(114, 38);
            this.btnVerRsv.TabIndex = 5;
            this.btnVerRsv.Text = "VER RESERVAS";
            this.btnVerRsv.UseVisualStyleBackColor = true;
            this.btnVerRsv.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVerMicros
            // 
            this.btnVerMicros.Location = new System.Drawing.Point(343, 70);
            this.btnVerMicros.Name = "btnVerMicros";
            this.btnVerMicros.Size = new System.Drawing.Size(114, 38);
            this.btnVerMicros.TabIndex = 6;
            this.btnVerMicros.Text = "VER MICROS";
            this.btnVerMicros.UseVisualStyleBackColor = true;
            this.btnVerMicros.Click += new System.EventHandler(this.button3_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(503, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 223);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnVerMicros);
            this.Controls.Add(this.btnVerRsv);
            this.Controls.Add(this.btnContinuarInicio);
            this.Controls.Add(this.txtCantInicio);
            this.Controls.Add(this.txtNombreInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInicio";
            this.Text = "INICIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreInicio;
        private System.Windows.Forms.TextBox txtCantInicio;
        private System.Windows.Forms.Button btnContinuarInicio;
        private System.Windows.Forms.Button btnVerRsv;
        private System.Windows.Forms.Button btnVerMicros;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}