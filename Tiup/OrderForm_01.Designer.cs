namespace Tiup
{
    partial class OrderForm_01
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
            this.CourseGrp_01 = new System.Windows.Forms.GroupBox();
            this.rdoSvc_Advanced = new System.Windows.Forms.RadioButton();
            this.rdoSvc_Intermediate = new System.Windows.Forms.RadioButton();
            this.rdoSvc_Beginner = new System.Windows.Forms.RadioButton();
            this.LevelGrp_01 = new System.Windows.Forms.GroupBox();
            this.rdoLevel_low = new System.Windows.Forms.RadioButton();
            this.rdoLevel_medium = new System.Windows.Forms.RadioButton();
            this.rdoLevel_high = new System.Windows.Forms.RadioButton();
            this.RoomGrp_01 = new System.Windows.Forms.GroupBox();
            this.rdoRoom_09 = new System.Windows.Forms.RadioButton();
            this.rdoRoom_08 = new System.Windows.Forms.RadioButton();
            this.rdoRoom_07 = new System.Windows.Forms.RadioButton();
            this.rdoRoom_06 = new System.Windows.Forms.RadioButton();
            this.rdoRoom_05 = new System.Windows.Forms.RadioButton();
            this.rdoRoom_04 = new System.Windows.Forms.RadioButton();
            this.rdoRoom_03 = new System.Windows.Forms.RadioButton();
            this.rdoRoom_02 = new System.Windows.Forms.RadioButton();
            this.rdoRoom_01 = new System.Windows.Forms.RadioButton();
            this.lstBxDisplay_01 = new System.Windows.Forms.ListBox();
            this.SnackGrp_01 = new System.Windows.Forms.GroupBox();
            this.SnackUpDn_03 = new System.Windows.Forms.NumericUpDown();
            this.SnackUpDn_02 = new System.Windows.Forms.NumericUpDown();
            this.SnackUpDn_01 = new System.Windows.Forms.NumericUpDown();
            this.chkBxSnack_03 = new System.Windows.Forms.CheckBox();
            this.chkBxSnack_02 = new System.Windows.Forms.CheckBox();
            this.chkBxSnack_01 = new System.Windows.Forms.CheckBox();
            this.DrinkGrp_01 = new System.Windows.Forms.GroupBox();
            this.DrinkUpDn_03 = new System.Windows.Forms.NumericUpDown();
            this.chkBxDrink_01 = new System.Windows.Forms.CheckBox();
            this.DrinkUpDn_02 = new System.Windows.Forms.NumericUpDown();
            this.chkBxDrink_02 = new System.Windows.Forms.CheckBox();
            this.DrinkUpDn_01 = new System.Windows.Forms.NumericUpDown();
            this.chkBxDrink_03 = new System.Windows.Forms.CheckBox();
            this.btnOrder_01 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CourseGrp_01.SuspendLayout();
            this.LevelGrp_01.SuspendLayout();
            this.RoomGrp_01.SuspendLayout();
            this.SnackGrp_01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SnackUpDn_03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SnackUpDn_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SnackUpDn_01)).BeginInit();
            this.DrinkGrp_01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrinkUpDn_03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrinkUpDn_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrinkUpDn_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseGrp_01
            // 
            this.CourseGrp_01.Controls.Add(this.rdoSvc_Advanced);
            this.CourseGrp_01.Controls.Add(this.rdoSvc_Intermediate);
            this.CourseGrp_01.Controls.Add(this.rdoSvc_Beginner);
            this.CourseGrp_01.Location = new System.Drawing.Point(12, 12);
            this.CourseGrp_01.Name = "CourseGrp_01";
            this.CourseGrp_01.Size = new System.Drawing.Size(193, 109);
            this.CourseGrp_01.TabIndex = 0;
            this.CourseGrp_01.TabStop = false;
            this.CourseGrp_01.Text = "티업코스";
            // 
            // rdoSvc_Advanced
            // 
            this.rdoSvc_Advanced.AutoSize = true;
            this.rdoSvc_Advanced.Location = new System.Drawing.Point(17, 72);
            this.rdoSvc_Advanced.Name = "rdoSvc_Advanced";
            this.rdoSvc_Advanced.Size = new System.Drawing.Size(153, 16);
            this.rdoSvc_Advanced.TabIndex = 2;
            this.rdoSvc_Advanced.TabStop = true;
            this.rdoSvc_Advanced.Text = "고급자 (1인당 30,000원)";
            this.rdoSvc_Advanced.UseVisualStyleBackColor = true;
            // 
            // rdoSvc_Intermediate
            // 
            this.rdoSvc_Intermediate.AutoSize = true;
            this.rdoSvc_Intermediate.Location = new System.Drawing.Point(17, 50);
            this.rdoSvc_Intermediate.Name = "rdoSvc_Intermediate";
            this.rdoSvc_Intermediate.Size = new System.Drawing.Size(153, 16);
            this.rdoSvc_Intermediate.TabIndex = 1;
            this.rdoSvc_Intermediate.TabStop = true;
            this.rdoSvc_Intermediate.Text = "중급자 (1인당 25,000원)";
            this.rdoSvc_Intermediate.UseVisualStyleBackColor = true;
            // 
            // rdoSvc_Beginner
            // 
            this.rdoSvc_Beginner.AutoSize = true;
            this.rdoSvc_Beginner.Location = new System.Drawing.Point(17, 28);
            this.rdoSvc_Beginner.Name = "rdoSvc_Beginner";
            this.rdoSvc_Beginner.Size = new System.Drawing.Size(153, 16);
            this.rdoSvc_Beginner.TabIndex = 0;
            this.rdoSvc_Beginner.TabStop = true;
            this.rdoSvc_Beginner.Text = "초급자 (1인당 20,000원)";
            this.rdoSvc_Beginner.UseVisualStyleBackColor = true;
            // 
            // LevelGrp_01
            // 
            this.LevelGrp_01.Controls.Add(this.rdoLevel_low);
            this.LevelGrp_01.Controls.Add(this.rdoLevel_medium);
            this.LevelGrp_01.Controls.Add(this.rdoLevel_high);
            this.LevelGrp_01.Location = new System.Drawing.Point(12, 162);
            this.LevelGrp_01.Name = "LevelGrp_01";
            this.LevelGrp_01.Size = new System.Drawing.Size(193, 109);
            this.LevelGrp_01.TabIndex = 3;
            this.LevelGrp_01.TabStop = false;
            this.LevelGrp_01.Text = "난이도";
            // 
            // rdoLevel_low
            // 
            this.rdoLevel_low.AutoSize = true;
            this.rdoLevel_low.Location = new System.Drawing.Point(17, 72);
            this.rdoLevel_low.Name = "rdoLevel_low";
            this.rdoLevel_low.Size = new System.Drawing.Size(35, 16);
            this.rdoLevel_low.TabIndex = 2;
            this.rdoLevel_low.TabStop = true;
            this.rdoLevel_low.Text = "하";
            this.rdoLevel_low.UseVisualStyleBackColor = true;
            // 
            // rdoLevel_medium
            // 
            this.rdoLevel_medium.AutoSize = true;
            this.rdoLevel_medium.Location = new System.Drawing.Point(17, 50);
            this.rdoLevel_medium.Name = "rdoLevel_medium";
            this.rdoLevel_medium.Size = new System.Drawing.Size(35, 16);
            this.rdoLevel_medium.TabIndex = 1;
            this.rdoLevel_medium.TabStop = true;
            this.rdoLevel_medium.Text = "중";
            this.rdoLevel_medium.UseVisualStyleBackColor = true;
            // 
            // rdoLevel_high
            // 
            this.rdoLevel_high.AutoSize = true;
            this.rdoLevel_high.Location = new System.Drawing.Point(17, 28);
            this.rdoLevel_high.Name = "rdoLevel_high";
            this.rdoLevel_high.Size = new System.Drawing.Size(35, 16);
            this.rdoLevel_high.TabIndex = 0;
            this.rdoLevel_high.TabStop = true;
            this.rdoLevel_high.Text = "상";
            this.rdoLevel_high.UseVisualStyleBackColor = true;
            // 
            // RoomGrp_01
            // 
            this.RoomGrp_01.Controls.Add(this.rdoRoom_09);
            this.RoomGrp_01.Controls.Add(this.rdoRoom_08);
            this.RoomGrp_01.Controls.Add(this.rdoRoom_07);
            this.RoomGrp_01.Controls.Add(this.rdoRoom_06);
            this.RoomGrp_01.Controls.Add(this.rdoRoom_05);
            this.RoomGrp_01.Controls.Add(this.rdoRoom_04);
            this.RoomGrp_01.Controls.Add(this.rdoRoom_03);
            this.RoomGrp_01.Controls.Add(this.rdoRoom_02);
            this.RoomGrp_01.Controls.Add(this.rdoRoom_01);
            this.RoomGrp_01.Location = new System.Drawing.Point(12, 626);
            this.RoomGrp_01.Name = "RoomGrp_01";
            this.RoomGrp_01.Size = new System.Drawing.Size(602, 112);
            this.RoomGrp_01.TabIndex = 3;
            this.RoomGrp_01.TabStop = false;
            this.RoomGrp_01.Text = " 룸 배정";
            // 
            // rdoRoom_09
            // 
            this.rdoRoom_09.AutoSize = true;
            this.rdoRoom_09.Location = new System.Drawing.Point(204, 72);
            this.rdoRoom_09.Name = "rdoRoom_09";
            this.rdoRoom_09.Size = new System.Drawing.Size(47, 16);
            this.rdoRoom_09.TabIndex = 10;
            this.rdoRoom_09.TabStop = true;
            this.rdoRoom_09.Text = "09룸";
            this.rdoRoom_09.UseVisualStyleBackColor = true;
            // 
            // rdoRoom_08
            // 
            this.rdoRoom_08.AutoSize = true;
            this.rdoRoom_08.Location = new System.Drawing.Point(204, 50);
            this.rdoRoom_08.Name = "rdoRoom_08";
            this.rdoRoom_08.Size = new System.Drawing.Size(47, 16);
            this.rdoRoom_08.TabIndex = 9;
            this.rdoRoom_08.TabStop = true;
            this.rdoRoom_08.Text = "08룸";
            this.rdoRoom_08.UseVisualStyleBackColor = true;
            // 
            // rdoRoom_07
            // 
            this.rdoRoom_07.AutoSize = true;
            this.rdoRoom_07.Location = new System.Drawing.Point(204, 28);
            this.rdoRoom_07.Name = "rdoRoom_07";
            this.rdoRoom_07.Size = new System.Drawing.Size(47, 16);
            this.rdoRoom_07.TabIndex = 8;
            this.rdoRoom_07.TabStop = true;
            this.rdoRoom_07.Text = "07룸";
            this.rdoRoom_07.UseVisualStyleBackColor = true;
            // 
            // rdoRoom_06
            // 
            this.rdoRoom_06.AutoSize = true;
            this.rdoRoom_06.Location = new System.Drawing.Point(111, 72);
            this.rdoRoom_06.Name = "rdoRoom_06";
            this.rdoRoom_06.Size = new System.Drawing.Size(47, 16);
            this.rdoRoom_06.TabIndex = 7;
            this.rdoRoom_06.TabStop = true;
            this.rdoRoom_06.Text = "06룸";
            this.rdoRoom_06.UseVisualStyleBackColor = true;
            // 
            // rdoRoom_05
            // 
            this.rdoRoom_05.AutoSize = true;
            this.rdoRoom_05.Location = new System.Drawing.Point(111, 50);
            this.rdoRoom_05.Name = "rdoRoom_05";
            this.rdoRoom_05.Size = new System.Drawing.Size(47, 16);
            this.rdoRoom_05.TabIndex = 6;
            this.rdoRoom_05.TabStop = true;
            this.rdoRoom_05.Text = "05룸";
            this.rdoRoom_05.UseVisualStyleBackColor = true;
            // 
            // rdoRoom_04
            // 
            this.rdoRoom_04.AutoSize = true;
            this.rdoRoom_04.Location = new System.Drawing.Point(111, 28);
            this.rdoRoom_04.Name = "rdoRoom_04";
            this.rdoRoom_04.Size = new System.Drawing.Size(47, 16);
            this.rdoRoom_04.TabIndex = 5;
            this.rdoRoom_04.TabStop = true;
            this.rdoRoom_04.Text = "04룸";
            this.rdoRoom_04.UseVisualStyleBackColor = true;
            // 
            // rdoRoom_03
            // 
            this.rdoRoom_03.AutoSize = true;
            this.rdoRoom_03.Location = new System.Drawing.Point(17, 72);
            this.rdoRoom_03.Name = "rdoRoom_03";
            this.rdoRoom_03.Size = new System.Drawing.Size(47, 16);
            this.rdoRoom_03.TabIndex = 2;
            this.rdoRoom_03.TabStop = true;
            this.rdoRoom_03.Text = "03룸";
            this.rdoRoom_03.UseVisualStyleBackColor = true;
            // 
            // rdoRoom_02
            // 
            this.rdoRoom_02.AutoSize = true;
            this.rdoRoom_02.Location = new System.Drawing.Point(17, 50);
            this.rdoRoom_02.Name = "rdoRoom_02";
            this.rdoRoom_02.Size = new System.Drawing.Size(47, 16);
            this.rdoRoom_02.TabIndex = 1;
            this.rdoRoom_02.TabStop = true;
            this.rdoRoom_02.Text = "02룸";
            this.rdoRoom_02.UseVisualStyleBackColor = true;
            // 
            // rdoRoom_01
            // 
            this.rdoRoom_01.AutoSize = true;
            this.rdoRoom_01.Location = new System.Drawing.Point(17, 28);
            this.rdoRoom_01.Name = "rdoRoom_01";
            this.rdoRoom_01.Size = new System.Drawing.Size(47, 16);
            this.rdoRoom_01.TabIndex = 0;
            this.rdoRoom_01.TabStop = true;
            this.rdoRoom_01.Text = "01룸";
            this.rdoRoom_01.UseVisualStyleBackColor = true;
            // 
            // lstBxDisplay_01
            // 
            this.lstBxDisplay_01.FormattingEnabled = true;
            this.lstBxDisplay_01.ItemHeight = 12;
            this.lstBxDisplay_01.Location = new System.Drawing.Point(12, 903);
            this.lstBxDisplay_01.Name = "lstBxDisplay_01";
            this.lstBxDisplay_01.Size = new System.Drawing.Size(602, 292);
            this.lstBxDisplay_01.TabIndex = 4;
            // 
            // SnackGrp_01
            // 
            this.SnackGrp_01.Controls.Add(this.SnackUpDn_03);
            this.SnackGrp_01.Controls.Add(this.SnackUpDn_02);
            this.SnackGrp_01.Controls.Add(this.SnackUpDn_01);
            this.SnackGrp_01.Controls.Add(this.chkBxSnack_03);
            this.SnackGrp_01.Controls.Add(this.chkBxSnack_02);
            this.SnackGrp_01.Controls.Add(this.chkBxSnack_01);
            this.SnackGrp_01.Location = new System.Drawing.Point(12, 315);
            this.SnackGrp_01.Name = "SnackGrp_01";
            this.SnackGrp_01.Size = new System.Drawing.Size(193, 109);
            this.SnackGrp_01.TabIndex = 4;
            this.SnackGrp_01.TabStop = false;
            this.SnackGrp_01.Text = "스낵";
            // 
            // SnackUpDn_03
            // 
            this.SnackUpDn_03.Location = new System.Drawing.Point(156, 74);
            this.SnackUpDn_03.Name = "SnackUpDn_03";
            this.SnackUpDn_03.Size = new System.Drawing.Size(31, 21);
            this.SnackUpDn_03.TabIndex = 15;
            this.SnackUpDn_03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SnackUpDn_02
            // 
            this.SnackUpDn_02.Location = new System.Drawing.Point(157, 47);
            this.SnackUpDn_02.Name = "SnackUpDn_02";
            this.SnackUpDn_02.Size = new System.Drawing.Size(31, 21);
            this.SnackUpDn_02.TabIndex = 14;
            this.SnackUpDn_02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SnackUpDn_01
            // 
            this.SnackUpDn_01.Location = new System.Drawing.Point(156, 20);
            this.SnackUpDn_01.Name = "SnackUpDn_01";
            this.SnackUpDn_01.Size = new System.Drawing.Size(31, 21);
            this.SnackUpDn_01.TabIndex = 11;
            this.SnackUpDn_01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkBxSnack_03
            // 
            this.chkBxSnack_03.AutoSize = true;
            this.chkBxSnack_03.Location = new System.Drawing.Point(17, 77);
            this.chkBxSnack_03.Name = "chkBxSnack_03";
            this.chkBxSnack_03.Size = new System.Drawing.Size(110, 16);
            this.chkBxSnack_03.TabIndex = 13;
            this.chkBxSnack_03.Text = "새우깡(3,000원)";
            this.chkBxSnack_03.UseVisualStyleBackColor = true;
            // 
            // chkBxSnack_02
            // 
            this.chkBxSnack_02.AutoSize = true;
            this.chkBxSnack_02.Location = new System.Drawing.Point(17, 52);
            this.chkBxSnack_02.Name = "chkBxSnack_02";
            this.chkBxSnack_02.Size = new System.Drawing.Size(134, 16);
            this.chkBxSnack_02.TabIndex = 12;
            this.chkBxSnack_02.Text = "허니버터칩(3,000원)";
            this.chkBxSnack_02.UseVisualStyleBackColor = true;
            // 
            // chkBxSnack_01
            // 
            this.chkBxSnack_01.AutoSize = true;
            this.chkBxSnack_01.Location = new System.Drawing.Point(17, 25);
            this.chkBxSnack_01.Name = "chkBxSnack_01";
            this.chkBxSnack_01.Size = new System.Drawing.Size(110, 16);
            this.chkBxSnack_01.TabIndex = 11;
            this.chkBxSnack_01.Text = "컵라면(5,000원)";
            this.chkBxSnack_01.UseVisualStyleBackColor = true;
            // 
            // DrinkGrp_01
            // 
            this.DrinkGrp_01.Controls.Add(this.DrinkUpDn_03);
            this.DrinkGrp_01.Controls.Add(this.chkBxDrink_01);
            this.DrinkGrp_01.Controls.Add(this.DrinkUpDn_02);
            this.DrinkGrp_01.Controls.Add(this.chkBxDrink_02);
            this.DrinkGrp_01.Controls.Add(this.DrinkUpDn_01);
            this.DrinkGrp_01.Controls.Add(this.chkBxDrink_03);
            this.DrinkGrp_01.Location = new System.Drawing.Point(12, 468);
            this.DrinkGrp_01.Name = "DrinkGrp_01";
            this.DrinkGrp_01.Size = new System.Drawing.Size(193, 129);
            this.DrinkGrp_01.TabIndex = 5;
            this.DrinkGrp_01.TabStop = false;
            this.DrinkGrp_01.Text = "음료";
            // 
            // DrinkUpDn_03
            // 
            this.DrinkUpDn_03.Location = new System.Drawing.Point(156, 83);
            this.DrinkUpDn_03.Name = "DrinkUpDn_03";
            this.DrinkUpDn_03.Size = new System.Drawing.Size(31, 21);
            this.DrinkUpDn_03.TabIndex = 21;
            this.DrinkUpDn_03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkBxDrink_01
            // 
            this.chkBxDrink_01.AutoSize = true;
            this.chkBxDrink_01.Location = new System.Drawing.Point(17, 34);
            this.chkBxDrink_01.Name = "chkBxDrink_01";
            this.chkBxDrink_01.Size = new System.Drawing.Size(136, 16);
            this.chkBxDrink_01.TabIndex = 17;
            this.chkBxDrink_01.Text = "캔맥주(1EA 5,000원)";
            this.chkBxDrink_01.UseVisualStyleBackColor = true;
            // 
            // DrinkUpDn_02
            // 
            this.DrinkUpDn_02.Location = new System.Drawing.Point(157, 56);
            this.DrinkUpDn_02.Name = "DrinkUpDn_02";
            this.DrinkUpDn_02.Size = new System.Drawing.Size(31, 21);
            this.DrinkUpDn_02.TabIndex = 20;
            this.DrinkUpDn_02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkBxDrink_02
            // 
            this.chkBxDrink_02.AutoSize = true;
            this.chkBxDrink_02.Location = new System.Drawing.Point(17, 61);
            this.chkBxDrink_02.Name = "chkBxDrink_02";
            this.chkBxDrink_02.Size = new System.Drawing.Size(124, 16);
            this.chkBxDrink_02.TabIndex = 18;
            this.chkBxDrink_02.Text = "콜라(1EA 3,000원)";
            this.chkBxDrink_02.UseVisualStyleBackColor = true;
            // 
            // DrinkUpDn_01
            // 
            this.DrinkUpDn_01.Location = new System.Drawing.Point(156, 29);
            this.DrinkUpDn_01.Name = "DrinkUpDn_01";
            this.DrinkUpDn_01.Size = new System.Drawing.Size(31, 21);
            this.DrinkUpDn_01.TabIndex = 16;
            this.DrinkUpDn_01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkBxDrink_03
            // 
            this.chkBxDrink_03.AutoSize = true;
            this.chkBxDrink_03.Location = new System.Drawing.Point(17, 86);
            this.chkBxDrink_03.Name = "chkBxDrink_03";
            this.chkBxDrink_03.Size = new System.Drawing.Size(136, 16);
            this.chkBxDrink_03.TabIndex = 19;
            this.chkBxDrink_03.Text = "사이다(1EA 3,000원)";
            this.chkBxDrink_03.UseVisualStyleBackColor = true;
            // 
            // btnOrder_01
            // 
            this.btnOrder_01.BackColor = System.Drawing.Color.Blue;
            this.btnOrder_01.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrder_01.Font = new System.Drawing.Font("돋움", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOrder_01.ForeColor = System.Drawing.Color.Red;
            this.btnOrder_01.Location = new System.Drawing.Point(54, 784);
            this.btnOrder_01.Name = "btnOrder_01";
            this.btnOrder_01.Size = new System.Drawing.Size(151, 51);
            this.btnOrder_01.TabIndex = 6;
            this.btnOrder_01.Text = "결 제";
            this.btnOrder_01.UseVisualStyleBackColor = false;
            this.btnOrder_01.Click += new System.EventHandler(this.btnOrder_01_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(216, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(398, 575);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("돋움", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(243, 784);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 51);
            this.button1.TabIndex = 16;
            this.button1.Text = "취 소";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // OrderForm_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 1220);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOrder_01);
            this.Controls.Add(this.DrinkGrp_01);
            this.Controls.Add(this.SnackGrp_01);
            this.Controls.Add(this.lstBxDisplay_01);
            this.Controls.Add(this.RoomGrp_01);
            this.Controls.Add(this.LevelGrp_01);
            this.Controls.Add(this.CourseGrp_01);
            this.Name = "OrderForm_01";
            this.Text = "티업";
            this.CourseGrp_01.ResumeLayout(false);
            this.CourseGrp_01.PerformLayout();
            this.LevelGrp_01.ResumeLayout(false);
            this.LevelGrp_01.PerformLayout();
            this.RoomGrp_01.ResumeLayout(false);
            this.RoomGrp_01.PerformLayout();
            this.SnackGrp_01.ResumeLayout(false);
            this.SnackGrp_01.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SnackUpDn_03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SnackUpDn_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SnackUpDn_01)).EndInit();
            this.DrinkGrp_01.ResumeLayout(false);
            this.DrinkGrp_01.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrinkUpDn_03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrinkUpDn_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrinkUpDn_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CourseGrp_01;
        private System.Windows.Forms.RadioButton rdoSvc_Advanced;
        private System.Windows.Forms.RadioButton rdoSvc_Intermediate;
        private System.Windows.Forms.RadioButton rdoSvc_Beginner;
        private System.Windows.Forms.GroupBox LevelGrp_01;
        private System.Windows.Forms.RadioButton rdoLevel_low;
        private System.Windows.Forms.RadioButton rdoLevel_medium;
        private System.Windows.Forms.RadioButton rdoLevel_high;
        private System.Windows.Forms.GroupBox RoomGrp_01;
        private System.Windows.Forms.RadioButton rdoRoom_09;
        private System.Windows.Forms.RadioButton rdoRoom_08;
        private System.Windows.Forms.RadioButton rdoRoom_07;
        private System.Windows.Forms.RadioButton rdoRoom_06;
        private System.Windows.Forms.RadioButton rdoRoom_05;
        private System.Windows.Forms.RadioButton rdoRoom_04;
        private System.Windows.Forms.RadioButton rdoRoom_03;
        private System.Windows.Forms.RadioButton rdoRoom_02;
        private System.Windows.Forms.RadioButton rdoRoom_01;
        private System.Windows.Forms.ListBox lstBxDisplay_01;
        private System.Windows.Forms.GroupBox SnackGrp_01;
        private System.Windows.Forms.GroupBox DrinkGrp_01;
        private System.Windows.Forms.NumericUpDown SnackUpDn_03;
        private System.Windows.Forms.NumericUpDown SnackUpDn_02;
        private System.Windows.Forms.NumericUpDown SnackUpDn_01;
        private System.Windows.Forms.CheckBox chkBxSnack_03;
        private System.Windows.Forms.CheckBox chkBxSnack_02;
        private System.Windows.Forms.CheckBox chkBxSnack_01;
        private System.Windows.Forms.NumericUpDown DrinkUpDn_03;
        private System.Windows.Forms.CheckBox chkBxDrink_01;
        private System.Windows.Forms.NumericUpDown DrinkUpDn_02;
        private System.Windows.Forms.CheckBox chkBxDrink_02;
        private System.Windows.Forms.NumericUpDown DrinkUpDn_01;
        private System.Windows.Forms.CheckBox chkBxDrink_03;
        private System.Windows.Forms.Button btnOrder_01;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}

