namespace Ejercicio_5_PII
{
  partial class Form1
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
      this.lstNombres = new System.Windows.Forms.ListBox();
      this.lstPrecios = new System.Windows.Forms.ListBox();
      this.lstCantidades = new System.Windows.Forms.ListBox();
      this.lstGastosTotales = new System.Windows.Forms.ListBox();
      this.btnCalcular = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.lblTotalGeneral = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lstNombres
      // 
      this.lstNombres.FormattingEnabled = true;
      this.lstNombres.ItemHeight = 25;
      this.lstNombres.Location = new System.Drawing.Point(65, 128);
      this.lstNombres.Name = "lstNombres";
      this.lstNombres.Size = new System.Drawing.Size(311, 379);
      this.lstNombres.TabIndex = 0;
      // 
      // lstPrecios
      // 
      this.lstPrecios.FormattingEnabled = true;
      this.lstPrecios.ItemHeight = 25;
      this.lstPrecios.Location = new System.Drawing.Point(425, 128);
      this.lstPrecios.Name = "lstPrecios";
      this.lstPrecios.Size = new System.Drawing.Size(311, 379);
      this.lstPrecios.TabIndex = 0;
      // 
      // lstCantidades
      // 
      this.lstCantidades.FormattingEnabled = true;
      this.lstCantidades.ItemHeight = 25;
      this.lstCantidades.Location = new System.Drawing.Point(792, 128);
      this.lstCantidades.Name = "lstCantidades";
      this.lstCantidades.Size = new System.Drawing.Size(311, 379);
      this.lstCantidades.TabIndex = 0;
      // 
      // lstGastosTotales
      // 
      this.lstGastosTotales.FormattingEnabled = true;
      this.lstGastosTotales.ItemHeight = 25;
      this.lstGastosTotales.Location = new System.Drawing.Point(1176, 128);
      this.lstGastosTotales.Name = "lstGastosTotales";
      this.lstGastosTotales.Size = new System.Drawing.Size(311, 379);
      this.lstGastosTotales.TabIndex = 0;
      // 
      // btnCalcular
      // 
      this.btnCalcular.Location = new System.Drawing.Point(792, 558);
      this.btnCalcular.Name = "btnCalcular";
      this.btnCalcular.Size = new System.Drawing.Size(236, 77);
      this.btnCalcular.TabIndex = 3;
      this.btnCalcular.Text = "Calcular Gastos";
      this.btnCalcular.UseVisualStyleBackColor = true;
      this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(1171, 584);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(142, 25);
      this.label1.TabIndex = 4;
      this.label1.Text = "Total General";
      // 
      // lblTotalGeneral
      // 
      this.lblTotalGeneral.AutoSize = true;
      this.lblTotalGeneral.Location = new System.Drawing.Point(1343, 584);
      this.lblTotalGeneral.Name = "lblTotalGeneral";
      this.lblTotalGeneral.Size = new System.Drawing.Size(19, 25);
      this.lblTotalGeneral.TabIndex = 4;
      this.lblTotalGeneral.Text = "-";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(65, 87);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(98, 25);
      this.label3.TabIndex = 4;
      this.label3.Text = "Nombres";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(425, 87);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(84, 25);
      this.label4.TabIndex = 4;
      this.label4.Text = "Precios";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(792, 87);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(121, 25);
      this.label5.TabIndex = 4;
      this.label5.Text = "Cantidades";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(1190, 87);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(157, 25);
      this.label6.TabIndex = 4;
      this.label6.Text = "Gastos Totales";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1552, 699);
      this.Controls.Add(this.lblTotalGeneral);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCalcular);
      this.Controls.Add(this.lstGastosTotales);
      this.Controls.Add(this.lstCantidades);
      this.Controls.Add(this.lstPrecios);
      this.Controls.Add(this.lstNombres);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lstNombres;
    private System.Windows.Forms.ListBox lstPrecios;
    private System.Windows.Forms.ListBox lstCantidades;
    private System.Windows.Forms.ListBox lstGastosTotales;
    private System.Windows.Forms.Button btnCalcular;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblTotalGeneral;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
  }
}

