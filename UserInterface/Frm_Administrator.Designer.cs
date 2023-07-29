namespace UserInterface
{
    partial class Frm_Administrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Administrator));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            createAsignatureToolStripMenuItem = new ToolStripMenuItem();
            newAsignatureToolStripMenuItem = new ToolStripMenuItem();
            createTeacherToolStripMenuItem = new ToolStripMenuItem();
            newTeacherToolStripMenuItem = new ToolStripMenuItem();
            borrarProfesorToolStripMenuItem = new ToolStripMenuItem();
            editarProfesorToolStripMenuItem = new ToolStripMenuItem();
            createStudentToolStripMenuItem = new ToolStripMenuItem();
            newStudentToolStripMenuItem = new ToolStripMenuItem();
            borrarEstudianteToolStripMenuItem = new ToolStripMenuItem();
            editarEstudianteToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            pictureBox2 = new PictureBox();
            toolStrip1 = new ToolStrip();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            pictureBox3 = new PictureBox();
            borrarAsignaturaToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(183, 37);
            label1.Name = "label1";
            label1.Size = new Size(248, 32);
            label1.TabIndex = 0;
            label1.Text = "Administrator Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo_removebg_preview;
            pictureBox1.Location = new Point(0, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.InactiveCaption;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { createAsignatureToolStripMenuItem, createTeacherToolStripMenuItem, createStudentToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(656, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // createAsignatureToolStripMenuItem
            // 
            createAsignatureToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newAsignatureToolStripMenuItem, borrarAsignaturaToolStripMenuItem });
            createAsignatureToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            createAsignatureToolStripMenuItem.Name = "createAsignatureToolStripMenuItem";
            createAsignatureToolStripMenuItem.Size = new Size(78, 20);
            createAsignatureToolStripMenuItem.Text = "Asignatura";
            // 
            // newAsignatureToolStripMenuItem
            // 
            newAsignatureToolStripMenuItem.Name = "newAsignatureToolStripMenuItem";
            newAsignatureToolStripMenuItem.Size = new Size(180, 22);
            newAsignatureToolStripMenuItem.Text = "Nueva Asignatura";
            newAsignatureToolStripMenuItem.Click += newAsignatureToolStripMenuItem_Click;
            // 
            // createTeacherToolStripMenuItem
            // 
            createTeacherToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newTeacherToolStripMenuItem, borrarProfesorToolStripMenuItem, editarProfesorToolStripMenuItem });
            createTeacherToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            createTeacherToolStripMenuItem.Name = "createTeacherToolStripMenuItem";
            createTeacherToolStripMenuItem.Size = new Size(67, 20);
            createTeacherToolStripMenuItem.Text = "Profesor";
            // 
            // newTeacherToolStripMenuItem
            // 
            newTeacherToolStripMenuItem.Name = "newTeacherToolStripMenuItem";
            newTeacherToolStripMenuItem.Size = new Size(162, 22);
            newTeacherToolStripMenuItem.Text = "Nuevo Profesor";
            newTeacherToolStripMenuItem.Click += newTeacherToolStripMenuItem_Click;
            // 
            // borrarProfesorToolStripMenuItem
            // 
            borrarProfesorToolStripMenuItem.Name = "borrarProfesorToolStripMenuItem";
            borrarProfesorToolStripMenuItem.Size = new Size(162, 22);
            borrarProfesorToolStripMenuItem.Text = "Borrar Profesor";
            borrarProfesorToolStripMenuItem.Click += borrarProfesorToolStripMenuItem_Click;
            // 
            // editarProfesorToolStripMenuItem
            // 
            editarProfesorToolStripMenuItem.Name = "editarProfesorToolStripMenuItem";
            editarProfesorToolStripMenuItem.Size = new Size(162, 22);
            editarProfesorToolStripMenuItem.Text = "Editar Profesor";
            editarProfesorToolStripMenuItem.Click += editarProfesorToolStripMenuItem_Click;
            // 
            // createStudentToolStripMenuItem
            // 
            createStudentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newStudentToolStripMenuItem, borrarEstudianteToolStripMenuItem, editarEstudianteToolStripMenuItem });
            createStudentToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            createStudentToolStripMenuItem.Name = "createStudentToolStripMenuItem";
            createStudentToolStripMenuItem.Size = new Size(77, 20);
            createStudentToolStripMenuItem.Text = "Estudiante";
            // 
            // newStudentToolStripMenuItem
            // 
            newStudentToolStripMenuItem.Name = "newStudentToolStripMenuItem";
            newStudentToolStripMenuItem.Size = new Size(172, 22);
            newStudentToolStripMenuItem.Text = "Nuevo Estudiante";
            newStudentToolStripMenuItem.Click += newStudentToolStripMenuItem_Click;
            // 
            // borrarEstudianteToolStripMenuItem
            // 
            borrarEstudianteToolStripMenuItem.Name = "borrarEstudianteToolStripMenuItem";
            borrarEstudianteToolStripMenuItem.Size = new Size(172, 22);
            borrarEstudianteToolStripMenuItem.Text = "Borrar Estudiante";
            borrarEstudianteToolStripMenuItem.Click += borrarEstudianteToolStripMenuItem_Click;
            // 
            // editarEstudianteToolStripMenuItem
            // 
            editarEstudianteToolStripMenuItem.Name = "editarEstudianteToolStripMenuItem";
            editarEstudianteToolStripMenuItem.Size = new Size(172, 22);
            editarEstudianteToolStripMenuItem.Text = "Editar Estudiante";
            editarEstudianteToolStripMenuItem.Click += editarEstudianteToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            salirToolStripMenuItem.ForeColor = Color.Red;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(43, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 144);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(256, 256);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.LightGray;
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 430);
            toolStrip1.MaximumSize = new Size(20, 20);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(20, 20);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.AutoSize = false;
            toolStripButton2.BackColor = Color.Transparent;
            toolStripButton2.BackgroundImage = Properties.Resources.snakeicon;
            toolStripButton2.BackgroundImageLayout = ImageLayout.Stretch;
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(40, 40);
            toolStripButton2.Text = "La Culebrita";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.AutoSize = false;
            toolStripButton3.BackColor = Color.Transparent;
            toolStripButton3.BackgroundImage = Properties.Resources.laviejaicon;
            toolStripButton3.BackgroundImageLayout = ImageLayout.Stretch;
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(40, 40);
            toolStripButton3.Text = "La vieja";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Location = new Point(104, 27);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(73, 55);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // borrarAsignaturaToolStripMenuItem
            // 
            borrarAsignaturaToolStripMenuItem.Name = "borrarAsignaturaToolStripMenuItem";
            borrarAsignaturaToolStripMenuItem.Size = new Size(180, 22);
            borrarAsignaturaToolStripMenuItem.Text = "Borrar Asignatura";
            borrarAsignaturaToolStripMenuItem.Click += borrarAsignaturaToolStripMenuItem_Click;
            // 
            // Frm_Administrator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = Properties.Resources.Fondopg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(656, 450);
            Controls.Add(pictureBox3);
            Controls.Add(toolStrip1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Transparent;
            MainMenuStrip = menuStrip1;
            Name = "Frm_Administrator";
            Text = "Panel de Administrador";
            Load += Frm_Administrator_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem createAsignatureToolStripMenuItem;
        private ToolStripMenuItem createTeacherToolStripMenuItem;
        private ToolStripMenuItem createStudentToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem newAsignatureToolStripMenuItem;
        private ToolStripMenuItem newTeacherToolStripMenuItem;
        private ToolStripMenuItem newStudentToolStripMenuItem;
        private PictureBox pictureBox2;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private PictureBox pictureBox3;
        private ToolStripMenuItem borrarEstudianteToolStripMenuItem;
        private ToolStripMenuItem borrarProfesorToolStripMenuItem;
        private ToolStripMenuItem editarEstudianteToolStripMenuItem;
        private ToolStripMenuItem editarProfesorToolStripMenuItem;
        private ToolStripMenuItem borrarAsignaturaToolStripMenuItem;
    }
}