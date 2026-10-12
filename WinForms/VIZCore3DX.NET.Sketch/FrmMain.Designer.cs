namespace VIZCore3DX.NET.Sketch
{
    partial class FrmMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxCamera = new System.Windows.Forms.GroupBox();
            this.btnUnlockCamera = new System.Windows.Forms.Button();
            this.btnLockCamera = new System.Windows.Forms.Button();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.chkHighlightable = new System.Windows.Forms.CheckBox();
            this.chkIsContinuousDrawing = new System.Windows.Forms.CheckBox();
            this.groupBoxCreate = new System.Windows.Forms.GroupBox();
            this.cmbSketchType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateSketch = new System.Windows.Forms.Button();
            this.groupBoxText = new System.Windows.Forms.GroupBox();
            this.btnShowSketchTextDialog = new System.Windows.Forms.Button();
            this.btnCreateTextSketch = new System.Windows.Forms.Button();
            this.txtSketchText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDeleteBox = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.groupBoxStyle = new System.Windows.Forms.GroupBox();
            this.pgStyle = new System.Windows.Forms.PropertyGrid();
            this.btnGetStyle = new System.Windows.Forms.Button();
            this.btnShowSketchStyleDialog = new System.Windows.Forms.Button();
            this.groupBoxItems = new System.Windows.Forms.GroupBox();
            this.lblLastOperationStatus = new System.Windows.Forms.Label();
            this.btnDeleteListSelected = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colHighlighted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tmrItems = new System.Windows.Forms.Timer(this.components);
            this.pnlViewHost = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxCamera.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            this.groupBoxCreate.SuspendLayout();
            this.groupBoxText.SuspendLayout();
            this.groupBoxStyle.SuspendLayout();
            this.groupBoxItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlViewHost);
            this.splitContainer1.Size = new System.Drawing.Size(1200, 800);
            this.splitContainer1.SplitterDistance = 299;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.groupBoxCamera);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxSettings);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxCreate);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxText);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxStyle);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxItems);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(299, 800);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // groupBoxCamera
            // 
            this.groupBoxCamera.Controls.Add(this.btnUnlockCamera);
            this.groupBoxCamera.Controls.Add(this.btnLockCamera);
            this.groupBoxCamera.Location = new System.Drawing.Point(8, 8);
            this.groupBoxCamera.Name = "groupBoxCamera";
            this.groupBoxCamera.Size = new System.Drawing.Size(265, 95);
            this.groupBoxCamera.TabIndex = 0;
            this.groupBoxCamera.TabStop = false;
            this.groupBoxCamera.Text = "카메라";
            // 
            // btnUnlockCamera
            // 
            this.btnUnlockCamera.Location = new System.Drawing.Point(15, 55);
            this.btnUnlockCamera.Name = "btnUnlockCamera";
            this.btnUnlockCamera.Size = new System.Drawing.Size(235, 25);
            this.btnUnlockCamera.TabIndex = 1;
            this.btnUnlockCamera.Text = "카메라 고정 해제";
            this.btnUnlockCamera.UseVisualStyleBackColor = true;
            this.btnUnlockCamera.Click += new System.EventHandler(this.btnUnlockCamera_Click);
            // 
            // btnLockCamera
            // 
            this.btnLockCamera.Location = new System.Drawing.Point(15, 24);
            this.btnLockCamera.Name = "btnLockCamera";
            this.btnLockCamera.Size = new System.Drawing.Size(235, 25);
            this.btnLockCamera.TabIndex = 0;
            this.btnLockCamera.Text = "카메라 고정";
            this.btnLockCamera.UseVisualStyleBackColor = true;
            this.btnLockCamera.Click += new System.EventHandler(this.btnLockCamera_Click);
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.chkHighlightable);
            this.groupBoxSettings.Controls.Add(this.chkIsContinuousDrawing);
            this.groupBoxSettings.Location = new System.Drawing.Point(8, 109);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(265, 52);
            this.groupBoxSettings.TabIndex = 1;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "기본 설정";
            // 
            // chkHighlightable
            // 
            this.chkHighlightable.AutoSize = true;
            this.chkHighlightable.Location = new System.Drawing.Point(126, 21);
            this.chkHighlightable.Name = "chkHighlightable";
            this.chkHighlightable.Size = new System.Drawing.Size(104, 16);
            this.chkHighlightable.TabIndex = 1;
            this.chkHighlightable.Text = "강조 가능 여부";
            this.chkHighlightable.UseVisualStyleBackColor = true;
            this.chkHighlightable.CheckedChanged += new System.EventHandler(this.chkHighlightable_CheckedChanged);
            // 
            // chkIsContinuousDrawing
            // 
            this.chkIsContinuousDrawing.AutoSize = true;
            this.chkIsContinuousDrawing.Location = new System.Drawing.Point(15, 21);
            this.chkIsContinuousDrawing.Name = "chkIsContinuousDrawing";
            this.chkIsContinuousDrawing.Size = new System.Drawing.Size(88, 16);
            this.chkIsContinuousDrawing.TabIndex = 0;
            this.chkIsContinuousDrawing.Text = "연속 그리기";
            this.chkIsContinuousDrawing.UseVisualStyleBackColor = true;
            this.chkIsContinuousDrawing.CheckedChanged += new System.EventHandler(this.chkIsContinuousDrawing_CheckedChanged);
            // 
            // groupBoxCreate
            // 
            this.groupBoxCreate.Controls.Add(this.cmbSketchType);
            this.groupBoxCreate.Controls.Add(this.label1);
            this.groupBoxCreate.Controls.Add(this.btnCreateSketch);
            this.groupBoxCreate.Location = new System.Drawing.Point(8, 167);
            this.groupBoxCreate.Name = "groupBoxCreate";
            this.groupBoxCreate.Size = new System.Drawing.Size(265, 85);
            this.groupBoxCreate.TabIndex = 2;
            this.groupBoxCreate.TabStop = false;
            this.groupBoxCreate.Text = "스케치 생성";
            // 
            // cmbSketchType
            // 
            this.cmbSketchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSketchType.FormattingEnabled = true;
            this.cmbSketchType.Location = new System.Drawing.Point(88, 22);
            this.cmbSketchType.Name = "cmbSketchType";
            this.cmbSketchType.Size = new System.Drawing.Size(162, 20);
            this.cmbSketchType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "스케치 타입:";
            // 
            // btnCreateSketch
            // 
            this.btnCreateSketch.Location = new System.Drawing.Point(15, 50);
            this.btnCreateSketch.Name = "btnCreateSketch";
            this.btnCreateSketch.Size = new System.Drawing.Size(235, 25);
            this.btnCreateSketch.TabIndex = 0;
            this.btnCreateSketch.Text = "선택한 타입 스케치 생성";
            this.btnCreateSketch.UseVisualStyleBackColor = true;
            this.btnCreateSketch.Click += new System.EventHandler(this.btnCreateSketch_Click);
            // 
            // groupBoxText
            // 
            this.groupBoxText.Controls.Add(this.btnShowSketchTextDialog);
            this.groupBoxText.Controls.Add(this.btnCreateTextSketch);
            this.groupBoxText.Controls.Add(this.txtSketchText);
            this.groupBoxText.Controls.Add(this.label2);
            this.groupBoxText.Location = new System.Drawing.Point(8, 258);
            this.groupBoxText.Name = "groupBoxText";
            this.groupBoxText.Size = new System.Drawing.Size(265, 115);
            this.groupBoxText.TabIndex = 3;
            this.groupBoxText.TabStop = false;
            this.groupBoxText.Text = "문자 스케치";
            // 
            // btnShowSketchTextDialog
            // 
            this.btnShowSketchTextDialog.Location = new System.Drawing.Point(15, 80);
            this.btnShowSketchTextDialog.Name = "btnShowSketchTextDialog";
            this.btnShowSketchTextDialog.Size = new System.Drawing.Size(235, 25);
            this.btnShowSketchTextDialog.TabIndex = 4;
            this.btnShowSketchTextDialog.Text = "기본 문자 다이얼로그 호출";
            this.btnShowSketchTextDialog.UseVisualStyleBackColor = true;
            this.btnShowSketchTextDialog.Click += new System.EventHandler(this.btnShowSketchTextDialog_Click);
            // 
            // btnCreateTextSketch
            // 
            this.btnCreateTextSketch.Location = new System.Drawing.Point(15, 50);
            this.btnCreateTextSketch.Name = "btnCreateTextSketch";
            this.btnCreateTextSketch.Size = new System.Drawing.Size(235, 25);
            this.btnCreateTextSketch.TabIndex = 3;
            this.btnCreateTextSketch.Text = "문자 스케치 생성";
            this.btnCreateTextSketch.UseVisualStyleBackColor = true;
            this.btnCreateTextSketch.Click += new System.EventHandler(this.btnCreateTextSketch_Click);
            // 
            // txtSketchText
            // 
            this.txtSketchText.Location = new System.Drawing.Point(54, 21);
            this.txtSketchText.Name = "txtSketchText";
            this.txtSketchText.Size = new System.Drawing.Size(196, 21);
            this.txtSketchText.TabIndex = 2;
            this.txtSketchText.Text = "VIZCore3DX.NET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "입력:";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(15, 255);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(235, 25);
            this.btnDeleteAll.TabIndex = 4;
            this.btnDeleteAll.Text = "전체 삭제";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDeleteBox
            // 
            this.btnDeleteBox.Location = new System.Drawing.Point(15, 225);
            this.btnDeleteBox.Name = "btnDeleteBox";
            this.btnDeleteBox.Size = new System.Drawing.Size(235, 25);
            this.btnDeleteBox.TabIndex = 3;
            this.btnDeleteBox.Text = "박스 선택 삭제";
            this.btnDeleteBox.UseVisualStyleBackColor = true;
            this.btnDeleteBox.Click += new System.EventHandler(this.btnDeleteBox_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Location = new System.Drawing.Point(15, 195);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(235, 25);
            this.btnDeleteSelected.TabIndex = 2;
            this.btnDeleteSelected.Text = "선택된 스케치 삭제";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // groupBoxStyle
            // 
            this.groupBoxStyle.Controls.Add(this.pgStyle);
            this.groupBoxStyle.Controls.Add(this.btnGetStyle);
            this.groupBoxStyle.Controls.Add(this.btnShowSketchStyleDialog);
            this.groupBoxStyle.Location = new System.Drawing.Point(8, 500);
            this.groupBoxStyle.Name = "groupBoxStyle";
            this.groupBoxStyle.Size = new System.Drawing.Size(265, 260);
            this.groupBoxStyle.TabIndex = 5;
            this.groupBoxStyle.TabStop = false;
            this.groupBoxStyle.Text = "스타일 설정 (PropertyGrid)";
            // 
            // pgStyle
            // 
            this.pgStyle.Location = new System.Drawing.Point(15, 80);
            this.pgStyle.Name = "pgStyle";
            this.pgStyle.HelpVisible = false;
            this.pgStyle.Size = new System.Drawing.Size(235, 170);
            this.pgStyle.TabIndex = 3;
            this.pgStyle.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgStyle_PropertyValueChanged);
            // 
            // btnGetStyle
            // 
            this.btnGetStyle.Location = new System.Drawing.Point(15, 50);
            this.btnGetStyle.Name = "btnGetStyle";
            this.btnGetStyle.Size = new System.Drawing.Size(235, 25);
            this.btnGetStyle.TabIndex = 1;
            this.btnGetStyle.Text = "현재 스타일 불러오기";
            this.btnGetStyle.UseVisualStyleBackColor = true;
            this.btnGetStyle.Click += new System.EventHandler(this.btnGetStyle_Click);
            // 
            // btnShowSketchStyleDialog
            // 
            this.btnShowSketchStyleDialog.Location = new System.Drawing.Point(15, 20);
            this.btnShowSketchStyleDialog.Name = "btnShowSketchStyleDialog";
            this.btnShowSketchStyleDialog.Size = new System.Drawing.Size(235, 25);
            this.btnShowSketchStyleDialog.TabIndex = 0;
            this.btnShowSketchStyleDialog.Text = "기본 스타일 다이얼로그 호출";
            this.btnShowSketchStyleDialog.UseVisualStyleBackColor = true;
            this.btnShowSketchStyleDialog.Click += new System.EventHandler(this.btnShowSketchStyleDialog_Click);
            // 
            // groupBoxItems
            // 
            this.groupBoxItems.Controls.Add(this.lblLastOperationStatus);
            this.groupBoxItems.Controls.Add(this.btnDeleteAll);
            this.groupBoxItems.Controls.Add(this.btnDeleteBox);
            this.groupBoxItems.Controls.Add(this.btnDeleteSelected);
            this.groupBoxItems.Controls.Add(this.btnDeleteListSelected);
            this.groupBoxItems.Controls.Add(this.dgvItems);
            this.groupBoxItems.Location = new System.Drawing.Point(8, 500);
            this.groupBoxItems.Name = "groupBoxItems";
            this.groupBoxItems.Size = new System.Drawing.Size(265, 315);
            this.groupBoxItems.TabIndex = 6;
            this.groupBoxItems.TabStop = false;
            this.groupBoxItems.Text = "스케치 목록 / 삭제";
            // 
            // lblLastOperationStatus
            // 
            this.lblLastOperationStatus.AutoSize = true;
            this.lblLastOperationStatus.Location = new System.Drawing.Point(15, 288);
            this.lblLastOperationStatus.Name = "lblLastOperationStatus";
            this.lblLastOperationStatus.Size = new System.Drawing.Size(87, 12);
            this.lblLastOperationStatus.TabIndex = 5;
            this.lblLastOperationStatus.Text = "마지막 상태 : -";
            // 
            // btnDeleteListSelected
            // 
            this.btnDeleteListSelected.Location = new System.Drawing.Point(15, 165);
            this.btnDeleteListSelected.Name = "btnDeleteListSelected";
            this.btnDeleteListSelected.Size = new System.Drawing.Size(235, 25);
            this.btnDeleteListSelected.TabIndex = 1;
            this.btnDeleteListSelected.Text = "목록에서 선택한 항목 삭제";
            this.btnDeleteListSelected.UseVisualStyleBackColor = true;
            this.btnDeleteListSelected.Click += new System.EventHandler(this.btnDeleteListSelected_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colType,
            this.colSelected,
            this.colHighlighted});
            this.dgvItems.Location = new System.Drawing.Point(15, 20);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellValueChanged);
            this.dgvItems.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvItems_CurrentCellDirtyStateChanged);
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowTemplate.Height = 21;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(235, 140);
            this.dgvItems.TabIndex = 0;
            // 
            // colNo
            // 
            this.colNo.FillWeight = 30F;
            this.colNo.HeaderText = "번호";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.FillWeight = 70F;
            this.colType.HeaderText = "종류";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colSelected
            // 
            this.colSelected.FillWeight = 40F;
            this.colSelected.HeaderText = "선택";
            this.colSelected.Name = "colSelected";
            // 
            // colHighlighted
            // 
            this.colHighlighted.FillWeight = 40F;
            this.colHighlighted.HeaderText = "강조";
            this.colHighlighted.Name = "colHighlighted";
            // 
            // tmrItems
            // 
            this.tmrItems.Interval = 100;
            this.tmrItems.Tick += new System.EventHandler(this.tmrItems_Tick);
            // 
            // pnlViewHost
            // 
            this.pnlViewHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewHost.Location = new System.Drawing.Point(0, 0);
            this.pnlViewHost.Name = "pnlViewHost";
            this.pnlViewHost.Size = new System.Drawing.Size(897, 800);
            this.pnlViewHost.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3DX.NET.Sketch";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBoxCamera.ResumeLayout(false);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.groupBoxCreate.ResumeLayout(false);
            this.groupBoxCreate.PerformLayout();
            this.groupBoxText.ResumeLayout(false);
            this.groupBoxText.PerformLayout();
            this.groupBoxStyle.ResumeLayout(false);
            this.groupBoxItems.ResumeLayout(false);
            this.groupBoxItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlViewHost;
        private System.Windows.Forms.GroupBox groupBoxCamera;
        private System.Windows.Forms.Button btnUnlockCamera;
        private System.Windows.Forms.Button btnLockCamera;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.CheckBox chkHighlightable;
        private System.Windows.Forms.CheckBox chkIsContinuousDrawing;
        private System.Windows.Forms.GroupBox groupBoxCreate;
        private System.Windows.Forms.ComboBox cmbSketchType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateSketch;
        private System.Windows.Forms.GroupBox groupBoxText;
        private System.Windows.Forms.Button btnShowSketchTextDialog;
        private System.Windows.Forms.Button btnCreateTextSketch;
        private System.Windows.Forms.TextBox txtSketchText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnDeleteBox;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.GroupBox groupBoxStyle;
        private System.Windows.Forms.PropertyGrid pgStyle;
        private System.Windows.Forms.Button btnGetStyle;
        private System.Windows.Forms.Button btnShowSketchStyleDialog;
        private System.Windows.Forms.GroupBox groupBoxItems;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelected;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colHighlighted;
        private System.Windows.Forms.Timer tmrItems;
        private System.Windows.Forms.Button btnDeleteListSelected;
        private System.Windows.Forms.Label lblLastOperationStatus;
    }
}