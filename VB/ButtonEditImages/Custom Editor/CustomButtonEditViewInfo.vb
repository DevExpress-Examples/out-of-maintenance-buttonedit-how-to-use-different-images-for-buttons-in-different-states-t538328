Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports System
Imports System.Drawing
Imports System.Reflection

Namespace ButtonEditImages

    Public Class CustomButtonEditViewInfo
        Inherits ButtonEditViewInfo

        Private setContextHtmlPropertyInfoDelegate As Action(Of EditorButtonObjectInfoArgs, Object)

        Public Sub New(ByVal item As RepositoryItem)
            MyBase.New(item)
            Dim propertyInfo As PropertyInfo = GetType(EditorButtonObjectInfoArgs).GetProperty("ContextHtml", BindingFlags.Instance Or BindingFlags.NonPublic)
            If propertyInfo IsNot Nothing Then
                setContextHtmlPropertyInfoDelegate = CType(propertyInfo.SetMethod.CreateDelegate(GetType(Action(Of EditorButtonObjectInfoArgs, Object))), Action(Of EditorButtonObjectInfoArgs, Object))
            End If
        End Sub

        Protected Overrides Function CreateButtonPainter() As EditorButtonPainter
            Return New CustomEditorButtonPainter(LookAndFeel)
        End Function

        Protected Overrides Function CreateButtonInfo(ByVal button As EditorButton, ByVal index As Integer) As EditorButtonObjectInfoArgs
            Dim res As CustomEditorButtonObjectInfoArgs = New CustomEditorButtonObjectInfoArgs(button, PaintAppearance)
            If setContextHtmlPropertyInfoDelegate IsNot Nothing Then
                setContextHtmlPropertyInfoDelegate(res, GetHtmlContext())
            End If

            res.AllowGlyphSkinning = Item.GetAllowGlyphSkinning()
            res.AllowHtmlDraw = AllowHtmlString
            res.Appearance.TextOptions.RightToLeft = RightToLeft
            Return res
        End Function

        Friend Overloads ReadOnly Property Item As RepositoryItemCustomButtonEdit
            Get
                Return TryCast(MyBase.Item, RepositoryItemCustomButtonEdit)
            End Get
        End Property

        Protected Overrides Function CalcMinButtonBounds(ByVal info As EditorButtonObjectInfoArgs) As System.Drawing.Size
            Dim item As RepositoryItemCustomButtonEdit = TryCast(Me.Item, RepositoryItemCustomButtonEdit)
            Dim args As CustomEditorButtonObjectInfoArgs = TryCast(info, CustomEditorButtonObjectInfoArgs)
            args.SetCustomImage(item)
            Return MyBase.CalcMinButtonBounds(info)
        End Function
    End Class
End Namespace
