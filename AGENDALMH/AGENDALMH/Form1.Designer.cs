namespace AGENDALMH
{
    partial class Form1
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
            lblagenda = new Label();
            lblnombre = new Label();
            lblapellido = new Label();
            lblapee = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            NOMBRE = new DataGridViewTextBoxColumn();
            APELLIDO = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblagenda
            // 
            lblagenda.AutoSize = true;
            lblagenda.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblagenda.Location = new Point(323, 46);
            lblagenda.Name = "lblagenda";
            lblagenda.Size = new Size(167, 31);
            lblagenda.TabIndex = 0;
            lblagenda.Text = "AGENDA LMH";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(54, 129);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(73, 20);
            lblnombre.TabIndex = 0;
            lblnombre.Text = "NOMBRE:";
            lblnombre.Click += label2_Click;
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.Location = new Point(66, 176);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new Size(0, 20);
            lblapellido.TabIndex = 0;
            // 
            // lblapee
            // 
            lblapee.AutoSize = true;
            lblapee.Location = new Point(54, 176);
            lblapee.Name = "lblapee";
            lblapee.Size = new Size(78, 20);
            lblapee.TabIndex = 0;
            lblapee.Text = "APELLIDO:";
            lblapee.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(578, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(133, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(578, 27);
            textBox2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NOMBRE, APELLIDO });
            dataGridView1.Location = new Point(38, 232);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(734, 188);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "NOMBRE";
            NOMBRE.MinimumWidth = 9;
            NOMBRE.Name = "NOMBRE";
            NOMBRE.Width = 125;
            // 
            // APELLIDO
            // 
            APELLIDO.HeaderText = "APELLIDO";
            APELLIDO.MinimumWidth = 6;
            APELLIDO.Name = "APELLIDO";
            APELLIDO.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblapellido);
            Controls.Add(lblapee);
            Controls.Add(lblnombre);
            Controls.Add(lblagenda);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblagenda;
        private Label lblnombre;
        private Label lblapellido;
        private Label lblapee;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn APELLIDO;
    }
}
