namespace UserInterface
{
    partial class Frm_Admin_DeleteAsignature
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Admin_DeleteAsignature));
            pictureBox1 = new PictureBox();
            labelCodeAsig = new Label();
            labelNameAsig = new Label();
            comboBox1 = new ComboBox();
            label10 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo_removebg_preview;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelCodeAsig
            // 
            labelCodeAsig.AutoSize = true;
            labelCodeAsig.BackColor = Color.Transparent;
            labelCodeAsig.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCodeAsig.Location = new Point(119, 35);
            labelCodeAsig.Name = "labelCodeAsig";
            labelCodeAsig.Size = new Size(175, 21);
            labelCodeAsig.TabIndex = 3;
            labelCodeAsig.Text = "Codigo de Asignatura";
            // 
            // labelNameAsig
            // 
            labelNameAsig.AutoSize = true;
            labelNameAsig.BackColor = Color.Transparent;
            labelNameAsig.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelNameAsig.Location = new Point(308, 35);
            labelNameAsig.Name = "labelNameAsig";
            labelNameAsig.Size = new Size(183, 21);
            labelNameAsig.TabIndex = 4;
            labelNameAsig.Text = "Nombre de Asignatura";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(119, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(94, 23);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(308, 73);
            label10.Name = "label10";
            label10.Size = new Size(52, 21);
            label10.TabIndex = 25;
            label10.Text = "-------";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(260, 135);
            button2.Name = "button2";
            button2.Size = new Size(92, 34);
            button2.TabIndex = 27;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Frm_Admin_DeleteAsignature
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondopg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(580, 190);
            Controls.Add(button2);
            Controls.Add(label10);
            Controls.Add(comboBox1);
            Controls.Add(labelNameAsig);
            Controls.Add(labelCodeAsig);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_Admin_DeleteAsignature";
            Text = "Borrar Asignatura";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelCodeAsig;
        private Label labelNameAsig;
        private ComboBox comboBox1;
        private Label label10;
        private Button button2;
    }
}