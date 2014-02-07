using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGF_3
{
public partial class Form1 : Form
{
        
    // Structs + Class Globales
    int idSel;
    int posSel;
    TableLayoutPanel[] indObj = new TableLayoutPanel[3];


    public Form1()
    {
           
        InitializeComponent();

        // VINCULO CHAPAS AL VECTOR DE ASIGNACION
        indObj[0] = new TableLayoutPanel(); // No Existe
        indObj[1] = chapa1;
        indObj[2] = chapa2;

        // CONFIGURO NOMBRE CHAPAS
        nombre1.Text = "ALSTOM A";


        // CONFIGURO COMPOSICIONES
        comp1.Text = "RCA116-RA116-MA116-MB116-RB116-RCB116";
            
            
           
    }


    // 

    private void Chapa1_Click(object sender, EventArgs e)
    {
        idSel = 1;
            
    }

    private void Chapa2_Click(object sender, EventArgs e)
    {
        idSel = 2;
    }

    private void Form1_SizeChanged(object sender, EventArgs e)
    {
           
        for (int i = 1; i <= indObj.Length ; i++)
        {
            indObj[i-1].Width = (Width * 13) / 100;    
        }


    }



    private void pos1_Click(object sender, EventArgs e)
    {

        indObj[idSel].Top = pos1.Top;
        indObj[idSel].Left = pos1.Left;
        idSel = 0;


    }

    private void pos2_Click(object sender, EventArgs e)
    {
        indObj[idSel].Top = pos2.Top;
        indObj[idSel].Left = pos2.Left;
        idSel = 0;

    }

    private void pos3_Click(object sender, EventArgs e)
    {

        indObj[idSel].Top = pos3.Top;
        indObj[idSel].Left = pos3.Left;
        idSel = 0;

    }

     
 

     
}
}
