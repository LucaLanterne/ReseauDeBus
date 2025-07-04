namespace ReseauDeBus
{
    partial class ConfigurationForm
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
            panelConfigSimulationHG = new Panel();
            titrePageConfig = new Label();
            labelTitreHG = new Label();
            labelChoixSimulationHG = new Label();
            SimulationSelectorHG = new ComboBox();
            labelDebutSimulationHG = new Label();
            labelFinSimulationHG = new Label();
            dateTimePickerDebutHG = new DateTimePicker();
            dateTimePickerFinHG = new DateTimePicker();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            comboBox3 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            comboBox4 = new ComboBox();
            label7 = new Label();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            comboBox5 = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            panel3 = new Panel();
            comboBox6 = new ComboBox();
            label12 = new Label();
            dateTimePicker5 = new DateTimePicker();
            dateTimePicker6 = new DateTimePicker();
            label13 = new Label();
            label14 = new Label();
            comboBox7 = new ComboBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            panelConfigSimulationHG.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelConfigSimulationHG
            // 
            panelConfigSimulationHG.BackColor = Color.White;
            panelConfigSimulationHG.Controls.Add(comboBox1);
            panelConfigSimulationHG.Controls.Add(label1);
            panelConfigSimulationHG.Controls.Add(dateTimePickerFinHG);
            panelConfigSimulationHG.Controls.Add(dateTimePickerDebutHG);
            panelConfigSimulationHG.Controls.Add(labelFinSimulationHG);
            panelConfigSimulationHG.Controls.Add(labelDebutSimulationHG);
            panelConfigSimulationHG.Controls.Add(SimulationSelectorHG);
            panelConfigSimulationHG.Controls.Add(labelChoixSimulationHG);
            panelConfigSimulationHG.Controls.Add(labelTitreHG);
            panelConfigSimulationHG.Location = new Point(12, 88);
            panelConfigSimulationHG.Name = "panelConfigSimulationHG";
            panelConfigSimulationHG.Size = new Size(496, 291);
            panelConfigSimulationHG.TabIndex = 0;
            panelConfigSimulationHG.Paint += panelConfigSimulationHG_Paint;
            // 
            // titrePageConfig
            // 
            titrePageConfig.AutoSize = true;
            titrePageConfig.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titrePageConfig.Location = new Point(12, 26);
            titrePageConfig.Name = "titrePageConfig";
            titrePageConfig.RightToLeft = RightToLeft.Yes;
            titrePageConfig.Size = new Size(400, 35);
            titrePageConfig.TabIndex = 1;
            titrePageConfig.Text = "Configuer vos simulation";
            titrePageConfig.Click += label1_Click;
            // 
            // labelTitreHG
            // 
            labelTitreHG.AutoSize = true;
            labelTitreHG.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitreHG.Location = new Point(9, 10);
            labelTitreHG.Name = "labelTitreHG";
            labelTitreHG.RightToLeft = RightToLeft.No;
            labelTitreHG.Size = new Size(482, 26);
            labelTitreHG.TabIndex = 2;
            labelTitreHG.Text = "Que voulez-vous faire en haut à gauche ?";
            labelTitreHG.Click += label1_Click_1;
            // 
            // labelChoixSimulationHG
            // 
            labelChoixSimulationHG.AutoSize = true;
            labelChoixSimulationHG.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelChoixSimulationHG.ImageAlign = ContentAlignment.MiddleLeft;
            labelChoixSimulationHG.Location = new Point(9, 61);
            labelChoixSimulationHG.Name = "labelChoixSimulationHG";
            labelChoixSimulationHG.RightToLeft = RightToLeft.No;
            labelChoixSimulationHG.Size = new Size(164, 21);
            labelChoixSimulationHG.TabIndex = 3;
            labelChoixSimulationHG.Text = "Choisir une simulation";
            labelChoixSimulationHG.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SimulationSelectorHG
            // 
            SimulationSelectorHG.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SimulationSelectorHG.FormattingEnabled = true;
            SimulationSelectorHG.Location = new Point(9, 85);
            SimulationSelectorHG.Name = "SimulationSelectorHG";
            SimulationSelectorHG.Size = new Size(482, 29);
            SimulationSelectorHG.TabIndex = 4;
            SimulationSelectorHG.Text = "-";
            // 
            // labelDebutSimulationHG
            // 
            labelDebutSimulationHG.AutoSize = true;
            labelDebutSimulationHG.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDebutSimulationHG.ImageAlign = ContentAlignment.MiddleLeft;
            labelDebutSimulationHG.Location = new Point(9, 193);
            labelDebutSimulationHG.Name = "labelDebutSimulationHG";
            labelDebutSimulationHG.RightToLeft = RightToLeft.No;
            labelDebutSimulationHG.Size = new Size(165, 21);
            labelDebutSimulationHG.TabIndex = 5;
            labelDebutSimulationHG.Text = "Début de la simulation";
            labelDebutSimulationHG.TextAlign = ContentAlignment.MiddleLeft;
            labelDebutSimulationHG.Click += label3_Click;
            // 
            // labelFinSimulationHG
            // 
            labelFinSimulationHG.AutoSize = true;
            labelFinSimulationHG.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFinSimulationHG.ImageAlign = ContentAlignment.MiddleLeft;
            labelFinSimulationHG.Location = new Point(9, 240);
            labelFinSimulationHG.Name = "labelFinSimulationHG";
            labelFinSimulationHG.RightToLeft = RightToLeft.No;
            labelFinSimulationHG.Size = new Size(144, 21);
            labelFinSimulationHG.TabIndex = 6;
            labelFinSimulationHG.Text = "Fin de la simulation";
            labelFinSimulationHG.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerDebutHG
            // 
            dateTimePickerDebutHG.Format = DateTimePickerFormat.Time;
            dateTimePickerDebutHG.Location = new Point(180, 193);
            dateTimePickerDebutHG.Name = "dateTimePickerDebutHG";
            dateTimePickerDebutHG.Size = new Size(115, 27);
            dateTimePickerDebutHG.TabIndex = 7;
            dateTimePickerDebutHG.Value = new DateTime(2025, 7, 3, 6, 0, 0, 0);
            // 
            // dateTimePickerFinHG
            // 
            dateTimePickerFinHG.Format = DateTimePickerFormat.Time;
            dateTimePickerFinHG.Location = new Point(180, 240);
            dateTimePickerFinHG.Name = "dateTimePickerFinHG";
            dateTimePickerFinHG.Size = new Size(115, 27);
            dateTimePickerFinHG.TabIndex = 8;
            dateTimePickerFinHG.Value = new DateTime(2025, 7, 3, 23, 0, 0, 0);
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(9, 145);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(482, 29);
            comboBox1.TabIndex = 10;
            comboBox1.Text = "Textuelle";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(9, 121);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(219, 21);
            label1.TabIndex = 9;
            label1.Text = "Choisir le type de visualisation";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(804, 15);
            button1.Name = "button1";
            button1.Size = new Size(218, 56);
            button1.TabIndex = 2;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label17);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(526, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 291);
            panel1.TabIndex = 11;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(9, 145);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(482, 29);
            comboBox2.TabIndex = 10;
            comboBox2.Text = "Textuelle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(9, 121);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(219, 21);
            label2.TabIndex = 9;
            label2.Text = "Choisir le type de visualisation";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(180, 240);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(115, 27);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.Value = new DateTime(2025, 7, 3, 23, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(180, 193);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(115, 27);
            dateTimePicker2.TabIndex = 7;
            dateTimePicker2.Value = new DateTime(2025, 7, 3, 6, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(9, 240);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(144, 21);
            label3.TabIndex = 6;
            label3.Text = "Fin de la simulation";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(9, 193);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(165, 21);
            label4.TabIndex = 5;
            label4.Text = "Début de la simulation";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(9, 85);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(482, 29);
            comboBox3.TabIndex = 4;
            comboBox3.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(9, 61);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(387, 21);
            label5.TabIndex = 3;
            label5.Text = "Ou choisir nouveau pour créer une nouvelle simulation";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 10);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(472, 26);
            label6.TabIndex = 2;
            label6.Text = "Que voulez-vous faire en haut à droite ?";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(comboBox4);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(dateTimePicker3);
            panel2.Controls.Add(dateTimePicker4);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(comboBox5);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Location = new Point(526, 395);
            panel2.Name = "panel2";
            panel2.Size = new Size(496, 291);
            panel2.TabIndex = 13;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(9, 145);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(482, 29);
            comboBox4.TabIndex = 10;
            comboBox4.Text = "Textuelle";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(9, 121);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(219, 21);
            label7.TabIndex = 9;
            label7.Text = "Choisir le type de visualisation";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker3.Location = new Point(180, 240);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(115, 27);
            dateTimePicker3.TabIndex = 8;
            dateTimePicker3.Value = new DateTime(2025, 7, 3, 23, 0, 0, 0);
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Format = DateTimePickerFormat.Time;
            dateTimePicker4.Location = new Point(180, 193);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(115, 27);
            dateTimePicker4.TabIndex = 7;
            dateTimePicker4.Value = new DateTime(2025, 7, 3, 6, 0, 0, 0);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.Location = new Point(9, 240);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(144, 21);
            label8.TabIndex = 6;
            label8.Text = "Fin de la simulation";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ImageAlign = ContentAlignment.MiddleLeft;
            label9.Location = new Point(9, 193);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(165, 21);
            label9.TabIndex = 5;
            label9.Text = "Début de la simulation";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(9, 85);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(482, 29);
            comboBox5.TabIndex = 4;
            comboBox5.Text = "-";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ImageAlign = ContentAlignment.MiddleLeft;
            label10.Location = new Point(9, 61);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.No;
            label10.Size = new Size(164, 21);
            label10.TabIndex = 3;
            label10.Text = "Choisir une simulation";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(9, 10);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.No;
            label11.Size = new Size(455, 26);
            label11.TabIndex = 2;
            label11.Text = "Que voulez-vous faire en bas à droite ?";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(comboBox6);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(dateTimePicker5);
            panel3.Controls.Add(dateTimePicker6);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(comboBox7);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label16);
            panel3.Location = new Point(12, 395);
            panel3.Name = "panel3";
            panel3.Size = new Size(496, 291);
            panel3.TabIndex = 12;
            // 
            // comboBox6
            // 
            comboBox6.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(9, 145);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(482, 29);
            comboBox6.TabIndex = 10;
            comboBox6.Text = "Textuelle";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ImageAlign = ContentAlignment.MiddleLeft;
            label12.Location = new Point(9, 121);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.No;
            label12.Size = new Size(219, 21);
            label12.TabIndex = 9;
            label12.Text = "Choisir le type de visualisation";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.Format = DateTimePickerFormat.Time;
            dateTimePicker5.Location = new Point(180, 240);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new Size(115, 27);
            dateTimePicker5.TabIndex = 8;
            dateTimePicker5.Value = new DateTime(2025, 7, 3, 23, 0, 0, 0);
            // 
            // dateTimePicker6
            // 
            dateTimePicker6.Format = DateTimePickerFormat.Time;
            dateTimePicker6.Location = new Point(180, 193);
            dateTimePicker6.Name = "dateTimePicker6";
            dateTimePicker6.Size = new Size(115, 27);
            dateTimePicker6.TabIndex = 7;
            dateTimePicker6.Value = new DateTime(2025, 7, 3, 6, 0, 0, 0);
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ImageAlign = ContentAlignment.MiddleLeft;
            label13.Location = new Point(9, 240);
            label13.Name = "label13";
            label13.RightToLeft = RightToLeft.No;
            label13.Size = new Size(144, 21);
            label13.TabIndex = 6;
            label13.Text = "Fin de la simulation";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ImageAlign = ContentAlignment.MiddleLeft;
            label14.Location = new Point(9, 193);
            label14.Name = "label14";
            label14.RightToLeft = RightToLeft.No;
            label14.Size = new Size(165, 21);
            label14.TabIndex = 5;
            label14.Text = "Début de la simulation";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBox7
            // 
            comboBox7.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(9, 85);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(482, 29);
            comboBox7.TabIndex = 4;
            comboBox7.Text = "-";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ImageAlign = ContentAlignment.MiddleLeft;
            label15.Location = new Point(9, 61);
            label15.Name = "label15";
            label15.RightToLeft = RightToLeft.No;
            label15.Size = new Size(164, 21);
            label15.TabIndex = 3;
            label15.Text = "Choisir une simulation";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(9, 10);
            label16.Name = "label16";
            label16.RightToLeft = RightToLeft.No;
            label16.Size = new Size(465, 26);
            label16.TabIndex = 2;
            label16.Text = "Que voulez-vous faire en bas à gauche ?";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ImageAlign = ContentAlignment.MiddleLeft;
            label17.Location = new Point(9, 40);
            label17.Name = "label17";
            label17.RightToLeft = RightToLeft.No;
            label17.Size = new Size(242, 21);
            label17.TabIndex = 11;
            label17.Text = "Choisir une simulation déja utilisé";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            label17.Click += label17_Click;
            // 
            // ConfigurationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 703);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(titrePageConfig);
            Controls.Add(panelConfigSimulationHG);
            Name = "ConfigurationForm";
            Text = "ConfigurationForm";
            panelConfigSimulationHG.ResumeLayout(false);
            panelConfigSimulationHG.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelConfigSimulationHG;
        private Label titrePageConfig;
        private Label labelTitreHG;
        private Label labelDebutSimulationHG;
        private ComboBox SimulationSelectorHG;
        private Label labelChoixSimulationHG;
        private Label labelFinSimulationHG;
        private DateTimePicker dateTimePickerDebutHG;
        private DateTimePicker dateTimePickerFinHG;
        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private Panel panel1;
        private ComboBox comboBox2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox3;
        private Label label5;
        private Label label6;
        private Panel panel2;
        private ComboBox comboBox4;
        private Label label7;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private Label label8;
        private Label label9;
        private ComboBox comboBox5;
        private Label label10;
        private Label label11;
        private Panel panel3;
        private ComboBox comboBox6;
        private Label label12;
        private DateTimePicker dateTimePicker5;
        private DateTimePicker dateTimePicker6;
        private Label label13;
        private Label label14;
        private ComboBox comboBox7;
        private Label label15;
        private Label label16;
        private Label label17;
    }
}
