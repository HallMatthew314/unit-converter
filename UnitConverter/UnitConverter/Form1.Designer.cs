namespace UnitConverter
{
    partial class Form1
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
            this.button_Convert = new System.Windows.Forms.Button();
            this.button_DistanceMode = new System.Windows.Forms.Button();
            this.button_WeightMode = new System.Windows.Forms.Button();
            this.button_TemperatureMode = new System.Windows.Forms.Button();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.textBox_Output = new System.Windows.Forms.TextBox();
            this.comboBox_BaseUnit = new System.Windows.Forms.ComboBox();
            this.comboBox_TargetUnit = new System.Windows.Forms.ComboBox();
            this.label_Mode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Convert
            // 
            this.button_Convert.Location = new System.Drawing.Point(248, 103);
            this.button_Convert.Name = "button_Convert";
            this.button_Convert.Size = new System.Drawing.Size(121, 50);
            this.button_Convert.TabIndex = 0;
            this.button_Convert.Text = "Convert";
            this.button_Convert.UseVisualStyleBackColor = true;
            // 
            // button_DistanceMode
            // 
            this.button_DistanceMode.Location = new System.Drawing.Point(84, 272);
            this.button_DistanceMode.Name = "button_DistanceMode";
            this.button_DistanceMode.Size = new System.Drawing.Size(121, 50);
            this.button_DistanceMode.TabIndex = 1;
            this.button_DistanceMode.Text = "Distance Mode";
            this.button_DistanceMode.UseVisualStyleBackColor = true;
            this.button_DistanceMode.Click += new System.EventHandler(this.button_DistanceMode_Click);
            // 
            // button_WeightMode
            // 
            this.button_WeightMode.Location = new System.Drawing.Point(248, 272);
            this.button_WeightMode.Name = "button_WeightMode";
            this.button_WeightMode.Size = new System.Drawing.Size(121, 50);
            this.button_WeightMode.TabIndex = 2;
            this.button_WeightMode.Text = "Weight Mode";
            this.button_WeightMode.UseVisualStyleBackColor = true;
            this.button_WeightMode.Click += new System.EventHandler(this.button_WeightMode_Click);
            // 
            // button_TemperatureMode
            // 
            this.button_TemperatureMode.Location = new System.Drawing.Point(412, 272);
            this.button_TemperatureMode.Name = "button_TemperatureMode";
            this.button_TemperatureMode.Size = new System.Drawing.Size(121, 50);
            this.button_TemperatureMode.TabIndex = 3;
            this.button_TemperatureMode.Text = "Temperature Mode";
            this.button_TemperatureMode.UseVisualStyleBackColor = true;
            this.button_TemperatureMode.Click += new System.EventHandler(this.button_TemperatureMode_Click);
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(84, 106);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(121, 20);
            this.textBox_Input.TabIndex = 4;
            this.textBox_Input.Text = "Enter Value Here";
            // 
            // textBox_Output
            // 
            this.textBox_Output.Location = new System.Drawing.Point(412, 106);
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.ReadOnly = true;
            this.textBox_Output.Size = new System.Drawing.Size(121, 20);
            this.textBox_Output.TabIndex = 5;
            // 
            // comboBox_BaseUnit
            // 
            this.comboBox_BaseUnit.FormattingEnabled = true;
            this.comboBox_BaseUnit.Location = new System.Drawing.Point(84, 132);
            this.comboBox_BaseUnit.Name = "comboBox_BaseUnit";
            this.comboBox_BaseUnit.Size = new System.Drawing.Size(121, 21);
            this.comboBox_BaseUnit.TabIndex = 6;
            // 
            // comboBox_TargetUnit
            // 
            this.comboBox_TargetUnit.FormattingEnabled = true;
            this.comboBox_TargetUnit.Location = new System.Drawing.Point(412, 132);
            this.comboBox_TargetUnit.Name = "comboBox_TargetUnit";
            this.comboBox_TargetUnit.Size = new System.Drawing.Size(121, 21);
            this.comboBox_TargetUnit.TabIndex = 7;
            // 
            // label_Mode
            // 
            this.label_Mode.AutoSize = true;
            this.label_Mode.Location = new System.Drawing.Point(29, 406);
            this.label_Mode.Name = "label_Mode";
            this.label_Mode.Size = new System.Drawing.Size(62, 13);
            this.label_Mode.TabIndex = 8;
            this.label_Mode.Text = "label_Mode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.label_Mode);
            this.Controls.Add(this.comboBox_TargetUnit);
            this.Controls.Add(this.comboBox_BaseUnit);
            this.Controls.Add(this.textBox_Output);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.button_TemperatureMode);
            this.Controls.Add(this.button_WeightMode);
            this.Controls.Add(this.button_DistanceMode);
            this.Controls.Add(this.button_Convert);
            this.Name = "Form1";
            this.Text = "Unit Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Convert;
        private System.Windows.Forms.Button button_DistanceMode;
        private System.Windows.Forms.Button button_WeightMode;
        private System.Windows.Forms.Button button_TemperatureMode;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.TextBox textBox_Output;
        private System.Windows.Forms.ComboBox comboBox_BaseUnit;
        private System.Windows.Forms.ComboBox comboBox_TargetUnit;
        private System.Windows.Forms.Label label_Mode;
    }
}

