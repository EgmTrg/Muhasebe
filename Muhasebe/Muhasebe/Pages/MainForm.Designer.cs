
namespace Muhasebe.Pages
{
    partial class MainForm
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
            this.headerSettings_panel = new System.Windows.Forms.Panel();
            this.menuBar_HideOrShow_button = new System.Windows.Forms.Button();
            this.headerSettings_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerSettings_panel
            // 
            this.headerSettings_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.headerSettings_panel.Controls.Add(this.menuBar_HideOrShow_button);
            this.headerSettings_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerSettings_panel.Location = new System.Drawing.Point(0, 0);
            this.headerSettings_panel.Name = "headerSettings_panel";
            this.headerSettings_panel.Size = new System.Drawing.Size(1286, 39);
            this.headerSettings_panel.TabIndex = 1;
            // 
            // menuBar_HideOrShow_button
            // 
            this.menuBar_HideOrShow_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(111)))), ((int)(((byte)(81)))));
            this.menuBar_HideOrShow_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.menuBar_HideOrShow_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.menuBar_HideOrShow_button.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuBar_HideOrShow_button.Location = new System.Drawing.Point(3, 3);
            this.menuBar_HideOrShow_button.Name = "menuBar_HideOrShow_button";
            this.menuBar_HideOrShow_button.Size = new System.Drawing.Size(84, 33);
            this.menuBar_HideOrShow_button.TabIndex = 2;
            this.menuBar_HideOrShow_button.Text = "MenuBar";
            this.menuBar_HideOrShow_button.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(1286, 687);
            this.Controls.Add(this.headerSettings_panel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.headerSettings_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerSettings_panel;
        private System.Windows.Forms.Button menuBar_HideOrShow_button;
    }
}