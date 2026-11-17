Imports NTSInformatica.CLN__STD
Imports System.Data.Common
Imports NTSInformatica
Imports System.IO

Public Class CLDZCCAEX
  Inherits CLD__BASE

  Public Overridable Function GetData(ByVal strDitta As String, ByVal dtDataDa As Date, ByVal dtDataA As Date, ByRef dttRes As DataTable) As Boolean
    Dim strSQL As String

    Try
      strSQL = "SELECT pa_darave,pa_importo,pa_conto,pa_codcena,pa_numdoc,pa_datini,ISNULL(pa_datdoc,pa_datreg) AS xx_datdoc,pa_controp,anagca.ac_descr1,tabcena.tb_descena,anagra.an_descr1" & _
              " FROM priana" & _
              " INNER JOIN anagca ON priana.codditt = anagca.codditt AND pa_conto = ac_conto" & _
              " INNER JOIN tabcena ON priana.codditt = tabcena.codditt AND pa_codcena = tb_codcena" & _
              " LEFT OUTER JOIN anagra ON priana.codditt = anagra.codditt AND pa_controp = an_conto" & _
              " WHERE priana.codditt = " & CStrSQL(strDitta) & " AND pa_origine = 'C'" & _
              " AND pa_datreg BETWEEN " & CDataSQL(dtDataDa) & " AND " & CDataSQL(dtDataA) & _
              " ORDER BY pa_conto,pa_codcena,xx_datdoc"

      dttRes = OpenRecordset(strSQL, CLE__APP.DBTIPO.DBAZI)
      If dttRes.Rows.Count > 0 Then Return True

    Catch ex As Exception
      '--------------------------------------------------------------
      CLN__STD.GestErr(ex, Me, "")
      '--------------------------------------------------------------
    End Try
  End Function
End Class
