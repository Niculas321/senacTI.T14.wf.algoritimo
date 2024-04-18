namespace WinFormsApp1
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            Buscar = new Button();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            Depositar = new Button();
            textBox2 = new TextBox();
            Sacar = new Button();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(Buscar);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(24, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(529, 196);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busca de Conta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 93);
            label2.Name = "label2";
            label2.Size = new Size(164, 27);
            label2.TabIndex = 2;
            label2.Text = "Escolha a conta";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(170, 85);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(181, 35);
            comboBox1.TabIndex = 2;
            // 
            // Buscar
            // 
            Buscar.Location = new Point(372, 86);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(122, 34);
            Buscar.TabIndex = 1;
            Buscar.Text = "Buscar";
            Buscar.UseVisualStyleBackColor = true;
            Buscar.Click += Buscar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(Depositar);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(Sacar);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(24, 234);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(529, 284);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Conta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 182);
            label5.Name = "label5";
            label5.Size = new Size(62, 27);
            label5.TabIndex = 2;
            label5.Text = "Valor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 142);
            label4.Name = "label4";
            label4.Size = new Size(65, 27);
            label4.TabIndex = 2;
            label4.Text = "Saldo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 102);
            label3.Name = "label3";
            label3.Size = new Size(90, 27);
            label3.TabIndex = 2;
            label3.Text = "Numero";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 62);
            label1.Name = "label1";
            label1.Size = new Size(75, 27);
            label1.TabIndex = 2;
            label1.Text = "Titular";
            label1.Click += label1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(137, 54);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(302, 35);
            textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(137, 174);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(302, 35);
            textBox3.TabIndex = 4;
            // 
            // Depositar
            // 
            Depositar.Location = new Point(316, 227);
            Depositar.Name = "Depositar";
            Depositar.Size = new Size(142, 38);
            Depositar.TabIndex = 2;
            Depositar.Text = "Depositar";
            Depositar.UseVisualStyleBackColor = true;
            Depositar.Click += Depositar_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(137, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(302, 35);
            textBox2.TabIndex = 3;
            // 
            // Sacar
            // 
            Sacar.Location = new Point(137, 227);
            Sacar.Name = "Sacar";
            Sacar.Size = new Size(101, 38);
            Sacar.TabIndex = 2;
            Sacar.Text = "Sacar";
            Sacar.UseVisualStyleBackColor = true;
            Sacar.Click += Sacar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 35);
            textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(577, 556);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Menu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button Buscar;
        private GroupBox groupBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button Depositar;
        private TextBox textBox2;
        private Button Sacar;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label5;
        private Label label4;
    }
}
