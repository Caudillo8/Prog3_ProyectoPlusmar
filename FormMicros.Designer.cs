
using System;

namespace Proyecto_Plusmar
{
    partial class FormMicros
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnInicioMicro = new System.Windows.Forms.Button();
            this.btnSalirMicro = new System.Windows.Forms.Button();
            this.dataGridMicros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMicros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ASIENTOS LIBRES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ASIENTOS OCUPADOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DESTINO";
            // 
            // btnInicioMicro
            // 
            this.btnInicioMicro.Location = new System.Drawing.Point(36, 226);
            this.btnInicioMicro.Name = "btnInicioMicro";
            this.btnInicioMicro.Size = new System.Drawing.Size(132, 52);
            this.btnInicioMicro.TabIndex = 5;
            this.btnInicioMicro.Text = "INICIO";
            this.btnInicioMicro.UseVisualStyleBackColor = true;
            // 
            // btnSalirMicro
            // 
            this.btnSalirMicro.Location = new System.Drawing.Point(431, 226);
            this.btnSalirMicro.Name = "btnSalirMicro";
            this.btnSalirMicro.Size = new System.Drawing.Size(132, 52);
            this.btnSalirMicro.TabIndex = 6;
            this.btnSalirMicro.Text = "SALIR";
            this.btnSalirMicro.UseVisualStyleBackColor = true;
            this.btnSalirMicro.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridMicros
            // 
            this.dataGridMicros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMicros.Location = new System.Drawing.Point(25, 47);
            this.dataGridMicros.Name = "dataGridMicros";
            this.dataGridMicros.Size = new System.Drawing.Size(538, 162);
            this.dataGridMicros.TabIndex = 17;
            this.dataGridMicros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormMicros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 309);
            this.Controls.Add(this.dataGridMicros);
            this.Controls.Add(this.btnSalirMicro);
            this.Controls.Add(this.btnInicioMicro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMicros";
            this.Text = "MICROS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMicros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInicioMicro;
        private System.Windows.Forms.Button btnSalirMicro;
        private System.Windows.Forms.DataGridView dataGridMicros;
    }
}