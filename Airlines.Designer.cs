
namespace Airlines
{
    partial class Airlines
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
            this.components = new System.ComponentModel.Container();
            this.listBoxAirlines = new System.Windows.Forms.ListBox();
            this.textBoxAirlineEntry = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAirlines
            // 
            this.listBoxAirlines.FormattingEnabled = true;
            this.listBoxAirlines.ItemHeight = 20;
            this.listBoxAirlines.Items.AddRange(new object[] {
            "Air Canada",
            "Qantas"});
            this.listBoxAirlines.Location = new System.Drawing.Point(43, 78);
            this.listBoxAirlines.Name = "listBoxAirlines";
            this.listBoxAirlines.Size = new System.Drawing.Size(246, 244);
            this.listBoxAirlines.TabIndex = 2;
            this.toolTip1.SetToolTip(this.listBoxAirlines, "It\'s a list of airlines");
            // 
            // textBoxAirlineEntry
            // 
            this.textBoxAirlineEntry.Location = new System.Drawing.Point(43, 32);
            this.textBoxAirlineEntry.Name = "textBoxAirlineEntry";
            this.textBoxAirlineEntry.Size = new System.Drawing.Size(125, 27);
            this.textBoxAirlineEntry.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBoxAirlineEntry, "Enter an airline here");
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(195, 32);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 29);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "&Add";
            this.toolTip1.SetToolTip(this.buttonAdd, "Click to add the airline to the list");
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(43, 336);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(94, 29);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "&Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(195, 336);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(94, 29);
            this.buttonSort.TabIndex = 4;
            this.buttonSort.Text = "&Sort";
            this.toolTip1.SetToolTip(this.buttonSort, "Sorts the list");
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(43, 383);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Sa&ve";
            this.toolTip1.SetToolTip(this.buttonSave, "Saves the list to a selected location");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.SaveClick);
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(195, 383);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(94, 29);
            this.buttonImport.TabIndex = 6;
            this.buttonImport.Text = "&Import";
            this.toolTip1.SetToolTip(this.buttonImport, "Replaces the current list with one from a file");
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.ImportClick);
            // 
            // Airlines
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 436);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxAirlineEntry);
            this.Controls.Add(this.listBoxAirlines);
            this.Name = "Airlines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airline List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAirlines;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBoxAirlineEntry;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonImport;
    }
}

