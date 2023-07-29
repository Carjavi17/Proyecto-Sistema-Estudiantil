namespace UserInterface
{
    partial class Frm_Admin_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Admin_Student));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            tBFullName = new TextBox();
            tBDni = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tBDni).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo_removebg_preview;
            pictureBox1.Location = new Point(1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(134, 50);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 1;
            label1.Text = "Ingrese el DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(328, 50);
            label2.Name = "label2";
            label2.Size = new Size(151, 21);
            label2.TabIndex = 2;
            label2.Text = "Ingrese el Nombre";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(259, 118);
            button1.Name = "button1";
            button1.Size = new Size(92, 34);
            button1.TabIndex = 3;
            button1.Text = "Cargar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tBFullName
            // 
            tBFullName.Location = new Point(328, 74);
            tBFullName.Name = "tBFullName";
            tBFullName.Size = new Size(148, 23);
            tBFullName.TabIndex = 5;
            // 
            // tBDni
            // 
            tBDni.Location = new Point(134, 74);
            tBDni.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            tBDni.Name = "tBDni";
            tBDni.Size = new Size(148, 23);
            tBDni.TabIndex = 6;
            // 
            // Frm_Admin_Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.Fondopg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(553, 213);
            Controls.Add(tBDni);
            Controls.Add(tBFullName);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Frm_Admin_Student";
            Text = "Crear Estudiante";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tBDni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox tBFullName;
        private NumericUpDown tBDni;
    }
}