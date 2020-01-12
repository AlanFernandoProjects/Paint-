namespace ProyectoGraficacion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbAreaDeImagen = new System.Windows.Forms.PictureBox();
            this.btnActivarPixel = new System.Windows.Forms.Button();
            this.btnLimpiarImagen = new System.Windows.Forms.Button();
            this.ColorenUso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ColorAzul = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.gbColores = new System.Windows.Forms.GroupBox();
            this.btnPaletaColores = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cbGrosor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTrazarLinea = new System.Windows.Forms.Button();
            this.btnPoligono = new System.Windows.Forms.Button();
            this.cbLados = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.gbPolRegulares = new System.Windows.Forms.GroupBox();
            this.btnPolPersonalizado = new System.Windows.Forms.Button();
            this.Hexagono = new System.Windows.Forms.Button();
            this.Pentagono = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.btnTrazarElipse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRadioX = new System.Windows.Forms.TextBox();
            this.txtRadioY = new System.Windows.Forms.TextBox();
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.btnRelleno = new System.Windows.Forms.Button();
            this.btnTraslacion = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.txtRotacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardarImagen = new System.Windows.Forms.Button();
            this.btnMasEscalar = new System.Windows.Forms.Button();
            this.btnMenosEscalar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRotacion = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAreaDeImagen)).BeginInit();
            this.gbColores.SuspendLayout();
            this.gbPolRegulares.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAreaDeImagen
            // 
            this.pbAreaDeImagen.BackColor = System.Drawing.Color.Silver;
            this.pbAreaDeImagen.Location = new System.Drawing.Point(135, 129);
            this.pbAreaDeImagen.Name = "pbAreaDeImagen";
            this.pbAreaDeImagen.Size = new System.Drawing.Size(1207, 390);
            this.pbAreaDeImagen.TabIndex = 0;
            this.pbAreaDeImagen.TabStop = false;
            this.pbAreaDeImagen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseDibujarPixel);
            // 
            // btnActivarPixel
            // 
            this.btnActivarPixel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActivarPixel.BackgroundImage")));
            this.btnActivarPixel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActivarPixel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivarPixel.Location = new System.Drawing.Point(21, 12);
            this.btnActivarPixel.Name = "btnActivarPixel";
            this.btnActivarPixel.Size = new System.Drawing.Size(64, 87);
            this.btnActivarPixel.TabIndex = 1;
            this.btnActivarPixel.Text = "Pixel";
            this.btnActivarPixel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActivarPixel.UseVisualStyleBackColor = true;
            this.btnActivarPixel.Click += new System.EventHandler(this.ActivarPixel_Click);
            // 
            // btnLimpiarImagen
            // 
            this.btnLimpiarImagen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiarImagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarImagen.BackgroundImage")));
            this.btnLimpiarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarImagen.Location = new System.Drawing.Point(860, 525);
            this.btnLimpiarImagen.Name = "btnLimpiarImagen";
            this.btnLimpiarImagen.Size = new System.Drawing.Size(99, 66);
            this.btnLimpiarImagen.TabIndex = 2;
            this.btnLimpiarImagen.UseVisualStyleBackColor = false;
            this.btnLimpiarImagen.Click += new System.EventHandler(this.LimpiarImagen_Click);
            // 
            // ColorenUso
            // 
            this.ColorenUso.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ColorenUso.Location = new System.Drawing.Point(9, 32);
            this.ColorenUso.Name = "ColorenUso";
            this.ColorenUso.Size = new System.Drawing.Size(65, 62);
            this.ColorenUso.TabIndex = 3;
            this.ColorenUso.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Color en Uso";
            // 
            // ColorAzul
            // 
            this.ColorAzul.BackColor = System.Drawing.SystemColors.Highlight;
            this.ColorAzul.Location = new System.Drawing.Point(80, 32);
            this.ColorAzul.Name = "ColorAzul";
            this.ColorAzul.Size = new System.Drawing.Size(34, 28);
            this.ColorAzul.TabIndex = 5;
            this.ColorAzul.UseVisualStyleBackColor = false;
            this.ColorAzul.Click += new System.EventHandler(this.ColorAzul_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(80, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 28);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ColorRojo_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(119, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 28);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ColorAmarillo_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Lime;
            this.button5.Location = new System.Drawing.Point(119, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 28);
            this.button5.TabIndex = 8;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.ColorVerde_Click);
            // 
            // gbColores
            // 
            this.gbColores.Controls.Add(this.btnPaletaColores);
            this.gbColores.Controls.Add(this.ColorenUso);
            this.gbColores.Controls.Add(this.button5);
            this.gbColores.Controls.Add(this.label1);
            this.gbColores.Controls.Add(this.button4);
            this.gbColores.Controls.Add(this.ColorAzul);
            this.gbColores.Controls.Add(this.button3);
            this.gbColores.Location = new System.Drawing.Point(1115, 5);
            this.gbColores.Name = "gbColores";
            this.gbColores.Size = new System.Drawing.Size(227, 118);
            this.gbColores.TabIndex = 9;
            this.gbColores.TabStop = false;
            // 
            // btnPaletaColores
            // 
            this.btnPaletaColores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPaletaColores.BackgroundImage")));
            this.btnPaletaColores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaletaColores.Location = new System.Drawing.Point(162, 32);
            this.btnPaletaColores.Name = "btnPaletaColores";
            this.btnPaletaColores.Size = new System.Drawing.Size(59, 62);
            this.btnPaletaColores.TabIndex = 10;
            this.btnPaletaColores.UseVisualStyleBackColor = true;
            this.btnPaletaColores.Click += new System.EventHandler(this.btnPaletaColores_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // cbGrosor
            // 
            this.cbGrosor.FormattingEnabled = true;
            this.cbGrosor.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "30",
            "40"});
            this.cbGrosor.Location = new System.Drawing.Point(96, 42);
            this.cbGrosor.Name = "cbGrosor";
            this.cbGrosor.Size = new System.Drawing.Size(74, 21);
            this.cbGrosor.TabIndex = 11;
            this.cbGrosor.SelectedIndexChanged += new System.EventHandler(this.cbGrosor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Grosor:";
            // 
            // btnTrazarLinea
            // 
            this.btnTrazarLinea.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTrazarLinea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrazarLinea.BackgroundImage")));
            this.btnTrazarLinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrazarLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrazarLinea.Location = new System.Drawing.Point(176, 12);
            this.btnTrazarLinea.Name = "btnTrazarLinea";
            this.btnTrazarLinea.Size = new System.Drawing.Size(78, 87);
            this.btnTrazarLinea.TabIndex = 13;
            this.btnTrazarLinea.UseVisualStyleBackColor = false;
            this.btnTrazarLinea.Click += new System.EventHandler(this.btnTrazarLinea_Click);
            // 
            // btnPoligono
            // 
            this.btnPoligono.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPoligono.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPoligono.BackgroundImage")));
            this.btnPoligono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPoligono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoligono.Location = new System.Drawing.Point(260, 12);
            this.btnPoligono.Name = "btnPoligono";
            this.btnPoligono.Size = new System.Drawing.Size(122, 59);
            this.btnPoligono.TabIndex = 14;
            this.btnPoligono.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPoligono.UseVisualStyleBackColor = false;
            this.btnPoligono.Click += new System.EventHandler(this.btnPoligono_Click);
            // 
            // cbLados
            // 
            this.cbLados.FormattingEnabled = true;
            this.cbLados.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbLados.Location = new System.Drawing.Point(263, 87);
            this.cbLados.Name = "cbLados";
            this.cbLados.Size = new System.Drawing.Size(119, 21);
            this.cbLados.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Numero de Lados:";
            // 
            // btnCirculo
            // 
            this.btnCirculo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCirculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCirculo.BackgroundImage")));
            this.btnCirculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCirculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCirculo.Location = new System.Drawing.Point(391, 12);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(91, 59);
            this.btnCirculo.TabIndex = 17;
            this.btnCirculo.UseVisualStyleBackColor = false;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(391, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Radio:";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(394, 88);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(88, 20);
            this.txtRadio.TabIndex = 19;
            // 
            // gbPolRegulares
            // 
            this.gbPolRegulares.Controls.Add(this.btnPolPersonalizado);
            this.gbPolRegulares.Controls.Add(this.Hexagono);
            this.gbPolRegulares.Controls.Add(this.Pentagono);
            this.gbPolRegulares.Controls.Add(this.btnCuadrado);
            this.gbPolRegulares.Controls.Add(this.btnTriangulo);
            this.gbPolRegulares.Location = new System.Drawing.Point(922, 5);
            this.gbPolRegulares.Name = "gbPolRegulares";
            this.gbPolRegulares.Size = new System.Drawing.Size(193, 118);
            this.gbPolRegulares.TabIndex = 20;
            this.gbPolRegulares.TabStop = false;
            this.gbPolRegulares.Text = "Poligonos Regulares";
            // 
            // btnPolPersonalizado
            // 
            this.btnPolPersonalizado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPolPersonalizado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPolPersonalizado.Location = new System.Drawing.Point(67, 69);
            this.btnPolPersonalizado.Name = "btnPolPersonalizado";
            this.btnPolPersonalizado.Size = new System.Drawing.Size(111, 40);
            this.btnPolPersonalizado.TabIndex = 4;
            this.btnPolPersonalizado.Text = "Personalizado";
            this.btnPolPersonalizado.UseVisualStyleBackColor = false;
            this.btnPolPersonalizado.Click += new System.EventHandler(this.btnPolPersonalizado_Click);
            // 
            // Hexagono
            // 
            this.Hexagono.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Hexagono.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Hexagono.BackgroundImage")));
            this.Hexagono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Hexagono.Location = new System.Drawing.Point(124, 19);
            this.Hexagono.Name = "Hexagono";
            this.Hexagono.Size = new System.Drawing.Size(54, 44);
            this.Hexagono.TabIndex = 3;
            this.Hexagono.UseVisualStyleBackColor = false;
            this.Hexagono.Click += new System.EventHandler(this.Hexagono_Click);
            // 
            // Pentagono
            // 
            this.Pentagono.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pentagono.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pentagono.BackgroundImage")));
            this.Pentagono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pentagono.Location = new System.Drawing.Point(6, 71);
            this.Pentagono.Name = "Pentagono";
            this.Pentagono.Size = new System.Drawing.Size(55, 40);
            this.Pentagono.TabIndex = 2;
            this.Pentagono.UseVisualStyleBackColor = false;
            this.Pentagono.Click += new System.EventHandler(this.Pentagono_Click);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCuadrado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCuadrado.BackgroundImage")));
            this.btnCuadrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCuadrado.Location = new System.Drawing.Point(67, 19);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(51, 46);
            this.btnCuadrado.TabIndex = 1;
            this.btnCuadrado.UseVisualStyleBackColor = false;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTriangulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTriangulo.BackgroundImage")));
            this.btnTriangulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTriangulo.Location = new System.Drawing.Point(6, 19);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(55, 47);
            this.btnTriangulo.TabIndex = 0;
            this.btnTriangulo.UseVisualStyleBackColor = false;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // btnTrazarElipse
            // 
            this.btnTrazarElipse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTrazarElipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrazarElipse.BackgroundImage")));
            this.btnTrazarElipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrazarElipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrazarElipse.Location = new System.Drawing.Point(488, 12);
            this.btnTrazarElipse.Name = "btnTrazarElipse";
            this.btnTrazarElipse.Size = new System.Drawing.Size(139, 59);
            this.btnTrazarElipse.TabIndex = 21;
            this.btnTrazarElipse.UseVisualStyleBackColor = false;
            this.btnTrazarElipse.Click += new System.EventHandler(this.btnTrazarElipse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(488, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Radio X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(566, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Radio Y:";
            // 
            // txtRadioX
            // 
            this.txtRadioX.Location = new System.Drawing.Point(491, 88);
            this.txtRadioX.Name = "txtRadioX";
            this.txtRadioX.Size = new System.Drawing.Size(59, 20);
            this.txtRadioX.TabIndex = 24;
            // 
            // txtRadioY
            // 
            this.txtRadioY.Location = new System.Drawing.Point(569, 87);
            this.txtRadioY.Name = "txtRadioY";
            this.txtRadioY.Size = new System.Drawing.Size(58, 20);
            this.txtRadioY.TabIndex = 25;
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRectangulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRectangulo.BackgroundImage")));
            this.btnRectangulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRectangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRectangulo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRectangulo.Location = new System.Drawing.Point(633, 12);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(96, 59);
            this.btnRectangulo.TabIndex = 26;
            this.btnRectangulo.UseVisualStyleBackColor = false;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // btnRelleno
            // 
            this.btnRelleno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRelleno.BackgroundImage")));
            this.btnRelleno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelleno.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRelleno.Location = new System.Drawing.Point(860, 12);
            this.btnRelleno.Name = "btnRelleno";
            this.btnRelleno.Size = new System.Drawing.Size(62, 59);
            this.btnRelleno.TabIndex = 27;
            this.btnRelleno.UseVisualStyleBackColor = true;
            this.btnRelleno.Click += new System.EventHandler(this.btnRelleno_Click);
            // 
            // btnTraslacion
            // 
            this.btnTraslacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTraslacion.BackgroundImage")));
            this.btnTraslacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTraslacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraslacion.Location = new System.Drawing.Point(735, 13);
            this.btnTraslacion.Name = "btnTraslacion";
            this.btnTraslacion.Size = new System.Drawing.Size(61, 58);
            this.btnTraslacion.TabIndex = 28;
            this.btnTraslacion.UseVisualStyleBackColor = true;
            this.btnTraslacion.Click += new System.EventHandler(this.btnTraslacion_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAyuda.BackgroundImage")));
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyuda.Location = new System.Drawing.Point(18, 445);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(75, 47);
            this.btnAyuda.TabIndex = 29;
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // txtRotacion
            // 
            this.txtRotacion.Location = new System.Drawing.Point(13, 145);
            this.txtRotacion.Name = "txtRotacion";
            this.txtRotacion.Size = new System.Drawing.Size(72, 20);
            this.txtRotacion.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Rotacion:";
            // 
            // btnGuardarImagen
            // 
            this.btnGuardarImagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarImagen.BackgroundImage")));
            this.btnGuardarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarImagen.Location = new System.Drawing.Point(18, 349);
            this.btnGuardarImagen.Name = "btnGuardarImagen";
            this.btnGuardarImagen.Size = new System.Drawing.Size(69, 59);
            this.btnGuardarImagen.TabIndex = 36;
            this.btnGuardarImagen.UseVisualStyleBackColor = true;
            this.btnGuardarImagen.Click += new System.EventHandler(this.btnGuardarImagen_Click);
            // 
            // btnMasEscalar
            // 
            this.btnMasEscalar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMasEscalar.BackgroundImage")));
            this.btnMasEscalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMasEscalar.Location = new System.Drawing.Point(13, 268);
            this.btnMasEscalar.Name = "btnMasEscalar";
            this.btnMasEscalar.Size = new System.Drawing.Size(55, 49);
            this.btnMasEscalar.TabIndex = 37;
            this.btnMasEscalar.UseVisualStyleBackColor = true;
            this.btnMasEscalar.Click += new System.EventHandler(this.btnMasEscalar_Click);
            // 
            // btnMenosEscalar
            // 
            this.btnMenosEscalar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenosEscalar.BackgroundImage")));
            this.btnMenosEscalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenosEscalar.Location = new System.Drawing.Point(74, 268);
            this.btnMenosEscalar.Name = "btnMenosEscalar";
            this.btnMenosEscalar.Size = new System.Drawing.Size(55, 49);
            this.btnMenosEscalar.TabIndex = 38;
            this.btnMenosEscalar.UseVisualStyleBackColor = true;
            this.btnMenosEscalar.Click += new System.EventHandler(this.btnMenosEscalar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Escalar:";
            // 
            // btnRotacion
            // 
            this.btnRotacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRotacion.BackgroundImage")));
            this.btnRotacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRotacion.Location = new System.Drawing.Point(13, 171);
            this.btnRotacion.Name = "btnRotacion";
            this.btnRotacion.Size = new System.Drawing.Size(71, 52);
            this.btnRotacion.TabIndex = 40;
            this.btnRotacion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnRotacion.UseVisualStyleBackColor = true;
            this.btnRotacion.Click += new System.EventHandler(this.btnRotacion_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Guardar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "Ayuda:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 603);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRotacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnMenosEscalar);
            this.Controls.Add(this.btnMasEscalar);
            this.Controls.Add(this.btnGuardarImagen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRotacion);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnTraslacion);
            this.Controls.Add(this.btnRelleno);
            this.Controls.Add(this.btnRectangulo);
            this.Controls.Add(this.txtRadioY);
            this.Controls.Add(this.txtRadioX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTrazarElipse);
            this.Controls.Add(this.gbPolRegulares);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCirculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbLados);
            this.Controls.Add(this.btnPoligono);
            this.Controls.Add(this.btnTrazarLinea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbGrosor);
            this.Controls.Add(this.gbColores);
            this.Controls.Add(this.btnLimpiarImagen);
            this.Controls.Add(this.btnActivarPixel);
            this.Controls.Add(this.pbAreaDeImagen);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto Graficacion - Castillo Alan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.AdaptarPantalla);
            ((System.ComponentModel.ISupportInitialize)(this.pbAreaDeImagen)).EndInit();
            this.gbColores.ResumeLayout(false);
            this.gbColores.PerformLayout();
            this.gbPolRegulares.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAreaDeImagen;
        private System.Windows.Forms.Button btnActivarPixel;
        private System.Windows.Forms.Button btnLimpiarImagen;
        private System.Windows.Forms.Button ColorenUso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ColorAzul;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox gbColores;
        private System.Windows.Forms.Button btnPaletaColores;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cbGrosor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTrazarLinea;
        private System.Windows.Forms.Button btnPoligono;
        private System.Windows.Forms.ComboBox cbLados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.GroupBox gbPolRegulares;
        private System.Windows.Forms.Button Hexagono;
        private System.Windows.Forms.Button Pentagono;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button btnPolPersonalizado;
        private System.Windows.Forms.Button btnTrazarElipse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRadioX;
        private System.Windows.Forms.TextBox txtRadioY;
        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.Button btnRelleno;
        private System.Windows.Forms.Button btnTraslacion;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.TextBox txtRotacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardarImagen;
        private System.Windows.Forms.Button btnMasEscalar;
        private System.Windows.Forms.Button btnMenosEscalar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRotacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

