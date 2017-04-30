namespace WindowsFormsApplication1
{
    partial class PESO
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
        	this.components = new System.ComponentModel.Container();
        	this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
        	this.Inicio = new System.Windows.Forms.Button();
        	this.Parar = new System.Windows.Forms.Button();
        	this.label1 = new System.Windows.Forms.Label();
        	this.Saida_Tela = new System.Windows.Forms.Label();
        	this.transferir = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// serialPort1
        	// 
        	this.serialPort1.BaudRate = 4800;
        	this.serialPort1.PortName = "COM14";
        	this.serialPort1.RtsEnable = true;
        	this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
        	// 
        	// Inicio
        	// 
        	this.Inicio.Location = new System.Drawing.Point(41, 12);
        	this.Inicio.Name = "Inicio";
        	this.Inicio.Size = new System.Drawing.Size(75, 23);
        	this.Inicio.TabIndex = 0;
        	this.Inicio.Text = "Inicio";
        	this.Inicio.UseVisualStyleBackColor = true;
        	this.Inicio.Click += new System.EventHandler(this.Inicio_Click);
        	// 
        	// Parar
        	// 
        	this.Parar.Location = new System.Drawing.Point(155, 12);
        	this.Parar.Name = "Parar";
        	this.Parar.Size = new System.Drawing.Size(75, 23);
        	this.Parar.TabIndex = 1;
        	this.Parar.Text = "Parar";
        	this.Parar.UseVisualStyleBackColor = true;
        	this.Parar.Click += new System.EventHandler(this.Parar_Click);
        	// 
        	// label1
        	// 
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(22, 55);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(86, 40);
        	this.label1.TabIndex = 3;
        	this.label1.Text = "Peso";
        	// 
        	// Saida_Tela
        	// 
        	this.Saida_Tela.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.Saida_Tela.Location = new System.Drawing.Point(117, 54);
        	this.Saida_Tela.Name = "Saida_Tela";
        	this.Saida_Tela.Size = new System.Drawing.Size(160, 40);
        	this.Saida_Tela.TabIndex = 4;
        	this.Saida_Tela.Text = "Sem Leitura";
        	this.Saida_Tela.Click += new System.EventHandler(this.Saida_TelaClick);
        	// 
        	// transferir
        	// 
        	this.transferir.Location = new System.Drawing.Point(44, 106);
        	this.transferir.Name = "transferir";
        	this.transferir.Size = new System.Drawing.Size(186, 37);
        	this.transferir.TabIndex = 5;
        	this.transferir.Text = "Transferir";
        	this.transferir.UseVisualStyleBackColor = true;
        	this.transferir.Click += new System.EventHandler(this.Button1Click);
        	// 
        	// PESO
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(276, 172);
        	this.Controls.Add(this.transferir);
        	this.Controls.Add(this.Saida_Tela);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.Parar);
        	this.Controls.Add(this.Inicio);
        	this.KeyPreview = true;
        	this.Name = "PESO";
        	this.Text = "PESO";
        	this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fechar_Tela);
        	this.Load += new System.EventHandler(this.PESOLoad);
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.Button transferir;
        private System.Windows.Forms.Label Saida_Tela;
        private System.Windows.Forms.Label label1;

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button Inicio;
        private System.Windows.Forms.Button Parar;
    }
}

