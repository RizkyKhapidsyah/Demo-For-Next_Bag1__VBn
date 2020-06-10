<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.listKeluaran = New System.Windows.Forms.ListBox()
        Me.tombolJalankan = New System.Windows.Forms.Button()
        Me.tombolBersihkan = New System.Windows.Forms.Button()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listKeluaran
        '
        Me.listKeluaran.FormattingEnabled = True
        Me.listKeluaran.Location = New System.Drawing.Point(3, 3)
        Me.listKeluaran.Name = "listKeluaran"
        Me.listKeluaran.Size = New System.Drawing.Size(279, 212)
        Me.listKeluaran.TabIndex = 0
        '
        'tombolJalankan
        '
        Me.tombolJalankan.Location = New System.Drawing.Point(3, 231)
        Me.tombolJalankan.Name = "tombolJalankan"
        Me.tombolJalankan.Size = New System.Drawing.Size(98, 29)
        Me.tombolJalankan.TabIndex = 1
        Me.tombolJalankan.Text = "Jalankan Demo"
        Me.tombolJalankan.UseVisualStyleBackColor = True
        '
        'tombolBersihkan
        '
        Me.tombolBersihkan.Location = New System.Drawing.Point(111, 231)
        Me.tombolBersihkan.Name = "tombolBersihkan"
        Me.tombolBersihkan.Size = New System.Drawing.Size(81, 29)
        Me.tombolBersihkan.TabIndex = 2
        Me.tombolBersihkan.Text = "Bersihkan"
        Me.tombolBersihkan.UseVisualStyleBackColor = True
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(200, 231)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(81, 29)
        Me.tombolKeluar.TabIndex = 3
        Me.tombolKeluar.Text = "Keluar"
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 272)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolBersihkan)
        Me.Controls.Add(Me.tombolJalankan)
        Me.Controls.Add(Me.listKeluaran)
        Me.Name = "Form1"
        Me.Text = "Demo For Next 1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listKeluaran As System.Windows.Forms.ListBox
    Friend WithEvents tombolJalankan As System.Windows.Forms.Button
    Friend WithEvents tombolBersihkan As System.Windows.Forms.Button
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button

End Class
