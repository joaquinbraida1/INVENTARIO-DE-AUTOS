
namespace Parcial2DB
{
    partial class frmEstadistica
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
            this.lblOtros = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCantFiatAct = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCantFordAct = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalAutomotor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOtros
            // 
            this.lblOtros.AutoSize = true;
            this.lblOtros.Location = new System.Drawing.Point(329, 193);
            this.lblOtros.Name = "lblOtros";
            this.lblOtros.Size = new System.Drawing.Size(35, 13);
            this.lblOtros.TabIndex = 15;
            this.lblOtros.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Otros (Activos e Inactivos)";
            // 
            // lblCantFiatAct
            // 
            this.lblCantFiatAct.AutoSize = true;
            this.lblCantFiatAct.Location = new System.Drawing.Point(329, 150);
            this.lblCantFiatAct.Name = "lblCantFiatAct";
            this.lblCantFiatAct.Size = new System.Drawing.Size(35, 13);
            this.lblCantFiatAct.TabIndex = 13;
            this.lblCantFiatAct.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cantidad de Fiat Activos";
            // 
            // lblCantFordAct
            // 
            this.lblCantFordAct.AutoSize = true;
            this.lblCantFordAct.Location = new System.Drawing.Point(329, 106);
            this.lblCantFordAct.Name = "lblCantFordAct";
            this.lblCantFordAct.Size = new System.Drawing.Size(35, 13);
            this.lblCantFordAct.TabIndex = 11;
            this.lblCantFordAct.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cantidad de Ford Activos";
            // 
            // lblTotalAutomotor
            // 
            this.lblTotalAutomotor.AutoSize = true;
            this.lblTotalAutomotor.Location = new System.Drawing.Point(329, 52);
            this.lblTotalAutomotor.Name = "lblTotalAutomotor";
            this.lblTotalAutomotor.Size = new System.Drawing.Size(35, 13);
            this.lblTotalAutomotor.TabIndex = 9;
            this.lblTotalAutomotor.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total de Automotores";
            // 
            // frmEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 258);
            this.Controls.Add(this.lblOtros);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCantFiatAct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCantFordAct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalAutomotor);
            this.Controls.Add(this.label1);
            this.Name = "frmEstadistica";
            this.Text = "frmEstadistica";
            this.Load += new System.EventHandler(this.frmEstadistica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOtros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCantFiatAct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCantFordAct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalAutomotor;
        private System.Windows.Forms.Label label1;
    }
}