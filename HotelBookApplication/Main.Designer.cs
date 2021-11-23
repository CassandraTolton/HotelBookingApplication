
namespace HotelBookApplication
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unavailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.dataTest = new System.Windows.Forms.DataGridView();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTest)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 23);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomsToolStripMenuItem,
            this.customersToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookedToolStripMenuItem,
            this.availableToolStripMenuItem,
            this.unavailableToolStripMenuItem});
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.roomsToolStripMenuItem.Text = "Rooms";
            // 
            // bookedToolStripMenuItem
            // 
            this.bookedToolStripMenuItem.Name = "bookedToolStripMenuItem";
            this.bookedToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.bookedToolStripMenuItem.Text = "Booked";
            this.bookedToolStripMenuItem.Click += new System.EventHandler(this.bookedToolStripMenuItem_Click);
            // 
            // availableToolStripMenuItem
            // 
            this.availableToolStripMenuItem.Name = "availableToolStripMenuItem";
            this.availableToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.availableToolStripMenuItem.Text = "Available";
            this.availableToolStripMenuItem.Click += new System.EventHandler(this.availableToolStripMenuItem_Click);
            // 
            // unavailableToolStripMenuItem
            // 
            this.unavailableToolStripMenuItem.Name = "unavailableToolStripMenuItem";
            this.unavailableToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.unavailableToolStripMenuItem.Text = "Down For Repair";
            this.unavailableToolStripMenuItem.Click += new System.EventHandler(this.unavailableToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 19);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.roomToolStripMenuItem.Text = "Room";
            this.roomToolStripMenuItem.Click += new System.EventHandler(this.roomToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hotel Booking Application";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(674, 93);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(127, 49);
            this.btnCheckIn.TabIndex = 3;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(807, 93);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(127, 49);
            this.btnCheckOut.TabIndex = 4;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataTest
            // 
            this.dataTest.AllowUserToAddRows = false;
            this.dataTest.AllowUserToDeleteRows = false;
            this.dataTest.AllowUserToResizeColumns = false;
            this.dataTest.AllowUserToResizeRows = false;
            this.dataTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTest.Location = new System.Drawing.Point(12, 148);
            this.dataTest.Name = "dataTest";
            this.dataTest.Size = new System.Drawing.Size(922, 290);
            this.dataTest.TabIndex = 6;
            this.dataTest.BackgroundColorChanged += new System.EventHandler(this.dataTest_BackgroundColorChanged);
            this.dataTest.AutoSizeColumnModeChanged += new System.Windows.Forms.DataGridViewAutoSizeColumnModeEventHandler(this.dataTest_AutoSizeColumnModeChanged);
            this.dataTest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTest_CellContentClick);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomsToolStripMenuItem1,
            this.clientsToolStripMenuItem});
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(62, 19);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // roomsToolStripMenuItem1
            // 
            this.roomsToolStripMenuItem1.Name = "roomsToolStripMenuItem1";
            this.roomsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.roomsToolStripMenuItem1.Text = "Rooms";
            this.roomsToolStripMenuItem1.Click += new System.EventHandler(this.roomsToolStripMenuItem1_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 450);
            this.Controls.Add(this.dataTest);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Hotel Reservation Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem availableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unavailableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataTest;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
    }
}

