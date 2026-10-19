namespace VIZCore3DX.NET.ExportOptions
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.grpFormat = new System.Windows.Forms.GroupBox();
            this.chkIncludeGroups = new System.Windows.Forms.CheckBox();
            this.chkIncludeNormals = new System.Windows.Forms.CheckBox();
            this.cmbMaterialGrouping = new System.Windows.Forms.ComboBox();
            this.lblMaterialGrouping = new System.Windows.Forms.Label();
            this.cmbVertexColor = new System.Windows.Forms.ComboBox();
            this.lblVertexColor = new System.Windows.Forms.Label();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.lblFormat = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.chkCut = new System.Windows.Forms.CheckBox();
            this.chkVisibleOnly = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbSearchOption = new System.Windows.Forms.ComboBox();
            this.lblSearchOption = new System.Windows.Forms.Label();
            this.cmbFrameZTo = new System.Windows.Forms.ComboBox();
            this.lblFrameZSep = new System.Windows.Forms.Label();
            this.cmbFrameZFrom = new System.Windows.Forms.ComboBox();
            this.lblFrameZ = new System.Windows.Forms.Label();
            this.cmbFrameYTo = new System.Windows.Forms.ComboBox();
            this.lblFrameYSep = new System.Windows.Forms.Label();
            this.cmbFrameYFrom = new System.Windows.Forms.ComboBox();
            this.lblFrameY = new System.Windows.Forms.Label();
            this.cmbFrameXTo = new System.Windows.Forms.ComboBox();
            this.lblFrameXSep = new System.Windows.Forms.Label();
            this.cmbFrameXFrom = new System.Windows.Forms.ComboBox();
            this.lblFrameX = new System.Windows.Forms.Label();
            this.btnOpenTribon = new System.Windows.Forms.Button();
            this.btnOpenAM = new System.Windows.Forms.Button();
            this.cmbFrame = new System.Windows.Forms.ComboBox();
            this.lblFrame = new System.Windows.Forms.Label();
            this.btnAddSection = new System.Windows.Forms.Button();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.btnAddSelectionBox = new System.Windows.Forms.Button();
            this.cmbSelectionBox = new System.Windows.Forms.ComboBox();
            this.lblSelectionBox = new System.Windows.Forms.Label();
            this.grpSource = new System.Windows.Forms.GroupBox();
            this.rdoFrame = new System.Windows.Forms.RadioButton();
            this.rdoSectionBox = new System.Windows.Forms.RadioButton();
            this.rdoSelectionBox = new System.Windows.Forms.RadioButton();
            this.rdoSelected = new System.Windows.Forms.RadioButton();
            this.rdoRendered = new System.Windows.Forms.RadioButton();
            this.rdoVisible = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpFormat.SuspendLayout();
            this.grpBox.SuspendLayout();
            this.grpSource.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnOpen);
            this.splitContainer1.Panel1.Controls.Add(this.btnExport);
            this.splitContainer1.Panel1.Controls.Add(this.grpFormat);
            this.splitContainer1.Panel1.Controls.Add(this.grpBox);
            this.splitContainer1.Panel1.Controls.Add(this.grpSource);
            this.splitContainer1.Panel1MinSize = 300;
            this.splitContainer1.Size = new System.Drawing.Size(1280, 760);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(12, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(376, 28);
            this.btnOpen.TabIndex = 100;
            this.btnOpen.Text = "모델 열기";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(12, 703);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(376, 36);
            this.btnExport.TabIndex = 45;
            this.btnExport.Text = "내보내기";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // grpFormat
            // 
            this.grpFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFormat.Controls.Add(this.chkIncludeGroups);
            this.grpFormat.Controls.Add(this.chkIncludeNormals);
            this.grpFormat.Controls.Add(this.cmbMaterialGrouping);
            this.grpFormat.Controls.Add(this.lblMaterialGrouping);
            this.grpFormat.Controls.Add(this.cmbVertexColor);
            this.grpFormat.Controls.Add(this.lblVertexColor);
            this.grpFormat.Controls.Add(this.cmbFormat);
            this.grpFormat.Controls.Add(this.lblFormat);
            this.grpFormat.Location = new System.Drawing.Point(12, 548);
            this.grpFormat.Name = "grpFormat";
            this.grpFormat.Size = new System.Drawing.Size(376, 149);
            this.grpFormat.TabIndex = 36;
            this.grpFormat.TabStop = false;
            this.grpFormat.Text = "3. 파일 형식 / OBJ 옵션";
            // 
            // chkIncludeGroups
            // 
            this.chkIncludeGroups.Checked = true;
            this.chkIncludeGroups.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeGroups.Location = new System.Drawing.Point(190, 118);
            this.chkIncludeGroups.Name = "chkIncludeGroups";
            this.chkIncludeGroups.Size = new System.Drawing.Size(170, 20);
            this.chkIncludeGroups.TabIndex = 44;
            this.chkIncludeGroups.Text = "노드 그룹(o/g) 포함";
            this.chkIncludeGroups.UseVisualStyleBackColor = true;
            // 
            // chkIncludeNormals
            // 
            this.chkIncludeNormals.Location = new System.Drawing.Point(14, 118);
            this.chkIncludeNormals.Name = "chkIncludeNormals";
            this.chkIncludeNormals.Size = new System.Drawing.Size(170, 20);
            this.chkIncludeNormals.TabIndex = 43;
            this.chkIncludeNormals.Text = "법선 포함";
            this.chkIncludeNormals.UseVisualStyleBackColor = true;
            // 
            // cmbMaterialGrouping
            // 
            this.cmbMaterialGrouping.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMaterialGrouping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterialGrouping.FormattingEnabled = true;
            this.cmbMaterialGrouping.Location = new System.Drawing.Point(100, 84);
            this.cmbMaterialGrouping.Name = "cmbMaterialGrouping";
            this.cmbMaterialGrouping.Size = new System.Drawing.Size(262, 20);
            this.cmbMaterialGrouping.TabIndex = 42;
            // 
            // lblMaterialGrouping
            // 
            this.lblMaterialGrouping.AutoSize = true;
            this.lblMaterialGrouping.Location = new System.Drawing.Point(14, 88);
            this.lblMaterialGrouping.Name = "lblMaterialGrouping";
            this.lblMaterialGrouping.Size = new System.Drawing.Size(57, 12);
            this.lblMaterialGrouping.TabIndex = 41;
            this.lblMaterialGrouping.Text = "재질 묶음";
            // 
            // cmbVertexColor
            // 
            this.cmbVertexColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVertexColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVertexColor.FormattingEnabled = true;
            this.cmbVertexColor.Location = new System.Drawing.Point(100, 54);
            this.cmbVertexColor.Name = "cmbVertexColor";
            this.cmbVertexColor.Size = new System.Drawing.Size(262, 20);
            this.cmbVertexColor.TabIndex = 40;
            // 
            // lblVertexColor
            // 
            this.lblVertexColor.AutoSize = true;
            this.lblVertexColor.Location = new System.Drawing.Point(14, 58);
            this.lblVertexColor.Name = "lblVertexColor";
            this.lblVertexColor.Size = new System.Drawing.Size(45, 12);
            this.lblVertexColor.TabIndex = 39;
            this.lblVertexColor.Text = "정점 색";
            // 
            // cmbFormat
            // 
            this.cmbFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Location = new System.Drawing.Point(100, 24);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(262, 20);
            this.cmbFormat.TabIndex = 38;
            this.cmbFormat.SelectedIndexChanged += new System.EventHandler(this.cmbFormat_SelectedIndexChanged);
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(14, 28);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(29, 12);
            this.lblFormat.TabIndex = 37;
            this.lblFormat.Text = "형식";
            // 
            // grpBox
            // 
            this.grpBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBox.Controls.Add(this.chkCut);
            this.grpBox.Controls.Add(this.chkVisibleOnly);
            this.grpBox.Controls.Add(this.btnRefresh);
            this.grpBox.Controls.Add(this.cmbSearchOption);
            this.grpBox.Controls.Add(this.lblSearchOption);
            this.grpBox.Controls.Add(this.cmbFrameZTo);
            this.grpBox.Controls.Add(this.lblFrameZSep);
            this.grpBox.Controls.Add(this.cmbFrameZFrom);
            this.grpBox.Controls.Add(this.lblFrameZ);
            this.grpBox.Controls.Add(this.cmbFrameYTo);
            this.grpBox.Controls.Add(this.lblFrameYSep);
            this.grpBox.Controls.Add(this.cmbFrameYFrom);
            this.grpBox.Controls.Add(this.lblFrameY);
            this.grpBox.Controls.Add(this.cmbFrameXTo);
            this.grpBox.Controls.Add(this.lblFrameXSep);
            this.grpBox.Controls.Add(this.cmbFrameXFrom);
            this.grpBox.Controls.Add(this.lblFrameX);
            this.grpBox.Controls.Add(this.btnOpenTribon);
            this.grpBox.Controls.Add(this.btnOpenAM);
            this.grpBox.Controls.Add(this.cmbFrame);
            this.grpBox.Controls.Add(this.lblFrame);
            this.grpBox.Controls.Add(this.btnAddSection);
            this.grpBox.Controls.Add(this.cmbSection);
            this.grpBox.Controls.Add(this.lblSection);
            this.grpBox.Controls.Add(this.btnAddSelectionBox);
            this.grpBox.Controls.Add(this.cmbSelectionBox);
            this.grpBox.Controls.Add(this.lblSelectionBox);
            this.grpBox.Location = new System.Drawing.Point(12, 248);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(376, 294);
            this.grpBox.TabIndex = 8;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "2. 범위 설정 (선택상자 / 단면상자 / 프레임 / 검색)";
            // 
            // chkCut
            // 
            this.chkCut.Location = new System.Drawing.Point(14, 264);
            this.chkCut.Name = "chkCut";
            this.chkCut.Size = new System.Drawing.Size(350, 20);
            this.chkCut.TabIndex = 35;
            this.chkCut.Text = "범위 경계로 형상 자르기 (SplitMesh, 모델이 변경됨)";
            this.chkCut.UseVisualStyleBackColor = true;
            // 
            // chkVisibleOnly
            // 
            this.chkVisibleOnly.Checked = true;
            this.chkVisibleOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVisibleOnly.Location = new System.Drawing.Point(14, 240);
            this.chkVisibleOnly.Name = "chkVisibleOnly";
            this.chkVisibleOnly.Size = new System.Drawing.Size(350, 20);
            this.chkVisibleOnly.TabIndex = 34;
            this.chkVisibleOnly.Text = "보이는 개체만 검색 (범위 안의 개체)";
            this.chkVisibleOnly.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(216, 208);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 24);
            this.btnRefresh.TabIndex = 33;
            this.btnRefresh.Text = "목록 새로고침";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbSearchOption
            // 
            this.cmbSearchOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSearchOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchOption.FormattingEnabled = true;
            this.cmbSearchOption.Location = new System.Drawing.Point(80, 210);
            this.cmbSearchOption.Name = "cmbSearchOption";
            this.cmbSearchOption.Size = new System.Drawing.Size(130, 20);
            this.cmbSearchOption.TabIndex = 32;
            // 
            // lblSearchOption
            // 
            this.lblSearchOption.AutoSize = true;
            this.lblSearchOption.Location = new System.Drawing.Point(14, 214);
            this.lblSearchOption.Name = "lblSearchOption";
            this.lblSearchOption.Size = new System.Drawing.Size(57, 12);
            this.lblSearchOption.TabIndex = 31;
            this.lblSearchOption.Text = "포함 기준";
            // 
            // cmbFrameZTo
            // 
            this.cmbFrameZTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFrameZTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrameZTo.FormattingEnabled = true;
            this.cmbFrameZTo.Location = new System.Drawing.Point(212, 174);
            this.cmbFrameZTo.Name = "cmbFrameZTo";
            this.cmbFrameZTo.Size = new System.Drawing.Size(150, 20);
            this.cmbFrameZTo.TabIndex = 30;
            // 
            // lblFrameZSep
            // 
            this.lblFrameZSep.AutoSize = true;
            this.lblFrameZSep.Location = new System.Drawing.Point(196, 178);
            this.lblFrameZSep.Name = "lblFrameZSep";
            this.lblFrameZSep.Size = new System.Drawing.Size(14, 12);
            this.lblFrameZSep.TabIndex = 29;
            this.lblFrameZSep.Text = "~";
            // 
            // cmbFrameZFrom
            // 
            this.cmbFrameZFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrameZFrom.FormattingEnabled = true;
            this.cmbFrameZFrom.Location = new System.Drawing.Point(40, 174);
            this.cmbFrameZFrom.Name = "cmbFrameZFrom";
            this.cmbFrameZFrom.Size = new System.Drawing.Size(150, 20);
            this.cmbFrameZFrom.TabIndex = 28;
            // 
            // lblFrameZ
            // 
            this.lblFrameZ.AutoSize = true;
            this.lblFrameZ.Location = new System.Drawing.Point(14, 178);
            this.lblFrameZ.Name = "lblFrameZ";
            this.lblFrameZ.Size = new System.Drawing.Size(13, 12);
            this.lblFrameZ.TabIndex = 27;
            this.lblFrameZ.Text = "Z";
            // 
            // cmbFrameYTo
            // 
            this.cmbFrameYTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFrameYTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrameYTo.FormattingEnabled = true;
            this.cmbFrameYTo.Location = new System.Drawing.Point(212, 146);
            this.cmbFrameYTo.Name = "cmbFrameYTo";
            this.cmbFrameYTo.Size = new System.Drawing.Size(150, 20);
            this.cmbFrameYTo.TabIndex = 26;
            // 
            // lblFrameYSep
            // 
            this.lblFrameYSep.AutoSize = true;
            this.lblFrameYSep.Location = new System.Drawing.Point(196, 150);
            this.lblFrameYSep.Name = "lblFrameYSep";
            this.lblFrameYSep.Size = new System.Drawing.Size(14, 12);
            this.lblFrameYSep.TabIndex = 25;
            this.lblFrameYSep.Text = "~";
            // 
            // cmbFrameYFrom
            // 
            this.cmbFrameYFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrameYFrom.FormattingEnabled = true;
            this.cmbFrameYFrom.Location = new System.Drawing.Point(40, 146);
            this.cmbFrameYFrom.Name = "cmbFrameYFrom";
            this.cmbFrameYFrom.Size = new System.Drawing.Size(150, 20);
            this.cmbFrameYFrom.TabIndex = 24;
            // 
            // lblFrameY
            // 
            this.lblFrameY.AutoSize = true;
            this.lblFrameY.Location = new System.Drawing.Point(14, 150);
            this.lblFrameY.Name = "lblFrameY";
            this.lblFrameY.Size = new System.Drawing.Size(13, 12);
            this.lblFrameY.TabIndex = 23;
            this.lblFrameY.Text = "Y";
            // 
            // cmbFrameXTo
            // 
            this.cmbFrameXTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFrameXTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrameXTo.FormattingEnabled = true;
            this.cmbFrameXTo.Location = new System.Drawing.Point(212, 118);
            this.cmbFrameXTo.Name = "cmbFrameXTo";
            this.cmbFrameXTo.Size = new System.Drawing.Size(150, 20);
            this.cmbFrameXTo.TabIndex = 22;
            // 
            // lblFrameXSep
            // 
            this.lblFrameXSep.AutoSize = true;
            this.lblFrameXSep.Location = new System.Drawing.Point(196, 122);
            this.lblFrameXSep.Name = "lblFrameXSep";
            this.lblFrameXSep.Size = new System.Drawing.Size(14, 12);
            this.lblFrameXSep.TabIndex = 21;
            this.lblFrameXSep.Text = "~";
            // 
            // cmbFrameXFrom
            // 
            this.cmbFrameXFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrameXFrom.FormattingEnabled = true;
            this.cmbFrameXFrom.Location = new System.Drawing.Point(40, 118);
            this.cmbFrameXFrom.Name = "cmbFrameXFrom";
            this.cmbFrameXFrom.Size = new System.Drawing.Size(150, 20);
            this.cmbFrameXFrom.TabIndex = 20;
            // 
            // lblFrameX
            // 
            this.lblFrameX.AutoSize = true;
            this.lblFrameX.Location = new System.Drawing.Point(14, 122);
            this.lblFrameX.Name = "lblFrameX";
            this.lblFrameX.Size = new System.Drawing.Size(13, 12);
            this.lblFrameX.TabIndex = 19;
            this.lblFrameX.Text = "X";
            // 
            // btnOpenTribon
            // 
            this.btnOpenTribon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenTribon.Location = new System.Drawing.Point(280, 86);
            this.btnOpenTribon.Name = "btnOpenTribon";
            this.btnOpenTribon.Size = new System.Drawing.Size(86, 24);
            this.btnOpenTribon.TabIndex = 18;
            this.btnOpenTribon.Text = "Tribon 열기";
            this.btnOpenTribon.UseVisualStyleBackColor = true;
            this.btnOpenTribon.Click += new System.EventHandler(this.btnOpenTribon_Click);
            // 
            // btnOpenAM
            // 
            this.btnOpenAM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenAM.Location = new System.Drawing.Point(198, 86);
            this.btnOpenAM.Name = "btnOpenAM";
            this.btnOpenAM.Size = new System.Drawing.Size(76, 24);
            this.btnOpenAM.TabIndex = 17;
            this.btnOpenAM.Text = "AM 열기";
            this.btnOpenAM.UseVisualStyleBackColor = true;
            this.btnOpenAM.Click += new System.EventHandler(this.btnOpenAM_Click);
            // 
            // cmbFrame
            // 
            this.cmbFrame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrame.FormattingEnabled = true;
            this.cmbFrame.Location = new System.Drawing.Point(80, 88);
            this.cmbFrame.Name = "cmbFrame";
            this.cmbFrame.Size = new System.Drawing.Size(110, 20);
            this.cmbFrame.TabIndex = 16;
            this.cmbFrame.SelectedIndexChanged += new System.EventHandler(this.cmbFrame_SelectedIndexChanged);
            // 
            // lblFrame
            // 
            this.lblFrame.AutoSize = true;
            this.lblFrame.Location = new System.Drawing.Point(14, 92);
            this.lblFrame.Name = "lblFrame";
            this.lblFrame.Size = new System.Drawing.Size(41, 12);
            this.lblFrame.TabIndex = 15;
            this.lblFrame.Text = "프레임";
            // 
            // btnAddSection
            // 
            this.btnAddSection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSection.Location = new System.Drawing.Point(216, 56);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Size = new System.Drawing.Size(150, 24);
            this.btnAddSection.TabIndex = 14;
            this.btnAddSection.Text = "선택 노드로 추가";
            this.btnAddSection.UseVisualStyleBackColor = true;
            this.btnAddSection.Click += new System.EventHandler(this.btnAddSection_Click);
            // 
            // cmbSection
            // 
            this.cmbSection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(80, 58);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(130, 20);
            this.cmbSection.TabIndex = 13;
            this.cmbSection.DropDown += new System.EventHandler(this.cmbSection_DropDown);
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(14, 62);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(53, 12);
            this.lblSection.TabIndex = 12;
            this.lblSection.Text = "단면상자";
            // 
            // btnAddSelectionBox
            // 
            this.btnAddSelectionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSelectionBox.Location = new System.Drawing.Point(216, 26);
            this.btnAddSelectionBox.Name = "btnAddSelectionBox";
            this.btnAddSelectionBox.Size = new System.Drawing.Size(150, 24);
            this.btnAddSelectionBox.TabIndex = 11;
            this.btnAddSelectionBox.Text = "선택 노드로 추가";
            this.btnAddSelectionBox.UseVisualStyleBackColor = true;
            this.btnAddSelectionBox.Click += new System.EventHandler(this.btnAddSelectionBox_Click);
            // 
            // cmbSelectionBox
            // 
            this.cmbSelectionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectionBox.FormattingEnabled = true;
            this.cmbSelectionBox.Location = new System.Drawing.Point(80, 28);
            this.cmbSelectionBox.Name = "cmbSelectionBox";
            this.cmbSelectionBox.Size = new System.Drawing.Size(130, 20);
            this.cmbSelectionBox.TabIndex = 10;
            this.cmbSelectionBox.DropDown += new System.EventHandler(this.cmbSelectionBox_DropDown);
            // 
            // lblSelectionBox
            // 
            this.lblSelectionBox.AutoSize = true;
            this.lblSelectionBox.Location = new System.Drawing.Point(14, 32);
            this.lblSelectionBox.Name = "lblSelectionBox";
            this.lblSelectionBox.Size = new System.Drawing.Size(53, 12);
            this.lblSelectionBox.TabIndex = 9;
            this.lblSelectionBox.Text = "선택상자";
            // 
            // grpSource
            // 
            this.grpSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSource.Controls.Add(this.rdoFrame);
            this.grpSource.Controls.Add(this.rdoSectionBox);
            this.grpSource.Controls.Add(this.rdoSelectionBox);
            this.grpSource.Controls.Add(this.rdoSelected);
            this.grpSource.Controls.Add(this.rdoRendered);
            this.grpSource.Controls.Add(this.rdoVisible);
            this.grpSource.Controls.Add(this.rdoAll);
            this.grpSource.Location = new System.Drawing.Point(12, 48);
            this.grpSource.Name = "grpSource";
            this.grpSource.Size = new System.Drawing.Size(376, 194);
            this.grpSource.TabIndex = 0;
            this.grpSource.TabStop = false;
            this.grpSource.Text = "1. 내보내기 대상 (Source)";
            // 
            // rdoFrame
            // 
            this.rdoFrame.Location = new System.Drawing.Point(14, 164);
            this.rdoFrame.Name = "rdoFrame";
            this.rdoFrame.Size = new System.Drawing.Size(350, 20);
            this.rdoFrame.TabIndex = 7;
            this.rdoFrame.Text = "프레임 범위 안의 개체";
            this.rdoFrame.UseVisualStyleBackColor = true;
            this.rdoFrame.CheckedChanged += new System.EventHandler(this.rdoSource_CheckedChanged);
            // 
            // rdoSectionBox
            // 
            this.rdoSectionBox.Location = new System.Drawing.Point(14, 140);
            this.rdoSectionBox.Name = "rdoSectionBox";
            this.rdoSectionBox.Size = new System.Drawing.Size(350, 20);
            this.rdoSectionBox.TabIndex = 6;
            this.rdoSectionBox.Text = "단면상자 안의 개체";
            this.rdoSectionBox.UseVisualStyleBackColor = true;
            this.rdoSectionBox.CheckedChanged += new System.EventHandler(this.rdoSource_CheckedChanged);
            // 
            // rdoSelectionBox
            // 
            this.rdoSelectionBox.Location = new System.Drawing.Point(14, 116);
            this.rdoSelectionBox.Name = "rdoSelectionBox";
            this.rdoSelectionBox.Size = new System.Drawing.Size(350, 20);
            this.rdoSelectionBox.TabIndex = 5;
            this.rdoSelectionBox.Text = "선택상자 안의 개체";
            this.rdoSelectionBox.UseVisualStyleBackColor = true;
            this.rdoSelectionBox.CheckedChanged += new System.EventHandler(this.rdoSource_CheckedChanged);
            // 
            // rdoSelected
            // 
            this.rdoSelected.Location = new System.Drawing.Point(14, 92);
            this.rdoSelected.Name = "rdoSelected";
            this.rdoSelected.Size = new System.Drawing.Size(350, 20);
            this.rdoSelected.TabIndex = 4;
            this.rdoSelected.Text = "선택된 개체 (SELECTED)";
            this.rdoSelected.UseVisualStyleBackColor = true;
            this.rdoSelected.CheckedChanged += new System.EventHandler(this.rdoSource_CheckedChanged);
            // 
            // rdoRendered
            // 
            this.rdoRendered.Location = new System.Drawing.Point(14, 68);
            this.rdoRendered.Name = "rdoRendered";
            this.rdoRendered.Size = new System.Drawing.Size(350, 20);
            this.rdoRendered.TabIndex = 3;
            this.rdoRendered.Text = "렌더링된 개체 (RENDERED)";
            this.rdoRendered.UseVisualStyleBackColor = true;
            this.rdoRendered.CheckedChanged += new System.EventHandler(this.rdoSource_CheckedChanged);
            // 
            // rdoVisible
            // 
            this.rdoVisible.Location = new System.Drawing.Point(14, 44);
            this.rdoVisible.Name = "rdoVisible";
            this.rdoVisible.Size = new System.Drawing.Size(350, 20);
            this.rdoVisible.TabIndex = 2;
            this.rdoVisible.Text = "보이는 개체 (VISIBLE)";
            this.rdoVisible.UseVisualStyleBackColor = true;
            this.rdoVisible.CheckedChanged += new System.EventHandler(this.rdoSource_CheckedChanged);
            // 
            // rdoAll
            // 
            this.rdoAll.Checked = true;
            this.rdoAll.Location = new System.Drawing.Point(14, 20);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(350, 20);
            this.rdoAll.TabIndex = 1;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "전체 (ALL)";
            this.rdoAll.UseVisualStyleBackColor = true;
            this.rdoAll.CheckedChanged += new System.EventHandler(this.rdoSource_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 760);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3DX.NET.ExportOptions";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpFormat.ResumeLayout(false);
            this.grpFormat.PerformLayout();
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.grpSource.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpSource;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.RadioButton rdoVisible;
        private System.Windows.Forms.RadioButton rdoRendered;
        private System.Windows.Forms.RadioButton rdoSelected;
        private System.Windows.Forms.RadioButton rdoSelectionBox;
        private System.Windows.Forms.RadioButton rdoSectionBox;
        private System.Windows.Forms.RadioButton rdoFrame;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.Label lblSelectionBox;
        private System.Windows.Forms.ComboBox cmbSelectionBox;
        private System.Windows.Forms.Button btnAddSelectionBox;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Button btnAddSection;
        private System.Windows.Forms.Label lblFrame;
        private System.Windows.Forms.ComboBox cmbFrame;
        private System.Windows.Forms.Button btnOpenAM;
        private System.Windows.Forms.Button btnOpenTribon;
        private System.Windows.Forms.Label lblFrameX;
        private System.Windows.Forms.ComboBox cmbFrameXFrom;
        private System.Windows.Forms.Label lblFrameXSep;
        private System.Windows.Forms.ComboBox cmbFrameXTo;
        private System.Windows.Forms.Label lblFrameY;
        private System.Windows.Forms.ComboBox cmbFrameYFrom;
        private System.Windows.Forms.Label lblFrameYSep;
        private System.Windows.Forms.ComboBox cmbFrameYTo;
        private System.Windows.Forms.Label lblFrameZ;
        private System.Windows.Forms.ComboBox cmbFrameZFrom;
        private System.Windows.Forms.Label lblFrameZSep;
        private System.Windows.Forms.ComboBox cmbFrameZTo;
        private System.Windows.Forms.Label lblSearchOption;
        private System.Windows.Forms.ComboBox cmbSearchOption;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.CheckBox chkVisibleOnly;
        private System.Windows.Forms.CheckBox chkCut;
        private System.Windows.Forms.GroupBox grpFormat;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.Label lblVertexColor;
        private System.Windows.Forms.ComboBox cmbVertexColor;
        private System.Windows.Forms.Label lblMaterialGrouping;
        private System.Windows.Forms.ComboBox cmbMaterialGrouping;
        private System.Windows.Forms.CheckBox chkIncludeNormals;
        private System.Windows.Forms.CheckBox chkIncludeGroups;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnOpen;
    }
}
