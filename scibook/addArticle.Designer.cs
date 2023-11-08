namespace scibook
{
    partial class addArticle
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label owner_idLabel;
            System.Windows.Forms.Label articals_idLabel;
            System.Windows.Forms.Label pretitleLabel;
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label main_photoLabel;
            System.Windows.Forms.Label sub_idLabel;
            System.Windows.Forms.Label dateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addArticle));
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner_idTextBox = new System.Windows.Forms.TextBox();
            this.articalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new scibook.DataSet1();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.articals_idTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.pretitleTextBox = new System.Windows.Forms.TextBox();
            this.main_textTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.mainphotoTextBox = new System.Windows.Forms.TextBox();
            this.sub_idTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articalsTableAdapter = new scibook.DataSet1TableAdapters.articalsTableAdapter();
            this.tableAdapterManager = new scibook.DataSet1TableAdapters.TableAdapterManager();
            this.articalsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.articalsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articalsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.selectbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            owner_idLabel = new System.Windows.Forms.Label();
            articals_idLabel = new System.Windows.Forms.Label();
            pretitleLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            main_photoLabel = new System.Windows.Forms.Label();
            sub_idLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.articalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articalsBindingNavigator)).BeginInit();
            this.articalsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articalsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // owner_idLabel
            // 
            owner_idLabel.AutoSize = true;
            owner_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            owner_idLabel.Location = new System.Drawing.Point(452, 51);
            owner_idLabel.Name = "owner_idLabel";
            owner_idLabel.Size = new System.Drawing.Size(104, 18);
            owner_idLabel.TabIndex = 44;
            owner_idLabel.Text = "Создатель id:";
            // 
            // articals_idLabel
            // 
            articals_idLabel.AutoSize = true;
            articals_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            articals_idLabel.Location = new System.Drawing.Point(44, 54);
            articals_idLabel.Name = "articals_idLabel";
            articals_idLabel.Size = new System.Drawing.Size(109, 18);
            articals_idLabel.TabIndex = 29;
            articals_idLabel.Text = "Номер статьи:";
            // 
            // pretitleLabel
            // 
            pretitleLabel.AutoSize = true;
            pretitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pretitleLabel.Location = new System.Drawing.Point(38, 157);
            pretitleLabel.Name = "pretitleLabel";
            pretitleLabel.Size = new System.Drawing.Size(76, 18);
            pretitleLabel.TabIndex = 32;
            pretitleLabel.Text = "Описание";
            pretitleLabel.Click += new System.EventHandler(this.pretitleLabel_Click);
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            authorLabel.Location = new System.Drawing.Point(44, 119);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(53, 18);
            authorLabel.TabIndex = 35;
            authorLabel.Text = "Автор:";
            // 
            // main_photoLabel
            // 
            main_photoLabel.AutoSize = true;
            main_photoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            main_photoLabel.Location = new System.Drawing.Point(832, 203);
            main_photoLabel.Name = "main_photoLabel";
            main_photoLabel.Size = new System.Drawing.Size(97, 18);
            main_photoLabel.TabIndex = 37;
            main_photoLabel.Text = "Фотография";
            // 
            // sub_idLabel
            // 
            sub_idLabel.AutoSize = true;
            sub_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            sub_idLabel.Location = new System.Drawing.Point(262, 54);
            sub_idLabel.Name = "sub_idLabel";
            sub_idLabel.Size = new System.Drawing.Size(99, 18);
            sub_idLabel.TabIndex = 39;
            sub_idLabel.Text = "Категория id:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel.Location = new System.Drawing.Point(44, 84);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(132, 18);
            dateLabel.TabIndex = 41;
            dateLabel.Text = "Дата публикации:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(841, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 37);
            this.label2.TabIndex = 46;
            this.label2.Text = "SciBook";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "main_photo";
            this.dataGridViewTextBoxColumn7.HeaderText = "main_photo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "sub_id";
            this.dataGridViewTextBoxColumn8.HeaderText = "sub_id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn9.HeaderText = "Date";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "author";
            this.dataGridViewTextBoxColumn6.HeaderText = "author";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // owner_idTextBox
            // 
            this.owner_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articalsBindingSource, "owner_id", true));
            this.owner_idTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.owner_idTextBox.Location = new System.Drawing.Point(562, 51);
            this.owner_idTextBox.Name = "owner_idTextBox";
            this.owner_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.owner_idTextBox.TabIndex = 45;
            // 
            // articalsBindingSource
            // 
            this.articalsBindingSource.DataMember = "articals";
            this.articalsBindingSource.DataSource = this.dataSet1;
            this.articalsBindingSource.CurrentChanged += new System.EventHandler(this.articalsBindingSource_CurrentChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(785, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // articals_idTextBox
            // 
            this.articals_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articalsBindingSource, "articals_id", true));
            this.articals_idTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articals_idTextBox.Location = new System.Drawing.Point(182, 50);
            this.articals_idTextBox.Name = "articals_idTextBox";
            this.articals_idTextBox.Size = new System.Drawing.Size(55, 22);
            this.articals_idTextBox.TabIndex = 30;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articalsBindingSource, "title", true));
            this.titleTextBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(265, 128);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(485, 32);
            this.titleTextBox.TabIndex = 31;
            this.titleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pretitleTextBox
            // 
            this.pretitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articalsBindingSource, "pretitle", true));
            this.pretitleTextBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretitleTextBox.Location = new System.Drawing.Point(37, 178);
            this.pretitleTextBox.Multiline = true;
            this.pretitleTextBox.Name = "pretitleTextBox";
            this.pretitleTextBox.Size = new System.Drawing.Size(200, 239);
            this.pretitleTextBox.TabIndex = 33;
            this.pretitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pretitleTextBox.TextChanged += new System.EventHandler(this.pretitleTextBox_TextChanged);
            // 
            // main_textTextBox
            // 
            this.main_textTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articalsBindingSource, "main_text", true));
            this.main_textTextBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_textTextBox.Location = new System.Drawing.Point(265, 184);
            this.main_textTextBox.Multiline = true;
            this.main_textTextBox.Name = "main_textTextBox";
            this.main_textTextBox.Size = new System.Drawing.Size(485, 233);
            this.main_textTextBox.TabIndex = 34;
            this.main_textTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articalsBindingSource, "author", true));
            this.authorTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorTextBox.Location = new System.Drawing.Point(108, 119);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(129, 22);
            this.authorTextBox.TabIndex = 36;
            // 
            // mainphotoTextBox
            // 
            this.mainphotoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articalsBindingSource, "main_photo", true));
            this.mainphotoTextBox.Location = new System.Drawing.Point(785, 370);
            this.mainphotoTextBox.Name = "mainphotoTextBox";
            this.mainphotoTextBox.Size = new System.Drawing.Size(200, 20);
            this.mainphotoTextBox.TabIndex = 38;
            // 
            // sub_idTextBox
            // 
            this.sub_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articalsBindingSource, "sub_id", true));
            this.sub_idTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.sub_idTextBox.Location = new System.Drawing.Point(367, 50);
            this.sub_idTextBox.Name = "sub_idTextBox";
            this.sub_idTextBox.Size = new System.Drawing.Size(61, 22);
            this.sub_idTextBox.TabIndex = 40;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Checked = false;
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.articalsBindingSource, "Date", true));
            this.dateDateTimePicker.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDateTimePicker.Location = new System.Drawing.Point(182, 81);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(181, 22);
            this.dateDateTimePicker.TabIndex = 42;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "main_text";
            this.dataGridViewTextBoxColumn5.HeaderText = "main_text";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // articalsTableAdapter
            // 
            this.articalsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.articalsTableAdapter = this.articalsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookmarksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = scibook.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // articalsBindingNavigator
            // 
            this.articalsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.articalsBindingNavigator.BindingSource = this.articalsBindingSource;
            this.articalsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.articalsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.articalsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.articalsBindingNavigatorSaveItem});
            this.articalsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.articalsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.articalsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.articalsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.articalsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.articalsBindingNavigator.Name = "articalsBindingNavigator";
            this.articalsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.articalsBindingNavigator.Size = new System.Drawing.Size(1023, 25);
            this.articalsBindingNavigator.TabIndex = 26;
            this.articalsBindingNavigator.Text = "bindingNavigator1";
            this.articalsBindingNavigator.RefreshItems += new System.EventHandler(this.articalsBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // articalsBindingNavigatorSaveItem
            // 
            this.articalsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.articalsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("articalsBindingNavigatorSaveItem.Image")));
            this.articalsBindingNavigatorSaveItem.Name = "articalsBindingNavigatorSaveItem";
            this.articalsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.articalsBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "pretitle";
            this.dataGridViewTextBoxColumn4.HeaderText = "pretitle";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // articalsDataGridView
            // 
            this.articalsDataGridView.AutoGenerateColumns = false;
            this.articalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articalsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.articalsDataGridView.DataSource = this.articalsBindingSource;
            this.articalsDataGridView.Location = new System.Drawing.Point(41, 496);
            this.articalsDataGridView.Name = "articalsDataGridView";
            this.articalsDataGridView.Size = new System.Drawing.Size(944, 145);
            this.articalsDataGridView.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "articals_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "articals_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "owner_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "owner_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn3.HeaderText = "title";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(341, 442);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 39);
            this.button3.TabIndex = 50;
            this.button3.Text = "Удалить выделенное";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(191, 442);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 39);
            this.button4.TabIndex = 49;
            this.button4.Text = "Сохранить изменения";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(41, 442);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 39);
            this.button5.TabIndex = 48;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // selectbtn
            // 
            this.selectbtn.Location = new System.Drawing.Point(785, 396);
            this.selectbtn.Name = "selectbtn";
            this.selectbtn.Size = new System.Drawing.Size(200, 23);
            this.selectbtn.TabIndex = 47;
            this.selectbtn.Text = "Выбрать";
            this.selectbtn.UseVisualStyleBackColor = true;
            this.selectbtn.Click += new System.EventHandler(this.selectbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(501, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 51;
            // 
            // addArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 708);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.selectbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(owner_idLabel);
            this.Controls.Add(this.owner_idTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(articals_idLabel);
            this.Controls.Add(this.articals_idTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(pretitleLabel);
            this.Controls.Add(this.pretitleTextBox);
            this.Controls.Add(this.main_textTextBox);
            this.Controls.Add(authorLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(main_photoLabel);
            this.Controls.Add(this.mainphotoTextBox);
            this.Controls.Add(sub_idLabel);
            this.Controls.Add(this.sub_idTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.articalsBindingNavigator);
            this.Controls.Add(this.articalsDataGridView);
            this.Name = "addArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление статьи";
            this.Load += new System.EventHandler(this.addArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.articalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articalsBindingNavigator)).EndInit();
            this.articalsBindingNavigator.ResumeLayout(false);
            this.articalsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articalsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox owner_idTextBox;
        private System.Windows.Forms.BindingSource articalsBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox articals_idTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox pretitleTextBox;
        private System.Windows.Forms.TextBox main_textTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox mainphotoTextBox;
        private System.Windows.Forms.TextBox sub_idTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataSet1TableAdapters.articalsTableAdapter articalsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator articalsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton articalsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView articalsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button selectbtn;
        private System.Windows.Forms.Label label1;
    }
}