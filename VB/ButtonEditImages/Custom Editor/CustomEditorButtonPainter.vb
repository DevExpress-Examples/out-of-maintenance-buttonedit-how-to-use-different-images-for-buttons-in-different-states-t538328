Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.Utils.Drawing
Imports DevExpress.Skins
Imports System.Drawing
Imports DevExpress.XtraEditors.Controls

Namespace ButtonEditImages

    Friend Class CustomEditorButtonPainter
        Inherits SkinEditorButtonPainter

        Public Sub New(ByVal provider As ISkinProvider)
            MyBase.New(provider)
        End Sub

        Protected Overrides Sub DrawKindImage(ByVal e As EditorButtonObjectInfoArgs, ByVal rect As Rectangle)
            Dim args As CustomEditorButtonObjectInfoArgs = TryCast(e, CustomEditorButtonObjectInfoArgs)
            If args.CustomImage Is Nothing Then
                MyBase.DrawKindImage(e, rect)
            Else
                DrawCustomKindImage(args, rect)
            End If
        End Sub

        Protected Overridable Sub DrawCustomKindImage(ByVal e As CustomEditorButtonObjectInfoArgs, ByVal rect As Rectangle)
            If e.Button.Kind = ButtonPredefines.Glyph Then
                Dim r As Rectangle = New Rectangle(Point.Empty, e.ImageSize)
                If Not e.GetAllowGlyphSkinning() Then
                    e.Cache.Paint.DrawImage(e.Graphics, e.CustomImage, rect, r, e.State <> ObjectState.Disabled)
                End If
            End If
        End Sub
    End Class
End Namespace
