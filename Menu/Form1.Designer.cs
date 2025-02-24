namespace Menu
{
    partial class menuForm
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
            layoutPanel = new Panel();
            Menulb = new Label();
            menudGV = new DataGridView();
            infogBx = new GroupBox();
            loadBtn = new Button();
            priceTxb = new TextBox();
            priceLB = new Label();
            selectBtn = new Button();
            menuLV = new ListView();
            menucBx = new ComboBox();
            addFoodBtn = new Button();
            foodTxt = new TextBox();
            foodLb = new Label();
            layoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menudGV).BeginInit();
            infogBx.SuspendLayout();
            SuspendLayout();
            // 
            // layoutPanel
            // 
            layoutPanel.Controls.Add(Menulb);
            layoutPanel.Controls.Add(menudGV);
            layoutPanel.Controls.Add(infogBx);
            layoutPanel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            layoutPanel.Location = new Point(12, 12);
            layoutPanel.Name = "layoutPanel";
            layoutPanel.Size = new Size(829, 689);
            layoutPanel.TabIndex = 0;
            // 
            // Menulb
            // 
            Menulb.AutoSize = true;
            Menulb.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Menulb.Location = new Point(360, 447);
            Menulb.Name = "Menulb";
            Menulb.Size = new Size(109, 26);
            Menulb.TabIndex = 2;
            Menulb.Text = "Danh sách";
            // 
            // menudGV
            // 
            menudGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            menudGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            menudGV.Location = new Point(0, 497);
            menudGV.Name = "menudGV";
            menudGV.RowHeadersWidth = 51;
            menudGV.Size = new Size(823, 189);
            menudGV.TabIndex = 1;
            menudGV.CellEndEdit += menudGV_CellEndEdit;
            menudGV.CellValueChanged += menudGV_CellValueChanged;
            // 
            // infogBx
            // 
            infogBx.Controls.Add(loadBtn);
            infogBx.Controls.Add(priceTxb);
            infogBx.Controls.Add(priceLB);
            infogBx.Controls.Add(selectBtn);
            infogBx.Controls.Add(menuLV);
            infogBx.Controls.Add(menucBx);
            infogBx.Controls.Add(addFoodBtn);
            infogBx.Controls.Add(foodTxt);
            infogBx.Controls.Add(foodLb);
            infogBx.Location = new Point(3, 3);
            infogBx.Name = "infogBx";
            infogBx.Size = new Size(823, 409);
            infogBx.TabIndex = 0;
            infogBx.TabStop = false;
            infogBx.Text = "Thông tin";
            // 
            // loadBtn
            // 
            loadBtn.Location = new Point(645, 101);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(117, 29);
            loadBtn.TabIndex = 8;
            loadBtn.Text = "Hiển thị";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += loadBtn_Click;
            loadBtn.MouseLeave += loadBtn_MouseLeave;
            loadBtn.MouseHover += loadBtn_MouseHover;
            // 
            // priceTxb
            // 
            priceTxb.Location = new Point(127, 105);
            priceTxb.Name = "priceTxb";
            priceTxb.Size = new Size(312, 30);
            priceTxb.TabIndex = 7;
            priceTxb.KeyPress += priceTxb_KeyPress;
            priceTxb.MouseLeave += priceTxb_MouseLeave;
            priceTxb.MouseHover += priceTxb_MouseHover;
            // 
            // priceLB
            // 
            priceLB.AutoSize = true;
            priceLB.Location = new Point(33, 108);
            priceLB.Name = "priceLB";
            priceLB.Size = new Size(39, 22);
            priceLB.TabIndex = 6;
            priceLB.Text = "Giá";
            // 
            // selectBtn
            // 
            selectBtn.Location = new Point(645, 173);
            selectBtn.Name = "selectBtn";
            selectBtn.Size = new Size(117, 29);
            selectBtn.TabIndex = 5;
            selectBtn.Text = "Chọn";
            selectBtn.UseVisualStyleBackColor = true;
            selectBtn.Click += selectBtn_Click;
            selectBtn.MouseLeave += selectBtn_MouseLeave;
            selectBtn.MouseHover += selectBtn_MouseHover;
            // 
            // menuLV
            // 
            menuLV.AllowColumnReorder = true;
            menuLV.FullRowSelect = true;
            menuLV.GridLines = true;
            menuLV.Location = new Point(33, 251);
            menuLV.Name = "menuLV";
            menuLV.Size = new Size(549, 121);
            menuLV.TabIndex = 4;
            menuLV.UseCompatibleStateImageBehavior = false;
            menuLV.View = View.Details;
            menuLV.AfterLabelEdit += menuLV_AfterLabelEdit;
            // 
            // menucBx
            // 
            menucBx.FormattingEnabled = true;
            menucBx.Location = new Point(33, 173);
            menucBx.Name = "menucBx";
            menucBx.Size = new Size(406, 30);
            menucBx.TabIndex = 3;
            // 
            // addFoodBtn
            // 
            addFoodBtn.Location = new Point(645, 48);
            addFoodBtn.Name = "addFoodBtn";
            addFoodBtn.Size = new Size(117, 29);
            addFoodBtn.TabIndex = 2;
            addFoodBtn.Text = "Thêm";
            addFoodBtn.UseVisualStyleBackColor = true;
            addFoodBtn.Click += addFoodBtn_Click;
            addFoodBtn.MouseLeave += addFoodBtn_MouseLeave;
            addFoodBtn.MouseHover += addFoodBtn_MouseHover;
            // 
            // foodTxt
            // 
            foodTxt.Location = new Point(127, 45);
            foodTxt.Name = "foodTxt";
            foodTxt.Size = new Size(312, 30);
            foodTxt.TabIndex = 1;
            foodTxt.KeyPress += foodTxt_KeyPress;
            foodTxt.MouseLeave += foodTxt_MouseLeave;
            foodTxt.MouseHover += foodTxt_MouseHover;
            // 
            // foodLb
            // 
            foodLb.AutoSize = true;
            foodLb.Location = new Point(33, 48);
            foodLb.Name = "foodLb";
            foodLb.Size = new Size(69, 22);
            foodLb.TabIndex = 0;
            foodLb.Text = "Món ăn";
            // 
            // menuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 713);
            Controls.Add(layoutPanel);
            Name = "menuForm";
            Text = "Menu";
            FormClosing += menuForm_FormClosing;
            Load += menuForm_Load;
            layoutPanel.ResumeLayout(false);
            layoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menudGV).EndInit();
            infogBx.ResumeLayout(false);
            infogBx.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel layoutPanel;
        private GroupBox infogBx;
        private DataGridView menudGV;
        private ListView menuLV;
        private ComboBox menucBx;
        private Button addFoodBtn;
        private TextBox foodTxt;
        private Label foodLb;
        private Label Menulb;
        private Button selectBtn;
        private TextBox priceTxb;
        private Label priceLB;
        private Button loadBtn;
    }
}
