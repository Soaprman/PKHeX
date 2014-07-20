﻿namespace PKHeX
{
    partial class CodeGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeGenerator));
            this.RTB_Code = new System.Windows.Forms.RichTextBox();
            this.TB_Write = new System.Windows.Forms.TextBox();
            this.L_Write = new System.Windows.Forms.Label();
            this.L_Source = new System.Windows.Forms.Label();
            this.CB_Source = new System.Windows.Forms.ComboBox();
            this.B_Save = new System.Windows.Forms.Button();
            this.L_Box = new System.Windows.Forms.Label();
            this.L_Slot = new System.Windows.Forms.Label();
            this.CB_Slot = new System.Windows.Forms.ComboBox();
            this.CB_Box = new System.Windows.Forms.ComboBox();
            this.B_Load = new System.Windows.Forms.Button();
            this.B_Add = new System.Windows.Forms.Button();
            this.B_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RTB_Code
            // 
            this.RTB_Code.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_Code.Location = new System.Drawing.Point(12, 100);
            this.RTB_Code.Name = "RTB_Code";
            this.RTB_Code.ReadOnly = true;
            this.RTB_Code.Size = new System.Drawing.Size(210, 175);
            this.RTB_Code.TabIndex = 0;
            this.RTB_Code.Text = "01234567 01234567 01234567 ";
            // 
            // TB_Write
            // 
            this.TB_Write.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Write.Location = new System.Drawing.Point(12, 24);
            this.TB_Write.Name = "TB_Write";
            this.TB_Write.Size = new System.Drawing.Size(65, 20);
            this.TB_Write.TabIndex = 1;
            this.TB_Write.Text = "01234567";
            // 
            // L_Write
            // 
            this.L_Write.AutoSize = true;
            this.L_Write.Location = new System.Drawing.Point(9, 8);
            this.L_Write.Name = "L_Write";
            this.L_Write.Size = new System.Drawing.Size(66, 13);
            this.L_Write.TabIndex = 2;
            this.L_Write.Text = "Write Offset:";
            // 
            // L_Source
            // 
            this.L_Source.AutoSize = true;
            this.L_Source.Location = new System.Drawing.Point(87, 8);
            this.L_Source.Name = "L_Source";
            this.L_Source.Size = new System.Drawing.Size(70, 13);
            this.L_Source.TabIndex = 5;
            this.L_Source.Text = "Data Source:";
            // 
            // CB_Source
            // 
            this.CB_Source.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Source.FormattingEnabled = true;
            this.CB_Source.Items.AddRange(new object[] {
            "Loaded EKX (Tabs)",
            "Box EKX",
            "Wondercard"});
            this.CB_Source.Location = new System.Drawing.Point(90, 23);
            this.CB_Source.Name = "CB_Source";
            this.CB_Source.Size = new System.Drawing.Size(132, 21);
            this.CB_Source.TabIndex = 6;
            this.CB_Source.SelectedIndexChanged += new System.EventHandler(this.changeDataSource);
            // 
            // B_Save
            // 
            this.B_Save.Location = new System.Drawing.Point(12, 71);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(69, 23);
            this.B_Save.TabIndex = 9;
            this.B_Save.Text = "Save Code";
            this.B_Save.UseVisualStyleBackColor = true;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // L_Box
            // 
            this.L_Box.AutoSize = true;
            this.L_Box.Location = new System.Drawing.Point(87, 48);
            this.L_Box.Name = "L_Box";
            this.L_Box.Size = new System.Drawing.Size(28, 13);
            this.L_Box.TabIndex = 10;
            this.L_Box.Text = "Box:";
            // 
            // L_Slot
            // 
            this.L_Slot.AutoSize = true;
            this.L_Slot.Location = new System.Drawing.Point(156, 48);
            this.L_Slot.Name = "L_Slot";
            this.L_Slot.Size = new System.Drawing.Size(28, 13);
            this.L_Slot.TabIndex = 11;
            this.L_Slot.Text = "Slot:";
            // 
            // CB_Slot
            // 
            this.CB_Slot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Slot.FormattingEnabled = true;
            this.CB_Slot.Items.AddRange(new object[] {
            "Loaded EKX (Tabs)",
            "Box EKX ",
            "Wondercard"});
            this.CB_Slot.Location = new System.Drawing.Point(187, 44);
            this.CB_Slot.Name = "CB_Slot";
            this.CB_Slot.Size = new System.Drawing.Size(35, 21);
            this.CB_Slot.TabIndex = 12;
            this.CB_Slot.SelectedIndexChanged += new System.EventHandler(this.changeSourceIndex);
            // 
            // CB_Box
            // 
            this.CB_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Box.FormattingEnabled = true;
            this.CB_Box.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.CB_Box.Location = new System.Drawing.Point(120, 44);
            this.CB_Box.Name = "CB_Box";
            this.CB_Box.Size = new System.Drawing.Size(35, 21);
            this.CB_Box.TabIndex = 13;
            this.CB_Box.SelectedIndexChanged += new System.EventHandler(this.changeSourceIndex);
            // 
            // B_Load
            // 
            this.B_Load.Location = new System.Drawing.Point(12, 48);
            this.B_Load.Name = "B_Load";
            this.B_Load.Size = new System.Drawing.Size(69, 23);
            this.B_Load.TabIndex = 14;
            this.B_Load.Text = "Load Code";
            this.B_Load.UseVisualStyleBackColor = true;
            this.B_Load.Click += new System.EventHandler(this.B_Load_Click);
            // 
            // B_Add
            // 
            this.B_Add.Location = new System.Drawing.Point(162, 71);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(60, 23);
            this.B_Add.TabIndex = 15;
            this.B_Add.Text = "Add ↓";
            this.B_Add.UseVisualStyleBackColor = true;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // B_Clear
            // 
            this.B_Clear.Location = new System.Drawing.Point(90, 71);
            this.B_Clear.Name = "B_Clear";
            this.B_Clear.Size = new System.Drawing.Size(60, 23);
            this.B_Clear.TabIndex = 16;
            this.B_Clear.Text = "Clear All";
            this.B_Clear.UseVisualStyleBackColor = true;
            this.B_Clear.Click += new System.EventHandler(this.B_Clear_Click);
            // 
            // CodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 282);
            this.Controls.Add(this.B_Clear);
            this.Controls.Add(this.B_Add);
            this.Controls.Add(this.B_Load);
            this.Controls.Add(this.CB_Box);
            this.Controls.Add(this.CB_Slot);
            this.Controls.Add(this.L_Slot);
            this.Controls.Add(this.L_Box);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.CB_Source);
            this.Controls.Add(this.L_Source);
            this.Controls.Add(this.L_Write);
            this.Controls.Add(this.TB_Write);
            this.Controls.Add(this.RTB_Code);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CodeGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CodeGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB_Code;
        private System.Windows.Forms.TextBox TB_Write;
        private System.Windows.Forms.Label L_Write;
        private System.Windows.Forms.Label L_Source;
        private System.Windows.Forms.ComboBox CB_Source;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Label L_Box;
        private System.Windows.Forms.Label L_Slot;
        private System.Windows.Forms.ComboBox CB_Slot;
        private System.Windows.Forms.ComboBox CB_Box;
        private System.Windows.Forms.Button B_Load;
        private System.Windows.Forms.Button B_Add;
        private System.Windows.Forms.Button B_Clear;
    }
}