﻿
namespace Decoder {
    partial class DecoderApp {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecoderApp));
            this.label1 = new System.Windows.Forms.Label();
            this.Decodificador = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.copiedDecodeAlert = new System.Windows.Forms.Label();
            this.decodeValue = new System.Windows.Forms.Label();
            this.letterToDecode = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textToDecode = new System.Windows.Forms.TextBox();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.copiedCodeAlert = new System.Windows.Forms.Label();
            this.codedValue = new System.Windows.Forms.Label();
            this.buttonCode = new System.Windows.Forms.Button();
            this.letterToCode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textToCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Decodificador.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 23F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Decodificador";
            // 
            // Decodificador
            // 
            this.Decodificador.Controls.Add(this.tabPage1);
            this.Decodificador.Controls.Add(this.tabPage2);
            this.Decodificador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Decodificador.Location = new System.Drawing.Point(12, 12);
            this.Decodificador.Name = "Decodificador";
            this.Decodificador.SelectedIndex = 0;
            this.Decodificador.Size = new System.Drawing.Size(488, 390);
            this.Decodificador.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.copiedDecodeAlert);
            this.tabPage1.Controls.Add(this.decodeValue);
            this.tabPage1.Controls.Add(this.letterToDecode);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textToDecode);
            this.tabPage1.Controls.Add(this.buttonDecode);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(480, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Decodificador";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // copiedDecodeAlert
            // 
            this.copiedDecodeAlert.AutoSize = true;
            this.copiedDecodeAlert.BackColor = System.Drawing.Color.Transparent;
            this.copiedDecodeAlert.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copiedDecodeAlert.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.copiedDecodeAlert.Location = new System.Drawing.Point(33, 188);
            this.copiedDecodeAlert.Name = "copiedDecodeAlert";
            this.copiedDecodeAlert.Size = new System.Drawing.Size(164, 15);
            this.copiedDecodeAlert.TabIndex = 21;
            this.copiedDecodeAlert.Text = "Texto copiado al Portapapeles";
            this.copiedDecodeAlert.Visible = false;
            // 
            // decodeValue
            // 
            this.decodeValue.AutoSize = true;
            this.decodeValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.decodeValue.Font = new System.Drawing.Font("Open Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decodeValue.Location = new System.Drawing.Point(36, 217);
            this.decodeValue.Name = "decodeValue";
            this.decodeValue.Size = new System.Drawing.Size(0, 27);
            this.decodeValue.TabIndex = 20;
            // 
            // letterToDecode
            // 
            this.letterToDecode.Font = new System.Drawing.Font("Open Sans", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterToDecode.FormattingEnabled = true;
            this.letterToDecode.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.letterToDecode.Location = new System.Drawing.Point(340, 98);
            this.letterToDecode.Name = "letterToDecode";
            this.letterToDecode.Size = new System.Drawing.Size(121, 31);
            this.letterToDecode.TabIndex = 18;
            this.letterToDecode.Text = "A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(335, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 27);
            this.label8.TabIndex = 17;
            this.label8.Text = "Letra clave";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 27);
            this.label9.TabIndex = 16;
            this.label9.Text = "Texto";
            // 
            // textToDecode
            // 
            this.textToDecode.Font = new System.Drawing.Font("Open Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textToDecode.Location = new System.Drawing.Point(36, 98);
            this.textToDecode.Name = "textToDecode";
            this.textToDecode.Size = new System.Drawing.Size(290, 35);
            this.textToDecode.TabIndex = 15;
            // 
            // buttonDecode
            // 
            this.buttonDecode.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonDecode.Font = new System.Drawing.Font("Open Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecode.ForeColor = System.Drawing.Color.White;
            this.buttonDecode.Location = new System.Drawing.Point(36, 149);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(126, 36);
            this.buttonDecode.TabIndex = 13;
            this.buttonDecode.Text = "Decodificar";
            this.buttonDecode.UseVisualStyleBackColor = false;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecodeHandleClick);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBox2.Location = new System.Drawing.Point(340, 98);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(335, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Letra clave";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Texto";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(36, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(290, 30);
            this.textBox2.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.copiedCodeAlert);
            this.tabPage2.Controls.Add(this.codedValue);
            this.tabPage2.Controls.Add(this.buttonCode);
            this.tabPage2.Controls.Add(this.letterToCode);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textToCode);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(480, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Codificador";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // copiedCodeAlert
            // 
            this.copiedCodeAlert.AutoSize = true;
            this.copiedCodeAlert.BackColor = System.Drawing.Color.Transparent;
            this.copiedCodeAlert.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copiedCodeAlert.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.copiedCodeAlert.Location = new System.Drawing.Point(33, 187);
            this.copiedCodeAlert.Name = "copiedCodeAlert";
            this.copiedCodeAlert.Size = new System.Drawing.Size(164, 15);
            this.copiedCodeAlert.TabIndex = 22;
            this.copiedCodeAlert.Text = "Texto copiado al Portapapeles";
            this.copiedCodeAlert.Visible = false;
            // 
            // codedValue
            // 
            this.codedValue.AutoSize = true;
            this.codedValue.Font = new System.Drawing.Font("Open Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codedValue.Location = new System.Drawing.Point(36, 216);
            this.codedValue.Name = "codedValue";
            this.codedValue.Size = new System.Drawing.Size(0, 27);
            this.codedValue.TabIndex = 8;
            // 
            // buttonCode
            // 
            this.buttonCode.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonCode.Font = new System.Drawing.Font("Open Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCode.ForeColor = System.Drawing.Color.White;
            this.buttonCode.Location = new System.Drawing.Point(36, 148);
            this.buttonCode.Name = "buttonCode";
            this.buttonCode.Size = new System.Drawing.Size(111, 36);
            this.buttonCode.TabIndex = 7;
            this.buttonCode.Text = "Codificar";
            this.buttonCode.UseVisualStyleBackColor = false;
            this.buttonCode.Click += new System.EventHandler(this.buttonCodeHandleClick);
            // 
            // letterToCode
            // 
            this.letterToCode.Font = new System.Drawing.Font("Open Sans", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterToCode.FormattingEnabled = true;
            this.letterToCode.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.letterToCode.Location = new System.Drawing.Point(340, 97);
            this.letterToCode.Name = "letterToCode";
            this.letterToCode.Size = new System.Drawing.Size(121, 31);
            this.letterToCode.TabIndex = 6;
            this.letterToCode.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Letra clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Texto";
            // 
            // textToCode
            // 
            this.textToCode.Font = new System.Drawing.Font("Open Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textToCode.Location = new System.Drawing.Point(36, 97);
            this.textToCode.Name = "textToCode";
            this.textToCode.Size = new System.Drawing.Size(290, 35);
            this.textToCode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 23.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codificador";
            // 
            // DecoderApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 411);
            this.Controls.Add(this.Decodificador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DecoderApp";
            this.Text = "Decoder v1.5";
            this.Decodificador.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Decodificador;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textToCode;
        private System.Windows.Forms.ComboBox letterToCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCode;
        private System.Windows.Forms.Label codedValue;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label decodeValue;
        private System.Windows.Forms.ComboBox letterToDecode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textToDecode;
        private System.Windows.Forms.Label copiedDecodeAlert;
        private System.Windows.Forms.Label copiedCodeAlert;
    }
}

