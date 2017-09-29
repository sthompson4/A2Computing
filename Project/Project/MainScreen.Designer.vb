<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game
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
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Board = New System.Windows.Forms.PictureBox()
        Me.Start = New System.Windows.Forms.Button()
        CType(Me.Board, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Board
        '
        Me.Board.Image = Global.Project.My.Resources.Resources.ChessBoard
        Me.Board.InitialImage = Global.Project.My.Resources.Resources.ChessBoard
        Me.Board.Location = New System.Drawing.Point(217, 44)
        Me.Board.Name = "Board"
        Me.Board.Size = New System.Drawing.Size(803, 806)
        Me.Board.TabIndex = 0
        Me.Board.TabStop = False
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(28, 44)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(75, 23)
        Me.Start.TabIndex = 1
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 898)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.Board)
        Me.Name = "Game"
        Me.Text = "Screen"
        CType(Me.Board, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer As Timer
    Public WithEvents Board As PictureBox
    Friend WithEvents Start As Button
End Class
