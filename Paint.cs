using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio11
{
    public partial class Paint : Form
    {
        public Paint(){
            InitializeComponent();
            Lienzo = pnl_Lienzo.CreateGraphics();
        }
        bool SePuedePintar = false;
        Graphics Lienzo;
        //hay que poner interrogante para decir que son nulos
        int? initX = null;
        int? initY = null;

        bool DibujarCuadrado = false;
        bool DibujarRectangulo = false;
        bool DibujarCirculo = false;
        //Evento activado cuando el puntero se mueve por el picture box(pnl_Draw)
        private void pnl_Draw_MouseMove(object sender, MouseEventArgs e){
            if (SePuedePintar){
                //ajustar el ancho y alto del pincel
                Pen p = new Pen(Button_ElegirColor.BackColor, float.Parse(TextBox_TamañoPincel.Text));
                //dibujar la linea
                Lienzo.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                initX = e.X;
                initY = e.Y;
            }
        }
        //Evento activado cuando el puntero está sobre el picture box y se presione encima
        private void pnl_Draw_MouseDown(object sender, MouseEventArgs e){
            SePuedePintar = true;
            if (DibujarCuadrado){
                //sirve para inicializar el pincel con el color elegido
                SolidBrush sb = new SolidBrush(Button_ElegirColor.BackColor);
                //ajustar el ancho y alto iguales para pintar cuadrados
                //obtenemos las medidas introducidas por el usuario
                Lienzo.FillRectangle(sb, e.X, e.Y, int.Parse(TextBox_TamañoForma.Text), int.Parse(TextBox_TamañoForma.Text));
                //establecer el valor startPaint y drawSquare en false para crear un gráfico con un solo clic.
                SePuedePintar = false;
                DibujarCuadrado = false;
            }
            if (DibujarRectangulo){
                SolidBrush sb = new SolidBrush(Button_ElegirColor.BackColor);
                //el ancho será el doble que el alto
                Lienzo.FillRectangle(sb, e.X, e.Y, 2 * int.Parse(TextBox_TamañoForma.Text), int.Parse(TextBox_TamañoForma.Text));
                SePuedePintar = false;
                DibujarRectangulo = false;
            }
            if (DibujarCirculo){
                SolidBrush sb = new SolidBrush(Button_ElegirColor.BackColor);
                Lienzo.FillEllipse(sb, e.X, e.Y, int.Parse(TextBox_TamañoForma.Text), int.Parse(TextBox_TamañoForma.Text));
                SePuedePintar = false;
                DibujarCirculo = false;
            }
        }
        //se activa cuando el puntero está sobre el lienzo y el botón izquierdo no se pulse
        private void pnl_Draw_MouseUp(object sender, MouseEventArgs e){
            SePuedePintar = false;
            initX = null;
            initY = null;
        }
        //Boton para elegir el color con el que pintar
        private void button1_Click(object sender, EventArgs e){
            //si se pulsa el boton OK, se cambia el color del pincel al color elegido
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK){
                Button_ElegirColor.BackColor = c.Color;
            }
        }
        //Nuevo Lienzo
        private void newToolStripMenuItem_Click(object sender, EventArgs e){
            //Limpiar el lienzo
            Lienzo.Clear(pnl_Lienzo.BackColor);
            //ajustar el color de fondo del lienzo y el color del boton al blanco
            pnl_Lienzo.BackColor = Color.White;
            Button_ColorFondo.BackColor = Color.White;
        }
        //ajustar el color de fondo
        private void btn_CanvasColor_Click_1(object sender, EventArgs e){
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK){
                pnl_Lienzo.BackColor = c.Color;
                Button_ColorFondo.BackColor = c.Color;
            }
        }
        private void btn_Square_Click(object sender, EventArgs e){
            DibujarCuadrado = true;
        }
        private void btn_Rectangle_Click(object sender, EventArgs e){
            DibujarRectangulo = true;
        }
        private void btn_Circle_Click(object sender, EventArgs e){
            DibujarCirculo = true;
        }
        //salir
        private void exitToolStripMenuItem_Click(object sender, EventArgs e){
            if (MessageBox.Show("Quieres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes){
                Application.Exit();
            }
        }

    }
}