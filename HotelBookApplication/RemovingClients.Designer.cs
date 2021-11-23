
namespace HotelBookApplication
{
    partial class RemovingClients
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
            this.DataClient = new System.Windows.Forms.DataGridView();
            this.Removebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataClient)).BeginInit();
            this.SuspendLayout();
            // 
            // DataClient
            // 
            this.DataClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataClient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DataClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataClient.Location = new System.Drawing.Point(12, 102);
            this.DataClient.Name = "DataClient";
            this.DataClient.Size = new System.Drawing.Size(776, 286);
            this.DataClient.TabIndex = 0;
            // 
            // Removebtn
            // 
            this.Removebtn.Location = new System.Drawing.Point(12, 73);
            this.Removebtn.Name = "Removebtn";
            this.Removebtn.Size = new System.Drawing.Size(75, 23);
            this.Removebtn.TabIndex = 1;
            this.Removebtn.Text = "Remove";
            this.Removebtn.UseVisualStyleBackColor = true;
            this.Removebtn.Click += new System.EventHandler(this.Removebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client List";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(102, 73);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // RemovingClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Removebtn);
            this.Controls.Add(this.DataClient);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RemovingClients";
            this.Text = "RemovingClients";
            this.Load += new System.EventHandler(this.RemovingClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataClient;
        private System.Windows.Forms.Button Removebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button BtnClose;
    }
}