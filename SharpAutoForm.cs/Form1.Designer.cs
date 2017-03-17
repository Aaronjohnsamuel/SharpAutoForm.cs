namespace SharpAutoForm.cs
{
    partial class SharpAutoForm
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
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtAdditionalOptions = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtSalesTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTradeInAllowance = new System.Windows.Forms.TextBox();
            this.txtAmountDue = new System.Windows.Forms.TextBox();
            this.basePrice = new System.Windows.Forms.Label();
            this.addOptions = new System.Windows.Forms.Label();
            this.subTotal = new System.Windows.Forms.Label();
            this.salesTax = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.tradeInAllowance = new System.Windows.Forms.Label();
            this.amountDue = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.addItems = new System.Windows.Forms.GroupBox();
            this.checkboxComputerNavigation = new System.Windows.Forms.CheckBox();
            this.checkboxLeatherInterior = new System.Windows.Forms.CheckBox();
            this.checkboxStereoSystem = new System.Windows.Forms.CheckBox();
            this.exteriorFinish = new System.Windows.Forms.GroupBox();
            this.rdoCustomizedDetailing = new System.Windows.Forms.RadioButton();
            this.rdoPearlized = new System.Windows.Forms.RadioButton();
            this.rdoStandard = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItems.SuspendLayout();
            this.exteriorFinish.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(138, 48);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(100, 20);
            this.txtBasePrice.TabIndex = 0;
            this.txtBasePrice.Text = "0";
            // 
            // txtAdditionalOptions
            // 
            this.txtAdditionalOptions.Location = new System.Drawing.Point(138, 86);
            this.txtAdditionalOptions.Name = "txtAdditionalOptions";
            this.txtAdditionalOptions.ReadOnly = true;
            this.txtAdditionalOptions.Size = new System.Drawing.Size(100, 20);
            this.txtAdditionalOptions.TabIndex = 1;
            this.txtAdditionalOptions.Text = "0";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(138, 112);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubTotal.TabIndex = 2;
            // 
            // txtSalesTax
            // 
            this.txtSalesTax.Location = new System.Drawing.Point(138, 138);
            this.txtSalesTax.Name = "txtSalesTax";
            this.txtSalesTax.ReadOnly = true;
            this.txtSalesTax.Size = new System.Drawing.Size(100, 20);
            this.txtSalesTax.TabIndex = 3;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(138, 164);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 4;
            // 
            // txtTradeInAllowance
            // 
            this.txtTradeInAllowance.Location = new System.Drawing.Point(138, 190);
            this.txtTradeInAllowance.Name = "txtTradeInAllowance";
            this.txtTradeInAllowance.Size = new System.Drawing.Size(100, 20);
            this.txtTradeInAllowance.TabIndex = 5;
            this.txtTradeInAllowance.Text = "0";
            // 
            // txtAmountDue
            // 
            this.txtAmountDue.Location = new System.Drawing.Point(138, 216);
            this.txtAmountDue.Name = "txtAmountDue";
            this.txtAmountDue.ReadOnly = true;
            this.txtAmountDue.Size = new System.Drawing.Size(100, 20);
            this.txtAmountDue.TabIndex = 6;
            this.txtAmountDue.Text = "0";
            // 
            // basePrice
            // 
            this.basePrice.AutoSize = true;
            this.basePrice.Location = new System.Drawing.Point(71, 55);
            this.basePrice.Name = "basePrice";
            this.basePrice.Size = new System.Drawing.Size(61, 13);
            this.basePrice.TabIndex = 7;
            this.basePrice.Text = "Base Price:";
            // 
            // addOptions
            // 
            this.addOptions.AutoSize = true;
            this.addOptions.Location = new System.Drawing.Point(37, 93);
            this.addOptions.Name = "addOptions";
            this.addOptions.Size = new System.Drawing.Size(95, 13);
            this.addOptions.TabIndex = 8;
            this.addOptions.Text = "Additional Options:";
            // 
            // subTotal
            // 
            this.subTotal.AutoSize = true;
            this.subTotal.Location = new System.Drawing.Point(76, 119);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(56, 13);
            this.subTotal.TabIndex = 9;
            this.subTotal.Text = "Sub Total:";
            // 
            // salesTax
            // 
            this.salesTax.AutoSize = true;
            this.salesTax.Location = new System.Drawing.Point(75, 145);
            this.salesTax.Name = "salesTax";
            this.salesTax.Size = new System.Drawing.Size(57, 13);
            this.salesTax.TabIndex = 10;
            this.salesTax.Text = "Sales Tax:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(98, 171);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(34, 13);
            this.total.TabIndex = 11;
            this.total.Text = "Total:";
            // 
            // tradeInAllowance
            // 
            this.tradeInAllowance.AutoSize = true;
            this.tradeInAllowance.Location = new System.Drawing.Point(30, 197);
            this.tradeInAllowance.Name = "tradeInAllowance";
            this.tradeInAllowance.Size = new System.Drawing.Size(102, 13);
            this.tradeInAllowance.TabIndex = 12;
            this.tradeInAllowance.Text = "Trade-In Allowance:";
            // 
            // amountDue
            // 
            this.amountDue.AutoSize = true;
            this.amountDue.Location = new System.Drawing.Point(63, 223);
            this.amountDue.Name = "amountDue";
            this.amountDue.Size = new System.Drawing.Size(69, 13);
            this.amountDue.TabIndex = 13;
            this.amountDue.Text = "Amount Due:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(33, 321);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(186, 320);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(333, 320);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // addItems
            // 
            this.addItems.Controls.Add(this.checkboxComputerNavigation);
            this.addItems.Controls.Add(this.checkboxLeatherInterior);
            this.addItems.Controls.Add(this.checkboxStereoSystem);
            this.addItems.Location = new System.Drawing.Point(260, 48);
            this.addItems.Name = "addItems";
            this.addItems.Size = new System.Drawing.Size(164, 110);
            this.addItems.TabIndex = 17;
            this.addItems.TabStop = false;
            this.addItems.Text = "Additional Items";
            // 
            // checkboxComputerNavigation
            // 
            this.checkboxComputerNavigation.AutoSize = true;
            this.checkboxComputerNavigation.Location = new System.Drawing.Point(15, 77);
            this.checkboxComputerNavigation.Name = "checkboxComputerNavigation";
            this.checkboxComputerNavigation.Size = new System.Drawing.Size(125, 17);
            this.checkboxComputerNavigation.TabIndex = 2;
            this.checkboxComputerNavigation.Text = "Computer Navigation";
            this.checkboxComputerNavigation.UseVisualStyleBackColor = true;
            this.checkboxComputerNavigation.CheckedChanged += new System.EventHandler(this.checkboxComputerNavigation_CheckedChanged);
            // 
            // checkboxLeatherInterior
            // 
            this.checkboxLeatherInterior.AutoSize = true;
            this.checkboxLeatherInterior.Location = new System.Drawing.Point(15, 53);
            this.checkboxLeatherInterior.Name = "checkboxLeatherInterior";
            this.checkboxLeatherInterior.Size = new System.Drawing.Size(97, 17);
            this.checkboxLeatherInterior.TabIndex = 1;
            this.checkboxLeatherInterior.Text = "Leather Interior";
            this.checkboxLeatherInterior.UseVisualStyleBackColor = true;
            this.checkboxLeatherInterior.CheckedChanged += new System.EventHandler(this.checkboxLeatherInterior_CheckedChanged);
            // 
            // checkboxStereoSystem
            // 
            this.checkboxStereoSystem.AutoSize = true;
            this.checkboxStereoSystem.Location = new System.Drawing.Point(15, 29);
            this.checkboxStereoSystem.Name = "checkboxStereoSystem";
            this.checkboxStereoSystem.Size = new System.Drawing.Size(94, 17);
            this.checkboxStereoSystem.TabIndex = 0;
            this.checkboxStereoSystem.Text = "Stereo System";
            this.checkboxStereoSystem.UseVisualStyleBackColor = true;
            this.checkboxStereoSystem.CheckedChanged += new System.EventHandler(this.checkboxStereoSystem_CheckedChanged);
            // 
            // exteriorFinish
            // 
            this.exteriorFinish.Controls.Add(this.rdoCustomizedDetailing);
            this.exteriorFinish.Controls.Add(this.rdoPearlized);
            this.exteriorFinish.Controls.Add(this.rdoStandard);
            this.exteriorFinish.Location = new System.Drawing.Point(260, 180);
            this.exteriorFinish.Name = "exteriorFinish";
            this.exteriorFinish.Size = new System.Drawing.Size(164, 116);
            this.exteriorFinish.TabIndex = 18;
            this.exteriorFinish.TabStop = false;
            this.exteriorFinish.Text = "Exterior Finish";
            // 
            // rdoCustomizedDetailing
            // 
            this.rdoCustomizedDetailing.AutoSize = true;
            this.rdoCustomizedDetailing.Location = new System.Drawing.Point(15, 80);
            this.rdoCustomizedDetailing.Name = "rdoCustomizedDetailing";
            this.rdoCustomizedDetailing.Size = new System.Drawing.Size(123, 17);
            this.rdoCustomizedDetailing.TabIndex = 2;
            this.rdoCustomizedDetailing.Text = "Customized Detailing";
            this.rdoCustomizedDetailing.UseVisualStyleBackColor = true;
            this.rdoCustomizedDetailing.CheckedChanged += new System.EventHandler(this.rdoCustomizedDetailing_CheckedChanged);
            // 
            // rdoPearlized
            // 
            this.rdoPearlized.AutoSize = true;
            this.rdoPearlized.Location = new System.Drawing.Point(15, 56);
            this.rdoPearlized.Name = "rdoPearlized";
            this.rdoPearlized.Size = new System.Drawing.Size(68, 17);
            this.rdoPearlized.TabIndex = 1;
            this.rdoPearlized.Text = "Pearlized";
            this.rdoPearlized.UseVisualStyleBackColor = true;
            this.rdoPearlized.CheckedChanged += new System.EventHandler(this.rdoPearlized_CheckedChanged);
            // 
            // rdoStandard
            // 
            this.rdoStandard.AutoSize = true;
            this.rdoStandard.Checked = true;
            this.rdoStandard.Location = new System.Drawing.Point(15, 32);
            this.rdoStandard.Name = "rdoStandard";
            this.rdoStandard.Size = new System.Drawing.Size(68, 17);
            this.rdoStandard.TabIndex = 0;
            this.rdoStandard.TabStop = true;
            this.rdoStandard.Text = "Standard";
            this.rdoStandard.UseVisualStyleBackColor = true;
            this.rdoStandard.CheckedChanged += new System.EventHandler(this.rdoStandard_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(446, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caculateToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // caculateToolStripMenuItem
            // 
            this.caculateToolStripMenuItem.Name = "caculateToolStripMenuItem";
            this.caculateToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.caculateToolStripMenuItem.Text = "Caculate";
            this.caculateToolStripMenuItem.Click += new System.EventHandler(this.caculateToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SharpAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 356);
            this.Controls.Add(this.exteriorFinish);
            this.Controls.Add(this.addItems);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.amountDue);
            this.Controls.Add(this.tradeInAllowance);
            this.Controls.Add(this.total);
            this.Controls.Add(this.salesTax);
            this.Controls.Add(this.subTotal);
            this.Controls.Add(this.addOptions);
            this.Controls.Add(this.basePrice);
            this.Controls.Add(this.txtAmountDue);
            this.Controls.Add(this.txtTradeInAllowance);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSalesTax);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtAdditionalOptions);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SharpAutoForm";
            this.Text = "Auto Centre";
            this.addItems.ResumeLayout(false);
            this.addItems.PerformLayout();
            this.exteriorFinish.ResumeLayout(false);
            this.exteriorFinish.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.TextBox txtAdditionalOptions;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTradeInAllowance;
        private System.Windows.Forms.TextBox txtAmountDue;
        private System.Windows.Forms.Label basePrice;
        private System.Windows.Forms.Label addOptions;
        private System.Windows.Forms.Label subTotal;
        private System.Windows.Forms.Label salesTax;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label tradeInAllowance;
        private System.Windows.Forms.Label amountDue;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox addItems;
        private System.Windows.Forms.CheckBox checkboxComputerNavigation;
        private System.Windows.Forms.CheckBox checkboxLeatherInterior;
        private System.Windows.Forms.CheckBox checkboxStereoSystem;
        private System.Windows.Forms.GroupBox exteriorFinish;
        private System.Windows.Forms.RadioButton rdoCustomizedDetailing;
        private System.Windows.Forms.RadioButton rdoPearlized;
        private System.Windows.Forms.RadioButton rdoStandard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

