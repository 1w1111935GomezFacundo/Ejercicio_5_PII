using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_5_PII
{
  public partial class Form1 : Form
  {
    private const int cantArray = 10;
    private string[] aNombres = new string[cantArray];
    private double[] aPrecios = new double[cantArray];
    private int[] aCantidades = new int[cantArray];
    private double[] aGastosTotales = new double[10];
    private double totalGeneral;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      aNombres[0] = "Bananas";
      aNombres[1] = "Manzanas";
      aNombres[2] = "Peras";
      aNombres[3] = "Naranjas";
      aNombres[4] = "Ananas";
      aNombres[5] = "Duraznos";
      aNombres[6] = "Frutillas";
      aNombres[7] = "Mandarinas";
      aNombres[8] = "Uvas";
      aNombres[9] = "Ciruelas";

      aPrecios[0] = 35.65;
      aPrecios[1] = 43.87;
      aPrecios[2] = 35.45;
      aPrecios[3] = 64.23;
      aPrecios[4] = 27.94;
      aPrecios[5] = 64.87;
      aPrecios[6] = 34.98;
      aPrecios[7] = 23.76;
      aPrecios[8] = 34.98;
      aPrecios[9] = 23.54;

      aCantidades[0] = 5;
      aCantidades[1] = 7;
      aCantidades[2] = 5;
      aCantidades[3] = 3;
      aCantidades[4] = 4;
      aCantidades[5] = 7;
      aCantidades[6] = 8;
      aCantidades[7] = 6;
      aCantidades[8] = 8;
      aCantidades[9] = 4;

      for (int i = 0; i < cantArray; i++)
      {
        lstNombres.Items.Add(aNombres[i]);
        lstPrecios.Items.Add($"$ {aPrecios[i]}");
        lstCantidades.Items.Add(aCantidades[i]);
      }
    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {
      lstGastosTotales.Items.Clear();
      totalGeneral = 0;
      for (int i = 0; i < cantArray; i++)
      {
        aGastosTotales[i] = aPrecios[i] * aCantidades[i];
        lstGastosTotales.Items.Add($"$ {Math.Round(aGastosTotales[i], 2)}"
          );
        totalGeneral += aGastosTotales[i];
        lblTotalGeneral.Text = $"$ {Math.Round(totalGeneral, 2).ToString()}";
      }
    }
  }
}