Public Class Game

    Sub Setup()
        Dim Piece As String
        Dim X As Integer
        Dim Y As Integer
        Dim Board As New CBoard
        Dim e As PaintEventArgs

        Y = 1
        For X = 0 To 7
            Piece = "WPawn"
            Board.DrawPiece(e, X, Y, Piece)
        Next
        Y = 6
        For X = 0 To 7
            Piece = "BPawn"
            Board.DrawPiece(e, X, Y, Piece)
        Next

        Y = 0
        X = 0
        Board.DrawPiece(e, X, Y, "WCastle")
        X = 7
        Board.DrawPiece(e, X, Y, "WCastle")

        X = 1
        Board.DrawPiece(e, X, Y, "WCastle")

    End Sub

    Private Sub Board_MouseClick(sender As Object, e As MouseEventArgs) Handles Board.MouseClick
        Dim X As Integer
        Dim Y As Integer

        X = e.Location.X
        Y = e.Location.Y

        X = X \ 100
        Y = Y \ 100

    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        MessageBox.Show(Start, "Start Game?")
        Setup()

    End Sub
End Class

Public Class CBoard
    Dim Square(7, 7) As String
    Public Sub DrawPiece(ByVal e As System.Windows.Forms.PaintEventArgs, X As Integer, Y As Integer, Piece As String)
        Dim PieceImage As Image
        PieceImage = Image.FromFile("U:\Visual Studio 2017\Projects\Project\Project\bin\Release\ChessAssets\" & Piece & ".png")
        Square(X, Y) = Piece
        e.Graphics.DrawImage(PieceImage, ((X + 1) * 100), ((Y + 1) * 100), 100, 100)

    End Sub
    Public Sub SelectPiece(X, Y)
        Dim Piece As String
        Piece = Square(1, 1)
    End Sub
End Class

