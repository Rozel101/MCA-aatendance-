Imports System.Windows.Forms
Public Class Customrenderer
    Inherits ToolStripProfessionalRenderer

    Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)
        ' Check if it's a top-level item
        If Not e.Item.IsOnDropDown Then
            If e.Item.Selected Then
                e.Graphics.FillRectangle(Brushes.LightSkyBlue, e.Item.ContentRectangle)
            Else
                MyBase.OnRenderMenuItemBackground(e)
            End If
        Else
            MyBase.OnRenderMenuItemBackground(e)
        End If
    End Sub
End Class
