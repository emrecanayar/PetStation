namespace WinFormUI
{
	partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ClearForComponent = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxUpdatePriceO = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUpdatePriceT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.textBoxUpdateQuantity = new System.Windows.Forms.TextBox();
            this.textBoxUpdateProductName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPriceO = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPriceT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CreateCombineForImageBtn = new System.Windows.Forms.Button();
            this.deleteForCombineBox = new System.Windows.Forms.Button();
            this.totalCost = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CombineListView = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSearchProduct = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(537, 327);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(551, 292);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ClearForComponent);
            this.tabPage1.Controls.Add(this.DeleteButton);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(543, 266);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ürün";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ClearForComponent
            // 
            this.ClearForComponent.Location = new System.Drawing.Point(344, 222);
            this.ClearForComponent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearForComponent.Name = "ClearForComponent";
            this.ClearForComponent.Size = new System.Drawing.Size(94, 34);
            this.ClearForComponent.TabIndex = 13;
            this.ClearForComponent.Text = "Temizle";
            this.ClearForComponent.UseVisualStyleBackColor = true;
            this.ClearForComponent.Click += new System.EventHandler(this.ClearForComponent_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(442, 222);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(94, 34);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Ürün Sil";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxUpdatePriceO);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBoxUpdatePriceT);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.UpdateButton);
            this.groupBox3.Controls.Add(this.textBoxUpdateQuantity);
            this.groupBox3.Controls.Add(this.textBoxUpdateProductName);
            this.groupBox3.Location = new System.Drawing.Point(279, 26);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(259, 176);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Güncelle";
            // 
            // textBoxUpdatePriceO
            // 
            this.textBoxUpdatePriceO.Location = new System.Drawing.Point(134, 69);
            this.textBoxUpdatePriceO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUpdatePriceO.Name = "textBoxUpdatePriceO";
            this.textBoxUpdatePriceO.Size = new System.Drawing.Size(27, 20);
            this.textBoxUpdatePriceO.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 73);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = ",";
            // 
            // textBoxUpdatePriceT
            // 
            this.textBoxUpdatePriceT.Location = new System.Drawing.Point(90, 69);
            this.textBoxUpdatePriceT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUpdatePriceT.Name = "textBoxUpdatePriceT";
            this.textBoxUpdatePriceT.Size = new System.Drawing.Size(27, 20);
            this.textBoxUpdatePriceT.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ürün Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Alış Fiyatı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Miktar:";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(152, 136);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(59, 19);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.Text = "Güncelle";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // textBoxUpdateQuantity
            // 
            this.textBoxUpdateQuantity.Location = new System.Drawing.Point(90, 106);
            this.textBoxUpdateQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUpdateQuantity.Name = "textBoxUpdateQuantity";
            this.textBoxUpdateQuantity.Size = new System.Drawing.Size(122, 20);
            this.textBoxUpdateQuantity.TabIndex = 7;
            // 
            // textBoxUpdateProductName
            // 
            this.textBoxUpdateProductName.Location = new System.Drawing.Point(90, 29);
            this.textBoxUpdateProductName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUpdateProductName.Name = "textBoxUpdateProductName";
            this.textBoxUpdateProductName.Size = new System.Drawing.Size(122, 20);
            this.textBoxUpdateProductName.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxPriceO);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.AddButton);
            this.groupBox2.Controls.Add(this.textBoxQuantity);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxPriceT);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxProductName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(7, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(259, 176);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Ekle";
            // 
            // textBoxPriceO
            // 
            this.textBoxPriceO.Location = new System.Drawing.Point(134, 67);
            this.textBoxPriceO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPriceO.Name = "textBoxPriceO";
            this.textBoxPriceO.Size = new System.Drawing.Size(27, 20);
            this.textBoxPriceO.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = ",";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(155, 136);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(56, 19);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Ekle";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(90, 106);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(122, 20);
            this.textBoxQuantity.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Adı:";
            // 
            // textBoxPriceT
            // 
            this.textBoxPriceT.Location = new System.Drawing.Point(90, 67);
            this.textBoxPriceT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPriceT.Name = "textBoxPriceT";
            this.textBoxPriceT.Size = new System.Drawing.Size(27, 20);
            this.textBoxPriceT.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alış Fiyatı:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(90, 29);
            this.textBoxProductName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(122, 20);
            this.textBoxProductName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Miktar:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CreateCombineForImageBtn);
            this.tabPage2.Controls.Add(this.deleteForCombineBox);
            this.tabPage2.Controls.Add(this.totalCost);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(543, 266);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kombin Yap";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CreateCombineForImageBtn
            // 
            this.CreateCombineForImageBtn.Location = new System.Drawing.Point(422, 227);
            this.CreateCombineForImageBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateCombineForImageBtn.Name = "CreateCombineForImageBtn";
            this.CreateCombineForImageBtn.Size = new System.Drawing.Size(117, 34);
            this.CreateCombineForImageBtn.TabIndex = 13;
            this.CreateCombineForImageBtn.Text = "Resim Kombin Yap";
            this.CreateCombineForImageBtn.UseVisualStyleBackColor = true;
            this.CreateCombineForImageBtn.Click += new System.EventHandler(this.CreateCombineForImageBtn_Click);
            // 
            // deleteForCombineBox
            // 
            this.deleteForCombineBox.Location = new System.Drawing.Point(187, 243);
            this.deleteForCombineBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteForCombineBox.Name = "deleteForCombineBox";
            this.deleteForCombineBox.Size = new System.Drawing.Size(56, 19);
            this.deleteForCombineBox.TabIndex = 3;
            this.deleteForCombineBox.Text = "Sil";
            this.deleteForCombineBox.UseVisualStyleBackColor = true;
            this.deleteForCombineBox.Click += new System.EventHandler(this.deleteForCombineBox_Click);
            // 
            // totalCost
            // 
            this.totalCost.AutoSize = true;
            this.totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalCost.Location = new System.Drawing.Point(372, 87);
            this.totalCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(60, 20);
            this.totalCost.TabIndex = 2;
            this.totalCost.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(324, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 26);
            this.label10.TabIndex = 1;
            this.label10.Text = "Toplam Maliyet";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CombineListView);
            this.groupBox4.Location = new System.Drawing.Point(14, 20);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(229, 220);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kombin Ürünler";
            // 
            // CombineListView
            // 
            this.CombineListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CombineListView.HideSelection = false;
            this.CombineListView.Location = new System.Drawing.Point(2, 15);
            this.CombineListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CombineListView.Name = "CombineListView";
            this.CombineListView.Size = new System.Drawing.Size(225, 203);
            this.CombineListView.TabIndex = 0;
            this.CombineListView.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 306);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ürün Adı Ara:";
            // 
            // textBoxSearchProduct
            // 
            this.textBoxSearchProduct.Location = new System.Drawing.Point(436, 304);
            this.textBoxSearchProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSearchProduct.Name = "textBoxSearchProduct";
            this.textBoxSearchProduct.Size = new System.Drawing.Size(122, 20);
            this.textBoxSearchProduct.TabIndex = 10;
            this.textBoxSearchProduct.TextChanged += new System.EventHandler(this.textBoxSearchProduct_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(16, 327);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(541, 344);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürünler";
            // 
            // ProductForm
            // 
            this.AcceptButton = this.AddButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 726);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxSearchProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pet Station";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox textBoxUpdateQuantity;
		private System.Windows.Forms.TextBox textBoxUpdateProductName;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBoxQuantity;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxPriceT;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxProductName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button UpdateButton;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxSearchProduct;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxPriceO;
		private System.Windows.Forms.TextBox textBoxUpdatePriceO;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxUpdatePriceT;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label totalCost;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button deleteForCombineBox;
		private System.Windows.Forms.ListView CombineListView;
		private System.Windows.Forms.Button ClearForComponent;
        private System.Windows.Forms.Button CreateCombineForImageBtn;
    }
}

