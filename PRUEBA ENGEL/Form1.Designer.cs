
namespace PRUEBA_ENGEL
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.text_correo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labe3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_identificacion = new System.Windows.Forms.TextBox();
            this.text_apellidos = new System.Windows.Forms.TextBox();
            this.text_nombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.REGISTRO = new System.Windows.Forms.Label();
            this.text_buscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1196, 209);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.text_correo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labe3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.text_identificacion);
            this.groupBox1.Controls.Add(this.text_apellidos);
            this.groupBox1.Controls.Add(this.text_nombres);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1196, 194);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS";
            // 
            // text_correo
            // 
            this.text_correo.Location = new System.Drawing.Point(701, 137);
            this.text_correo.Name = "text_correo";
            this.text_correo.Size = new System.Drawing.Size(303, 22);
            this.text_correo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "APELLIDOS";
            // 
            // labe3
            // 
            this.labe3.AutoSize = true;
            this.labe3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe3.Location = new System.Drawing.Point(698, 44);
            this.labe3.Name = "labe3";
            this.labe3.Size = new System.Drawing.Size(138, 18);
            this.labe3.TabIndex = 4;
            this.labe3.Text = "IDENTIFICACION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(698, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "CORREO";
            // 
            // text_identificacion
            // 
            this.text_identificacion.Location = new System.Drawing.Point(701, 65);
            this.text_identificacion.Name = "text_identificacion";
            this.text_identificacion.Size = new System.Drawing.Size(303, 22);
            this.text_identificacion.TabIndex = 2;
            // 
            // text_apellidos
            // 
            this.text_apellidos.Location = new System.Drawing.Point(35, 137);
            this.text_apellidos.Name = "text_apellidos";
            this.text_apellidos.Size = new System.Drawing.Size(303, 22);
            this.text_apellidos.TabIndex = 1;
            this.text_apellidos.TextChanged += new System.EventHandler(this.text_apellidos_TextChanged);
            // 
            // text_nombres
            // 
            this.text_nombres.Location = new System.Drawing.Point(35, 64);
            this.text_nombres.Name = "text_nombres";
            this.text_nombres.Size = new System.Drawing.Size(303, 22);
            this.text_nombres.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOMBRES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // REGISTRO
            // 
            this.REGISTRO.AutoSize = true;
            this.REGISTRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGISTRO.Location = new System.Drawing.Point(12, 35);
            this.REGISTRO.Name = "REGISTRO";
            this.REGISTRO.Size = new System.Drawing.Size(197, 38);
            this.REGISTRO.TabIndex = 6;
            this.REGISTRO.Text = "REGISTRO";
            // 
            // text_buscar
            // 
            this.text_buscar.Location = new System.Drawing.Point(713, 80);
            this.text_buscar.Name = "text_buscar";
            this.text_buscar.Size = new System.Drawing.Size(303, 22);
            this.text_buscar.TabIndex = 7;
            this.text_buscar.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 72);
            this.button1.TabIndex = 8;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(353, 599);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 72);
            this.button2.TabIndex = 9;
            this.button2.Text = "MODIFICAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(678, 599);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 72);
            this.button3.TabIndex = 10;
            this.button3.Text = "ELIMINAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(994, 599);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 72);
            this.button4.TabIndex = 11;
            this.button4.Text = "NUEVO";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1035, 63);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 57);
            this.button5.TabIndex = 12;
            this.button5.Text = "BUSCAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 683);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_buscar);
            this.Controls.Add(this.REGISTRO);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_correo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labe3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_identificacion;
        private System.Windows.Forms.TextBox text_apellidos;
        private System.Windows.Forms.TextBox text_nombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label REGISTRO;
        private System.Windows.Forms.TextBox text_buscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

