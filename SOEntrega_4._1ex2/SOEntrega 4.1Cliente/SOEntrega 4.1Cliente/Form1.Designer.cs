
namespace SOEntrega_4._1Cliente
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
            this.textBoxIntroduceT = new System.Windows.Forms.TextBox();
            this.labelResultadoT = new System.Windows.Forms.Label();
            this.radioButtonCtoF = new System.Windows.Forms.RadioButton();
            this.radioButtonFtoC = new System.Windows.Forms.RadioButton();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxIntroduceT
            // 
            this.textBoxIntroduceT.Location = new System.Drawing.Point(56, 58);
            this.textBoxIntroduceT.Name = "textBoxIntroduceT";
            this.textBoxIntroduceT.Size = new System.Drawing.Size(152, 23);
            this.textBoxIntroduceT.TabIndex = 1;
            this.textBoxIntroduceT.Text = "Introduce la temperatura";
            // 
            // labelResultadoT
            // 
            this.labelResultadoT.AutoSize = true;
            this.labelResultadoT.Location = new System.Drawing.Point(56, 266);
            this.labelResultadoT.Name = "labelResultadoT";
            this.labelResultadoT.Size = new System.Drawing.Size(132, 15);
            this.labelResultadoT.TabIndex = 2;
            this.labelResultadoT.Text = "Introduce valor primero";
            // 
            // radioButtonCtoF
            // 
            this.radioButtonCtoF.AutoSize = true;
            this.radioButtonCtoF.Location = new System.Drawing.Point(62, 104);
            this.radioButtonCtoF.Name = "radioButtonCtoF";
            this.radioButtonCtoF.Size = new System.Drawing.Size(135, 19);
            this.radioButtonCtoF.TabIndex = 3;
            this.radioButtonCtoF.TabStop = true;
            this.radioButtonCtoF.Text = "Celsius to Fahrenheit";
            this.radioButtonCtoF.UseVisualStyleBackColor = true;
            // 
            // radioButtonFtoC
            // 
            this.radioButtonFtoC.AutoSize = true;
            this.radioButtonFtoC.Location = new System.Drawing.Point(62, 149);
            this.radioButtonFtoC.Name = "radioButtonFtoC";
            this.radioButtonFtoC.Size = new System.Drawing.Size(135, 19);
            this.radioButtonFtoC.TabIndex = 4;
            this.radioButtonFtoC.TabStop = true;
            this.radioButtonFtoC.Text = "Fahrenheit to Celsius";
            this.radioButtonFtoC.UseVisualStyleBackColor = true;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(87, 207);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 5;
            this.buttonCalcular.Text = "CALCULAR";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.radioButtonFtoC);
            this.Controls.Add(this.radioButtonCtoF);
            this.Controls.Add(this.labelResultadoT);
            this.Controls.Add(this.textBoxIntroduceT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIntroduceT;
        private System.Windows.Forms.Label labelResultadoT;
        private System.Windows.Forms.RadioButton radioButtonCtoF;
        private System.Windows.Forms.RadioButton radioButtonFtoC;
        private System.Windows.Forms.Button buttonCalcular;
    }
}

