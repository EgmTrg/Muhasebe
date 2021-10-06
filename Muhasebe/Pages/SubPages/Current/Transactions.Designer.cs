
namespace Muhasebe.Pages.SubPages.Current
{
    partial class Transactions
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.edit_checkBox = new System.Windows.Forms.CheckBox();
            this.Search_ıconButton = new FontAwesome.Sharp.IconButton();
            this.Remove_ıconButton = new FontAwesome.Sharp.IconButton();
            this.Add_ıconButton = new FontAwesome.Sharp.IconButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.edit_checkBox);
            this.panel1.Controls.Add(this.Search_ıconButton);
            this.panel1.Controls.Add(this.Remove_ıconButton);
            this.panel1.Controls.Add(this.Add_ıconButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 61);
            this.panel1.TabIndex = 0;
            // 
            // edit_checkBox
            // 
            this.edit_checkBox.AutoSize = true;
            this.edit_checkBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(111)))), ((int)(((byte)(81)))));
            this.edit_checkBox.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.edit_checkBox.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.edit_checkBox.FlatAppearance.BorderSize = 3;
            this.edit_checkBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.edit_checkBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.edit_checkBox.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.edit_checkBox.Location = new System.Drawing.Point(846, 6);
            this.edit_checkBox.Name = "edit_checkBox";
            this.edit_checkBox.Size = new System.Drawing.Size(235, 47);
            this.edit_checkBox.TabIndex = 2;
            this.edit_checkBox.Text = "Edit Mode: DISABLE";
            this.edit_checkBox.UseVisualStyleBackColor = false;
            this.edit_checkBox.CheckedChanged += new System.EventHandler(this.edit_checkBox_CheckedChanged);
            // 
            // Search_ıconButton
            // 
            this.Search_ıconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(111)))), ((int)(((byte)(81)))));
            this.Search_ıconButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.Search_ıconButton.FlatAppearance.BorderSize = 3;
            this.Search_ıconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.Search_ıconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_ıconButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Search_ıconButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Search_ıconButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.Search_ıconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Search_ıconButton.IconSize = 32;
            this.Search_ıconButton.Location = new System.Drawing.Point(230, 3);
            this.Search_ıconButton.Name = "Search_ıconButton";
            this.Search_ıconButton.Size = new System.Drawing.Size(122, 54);
            this.Search_ıconButton.TabIndex = 1;
            this.Search_ıconButton.Text = "Search";
            this.Search_ıconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Search_ıconButton.UseVisualStyleBackColor = false;
            this.Search_ıconButton.Click += new System.EventHandler(this.Search_ıconButton_Click);
            // 
            // Remove_ıconButton
            // 
            this.Remove_ıconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(111)))), ((int)(((byte)(81)))));
            this.Remove_ıconButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.Remove_ıconButton.FlatAppearance.BorderSize = 3;
            this.Remove_ıconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.Remove_ıconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove_ıconButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Remove_ıconButton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.Remove_ıconButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.Remove_ıconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Remove_ıconButton.IconSize = 32;
            this.Remove_ıconButton.Location = new System.Drawing.Point(102, 3);
            this.Remove_ıconButton.Name = "Remove_ıconButton";
            this.Remove_ıconButton.Size = new System.Drawing.Size(122, 54);
            this.Remove_ıconButton.TabIndex = 1;
            this.Remove_ıconButton.Text = "Remove";
            this.Remove_ıconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Remove_ıconButton.UseVisualStyleBackColor = false;
            // 
            // Add_ıconButton
            // 
            this.Add_ıconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(111)))), ((int)(((byte)(81)))));
            this.Add_ıconButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.Add_ıconButton.FlatAppearance.BorderSize = 3;
            this.Add_ıconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.Add_ıconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_ıconButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Add_ıconButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.Add_ıconButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.Add_ıconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Add_ıconButton.IconSize = 32;
            this.Add_ıconButton.Location = new System.Drawing.Point(3, 3);
            this.Add_ıconButton.Name = "Add_ıconButton";
            this.Add_ıconButton.Size = new System.Drawing.Size(98, 54);
            this.Add_ıconButton.TabIndex = 1;
            this.Add_ıconButton.Text = "Add";
            this.Add_ıconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Add_ıconButton.UseVisualStyleBackColor = false;
            this.Add_ıconButton.Click += new System.EventHandler(this.Add_ıconButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 61);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1094, 587);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView_CellBeginEdit);
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "Transactions";
            this.Size = new System.Drawing.Size(1094, 648);
            this.Load += new System.EventHandler(this.Transactions_Page_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Search_ıconButton;
        private FontAwesome.Sharp.IconButton Remove_ıconButton;
        private FontAwesome.Sharp.IconButton Add_ıconButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.CheckBox edit_checkBox;
    }
}
