namespace App10._10WinFormsApp1
{
    partial class CriarProdutoForm2
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
            textBoxNome = new TextBox();
            textBoxFabricante = new TextBox();
            inputPrecoCompra = new NumericUpDown();
            inputPrecoVenda = new NumericUpDown();
            button1Ok = new Button();
            button2Cancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)inputPrecoCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputPrecoVenda).BeginInit();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(134, 18);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(130, 23);
            textBoxNome.TabIndex = 0;
            textBoxNome.TextChanged += textBox1_TextChanged;
            // 
            // textBoxFabricante
            // 
            textBoxFabricante.Location = new Point(130, 60);
            textBoxFabricante.Name = "textBoxFabricante";
            textBoxFabricante.Size = new Size(134, 23);
            textBoxFabricante.TabIndex = 1;
            // 
            // inputPrecoCompra
            // 
            inputPrecoCompra.DecimalPlaces = 2;
            inputPrecoCompra.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            inputPrecoCompra.Location = new Point(128, 105);
            inputPrecoCompra.Name = "inputPrecoCompra";
            inputPrecoCompra.Size = new Size(136, 23);
            inputPrecoCompra.TabIndex = 2;
            inputPrecoCompra.TextAlign = HorizontalAlignment.Right;
            inputPrecoCompra.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // inputPrecoVenda
            // 
            inputPrecoVenda.DecimalPlaces = 2;
            inputPrecoVenda.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            inputPrecoVenda.Location = new Point(128, 150);
            inputPrecoVenda.Name = "inputPrecoVenda";
            inputPrecoVenda.Size = new Size(136, 23);
            inputPrecoVenda.TabIndex = 3;
            inputPrecoVenda.TextAlign = HorizontalAlignment.Right;
            // 
            // button1Ok
            // 
            button1Ok.Location = new Point(22, 210);
            button1Ok.Name = "button1Ok";
            button1Ok.Size = new Size(75, 23);
            button1Ok.TabIndex = 4;
            button1Ok.Text = "Ok";
            button1Ok.UseVisualStyleBackColor = true;
            // 
            // button2Cancel
            // 
            button2Cancel.Location = new Point(173, 210);
            button2Cancel.Name = "button2Cancel";
            button2Cancel.Size = new Size(75, 23);
            button2Cancel.TabIndex = 5;
            button2Cancel.Text = "Cancel";
            button2Cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 6;
            label1.Text = "Nome do produto:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 60);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 7;
            label2.Text = "Fabricante: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 107);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 8;
            label3.Text = "Preço da compra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 152);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 9;
            label4.Text = "Preço de venda:";
            // 
            // CriarProdutoForm2
            // 
            AcceptButton = button1Ok;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button2Cancel;
            ClientSize = new Size(284, 262);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2Cancel);
            Controls.Add(button1Ok);
            Controls.Add(inputPrecoVenda);
            Controls.Add(inputPrecoCompra);
            Controls.Add(textBoxFabricante);
            Controls.Add(textBoxNome);
            Name = "CriarProdutoForm2";
            Text = "CriarProdutoForm2";
            ((System.ComponentModel.ISupportInitialize)inputPrecoCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputPrecoVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNome;
        private TextBox textBoxFabricante;
        private NumericUpDown inputPrecoCompra;
        private NumericUpDown inputPrecoVenda;
        private Button button1Ok;
        private Button button2Cancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}