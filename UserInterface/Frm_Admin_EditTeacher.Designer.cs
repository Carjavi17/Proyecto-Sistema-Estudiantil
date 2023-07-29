namespace UserInterface
{
    partial class Frm_Admin_EditTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Admin_EditTeacher));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label10 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            tBFullName = new TextBox();
            textBox1 = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo_removebg_preview;
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(488, 64);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 35;
            label2.Text = "-------";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(488, 38);
            label1.Name = "label1";
            label1.Size = new Size(202, 21);
            label1.TabIndex = 34;
            label1.Text = "Especialidad del Profesor";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(302, 64);
            label10.Name = "label10";
            label10.Size = new Size(52, 21);
            label10.TabIndex = 33;
            label10.Text = "-------";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(302, 38);
            label8.Name = "label8";
            label8.Size = new Size(169, 21);
            label8.TabIndex = 32;
            label8.Text = "Nombre del Profesor";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(124, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 23);
            comboBox1.TabIndex = 31;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(124, 38);
            label5.Name = "label5";
            label5.Size = new Size(136, 21);
            label5.TabIndex = 30;
            label5.Text = "DNI del Profesor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(424, 146);
            label3.Name = "label3";
            label3.Size = new Size(160, 21);
            label3.TabIndex = 38;
            label3.Text = "Nueva Especialidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(191, 146);
            label4.Name = "label4";
            label4.Size = new Size(128, 21);
            label4.TabIndex = 37;
            label4.Text = "Nuevo Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(124, 146);
            label6.Name = "label6";
            label6.Size = new Size(0, 21);
            label6.TabIndex = 36;
            // 
            // tBFullName
            // 
            tBFullName.Location = new Point(191, 170);
            tBFullName.Name = "tBFullName";
            tBFullName.Size = new Size(148, 23);
            tBFullName.TabIndex = 40;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(424, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 23);
            textBox1.TabIndex = 41;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(336, 227);
            button3.Name = "button3";
            button3.Size = new Size(92, 34);
            button3.TabIndex = 42;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Frm_Admin_EditTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondopg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(768, 268);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(tBFullName);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Name = "Frm_Admin_EditTeacher";
            Text = "Editar Profesor";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label10;
        private Label label8;
        private ComboBox comboBox1;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox tBFullName;
        private TextBox textBox1;
        private Button button3;
    }
}