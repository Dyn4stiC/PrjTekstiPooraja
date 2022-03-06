<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EkraaniVorm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblSisend = New System.Windows.Forms.Label()
        Me.btnPoora = New System.Windows.Forms.Button()
        Me.txtSisendTekst = New System.Windows.Forms.TextBox()
        Me.lblPooratud = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTaishaalikuid = New System.Windows.Forms.TextBox()
        Me.txtPooratudTekst = New System.Windows.Forms.TextBox()
        Me.txtPalindroom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTahemargid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblSisend
        '
        Me.lblSisend.AutoSize = True
        Me.lblSisend.Location = New System.Drawing.Point(62, 24)
        Me.lblSisend.Name = "lblSisend"
        Me.lblSisend.Size = New System.Drawing.Size(39, 13)
        Me.lblSisend.TabIndex = 0
        Me.lblSisend.Text = "Sisend"
        '
        'btnPoora
        '
        Me.btnPoora.Location = New System.Drawing.Point(107, 47)
        Me.btnPoora.Name = "btnPoora"
        Me.btnPoora.Size = New System.Drawing.Size(148, 23)
        Me.btnPoora.TabIndex = 1
        Me.btnPoora.Text = "Lahenda!"
        Me.btnPoora.UseVisualStyleBackColor = True
        '
        'txtSisendTekst
        '
        Me.txtSisendTekst.Location = New System.Drawing.Point(107, 21)
        Me.txtSisendTekst.Name = "txtSisendTekst"
        Me.txtSisendTekst.Size = New System.Drawing.Size(148, 20)
        Me.txtSisendTekst.TabIndex = 2
        '
        'lblPooratud
        '
        Me.lblPooratud.AutoSize = True
        Me.lblPooratud.Location = New System.Drawing.Point(26, 80)
        Me.lblPooratud.Name = "lblPooratud"
        Me.lblPooratud.Size = New System.Drawing.Size(79, 13)
        Me.lblPooratud.TabIndex = 3
        Me.lblPooratud.Text = "Pööratud tekst:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Täishäälikuid:"
        '
        'txtTaishaalikuid
        '
        Me.txtTaishaalikuid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTaishaalikuid.Location = New System.Drawing.Point(107, 102)
        Me.txtTaishaalikuid.Name = "txtTaishaalikuid"
        Me.txtTaishaalikuid.ReadOnly = True
        Me.txtTaishaalikuid.Size = New System.Drawing.Size(148, 20)
        Me.txtTaishaalikuid.TabIndex = 6
        '
        'txtPooratudTekst
        '
        Me.txtPooratudTekst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPooratudTekst.Location = New System.Drawing.Point(107, 76)
        Me.txtPooratudTekst.Name = "txtPooratudTekst"
        Me.txtPooratudTekst.ReadOnly = True
        Me.txtPooratudTekst.Size = New System.Drawing.Size(148, 20)
        Me.txtPooratudTekst.TabIndex = 7
        '
        'txtPalindroom
        '
        Me.txtPalindroom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPalindroom.Location = New System.Drawing.Point(107, 128)
        Me.txtPalindroom.Name = "txtPalindroom"
        Me.txtPalindroom.ReadOnly = True
        Me.txtPalindroom.Size = New System.Drawing.Size(148, 20)
        Me.txtPalindroom.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Palindroom:"
        '
        'txtTahemargid
        '
        Me.txtTahemargid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTahemargid.Location = New System.Drawing.Point(107, 154)
        Me.txtTahemargid.Name = "txtTahemargid"
        Me.txtTahemargid.ReadOnly = True
        Me.txtTahemargid.Size = New System.Drawing.Size(148, 20)
        Me.txtTahemargid.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Tahemärgid ette"
        '
        'EkraaniVorm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 186)
        Me.Controls.Add(Me.txtTahemargid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPalindroom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPooratudTekst)
        Me.Controls.Add(Me.txtTaishaalikuid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPooratud)
        Me.Controls.Add(Me.txtSisendTekst)
        Me.Controls.Add(Me.btnPoora)
        Me.Controls.Add(Me.lblSisend)
        Me.Name = "EkraaniVorm"
        Me.Text = "Teksti töötleja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSisend As Label
    Friend WithEvents btnPoora As Button
    Friend WithEvents txtSisendTekst As TextBox
    Friend WithEvents lblPooratud As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTaishaalikuid As TextBox
    Friend WithEvents txtPooratudTekst As TextBox
    Friend WithEvents txtPalindroom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTahemargid As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
