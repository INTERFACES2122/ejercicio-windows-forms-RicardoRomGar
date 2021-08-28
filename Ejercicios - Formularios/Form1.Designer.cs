
namespace Ejercicios___Formularios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_AgregarAlumno = new System.Windows.Forms.Label();
            this.label_Buscar = new System.Windows.Forms.Label();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label_ApellidoPat = new System.Windows.Forms.Label();
            this.label_ApellidoMat = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_ApellidoPat = new System.Windows.Forms.TextBox();
            this.textBox_ApellidoMat = new System.Windows.Forms.TextBox();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.textBox_Buscar = new System.Windows.Forms.TextBox();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label_AgregarAlumno
            // 
            this.label_AgregarAlumno.AutoSize = true;
            this.label_AgregarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AgregarAlumno.ForeColor = System.Drawing.Color.Maroon;
            this.label_AgregarAlumno.Location = new System.Drawing.Point(12, 9);
            this.label_AgregarAlumno.Name = "label_AgregarAlumno";
            this.label_AgregarAlumno.Size = new System.Drawing.Size(198, 29);
            this.label_AgregarAlumno.TabIndex = 0;
            this.label_AgregarAlumno.Text = "Agregar alumno";
            // 
            // label_Buscar
            // 
            this.label_Buscar.AutoSize = true;
            this.label_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Buscar.ForeColor = System.Drawing.Color.Maroon;
            this.label_Buscar.Location = new System.Drawing.Point(12, 209);
            this.label_Buscar.Name = "label_Buscar";
            this.label_Buscar.Size = new System.Drawing.Size(93, 29);
            this.label_Buscar.TabIndex = 1;
            this.label_Buscar.Text = "Buscar";
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nombre.Location = new System.Drawing.Point(13, 53);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(87, 20);
            this.label_Nombre.TabIndex = 2;
            this.label_Nombre.Text = "Nombre(s):";
            // 
            // label_ApellidoPat
            // 
            this.label_ApellidoPat.AutoSize = true;
            this.label_ApellidoPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ApellidoPat.Location = new System.Drawing.Point(14, 126);
            this.label_ApellidoPat.Name = "label_ApellidoPat";
            this.label_ApellidoPat.Size = new System.Drawing.Size(129, 20);
            this.label_ApellidoPat.TabIndex = 3;
            this.label_ApellidoPat.Text = "Apellido Paterno:";
            // 
            // label_ApellidoMat
            // 
            this.label_ApellidoMat.AutoSize = true;
            this.label_ApellidoMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ApellidoMat.Location = new System.Drawing.Point(247, 126);
            this.label_ApellidoMat.Name = "label_ApellidoMat";
            this.label_ApellidoMat.Size = new System.Drawing.Size(132, 20);
            this.label_ApellidoMat.TabIndex = 4;
            this.label_ApellidoMat.Text = "Apellido Materno:";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nombre.Location = new System.Drawing.Point(18, 76);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(213, 29);
            this.textBox_Nombre.TabIndex = 5;
            this.textBox_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Nombre_KeyPress);
            // 
            // textBox_ApellidoPat
            // 
            this.textBox_ApellidoPat.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_ApellidoPat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ApellidoPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ApellidoPat.Location = new System.Drawing.Point(18, 149);
            this.textBox_ApellidoPat.Name = "textBox_ApellidoPat";
            this.textBox_ApellidoPat.Size = new System.Drawing.Size(213, 29);
            this.textBox_ApellidoPat.TabIndex = 6;
            this.textBox_ApellidoPat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ApellidoPat_KeyPress);
            // 
            // textBox_ApellidoMat
            // 
            this.textBox_ApellidoMat.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_ApellidoMat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ApellidoMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ApellidoMat.Location = new System.Drawing.Point(251, 149);
            this.textBox_ApellidoMat.Name = "textBox_ApellidoMat";
            this.textBox_ApellidoMat.Size = new System.Drawing.Size(213, 29);
            this.textBox_ApellidoMat.TabIndex = 7;
            this.textBox_ApellidoMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ApellidoMat_KeyPress);
            // 
            // button_Guardar
            // 
            this.button_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Guardar.Location = new System.Drawing.Point(251, 76);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(100, 32);
            this.button_Guardar.TabIndex = 8;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Limpiar.Location = new System.Drawing.Point(364, 76);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(100, 32);
            this.button_Limpiar.TabIndex = 9;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // textBox_Buscar
            // 
            this.textBox_Buscar.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_Buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Buscar.Location = new System.Drawing.Point(18, 241);
            this.textBox_Buscar.Name = "textBox_Buscar";
            this.textBox_Buscar.Size = new System.Drawing.Size(446, 29);
            this.textBox_Buscar.TabIndex = 10;
            this.textBox_Buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Buscar_KeyPress);
            // 
            // DataView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DataView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DataView.BackgroundColor = System.Drawing.Color.MistyRose;
            this.DataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Names,
            this.LastName1,
            this.LastName2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataView.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataView.EnableHeadersVisualStyles = false;
            this.DataView.GridColor = System.Drawing.Color.Black;
            this.DataView.Location = new System.Drawing.Point(17, 299);
            this.DataView.Name = "DataView";
            this.DataView.ReadOnly = true;
            this.DataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataView.RowHeadersWidth = 40;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DataView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataView.Size = new System.Drawing.Size(447, 327);
            this.DataView.TabIndex = 11;
            // 
            // Names
            // 
            this.Names.HeaderText = "Nombre(s)";
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            // 
            // LastName1
            // 
            this.LastName1.HeaderText = "Apellido Paterno";
            this.LastName1.Name = "LastName1";
            this.LastName1.ReadOnly = true;
            // 
            // LastName2
            // 
            this.LastName2.HeaderText = "Apellido Materno";
            this.LastName2.Name = "LastName2";
            this.LastName2.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(483, 638);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.textBox_Buscar);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.textBox_ApellidoMat);
            this.Controls.Add(this.textBox_ApellidoPat);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.label_ApellidoMat);
            this.Controls.Add(this.label_ApellidoPat);
            this.Controls.Add(this.label_Nombre);
            this.Controls.Add(this.label_Buscar);
            this.Controls.Add(this.label_AgregarAlumno);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_AgregarAlumno;
        private System.Windows.Forms.Label label_Buscar;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.Label label_ApellidoPat;
        private System.Windows.Forms.Label label_ApellidoMat;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_ApellidoPat;
        private System.Windows.Forms.TextBox textBox_ApellidoMat;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.TextBox textBox_Buscar;
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName2;
    }
}

