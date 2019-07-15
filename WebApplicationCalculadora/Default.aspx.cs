using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationCalculadora
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAbrirParentesis_Click(object sender, EventArgs e)
        {
            TextBoxExpresionAritmetica.Text += ((Button)sender).Text;
        }

        protected void ButtonCerrarParentesis_Click(object sender, EventArgs e)
        {
            TextBoxExpresionAritmetica.Text += ((Button)sender).Text;
        }

        protected void ButtonPorcentaje_Click(object sender, EventArgs e)
        {
            TextBoxExpresionAritmetica.Text += ((Button)sender).Text;
        }

        protected void ButtonBorrar_Click(object sender, EventArgs e)
        {
            TextBoxExpresionAritmetica.Text = "";
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            TextBoxExpresionAritmetica.Text += ((Button)sender).Text;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            TextBoxExpresionAritmetica.Text += ((Button)sender).Text;
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            TextBoxExpresionAritmetica.Text += ((Button)sender).Text;
        }

        protected void ButtonDividir_Click(object sender, EventArgs e)
        {
            TextBoxExpresionAritmetica.Text += ((Button)sender).Text;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBoxExpresionAritmetica.Text += ((Button)sender).Text;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBoxExpresionAritmetica.Text += ((Button)sender).Text;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            TextBoxExpresionAritmetica.Text += ((Button)sender).Text;
        }

        protected void ButtonMultiplicar_Click(object sender, EventArgs e)
        {
            TextBoxExpresionAritmetica.Text += ((Button)sender).Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBoxExpresionAritmetica.Text += ((Button)sender).Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBoxExpresionAritmetica.Text += ((Button)sender).Text;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBoxExpresionAritmetica.Text += ((Button)sender).Text;
        }

        protected void ButtonRestar_Click(object sender, EventArgs e)
        {
            TextBoxExpresionAritmetica.Text += ((Button)sender).Text;
        }

        protected void Button0_Click(object sender, EventArgs e)
        {
            TextBoxExpresionAritmetica.Text += ((Button)sender).Text;
        }

        protected void ButtonPunto_Click(object sender, EventArgs e)
        {
            TextBoxExpresionAritmetica.Text += ((Button)sender).Text;
        }

        protected void ButtonSumar_Click(object sender, EventArgs e)
        {
            TextBoxExpresionAritmetica.Text += ((Button)sender).Text;
        }

        protected void ButtonIgual_Click(object sender, EventArgs e)
        {
            const string ERROR_MSG = "Error";
            try
            {
                string expre = TextBoxExpresionAritmetica.Text;
                //double result = Convert.ToDouble(new DataTable().Compute("(3+3)*2+1", null));
                //El método “Compute” es el responsable de evaluar la expresión aritmética almacenada en un string.
                double result = Convert.ToDouble(new System.Data.DataTable().Compute(expre, null));                
                TextBoxExpresionAritmetica.Text = result.ToString().Replace(",", ".");
            }
            catch 
            {
                TextBoxExpresionAritmetica.Text = ERROR_MSG;
            }               
        }
    }
}