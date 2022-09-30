
namespace Phone_Book
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label customer_idLabel;
            System.Windows.Forms.Label incomeLabel;
            System.Windows.Forms.Label debtLabel;
            System.Windows.Forms.Label birth_dateLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label educationLabel;
            System.Windows.Forms.Label study_fieldLabel;
            System.Windows.Forms.Label cell_phone1Label;
            System.Windows.Forms.Label cell_phone2Label;
            System.Windows.Forms.Label landline1Label;
            System.Windows.Forms.Label landline2Label;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label web_urlLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label zip_codeLabel;
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label co_nameLabel;
            System.Windows.Forms.Label activityLabel;
            System.Windows.Forms.Label commentLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.phone_book_tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.phone_book_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pb_dataset = new Phone_Book.DataSet.pb_dataset();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.phone_book_tableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.customer_idTextBox = new System.Windows.Forms.TextBox();
            this.incomeTextBox = new System.Windows.Forms.TextBox();
            this.debtTextBox = new System.Windows.Forms.TextBox();
            this.birth_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.educationTextBox = new System.Windows.Forms.TextBox();
            this.study_fieldTextBox = new System.Windows.Forms.TextBox();
            this.cell_phone1TextBox = new System.Windows.Forms.TextBox();
            this.cell_phone2TextBox = new System.Windows.Forms.TextBox();
            this.landline1TextBox = new System.Windows.Forms.TextBox();
            this.landline2TextBox = new System.Windows.Forms.TextBox();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.web_urlTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.zip_codeTextBox = new System.Windows.Forms.TextBox();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.co_nameTextBox = new System.Windows.Forms.TextBox();
            this.activityTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.phone_book_tableTableAdapter = new Phone_Book.DataSet.pb_datasetTableAdapters.phone_book_tableTableAdapter();
            this.tableAdapterManager = new Phone_Book.DataSet.pb_datasetTableAdapters.TableAdapterManager();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddNew = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCencel = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.phone_book_tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            idLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            customer_idLabel = new System.Windows.Forms.Label();
            incomeLabel = new System.Windows.Forms.Label();
            debtLabel = new System.Windows.Forms.Label();
            birth_dateLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            educationLabel = new System.Windows.Forms.Label();
            study_fieldLabel = new System.Windows.Forms.Label();
            cell_phone1Label = new System.Windows.Forms.Label();
            cell_phone2Label = new System.Windows.Forms.Label();
            landline1Label = new System.Windows.Forms.Label();
            landline2Label = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            web_urlLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            zip_codeLabel = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            co_nameLabel = new System.Windows.Forms.Label();
            activityLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phone_book_tableBindingNavigator)).BeginInit();
            this.phone_book_tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phone_book_tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_book_tableDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(70, 28);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 18);
            idLabel.TabIndex = 2;
            idLabel.Text = "id:";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(70, 62);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(94, 18);
            first_nameLabel.TabIndex = 4;
            first_nameLabel.Text = "first name:";
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(70, 96);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(93, 18);
            last_nameLabel.TabIndex = 6;
            last_nameLabel.Text = "last name:";
            // 
            // customer_idLabel
            // 
            customer_idLabel.AutoSize = true;
            customer_idLabel.Location = new System.Drawing.Point(70, 130);
            customer_idLabel.Name = "customer_idLabel";
            customer_idLabel.Size = new System.Drawing.Size(110, 18);
            customer_idLabel.TabIndex = 8;
            customer_idLabel.Text = "customer id:";
            // 
            // incomeLabel
            // 
            incomeLabel.AutoSize = true;
            incomeLabel.Location = new System.Drawing.Point(70, 164);
            incomeLabel.Name = "incomeLabel";
            incomeLabel.Size = new System.Drawing.Size(73, 18);
            incomeLabel.TabIndex = 10;
            incomeLabel.Text = "income:";
            // 
            // debtLabel
            // 
            debtLabel.AutoSize = true;
            debtLabel.Location = new System.Drawing.Point(70, 198);
            debtLabel.Name = "debtLabel";
            debtLabel.Size = new System.Drawing.Size(49, 18);
            debtLabel.TabIndex = 12;
            debtLabel.Text = "debt:";
            // 
            // birth_dateLabel
            // 
            birth_dateLabel.AutoSize = true;
            birth_dateLabel.Location = new System.Drawing.Point(70, 233);
            birth_dateLabel.Name = "birth_dateLabel";
            birth_dateLabel.Size = new System.Drawing.Size(89, 18);
            birth_dateLabel.TabIndex = 14;
            birth_dateLabel.Text = "birth date:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(70, 266);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(70, 18);
            genderLabel.TabIndex = 16;
            genderLabel.Text = "gender:";
            // 
            // educationLabel
            // 
            educationLabel.AutoSize = true;
            educationLabel.Location = new System.Drawing.Point(70, 300);
            educationLabel.Name = "educationLabel";
            educationLabel.Size = new System.Drawing.Size(93, 18);
            educationLabel.TabIndex = 18;
            educationLabel.Text = "education:";
            // 
            // study_fieldLabel
            // 
            study_fieldLabel.AutoSize = true;
            study_fieldLabel.Location = new System.Drawing.Point(70, 334);
            study_fieldLabel.Name = "study_fieldLabel";
            study_fieldLabel.Size = new System.Drawing.Size(96, 18);
            study_fieldLabel.TabIndex = 20;
            study_fieldLabel.Text = "study field:";
            // 
            // cell_phone1Label
            // 
            cell_phone1Label.AutoSize = true;
            cell_phone1Label.Location = new System.Drawing.Point(70, 368);
            cell_phone1Label.Name = "cell_phone1Label";
            cell_phone1Label.Size = new System.Drawing.Size(107, 18);
            cell_phone1Label.TabIndex = 22;
            cell_phone1Label.Text = "cell phone1:";
            // 
            // cell_phone2Label
            // 
            cell_phone2Label.AutoSize = true;
            cell_phone2Label.Location = new System.Drawing.Point(70, 402);
            cell_phone2Label.Name = "cell_phone2Label";
            cell_phone2Label.Size = new System.Drawing.Size(107, 18);
            cell_phone2Label.TabIndex = 24;
            cell_phone2Label.Text = "cell phone2:";
            // 
            // landline1Label
            // 
            landline1Label.AutoSize = true;
            landline1Label.Location = new System.Drawing.Point(70, 436);
            landline1Label.Name = "landline1Label";
            landline1Label.Size = new System.Drawing.Size(83, 18);
            landline1Label.TabIndex = 26;
            landline1Label.Text = "landline1:";
            // 
            // landline2Label
            // 
            landline2Label.AutoSize = true;
            landline2Label.Location = new System.Drawing.Point(535, 28);
            landline2Label.Name = "landline2Label";
            landline2Label.Size = new System.Drawing.Size(83, 18);
            landline2Label.TabIndex = 28;
            landline2Label.Text = "landline2:";
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(535, 62);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(39, 18);
            faxLabel.TabIndex = 30;
            faxLabel.Text = "fax:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(535, 96);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(55, 18);
            emailLabel.TabIndex = 32;
            emailLabel.Text = "email:";
            // 
            // web_urlLabel
            // 
            web_urlLabel.AutoSize = true;
            web_urlLabel.Location = new System.Drawing.Point(535, 130);
            web_urlLabel.Name = "web_urlLabel";
            web_urlLabel.Size = new System.Drawing.Size(73, 18);
            web_urlLabel.TabIndex = 34;
            web_urlLabel.Text = "web url:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(535, 164);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(76, 18);
            countryLabel.TabIndex = 36;
            countryLabel.Text = "country:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(535, 198);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(54, 18);
            stateLabel.TabIndex = 38;
            stateLabel.Text = "state:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(535, 232);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(42, 18);
            cityLabel.TabIndex = 40;
            cityLabel.Text = "city:";
            // 
            // zip_codeLabel
            // 
            zip_codeLabel.AutoSize = true;
            zip_codeLabel.Location = new System.Drawing.Point(535, 266);
            zip_codeLabel.Name = "zip_codeLabel";
            zip_codeLabel.Size = new System.Drawing.Size(83, 18);
            zip_codeLabel.TabIndex = 42;
            zip_codeLabel.Text = "zip code:";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(535, 300);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(90, 18);
            address1Label.TabIndex = 44;
            address1Label.Text = "address1:";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Location = new System.Drawing.Point(535, 334);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(90, 18);
            address2Label.TabIndex = 46;
            address2Label.Text = "address2:";
            // 
            // co_nameLabel
            // 
            co_nameLabel.AutoSize = true;
            co_nameLabel.Location = new System.Drawing.Point(535, 368);
            co_nameLabel.Name = "co_nameLabel";
            co_nameLabel.Size = new System.Drawing.Size(86, 18);
            co_nameLabel.TabIndex = 48;
            co_nameLabel.Text = "co name:";
            // 
            // activityLabel
            // 
            activityLabel.AutoSize = true;
            activityLabel.Location = new System.Drawing.Point(535, 402);
            activityLabel.Name = "activityLabel";
            activityLabel.Size = new System.Drawing.Size(70, 18);
            activityLabel.TabIndex = 50;
            activityLabel.Text = "activity:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(535, 436);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(90, 18);
            commentLabel.TabIndex = 52;
            commentLabel.Text = "comment:";
            // 
            // phone_book_tableBindingNavigator
            // 
            this.phone_book_tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.phone_book_tableBindingNavigator.AutoSize = false;
            this.phone_book_tableBindingNavigator.BindingSource = this.phone_book_tableBindingSource;
            this.phone_book_tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.phone_book_tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.phone_book_tableBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.phone_book_tableBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.phone_book_tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripSeparator1,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator2,
            this.phone_book_tableBindingNavigatorSaveItem,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripSeparator9});
            this.phone_book_tableBindingNavigator.Location = new System.Drawing.Point(0, 917);
            this.phone_book_tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.phone_book_tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.phone_book_tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.phone_book_tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.phone_book_tableBindingNavigator.Name = "phone_book_tableBindingNavigator";
            this.phone_book_tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.phone_book_tableBindingNavigator.Size = new System.Drawing.Size(1373, 39);
            this.phone_book_tableBindingNavigator.TabIndex = 0;
            this.phone_book_tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // phone_book_tableBindingSource
            // 
            this.phone_book_tableBindingSource.DataMember = "phone_book_table";
            this.phone_book_tableBindingSource.DataSource = this.pb_dataset;
            // 
            // pb_dataset
            // 
            this.pb_dataset.DataSetName = "pb_dataset";
            this.pb_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(39, 34);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "전체 항목 수";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "위치";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "현재 위치";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 39);
            // 
            // phone_book_tableDataGridView
            // 
            this.phone_book_tableDataGridView.AllowUserToAddRows = false;
            this.phone_book_tableDataGridView.AllowUserToDeleteRows = false;
            this.phone_book_tableDataGridView.AllowUserToOrderColumns = true;
            this.phone_book_tableDataGridView.AllowUserToResizeRows = false;
            this.phone_book_tableDataGridView.AutoGenerateColumns = false;
            this.phone_book_tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phone_book_tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewImageColumn1});
            this.phone_book_tableDataGridView.DataSource = this.phone_book_tableBindingSource;
            this.phone_book_tableDataGridView.Location = new System.Drawing.Point(13, 564);
            this.phone_book_tableDataGridView.Name = "phone_book_tableDataGridView";
            this.phone_book_tableDataGridView.ReadOnly = true;
            this.phone_book_tableDataGridView.RowHeadersWidth = 62;
            this.phone_book_tableDataGridView.RowTemplate.Height = 30;
            this.phone_book_tableDataGridView.Size = new System.Drawing.Size(1349, 350);
            this.phone_book_tableDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "first_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "first_name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "last_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "last_name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "customer_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "customer_id";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "income";
            this.dataGridViewTextBoxColumn5.HeaderText = "income";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "debt";
            this.dataGridViewTextBoxColumn6.HeaderText = "debt";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "birth_date";
            this.dataGridViewTextBoxColumn7.HeaderText = "birth_date";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn8.HeaderText = "gender";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "education";
            this.dataGridViewTextBoxColumn9.HeaderText = "education";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "study_field";
            this.dataGridViewTextBoxColumn10.HeaderText = "study_field";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "cell_phone1";
            this.dataGridViewTextBoxColumn11.HeaderText = "cell_phone1";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "cell_phone2";
            this.dataGridViewTextBoxColumn12.HeaderText = "cell_phone2";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "landline1";
            this.dataGridViewTextBoxColumn13.HeaderText = "landline1";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "landline2";
            this.dataGridViewTextBoxColumn14.HeaderText = "landline2";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 150;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "fax";
            this.dataGridViewTextBoxColumn15.HeaderText = "fax";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 150;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn16.HeaderText = "email";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 150;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "web_url";
            this.dataGridViewTextBoxColumn17.HeaderText = "web_url";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 150;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "country";
            this.dataGridViewTextBoxColumn18.HeaderText = "country";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 150;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "state";
            this.dataGridViewTextBoxColumn19.HeaderText = "state";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 150;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "city";
            this.dataGridViewTextBoxColumn20.HeaderText = "city";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 150;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "zip_code";
            this.dataGridViewTextBoxColumn21.HeaderText = "zip_code";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 150;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "address1";
            this.dataGridViewTextBoxColumn22.HeaderText = "address1";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Width = 150;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "address2";
            this.dataGridViewTextBoxColumn23.HeaderText = "address2";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Width = 150;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "co_name";
            this.dataGridViewTextBoxColumn24.HeaderText = "co_name";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Width = 150;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "activity";
            this.dataGridViewTextBoxColumn25.HeaderText = "activity";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Width = 150;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "comment";
            this.dataGridViewTextBoxColumn26.HeaderText = "comment";
            this.dataGridViewTextBoxColumn26.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Width = 150;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "customer_image";
            this.dataGridViewImageColumn1.HeaderText = "customer_image";
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 150;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(186, 25);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(266, 28);
            this.idTextBox.TabIndex = 3;
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "first_name", true));
            this.first_nameTextBox.Location = new System.Drawing.Point(186, 59);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(266, 28);
            this.first_nameTextBox.TabIndex = 5;
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "last_name", true));
            this.last_nameTextBox.Location = new System.Drawing.Point(186, 93);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(266, 28);
            this.last_nameTextBox.TabIndex = 7;
            // 
            // customer_idTextBox
            // 
            this.customer_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "customer_id", true));
            this.customer_idTextBox.Location = new System.Drawing.Point(186, 127);
            this.customer_idTextBox.Name = "customer_idTextBox";
            this.customer_idTextBox.Size = new System.Drawing.Size(266, 28);
            this.customer_idTextBox.TabIndex = 9;
            // 
            // incomeTextBox
            // 
            this.incomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "income", true));
            this.incomeTextBox.Location = new System.Drawing.Point(186, 161);
            this.incomeTextBox.Name = "incomeTextBox";
            this.incomeTextBox.Size = new System.Drawing.Size(266, 28);
            this.incomeTextBox.TabIndex = 11;
            // 
            // debtTextBox
            // 
            this.debtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "debt", true));
            this.debtTextBox.Location = new System.Drawing.Point(186, 195);
            this.debtTextBox.Name = "debtTextBox";
            this.debtTextBox.Size = new System.Drawing.Size(266, 28);
            this.debtTextBox.TabIndex = 13;
            // 
            // birth_dateDateTimePicker
            // 
            this.birth_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.phone_book_tableBindingSource, "birth_date", true));
            this.birth_dateDateTimePicker.Location = new System.Drawing.Point(186, 229);
            this.birth_dateDateTimePicker.Name = "birth_dateDateTimePicker";
            this.birth_dateDateTimePicker.Size = new System.Drawing.Size(266, 28);
            this.birth_dateDateTimePicker.TabIndex = 15;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(186, 263);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(266, 28);
            this.genderTextBox.TabIndex = 17;
            // 
            // educationTextBox
            // 
            this.educationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "education", true));
            this.educationTextBox.Location = new System.Drawing.Point(186, 297);
            this.educationTextBox.Name = "educationTextBox";
            this.educationTextBox.Size = new System.Drawing.Size(266, 28);
            this.educationTextBox.TabIndex = 19;
            // 
            // study_fieldTextBox
            // 
            this.study_fieldTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "study_field", true));
            this.study_fieldTextBox.Location = new System.Drawing.Point(186, 331);
            this.study_fieldTextBox.Name = "study_fieldTextBox";
            this.study_fieldTextBox.Size = new System.Drawing.Size(266, 28);
            this.study_fieldTextBox.TabIndex = 21;
            // 
            // cell_phone1TextBox
            // 
            this.cell_phone1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "cell_phone1", true));
            this.cell_phone1TextBox.Location = new System.Drawing.Point(186, 365);
            this.cell_phone1TextBox.Name = "cell_phone1TextBox";
            this.cell_phone1TextBox.Size = new System.Drawing.Size(266, 28);
            this.cell_phone1TextBox.TabIndex = 23;
            // 
            // cell_phone2TextBox
            // 
            this.cell_phone2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "cell_phone2", true));
            this.cell_phone2TextBox.Location = new System.Drawing.Point(186, 399);
            this.cell_phone2TextBox.Name = "cell_phone2TextBox";
            this.cell_phone2TextBox.Size = new System.Drawing.Size(266, 28);
            this.cell_phone2TextBox.TabIndex = 25;
            // 
            // landline1TextBox
            // 
            this.landline1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "landline1", true));
            this.landline1TextBox.Location = new System.Drawing.Point(186, 433);
            this.landline1TextBox.Name = "landline1TextBox";
            this.landline1TextBox.Size = new System.Drawing.Size(266, 28);
            this.landline1TextBox.TabIndex = 27;
            // 
            // landline2TextBox
            // 
            this.landline2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "landline2", true));
            this.landline2TextBox.Location = new System.Drawing.Point(651, 25);
            this.landline2TextBox.Name = "landline2TextBox";
            this.landline2TextBox.Size = new System.Drawing.Size(284, 28);
            this.landline2TextBox.TabIndex = 29;
            // 
            // faxTextBox
            // 
            this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "fax", true));
            this.faxTextBox.Location = new System.Drawing.Point(651, 59);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(284, 28);
            this.faxTextBox.TabIndex = 31;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(651, 93);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(284, 28);
            this.emailTextBox.TabIndex = 33;
            // 
            // web_urlTextBox
            // 
            this.web_urlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "web_url", true));
            this.web_urlTextBox.Location = new System.Drawing.Point(651, 127);
            this.web_urlTextBox.Name = "web_urlTextBox";
            this.web_urlTextBox.Size = new System.Drawing.Size(284, 28);
            this.web_urlTextBox.TabIndex = 35;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "country", true));
            this.countryTextBox.Location = new System.Drawing.Point(651, 161);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(284, 28);
            this.countryTextBox.TabIndex = 37;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "state", true));
            this.stateTextBox.Location = new System.Drawing.Point(651, 195);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(284, 28);
            this.stateTextBox.TabIndex = 39;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(651, 229);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(284, 28);
            this.cityTextBox.TabIndex = 41;
            // 
            // zip_codeTextBox
            // 
            this.zip_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "zip_code", true));
            this.zip_codeTextBox.Location = new System.Drawing.Point(651, 263);
            this.zip_codeTextBox.Name = "zip_codeTextBox";
            this.zip_codeTextBox.Size = new System.Drawing.Size(284, 28);
            this.zip_codeTextBox.TabIndex = 43;
            // 
            // address1TextBox
            // 
            this.address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "address1", true));
            this.address1TextBox.Location = new System.Drawing.Point(651, 297);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(284, 28);
            this.address1TextBox.TabIndex = 45;
            // 
            // address2TextBox
            // 
            this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "address2", true));
            this.address2TextBox.Location = new System.Drawing.Point(651, 331);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(284, 28);
            this.address2TextBox.TabIndex = 47;
            // 
            // co_nameTextBox
            // 
            this.co_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "co_name", true));
            this.co_nameTextBox.Location = new System.Drawing.Point(651, 365);
            this.co_nameTextBox.Name = "co_nameTextBox";
            this.co_nameTextBox.Size = new System.Drawing.Size(284, 28);
            this.co_nameTextBox.TabIndex = 49;
            // 
            // activityTextBox
            // 
            this.activityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "activity", true));
            this.activityTextBox.Location = new System.Drawing.Point(651, 399);
            this.activityTextBox.Name = "activityTextBox";
            this.activityTextBox.Size = new System.Drawing.Size(284, 28);
            this.activityTextBox.TabIndex = 51;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(651, 433);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(284, 28);
            this.commentTextBox.TabIndex = 53;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.study_fieldTextBox);
            this.groupBox1.Controls.Add(web_urlLabel);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.web_urlTextBox);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(countryLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(this.countryTextBox);
            this.groupBox1.Controls.Add(stateLabel);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.stateTextBox);
            this.groupBox1.Controls.Add(first_nameLabel);
            this.groupBox1.Controls.Add(cityLabel);
            this.groupBox1.Controls.Add(this.faxTextBox);
            this.groupBox1.Controls.Add(this.cityTextBox);
            this.groupBox1.Controls.Add(this.first_nameTextBox);
            this.groupBox1.Controls.Add(zip_codeLabel);
            this.groupBox1.Controls.Add(faxLabel);
            this.groupBox1.Controls.Add(this.zip_codeTextBox);
            this.groupBox1.Controls.Add(last_nameLabel);
            this.groupBox1.Controls.Add(address1Label);
            this.groupBox1.Controls.Add(this.landline2TextBox);
            this.groupBox1.Controls.Add(this.address1TextBox);
            this.groupBox1.Controls.Add(this.last_nameTextBox);
            this.groupBox1.Controls.Add(address2Label);
            this.groupBox1.Controls.Add(landline2Label);
            this.groupBox1.Controls.Add(this.address2TextBox);
            this.groupBox1.Controls.Add(customer_idLabel);
            this.groupBox1.Controls.Add(co_nameLabel);
            this.groupBox1.Controls.Add(this.landline1TextBox);
            this.groupBox1.Controls.Add(this.co_nameTextBox);
            this.groupBox1.Controls.Add(this.customer_idTextBox);
            this.groupBox1.Controls.Add(activityLabel);
            this.groupBox1.Controls.Add(landline1Label);
            this.groupBox1.Controls.Add(this.activityTextBox);
            this.groupBox1.Controls.Add(incomeLabel);
            this.groupBox1.Controls.Add(commentLabel);
            this.groupBox1.Controls.Add(this.cell_phone2TextBox);
            this.groupBox1.Controls.Add(this.commentTextBox);
            this.groupBox1.Controls.Add(this.incomeTextBox);
            this.groupBox1.Controls.Add(cell_phone2Label);
            this.groupBox1.Controls.Add(debtLabel);
            this.groupBox1.Controls.Add(this.cell_phone1TextBox);
            this.groupBox1.Controls.Add(this.debtTextBox);
            this.groupBox1.Controls.Add(cell_phone1Label);
            this.groupBox1.Controls.Add(birth_dateLabel);
            this.groupBox1.Controls.Add(study_fieldLabel);
            this.groupBox1.Controls.Add(this.birth_dateDateTimePicker);
            this.groupBox1.Controls.Add(this.educationTextBox);
            this.groupBox1.Controls.Add(genderLabel);
            this.groupBox1.Controls.Add(educationLabel);
            this.groupBox1.Controls.Add(this.genderTextBox);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1349, 483);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Costomer Info";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddNew,
            this.toolStripSeparator4,
            this.btnEdit,
            this.toolStripSeparator5,
            this.btnDel,
            this.toolStripSeparator6,
            this.btnSave,
            this.toolStripSeparator7,
            this.btnCencel,
            this.toolStripSeparator8});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1373, 72);
            this.toolStrip1.TabIndex = 55;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 72);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 72);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 72);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 72);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 72);
            // 
            // phone_book_tableTableAdapter
            // 
            this.phone_book_tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.phone_book_tableTableAdapter = this.phone_book_tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Phone_Book.DataSet.pb_datasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(86, 243);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(208, 43);
            this.btnBrowse.TabIndex = 54;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Location = new System.Drawing.Point(960, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 436);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Photo";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(117, 67);
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(70, 67);
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(93, 67);
            this.btnDel.Text = "Delete";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 67);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCencel
            // 
            this.btnCencel.Image = ((System.Drawing.Image)(resources.GetObject("btnCencel.Image")));
            this.btnCencel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCencel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCencel.Name = "btnCencel";
            this.btnCencel.Size = new System.Drawing.Size(93, 67);
            this.btnCencel.Text = "Cancel";
            this.btnCencel.Click += new System.EventHandler(this.btnCencel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.phone_book_tableBindingSource, "customer_image", true));
            this.pictureBox1.Image = global::Phone_Book.Properties.Resources.no_image;
            this.pictureBox1.Location = new System.Drawing.Point(38, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(118, 34);
            this.bindingNavigatorAddNewItem.Text = "새로 추가";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(76, 34);
            this.bindingNavigatorDeleteItem.Text = "삭제";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 34);
            this.bindingNavigatorMoveFirstItem.Text = "처음으로 이동";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 34);
            this.bindingNavigatorMovePreviousItem.Text = "이전으로 이동";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 34);
            this.bindingNavigatorMoveNextItem.Text = "다음으로 이동";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 34);
            this.bindingNavigatorMoveLastItem.Text = "마지막으로 이동";
            // 
            // phone_book_tableBindingNavigatorSaveItem
            // 
            this.phone_book_tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("phone_book_tableBindingNavigatorSaveItem.Image")));
            this.phone_book_tableBindingNavigatorSaveItem.Name = "phone_book_tableBindingNavigatorSaveItem";
            this.phone_book_tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(136, 34);
            this.phone_book_tableBindingNavigatorSaveItem.Text = "데이터 저장";
            this.phone_book_tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.phone_book_tableBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(189, 34);
            this.toolStripButton1.Text = "Show Income Info";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image File|.*JPG;*.PNG;*.BMP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1373, 956);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.phone_book_tableDataGridView);
            this.Controls.Add(this.phone_book_tableBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phone Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phone_book_tableBindingNavigator)).EndInit();
            this.phone_book_tableBindingNavigator.ResumeLayout(false);
            this.phone_book_tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phone_book_tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_book_tableDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet.pb_dataset pb_dataset;
        private System.Windows.Forms.BindingSource phone_book_tableBindingSource;
        private DataSet.pb_datasetTableAdapters.phone_book_tableTableAdapter phone_book_tableTableAdapter;
        private DataSet.pb_datasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator phone_book_tableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton phone_book_tableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView phone_book_tableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.TextBox customer_idTextBox;
        private System.Windows.Forms.TextBox incomeTextBox;
        private System.Windows.Forms.TextBox debtTextBox;
        private System.Windows.Forms.DateTimePicker birth_dateDateTimePicker;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox educationTextBox;
        private System.Windows.Forms.TextBox study_fieldTextBox;
        private System.Windows.Forms.TextBox cell_phone1TextBox;
        private System.Windows.Forms.TextBox cell_phone2TextBox;
        private System.Windows.Forms.TextBox landline1TextBox;
        private System.Windows.Forms.TextBox landline2TextBox;
        private System.Windows.Forms.TextBox faxTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox web_urlTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox zip_codeTextBox;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox co_nameTextBox;
        private System.Windows.Forms.TextBox activityTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btnCencel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

