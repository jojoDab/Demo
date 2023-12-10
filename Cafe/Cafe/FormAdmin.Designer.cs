
namespace Cafe
{
    partial class FormAdmin
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
            this.Back = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iduser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dismissed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iddish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numtable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.users_iduser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(125, 9);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(100, 27);
            this.Back.TabIndex = 0;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1387, 794);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1379, 765);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сотрудники";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iduser,
            this.username,
            this.passuser,
            this.accessuser,
            this.fullname,
            this.dismissed,
            this.shiftnumber});
            this.dataGridView1.Location = new System.Drawing.Point(-19, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1392, 517);
            this.dataGridView1.TabIndex = 0;
            // 
            // iduser
            // 
            this.iduser.DataPropertyName = "iduser";
            this.iduser.HeaderText = "ID пользователя";
            this.iduser.MinimumWidth = 6;
            this.iduser.Name = "iduser";
            this.iduser.Width = 125;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Логин";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.Width = 125;
            // 
            // passuser
            // 
            this.passuser.DataPropertyName = "passuser";
            this.passuser.HeaderText = "Пароль";
            this.passuser.MinimumWidth = 6;
            this.passuser.Name = "passuser";
            this.passuser.Width = 125;
            // 
            // accessuser
            // 
            this.accessuser.DataPropertyName = "accessuser";
            this.accessuser.HeaderText = "Тип доступа";
            this.accessuser.MinimumWidth = 6;
            this.accessuser.Name = "accessuser";
            this.accessuser.Width = 125;
            // 
            // fullname
            // 
            this.fullname.DataPropertyName = "fullname";
            this.fullname.HeaderText = "ФИО";
            this.fullname.MinimumWidth = 6;
            this.fullname.Name = "fullname";
            this.fullname.Width = 125;
            // 
            // dismissed
            // 
            this.dismissed.DataPropertyName = "dismissed";
            this.dismissed.HeaderText = "Уволен";
            this.dismissed.MinimumWidth = 6;
            this.dismissed.Name = "dismissed";
            this.dismissed.Width = 125;
            // 
            // shiftnumber
            // 
            this.shiftnumber.DataPropertyName = "shiftnumber";
            this.shiftnumber.HeaderText = "Номер смены";
            this.shiftnumber.MinimumWidth = 6;
            this.shiftnumber.Name = "shiftnumber";
            this.shiftnumber.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1379, 765);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Блюдо";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddish,
            this.wt,
            this.price});
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1302, 534);
            this.dataGridView2.TabIndex = 0;
            // 
            // iddish
            // 
            this.iddish.DataPropertyName = "iddish";
            this.iddish.HeaderText = "ID блюда";
            this.iddish.MinimumWidth = 6;
            this.iddish.Name = "iddish";
            this.iddish.Width = 125;
            // 
            // wt
            // 
            this.wt.DataPropertyName = "wt";
            this.wt.HeaderText = "Вес блюда";
            this.wt.MinimumWidth = 6;
            this.wt.Name = "wt";
            this.wt.Width = 125;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Цена";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1379, 765);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Заказ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1312, 603);
            this.dataGridView3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1379, 765);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Статус заказа";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idorder,
            this.statusorder,
            this.numtable,
            this.users_iduser});
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(1373, 704);
            this.dataGridView4.TabIndex = 0;
            // 
            // idorder
            // 
            this.idorder.DataPropertyName = "idorder";
            this.idorder.HeaderText = "ID заказа";
            this.idorder.MinimumWidth = 6;
            this.idorder.Name = "idorder";
            this.idorder.Width = 125;
            // 
            // statusorder
            // 
            this.statusorder.DataPropertyName = "statusorder";
            this.statusorder.HeaderText = "Статус заказа";
            this.statusorder.MinimumWidth = 6;
            this.statusorder.Name = "statusorder";
            this.statusorder.Width = 125;
            // 
            // numtable
            // 
            this.numtable.DataPropertyName = "numtable";
            this.numtable.HeaderText = "№ стола";
            this.numtable.MinimumWidth = 6;
            this.numtable.Name = "numtable";
            this.numtable.Width = 125;
            // 
            // users_iduser
            // 
            this.users_iduser.DataPropertyName = "users_iduser";
            this.users_iduser.HeaderText = "ID пользователя";
            this.users_iduser.MinimumWidth = 6;
            this.users_iduser.Name = "users_iduser";
            this.users_iduser.Width = 125;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 847);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAdmin";
            this.Text = "Меню Администратора";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduser;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn passuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dismissed;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftnumber;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddish;
        private System.Windows.Forms.DataGridViewTextBoxColumn wt;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn numtable;
        private System.Windows.Forms.DataGridViewTextBoxColumn users_iduser;
    }
}