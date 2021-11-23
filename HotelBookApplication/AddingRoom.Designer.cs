
namespace HotelBookApplication
{
    partial class AddingRoom
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
            this.roomnumbertextbox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Balcony = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numberofbedsText = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.smokingTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberOfRoomsTextBox = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.balconycomb = new System.Windows.Forms.ComboBox();
            this.downforrepaircombo = new System.Windows.Forms.ComboBox();
            this.BasicRadio = new System.Windows.Forms.RadioButton();
            this.NumberOfRoomsSuite = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomnumbertextbox
            // 
            this.roomnumbertextbox.Location = new System.Drawing.Point(230, 34);
            this.roomnumbertextbox.Name = "roomnumbertextbox";
            this.roomnumbertextbox.Size = new System.Drawing.Size(138, 20);
            this.roomnumbertextbox.TabIndex = 0;
            this.roomnumbertextbox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room Number";
            // 
            // Balcony
            // 
            this.Balcony.AutoSize = true;
            this.Balcony.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balcony.Location = new System.Drawing.Point(17, 73);
            this.Balcony.Name = "Balcony";
            this.Balcony.Size = new System.Drawing.Size(65, 20);
            this.Balcony.TabIndex = 3;
            this.Balcony.Text = "Balcony";
            this.Balcony.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Down For Repair";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number of Beds";
            // 
            // numberofbedsText
            // 
            this.numberofbedsText.Location = new System.Drawing.Point(230, 151);
            this.numberofbedsText.Name = "numberofbedsText";
            this.numberofbedsText.Size = new System.Drawing.Size(138, 20);
            this.numberofbedsText.TabIndex = 6;
            this.numberofbedsText.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox4_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Smoking";
            // 
            // smokingTextBox
            // 
            this.smokingTextBox.Location = new System.Drawing.Point(9, 38);
            this.smokingTextBox.Name = "smokingTextBox";
            this.smokingTextBox.Size = new System.Drawing.Size(88, 20);
            this.smokingTextBox.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.smokingTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 116);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Room";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.NumberOfRoomsTextBox);
            this.groupBox2.Location = new System.Drawing.Point(198, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 116);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Suite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number of Rooms";
            // 
            // NumberOfRoomsTextBox
            // 
            this.NumberOfRoomsTextBox.Enabled = false;
            this.NumberOfRoomsTextBox.Location = new System.Drawing.Point(10, 38);
            this.NumberOfRoomsTextBox.Name = "NumberOfRoomsTextBox";
            this.NumberOfRoomsTextBox.Size = new System.Drawing.Size(88, 20);
            this.NumberOfRoomsTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // balconycomb
            // 
            this.balconycomb.DisplayMember = "true";
            this.balconycomb.FormattingEnabled = true;
            this.balconycomb.Items.AddRange(new object[] {
            "True",
            "False"});
            this.balconycomb.Location = new System.Drawing.Point(230, 75);
            this.balconycomb.Name = "balconycomb";
            this.balconycomb.Size = new System.Drawing.Size(121, 21);
            this.balconycomb.TabIndex = 14;
            this.balconycomb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // downforrepaircombo
            // 
            this.downforrepaircombo.FormattingEnabled = true;
            this.downforrepaircombo.Items.AddRange(new object[] {
            "True",
            "False"});
            this.downforrepaircombo.Location = new System.Drawing.Point(230, 114);
            this.downforrepaircombo.Name = "downforrepaircombo";
            this.downforrepaircombo.Size = new System.Drawing.Size(121, 21);
            this.downforrepaircombo.TabIndex = 15;
            // 
            // BasicRadio
            // 
            this.BasicRadio.AutoSize = true;
            this.BasicRadio.Location = new System.Drawing.Point(12, 202);
            this.BasicRadio.Name = "BasicRadio";
            this.BasicRadio.Size = new System.Drawing.Size(51, 17);
            this.BasicRadio.TabIndex = 16;
            this.BasicRadio.TabStop = true;
            this.BasicRadio.Text = "Basic";
            this.BasicRadio.UseVisualStyleBackColor = true;
            this.BasicRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // NumberOfRoomsSuite
            // 
            this.NumberOfRoomsSuite.AutoSize = true;
            this.NumberOfRoomsSuite.Location = new System.Drawing.Point(69, 202);
            this.NumberOfRoomsSuite.Name = "NumberOfRoomsSuite";
            this.NumberOfRoomsSuite.Size = new System.Drawing.Size(49, 17);
            this.NumberOfRoomsSuite.TabIndex = 17;
            this.NumberOfRoomsSuite.TabStop = true;
            this.NumberOfRoomsSuite.Text = "Suite";
            this.NumberOfRoomsSuite.UseVisualStyleBackColor = true;
            this.NumberOfRoomsSuite.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // AddingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 396);
            this.Controls.Add(this.NumberOfRoomsSuite);
            this.Controls.Add(this.BasicRadio);
            this.Controls.Add(this.downforrepaircombo);
            this.Controls.Add(this.balconycomb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numberofbedsText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Balcony);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomnumbertextbox);
            this.Name = "AddingRoom";
            this.Text = "AddingRoom";
            this.Load += new System.EventHandler(this.AddingRoom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox roomnumbertextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Balcony;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox numberofbedsText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox smokingTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox NumberOfRoomsTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox balconycomb;
        private System.Windows.Forms.ComboBox downforrepaircombo;
        private System.Windows.Forms.RadioButton BasicRadio;
        private System.Windows.Forms.RadioButton NumberOfRoomsSuite;
    }
}