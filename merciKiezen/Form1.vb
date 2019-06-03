Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()

        Dim chocolade As String() = {"melk", "koffie-creme", "hazelnoot", "marsepein", "zwarte-creme", "zwarte-mouse", "praline-creme", "hazelnoot-amandel"}
        Dim persoon As String() = {"Arthur", "Kyle", "Tim", "Denis"}
        Dim getal As Integer = Int(Rnd() * 8) + 1
        Dim getal2 As Integer = Int(Rnd() * 4) + 1
        ListBox1.Items.Add(persoon(getal2) & " krijgt " & chocolade(getal))
    End Sub
End Class
