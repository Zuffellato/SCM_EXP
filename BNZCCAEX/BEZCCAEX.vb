#Region "Imports"
Imports System.Data
Imports NTSInformatica.CLN__STD
Imports Microsoft.Office.Interop
#End Region

Public Class CLEZCCAEX
  Inherits CLE__BASE

  Public oCldCaex As CLDZCCAEX

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
  '#End Region

  Public Overrides Function Init(ByRef App As CLE__APP, _
                              ByRef oScriptEngine As INT__SCRIPT, ByRef oCleLbmenu As Object, ByVal strTabella As String, _
                              ByVal bFiller1 As Boolean, ByVal strFiller1 As String, _
                              ByVal strFiller2 As String) As Boolean
    If MyBase.strNomeDal = "BD__BASE" Then MyBase.strNomeDal = "BDZCCAEX"
    MyBase.Init(App, oScriptEngine, oCleLbmenu, strTabella, False, "", "")
    oCldCaex = CType(MyBase.ocldBase, CLDZCCAEX)
    oCldCaex.Init(oApp)
    Return True
  End Function

  Public Overrides Sub BeforeColUpdate(ByVal sender As Object, ByVal e As DataColumnChangeEventArgs)
    Dim strErr As String = ""
    Try

      '-------------------------------------------------------------
      'controllo che in una cella short non venga inserito un numero troppo grande
      If Not CheckCellaShort(e, strErr) Then Throw New NTSException(strErr)
      '-------------------------------------------------------------
      'cerco e, se la trovo, eseguo la funzione specifica per la colonna modificata
      Dim strFunction As String = "BeforeColUpdate_" & e.Column.ColumnName.ToLower
      Dim fun As System.Reflection.MethodInfo = Me.GetType.GetMethod(strFunction)  'occhio: è case_sensitive!!!!
      If Not fun Is Nothing Then fun.Invoke(Me, New Object() {sender, e})
    Catch ex As Exception
      '--------------------------------------------------------------
      
   CLN__STD.GestErr(ex, Me, "")

      '--------------------------------------------------------------
    End Try
  End Sub
  Public Overrides Sub AfterColUpdate(ByVal sender As Object, ByVal e As DataColumnChangeEventArgs)
    Try

      '-------------------------------------------------------------
      'cerco e, se la trovo, eseguo la funzione specifica per la colonna modificata
      Dim strFunction As String = "AfterColUpdate_" & e.Column.ColumnName.ToLower
      Dim fun As System.Reflection.MethodInfo = Me.GetType.GetMethod(strFunction)  'occhio: è case_sensitive!!!!
      If Not fun Is Nothing Then fun.Invoke(Me, New Object() {sender, e})

    Catch ex As Exception
      '--------------------------------------------------------------
      
   CLN__STD.GestErr(ex, Me, "")

      '--------------------------------------------------------------
    End Try
  End Sub

  Public Overridable Function Elabora(ByVal dtDataDa As Date, ByVal dtDataA As Date, ByVal strNomeFile As String) As Boolean

    Dim dttRes As New DataTable
    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet
    Dim misValue As Object = System.Reflection.Missing.Value

    Try

      If Not oCldCaex.GetData(strDittaCorrente, dtDataDa, dtDataA, dttRes) Then
        ThrowRemoteEvent(New NTSEventArgs("", "Non esistono dati nel periodo selezionato."))
        Return False
      End If

      xlApp = New Excel.Application
      xlWorkBook = xlApp.Workbooks.Add(misValue)
      xlWorkSheet = CType(xlWorkBook.ActiveSheet, Excel.Worksheet)
      With xlWorkSheet.Range("A1")
        .Font.Size = 12
        .Font.Bold = True
      End With
      With xlWorkSheet.Range("A3", "J3")
        .Font.Bold = True
        .Columns.AutoFit()
        .HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter
      End With
      xlWorkSheet.Cells(1, 1) = "ESTRATTO C.A. DAL " & dtDataDa.ToShortDateString & " AL " & dtDataA.ToShortDateString
      xlWorkSheet.Cells(3, 1) = "Importo dare"
      xlWorkSheet.Cells(3, 2) = "Importo avere"
      xlWorkSheet.Cells(3, 3) = "Conto"
      xlWorkSheet.Cells(3, 4) = "Descrizione conto"
      xlWorkSheet.Cells(3, 5) = "Centro di costo"
      xlWorkSheet.Cells(3, 6) = "Descr. centro di costo"
      xlWorkSheet.Cells(3, 7) = "Num. doc."
      xlWorkSheet.Cells(3, 8) = "Data doc."
      xlWorkSheet.Cells(3, 9) = "Contropartita"
      xlWorkSheet.Cells(3, 10) = "Descr. contropartita"
      xlWorkSheet.Cells(3, 11) = "Data competenza economica"

      For i As Integer = 0 To dttRes.Rows.Count - 1
        If NTSCStr(dttRes.Rows(i)!pa_darave) = "A" Then
          xlWorkSheet.Cells(4 + i, 1) = 0
          xlWorkSheet.Cells(4 + i, 2) = NTSCDec(dttRes.Rows(i)!pa_importo)
        Else
          xlWorkSheet.Cells(4 + i, 1) = NTSCDec(dttRes.Rows(i)!pa_importo)
          xlWorkSheet.Cells(4 + i, 2) = 0
        End If
        xlWorkSheet.Cells(4 + i, 3) = NTSCInt(dttRes.Rows(i)!pa_conto)
        xlWorkSheet.Cells(4 + i, 4) = NTSCStr(dttRes.Rows(i)!ac_descr1)
        xlWorkSheet.Cells(4 + i, 5) = NTSCInt(dttRes.Rows(i)!pa_codcena)
        xlWorkSheet.Cells(4 + i, 6) = NTSCStr(dttRes.Rows(i)!tb_descena)
        xlWorkSheet.Cells(4 + i, 7) = NTSCInt(dttRes.Rows(i)!pa_numdoc)
        xlWorkSheet.Cells(4 + i, 8) = NTSCDate(dttRes.Rows(i)!xx_datdoc)
        xlWorkSheet.Cells(4 + i, 9) = NTSCInt(dttRes.Rows(i)!pa_controp)
        xlWorkSheet.Cells(4 + i, 10) = NTSCStr(dttRes.Rows(i)!an_descr1)
        xlWorkSheet.Cells(4 + i, 11) = NTSCStr(dttRes.Rows(i)!pa_datini)
      Next

      xlWorkSheet.SaveAs(strNomeFile)

      xlWorkBook.Close()
      xlApp.Quit()

      ThrowRemoteEvent(New NTSEventArgs(CLN__STD.ThMsg.MSG_INFO, "File generato correttamente."))

      Return True

    Catch ex As Exception
      '--------------------------------------------------------------
      
   CLN__STD.GestErr(ex, Me, "")

      '--------------------------------------------------------------
    Finally
      rilasciaOggetto(xlApp)
      rilasciaOggetto(xlWorkBook)
      rilasciaOggetto(xlWorkSheet)
    End Try
  End Function

  Private Sub rilasciaOggetto(ByVal obj As Object)
    Try
      System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
      obj = Nothing
    Catch ex As Exception
      obj = Nothing
    Finally
      GC.Collect()
    End Try
  End Sub

End Class
