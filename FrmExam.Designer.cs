﻿namespace FrmExam
{
    partial class FrmExam
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
            GroupBox gbParams;
            TreeNode treeNode1 = new TreeNode("Узел2");
            TreeNode treeNode2 = new TreeNode("Узел1", new TreeNode[] { treeNode1 });
            TreeNode treeNode3 = new TreeNode("Узел0", new TreeNode[] { treeNode2 });
            tbcInfo = new TabControl();
            tbpObject = new TabPage();
            tbObjectName = new TextBox();
            tbAddress = new TextBox();
            lblTasksCount = new Label();
            tbCadastralNumber = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblObjectId = new Label();
            label2 = new Label();
            tbpTask = new TabPage();
            tbTaskDescription = new RichTextBox();
            label7 = new Label();
            lblTaskId = new Label();
            label9 = new Label();
            tbpDecision = new TabPage();
            btnEndDate = new Button();
            btnStartDate = new Button();
            cbbStatus = new ComboBox();
            tbStartDate = new TextBox();
            tbEndDate = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            tbDecisionDescription = new RichTextBox();
            label8 = new Label();
            lblDecisionId = new Label();
            label11 = new Label();
            tbpUser = new TabPage();
            tbPersonName = new TextBox();
            cbbPosition = new ComboBox();
            label18 = new Label();
            label17 = new Label();
            lblPersonId = new Label();
            label16 = new Label();
            pnlMessage = new Panel();
            lblMessage = new Label();
            pnlMain = new Panel();
            btnRefresh = new Button();
            lblCount = new Label();
            label1 = new Label();
            btnDel = new Button();
            btnMod = new Button();
            btnAdd = new Button();
            tvMain = new TreeView();
            gbParams = new GroupBox();
            gbParams.SuspendLayout();
            tbcInfo.SuspendLayout();
            tbpObject.SuspendLayout();
            tbpTask.SuspendLayout();
            tbpDecision.SuspendLayout();
            tbpUser.SuspendLayout();
            pnlMessage.SuspendLayout();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // gbParams
            // 
            gbParams.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbParams.Controls.Add(tbcInfo);
            gbParams.Font = new Font("Segoe UI Semibold", 9F);
            gbParams.Location = new Point(309, 12);
            gbParams.Name = "gbParams";
            gbParams.Size = new Size(461, 299);
            gbParams.TabIndex = 4;
            gbParams.TabStop = false;
            gbParams.Text = "Информация об объекте";
            // 
            // tbcInfo
            // 
            tbcInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbcInfo.Controls.Add(tbpObject);
            tbcInfo.Controls.Add(tbpTask);
            tbcInfo.Controls.Add(tbpDecision);
            tbcInfo.Controls.Add(tbpUser);
            tbcInfo.Location = new Point(11, 26);
            tbcInfo.Name = "tbcInfo";
            tbcInfo.SelectedIndex = 0;
            tbcInfo.Size = new Size(444, 266);
            tbcInfo.TabIndex = 0;
            // 
            // tbpObject
            // 
            tbpObject.Controls.Add(tbObjectName);
            tbpObject.Controls.Add(tbAddress);
            tbpObject.Controls.Add(lblTasksCount);
            tbpObject.Controls.Add(tbCadastralNumber);
            tbpObject.Controls.Add(label6);
            tbpObject.Controls.Add(label5);
            tbpObject.Controls.Add(label4);
            tbpObject.Controls.Add(label3);
            tbpObject.Controls.Add(lblObjectId);
            tbpObject.Controls.Add(label2);
            tbpObject.Location = new Point(4, 29);
            tbpObject.Name = "tbpObject";
            tbpObject.Padding = new Padding(3);
            tbpObject.Size = new Size(436, 233);
            tbpObject.TabIndex = 0;
            tbpObject.Text = "Объект";
            tbpObject.UseVisualStyleBackColor = true;
            // 
            // tbObjectName
            // 
            tbObjectName.Location = new Point(173, 40);
            tbObjectName.Name = "tbObjectName";
            tbObjectName.Size = new Size(257, 27);
            tbObjectName.TabIndex = 9;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(173, 73);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(257, 27);
            tbAddress.TabIndex = 8;
            // 
            // lblTasksCount
            // 
            lblTasksCount.AutoSize = true;
            lblTasksCount.Font = new Font("Segoe UI", 9F);
            lblTasksCount.Location = new Point(173, 136);
            lblTasksCount.Margin = new Padding(8, 0, 8, 0);
            lblTasksCount.Name = "lblTasksCount";
            lblTasksCount.Size = new Size(33, 20);
            lblTasksCount.TabIndex = 7;
            lblTasksCount.Text = "999";
            // 
            // tbCadastralNumber
            // 
            tbCadastralNumber.Location = new Point(173, 106);
            tbCadastralNumber.Name = "tbCadastralNumber";
            tbCadastralNumber.Size = new Size(257, 27);
            tbCadastralNumber.TabIndex = 6;
            tbCadastralNumber.TextChanged += tbCadastralNumber_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(8, 136);
            label6.Margin = new Padding(8, 0, 8, 0);
            label6.Name = "label6";
            label6.Size = new Size(136, 20);
            label6.TabIndex = 5;
            label6.Text = "Количество задач:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(8, 109);
            label5.Margin = new Padding(8, 0, 8, 0);
            label5.Name = "label5";
            label5.Size = new Size(154, 20);
            label5.TabIndex = 4;
            label5.Text = "Кадастровый номер:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(8, 76);
            label4.Margin = new Padding(8, 0, 8, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "Адрес:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(8, 43);
            label3.Margin = new Padding(8, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 2;
            label3.Text = "Название:";
            // 
            // lblObjectId
            // 
            lblObjectId.AutoSize = true;
            lblObjectId.Font = new Font("Segoe UI", 9F);
            lblObjectId.Location = new Point(173, 9);
            lblObjectId.Margin = new Padding(8, 0, 8, 0);
            lblObjectId.Name = "lblObjectId";
            lblObjectId.Size = new Size(33, 20);
            lblObjectId.TabIndex = 1;
            lblObjectId.Text = "999";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(8, 12);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 0;
            label2.Text = "ID:";
            // 
            // tbpTask
            // 
            tbpTask.Controls.Add(tbTaskDescription);
            tbpTask.Controls.Add(label7);
            tbpTask.Controls.Add(lblTaskId);
            tbpTask.Controls.Add(label9);
            tbpTask.Location = new Point(4, 29);
            tbpTask.Name = "tbpTask";
            tbpTask.Padding = new Padding(3);
            tbpTask.Size = new Size(436, 233);
            tbpTask.TabIndex = 1;
            tbpTask.Text = "Задача";
            tbpTask.UseVisualStyleBackColor = true;
            // 
            // tbTaskDescription
            // 
            tbTaskDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbTaskDescription.Location = new Point(141, 47);
            tbTaskDescription.Name = "tbTaskDescription";
            tbTaskDescription.Size = new Size(275, 165);
            tbTaskDescription.TabIndex = 13;
            tbTaskDescription.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(8, 47);
            label7.Margin = new Padding(8, 0, 8, 0);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 12;
            label7.Text = "Описане задачи";
            // 
            // lblTaskId
            // 
            lblTaskId.AutoSize = true;
            lblTaskId.Font = new Font("Segoe UI", 9F);
            lblTaskId.Location = new Point(141, 12);
            lblTaskId.Margin = new Padding(8, 0, 8, 0);
            lblTaskId.Name = "lblTaskId";
            lblTaskId.Size = new Size(33, 20);
            lblTaskId.TabIndex = 11;
            lblTaskId.Text = "999";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F);
            label9.Location = new Point(8, 12);
            label9.Margin = new Padding(8, 0, 8, 0);
            label9.Name = "label9";
            label9.Size = new Size(27, 20);
            label9.TabIndex = 10;
            label9.Text = "ID:";
            // 
            // tbpDecision
            // 
            tbpDecision.Controls.Add(btnEndDate);
            tbpDecision.Controls.Add(btnStartDate);
            tbpDecision.Controls.Add(cbbStatus);
            tbpDecision.Controls.Add(tbStartDate);
            tbpDecision.Controls.Add(tbEndDate);
            tbpDecision.Controls.Add(label14);
            tbpDecision.Controls.Add(label13);
            tbpDecision.Controls.Add(label12);
            tbpDecision.Controls.Add(tbDecisionDescription);
            tbpDecision.Controls.Add(label8);
            tbpDecision.Controls.Add(lblDecisionId);
            tbpDecision.Controls.Add(label11);
            tbpDecision.Location = new Point(4, 29);
            tbpDecision.Name = "tbpDecision";
            tbpDecision.Padding = new Padding(3);
            tbpDecision.Size = new Size(436, 233);
            tbpDecision.TabIndex = 2;
            tbpDecision.Text = "Решение";
            tbpDecision.UseVisualStyleBackColor = true;
            // 
            // btnEndDate
            // 
            btnEndDate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEndDate.Font = new Font("Segoe UI", 9F);
            btnEndDate.Location = new Point(293, 159);
            btnEndDate.Name = "btnEndDate";
            btnEndDate.Size = new Size(123, 29);
            btnEndDate.TabIndex = 21;
            btnEndDate.Text = "Выбрать дату";
            btnEndDate.UseVisualStyleBackColor = true;
            // 
            // btnStartDate
            // 
            btnStartDate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnStartDate.Font = new Font("Segoe UI", 9F);
            btnStartDate.Location = new Point(293, 123);
            btnStartDate.Name = "btnStartDate";
            btnStartDate.Size = new Size(123, 29);
            btnStartDate.TabIndex = 20;
            btnStartDate.Text = "Выбрать дату";
            btnStartDate.UseVisualStyleBackColor = true;
            // 
            // cbbStatus
            // 
            cbbStatus.FormattingEnabled = true;
            cbbStatus.Location = new Point(146, 194);
            cbbStatus.Name = "cbbStatus";
            cbbStatus.Size = new Size(270, 28);
            cbbStatus.TabIndex = 19;
            // 
            // tbStartDate
            // 
            tbStartDate.Font = new Font("Segoe UI", 9F);
            tbStartDate.Location = new Point(146, 128);
            tbStartDate.Name = "tbStartDate";
            tbStartDate.Size = new Size(141, 27);
            tbStartDate.TabIndex = 18;
            tbStartDate.Text = "28.12.2020";
            // 
            // tbEndDate
            // 
            tbEndDate.Font = new Font("Segoe UI", 9F);
            tbEndDate.Location = new Point(146, 161);
            tbEndDate.Name = "tbEndDate";
            tbEndDate.Size = new Size(141, 27);
            tbEndDate.TabIndex = 17;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F);
            label14.Location = new Point(11, 197);
            label14.Margin = new Padding(8, 0, 8, 0);
            label14.Name = "label14";
            label14.Size = new Size(117, 20);
            label14.TabIndex = 16;
            label14.Text = "Текущий статус:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F);
            label13.Location = new Point(11, 164);
            label13.Margin = new Padding(8, 0, 8, 0);
            label13.Name = "label13";
            label13.Size = new Size(124, 20);
            label13.TabIndex = 15;
            label13.Text = "Дата окончания:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F);
            label12.Location = new Point(11, 132);
            label12.Margin = new Padding(8, 0, 8, 0);
            label12.Name = "label12";
            label12.Size = new Size(97, 20);
            label12.TabIndex = 14;
            label12.Text = "Дата начала:";
            // 
            // tbDecisionDescription
            // 
            tbDecisionDescription.Location = new Point(146, 46);
            tbDecisionDescription.Name = "tbDecisionDescription";
            tbDecisionDescription.Size = new Size(270, 74);
            tbDecisionDescription.TabIndex = 13;
            tbDecisionDescription.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(8, 46);
            label8.Margin = new Padding(8, 0, 8, 0);
            label8.Name = "label8";
            label8.Size = new Size(83, 40);
            label8.TabIndex = 12;
            label8.Text = "Описание \r\nрешения:";
            // 
            // lblDecisionId
            // 
            lblDecisionId.AutoSize = true;
            lblDecisionId.Font = new Font("Segoe UI", 9F);
            lblDecisionId.Location = new Point(146, 12);
            lblDecisionId.Margin = new Padding(8, 0, 8, 0);
            lblDecisionId.Name = "lblDecisionId";
            lblDecisionId.Size = new Size(33, 20);
            lblDecisionId.TabIndex = 11;
            lblDecisionId.Text = "999";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F);
            label11.Location = new Point(8, 12);
            label11.Margin = new Padding(8, 0, 8, 0);
            label11.Name = "label11";
            label11.Size = new Size(27, 20);
            label11.TabIndex = 10;
            label11.Text = "ID:";
            // 
            // tbpUser
            // 
            tbpUser.Controls.Add(tbPersonName);
            tbpUser.Controls.Add(cbbPosition);
            tbpUser.Controls.Add(label18);
            tbpUser.Controls.Add(label17);
            tbpUser.Controls.Add(lblPersonId);
            tbpUser.Controls.Add(label16);
            tbpUser.Location = new Point(4, 29);
            tbpUser.Name = "tbpUser";
            tbpUser.Padding = new Padding(3);
            tbpUser.Size = new Size(436, 233);
            tbpUser.TabIndex = 3;
            tbpUser.Text = "Ответственный";
            tbpUser.UseVisualStyleBackColor = true;
            // 
            // tbPersonName
            // 
            tbPersonName.Location = new Point(111, 37);
            tbPersonName.Name = "tbPersonName";
            tbPersonName.Size = new Size(306, 27);
            tbPersonName.TabIndex = 18;
            // 
            // cbbPosition
            // 
            cbbPosition.FormattingEnabled = true;
            cbbPosition.Location = new Point(111, 74);
            cbbPosition.Name = "cbbPosition";
            cbbPosition.Size = new Size(306, 28);
            cbbPosition.TabIndex = 17;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F);
            label18.Location = new Point(11, 77);
            label18.Margin = new Padding(8, 0, 8, 0);
            label18.Name = "label18";
            label18.Size = new Size(89, 20);
            label18.TabIndex = 16;
            label18.Text = "Должность:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F);
            label17.Location = new Point(11, 44);
            label17.Margin = new Padding(8, 0, 8, 0);
            label17.Name = "label17";
            label17.Size = new Size(42, 20);
            label17.TabIndex = 14;
            label17.Text = "Имя:";
            // 
            // lblPersonId
            // 
            lblPersonId.AutoSize = true;
            lblPersonId.Font = new Font("Segoe UI", 9F);
            lblPersonId.Location = new Point(111, 12);
            lblPersonId.Margin = new Padding(8, 0, 8, 0);
            lblPersonId.Name = "lblPersonId";
            lblPersonId.Size = new Size(33, 20);
            lblPersonId.TabIndex = 13;
            lblPersonId.Text = "999";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F);
            label16.Location = new Point(8, 12);
            label16.Margin = new Padding(8, 0, 8, 0);
            label16.Name = "label16";
            label16.Size = new Size(27, 20);
            label16.TabIndex = 12;
            label16.Text = "ID:";
            // 
            // pnlMessage
            // 
            pnlMessage.BorderStyle = BorderStyle.FixedSingle;
            pnlMessage.Controls.Add(lblMessage);
            pnlMessage.Dock = DockStyle.Bottom;
            pnlMessage.Location = new Point(0, 353);
            pnlMessage.MaximumSize = new Size(0, 30);
            pnlMessage.MinimumSize = new Size(0, 30);
            pnlMessage.Name = "pnlMessage";
            pnlMessage.Size = new Size(782, 30);
            pnlMessage.TabIndex = 0;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(11, 5);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(50, 20);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "label1";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(btnRefresh);
            pnlMain.Controls.Add(lblCount);
            pnlMain.Controls.Add(label1);
            pnlMain.Controls.Add(gbParams);
            pnlMain.Controls.Add(btnDel);
            pnlMain.Controls.Add(btnMod);
            pnlMain.Controls.Add(btnAdd);
            pnlMain.Controls.Add(tvMain);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(782, 353);
            pnlMain.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRefresh.Location = new Point(12, 318);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(140, 29);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Обновить список";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            lblCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI Semibold", 9F);
            lblCount.Location = new Point(270, 322);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(33, 20);
            lblCount.TabIndex = 6;
            lblCount.Text = "999";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(213, 322);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 5;
            label1.Text = "Всего:";
            // 
            // btnDel
            // 
            btnDel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDel.Location = new Point(676, 317);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 29);
            btnDel.TabIndex = 3;
            btnDel.Text = "Удалить";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnMod
            // 
            btnMod.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMod.Location = new Point(576, 317);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(94, 29);
            btnMod.TabIndex = 2;
            btnMod.Text = "Изменить";
            btnMod.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.Location = new Point(476, 317);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tvMain
            // 
            tvMain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tvMain.Location = new Point(12, 12);
            tvMain.Name = "tvMain";
            treeNode1.Name = "Узел2";
            treeNode1.Text = "Узел2";
            treeNode2.Name = "Узел1";
            treeNode2.Text = "Узел1";
            treeNode3.Name = "Узел0";
            treeNode3.Tag = "t1";
            treeNode3.Text = "Узел0";
            tvMain.Nodes.AddRange(new TreeNode[] { treeNode3 });
            tvMain.Size = new Size(291, 298);
            tvMain.TabIndex = 0;
            tvMain.Tag = "TreeView";
            tvMain.AfterSelect += tvMain_AfterSelect;
            // 
            // FrmExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 383);
            Controls.Add(pnlMain);
            Controls.Add(pnlMessage);
            DoubleBuffered = true;
            MinimumSize = new Size(800, 430);
            Name = "FrmExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Менеджер проектов";
            Load += FrmExam_Load;
            gbParams.ResumeLayout(false);
            tbcInfo.ResumeLayout(false);
            tbpObject.ResumeLayout(false);
            tbpObject.PerformLayout();
            tbpTask.ResumeLayout(false);
            tbpTask.PerformLayout();
            tbpDecision.ResumeLayout(false);
            tbpDecision.PerformLayout();
            tbpUser.ResumeLayout(false);
            tbpUser.PerformLayout();
            pnlMessage.ResumeLayout(false);
            pnlMessage.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMessage;
        private Label lblMessage;
        private Panel pnlMain;
        private TreeView tvMain;
        private Button btnDel;
        private Button btnMod;
        private Button btnAdd;
        private Label lblCount;
        private Label label1;
        private GroupBox gbParams;
        private Button btnRefresh;
        private TabControl tbcInfo;
        private TabPage tbpObject;
        private TabPage tbpTask;
        private TabPage tbpDecision;
        private TabPage tbpUser;
        private TextBox tbAddress;
        private Label lblTasksCount;
        private TextBox tbCadastralNumber;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblObjectId;
        private Label label2;
        private TextBox tbObjectName;
        private RichTextBox tbTaskDescription;
        private Label label7;
        private Label lblTaskId;
        private Label label9;
        private RichTextBox tbDecisionDescription;
        private Label label8;
        private Label lblDecisionId;
        private Label label11;
        private TextBox tbStartDate;
        private TextBox tbEndDate;
        private Label label14;
        private Label label13;
        private Label label12;
        private ComboBox cbbStatus;
        private TextBox textBox2;
        private Label label18;
        private TextBox textBox1;
        private Label label17;
        private Label lblPersonId;
        private Label label16;
        private Button btnEndDate;
        private Button btnStartDate;
        private ComboBox cbbPosition;
        private TextBox tbPersonName;
    }
}