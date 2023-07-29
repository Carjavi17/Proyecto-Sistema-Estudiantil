namespace UserInterface
{
    partial class Frm_Admin_Teacher
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
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textbDNI = new NumericUpDown();
            tbFullName = new TextBox();
            button1 = new Button();
            label3 = new Label();
            tbSpecialty = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textbDNI).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Logo_removebg_preview;
            pictureBox2.Location = new Point(2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 73);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(144, 43);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 2;
            label1.Text = "Ingrese el DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(305, 43);
            label2.Name = "label2";
            label2.Size = new Size(151, 21);
            label2.TabIndex = 3;
            label2.Text = "Ingrese el Nombre";
            // 
            // textbDNI
            // 
            textbDNI.Location = new Point(142, 77);
            textbDNI.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            textbDNI.Name = "textbDNI";
            textbDNI.Size = new Size(120, 23);
            textbDNI.TabIndex = 5;
            // 
            // tbFullName
            // 
            tbFullName.Location = new Point(305, 77);
            tbFullName.Name = "tbFullName";
            tbFullName.Size = new Size(173, 23);
            tbFullName.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.BackgroundImage = Properties.Resources.Fondo_Boton;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(341, 124);
            button1.Name = "button1";
            button1.Size = new Size(92, 34);
            button1.TabIndex = 7;
            button1.Text = "Cargar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(519, 43);
            label3.Name = "label3";
            label3.Size = new Size(184, 21);
            label3.TabIndex = 8;
            label3.Text = "Ingrese la Especialidad";
            // 
            // tbSpecialty
            // 
            tbSpecialty.Location = new Point(519, 76);
            tbSpecialty.Name = "tbSpecialty";
            tbSpecialty.Size = new Size(173, 23);
            tbSpecialty.TabIndex = 9;
            // 
            // Frm_Admin_Teacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.Fondopg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(738, 224);
            Controls.Add(tbSpecialty);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(tbFullName);
            Controls.Add(textbDNI);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "Frm_Admin_Teacher";
            Text = "Crear Profesor";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)textbDNI).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private NumericUpDown textbDNI;
        private TextBox tbFullName;
        private Button button1;
        private Label label3;
        private TextBox tbSpecialty;
    }
}