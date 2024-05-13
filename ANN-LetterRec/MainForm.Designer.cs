namespace ANN_LetterRec
{
    partial class MainForm
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
            trainButton = new Button();
            button2 = new Button();
            ClearButton = new Button();
            textBoxA = new TextBox();
            label = new Label();
            label1 = new Label();
            textBoxB = new TextBox();
            label2 = new Label();
            textBoxC = new TextBox();
            label3 = new Label();
            textBoxD = new TextBox();
            label4 = new Label();
            textBoxE = new TextBox();
            label5 = new Label();
            textBoxPrediction = new TextBox();
            panel5 = new Panel();
            loadButton = new Button();
            saveButton = new Button();
            label6 = new Label();
            ErrorEpsilontextBox = new TextBox();
            panel1 = new Panel();
            button32 = new Button();
            button33 = new Button();
            button34 = new Button();
            button35 = new Button();
            button36 = new Button();
            button27 = new Button();
            button28 = new Button();
            button29 = new Button();
            button30 = new Button();
            button31 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            button25 = new Button();
            button26 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            ExitButton = new Button();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // trainButton
            // 
            trainButton.BackColor = Color.FromArgb(43, 45, 62);
            trainButton.FlatStyle = FlatStyle.Popup;
            trainButton.Font = new Font("MV Boli", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            trainButton.ForeColor = SystemColors.Control;
            trainButton.Location = new Point(100, 380);
            trainButton.Name = "trainButton";
            trainButton.Size = new Size(84, 40);
            trainButton.TabIndex = 0;
            trainButton.Text = "Train";
            trainButton.UseVisualStyleBackColor = false;
            trainButton.Click += trainButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(43, 45, 62);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("MV Boli", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(188, 380);
            button2.Name = "button2";
            button2.Size = new Size(84, 40);
            button2.TabIndex = 1;
            button2.Text = "Test";
            button2.UseVisualStyleBackColor = false;
            button2.Click += testButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.FromArgb(43, 45, 62);
            ClearButton.FlatStyle = FlatStyle.Popup;
            ClearButton.Font = new Font("MV Boli", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ClearButton.ForeColor = SystemColors.Control;
            ClearButton.Location = new Point(12, 380);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(84, 40);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // textBoxA
            // 
            textBoxA.BackColor = Color.FromArgb(52, 63, 86);
            textBoxA.BorderStyle = BorderStyle.None;
            textBoxA.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxA.ForeColor = SystemColors.Control;
            textBoxA.Location = new Point(83, 31);
            textBoxA.Name = "textBoxA";
            textBoxA.ReadOnly = true;
            textBoxA.Size = new Size(234, 25);
            textBoxA.TabIndex = 3;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("MV Boli", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label.ForeColor = SystemColors.Control;
            label.Location = new Point(31, 31);
            label.Name = "label";
            label.Size = new Size(31, 23);
            label.TabIndex = 4;
            label.Text = "A:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(32, 91);
            label1.Name = "label1";
            label1.Size = new Size(30, 23);
            label1.TabIndex = 6;
            label1.Text = "B:";
            // 
            // textBoxB
            // 
            textBoxB.BackColor = Color.FromArgb(52, 63, 86);
            textBoxB.BorderStyle = BorderStyle.None;
            textBoxB.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxB.ForeColor = SystemColors.Control;
            textBoxB.Location = new Point(83, 91);
            textBoxB.Name = "textBoxB";
            textBoxB.ReadOnly = true;
            textBoxB.Size = new Size(234, 25);
            textBoxB.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(31, 151);
            label2.Name = "label2";
            label2.Size = new Size(30, 23);
            label2.TabIndex = 8;
            label2.Text = "C:";
            // 
            // textBoxC
            // 
            textBoxC.BackColor = Color.FromArgb(52, 63, 86);
            textBoxC.BorderStyle = BorderStyle.None;
            textBoxC.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxC.ForeColor = SystemColors.Control;
            textBoxC.Location = new Point(83, 151);
            textBoxC.Name = "textBoxC";
            textBoxC.ReadOnly = true;
            textBoxC.Size = new Size(234, 25);
            textBoxC.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(30, 211);
            label3.Name = "label3";
            label3.Size = new Size(32, 23);
            label3.TabIndex = 10;
            label3.Text = "D:";
            // 
            // textBoxD
            // 
            textBoxD.BackColor = Color.FromArgb(52, 63, 86);
            textBoxD.BorderStyle = BorderStyle.None;
            textBoxD.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxD.ForeColor = SystemColors.Control;
            textBoxD.Location = new Point(83, 211);
            textBoxD.Name = "textBoxD";
            textBoxD.ReadOnly = true;
            textBoxD.Size = new Size(234, 25);
            textBoxD.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MV Boli", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(32, 271);
            label4.Name = "label4";
            label4.Size = new Size(30, 23);
            label4.TabIndex = 12;
            label4.Text = "E:";
            // 
            // textBoxE
            // 
            textBoxE.BackColor = Color.FromArgb(52, 63, 86);
            textBoxE.BorderStyle = BorderStyle.None;
            textBoxE.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxE.ForeColor = SystemColors.Control;
            textBoxE.Location = new Point(83, 271);
            textBoxE.Name = "textBoxE";
            textBoxE.ReadOnly = true;
            textBoxE.Size = new Size(234, 25);
            textBoxE.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MV Boli", 15.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(66, 321);
            label5.Name = "label5";
            label5.Size = new Size(162, 34);
            label5.TabIndex = 14;
            label5.Text = "Prediction:";
            // 
            // textBoxPrediction
            // 
            textBoxPrediction.BackColor = Color.FromArgb(43, 45, 62);
            textBoxPrediction.BorderStyle = BorderStyle.None;
            textBoxPrediction.Font = new Font("MV Boli", 15F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPrediction.ForeColor = SystemColors.Control;
            textBoxPrediction.Location = new Point(234, 321);
            textBoxPrediction.Name = "textBoxPrediction";
            textBoxPrediction.ReadOnly = true;
            textBoxPrediction.Size = new Size(45, 41);
            textBoxPrediction.TabIndex = 13;
            textBoxPrediction.TextAlign = HorizontalAlignment.Center;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(43, 45, 62);
            panel5.Controls.Add(ExitButton);
            panel5.Controls.Add(label);
            panel5.Controls.Add(textBoxA);
            panel5.Controls.Add(loadButton);
            panel5.Controls.Add(saveButton);
            panel5.Controls.Add(textBoxB);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(textBoxE);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(textBoxC);
            panel5.Controls.Add(textBoxPrediction);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(textBoxD);
            panel5.ForeColor = SystemColors.Control;
            panel5.Location = new Point(294, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(360, 446);
            panel5.TabIndex = 23;
            // 
            // loadButton
            // 
            loadButton.BackColor = Color.FromArgb(43, 45, 62);
            loadButton.FlatStyle = FlatStyle.Flat;
            loadButton.Font = new Font("MV Boli", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            loadButton.ForeColor = SystemColors.Control;
            loadButton.Location = new Point(0, 375);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(180, 70);
            loadButton.TabIndex = 27;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += loadButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(43, 45, 62);
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("MV Boli", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.ForeColor = SystemColors.Control;
            saveButton.Location = new Point(177, 375);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(180, 70);
            saveButton.TabIndex = 28;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MV Boli", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(12, 431);
            label6.Name = "label6";
            label6.Size = new Size(123, 23);
            label6.TabIndex = 25;
            label6.Text = "Error Rate:";
            // 
            // ErrorEpsilontextBox
            // 
            ErrorEpsilontextBox.BackColor = Color.FromArgb(43, 45, 62);
            ErrorEpsilontextBox.BorderStyle = BorderStyle.FixedSingle;
            ErrorEpsilontextBox.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ErrorEpsilontextBox.ForeColor = SystemColors.Control;
            ErrorEpsilontextBox.Location = new Point(147, 426);
            ErrorEpsilontextBox.Name = "ErrorEpsilontextBox";
            ErrorEpsilontextBox.Size = new Size(125, 32);
            ErrorEpsilontextBox.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.Controls.Add(button32);
            panel1.Controls.Add(button33);
            panel1.Controls.Add(button34);
            panel1.Controls.Add(button35);
            panel1.Controls.Add(button36);
            panel1.Controls.Add(button27);
            panel1.Controls.Add(button28);
            panel1.Controls.Add(button29);
            panel1.Controls.Add(button30);
            panel1.Controls.Add(button31);
            panel1.Controls.Add(button22);
            panel1.Controls.Add(button23);
            panel1.Controls.Add(button24);
            panel1.Controls.Add(button25);
            panel1.Controls.Add(button26);
            panel1.Controls.Add(button17);
            panel1.Controls.Add(button18);
            panel1.Controls.Add(button19);
            panel1.Controls.Add(button20);
            panel1.Controls.Add(button21);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button13);
            panel1.Controls.Add(button14);
            panel1.Controls.Add(button15);
            panel1.Controls.Add(button16);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 360);
            panel1.TabIndex = 30;
            // 
            // button32
            // 
            button32.BackColor = Color.FromArgb(52, 63, 86);
            button32.FlatStyle = FlatStyle.Popup;
            button32.ForeColor = SystemColors.ControlLightLight;
            button32.Location = new Point(210, 310);
            button32.Name = "button32";
            button32.Size = new Size(40, 40);
            button32.TabIndex = 34;
            button32.UseVisualStyleBackColor = false;
            button32.Click += Button_Click;
            // 
            // button33
            // 
            button33.BackColor = Color.FromArgb(52, 63, 86);
            button33.FlatStyle = FlatStyle.Popup;
            button33.ForeColor = SystemColors.ControlLightLight;
            button33.Location = new Point(160, 310);
            button33.Name = "button33";
            button33.Size = new Size(40, 40);
            button33.TabIndex = 33;
            button33.UseVisualStyleBackColor = false;
            button33.Click += Button_Click;
            // 
            // button34
            // 
            button34.BackColor = Color.FromArgb(52, 63, 86);
            button34.FlatStyle = FlatStyle.Popup;
            button34.ForeColor = SystemColors.ControlLightLight;
            button34.Location = new Point(110, 310);
            button34.Name = "button34";
            button34.Size = new Size(40, 40);
            button34.TabIndex = 32;
            button34.UseVisualStyleBackColor = false;
            button34.Click += Button_Click;
            // 
            // button35
            // 
            button35.BackColor = Color.FromArgb(52, 63, 86);
            button35.FlatStyle = FlatStyle.Popup;
            button35.ForeColor = SystemColors.ControlLightLight;
            button35.Location = new Point(60, 310);
            button35.Name = "button35";
            button35.Size = new Size(40, 40);
            button35.TabIndex = 31;
            button35.UseVisualStyleBackColor = false;
            button35.Click += Button_Click;
            // 
            // button36
            // 
            button36.BackColor = Color.FromArgb(52, 63, 86);
            button36.FlatStyle = FlatStyle.Popup;
            button36.ForeColor = SystemColors.ControlLightLight;
            button36.Location = new Point(10, 310);
            button36.Name = "button36";
            button36.Size = new Size(40, 40);
            button36.TabIndex = 30;
            button36.UseVisualStyleBackColor = false;
            button36.Click += Button_Click;
            // 
            // button27
            // 
            button27.BackColor = Color.FromArgb(52, 63, 86);
            button27.FlatStyle = FlatStyle.Popup;
            button27.ForeColor = SystemColors.ControlLightLight;
            button27.Location = new Point(210, 260);
            button27.Name = "button27";
            button27.Size = new Size(40, 40);
            button27.TabIndex = 29;
            button27.UseVisualStyleBackColor = false;
            button27.Click += Button_Click;
            // 
            // button28
            // 
            button28.BackColor = Color.FromArgb(52, 63, 86);
            button28.FlatStyle = FlatStyle.Popup;
            button28.ForeColor = SystemColors.ControlLightLight;
            button28.Location = new Point(160, 260);
            button28.Name = "button28";
            button28.Size = new Size(40, 40);
            button28.TabIndex = 28;
            button28.UseVisualStyleBackColor = false;
            button28.Click += Button_Click;
            // 
            // button29
            // 
            button29.BackColor = Color.FromArgb(52, 63, 86);
            button29.FlatStyle = FlatStyle.Popup;
            button29.ForeColor = SystemColors.ControlLightLight;
            button29.Location = new Point(110, 260);
            button29.Name = "button29";
            button29.Size = new Size(40, 40);
            button29.TabIndex = 27;
            button29.UseVisualStyleBackColor = false;
            button29.Click += Button_Click;
            // 
            // button30
            // 
            button30.BackColor = Color.FromArgb(52, 63, 86);
            button30.FlatStyle = FlatStyle.Popup;
            button30.ForeColor = SystemColors.ControlLightLight;
            button30.Location = new Point(60, 260);
            button30.Name = "button30";
            button30.Size = new Size(40, 40);
            button30.TabIndex = 26;
            button30.UseVisualStyleBackColor = false;
            button30.Click += Button_Click;
            // 
            // button31
            // 
            button31.BackColor = Color.FromArgb(52, 63, 86);
            button31.FlatStyle = FlatStyle.Popup;
            button31.ForeColor = SystemColors.ControlLightLight;
            button31.Location = new Point(10, 260);
            button31.Name = "button31";
            button31.Size = new Size(40, 40);
            button31.TabIndex = 25;
            button31.UseVisualStyleBackColor = false;
            button31.Click += Button_Click;
            // 
            // button22
            // 
            button22.BackColor = Color.FromArgb(52, 63, 86);
            button22.FlatStyle = FlatStyle.Popup;
            button22.ForeColor = SystemColors.ControlLightLight;
            button22.Location = new Point(210, 210);
            button22.Name = "button22";
            button22.Size = new Size(40, 40);
            button22.TabIndex = 24;
            button22.UseVisualStyleBackColor = false;
            button22.Click += Button_Click;
            // 
            // button23
            // 
            button23.BackColor = Color.FromArgb(52, 63, 86);
            button23.FlatStyle = FlatStyle.Popup;
            button23.ForeColor = SystemColors.ControlLightLight;
            button23.Location = new Point(160, 210);
            button23.Name = "button23";
            button23.Size = new Size(40, 40);
            button23.TabIndex = 23;
            button23.UseVisualStyleBackColor = false;
            button23.Click += Button_Click;
            // 
            // button24
            // 
            button24.BackColor = Color.FromArgb(52, 63, 86);
            button24.FlatStyle = FlatStyle.Popup;
            button24.ForeColor = SystemColors.ControlLightLight;
            button24.Location = new Point(110, 210);
            button24.Name = "button24";
            button24.Size = new Size(40, 40);
            button24.TabIndex = 22;
            button24.UseVisualStyleBackColor = false;
            button24.Click += Button_Click;
            // 
            // button25
            // 
            button25.BackColor = Color.FromArgb(52, 63, 86);
            button25.FlatStyle = FlatStyle.Popup;
            button25.ForeColor = SystemColors.ControlLightLight;
            button25.Location = new Point(60, 210);
            button25.Name = "button25";
            button25.Size = new Size(40, 40);
            button25.TabIndex = 21;
            button25.UseVisualStyleBackColor = false;
            button25.Click += Button_Click;
            // 
            // button26
            // 
            button26.BackColor = Color.FromArgb(52, 63, 86);
            button26.FlatStyle = FlatStyle.Popup;
            button26.ForeColor = SystemColors.ControlLightLight;
            button26.Location = new Point(10, 210);
            button26.Name = "button26";
            button26.Size = new Size(40, 40);
            button26.TabIndex = 20;
            button26.UseVisualStyleBackColor = false;
            button26.Click += Button_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.FromArgb(52, 63, 86);
            button17.FlatStyle = FlatStyle.Popup;
            button17.ForeColor = SystemColors.ControlLightLight;
            button17.Location = new Point(210, 160);
            button17.Name = "button17";
            button17.Size = new Size(40, 40);
            button17.TabIndex = 19;
            button17.UseVisualStyleBackColor = false;
            button17.Click += Button_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.FromArgb(52, 63, 86);
            button18.FlatStyle = FlatStyle.Popup;
            button18.ForeColor = SystemColors.ControlLightLight;
            button18.Location = new Point(160, 160);
            button18.Name = "button18";
            button18.Size = new Size(40, 40);
            button18.TabIndex = 18;
            button18.UseVisualStyleBackColor = false;
            button18.Click += Button_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.FromArgb(52, 63, 86);
            button19.FlatStyle = FlatStyle.Popup;
            button19.ForeColor = SystemColors.ControlLightLight;
            button19.Location = new Point(110, 160);
            button19.Name = "button19";
            button19.Size = new Size(40, 40);
            button19.TabIndex = 17;
            button19.UseVisualStyleBackColor = false;
            button19.Click += Button_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.FromArgb(52, 63, 86);
            button20.FlatStyle = FlatStyle.Popup;
            button20.ForeColor = SystemColors.ControlLightLight;
            button20.Location = new Point(60, 160);
            button20.Name = "button20";
            button20.Size = new Size(40, 40);
            button20.TabIndex = 16;
            button20.UseVisualStyleBackColor = false;
            button20.Click += Button_Click;
            // 
            // button21
            // 
            button21.BackColor = Color.FromArgb(52, 63, 86);
            button21.FlatStyle = FlatStyle.Popup;
            button21.ForeColor = SystemColors.ControlLightLight;
            button21.Location = new Point(10, 160);
            button21.Name = "button21";
            button21.Size = new Size(40, 40);
            button21.TabIndex = 15;
            button21.UseVisualStyleBackColor = false;
            button21.Click += Button_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(52, 63, 86);
            button12.FlatStyle = FlatStyle.Popup;
            button12.ForeColor = SystemColors.ControlLightLight;
            button12.Location = new Point(210, 110);
            button12.Name = "button12";
            button12.Size = new Size(40, 40);
            button12.TabIndex = 14;
            button12.UseVisualStyleBackColor = false;
            button12.Click += Button_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(52, 63, 86);
            button13.FlatStyle = FlatStyle.Popup;
            button13.ForeColor = SystemColors.ControlLightLight;
            button13.Location = new Point(160, 110);
            button13.Name = "button13";
            button13.Size = new Size(40, 40);
            button13.TabIndex = 13;
            button13.UseVisualStyleBackColor = false;
            button13.Click += Button_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(52, 63, 86);
            button14.FlatStyle = FlatStyle.Popup;
            button14.ForeColor = SystemColors.ControlLightLight;
            button14.Location = new Point(110, 110);
            button14.Name = "button14";
            button14.Size = new Size(40, 40);
            button14.TabIndex = 12;
            button14.UseVisualStyleBackColor = false;
            button14.Click += Button_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(52, 63, 86);
            button15.FlatStyle = FlatStyle.Popup;
            button15.ForeColor = SystemColors.ControlLightLight;
            button15.Location = new Point(60, 110);
            button15.Name = "button15";
            button15.Size = new Size(40, 40);
            button15.TabIndex = 11;
            button15.UseVisualStyleBackColor = false;
            button15.Click += Button_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.FromArgb(52, 63, 86);
            button16.FlatStyle = FlatStyle.Popup;
            button16.ForeColor = SystemColors.ControlLightLight;
            button16.Location = new Point(10, 110);
            button16.Name = "button16";
            button16.Size = new Size(40, 40);
            button16.TabIndex = 10;
            button16.UseVisualStyleBackColor = false;
            button16.Click += Button_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(52, 63, 86);
            button7.FlatStyle = FlatStyle.Popup;
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(210, 60);
            button7.Name = "button7";
            button7.Size = new Size(40, 40);
            button7.TabIndex = 9;
            button7.UseVisualStyleBackColor = false;
            button7.Click += Button_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(52, 63, 86);
            button8.FlatStyle = FlatStyle.Popup;
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(160, 60);
            button8.Name = "button8";
            button8.Size = new Size(40, 40);
            button8.TabIndex = 8;
            button8.UseVisualStyleBackColor = false;
            button8.Click += Button_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(52, 63, 86);
            button9.FlatStyle = FlatStyle.Popup;
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Location = new Point(110, 60);
            button9.Name = "button9";
            button9.Size = new Size(40, 40);
            button9.TabIndex = 7;
            button9.UseVisualStyleBackColor = false;
            button9.Click += Button_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(52, 63, 86);
            button10.FlatStyle = FlatStyle.Popup;
            button10.ForeColor = SystemColors.ControlLightLight;
            button10.Location = new Point(60, 60);
            button10.Name = "button10";
            button10.Size = new Size(40, 40);
            button10.TabIndex = 6;
            button10.UseVisualStyleBackColor = false;
            button10.Click += Button_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(52, 63, 86);
            button11.FlatStyle = FlatStyle.Popup;
            button11.ForeColor = SystemColors.ControlLightLight;
            button11.Location = new Point(10, 60);
            button11.Name = "button11";
            button11.Size = new Size(40, 40);
            button11.TabIndex = 5;
            button11.UseVisualStyleBackColor = false;
            button11.Click += Button_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(52, 63, 86);
            button6.FlatStyle = FlatStyle.Popup;
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(210, 10);
            button6.Name = "button6";
            button6.Size = new Size(40, 40);
            button6.TabIndex = 4;
            button6.UseVisualStyleBackColor = false;
            button6.Click += Button_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(52, 63, 86);
            button5.FlatStyle = FlatStyle.Popup;
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(160, 10);
            button5.Name = "button5";
            button5.Size = new Size(40, 40);
            button5.TabIndex = 3;
            button5.UseVisualStyleBackColor = false;
            button5.Click += Button_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(52, 63, 86);
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(110, 10);
            button4.Name = "button4";
            button4.Size = new Size(40, 40);
            button4.TabIndex = 2;
            button4.UseVisualStyleBackColor = false;
            button4.Click += Button_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(52, 63, 86);
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(60, 10);
            button3.Name = "button3";
            button3.Size = new Size(40, 40);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = false;
            button3.Click += Button_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(52, 63, 86);
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(11, 10);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.FromArgb(43, 45, 62);
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("MV Boli", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ExitButton.ForeColor = SystemColors.Control;
            ExitButton.Location = new Point(323, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(37, 34);
            ExitButton.TabIndex = 29;
            ExitButton.Text = "X";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 63, 86);
            ClientSize = new Size(660, 468);
            Controls.Add(panel1);
            Controls.Add(ErrorEpsilontextBox);
            Controls.Add(label6);
            Controls.Add(panel5);
            Controls.Add(ClearButton);
            Controls.Add(button2);
            Controls.Add(trainButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button trainButton;
        private Button button2;
        private Button ClearButton;
        private TextBox textBoxA;
        private Label label;
        private Label label1;
        private TextBox textBoxB;
        private Label label2;
        private TextBox textBoxC;
        private Label label3;
        private TextBox textBoxD;
        private Label label4;
        private TextBox textBoxE;
        private Label label5;
        private TextBox textBoxPrediction;
        private Panel panel5;
        private Label label6;
        private Button saveButton;
        private Button loadButton;
        private TextBox ErrorEpsilontextBox;
        private Panel panel1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button1;
        private Button button32;
        private Button button33;
        private Button button34;
        private Button button35;
        private Button button36;
        private Button button27;
        private Button button28;
        private Button button29;
        private Button button30;
        private Button button31;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button26;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button ExitButton;
    }
}