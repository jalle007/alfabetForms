namespace alfabetForms {
    partial class alfabetForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.textBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.buttonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.addNewToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(640, 28);
      this.menuStrip1.TabIndex = 3;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
      this.editToolStripMenuItem.Text = "Edit";
      this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
      this.saveToolStripMenuItem.Text = "Save";
      this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
      // 
      // resetToolStripMenuItem
      // 
      this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
      this.resetToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
      this.resetToolStripMenuItem.Text = "Reset";
      this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
      // 
      // addNewToolStripMenuItem
      // 
      this.addNewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textBoxToolStripMenuItem,
            this.buttonToolStripMenuItem});
      this.addNewToolStripMenuItem.Enabled = false;
      this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
      this.addNewToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
      this.addNewToolStripMenuItem.Text = "Add new";
      // 
      // textBoxToolStripMenuItem
      // 
      this.textBoxToolStripMenuItem.Name = "textBoxToolStripMenuItem";
      this.textBoxToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
      this.textBoxToolStripMenuItem.Text = "TextBox";
      this.textBoxToolStripMenuItem.Click += new System.EventHandler(this.textBoxToolStripMenuItem_Click);
      // 
      // buttonToolStripMenuItem
      // 
      this.buttonToolStripMenuItem.Name = "buttonToolStripMenuItem";
      this.buttonToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
      this.buttonToolStripMenuItem.Text = "Button";
      this.buttonToolStripMenuItem.Click += new System.EventHandler(this.buttonToolStripMenuItem_Click);
      // 
      // timer1
      // 
      this.timer1.Interval = 2000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // alfabetForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(640, 324);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "alfabetForm";
      this.Tag = "36516451-11d4-4178-9202-624c8b845045";
      this.Text = "alfabetForm";
      this.Load += new System.EventHandler(this.alfabetForm_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem textBoxToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem buttonToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
    private System.Windows.Forms.Timer timer1;
  }
}