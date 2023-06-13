Imports DevExpress.XtraEditors
Imports System.ComponentModel

Namespace ButtonEditImages

    <ToolboxItem(True)>
    Public Class CustomButtonEdit
        Inherits ButtonEdit

        Shared Sub New()
            RepositoryItemCustomButtonEdit.RegisterCustomButtonEdit()
        End Sub

        Public Sub New()
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public Overloads ReadOnly Property Properties As RepositoryItemCustomButtonEdit
            Get
                Return TryCast(MyBase.Properties, RepositoryItemCustomButtonEdit)
            End Get
        End Property

        Public Overrides ReadOnly Property EditorTypeName As String
            Get
                Return RepositoryItemCustomButtonEdit.CustomEditName
            End Get
        End Property
    End Class
End Namespace
