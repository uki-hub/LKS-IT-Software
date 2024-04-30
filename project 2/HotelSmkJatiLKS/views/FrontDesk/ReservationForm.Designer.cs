namespace HotelSmkJatiLKS.views.FrontDesk
{
    partial class ReservationForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAddNewCustomer = new System.Windows.Forms.Button();
            this.customerAddNewGroup = new System.Windows.Forms.GroupBox();
            this.InpCustomerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.InpCustomerGender = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.InpCustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.InpCustomerEmail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.InpCustomerNIK = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.InpCustomerName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TableCustomer = new System.Windows.Forms.DataGridView();
            this.labelSearchCustomer = new System.Windows.Forms.Label();
            this.InpSearchCustomer = new System.Windows.Forms.TextBox();
            this.RadioSearch = new System.Windows.Forms.RadioButton();
            this.RadioAddNew = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InpStaying = new System.Windows.Forms.TextBox();
            this.InpCheckout = new System.Windows.Forms.DateTimePicker();
            this.InpCheckin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.InpRoomType = new System.Windows.Forms.ComboBox();
            this.BtnRoomTypeSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TableAvailableRoom = new System.Windows.Forms.DataGridView();
            this.TableSelectedRoom = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnAddRoom = new System.Windows.Forms.Button();
            this.BtnRemoveRoom = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnItemAdd = new System.Windows.Forms.Button();
            this.TableItem = new System.Windows.Forms.DataGridView();
            this.InpSubTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.InpPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.InpQty = new System.Windows.Forms.NumericUpDown();
            this.InpItem = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.customerAddNewGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableCustomer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableAvailableRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSelectedRoom)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InpQty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAddNewCustomer);
            this.groupBox1.Controls.Add(this.customerAddNewGroup);
            this.groupBox1.Controls.Add(this.TableCustomer);
            this.groupBox1.Controls.Add(this.labelSearchCustomer);
            this.groupBox1.Controls.Add(this.InpSearchCustomer);
            this.groupBox1.Controls.Add(this.RadioSearch);
            this.groupBox1.Controls.Add(this.RadioAddNew);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // BtnAddNewCustomer
            // 
            this.BtnAddNewCustomer.Location = new System.Drawing.Point(333, 32);
            this.BtnAddNewCustomer.Name = "BtnAddNewCustomer";
            this.BtnAddNewCustomer.Size = new System.Drawing.Size(121, 23);
            this.BtnAddNewCustomer.TabIndex = 6;
            this.BtnAddNewCustomer.Text = "Add Customer";
            this.BtnAddNewCustomer.UseVisualStyleBackColor = true;
            this.BtnAddNewCustomer.Visible = false;
            this.BtnAddNewCustomer.Click += new System.EventHandler(this.BtnAddNewCustomer_Click);
            // 
            // customerAddNewGroup
            // 
            this.customerAddNewGroup.Controls.Add(this.InpCustomerDateOfBirth);
            this.customerAddNewGroup.Controls.Add(this.InpCustomerGender);
            this.customerAddNewGroup.Controls.Add(this.label18);
            this.customerAddNewGroup.Controls.Add(this.InpCustomerPhoneNumber);
            this.customerAddNewGroup.Controls.Add(this.label17);
            this.customerAddNewGroup.Controls.Add(this.label16);
            this.customerAddNewGroup.Controls.Add(this.InpCustomerEmail);
            this.customerAddNewGroup.Controls.Add(this.label15);
            this.customerAddNewGroup.Controls.Add(this.InpCustomerNIK);
            this.customerAddNewGroup.Controls.Add(this.label14);
            this.customerAddNewGroup.Controls.Add(this.InpCustomerName);
            this.customerAddNewGroup.Controls.Add(this.label13);
            this.customerAddNewGroup.Location = new System.Drawing.Point(12, 58);
            this.customerAddNewGroup.Name = "customerAddNewGroup";
            this.customerAddNewGroup.Size = new System.Drawing.Size(455, 199);
            this.customerAddNewGroup.TabIndex = 5;
            this.customerAddNewGroup.TabStop = false;
            this.customerAddNewGroup.Visible = false;
            // 
            // InpCustomerDateOfBirth
            // 
            this.InpCustomerDateOfBirth.Location = new System.Drawing.Point(128, 165);
            this.InpCustomerDateOfBirth.Name = "InpCustomerDateOfBirth";
            this.InpCustomerDateOfBirth.Size = new System.Drawing.Size(314, 22);
            this.InpCustomerDateOfBirth.TabIndex = 19;
            // 
            // InpCustomerGender
            // 
            this.InpCustomerGender.FormattingEnabled = true;
            this.InpCustomerGender.Location = new System.Drawing.Point(127, 105);
            this.InpCustomerGender.Name = "InpCustomerGender";
            this.InpCustomerGender.Size = new System.Drawing.Size(315, 24);
            this.InpCustomerGender.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(35, 165);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 17);
            this.label18.TabIndex = 16;
            this.label18.Text = "Date of Birth";
            // 
            // InpCustomerPhoneNumber
            // 
            this.InpCustomerPhoneNumber.Location = new System.Drawing.Point(127, 134);
            this.InpCustomerPhoneNumber.Name = "InpCustomerPhoneNumber";
            this.InpCustomerPhoneNumber.Size = new System.Drawing.Size(315, 22);
            this.InpCustomerPhoneNumber.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 134);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 17);
            this.label17.TabIndex = 14;
            this.label17.Text = "Phone Number";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(65, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 17);
            this.label16.TabIndex = 12;
            this.label16.Text = "Gender";
            // 
            // InpCustomerEmail
            // 
            this.InpCustomerEmail.Location = new System.Drawing.Point(127, 77);
            this.InpCustomerEmail.Name = "InpCustomerEmail";
            this.InpCustomerEmail.Size = new System.Drawing.Size(315, 22);
            this.InpCustomerEmail.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(79, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 17);
            this.label15.TabIndex = 10;
            this.label15.Text = "Email";
            // 
            // InpCustomerNIK
            // 
            this.InpCustomerNIK.Location = new System.Drawing.Point(127, 52);
            this.InpCustomerNIK.Name = "InpCustomerNIK";
            this.InpCustomerNIK.Size = new System.Drawing.Size(315, 22);
            this.InpCustomerNIK.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(91, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "NIK";
            // 
            // InpCustomerName
            // 
            this.InpCustomerName.Location = new System.Drawing.Point(127, 21);
            this.InpCustomerName.Name = "InpCustomerName";
            this.InpCustomerName.Size = new System.Drawing.Size(315, 22);
            this.InpCustomerName.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Customer Name";
            // 
            // TableCustomer
            // 
            this.TableCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableCustomer.Location = new System.Drawing.Point(12, 67);
            this.TableCustomer.Name = "TableCustomer";
            this.TableCustomer.RowHeadersWidth = 51;
            this.TableCustomer.RowTemplate.Height = 24;
            this.TableCustomer.Size = new System.Drawing.Size(434, 176);
            this.TableCustomer.TabIndex = 4;
            this.TableCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableCustomer_CellClick);
            // 
            // labelSearchCustomer
            // 
            this.labelSearchCustomer.AutoSize = true;
            this.labelSearchCustomer.Location = new System.Drawing.Point(213, 33);
            this.labelSearchCustomer.Name = "labelSearchCustomer";
            this.labelSearchCustomer.Size = new System.Drawing.Size(53, 17);
            this.labelSearchCustomer.TabIndex = 3;
            this.labelSearchCustomer.Text = "Search";
            // 
            // InpSearchCustomer
            // 
            this.InpSearchCustomer.Location = new System.Drawing.Point(272, 33);
            this.InpSearchCustomer.Name = "InpSearchCustomer";
            this.InpSearchCustomer.Size = new System.Drawing.Size(174, 22);
            this.InpSearchCustomer.TabIndex = 2;
            // 
            // RadioSearch
            // 
            this.RadioSearch.AutoSize = true;
            this.RadioSearch.Checked = true;
            this.RadioSearch.Location = new System.Drawing.Point(103, 31);
            this.RadioSearch.Name = "RadioSearch";
            this.RadioSearch.Size = new System.Drawing.Size(74, 21);
            this.RadioSearch.TabIndex = 1;
            this.RadioSearch.TabStop = true;
            this.RadioSearch.Text = "Search";
            this.RadioSearch.UseVisualStyleBackColor = true;
            this.RadioSearch.CheckedChanged += new System.EventHandler(this.RadioSearch_CheckedChanged);
            // 
            // RadioAddNew
            // 
            this.RadioAddNew.AutoSize = true;
            this.RadioAddNew.Location = new System.Drawing.Point(12, 31);
            this.RadioAddNew.Name = "RadioAddNew";
            this.RadioAddNew.Size = new System.Drawing.Size(85, 21);
            this.RadioAddNew.TabIndex = 0;
            this.RadioAddNew.Text = "Add New";
            this.RadioAddNew.UseVisualStyleBackColor = true;
            this.RadioAddNew.CheckedChanged += new System.EventHandler(this.RadioAddNew_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.InpStaying);
            this.groupBox2.Controls.Add(this.InpCheckout);
            this.groupBox2.Controls.Add(this.InpCheckin);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(512, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reservation\'s Information";
            // 
            // InpStaying
            // 
            this.InpStaying.Location = new System.Drawing.Point(126, 67);
            this.InpStaying.Name = "InpStaying";
            this.InpStaying.Size = new System.Drawing.Size(324, 22);
            this.InpStaying.TabIndex = 5;
            // 
            // InpCheckout
            // 
            this.InpCheckout.Location = new System.Drawing.Point(126, 101);
            this.InpCheckout.Name = "InpCheckout";
            this.InpCheckout.Size = new System.Drawing.Size(324, 22);
            this.InpCheckout.TabIndex = 4;
            // 
            // InpCheckin
            // 
            this.InpCheckin.Location = new System.Drawing.Point(126, 31);
            this.InpCheckin.Name = "InpCheckin";
            this.InpCheckin.Size = new System.Drawing.Size(320, 22);
            this.InpCheckin.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "CheckOut Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Staying";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Checkin Date :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.InpRoomType);
            this.groupBox3.Controls.Add(this.BtnRoomTypeSearch);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(512, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(473, 112);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Room\'s Information";
            // 
            // InpRoomType
            // 
            this.InpRoomType.FormattingEnabled = true;
            this.InpRoomType.Location = new System.Drawing.Point(122, 29);
            this.InpRoomType.Name = "InpRoomType";
            this.InpRoomType.Size = new System.Drawing.Size(324, 24);
            this.InpRoomType.TabIndex = 5;
            this.InpRoomType.SelectedIndexChanged += new System.EventHandler(this.InpRoomType_SelectedIndexChanged);
            // 
            // BtnRoomTypeSearch
            // 
            this.BtnRoomTypeSearch.Location = new System.Drawing.Point(122, 59);
            this.BtnRoomTypeSearch.Name = "BtnRoomTypeSearch";
            this.BtnRoomTypeSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnRoomTypeSearch.TabIndex = 4;
            this.BtnRoomTypeSearch.Text = "Search";
            this.BtnRoomTypeSearch.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Room Type";
            // 
            // TableAvailableRoom
            // 
            this.TableAvailableRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableAvailableRoom.Location = new System.Drawing.Point(24, 326);
            this.TableAvailableRoom.Name = "TableAvailableRoom";
            this.TableAvailableRoom.RowHeadersWidth = 51;
            this.TableAvailableRoom.RowTemplate.Height = 24;
            this.TableAvailableRoom.Size = new System.Drawing.Size(442, 150);
            this.TableAvailableRoom.TabIndex = 3;
            this.TableAvailableRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableAvailableRoom_CellClick);
            // 
            // TableSelectedRoom
            // 
            this.TableSelectedRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableSelectedRoom.Location = new System.Drawing.Point(543, 326);
            this.TableSelectedRoom.Name = "TableSelectedRoom";
            this.TableSelectedRoom.RowHeadersWidth = 51;
            this.TableSelectedRoom.RowTemplate.Height = 24;
            this.TableSelectedRoom.Size = new System.Drawing.Size(442, 150);
            this.TableSelectedRoom.TabIndex = 4;
            this.TableSelectedRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableSelectedRoom_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "List Available Rooms:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(540, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "List Selected Rooms:";
            // 
            // BtnAddRoom
            // 
            this.BtnAddRoom.Location = new System.Drawing.Point(472, 361);
            this.BtnAddRoom.Name = "BtnAddRoom";
            this.BtnAddRoom.Size = new System.Drawing.Size(65, 33);
            this.BtnAddRoom.TabIndex = 8;
            this.BtnAddRoom.Text = ">>";
            this.BtnAddRoom.UseVisualStyleBackColor = true;
            this.BtnAddRoom.Click += new System.EventHandler(this.BtnAddRoom_Click);
            // 
            // BtnRemoveRoom
            // 
            this.BtnRemoveRoom.Location = new System.Drawing.Point(472, 400);
            this.BtnRemoveRoom.Name = "BtnRemoveRoom";
            this.BtnRemoveRoom.Size = new System.Drawing.Size(65, 33);
            this.BtnRemoveRoom.TabIndex = 9;
            this.BtnRemoveRoom.Text = "<<";
            this.BtnRemoveRoom.UseVisualStyleBackColor = true;
            this.BtnRemoveRoom.Click += new System.EventHandler(this.BtnRemoveRoom_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnItemAdd);
            this.groupBox4.Controls.Add(this.TableItem);
            this.groupBox4.Controls.Add(this.InpSubTotal);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.InpPrice);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.InpQty);
            this.groupBox4.Controls.Add(this.InpItem);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(24, 507);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(763, 199);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Request Additional Items";
            // 
            // BtnItemAdd
            // 
            this.BtnItemAdd.Location = new System.Drawing.Point(692, 105);
            this.BtnItemAdd.Name = "BtnItemAdd";
            this.BtnItemAdd.Size = new System.Drawing.Size(65, 33);
            this.BtnItemAdd.TabIndex = 11;
            this.BtnItemAdd.Text = "Add";
            this.BtnItemAdd.UseVisualStyleBackColor = true;
            this.BtnItemAdd.Click += new System.EventHandler(this.BtnItemAdd_Click);
            // 
            // TableItem
            // 
            this.TableItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableItem.Location = new System.Drawing.Point(14, 105);
            this.TableItem.Name = "TableItem";
            this.TableItem.RowHeadersWidth = 51;
            this.TableItem.RowTemplate.Height = 24;
            this.TableItem.Size = new System.Drawing.Size(671, 76);
            this.TableItem.TabIndex = 14;
            // 
            // InpSubTotal
            // 
            this.InpSubTotal.Location = new System.Drawing.Point(485, 59);
            this.InpSubTotal.Name = "InpSubTotal";
            this.InpSubTotal.Size = new System.Drawing.Size(272, 22);
            this.InpSubTotal.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(406, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Sub Total:";
            // 
            // InpPrice
            // 
            this.InpPrice.Location = new System.Drawing.Point(485, 24);
            this.InpPrice.Name = "InpPrice";
            this.InpPrice.Size = new System.Drawing.Size(272, 22);
            this.InpPrice.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(406, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Price";
            // 
            // InpQty
            // 
            this.InpQty.Location = new System.Drawing.Point(78, 62);
            this.InpQty.Name = "InpQty";
            this.InpQty.Size = new System.Drawing.Size(298, 22);
            this.InpQty.TabIndex = 9;
            // 
            // InpItem
            // 
            this.InpItem.FormattingEnabled = true;
            this.InpItem.Location = new System.Drawing.Point(78, 24);
            this.InpItem.Name = "InpItem";
            this.InpItem.Size = new System.Drawing.Size(298, 24);
            this.InpItem.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Item:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(803, 520);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Total Price: RP. 140000";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(806, 545);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 38);
            this.BtnSubmit.TabIndex = 11;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 718);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.BtnRemoveRoom);
            this.Controls.Add(this.BtnAddRoom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TableSelectedRoom);
            this.Controls.Add(this.TableAvailableRoom);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReservationForm";
            this.Text = "ReservationRoom";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.customerAddNewGroup.ResumeLayout(false);
            this.customerAddNewGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableCustomer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableAvailableRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableSelectedRoom)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InpQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioSearch;
        private System.Windows.Forms.RadioButton RadioAddNew;
        private System.Windows.Forms.DataGridView TableCustomer;
        private System.Windows.Forms.Label labelSearchCustomer;
        private System.Windows.Forms.TextBox InpSearchCustomer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox InpStaying;
        private System.Windows.Forms.DateTimePicker InpCheckout;
        private System.Windows.Forms.DateTimePicker InpCheckin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox InpRoomType;
        private System.Windows.Forms.Button BtnRoomTypeSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView TableAvailableRoom;
        private System.Windows.Forms.DataGridView TableSelectedRoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnAddRoom;
        private System.Windows.Forms.Button BtnRemoveRoom;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnItemAdd;
        private System.Windows.Forms.DataGridView TableItem;
        private System.Windows.Forms.TextBox InpSubTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox InpPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown InpQty;
        private System.Windows.Forms.ComboBox InpItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.GroupBox customerAddNewGroup;
        private System.Windows.Forms.DateTimePicker InpCustomerDateOfBirth;
        private System.Windows.Forms.ComboBox InpCustomerGender;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox InpCustomerPhoneNumber;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox InpCustomerEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox InpCustomerNIK;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox InpCustomerName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnAddNewCustomer;
    }
}