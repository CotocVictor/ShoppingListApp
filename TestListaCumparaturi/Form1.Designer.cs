namespace TestListaCumparaturi
{
    partial class FormCumparaturi
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
            this.ListViewElemente = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ListViewElemente
            // 
            this.ListViewElemente.Location = new System.Drawing.Point(12, 12);
            this.ListViewElemente.Name = "ListViewElemente";
            this.ListViewElemente.Size = new System.Drawing.Size(240, 185);
            this.ListViewElemente.TabIndex = 0;
            this.ListViewElemente.UseCompatibleStateImageBehavior = false;
            // 
            // FormCumparaturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 290);
            this.Controls.Add(this.ListViewElemente);
            this.Name = "FormCumparaturi";
            this.Text = "Lista cumparaturi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListViewElemente;
    }
}

