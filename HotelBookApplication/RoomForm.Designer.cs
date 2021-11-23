
namespace HotelBookApplication
{
    partial class RoomForm
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.RemoveRoomBtn = new System.Windows.Forms.Button();
            this.DataRooms = new System.Windows.Forms.DataGridView();
            this.Closebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 80);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(85, 37);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add Room";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // RemoveRoomBtn
            // 
            this.RemoveRoomBtn.Location = new System.Drawing.Point(103, 80);
            this.RemoveRoomBtn.Name = "RemoveRoomBtn";
            this.RemoveRoomBtn.Size = new System.Drawing.Size(85, 37);
            this.RemoveRoomBtn.TabIndex = 1;
            this.RemoveRoomBtn.Text = "Remove Room";
            this.RemoveRoomBtn.UseVisualStyleBackColor = true;
            this.RemoveRoomBtn.Click += new System.EventHandler(this.RemoveRoomBtn_Click);
            // 
            // DataRooms
            // 
            this.DataRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataRooms.Location = new System.Drawing.Point(12, 123);
            this.DataRooms.Name = "DataRooms";
            this.DataRooms.Size = new System.Drawing.Size(776, 315);
            this.DataRooms.TabIndex = 2;
            // 
            // Closebtn
            // 
            this.Closebtn.Location = new System.Drawing.Point(703, 80);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(85, 37);
            this.Closebtn.TabIndex = 3;
            this.Closebtn.Text = "Close";
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rooms Editor";
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.DataRooms);
            this.Controls.Add(this.RemoveRoomBtn);
            this.Controls.Add(this.BtnAdd);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button RemoveRoomBtn;
        private System.Windows.Forms.DataGridView DataRooms;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}