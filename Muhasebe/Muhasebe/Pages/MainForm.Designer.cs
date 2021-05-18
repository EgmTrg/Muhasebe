
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Homepage");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("List");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Current Account", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.headerSettings_panel = new System.Windows.Forms.Panel();
            this.currentUsername_label = new System.Windows.Forms.Label();
            this.menuBar_HideOrShow_button = new System.Windows.Forms.Button();
            this.menubar_treeView = new System.Windows.Forms.TreeView();
            this.main_panel = new System.Windows.Forms.Panel();
            this.headerSettings_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerSettings_panel
            // 
            this.headerSettings_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.headerSettings_panel.Controls.Add(this.currentUsername_label);
            this.headerSettings_panel.Controls.Add(this.menuBar_HideOrShow_button);
            this.headerSettings_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerSettings_panel.Location = new System.Drawing.Point(0, 0);
            this.headerSettings_panel.Name = "headerSettings_panel";
            this.headerSettings_panel.Size = new System.Drawing.Size(1286, 39);
            this.headerSettings_panel.TabIndex = 1;
            // 
            // currentUsername_label
            // 
            this.currentUsername_label.AutoSize = true;
            this.currentUsername_label.Dock = System.Windows.Forms.DockStyle.Right;
            this.currentUsername_label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.currentUsername_label.ForeColor = System.Drawing.Color.White;
            this.currentUsername_label.Location = new System.Drawing.Point(1207, 0);
            this.currentUsername_label.Name = "currentUsername_label";
            this.currentUsername_label.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.currentUsername_label.Size = new System.Drawing.Size(79, 32);
            this.currentUsername_label.TabIndex = 3;
            this.currentUsername_label.Text = "\'s Account";
            // 
            // menuBar_HideOrShow_button
            // 
            this.menuBar_HideOrShow_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(111)))), ((int)(((byte)(81)))));
            this.menuBar_HideOrShow_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.menuBar_HideOrShow_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.menuBar_HideOrShow_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBar_HideOrShow_button.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuBar_HideOrShow_button.Location = new System.Drawing.Point(3, 3);
            this.menuBar_HideOrShow_button.Name = "menuBar_HideOrShow_button";
            this.menuBar_HideOrShow_button.Size = new System.Drawing.Size(86, 33);
            this.menuBar_HideOrShow_button.TabIndex = 2;
            this.menuBar_HideOrShow_button.Text = "MenuBar";
            this.menuBar_HideOrShow_button.UseVisualStyleBackColor = false;
            // 
            // menubar_treeView
            // 
            this.menubar_treeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.menubar_treeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.menubar_treeView.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menubar_treeView.ForeColor = System.Drawing.Color.White;
            this.menubar_treeView.Location = new System.Drawing.Point(0, 39);
            this.menubar_treeView.Name = "menubar_treeView";
            treeNode1.Name = "Node0";
            treeNode1.Tag = "ChildNode";
            treeNode1.Text = "Homepage";
            treeNode2.Name = "Node3";
            treeNode2.Tag = "ChildNode";
            treeNode2.Text = "List";
            treeNode3.Name = "Node1";
            treeNode3.Tag = "ParentNode";
            treeNode3.Text = "Current Account";
            this.menubar_treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode3});
            this.menubar_treeView.Size = new System.Drawing.Size(192, 648);
            this.menubar_treeView.TabIndex = 2;
            this.menubar_treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.menubar_treeView_NodeMouseClick);
            // 
            // main_panel
            // 
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(192, 39);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1094, 648);
            this.main_panel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(1286, 687);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.menubar_treeView);
            this.Controls.Add(this.headerSettings_panel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.headerSettings_panel.ResumeLayout(false);
            this.headerSettings_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerSettings_panel;
        private System.Windows.Forms.Button menuBar_HideOrShow_button;
        private System.Windows.Forms.Label currentUsername_label;
        private System.Windows.Forms.Panel main_panel;
        public System.Windows.Forms.TreeView menubar_treeView;
    }
}