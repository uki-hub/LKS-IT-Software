namespace C3
{
    partial class OrderForm
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
            this.PicMenu = new System.Windows.Forms.PictureBox();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TableMenu = new System.Windows.Forms.DataGridView();
            this.InputPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.InputQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InputMenuName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TableOrder = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // PicMenu
            // 
            this.PicMenu.BackColor = System.Drawing.Color.White;
            this.PicMenu.Location = new System.Drawing.Point(12, 250);
            this.PicMenu.Name = "PicMenu";
            this.PicMenu.Size = new System.Drawing.Size(227, 126);
            this.PicMenu.TabIndex = 47;
            this.PicMenu.TabStop = false;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(254, 350);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(92, 26);
            this.BtnInsert.TabIndex = 43;
            this.BtnInsert.Text = "Add";
            this.BtnInsert.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Form Order";
            // 
            // TableMenu
            // 
            this.TableMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableMenu.Location = new System.Drawing.Point(3, 48);
            this.TableMenu.Name = "TableMenu";
            this.TableMenu.Size = new System.Drawing.Size(633, 183);
            this.TableMenu.TabIndex = 33;
            // 
            // InputPrice
            // 
            this.InputPrice.Location = new System.Drawing.Point(328, 321);
            this.InputPrice.Name = "InputPrice";
            this.InputPrice.Size = new System.Drawing.Size(209, 20);
            this.InputPrice.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Price";
            // 
            // InputQty
            // 
            this.InputQty.Location = new System.Drawing.Point(328, 285);
            this.InputQty.Name = "InputQty";
            this.InputQty.Size = new System.Drawing.Size(209, 20);
            this.InputQty.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Qty";
            // 
            // InputMenuName
            // 
            this.InputMenuName.Location = new System.Drawing.Point(328, 250);
            this.InputMenuName.Name = "InputMenuName";
            this.InputMenuName.Size = new System.Drawing.Size(209, 20);
            this.InputMenuName.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Menu Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 26);
            this.button1.TabIndex = 54;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TableOrder
            // 
            this.TableOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableOrder.Location = new System.Drawing.Point(3, 395);
            this.TableOrder.Name = "TableOrder";
            this.TableOrder.Size = new System.Drawing.Size(633, 183);
            this.TableOrder.TabIndex = 55;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 584);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 26);
            this.button2.TabIndex = 56;
            this.button2.Text = "Order";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 591);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Total: ###";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 632);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TableOrder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InputQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputMenuName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicMenu);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TableMenu);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.PicMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicMenu;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TableMenu;
        private System.Windows.Forms.TextBox InputPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InputQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputMenuName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView TableOrder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}