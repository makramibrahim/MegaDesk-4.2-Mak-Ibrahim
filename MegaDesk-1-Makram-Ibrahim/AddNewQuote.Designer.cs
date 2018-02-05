namespace MegaDesk_4_Makram_Ibrahim
{
    partial class AddNewQuote
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
            this.MenuBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.DeskWidth = new System.Windows.Forms.TextBox();
            this.DeskDepth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.DeskMaterial = new System.Windows.Forms.ComboBox();
            this.Total = new System.Windows.Forms.Label();
            this.OrderDate = new System.Windows.Forms.Label();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.DeskDrawers = new System.Windows.Forms.ComboBox();
            this.RushDays = new System.Windows.Forms.ComboBox();
            this.DisplayQuote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MenuBtn
            // 
            this.MenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn.Location = new System.Drawing.Point(11, 388);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(90, 34);
            this.MenuBtn.TabIndex = 8;
            this.MenuBtn.Text = "Menu";
            this.MenuBtn.UseVisualStyleBackColor = true;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desk Width:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 50);
            this.label3.TabIndex = 1;
            this.label3.Text = "Desk Depth:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 50);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClientName
            // 
            this.ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientName.Location = new System.Drawing.Point(159, 77);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(183, 26);
            this.ClientName.TabIndex = 1;
            // 
            // DeskWidth
            // 
            this.DeskWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidth.Location = new System.Drawing.Point(159, 124);
            this.DeskWidth.Name = "DeskWidth";
            this.DeskWidth.Size = new System.Drawing.Size(183, 26);
            this.DeskWidth.TabIndex = 2;
            this.DeskWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeskWidth_KeyPress);
            // 
            // DeskDepth
            // 
            this.DeskDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepth.Location = new System.Drawing.Point(159, 174);
            this.DeskDepth.Name = "DeskDepth";
            this.DeskDepth.Size = new System.Drawing.Size(183, 26);
            this.DeskDepth.TabIndex = 3;
            this.DeskDepth.TextChanged += new System.EventHandler(this.DeskDepth_TextChanged);
            this.DeskDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeskWidth_KeyPress);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(374, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 50);
            this.label5.TabIndex = 1;
            this.label5.Text = "Material:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(374, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 50);
            this.label6.TabIndex = 1;
            this.label6.Text = "Drawers :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(374, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 50);
            this.label7.TabIndex = 1;
            this.label7.Text = "Rush Days:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalPrice
            // 
            this.TotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice.Location = new System.Drawing.Point(504, 388);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(138, 35);
            this.TotalPrice.TabIndex = 1;
            this.TotalPrice.Text = "$0.00";
            this.TotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeskMaterial
            // 
            this.DeskMaterial.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.DeskMaterial.AllowDrop = true;
            this.DeskMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeskMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskMaterial.FormattingEnabled = true;
            this.DeskMaterial.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.DeskMaterial.Location = new System.Drawing.Point(489, 82);
            this.DeskMaterial.Name = "DeskMaterial";
            this.DeskMaterial.Size = new System.Drawing.Size(121, 28);
            this.DeskMaterial.TabIndex = 4;
            this.DeskMaterial.SelectedIndexChanged += new System.EventHandler(this.Material_SelectedIndexChanged);
            // 
            // Total
            // 
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(438, 388);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(60, 38);
            this.Total.TabIndex = 1;
            this.Total.Text = "Total:";
            this.Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderDate
            // 
            this.OrderDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDate.Location = new System.Drawing.Point(69, 19);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(182, 30);
            this.OrderDate.TabIndex = 1;
            this.OrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBtn.Location = new System.Drawing.Point(107, 388);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(134, 34);
            this.ConfirmBtn.TabIndex = 7;
            this.ConfirmBtn.Text = "Add Quote";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // DeskDrawers
            // 
            this.DeskDrawers.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.DeskDrawers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeskDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDrawers.FormattingEnabled = true;
            this.DeskDrawers.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.DeskDrawers.Location = new System.Drawing.Point(489, 124);
            this.DeskDrawers.Name = "DeskDrawers";
            this.DeskDrawers.Size = new System.Drawing.Size(121, 28);
            this.DeskDrawers.TabIndex = 5;
            this.DeskDrawers.SelectedIndexChanged += new System.EventHandler(this.Material_SelectedIndexChanged);
            // 
            // RushDays
            // 
            this.RushDays.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.RushDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RushDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushDays.FormattingEnabled = true;
            this.RushDays.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.RushDays.Location = new System.Drawing.Point(489, 171);
            this.RushDays.Name = "RushDays";
            this.RushDays.Size = new System.Drawing.Size(121, 28);
            this.RushDays.TabIndex = 6;
            this.RushDays.SelectedIndexChanged += new System.EventHandler(this.Material_SelectedIndexChanged);
            // 
            // DisplayQuote
            // 
            this.DisplayQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayQuote.Location = new System.Drawing.Point(27, 222);
            this.DisplayQuote.Name = "DisplayQuote";
            this.DisplayQuote.Size = new System.Drawing.Size(456, 163);
            this.DisplayQuote.TabIndex = 6;
            // 
            // AddNewQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.DisplayQuote);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.RushDays);
            this.Controls.Add(this.DeskDrawers);
            this.Controls.Add(this.DeskMaterial);
            this.Controls.Add(this.DeskDepth);
            this.Controls.Add(this.DeskWidth);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.OrderDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewQuote";
            this.Text = "AddNewQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.TextBox DeskWidth;
        private System.Windows.Forms.TextBox DeskDepth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.ComboBox DeskMaterial;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label OrderDate;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.ComboBox DeskDrawers;
        private System.Windows.Forms.ComboBox RushDays;
        private System.Windows.Forms.Label DisplayQuote;
    }
}