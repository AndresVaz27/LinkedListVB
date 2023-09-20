<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txtDato = New TextBox()
        txtName = New TextBox()
        txtNumNodos = New TextBox()
        btnCrear = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtDato
        ' 
        txtDato.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtDato.Location = New Point(104, 87)
        txtDato.Name = "txtDato"
        txtDato.Size = New Size(125, 34)
        txtDato.TabIndex = 0
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtName.Location = New Point(104, 166)
        txtName.Name = "txtName"
        txtName.Size = New Size(125, 34)
        txtName.TabIndex = 1
        ' 
        ' txtNumNodos
        ' 
        txtNumNodos.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtNumNodos.Location = New Point(104, 285)
        txtNumNodos.Name = "txtNumNodos"
        txtNumNodos.Size = New Size(125, 34)
        txtNumNodos.TabIndex = 2
        ' 
        ' btnCrear
        ' 
        btnCrear.Location = New Point(353, 92)
        btnCrear.Name = "btnCrear"
        btnCrear.Size = New Size(94, 29)
        btnCrear.TabIndex = 3
        btnCrear.Text = "Crear"
        btnCrear.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(353, 166)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 4
        Button1.Text = "Eliminar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(335, 291)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 5
        Button2.Text = "Crear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(515, 173)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 28)
        Label1.TabIndex = 6
        Label1.Text = "Label1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(988, 399)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(btnCrear)
        Controls.Add(txtNumNodos)
        Controls.Add(txtName)
        Controls.Add(txtDato)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDato As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNumNodos As TextBox
    Friend WithEvents btnCrear As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
End Class
