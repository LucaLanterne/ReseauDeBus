namespace ReseauDeBus.Frontend
{
    partial class SimulationForm
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
            LabelNomReseau = new Label();
            labelTimer = new Label();
            labelTitreFinSimulation = new Label();
            label1 = new Label();
            panel1 = new Panel();
            checkedListBoxBus = new CheckedListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LabelNomReseau
            // 
            LabelNomReseau.AutoSize = true;
            LabelNomReseau.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelNomReseau.Location = new Point(12, 23);
            LabelNomReseau.Name = "LabelNomReseau";
            LabelNomReseau.RightToLeft = RightToLeft.Yes;
            LabelNomReseau.Size = new Size(194, 35);
            LabelNomReseau.TabIndex = 4;
            LabelNomReseau.Text = "Nom réseau";
            LabelNomReseau.Click += titrePageConfig_Click;
            // 
            // labelTimer
            // 
            labelTimer.BackColor = Color.PaleGreen;
            labelTimer.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTimer.Location = new Point(573, 15);
            labelTimer.Name = "labelTimer";
            labelTimer.RightToLeft = RightToLeft.No;
            labelTimer.Size = new Size(215, 51);
            labelTimer.TabIndex = 5;
            labelTimer.Text = "00 : 00";
            labelTimer.TextAlign = ContentAlignment.MiddleCenter;
            labelTimer.Click += label1_Click;
            // 
            // labelTitreFinSimulation
            // 
            labelTitreFinSimulation.AutoSize = true;
            labelTitreFinSimulation.Font = new Font("Calibri Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitreFinSimulation.Location = new Point(211, 30);
            labelTitreFinSimulation.Name = "labelTitreFinSimulation";
            labelTitreFinSimulation.RightToLeft = RightToLeft.Yes;
            labelTitreFinSimulation.Size = new Size(177, 24);
            labelTitreFinSimulation.TabIndex = 6;
            labelTitreFinSimulation.Text = "Fin de la simulation à";
            labelTitreFinSimulation.Click += label1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(385, 30);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(66, 24);
            label1.TabIndex = 7;
            label1.Text = "23 : 00";
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(checkedListBoxBus);
            panel1.Location = new Point(12, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 368);
            panel1.TabIndex = 8;
            // 
            // checkedListBoxBus
            // 
            checkedListBoxBus.BackColor = Color.FromArgb(224, 224, 224);
            checkedListBoxBus.BorderStyle = BorderStyle.None;
            checkedListBoxBus.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBoxBus.FormattingEnabled = true;
            checkedListBoxBus.Location = new Point(0, 0);
            checkedListBoxBus.Name = "checkedListBoxBus";
            checkedListBoxBus.Size = new Size(328, 108);
            checkedListBoxBus.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(3, 114);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(103, 114);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(203, 114);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(315, 184);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 13;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // SimulationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(labelTitreFinSimulation);
            Controls.Add(labelTimer);
            Controls.Add(LabelNomReseau);
            Name = "SimulationForm";
            Text = "SimulationForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LabelNomReseau;
        private Label labelTimer;
        private Label labelTitreFinSimulation;
        private Label label1;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private CheckedListBox checkedListBoxBus;
        private Button button4;
    }
}