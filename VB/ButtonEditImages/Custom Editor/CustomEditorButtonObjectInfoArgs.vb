Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Drawing
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace ButtonEditImages
    Public Class CustomEditorButtonObjectInfoArgs
        Inherits EditorButtonObjectInfoArgs

        Public Sub New(ByVal button As EditorButton, ByVal backStyle As AppearanceObject, ByVal isStandalone As Boolean)
            MyBase.New(button, backStyle, isStandalone)

        End Sub
        Public Sub New(ByVal button As EditorButton, ByVal backStyle As AppearanceObject)
            MyBase.New(button, backStyle)

        End Sub
        Public Sub New(ByVal cache As GraphicsCache, ByVal button As EditorButton, ByVal backStyle As AppearanceObject)
            MyBase.New(cache, button, backStyle)

        End Sub
        Protected Sub New(ByVal button As EditorButton)
            MyBase.New(button)

        End Sub
        Friend Property CustomImage() As Image
        Public Overrides ReadOnly Property IsImageExists() As Boolean
            Get

                Dim isImageExists_Renamed As Boolean = MyBase.IsImageExists
                If isImageExists_Renamed Then
                    Return isImageExists_Renamed
                End If
                If Button.Kind <> ButtonPredefines.Glyph Then
                    Return False
                End If
                Return CustomImage IsNot Nothing
            End Get
        End Property
        Public Overrides ReadOnly Property ImageSize() As Size
            Get
                Dim size As Size = MyBase.ImageSize
                If size.IsEmpty AndAlso IsImageExists Then
                    Return CustomImage.Size
                End If
                Return size
            End Get
        End Property
        Protected Overrides Function CreateInstance() As EditorButtonObjectInfoArgs
            Return New CustomEditorButtonObjectInfoArgs(Button, Nothing)
        End Function
        Friend Sub SetCustomImage(ByVal item As RepositoryItemCustomButtonEdit)
            If Button.Kind = ButtonPredefines.Glyph Then
                Select Case State
                    Case ObjectState.Hot
                        SetImage(item, "hovered_btn" & item.Buttons.IndexOf(Button))
                    Case ObjectState.Pressed Or ObjectState.Hot, ObjectState.Pressed
                        SetImage(item, "pressed_btn" & item.Buttons.IndexOf(Button))
                    Case ObjectState.Normal
                        SetImage(item, "normal_btn" & item.Buttons.IndexOf(Button))
                End Select
            End If
        End Sub
        Private Sub SetImage(ByVal item As RepositoryItemCustomButtonEdit, ByVal imageName As String)
            CustomImage = item.ImageCollection.Images(imageName)
        End Sub
    End Class
End Namespace
