
Imports System.Drawing
' #############################################################################################
' ### Work to do:
' ###
' ### Defining a new bitmap each time the user clicks, and when getting current pixel colour
' ### is very memory inefficient. It is better to create a global bitmap variable, 
' ### set the picture box to it when loaded, and operate from the single bitmap instance
' ### flushing it back to the picturebox whenever appropriate.
' ###
' ### This MUST be done before you can write the floodfill, or it will chomp up meory after
' ### a very short time
' ###
' ###
' ### Another issue is the mouse move event on the image. If the form is resized past the image
' ### an error will be generated when the sub attempts to get the current pixel colour
' ### as there is no valid pixel within the grey part of the image
' ###
' ### This could be expanded to allow drawing of other shapes, etc.


Public Class frmMain
    Dim bmp As Bitmap
    Dim gr As Graphics
    Dim br As SolidBrush
    ' global declarations can go here
    Public CurrColour As New System.Drawing.Color
    Public GotPic As Boolean = False

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' set default colours here
        CurrColour = Color.Black

        ShowColour()
    End Sub

    Public Sub ShowColour()
        lblCurrentColour.BackColor = CurrColour
    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        Dim c As New ColorDialog
        c.Color = CurrColour
        If c.ShowDialog = DialogResult.OK Then
            CurrColour = c.Color
            ShowColour()
        End If
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim GetFile As New OpenFileDialog
        If GetFile.ShowDialog = DialogResult.OK Then
            ' load file
            pBox.Load(GetFile.FileName)
            Controls.Add(pBox)
            pBox.SizeMode = PictureBoxSizeMode.AutoSize
            GotPic = True
        End If
    End Sub

    Private Sub pBox_MouseUp(sender As Object, e As MouseEventArgs) Handles pBox.MouseUp
        ' mouse up exposes x and y coordinates, whereas mouse click does not
        If GotPic = False Then
            MessageBox.Show("Sorry, please load a picture first", "Error - No Picture", MessageBoxButtons.OK)
            Exit Sub
        Else
            ' get mouse position (i.e. click)
            Dim pos As New Point(e.X, e.Y) ' lock point
            Try
                bmp = New Bitmap(pBox.Image) ' create a bitmap image (it will take dpi and resolution from loaded image)
                gr = Graphics.FromImage(bmp) ' create a graphics surface on which to draw, as bitmaps cannot be directly manipluated
                br = New SolidBrush(CurrColour) ' brush is passed into rectangle fill
                FloodFill(pos, bmp.GetPixel(pos.X, pos.Y))

                'gr.FillRectangle(br, pos.X, pos.Y, 1, 1) ' create a point 1x1 pixel at point using the fill brush defined above

                ' save back to picturebox to view
                pBox.Image = bmp
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub FloodFill(start As Point, ocol As Color)
        'this doesn't completley work as it wont fill all the edges, but it has the gist of it
        'i'm guessing this is due to the stack storing multiple of the same points through the itterations.
        'i tried using recursion but it just resulted in an overflow error every time
        Dim stk As Stack(Of Point) = New Stack(Of Point)
        Dim temp As Point
        Dim count As Integer = 1
        stk.Push(start)
        While stk.Count > 0
            temp = stk.Pop
            If bmp.GetPixel(temp.X, temp.Y) = ocol Then
                gr.FillRectangle(br, temp.X, temp.Y, 1, 1)

                stk.Push(New Point(temp.X - 1, temp.Y))
                stk.Push(New Point(temp.X + 1, temp.Y))
                stk.Push(New Point(temp.X, temp.Y - 1))
                stk.Push(New Point(temp.X, temp.Y + 1))

            End If

        End While
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim save As New SaveFileDialog
        Dim re As Boolean = save.ShowDialog()
        If re = True Then
            pBox.Image.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub
End Class
