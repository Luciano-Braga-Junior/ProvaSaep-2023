namespace IArea
{
    partial class Area3
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
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            modelo = new DataGridViewTextBoxColumn();
            preco = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(263, 8);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 36);
            textBox1.TabIndex = 0;
            textBox1.Text = "AREA 3";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { modelo, preco });
            dataGridView1.Location = new Point(47, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(245, 53);
            dataGridView1.TabIndex = 1;
            // 
            // modelo
            // 
            modelo.Frozen = true;
            modelo.HeaderText = "Modelo";
            modelo.Name = "modelo";
            modelo.ReadOnly = true;
            // 
            // preco
            // 
            preco.Frozen = true;
            preco.HeaderText = "Preço";
            preco.Name = "preco";
            preco.ReadOnly = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridView2.Location = new Point(47, 132);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(245, 53);
            dataGridView2.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.Frozen = true;
            dataGridViewTextBoxColumn1.HeaderText = "Modelo";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.Frozen = true;
            dataGridViewTextBoxColumn2.HeaderText = "Preço";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView3.Location = new Point(47, 200);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(245, 53);
            dataGridView3.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.Frozen = true;
            dataGridViewTextBoxColumn3.HeaderText = "Modelo";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.Frozen = true;
            dataGridViewTextBoxColumn4.HeaderText = "Preço";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(362, 69);
            button1.Name = "button1";
            button1.Size = new Size(122, 42);
            button1.TabIndex = 4;
            button1.Text = "Vender";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(362, 139);
            button2.Name = "button2";
            button2.Size = new Size(122, 42);
            button2.TabIndex = 5;
            button2.Text = "Vender";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(362, 210);
            button3.Name = "button3";
            button3.Size = new Size(122, 42);
            button3.TabIndex = 6;
            button3.Text = "Vender";
            button3.UseVisualStyleBackColor = true;
            // 
            // DetalhesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 265);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Name = "DetalhesForm";
            Text = "DetalhesForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn modelo;
        private DataGridViewTextBoxColumn preco;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}