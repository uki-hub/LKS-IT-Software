namespace LKS.views.Chef
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
            this.LabelTotal = new System.Windows.Forms.Label();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.TableOrder = new System.Windows.Forms.DataGridView();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.InputPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.InputQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InputMenuName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TableMenu = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Location = new System.Drawing.Point(492, 718);
            this.LabelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(72, 17);
            this.LabelTotal.TabIndex = 71;
            this.LabelTotal.Text = "Total: ###";
            // 
            // BtnOrder
            // 
            this.BtnOrder.Location = new System.Drawing.Point(348, 710);
            this.BtnOrder.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(123, 32);
            this.BtnOrder.TabIndex = 70;
            this.BtnOrder.Text = "Order";
            this.BtnOrder.UseVisualStyleBackColor = true;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // TableOrder
            // 
            this.TableOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableOrder.Location = new System.Drawing.Point(13, 477);
            this.TableOrder.Margin = new System.Windows.Forms.Padding(4);
            this.TableOrder.Name = "TableOrder";
            this.TableOrder.ReadOnly = true;
            this.TableOrder.RowHeadersWidth = 51;
            this.TableOrder.Size = new System.Drawing.Size(844, 225);
            this.TableOrder.TabIndex = 69;
            this.TableOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableOrder_CellClick);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(389, 419);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(123, 32);
            this.BtnDelete.TabIndex = 68;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // InputPrice
            // 
            this.InputPrice.Enabled = false;
            this.InputPrice.Location = new System.Drawing.Point(339, 383);
            this.InputPrice.Margin = new System.Windows.Forms.Padding(4);
            this.InputPrice.Name = "InputPrice";
            this.InputPrice.Size = new System.Drawing.Size(277, 22);
            this.InputPrice.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 387);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 66;
            this.label5.Text = "Price";
            // 
            // InputQty
            // 
            this.InputQty.Location = new System.Drawing.Point(339, 339);
            this.InputQty.Margin = new System.Windows.Forms.Padding(4);
            this.InputQty.Name = "InputQty";
            this.InputQty.Size = new System.Drawing.Size(277, 22);
            this.InputQty.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 342);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "Qty";
            // 
            // InputMenuName
            // 
            this.InputMenuName.Enabled = false;
            this.InputMenuName.Location = new System.Drawing.Point(339, 296);
            this.InputMenuName.Margin = new System.Windows.Forms.Padding(4);
            this.InputMenuName.Name = "InputMenuName";
            this.InputMenuName.Size = new System.Drawing.Size(277, 22);
            this.InputMenuName.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 299);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "Menu Name";
            // 
            // Photo
            // 
            this.Photo.BackColor = System.Drawing.Color.White;
            this.Photo.Location = new System.Drawing.Point(25, 299);
            this.Photo.Margin = new System.Windows.Forms.Padding(4);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(193, 155);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Photo.TabIndex = 61;
            this.Photo.TabStop = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(241, 419);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(123, 32);
            this.BtnAdd.TabIndex = 60;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 59;
            this.label2.Text = "Form Order";
            // 
            // TableMenu
            // 
            this.TableMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableMenu.Location = new System.Drawing.Point(13, 50);
            this.TableMenu.Margin = new System.Windows.Forms.Padding(4);
            this.TableMenu.Name = "TableMenu";
            this.TableMenu.ReadOnly = true;
            this.TableMenu.RowHeadersWidth = 51;
            this.TableMenu.Size = new System.Drawing.Size(844, 225);
            this.TableMenu.TabIndex = 58;
            this.TableMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableMenu_CellClick);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(13, 6);
            this.back.Margin = new System.Windows.Forms.Padding(4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(61, 36);
            this.back.TabIndex = 72;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 759);
            this.Controls.Add(this.back);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.BtnOrder);
            this.Controls.Add(this.TableOrder);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.InputPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InputQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputMenuName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TableMenu);
            this.Name = "OrderForm";
            this.Text = "ViewOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.TableOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.DataGridView TableOrder;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox InputPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InputQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputMenuName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TableMenu;
        private System.Windows.Forms.Button back;
    }
}