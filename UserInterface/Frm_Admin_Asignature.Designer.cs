namespace UserInterface
{
    partial class Frm_Admin_Asignature
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
            pictureBox1 = new PictureBox();
            labelCodeAsig = new Label();
            labelNameAsig = new Label();
            numBoxCode = new NumericUpDown();
            txtBoxNameAsig = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBoxCode).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo_removebg_preview;
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelCodeAsig
            // 
            labelCodeAsig.AutoSize = true;
            labelCodeAsig.BackColor = Color.Transparent;
            labelCodeAsig.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCodeAsig.Location = new Point(106, 26);
            labelCodeAsig.Name = "labelCodeAsig";
            labelCodeAsig.Size = new Size(0, 21);
            labelCodeAsig.TabIndex = 2;
            // 
            // labelNameAsig
            // 
            labelNameAsig.AutoSize = true;
            labelNameAsig.BackColor = Color.Transparent;
            labelNameAsig.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelNameAsig.Location = new Point(300, 26);
            labelNameAsig.Name = "labelNameAsig";
            labelNameAsig.Size = new Size(183, 21);
            labelNameAsig.TabIndex = 3;
            labelNameAsig.Text = "Nombre de Asignatura";
            // 
            // numBoxCode
            // 
            numBoxCode.Location = new Point(106, 50);
            numBoxCode.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numBoxCode.Name = "numBoxCode";
            numBoxCode.Size = new Size(136, 23);
            numBoxCode.TabIndex = 4;
            // 
            // txtBoxNameAsig
            // 
            txtBoxNameAsig.Location = new Point(306, 50);
            txtBoxNameAsig.Name = "txtBoxNameAsig";
            txtBoxNameAsig.Size = new Size(143, 23);
            txtBoxNameAsig.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.BackgroundImage = Properties.Resources.Fondo_Boton;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(266, 94);
            button1.Name = "button1";
            button1.Size = new Size(92, 34);
            button1.TabIndex = 6;
            button1.Text = "Cargar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(106, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(136, 23);
            comboBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(106, 81);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 9;
            label1.Text = "Profesor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(102, 26);
            label2.Name = "label2";
            label2.Size = new Size(175, 21);
            label2.TabIndex = 10;
            label2.Text = "Codigo de Asignatura";
            // 
            // Frm_Admin_Asignature
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.Fondopg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(601, 207);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(txtBoxNameAsig);
            Controls.Add(numBoxCode);
            Controls.Add(labelNameAsig);
            Controls.Add(labelCodeAsig);
            Controls.Add(pictureBox1);
            Name = "Frm_Admin_Asignature";
            Text = "Crear Asignatura";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBoxCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelCodeAsig;
        private Label labelNameAsig;
        private NumericUpDown numBoxCode;
        private TextBox txtBoxNameAsig;
        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
    }
}