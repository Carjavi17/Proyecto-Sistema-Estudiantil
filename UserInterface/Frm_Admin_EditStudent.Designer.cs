namespace UserInterface
{
    partial class Frm_Admin_EditStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Admin_EditStudent));
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label8 = new Label();
            label10 = new Label();
            comboBox1 = new ComboBox();
            tBFullName = new TextBox();
            label2 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo_removebg_preview;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(145, 64);
            label5.Name = "label5";
            label5.Size = new Size(153, 21);
            label5.TabIndex = 14;
            label5.Text = "DNI del Estudiante";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(357, 66);
            label8.Name = "label8";
            label8.Size = new Size(186, 21);
            label8.TabIndex = 22;
            label8.Text = "Nombre del Estudiante";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(358, 93);
            label10.Name = "label10";
            label10.Size = new Size(52, 21);
            label10.TabIndex = 24;
            label10.Text = "-------";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(145, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 23);
            comboBox1.TabIndex = 25;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tBFullName
            // 
            tBFullName.Location = new Point(145, 203);
            tBFullName.Name = "tBFullName";
            tBFullName.Size = new Size(153, 23);
            tBFullName.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(145, 176);
            label2.Name = "label2";
            label2.Size = new Size(128, 21);
            label2.TabIndex = 29;
            label2.Text = "Nombre Nuevo";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(358, 192);
            button3.Name = "button3";
            button3.Size = new Size(92, 34);
            button3.TabIndex = 30;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Frm_Admin_EditStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondopg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(631, 319);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(tBFullName);
            Controls.Add(comboBox1);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Name = "Frm_Admin_EditStudent";
            Text = "Editar Estudiante";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label5;
        private Label label8;
        private Label label10;
        private ComboBox comboBox1;
        private TextBox tBFullName;
        private Label label2;
        private Button button3;
    }
}