Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace ButtonEditImages
    Public Class CustomButtonEditPainter
        Inherits ButtonEditPainter

        Shared Sub New()
        End Sub
        Public Sub New()
        End Sub
        Protected Overrides Sub DrawButton(ByVal viewInfo As ButtonEditViewInfo, ByVal info As EditorButtonObjectInfoArgs)
            Dim item As RepositoryItemCustomButtonEdit = TryCast(viewInfo.Item, RepositoryItemCustomButtonEdit)
            Dim args As CustomEditorButtonObjectInfoArgs = TryCast(info, CustomEditorButtonObjectInfoArgs)
            args.SetCustomImage(item)
            MyBase.DrawButton(viewInfo, info)
        End Sub
    End Class
End Namespace
