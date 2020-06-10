Public Class Form1

    Private Sub tombolJalankan_Click(sender As Object, e As EventArgs) Handles tombolJalankan.Click
        Dim intHitung As Integer    'pencacah loop
        Dim intKuadrat As Integer   'memuat hasil kuadrat
        Dim strTemp As String       'memuat keluaran

        For intHitung = 1 To 10
            'menghitung kuadrat dari intHitung
            intKuadrat = CInt(intHitung ^ 2)

            'menciptakan string untuk ditampilkan
            strTemp = "Kuadrat dari " & intHitung.ToString() &
            " adalah " & intKuadrat.ToString()

            'menambahkan string pada kotak list
            listKeluaran.Items.Add(strTemp)
        Next
    End Sub

    Private Sub tombolBersihkan_Click(sender As Object, e As EventArgs) Handles tombolBersihkan.Click
        'membersihkan kotak list
        listKeluaran.Items.Clear()
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'menutup form
        Me.Close()
    End Sub
End Class
