
namespace Muhasebe.Pages.SubPages.Current
{
    partial class List
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchValue_richTextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.search_groupBox = new System.Windows.Forms.GroupBox();
            this.clearFilter_ıconButton = new FontAwesome.Sharp.IconButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshList_iconButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.search_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 137);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(1094, 511);
            this.dataGridView1.TabIndex = 0;
            // 
            // searchValue_richTextBox
            // 
            this.searchValue_richTextBox.Location = new System.Drawing.Point(157, 50);
            this.searchValue_richTextBox.Name = "searchValue_richTextBox";
            this.searchValue_richTextBox.Size = new System.Drawing.Size(185, 48);
            this.searchValue_richTextBox.TabIndex = 2;
            this.searchValue_richTextBox.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // search_groupBox
            // 
            this.search_groupBox.Controls.Add(this.clearFilter_ıconButton);
            this.search_groupBox.Controls.Add(this.radioButton5);
            this.search_groupBox.Controls.Add(this.radioButton3);
            this.search_groupBox.Controls.Add(this.radioButton4);
            this.search_groupBox.Controls.Add(this.radioButton6);
            this.search_groupBox.Controls.Add(this.radioButton2);
            this.search_groupBox.Controls.Add(this.radioButton1);
            this.search_groupBox.Controls.Add(this.label2);
            this.search_groupBox.Controls.Add(this.label1);
            this.search_groupBox.Controls.Add(this.searchValue_richTextBox);
            this.search_groupBox.Location = new System.Drawing.Point(12, 13);
            this.search_groupBox.Name = "search_groupBox";
            this.search_groupBox.Size = new System.Drawing.Size(826, 116);
            this.search_groupBox.TabIndex = 4;
            this.search_groupBox.TabStop = false;
            this.search_groupBox.Text = "Search Area";
            // 
            // clearFilter_ıconButton
            // 
            this.clearFilter_ıconButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clearFilter_ıconButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.clearFilter_ıconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clearFilter_ıconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFilter_ıconButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clearFilter_ıconButton.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.clearFilter_ıconButton.IconColor = System.Drawing.Color.Black;
            this.clearFilter_ıconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.clearFilter_ıconButton.IconSize = 18;
            this.clearFilter_ıconButton.Location = new System.Drawing.Point(488, 18);
            this.clearFilter_ıconButton.Name = "clearFilter_ıconButton";
            this.clearFilter_ıconButton.Size = new System.Drawing.Size(92, 27);
            this.clearFilter_ıconButton.TabIndex = 6;
            this.clearFilter_ıconButton.Text = "Clear Filter";
            this.clearFilter_ıconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clearFilter_ıconButton.UseVisualStyleBackColor = true;
            this.clearFilter_ıconButton.Click += new System.EventHandler(this.clearFilter_ıconButton_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton5.Location = new System.Drawing.Point(529, 79);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(69, 22);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "District";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.SearchButtons_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton3.Location = new System.Drawing.Point(474, 51);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(49, 22);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "City";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.SearchButtons_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton4.Location = new System.Drawing.Point(474, 79);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(53, 22);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Date";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.SearchButtons_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton6.Location = new System.Drawing.Point(529, 51);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(90, 22);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Personal ID";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.SearchButtons_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(361, 79);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(107, 22);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Current Name";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.SearchButtons_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(361, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 22);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Current Code";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.SearchButtons_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(357, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search Settings";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "What are you want to look for?";
            // 
            // refreshList_iconButton
            // 
            this.refreshList_iconButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.refreshList_iconButton.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.refreshList_iconButton.IconColor = System.Drawing.Color.Black;
            this.refreshList_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.refreshList_iconButton.IconSize = 40;
            this.refreshList_iconButton.Location = new System.Drawing.Point(844, 53);
            this.refreshList_iconButton.Name = "refreshList_iconButton";
            this.refreshList_iconButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.refreshList_iconButton.Size = new System.Drawing.Size(247, 58);
            this.refreshList_iconButton.TabIndex = 5;
            this.refreshList_iconButton.Text = "Refresh List";
            this.refreshList_iconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.refreshList_iconButton.UseVisualStyleBackColor = true;
            this.refreshList_iconButton.Click += new System.EventHandler(this.refreshList_iconButton_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.refreshList_iconButton);
            this.Controls.Add(this.search_groupBox);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "List";
            this.Size = new System.Drawing.Size(1094, 648);
            this.Load += new System.EventHandler(this.List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.search_groupBox.ResumeLayout(false);
            this.search_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox searchValue_richTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox search_groupBox;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton refreshList_iconButton;
        private FontAwesome.Sharp.IconButton clearFilter_ıconButton;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}
