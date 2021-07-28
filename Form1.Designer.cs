
namespace Slotkin_P4
{
    partial class Form1
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
            this.tabsProgram = new System.Windows.Forms.TabControl();
            this.tabInstructions = new System.Windows.Forms.TabPage();
            this.tbInstructions = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddToInventory = new System.Windows.Forms.Button();
            this.gbDepMethod = new System.Windows.Forms.GroupBox();
            this.lblSelectMethod = new System.Windows.Forms.Label();
            this.rbDoubleDeclineDep = new System.Windows.Forms.RadioButton();
            this.rbStraightLineDep = new System.Windows.Forms.RadioButton();
            this.dtpDateOut = new System.Windows.Forms.DateTimePicker();
            this.dtpDateIn = new System.Windows.Forms.DateTimePicker();
            this.tbLifetime = new System.Windows.Forms.TextBox();
            this.tbEndingValue = new System.Windows.Forms.TextBox();
            this.tbStartValue = new System.Windows.Forms.TextBox();
            this.tbItem = new System.Windows.Forms.TextBox();
            this.lblDateOutInventory = new System.Windows.Forms.Label();
            this.lblDateInInventory = new System.Windows.Forms.Label();
            this.lblLifetime = new System.Windows.Forms.Label();
            this.lblEndValue = new System.Windows.Forms.Label();
            this.lblStartValue = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbInventory = new System.Windows.Forms.ListBox();
            this.tabSummary = new System.Windows.Forms.TabPage();
            this.tbSummary = new System.Windows.Forms.TextBox();
            this.btnSummary = new System.Windows.Forms.Button();
            this.tabsProgram.SuspendLayout();
            this.tabInstructions.SuspendLayout();
            this.tabInventory.SuspendLayout();
            this.gbDepMethod.SuspendLayout();
            this.tabSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsProgram
            // 
            this.tabsProgram.Controls.Add(this.tabInstructions);
            this.tabsProgram.Controls.Add(this.tabInventory);
            this.tabsProgram.Controls.Add(this.tabSummary);
            this.tabsProgram.Location = new System.Drawing.Point(12, 12);
            this.tabsProgram.Name = "tabsProgram";
            this.tabsProgram.SelectedIndex = 0;
            this.tabsProgram.Size = new System.Drawing.Size(849, 523);
            this.tabsProgram.TabIndex = 0;
            // 
            // tabInstructions
            // 
            this.tabInstructions.Controls.Add(this.tbInstructions);
            this.tabInstructions.Controls.Add(this.lblInstructions);
            this.tabInstructions.Location = new System.Drawing.Point(4, 29);
            this.tabInstructions.Name = "tabInstructions";
            this.tabInstructions.Padding = new System.Windows.Forms.Padding(3);
            this.tabInstructions.Size = new System.Drawing.Size(841, 490);
            this.tabInstructions.TabIndex = 0;
            this.tabInstructions.Text = "How to use this application";
            this.tabInstructions.UseVisualStyleBackColor = true;
            // 
            // tbInstructions
            // 
            this.tbInstructions.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbInstructions.Location = new System.Drawing.Point(102, 119);
            this.tbInstructions.Multiline = true;
            this.tbInstructions.Name = "tbInstructions";
            this.tbInstructions.ReadOnly = true;
            this.tbInstructions.Size = new System.Drawing.Size(533, 194);
            this.tbInstructions.TabIndex = 1;
            this.tbInstructions.Text = "Welcome to the Super Depreciation Calculator 3000.  Enter your inventory in the I" +
    "nventory tab.  Then go to the Summary tab to find the total yearly depreciation " +
    "value of your inventory.";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInstructions.Location = new System.Drawing.Point(70, 51);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(587, 46);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Super Depreciation Calculator 3000";
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.btnRemove);
            this.tabInventory.Controls.Add(this.btnAddToInventory);
            this.tabInventory.Controls.Add(this.gbDepMethod);
            this.tabInventory.Controls.Add(this.dtpDateOut);
            this.tabInventory.Controls.Add(this.dtpDateIn);
            this.tabInventory.Controls.Add(this.tbLifetime);
            this.tabInventory.Controls.Add(this.tbEndingValue);
            this.tabInventory.Controls.Add(this.tbStartValue);
            this.tabInventory.Controls.Add(this.tbItem);
            this.tabInventory.Controls.Add(this.lblDateOutInventory);
            this.tabInventory.Controls.Add(this.lblDateInInventory);
            this.tabInventory.Controls.Add(this.lblLifetime);
            this.tabInventory.Controls.Add(this.lblEndValue);
            this.tabInventory.Controls.Add(this.lblStartValue);
            this.tabInventory.Controls.Add(this.lblTitle);
            this.tabInventory.Controls.Add(this.lbInventory);
            this.tabInventory.Location = new System.Drawing.Point(4, 29);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(841, 490);
            this.tabInventory.TabIndex = 1;
            this.tabInventory.Text = "Inventory";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(56, 325);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(245, 56);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove Selected Item From Inventory";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddToInventory
            // 
            this.btnAddToInventory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddToInventory.Location = new System.Drawing.Point(425, 405);
            this.btnAddToInventory.Name = "btnAddToInventory";
            this.btnAddToInventory.Size = new System.Drawing.Size(274, 44);
            this.btnAddToInventory.TabIndex = 14;
            this.btnAddToInventory.Text = "Add Form Item To Inventory";
            this.btnAddToInventory.UseVisualStyleBackColor = true;
            this.btnAddToInventory.Click += new System.EventHandler(this.btnAddToInventory_Click);
            // 
            // gbDepMethod
            // 
            this.gbDepMethod.Controls.Add(this.lblSelectMethod);
            this.gbDepMethod.Controls.Add(this.rbDoubleDeclineDep);
            this.gbDepMethod.Controls.Add(this.rbStraightLineDep);
            this.gbDepMethod.Location = new System.Drawing.Point(328, 310);
            this.gbDepMethod.Name = "gbDepMethod";
            this.gbDepMethod.Size = new System.Drawing.Size(507, 71);
            this.gbDepMethod.TabIndex = 13;
            this.gbDepMethod.TabStop = false;
            // 
            // lblSelectMethod
            // 
            this.lblSelectMethod.AutoSize = true;
            this.lblSelectMethod.Location = new System.Drawing.Point(125, 18);
            this.lblSelectMethod.Name = "lblSelectMethod";
            this.lblSelectMethod.Size = new System.Drawing.Size(221, 20);
            this.lblSelectMethod.TabIndex = 2;
            this.lblSelectMethod.Text = "Select the depreciation method:";
            // 
            // rbDoubleDeclineDep
            // 
            this.rbDoubleDeclineDep.AutoSize = true;
            this.rbDoubleDeclineDep.Location = new System.Drawing.Point(252, 41);
            this.rbDoubleDeclineDep.Name = "rbDoubleDeclineDep";
            this.rbDoubleDeclineDep.Size = new System.Drawing.Size(236, 24);
            this.rbDoubleDeclineDep.TabIndex = 1;
            this.rbDoubleDeclineDep.TabStop = true;
            this.rbDoubleDeclineDep.Text = "Double Declining Depreciation";
            this.rbDoubleDeclineDep.UseVisualStyleBackColor = true;
            this.rbDoubleDeclineDep.CheckedChanged += new System.EventHandler(this.rbDoubleDeclineDep_CheckedChanged);
            // 
            // rbStraightLineDep
            // 
            this.rbStraightLineDep.AutoSize = true;
            this.rbStraightLineDep.Location = new System.Drawing.Point(40, 41);
            this.rbStraightLineDep.Name = "rbStraightLineDep";
            this.rbStraightLineDep.Size = new System.Drawing.Size(203, 24);
            this.rbStraightLineDep.TabIndex = 0;
            this.rbStraightLineDep.TabStop = true;
            this.rbStraightLineDep.Text = "Straight Line Depreciation";
            this.rbStraightLineDep.UseVisualStyleBackColor = true;
            // 
            // dtpDateOut
            // 
            this.dtpDateOut.Location = new System.Drawing.Point(517, 277);
            this.dtpDateOut.Name = "dtpDateOut";
            this.dtpDateOut.Size = new System.Drawing.Size(250, 27);
            this.dtpDateOut.TabIndex = 12;
            // 
            // dtpDateIn
            // 
            this.dtpDateIn.Location = new System.Drawing.Point(517, 234);
            this.dtpDateIn.Name = "dtpDateIn";
            this.dtpDateIn.Size = new System.Drawing.Size(250, 27);
            this.dtpDateIn.TabIndex = 11;
            // 
            // tbLifetime
            // 
            this.tbLifetime.Location = new System.Drawing.Point(517, 191);
            this.tbLifetime.Name = "tbLifetime";
            this.tbLifetime.Size = new System.Drawing.Size(125, 27);
            this.tbLifetime.TabIndex = 10;
            // 
            // tbEndingValue
            // 
            this.tbEndingValue.Location = new System.Drawing.Point(520, 148);
            this.tbEndingValue.Name = "tbEndingValue";
            this.tbEndingValue.Size = new System.Drawing.Size(125, 27);
            this.tbEndingValue.TabIndex = 9;
            // 
            // tbStartValue
            // 
            this.tbStartValue.Location = new System.Drawing.Point(519, 105);
            this.tbStartValue.Name = "tbStartValue";
            this.tbStartValue.Size = new System.Drawing.Size(125, 27);
            this.tbStartValue.TabIndex = 8;
            // 
            // tbItem
            // 
            this.tbItem.Location = new System.Drawing.Point(518, 62);
            this.tbItem.Name = "tbItem";
            this.tbItem.Size = new System.Drawing.Size(125, 27);
            this.tbItem.TabIndex = 7;
            // 
            // lblDateOutInventory
            // 
            this.lblDateOutInventory.AutoSize = true;
            this.lblDateOutInventory.Location = new System.Drawing.Point(368, 280);
            this.lblDateOutInventory.Name = "lblDateOutInventory";
            this.lblDateOutInventory.Size = new System.Drawing.Size(153, 20);
            this.lblDateOutInventory.TabIndex = 6;
            this.lblDateOutInventory.Text = "Date out of Inventory:";
            // 
            // lblDateInInventory
            // 
            this.lblDateInInventory.AutoSize = true;
            this.lblDateInInventory.Location = new System.Drawing.Point(368, 237);
            this.lblDateInInventory.Name = "lblDateInInventory";
            this.lblDateInInventory.Size = new System.Drawing.Size(125, 20);
            this.lblDateInInventory.TabIndex = 5;
            this.lblDateInInventory.Text = "Date in Inventory:";
            // 
            // lblLifetime
            // 
            this.lblLifetime.AutoSize = true;
            this.lblLifetime.Location = new System.Drawing.Point(368, 194);
            this.lblLifetime.Name = "lblLifetime";
            this.lblLifetime.Size = new System.Drawing.Size(114, 20);
            this.lblLifetime.TabIndex = 4;
            this.lblLifetime.Text = "Lifetime (years):";
            // 
            // lblEndValue
            // 
            this.lblEndValue.AutoSize = true;
            this.lblEndValue.Location = new System.Drawing.Point(368, 151);
            this.lblEndValue.Name = "lblEndValue";
            this.lblEndValue.Size = new System.Drawing.Size(110, 20);
            this.lblEndValue.TabIndex = 3;
            this.lblEndValue.Text = "Ending Value $:";
            // 
            // lblStartValue
            // 
            this.lblStartValue.AutoSize = true;
            this.lblStartValue.Location = new System.Drawing.Point(368, 108);
            this.lblStartValue.Name = "lblStartValue";
            this.lblStartValue.Size = new System.Drawing.Size(116, 20);
            this.lblStartValue.TabIndex = 2;
            this.lblStartValue.Text = "Starting Value $:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(368, 65);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(107, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Inventory Item:";
            // 
            // lbInventory
            // 
            this.lbInventory.FormattingEnabled = true;
            this.lbInventory.HorizontalScrollbar = true;
            this.lbInventory.ItemHeight = 20;
            this.lbInventory.Location = new System.Drawing.Point(56, 57);
            this.lbInventory.Name = "lbInventory";
            this.lbInventory.ScrollAlwaysVisible = true;
            this.lbInventory.Size = new System.Drawing.Size(245, 264);
            this.lbInventory.TabIndex = 0;
            this.lbInventory.SelectedIndexChanged += new System.EventHandler(this.lbInventory_SelectedIndexChanged);
            // 
            // tabSummary
            // 
            this.tabSummary.Controls.Add(this.tbSummary);
            this.tabSummary.Controls.Add(this.btnSummary);
            this.tabSummary.Location = new System.Drawing.Point(4, 29);
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSummary.Size = new System.Drawing.Size(841, 490);
            this.tabSummary.TabIndex = 2;
            this.tabSummary.Text = "Summary";
            this.tabSummary.UseVisualStyleBackColor = true;
            // 
            // tbSummary
            // 
            this.tbSummary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSummary.Location = new System.Drawing.Point(149, 298);
            this.tbSummary.Multiline = true;
            this.tbSummary.Name = "tbSummary";
            this.tbSummary.ReadOnly = true;
            this.tbSummary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSummary.Size = new System.Drawing.Size(505, 146);
            this.tbSummary.TabIndex = 1;
            this.tbSummary.TextChanged += new System.EventHandler(this.tbSummary_TextChanged);
            // 
            // btnSummary
            // 
            this.btnSummary.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSummary.Location = new System.Drawing.Point(177, 134);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(452, 46);
            this.btnSummary.TabIndex = 0;
            this.btnSummary.Text = "Calculate Yearly Depreciation Value";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 578);
            this.Controls.Add(this.tabsProgram);
            this.Name = "Form1";
            this.Text = "Erica Slotkin - Super Depreciation Calculation 3000";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabsProgram.ResumeLayout(false);
            this.tabInstructions.ResumeLayout(false);
            this.tabInstructions.PerformLayout();
            this.tabInventory.ResumeLayout(false);
            this.tabInventory.PerformLayout();
            this.gbDepMethod.ResumeLayout(false);
            this.gbDepMethod.PerformLayout();
            this.tabSummary.ResumeLayout(false);
            this.tabSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsProgram;
        private System.Windows.Forms.TabPage tabInstructions;
        private System.Windows.Forms.TextBox tbInstructions;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.TabPage tabSummary;
        private System.Windows.Forms.TextBox tbSummary;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Label lblDateOutInventory;
        private System.Windows.Forms.Label lblDateInInventory;
        private System.Windows.Forms.Label lblLifetime;
        private System.Windows.Forms.Label lblEndValue;
        private System.Windows.Forms.Label lblStartValue;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dtpDateOut;
        private System.Windows.Forms.DateTimePicker dtpDateIn;
        private System.Windows.Forms.TextBox tbLifetime;
        private System.Windows.Forms.TextBox tbEndingValue;
        private System.Windows.Forms.TextBox tbStartValue;
        private System.Windows.Forms.TextBox tbItem;
        private System.Windows.Forms.GroupBox gbDepMethod;
        private System.Windows.Forms.RadioButton rbDoubleDeclineDep;
        private System.Windows.Forms.RadioButton rbStraightLineDep;
        private System.Windows.Forms.Button btnRemove;
        public System.Windows.Forms.Button btnAddToInventory;
        private System.Windows.Forms.ListBox lbInventory;
        private System.Windows.Forms.Label lblSelectMethod;
    }
}

