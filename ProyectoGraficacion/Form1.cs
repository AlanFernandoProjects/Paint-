using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoGraficacion
{
    public partial class Form1 : Form
    {
        //Variables
        Bitmap Lienzo; 
        bool BanderaPixel, BanderaRecta, BanderaCirculo, BanderaPoligono, BanderaPRegular, BanderaElipse, BanderaRectangulo, BanderaRelleno, BanderaTraslacion;
        Color MiColor, ColorFondo; //variable para asignar el color a utilizar
        List<Point> Pixeles;
        List<Point> NuevosPixeles;
        int Grosor;
        int Radio, RadioX, RadioY;
        int Ajuste;
        int Lados;
        int id;
        int tx, ty;
        int xc, yc;
        int xce, yce;

        public Form1()
        {
            InitializeComponent();
            Lienzo = new Bitmap(pbAreaDeImagen.Width, pbAreaDeImagen.Height); //El tamaño del lienzo tiene que ser igual al del picture Box
            MiColor = Color.Black;
            ColorFondo.ToArgb();
            Grosor = 1;
            Pixeles = new List<Point>();
            NuevosPixeles = new List<Point>();
            Radio = 100;
            RadioX = 75;
            RadioY = 50;
            EstadoBandera();
            cbGrosor.SelectedIndex = 0;
            s = 0;
        }
        
        private void MouseDibujarPixel(object sender, MouseEventArgs e)
        {
            if (BanderaPixel == true)
            {
                GrosorPixel(e.X, e.Y, MiColor, Grosor);
            }
            pbAreaDeImagen.Image = Lienzo;

            if (BanderaCirculo == true)
            {
                Pixeles.Clear();
                id = 3;
                Pixeles.Add(new Point(e.X, e.Y));

                if (txtRadio.Text == string.Empty)
                {
                    MessageBox.Show("¡¡¡TECLEAR EL RADIO DEL CIRCULO!!!");
                }
                if (Convert.ToInt32(txtRadio.Text) <= 0)
                {
                    MessageBox.Show("¡¡¡TECLEAR UNA CANTIDAD DE RADIO MAYOR A 0!!!");
                }
                else
                {
                    Circulo(e.X, e.Y, Convert.ToInt32(txtRadio.Text), MiColor);
                }
            }

            if (BanderaRecta == true)
            {
                if (Pixeles.Count > 2)
                {
                    Pixeles.Clear();
                }
                    id = 1;
                    GrosorPixel(e.X, e.Y, MiColor, Grosor);
                    Pixeles.Add(new Point(e.X, e.Y));

                    if (Pixeles.Count == 2)
                    {
                        Recta(Pixeles, MiColor);
                        xc = (Pixeles[1].X + Pixeles[0].X) / 2;
                        yc = (Pixeles[1].Y + Pixeles[0].Y) / 2;
                        Pixeles.Add(new Point((int)xc, (int)yc));
                    }
            }

            if (BanderaPoligono == true)
            {       
                id = 2;
                if (cbLados.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese el numero de lados de la figura");
                }
                else
                {
                    if (Pixeles.Count > Convert.ToInt32(cbLados.SelectedItem))
                    {
                        Pixeles.Clear();
                    }
                    GrosorPixel(e.X, e.Y, MiColor, Grosor);
                    Pixeles.Add(new Point(e.X, e.Y));
                   
                    
                    if (Pixeles.Count == Convert.ToInt32(cbLados.SelectedItem))
                    {
                        Irregular(Pixeles, Convert.ToInt32(cbLados.SelectedItem), MiColor);
                        MetodoOrdenamiento();
                        Pixeles.Add(new Point((int)xce, (int)yce));
                    }
                }
            }
		
	        if(BanderaPRegular==true)
            {
                Pixeles.Clear();
                id = 5;
                PoligonoRegular(e.X,e.Y,Lados,Ajuste, MiColor);
                MetodoOrdenamiento();
                Pixeles.Add(new Point((int)xce, (int)yce));
            }

            if (BanderaElipse == true)
            {
                Pixeles.Clear();
                id = 4;
                Pixeles.Add(new Point(e.X, e.Y));

                if (txtRadioX.Text == string.Empty || txtRadioY.Text == string.Empty)
                {
                    txtRadioX.Text = "75";
                    txtRadioY.Text = "50";
                    Elipse(e.X, e.Y, RadioX, RadioY, MiColor);
                }

                else if (Convert.ToInt32(txtRadioX.Text) <= 0 || Convert.ToInt32(txtRadioY.Text) <= 0)
                {
                    MessageBox.Show("¡¡¡TECLEE UN RADIO MAYOR A 0!!!");
                }

                else
                {
                    Elipse(e.X, e.Y, Convert.ToInt32(txtRadioX.Text), Convert.ToInt32(txtRadioY.Text), MiColor);
                }
            }

            if (BanderaRectangulo == true)
            {
                Pixeles.Clear();
                id = 6;
                Rectangulo(e.X, e.Y, Lados, Ajuste, MiColor);
                MetodoOrdenamiento();
                Pixeles.Add(new Point((int)xce, (int)yce));
            }

            if (BanderaRelleno == true)
            {
                MetodoRelleno(e.X, e.Y);
            }

            if (BanderaTraslacion == true)
            {
                tx = e.X - Pixeles[Pixeles.Count - 1].X;
                ty = e.Y - Pixeles[Pixeles.Count - 1].Y;

                Traslacion(Pixeles,tx,ty,id, MiColor);
            }
        }

        public void Traslacion(List<Point> Pixeles, int x, int y, int id, Color MiColor)
        {
     
            for (int i = 0; i < Pixeles.Count; i++)
            {
                NuevosPixeles.Add(new Point(Pixeles[i].X + tx, Pixeles[i].Y + ty));
            }

            if (id == 1)
            {
                Recta(Pixeles, ColorFondo);
                Recta(NuevosPixeles, MiColor);
            }
            if (id == 2)
            {
                Irregular(Pixeles, Convert.ToInt32(cbLados.SelectedItem), ColorFondo);
                Irregular(NuevosPixeles, Convert.ToInt32(cbLados.SelectedItem), MiColor);
            }
            if (id == 3)
            {
                Circulo(Pixeles[0].X, Pixeles[0].Y, Convert.ToInt32(txtRadio.Text), ColorFondo);
                Circulo(NuevosPixeles[0].X,NuevosPixeles[0].Y, Convert.ToInt32(txtRadio.Text), MiColor);
            }
            if (id == 4)
            {
                Elipse(Pixeles[0].X,Pixeles[0].Y,RadioX,RadioY, ColorFondo);
                Elipse(NuevosPixeles[0].X,NuevosPixeles[0].Y,RadioX,RadioY, MiColor);
            }
            if (id == 5)
            { //Metodo Poligonos Regulares
                Irregular(Pixeles, Lados, ColorFondo);
                Irregular(NuevosPixeles, Lados, MiColor);
            }
            if (id == 6)
            {//Metodo Triangulo
                Irregular(Pixeles, Lados, ColorFondo);
                Irregular(NuevosPixeles, Lados, MiColor);
            }

            for (int i = 0; i < Pixeles.Count; i++)
            {
                Pixeles[i] = NuevosPixeles[i];
            }
            NuevosPixeles.Clear();
        }

        public void Rotacion(List<Point> Pixeles, int Grados, int id, Color MiColor)
        {
            Double X, Y;
            
            for (int j = 0; j < Pixeles.Count; j++)
            {
                X = Pixeles[Pixeles.Count - 1].X + (Pixeles[j].X - Pixeles[Pixeles.Count - 1].X) * Math.Cos(Grados * Math.PI / 180)
                                                 - (Pixeles[j].Y - Pixeles[Pixeles.Count - 1].Y) * Math.Sin(Grados * Math.PI / 180);
                Y= Pixeles[Pixeles.Count - 1].Y + (Pixeles[j].X - Pixeles[Pixeles.Count - 1].X) * Math.Sin(Grados * Math.PI / 180)
                                                 + (Pixeles[j].Y - Pixeles[Pixeles.Count - 1].Y) * Math.Cos(Grados * Math.PI / 180);
                NuevosPixeles.Add(new Point((int)Math.Round(X),(int)Math.Round(Y)));
            }

            if (id == 1)
            {
                Recta(Pixeles, ColorFondo);
                Recta(NuevosPixeles, MiColor);
            }
            if (id == 2)
            {
                Irregular(Pixeles, Convert.ToInt32(cbLados.SelectedItem), ColorFondo);
                Irregular(NuevosPixeles, Convert.ToInt32(cbLados.SelectedItem), MiColor);
            }
            if (id == 4)
            {
                Elipse(Pixeles[0].X, Pixeles[0].Y, RadioX, RadioY, ColorFondo);
                ElipseRotada(Pixeles[0].X, Pixeles[0].Y, RadioX + RadioX, RadioY, MiColor);
            }
            if (id == 5)
            { //Metodo Poligonos Regulares
                Irregular(Pixeles, Lados, ColorFondo);
                Irregular(NuevosPixeles, Lados, MiColor);
            }
            if (id == 6)
            {//Metodo Triangulo
                Irregular(Pixeles, Lados, ColorFondo);
                Irregular(NuevosPixeles, Lados, MiColor);
            }

            for (int i = 0; i < Pixeles.Count; i++)
            {
                Pixeles[i] = NuevosPixeles[i];
            }
            NuevosPixeles.Clear();
        }

        public void Escalamiento(List<Point> Pixeles, float S, Color MiColor)
        {
            Double X, Y;

            for (int j = 0; j < Pixeles.Count; j++)
            {
                X = Pixeles[Pixeles.Count - 1].X + S * (Pixeles[j].X - Pixeles[Pixeles.Count - 1].X);
                Y = Pixeles[Pixeles.Count - 1].Y + S * (Pixeles[j].Y - Pixeles[Pixeles.Count - 1].Y);
                NuevosPixeles.Add(new Point((int)Math.Round(X), (int)Math.Round(Y)));
            }

            if (id == 1)
            {
                Recta(Pixeles, ColorFondo);
                Recta(NuevosPixeles, MiColor);
            }
            if (id == 2)
            {
                Irregular(Pixeles, Convert.ToInt32(cbLados.SelectedItem), ColorFondo);
                Irregular(NuevosPixeles, Convert.ToInt32(cbLados.SelectedItem), MiColor);
            }
            if (id == 3)
            {
                Circulo(Pixeles[0].X, Pixeles[0].Y, Convert.ToInt32(txtRadio.Text), ColorFondo);
                Circulo(NuevosPixeles[0].X, NuevosPixeles[0].Y, Convert.ToInt32(Convert.ToInt32(txtRadio.Text)*s), MiColor);
            }
            if (id == 4)
            {
                Elipse(Pixeles[0].X, Pixeles[0].Y, RadioX, RadioY, ColorFondo);
                Elipse(NuevosPixeles[0].X, NuevosPixeles[0].Y, Convert.ToInt32(RadioX*s), Convert.ToInt32(RadioY*s), MiColor);
            }
            if (id == 5)
            { //Metodo Poligonos Regulares
                Irregular(Pixeles, Lados, ColorFondo);
                Irregular(NuevosPixeles, Lados, MiColor);
            }
            if (id == 6)
            {//Metodo Triangulo
                Irregular(Pixeles, Lados, ColorFondo);
                Irregular(NuevosPixeles, Lados, MiColor);
            }

            for (int i = 0; i < Pixeles.Count; i++)
            {
                Pixeles[i] = NuevosPixeles[i];
            }
            NuevosPixeles.Clear();
        }


        public void Recta(List<Point> Pixeles, Color Color)
        {
            int X, Y, P, DX, DY, INCX, INCY;
            DX = Pixeles[1].X - Pixeles[0].X;
            DY = Pixeles[1].Y - Pixeles[0].Y;

            if (DX < 0)
            {
                DX = -DX;
                INCX = -1;
            }
            else
            {
                INCX = 1;
            }
            if (DY < 0)
            {
                DY = -DY;
                INCY = -1;
            }
            else
            {
                INCY = 1;
            }
            X = Pixeles[0].X;
            Y = Pixeles[0].Y;

            GrosorPixel(X, Y, Color, Grosor);

            if (DX > DY)
            {
                P = 2 * DY - DX;
                while (X != Pixeles[1].X)
                {
                    X = X + INCX;

                    if (P < 0)
                    {
                        P = P + 2 * DY;
                    }
                    else
                    {
                        Y = Y + INCY;
                        P = P + 2 * (DY - DX);
                    }
                    GrosorPixel(X, Y, Color, Grosor);
                }
            }

            else
            {
                P = 2 * DX - DY;
                while (Y != Pixeles[1].Y)
                {
                    Y = Y + INCY;

                    if (P < 0)
                    {
                        P = P + 2 * DX;
                    }
                    else
                    {
                        X = X + INCX;
                        P = P + 2 * (DX - DY);
                    }
                    GrosorPixel(X, Y, Color, Grosor);
                }
            }
        }
      
        public void Irregular(List<Point> Pixeles, int lados, Color color)
        {
            List<Point> Auxiliar = new List<Point>();
            for (int i=0; i < lados-1; i++)
            {
                Auxiliar.Add(Pixeles[i]);
                Auxiliar.Add(Pixeles[i + 1]);
                Recta(Auxiliar, color);
                Auxiliar.Clear();
            }
                Auxiliar.Add(Pixeles[lados-1]);
                Auxiliar.Add(Pixeles[0]);
                Recta(Auxiliar, color);
                Auxiliar.Clear();
        }

        private void Circulo(int xc, int yc, int radio, Color color)
        {
            int x , y, e;
            x = radio; y = 0; e = 0;

            while (y <= x)
            {
                GrosorPixel(xc + x, yc + y, color, Grosor);
                GrosorPixel(xc - x, yc + y, color, Grosor);
                GrosorPixel(xc + x, yc - y, color, Grosor);
                GrosorPixel(xc - x, yc - y, color, Grosor);
                GrosorPixel(xc + y, yc + x, color, Grosor);
                GrosorPixel(xc - y, yc + x, color, Grosor);
                GrosorPixel(xc + y, yc - x, color, Grosor);
                GrosorPixel(xc - y, yc - x, color, Grosor);

                e = e + 2 * y + 1;
                y = y + 1;

                if (2 * e > (2 * x - 1))
                {
                    x = x - 1;
                    e = e - 2 * x + 1;
                }
            }
        }
	
	    public void PoligonoRegular(int xc,int yc,int lados,int ajuste, Color color)
	    {
		    float angulo;
		    double x,y;
		    
		    angulo=360/lados;
            if (BanderaTraslacion == false)
            {
                for (float i = ajuste; i < 360; i = i + angulo)
                {
                    x = xc + Radio * Math.Cos(i * Math.PI / 180);
                    y = yc + Radio * Math.Sin(i * Math.PI / 180);
                    Pixeles.Add(new Point((int)Math.Round(x), (int)Math.Round(y)));
                }
            }
            Irregular(Pixeles, lados, color);
	    }

        public void Elipse(int xc,int yc, int rx, int ry, Color color)
        {
            int x = 0;
            int y = ry;
            int p1 = (ry*ry)-ry*(rx*rx)+(1*(rx*rx))/4;
            int p2;
            while (((2*((ry*ry)))* x) <= ((2*((rx * rx))) * y)) 
            {
                GrosorPixel(xc + x, yc + y, color, Grosor);
                GrosorPixel(xc + x, yc - y, color, Grosor);
                GrosorPixel(xc - x, yc + y, color, Grosor);
                GrosorPixel(xc - x, yc - y, color, Grosor);
                x = x + 1;
                if (p1 <= 0)
                {
                    p1 = p1 + (2 * x) * (ry * ry) + (ry * ry);
                }
                else
                {
                    y = y - 1;
                    p1 = p1 + ((2*(x) * (ry * ry)) + (ry * ry))-(2*(rx*rx)*(y));
                }
            }
            p2 = ((ry * ry)*((x + (1) / 2)*(x + (1) / 2)))+((rx*rx)*((y - 1)*(y - 1))-((rx * rx)*(ry * ry)));
            while (y > 0)
            {
                y = y - 1;
                if (p2 <= 0)
                {
                    x = x + 1;
                    p2 = p2 + ((2 * x) * (ry * ry)) - ((2 * (rx * rx)) * y) + (rx * rx);
                }
                else
                {
                    p2 = p2 - ((2 * y) * (rx * rx)) + (rx * rx);
                }
                GrosorPixel(xc + x, yc + y, color, Grosor);
                GrosorPixel(xc + x, yc - y, color, Grosor);
                GrosorPixel(xc - x, yc + y, color, Grosor);
                GrosorPixel(xc - x, yc - y, color, Grosor);
            }
        }

        int gr;
        public void ElipseRotada(int xc, int yc, int rx, int ry, Color color)
        {
            gr = 10;
            int x = 0;
            int y = ry;
            int p1 = (ry * ry) - ry * (rx * rx) + (1 * (rx * rx)) / 4;
            int p2;

            while (((2 * ((ry * ry))) * x) <= ((2 * ((rx * rx))) * y))
            {
                GrosorPixel(xc + x, yc + y, color, Grosor);
                GrosorPixel(xc + x, yc - y, color, Grosor);
                GrosorPixel(xc - x, yc + y, color, Grosor);
                GrosorPixel(xc - x, yc - y, color, Grosor);
                x = x + 1;
                if (p1 <= 0)
                {
                    p1 = p1 + (2 * x) * (ry * ry) + (ry * ry);
                }
                else
                {
                    y = y - 1;
                    p1 = p1 + ((2 * (x) * (ry * ry)) + (ry * ry)) - (2 * (rx * rx) * (y));
                }
            }
            p2 = ((ry * ry) * ((x + (1) / 2) * (x + (1) / 2))) + ((rx * rx) * ((y - 1) * (y - 1)) - ((rx * rx) * (ry * ry)));
            while (y > 0)
            {
                y = y - 1;
                if (p2 <= 0)
                {
                    x = x + 1;
                    p2 = p2 + ((2 * x) * (ry * ry)) - ((2 * (rx * rx)) * y) + (rx * rx);
                }
                else
                {
                    p2 = p2 - ((2 * y) * (rx * rx)) + (rx * rx);
                }
                GrosorPixel(xc + x, yc + y, color, Grosor);
                GrosorPixel(xc + x, yc - y, color, Grosor);
                GrosorPixel(xc - x, yc + y, color, Grosor);
                GrosorPixel(xc - x, yc - y, color, Grosor);
            }
        }
        public void Rectangulo(int xc, int yc, int lados, int ajuste, Color color)
        {
            float angulo;
            double x, y;

            angulo = 360 / lados;
            if (BanderaTraslacion == false)
            {
                for (float i = ajuste; i < 360; i = i + angulo)
                {
                    x = xc + RadioX * Math.Cos(i * Math.PI / 180);
                    y = yc + RadioY * Math.Sin(i * Math.PI / 180);
                    Pixeles.Add(new Point((int)Math.Round(x), (int)Math.Round(y)));
                }
            }
            Irregular(Pixeles, lados, color);
        }

        public void MetodoRelleno(int x, int y)
        {
            int PuntoX, PuntoY;
            Color ColorActual;
            ColorActual = MiColor;

            Color ColorAnterior = Lienzo.GetPixel(x, y);
            if ((ColorActual.A != ColorAnterior.A) || (ColorActual.B != ColorAnterior.B) || (ColorActual.G != ColorAnterior.G) || (ColorActual.R != ColorAnterior.R))
            {
                Stack<int> Pila = new Stack<int>();
                Pila.Push(x);
                Pila.Push(y);
                while (Pila.Count != 0)
                {
                    PuntoY = (int)Pila.Pop();
                    PuntoX = (int)Pila.Pop();
                    if ((PuntoX >= 0) && (PuntoY >= 0) && (PuntoX <= Lienzo.Width - 1) && (PuntoY <= Lienzo.Height - 1))
                    {
                        if (Lienzo.GetPixel(PuntoX, PuntoY) == ColorAnterior)
                        {
                            Lienzo.SetPixel(PuntoX, PuntoY, ColorActual);
                            Pila.Push(PuntoX - 1);
                            Pila.Push(PuntoY);
                            Pila.Push(PuntoX + 1);
                            Pila.Push(PuntoY);
                            Pila.Push(PuntoX);
                            Pila.Push(PuntoY + 1);
                            Pila.Push(PuntoX);
                            Pila.Push(PuntoY - 1);
                        }
                    }
                }
                Pila.Clear();
                pbAreaDeImagen.Image = Lienzo;
            }
        }

        public void MetodoOrdenamiento()
        {
            int ultimo;

            ultimo = Pixeles.Count - 1;

            List<Point> AUX = new List<Point>();
            List<Point> SubstituyeLista = new List<Point>();

            for (int i = 0; i <= Pixeles.Count - 1; i++)
            {
                SubstituyeLista.Add(new Point(Pixeles[i].X, Pixeles[i].Y));
            }


            SubstituyeLista = SubstituyeLista.OrderByDescending(p => p.X).ToList();
            AUX.Add(new Point(SubstituyeLista[0].X, SubstituyeLista[0].Y));
            AUX.Add(new Point(SubstituyeLista[ultimo].X, SubstituyeLista[ultimo].Y));

            xce = (SubstituyeLista[0].X + SubstituyeLista[ultimo].X) / 2;

            SubstituyeLista = SubstituyeLista.OrderByDescending(p => p.Y).ToList();
            AUX.Add(new Point(SubstituyeLista[0].X, SubstituyeLista[0].Y));
            AUX.Add(new Point(SubstituyeLista[ultimo].X, SubstituyeLista[ultimo].Y));

            yce = (SubstituyeLista[0].Y + SubstituyeLista[ultimo].Y) / 2;

            AUX.Clear();
        }

        //Metodo para Ampliar Botones al mismo tiempo
        private void AdaptarPantalla(object sender, EventArgs e)
        {
            
            pbAreaDeImagen.Width = this.Width - 50;
            pbAreaDeImagen.Height = this.Height - 20;
            btnLimpiarImagen.Top = this.Height - 100;
            btnLimpiarImagen.Left = this.Width - 120;
            gbColores.Left = this.Width - 250;
            gbPolRegulares.Left = this.Width - 450;
            Lienzo = new Bitmap(pbAreaDeImagen.Width, pbAreaDeImagen.Height);
            btnRelleno.Left = this.Width - 520;
        }

        //btnLimpiar Area de Imagen
        private void LimpiarImagen_Click(object sender, EventArgs e)
        {
            Lienzo = new Bitmap(pbAreaDeImagen.Width, pbAreaDeImagen.Height);
            pbAreaDeImagen.Image = Lienzo;
            Pixeles.Clear();
        }

        
        private void btnPaletaColores_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.MiColor = colorDialog1.Color;
            }
        }

        public void GrosorPixel(int x, int y, Color MiColor, int Grosor)
        {
            for (int i = 0; i < Grosor; i++)
            {
                for (int j = 0; j < Grosor; j++)
                {
                    ValidarPixel(x + i, y + j, MiColor);
                }
            }
        }

        private void cbGrosor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Grosor = Convert.ToInt32(cbGrosor.SelectedItem);

        }

        public void ValidarPixel(int x, int y, Color MiColor)
        {
            if (x > 0 && y > 0 && x < pbAreaDeImagen.Width && y < pbAreaDeImagen.Height)
            {
                Lienzo.SetPixel(x, y, MiColor);
            }
        }
    
        //Botones
        private void EstadoBandera()
        {
            BanderaCirculo = false;
            BanderaPixel = false;
            BanderaRecta = false;
            BanderaPoligono = false;
	        BanderaPRegular=false;
            BanderaElipse = false;
            BanderaRectangulo = false;
            BanderaRelleno = false;
            BanderaTraslacion = false;
            txtRadio.Enabled = false;
            txtRadioX.Enabled = false;
            txtRadioY.Enabled = false;
            cbLados.Enabled = false;
           
        }

        private void btnPoligono_Click(object sender, EventArgs e)
        {
             EstadoBandera();
             BanderaPoligono = true;
             cbLados.Enabled = true; 
        }

        private void ActivarPixel_Click(object sender, EventArgs e)
        {
            EstadoBandera();
            BanderaPixel = true;
        }

        private void btnGuardarImagen_Click(object sender, EventArgs e)
        {
            SaveFileDialog Guardar = new SaveFileDialog();
            Guardar.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP";
            Image Imagen = pbAreaDeImagen.Image;
            Guardar.ShowDialog();
            Imagen.Save(Guardar.FileName);
        }

        float s;
        private void btnMasEscalar_Click(object sender, EventArgs e)
        {
            s = s + 1;
            pbAreaDeImagen.Image = Lienzo;
            Escalamiento(Pixeles,s,MiColor);      
        }

        private void btnMenosEscalar_Click(object sender, EventArgs e)
        {

            s = s - 1; 
            
            pbAreaDeImagen.Image = Lienzo;
            Escalamiento(Pixeles, s, MiColor);
        }

        private void btnRotacion_Click(object sender, EventArgs e)
        {
            if (txtRotacion.Text == string.Empty)
            {
                MessageBox.Show("Introduzca los grados de Rotacion");
            }
            else
            {
                EstadoBandera();
                pbAreaDeImagen.Image = Lienzo;
                Rotacion(Pixeles,Convert.ToInt32(txtRotacion.Text),id,MiColor);
            }
        }

        private void btnCirculo_Click_1(object sender, EventArgs e)
        {
            EstadoBandera();
            BanderaCirculo = true;
            txtRadio.Text = "100";
            txtRadio.Enabled = true;   
        }

        private void btnTrazarLinea_Click(object sender, EventArgs e)
        {
            EstadoBandera();  
            BanderaRecta = true;
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            frmAyuda Ayuda = new frmAyuda();
            Ayuda.ShowDialog();
        }

        //Botones Figuras Regulares
        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            EstadoBandera();
            BanderaPRegular = true;
            Lados = 3;
            Ajuste = -90;
        }

        private void btnTraslacion_Click(object sender, EventArgs e)
        {
            EstadoBandera();
            BanderaTraslacion = true;
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            EstadoBandera();
            BanderaPRegular = true;
            Lados = 4;
            Ajuste = 45;
        }

        private void Hexagono_Click(object sender, EventArgs e)
        {
            EstadoBandera();
            BanderaPRegular = true;
            Lados = 6;
            Ajuste = 0;
        }

        private void btnRelleno_Click(object sender, EventArgs e)
        {
            EstadoBandera();
            BanderaRelleno = true;
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            EstadoBandera();
            BanderaRectangulo = true;
            Lados = 4;
            Ajuste = 45;
        }

        private void Pentagono_Click(object sender, EventArgs e)
        {
            EstadoBandera();
            BanderaPRegular = true;
            Lados = 8;
            Ajuste = 22;
        }

        private void btnPolPersonalizado_Click(object sender, EventArgs e)
        {
            EstadoBandera();
            BanderaPRegular = true;
            cbLados.Enabled = true;
            txtRadio.Enabled = true;
            txtRadio.Text = "100";
            cbLados.SelectedIndex = 2;
            Lados = Convert.ToInt32(cbLados.SelectedItem);
            Ajuste = 0;
            
        }

        private void btnTrazarElipse_Click(object sender, EventArgs e)
        {
            EstadoBandera();
            BanderaElipse = true;
            txtRadioX.Text = "75";
            txtRadioY.Text = "50";
            txtRadioX.Enabled = true;
            txtRadioY.Enabled = true;
        }

        //Colores
        private void ColorAzul_Click(object sender, EventArgs e)
        {
            MiColor = Color.Blue;
            ColorenUso.BackColor = MiColor;
        }

        private void ColorAmarillo_Click(object sender, EventArgs e)
        {
            MiColor = Color.Yellow;
            ColorenUso.BackColor = MiColor;
        }

        private void ColorRojo_Click(object sender, EventArgs e)
        {
            MiColor = Color.Red;
            ColorenUso.BackColor = MiColor;
        }

        private void ColorVerde_Click(object sender, EventArgs e)
        {
            MiColor = Color.Green;
            ColorenUso.BackColor = MiColor;
        }
    }
}
