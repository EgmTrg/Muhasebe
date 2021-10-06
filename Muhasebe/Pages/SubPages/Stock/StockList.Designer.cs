
namespace Muhasebe.Pages.SubPages.Stock
{
    partial class StockList
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
            this.refreshList_iconButton = new FontAwesome.Sharp.IconButton();
            this.search_groupBox = new System.Windows.Forms.GroupBox();
            this.clearFilter_ıconButton = new FontAwesome.Sharp.IconButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchValue_richTextBox = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshList_iconButton
            // 
            this.refreshList_iconButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.refreshList_iconButton.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.refreshList_iconButton.IconColor = System.Drawing.Color.Black;
            this.refreshList_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.refreshList_iconButton.IconSize = 40;
            this.refreshList_iconButton.Location = new System.Drawing.Point(844, 47);
            this.refreshList_iconButton.Name = "refreshList_iconButton";
            this.refreshList_iconButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.refreshList_iconButton.Size = new System.Drawing.Size(247, 58);
            this.refreshList_iconButton.TabIndex = 8;
            this.refreshList_iconButton.Text = "Refresh List";
            this.refreshList_iconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.refreshList_iconButton.UseVisualStyleBackColor = true;
            // 
            // search_groupBox
            // 
            this.search_groupBox.Controls.Add(this.clearFilter_ıconButton);
            this.search_groupBox.Controls.Add(this.radioButton3);
            this.search_groupBox.Controls.Add(this.radioButton1);
            this.search_groupBox.Controls.Add(this.label2);
            this.search_groupBox.Controls.Add(this.label1);
            this.search_groupBox.Controls.Add(this.searchValue_richTextBox);
            this.search_groupBox.Location = new System.Drawing.Point(12, 7);
            this.search_groupBox.Name = "search_groupBox";
            this.search_groupBox.Size = new System.Drawing.Size(826, 116);
            this.search_groupBox.TabIndex = 7;
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
            this.clearFilter_ıconButton.Location = new System.Drawing.Point(488, 23);
            this.clearFilter_ıconButton.Name = "clearFilter_ıconButton";
            this.clearFilter_ıconButton.Size = new System.Drawing.Size(92, 27);
            this.clearFilter_ıconButton.TabIndex = 6;
            this.clearFilter_ıconButton.Text = "Clear Filter";
            this.clearFilter_ıconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clearFilter_ıconButton.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton3.Location = new System.Drawing.Point(474, 60);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(91, 22);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Stock Code";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(361, 60);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 22);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Stock Name";
            this.radioButton1.UseVisualStyleBackColor = true;
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
            // searchValue_richTextBox
            // 
            this.searchValue_richTextBox.Location = new System.Drawing.Point(157, 50);
            this.searchValue_richTextBox.Name = "searchValue_richTextBox";
            this.searchValue_richTextBox.Size = new System.Drawing.Size(185, 48);
            this.searchValue_richTextBox.TabIndex = 2;
            this.searchValue_richTextBox.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 131);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(1094, 511);
            this.dataGridView1.TabIndex = 6;
            // 
            // StockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.refreshList_iconButton);
            this.Controls.Add(this.search_groupBox);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StockList";
            this.Size = new System.Drawing.Size(1094, 648);
            this.search_groupBox.ResumeLayout(false);
            this.search_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton refreshList_iconButton;
        private System.Windows.Forms.GroupBox search_groupBox;
        private FontAwesome.Sharp.IconButton clearFilter_ıconButton;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox searchValue_richTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
