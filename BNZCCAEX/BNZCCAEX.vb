#Region "Imports"
Imports System.Data
Imports NTSInformatica.CLN__STD
#End Region

Public Class FRMZCCAEX

  '#Region "Moduli"
  '  Private Moduli_P As Integer = 0
  '  Private ModuliExt_P As Integer = 0
  '  Private ModuliSup_P As Integer = 0
  '  Private ModuliSupExt_P As Integer = 0
  '  Private ModuliPtn_P As Integer = 0
  '  Private ModuliPtnExt_P As Integer = 0

  '  Public ReadOnly Property Moduli() As Integer
  '    Get
  '      Return Moduli_P
  '    End Get
  '  End Property
  '  Public ReadOnly Property ModuliExt() As Integer
  '    Get
  '      Return ModuliExt_P
  '    End Get
  '  End Property
  '  Public ReadOnly Property ModuliSup() As Integer
  '    Get
  '      Return ModuliSup_P
  '    End Get
  '  End Property
  '  Public ReadOnly Property ModuliSupExt() As Integer
  '    Get
  '      Return ModuliSupExt_P
  '    End Get
  '  End Property
  '  Public ReadOnly Property ModuliPtn() As Integer
  '    Get
  '      Return ModuliPtn_P
  '    End Get
  '  End Property
  '  Public ReadOnly Property ModuliPtnExt() As Integer
  '    Get
  '      Return ModuliPtnExt_P
  '    End Get
  '  End Property

  Public WithEvents lbDataA As NTSInformatica.NTSLabel
  Public WithEvents edDataA As NTSInformatica.NTSTextBoxData
  Public WithEvents lbNomeFile As NTSInformatica.NTSLabel
  Public WithEvents edNomeFile As NTSInformatica.NTSTextBoxStr
  '#End Region

#Region "Variabili"
  Public oCleCaex As CLEZCCAEX
  Public oCallParams As CLE__CLDP
  Public strWhereFiar As String = ""

  Public str1Periodo As String
  Public str2Periodo As String
  Public str3Periodo As String
  Public str4Periodo As String
  Public str5Periodo As String
  Public str6Periodo As String
  Public str7Periodo As String
  Public str8Periodo As String

  Private components As System.ComponentModel.IContainer
  Public WithEvents NtsBarManager1 As NTSInformatica.NTSBarManager
  Public WithEvents tlbMain As NTSInformatica.NTSBar
  Public WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
  Public WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
  Public WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
  Public WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
  Public WithEvents tlbZoom As NTSInformatica.NTSBarButtonItem
  Public WithEvents tlbStampa As NTSInformatica.NTSBarButtonItem
  Public WithEvents tlbStampaVideo As NTSInformatica.NTSBarButtonItem
  Public WithEvents tlbGuida As NTSInformatica.NTSBarButtonItem
  Public WithEvents tlbEsci As NTSInformatica.NTSBarButtonItem
  Public WithEvents lbDataDa As NTSInformatica.NTSLabel
  Public WithEvents edDataDa As NTSInformatica.NTSTextBoxData
  Public WithEvents pnCpvl As NTSInformatica.NTSPanel
  Public WithEvents tlbStampaGriglia As NTSInformatica.NTSBarButtonItem
  Public WithEvents tlbElabora As NTSInformatica.NTSBarButtonItem
  Public WithEvents tlbStrumenti As NTSInformatica.NTSBarSubItem
  Public WithEvents tlbImpostaStampante As NTSInformatica.NTSBarButtonItem
#End Region

  Public Overridable Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMZCCAEX))
        Me.NtsBarManager1 = New NTSInformatica.NTSBarManager()
        Me.tlbMain = New NTSInformatica.NTSBar()
        Me.tlbElabora = New NTSInformatica.NTSBarButtonItem()
        Me.tlbStampa = New NTSInformatica.NTSBarButtonItem()
        Me.tlbStampaVideo = New NTSInformatica.NTSBarButtonItem()
        Me.tlbStampaGriglia = New NTSInformatica.NTSBarButtonItem()
        Me.tlbZoom = New NTSInformatica.NTSBarButtonItem()
        Me.tlbStrumenti = New NTSInformatica.NTSBarSubItem()
        Me.tlbImpostaStampante = New NTSInformatica.NTSBarButtonItem()
        Me.tlbGuida = New NTSInformatica.NTSBarButtonItem()
        Me.tlbEsci = New NTSInformatica.NTSBarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.lbDataDa = New NTSInformatica.NTSLabel()
        Me.edDataDa = New NTSInformatica.NTSTextBoxData()
        Me.pnCpvl = New NTSInformatica.NTSPanel()
        Me.lbNomeFile = New NTSInformatica.NTSLabel()
        Me.edNomeFile = New NTSInformatica.NTSTextBoxStr()
        Me.lbDataA = New NTSInformatica.NTSLabel()
        Me.edDataA = New NTSInformatica.NTSTextBoxData()
        CType(Me.dttSmartArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NtsBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edDataDa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnCpvl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnCpvl.SuspendLayout()
        CType(Me.edNomeFile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edDataA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NtsBarManager1
        '
        Me.NtsBarManager1.AllowCustomization = False
        Me.NtsBarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.tlbMain})
        Me.NtsBarManager1.DockControls.Add(Me.barDockControlTop)
        Me.NtsBarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.NtsBarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.NtsBarManager1.DockControls.Add(Me.barDockControlRight)
        Me.NtsBarManager1.Form = Me
        Me.NtsBarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.tlbZoom, Me.tlbStampa, Me.tlbStampaVideo, Me.tlbGuida, Me.tlbEsci, Me.tlbElabora, Me.tlbStampaGriglia, Me.tlbStrumenti, Me.tlbImpostaStampante})
        Me.NtsBarManager1.MaxItemId = 33
        '
        'tlbMain
        '
        Me.tlbMain.BarName = "tlbMain"
        Me.tlbMain.DockCol = 0
        Me.tlbMain.DockRow = 0
        Me.tlbMain.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.tlbMain.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.tlbElabora, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, False, Me.tlbStampa, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, False, Me.tlbStampaVideo, False), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, False, Me.tlbStampaGriglia, False), New DevExpress.XtraBars.LinkPersistInfo(Me.tlbZoom, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tlbStrumenti, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tlbGuida, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tlbEsci)})
        Me.tlbMain.OptionsBar.AllowQuickCustomization = False
        Me.tlbMain.OptionsBar.DisableClose = True
        Me.tlbMain.OptionsBar.DrawDragBorder = False
        Me.tlbMain.OptionsBar.UseWholeRow = True
        Me.tlbMain.Text = "tlbMain"
        '
        'tlbElabora
        '
        Me.tlbElabora.Caption = "Elabora"
        Me.tlbElabora.Glyph = CType(resources.GetObject("tlbElabora.Glyph"), System.Drawing.Image)
        Me.tlbElabora.Id = 33
        Me.tlbElabora.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.tlbElabora.Name = "tlbElabora"
        Me.tlbElabora.Visible = True
        '
        'tlbStampa
        '
        Me.tlbStampa.Caption = "Stampa"
        Me.tlbStampa.Glyph = CType(resources.GetObject("tlbStampa.Glyph"), System.Drawing.Image)
        Me.tlbStampa.Id = 16
        Me.tlbStampa.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
        Me.tlbStampa.Name = "tlbStampa"
        Me.tlbStampa.Visible = False
        '
        'tlbStampaVideo
        '
        Me.tlbStampaVideo.Caption = "Stampa video"
        Me.tlbStampaVideo.Glyph = CType(resources.GetObject("tlbStampaVideo.Glyph"), System.Drawing.Image)
        Me.tlbStampaVideo.Id = 17
        Me.tlbStampaVideo.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12)
        Me.tlbStampaVideo.Name = "tlbStampaVideo"
        Me.tlbStampaVideo.Visible = False
        '
        'tlbStampaGriglia
        '
        Me.tlbStampaGriglia.Caption = "Report su griglia"
        Me.tlbStampaGriglia.Glyph = CType(resources.GetObject("tlbStampaGriglia.Glyph"), System.Drawing.Image)
        Me.tlbStampaGriglia.Id = 28
        Me.tlbStampaGriglia.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F11)
        Me.tlbStampaGriglia.Name = "tlbStampaGriglia"
        Me.tlbStampaGriglia.Visible = False
        '
        'tlbZoom
        '
        Me.tlbZoom.Caption = "Zoom"
        Me.tlbZoom.Glyph = CType(resources.GetObject("tlbZoom.Glyph"), System.Drawing.Image)
        Me.tlbZoom.Id = 4
        Me.tlbZoom.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5)
        Me.tlbZoom.Name = "tlbZoom"
        Me.tlbZoom.Visible = True
        '
        'tlbStrumenti
        '
        Me.tlbStrumenti.Caption = "Strumenti"
        Me.tlbStrumenti.Glyph = CType(resources.GetObject("tlbStrumenti.Glyph"), System.Drawing.Image)
        Me.tlbStrumenti.Id = 31
        Me.tlbStrumenti.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.tlbImpostaStampante)})
        Me.tlbStrumenti.Name = "tlbStrumenti"
        Me.tlbStrumenti.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
        Me.tlbStrumenti.Visible = True
        '
        'tlbImpostaStampante
        '
        Me.tlbImpostaStampante.Caption = "Imposta stampante"
        Me.tlbImpostaStampante.Id = 32
        Me.tlbImpostaStampante.Name = "tlbImpostaStampante"
        Me.tlbImpostaStampante.Visible = True
        '
        'tlbGuida
        '
        Me.tlbGuida.Caption = "Guida"
        Me.tlbGuida.Glyph = CType(resources.GetObject("tlbGuida.Glyph"), System.Drawing.Image)
        Me.tlbGuida.Id = 18
        Me.tlbGuida.Name = "tlbGuida"
        Me.tlbGuida.Visible = True
        '
        'tlbEsci
        '
        Me.tlbEsci.Caption = "Esci"
        Me.tlbEsci.Glyph = CType(resources.GetObject("tlbEsci.Glyph"), System.Drawing.Image)
        Me.tlbEsci.Id = 19
        Me.tlbEsci.Name = "tlbEsci"
        Me.tlbEsci.Visible = True
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(460, 35)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 140)
        Me.barDockControlBottom.Size = New System.Drawing.Size(460, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 35)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 105)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(460, 35)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 105)
        '
        'lbDataDa
        '
        Me.lbDataDa.BackColor = System.Drawing.Color.Transparent
        Me.lbDataDa.Location = New System.Drawing.Point(4, 4)
        Me.lbDataDa.Name = "lbDataDa"
        Me.lbDataDa.NTSBordeStyle = NTSInformatica.NTSLabel.NTSBorderStyle.FieldCaption
        Me.lbDataDa.Size = New System.Drawing.Size(72, 20)
        Me.lbDataDa.Text = "Da data"
        Me.lbDataDa.UseMnemonic = False
        '
        'edDataDa
        '
        Me.edDataDa.Cursor = System.Windows.Forms.Cursors.Default
        Me.edDataDa.EditValue = "01/01/1900"
        Me.edDataDa.Location = New System.Drawing.Point(84, 4)
        Me.edDataDa.Name = "edDataDa"
        Me.edDataDa.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.edDataDa.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.edDataDa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.edDataDa.Properties.MaxLength = 65536
        Me.edDataDa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edDataDa.Size = New System.Drawing.Size(80, 20)
        '
        'pnCpvl
        '
        Me.pnCpvl.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pnCpvl.Appearance.Options.UseBackColor = True
        Me.pnCpvl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnCpvl.Controls.Add(Me.lbNomeFile)
        Me.pnCpvl.Controls.Add(Me.edNomeFile)
        Me.pnCpvl.Controls.Add(Me.lbDataA)
        Me.pnCpvl.Controls.Add(Me.edDataA)
        Me.pnCpvl.Controls.Add(Me.lbDataDa)
        Me.pnCpvl.Controls.Add(Me.edDataDa)
        Me.pnCpvl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnCpvl.Location = New System.Drawing.Point(0, 35)
        Me.pnCpvl.Name = "pnCpvl"
        Me.pnCpvl.Size = New System.Drawing.Size(460, 105)
        '
        'lbNomeFile
        '
        Me.lbNomeFile.BackColor = System.Drawing.Color.Transparent
        Me.lbNomeFile.Location = New System.Drawing.Point(4, 28)
        Me.lbNomeFile.Name = "lbNomeFile"
        Me.lbNomeFile.NTSBordeStyle = NTSInformatica.NTSLabel.NTSBorderStyle.FieldCaption
        Me.lbNomeFile.Size = New System.Drawing.Size(72, 20)
        Me.lbNomeFile.Text = "Nome file"
        Me.lbNomeFile.UseMnemonic = False
        '
        'edNomeFile
        '
        Me.edNomeFile.Location = New System.Drawing.Point(84, 28)
        Me.edNomeFile.Name = "edNomeFile"
        Me.edNomeFile.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.edNomeFile.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.edNomeFile.Properties.AutoHeight = False
        Me.edNomeFile.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.edNomeFile.Properties.MaxLength = 65536
        Me.edNomeFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edNomeFile.Size = New System.Drawing.Size(364, 20)
        '
        'lbDataA
        '
        Me.lbDataA.BackColor = System.Drawing.Color.Transparent
        Me.lbDataA.Location = New System.Drawing.Point(184, 4)
        Me.lbDataA.Name = "lbDataA"
        Me.lbDataA.NTSBordeStyle = NTSInformatica.NTSLabel.NTSBorderStyle.FieldCaption
        Me.lbDataA.Size = New System.Drawing.Size(72, 20)
        Me.lbDataA.Text = "A data"
        Me.lbDataA.UseMnemonic = False
        '
        'edDataA
        '
        Me.edDataA.Cursor = System.Windows.Forms.Cursors.Default
        Me.edDataA.EditValue = "31/12/2099"
        Me.edDataA.Location = New System.Drawing.Point(264, 4)
        Me.edDataA.Name = "edDataA"
        Me.edDataA.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.edDataA.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.edDataA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.edDataA.Properties.MaxLength = 65536
        Me.edDataA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edDataA.Size = New System.Drawing.Size(80, 20)
        '
        'FRMZCCAEX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(460, 140)
        Me.Controls.Add(Me.pnCpvl)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FRMZCCAEX"
        Me.Text = "EXPORT C.A. SU EXCEL"
        CType(Me.dttSmartArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NtsBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edDataDa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnCpvl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnCpvl.ResumeLayout(False)
        CType(Me.edNomeFile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edDataA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public Overloads Function Init(ByRef Menu As CLE__MENU, ByRef Param As CLE__CLDP, Optional ByVal Ditta As String = "", Optional ByRef SharedControls As CLE__EVNT = Nothing) As Boolean
    oMenu = Menu
    oApp = oMenu.App
    oCallParams = Param
    If Ditta <> "" Then
      DittaCorrente = Ditta
    Else
      DittaCorrente = oApp.Ditta
    End If
    Me.GctlTipoDoc = ""

    InitializeComponent()
    Me.MinimumSize = Me.Size

    '------------------------------------------------
    'creo e attivo l'entity e inizializzo la funzione che dovrÃ  rilevare gli eventi dall'ENTITY
    Dim strErr As String = ""
    Dim oTmp As Object = Nothing
    If CLN__STD.NTSIstanziaDll(oApp.ServerDir, oApp.NetDir, "BNZCCAEX", "BEZCCAEX", oTmp, strErr, False, "", "") = False Then
      oApp.MsgBoxErr(oApp.Tr(Me, 128534975466065282, "ERRORE in fase di creazione Entity:" & vbCrLf) & strErr)
      Return False
    End If
    oCleCaex = CType(oTmp, CLEZCCAEX)
    '------------------------------------------------
    
    AddHandler oCleCaex.RemoteEvent, AddressOf GestisciEventiEntity
    If oCleCaex.Init(oApp, oScript, oMenu.oCleComm, "", False, "", "") = False Then Return False

    Return True
  End Function

  Public Overridable Sub InitControls()
    InitControlsBeginEndInit(Me, False)
    Dim i As Integer = 0
    Try
      '-------------------------------------------------
      'carico le immagini della toolbar
      Try
        tlbElabora.Glyph = Bitmap.FromFile(oApp.ChildImageDir & "\elabora.png")
        tlbStampa.Glyph = Bitmap.FromFile(oApp.ChildImageDir & "\print.png")
        tlbStampaVideo.Glyph = Bitmap.FromFile(oApp.ChildImageDir & "\prnscreen.png")
        tlbStampaGriglia.Glyph = Bitmap.FromFile(oApp.ChildImageDir & "\prngrid.png")
        tlbZoom.Glyph = Bitmap.FromFile(oApp.ChildImageDir & "\zoom.png")
        tlbGuida.Glyph = Bitmap.FromFile(oApp.ChildImageDir & "\help.png")
        tlbEsci.Glyph = Bitmap.FromFile(oApp.ChildImageDir & "\exit.png")
      Catch ex As Exception
        'non gestisco l'errore: se non c'Ã¨ una immagine prendo quella standard
      End Try
      tlbMain.NTSSetToolTip()

      '-------------------------------------------------
      'completo le informazioni dei controlli
      edDataDa.NTSSetParam(oMenu, "Da data", False)
      edDataA.NTSSetParam(oMenu, "A data", False)
      edNomeFile.NTSSetParam(oMenu, "Nome file", 255)

      edNomeFile.NTSSetParamZoom("..")

      '-------------------------------------------------
      'chiamo lo script per inizializzare i controlli caricati con source ext
      NTSScriptExec("InitControls", Me, Nothing)
    Catch ex As Exception
      '-------------------------------------------------
      CLN__STD.GestErr(ex, Me, "")
      '-------------------------------------------------
    End Try
    InitControlsBeginEndInit(Me, True)
  End Sub

#Region "Eventi Form"
  Public Overridable Sub FRMZCSTUT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try

      '-------------------------------------------------
      'predispongo i controlli
      InitControls()

      '-------------------------------------------------
      'sempre alla fine di questa funzione: applico le regole della gctl
      GctlSetRoules()

    Catch ex As Exception
      '-------------------------------------------------
      CLN__STD.GestErr(ex, Me, "")
      '-------------------------------------------------
    End Try
  End Sub

  Public Overridable Sub FRMZCSTUT_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    Try

    Catch ex As Exception
      '-------------------------------------------------
      CLN__STD.GestErr(ex, Me, "")
      '-------------------------------------------------
    End Try
  End Sub
#End Region

#Region "Eventi Toolbar"
  Public Overridable Sub tlbZoom_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tlbZoom.ItemClick
    Dim strTipork As String = ""
    Dim strTmp As String = ""
    Dim strErr As String = ""

    Try
      'per eventuali altri controlli caricati al volo
      Dim ctrlTmp As Control = NTSFindControlForZoom()
      If ctrlTmp Is Nothing Then Return
      Dim oParam As New CLE__CLDP

      If edNomeFile.Focused Then
        Dim strFilePath As String
        Dim ApriFileDialog As New NTSSaveFileDialog
        Try
          With ApriFileDialog
            .Title = "Sfoglia"
            .Filter = "File Excel|*.xls;*.xlsx|Tutti i file|*.*"
            .InitialDirectory = "C:\"
            .oMenu = oMenu
            If ApriFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
              strFilePath = .FileName
              edNomeFile.Text = strFilePath
            End If
          End With
        Catch ex As Exception
          CLN__STD.GestErr(ex, Me, "")
        Finally
          If Not ApriFileDialog Is Nothing Then ApriFileDialog.Dispose()
          ApriFileDialog = Nothing
        End Try
      Else
        '------------------------------------
        'zoom standard di textbox e griglia
        NTSCallStandardZoom()
      End If

    Catch ex As Exception
      '-------------------------------------------------
      CLN__STD.GestErr(ex, Me, "")
      '-------------------------------------------------
    End Try
  End Sub
  Public Overridable Sub tlbImpostaStampante_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tlbImpostaStampante.ItemClick
    Try
      oMenu.ReportImposta(Me)
    Catch ex As Exception
      '-------------------------------------------------
      CLN__STD.GestErr(ex, Me, "")
      '-------------------------------------------------
    End Try
  End Sub

  Public Overridable Sub tlbGuida_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tlbGuida.ItemClick
    Try
      SendKeys.SendWait("{F1}")
    Catch ex As Exception
      '-------------------------------------------------
      CLN__STD.GestErr(ex, Me, "")
      '-------------------------------------------------
    End Try
  End Sub
  Public Overridable Sub tlbEsci_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tlbEsci.ItemClick
    Try
      Me.Close()
    Catch ex As Exception
      '-------------------------------------------------
      CLN__STD.GestErr(ex, Me, "")
      '-------------------------------------------------
    End Try
  End Sub

#End Region

  Public Overridable Sub Elabora()
    Try

      If Not TestPreElabora() Then Return

      oCleCaex.Elabora(NTSCDate(edDataDa.Text), NTSCDate(edDataA.Text), NTSCStr(edNomeFile.Text))

    Catch ex As Exception
      '-------------------------------------------------
      CLN__STD.GestErr(ex, Me, "")
      '-------------------------------------------------
    End Try
  End Sub

  Public Overridable Function TestPreElabora() As Boolean
    Try

      If NTSCDate(edDataDa.Text) > NTSCDate(edDataA.Text) Then
        oApp.MsgBoxErr("Il valore del campo ""Da data"" non può essere maggiore del campo ""A data"".")
        Return False
      End If
      If System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(strNomeFile)) Then
        oApp.MsgBoxErr("La directory """ & System.IO.Path.GetDirectoryName(strNomeFile) & """ non esiste.")
        Return False
      End If

      Return True

    Catch ex As Exception
      '-------------------------------------------------
      CLN__STD.GestErr(ex, Me, "")
      '-------------------------------------------------
    End Try
  End Function

  'Public Overridable Sub Zoom_Enable(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edContoDa.Enter
  '  Try
  '    tlbZoom.Enabled = True
  '  Catch ex As Exception
  '    '-------------------------------------------------
  '    CLN__STD.GestErr(ex, Me, "")
  '    '-------------------------------------------------
  '  End Try
  'End Sub
  'Public Overridable Sub Zoom_Disable(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edContoDa.Leave
  '  Try
  '    tlbZoom.Enabled = False
  '  Catch ex As Exception
  '    '-------------------------------------------------
  '    CLN__STD.GestErr(ex, Me, "")
  '    '-------------------------------------------------
  '  End Try
  'End Sub



  Private Sub edDataDa_ValidatedAndChanged(sender As Object, e As System.EventArgs) Handles edDataDa.ValidatedAndChanged
    Try

      edDataA.Text = edDataDa.Text

    Catch ex As Exception
      '-------------------------------------------------
      CLN__STD.GestErr(ex, Me, "")
      '-------------------------------------------------
    End Try
  End Sub

  Private Sub tlbElabora_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles tlbElabora.ItemClick
    Try

      Elabora()

    Catch ex As Exception
      '-------------------------------------------------
      CLN__STD.GestErr(ex, Me, "")
      '-------------------------------------------------
    End Try
  End Sub

  Private Sub edNomeFile_NTSZoomGest(sender As Object, ByRef e As NTSEventArgs) Handles edNomeFile.NTSZoomGest
    Try

      e.ZoomHandled = True

    Catch ex As Exception
      '-------------------------------------------------
      CLN__STD.GestErr(ex, Me, "")
      '-------------------------------------------------
    End Try
  End Sub
End Class

