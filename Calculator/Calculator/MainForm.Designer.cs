namespace Calculator
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
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnMemoryClear = new System.Windows.Forms.Button();
            this.btnMemoryRecall = new System.Windows.Forms.Button();
            this.btnMemoryAdd = new System.Windows.Forms.Button();
            this.btnMemorySubtract = new System.Windows.Forms.Button();
            this.btnMemoryStore = new System.Windows.Forms.Button();
            this.lblMemory = new System.Windows.Forms.Label();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnChangeSign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResults
            // 
            this.txtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(13, 13);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(291, 37);
            this.txtResults.TabIndex = 0;
            this.txtResults.TabStop = false;
            this.txtResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBackspace
            // 
            this.btnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackspace.Location = new System.Drawing.Point(51, 90);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(48, 48);
            this.btnBackspace.TabIndex = 1;
            this.btnBackspace.TabStop = false;
            this.btnBackspace.Text = "<";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnMemoryClear
            // 
            this.btnMemoryClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryClear.Location = new System.Drawing.Point(12, 54);
            this.btnMemoryClear.Margin = new System.Windows.Forms.Padding(1);
            this.btnMemoryClear.Name = "btnMemoryClear";
            this.btnMemoryClear.Size = new System.Drawing.Size(32, 27);
            this.btnMemoryClear.TabIndex = 2;
            this.btnMemoryClear.TabStop = false;
            this.btnMemoryClear.Text = "MC";
            this.btnMemoryClear.UseVisualStyleBackColor = true;
            this.btnMemoryClear.Click += new System.EventHandler(this.btnMemoryClear_Click);
            // 
            // btnMemoryRecall
            // 
            this.btnMemoryRecall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryRecall.Location = new System.Drawing.Point(46, 54);
            this.btnMemoryRecall.Margin = new System.Windows.Forms.Padding(1);
            this.btnMemoryRecall.Name = "btnMemoryRecall";
            this.btnMemoryRecall.Size = new System.Drawing.Size(32, 27);
            this.btnMemoryRecall.TabIndex = 3;
            this.btnMemoryRecall.TabStop = false;
            this.btnMemoryRecall.Text = "MR";
            this.btnMemoryRecall.UseVisualStyleBackColor = true;
            this.btnMemoryRecall.Click += new System.EventHandler(this.btnMemoryRecall_Click);
            // 
            // btnMemoryAdd
            // 
            this.btnMemoryAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryAdd.Location = new System.Drawing.Point(80, 54);
            this.btnMemoryAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btnMemoryAdd.Name = "btnMemoryAdd";
            this.btnMemoryAdd.Size = new System.Drawing.Size(32, 27);
            this.btnMemoryAdd.TabIndex = 4;
            this.btnMemoryAdd.TabStop = false;
            this.btnMemoryAdd.Text = "M+";
            this.btnMemoryAdd.UseVisualStyleBackColor = true;
            this.btnMemoryAdd.Click += new System.EventHandler(this.btnMemoryAdd_Click);
            // 
            // btnMemorySubtract
            // 
            this.btnMemorySubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemorySubtract.Location = new System.Drawing.Point(114, 54);
            this.btnMemorySubtract.Margin = new System.Windows.Forms.Padding(1);
            this.btnMemorySubtract.Name = "btnMemorySubtract";
            this.btnMemorySubtract.Size = new System.Drawing.Size(32, 27);
            this.btnMemorySubtract.TabIndex = 5;
            this.btnMemorySubtract.TabStop = false;
            this.btnMemorySubtract.Text = "M-";
            this.btnMemorySubtract.UseVisualStyleBackColor = true;
            this.btnMemorySubtract.Click += new System.EventHandler(this.btnMemorySubtract_Click);
            // 
            // btnMemoryStore
            // 
            this.btnMemoryStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryStore.Location = new System.Drawing.Point(148, 54);
            this.btnMemoryStore.Margin = new System.Windows.Forms.Padding(1);
            this.btnMemoryStore.Name = "btnMemoryStore";
            this.btnMemoryStore.Size = new System.Drawing.Size(32, 27);
            this.btnMemoryStore.TabIndex = 6;
            this.btnMemoryStore.TabStop = false;
            this.btnMemoryStore.Text = "MS";
            this.btnMemoryStore.UseVisualStyleBackColor = true;
            this.btnMemoryStore.Click += new System.EventHandler(this.btnMemoryStore_Click);
            // 
            // lblMemory
            // 
            this.lblMemory.BackColor = System.Drawing.SystemColors.Window;
            this.lblMemory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMemory.Location = new System.Drawing.Point(182, 54);
            this.lblMemory.Margin = new System.Windows.Forms.Padding(1);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(121, 27);
            this.lblMemory.TabIndex = 7;
            this.lblMemory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEntry.Location = new System.Drawing.Point(105, 90);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(48, 48);
            this.btnClearEntry.TabIndex = 8;
            this.btnClearEntry.TabStop = false;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(159, 90);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(48, 48);
            this.btnClear.TabIndex = 9;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(213, 90);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(48, 48);
            this.btnDivide.TabIndex = 10;
            this.btnDivide.TabStop = false;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(213, 144);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(48, 48);
            this.btnMultiply.TabIndex = 14;
            this.btnMultiply.TabStop = false;
            this.btnMultiply.Text = "X";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnNine
            // 
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(159, 144);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(48, 48);
            this.btnNine.TabIndex = 13;
            this.btnNine.TabStop = false;
            this.btnNine.Text = "&9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnEight
            // 
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(105, 144);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(48, 48);
            this.btnEight.TabIndex = 12;
            this.btnEight.TabStop = false;
            this.btnEight.Text = "&8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(51, 144);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(48, 48);
            this.btnSeven.TabIndex = 11;
            this.btnSeven.TabStop = false;
            this.btnSeven.Text = "&7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(213, 198);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(48, 48);
            this.btnSubtract.TabIndex = 18;
            this.btnSubtract.TabStop = false;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnSix
            // 
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(159, 198);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(48, 48);
            this.btnSix.TabIndex = 17;
            this.btnSix.TabStop = false;
            this.btnSix.Text = "&6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnFive
            // 
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(105, 198);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(48, 48);
            this.btnFive.TabIndex = 16;
            this.btnFive.TabStop = false;
            this.btnFive.Text = "&5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnFour
            // 
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(51, 198);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(48, 48);
            this.btnFour.TabIndex = 15;
            this.btnFour.TabStop = false;
            this.btnFour.Text = "&4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(213, 252);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 48);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnThree
            // 
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(159, 252);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(48, 48);
            this.btnThree.TabIndex = 21;
            this.btnThree.TabStop = false;
            this.btnThree.Text = "&3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(105, 252);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(48, 48);
            this.btnTwo.TabIndex = 20;
            this.btnTwo.TabStop = false;
            this.btnTwo.Text = "&2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnOne
            // 
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(51, 252);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(48, 48);
            this.btnOne.TabIndex = 19;
            this.btnOne.TabStop = false;
            this.btnOne.Text = "&1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(213, 306);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(48, 48);
            this.btnEquals.TabIndex = 26;
            this.btnEquals.TabStop = false;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(159, 306);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(48, 48);
            this.btnDecimal.TabIndex = 25;
            this.btnDecimal.TabStop = false;
            this.btnDecimal.Text = "&.";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(105, 306);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(48, 48);
            this.btnZero.TabIndex = 24;
            this.btnZero.TabStop = false;
            this.btnZero.Text = "&0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnChangeSign
            // 
            this.btnChangeSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeSign.Location = new System.Drawing.Point(51, 306);
            this.btnChangeSign.Name = "btnChangeSign";
            this.btnChangeSign.Size = new System.Drawing.Size(48, 48);
            this.btnChangeSign.TabIndex = 23;
            this.btnChangeSign.TabStop = false;
            this.btnChangeSign.Text = "+-";
            this.btnChangeSign.UseVisualStyleBackColor = true;
            this.btnChangeSign.Click += new System.EventHandler(this.btnChangeSign_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 356);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnChangeSign);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.lblMemory);
            this.Controls.Add(this.btnMemoryStore);
            this.Controls.Add(this.btnMemorySubtract);
            this.Controls.Add(this.btnMemoryAdd);
            this.Controls.Add(this.btnMemoryRecall);
            this.Controls.Add(this.btnMemoryClear);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.txtResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnMemoryClear;
        private System.Windows.Forms.Button btnMemoryRecall;
        private System.Windows.Forms.Button btnMemoryAdd;
        private System.Windows.Forms.Button btnMemorySubtract;
        private System.Windows.Forms.Button btnMemoryStore;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnChangeSign;
    }
}

