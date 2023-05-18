namespace PracticaParcial
{
    partial class IngresoAlumnos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            comboBox1 = new ComboBox();
            domainUpDown1 = new DomainUpDown();
            ListaAlumnos = new GroupBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            domainUpDown2 = new DomainUpDown();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripTextBox1 = new ToolStripTextBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            groupBox6 = new GroupBox();
            fontDialog1 = new FontDialog();
            richTextBox4 = new RichTextBox();
            richTextBox5 = new RichTextBox();
            richTextBox6 = new RichTextBox();
            button2 = new Button();
            panel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(richTextBox6);
            panel1.Controls.Add(richTextBox5);
            panel1.Controls.Add(richTextBox4);
            panel1.Controls.Add(groupBox5);
            panel1.Controls.Add(groupBox6);
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(178, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 169);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(77, 115);
            button1.Name = "button1";
            button1.Size = new Size(170, 32);
            button1.TabIndex = 0;
            button1.Text = "Crear Alumno";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 261);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(188, 186);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "lstAlumnosCreados";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(447, 261);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(133, 195);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "lstAlumnosInscriptosProgramacion";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(663, 261);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(133, 195);
            richTextBox3.TabIndex = 3;
            richTextBox3.Text = "lstAlumnosInscriptosLabo";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(245, 337);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(143, 28);
            comboBox1.TabIndex = 4;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(3, 3);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(10, 27);
            domainUpDown1.TabIndex = 5;
            domainUpDown1.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
            // 
            // ListaAlumnos
            // 
            ListaAlumnos.Location = new Point(12, 229);
            ListaAlumnos.Name = "ListaAlumnos";
            ListaAlumnos.Size = new Size(154, 26);
            ListaAlumnos.TabIndex = 6;
            ListaAlumnos.TabStop = false;
            ListaAlumnos.Text = "Lista Alumnos";
            ListaAlumnos.Enter += ListaAlumnos_Enter;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(439, 229);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(185, 28);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista Alumnos Progra";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(667, 229);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(154, 26);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista Alumnos Labo";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // domainUpDown2
            // 
            domainUpDown2.Location = new Point(162, 161);
            domainUpDown2.Name = "domainUpDown2";
            domainUpDown2.Size = new Size(10, 27);
            domainUpDown2.TabIndex = 9;
            domainUpDown2.Text = "domainUpDown2";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(161, 33);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 27);
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Control;
            groupBox3.Location = new Point(273, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(154, 26);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Alta Alumno";
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(15, 39);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(74, 26);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "DNI:";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // groupBox5
            // 
            groupBox5.Location = new Point(169, 39);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(97, 26);
            groupBox5.TabIndex = 8;
            groupBox5.TabStop = false;
            groupBox5.Text = "APELLIDO:";
            // 
            // groupBox6
            // 
            groupBox6.Location = new Point(315, 39);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(87, 26);
            groupBox6.TabIndex = 8;
            groupBox6.TabStop = false;
            groupBox6.Text = "NOMBRE:";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(15, 71);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(106, 30);
            richTextBox4.TabIndex = 11;
            richTextBox4.Text = "";
            // 
            // richTextBox5
            // 
            richTextBox5.Location = new Point(154, 69);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(106, 30);
            richTextBox5.TabIndex = 12;
            richTextBox5.Text = "";
            // 
            // richTextBox6
            // 
            richTextBox6.Location = new Point(296, 69);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.Size = new Size(106, 30);
            richTextBox6.TabIndex = 13;
            richTextBox6.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(244, 393);
            button2.Name = "button2";
            button2.Size = new Size(151, 62);
            button2.TabIndex = 11;
            button2.Text = "Asignar al alumno seleccionado";
            button2.UseVisualStyleBackColor = true;
            // 
            // IngresoAlumnos
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 468);
            Controls.Add(button2);
            Controls.Add(groupBox3);
            Controls.Add(domainUpDown2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(ListaAlumnos);
            Controls.Add(domainUpDown1);
            Controls.Add(comboBox1);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            Name = "IngresoAlumnos";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Button button1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private ComboBox comboBox1;
        private DomainUpDown domainUpDown1;
        private GroupBox ListaAlumnos;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private GroupBox groupBox4;
        private DomainUpDown domainUpDown2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripTextBox toolStripTextBox1;
        private GroupBox groupBox3;
        private RichTextBox richTextBox6;
        private RichTextBox richTextBox5;
        private RichTextBox richTextBox4;
        private FontDialog fontDialog1;
        private Button button2;
    }
}