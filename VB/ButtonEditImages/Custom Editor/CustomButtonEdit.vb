Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace ButtonEditImages
    <ToolboxItem(True)> _
    Public Class CustomButtonEdit
        Inherits ButtonEdit

        Shared Sub New()
            RepositoryItemCustomButtonEdit.RegisterCustomButtonEdit()
        End Sub

        Public Sub New()
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public Shadows ReadOnly Property Properties() As RepositoryItemCustomButtonEdit
            Get
                Return TryCast(MyBase.Properties, RepositoryItemCustomButtonEdit)
            End Get
        End Property

        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return RepositoryItemCustomButtonEdit.CustomEditName
            End Get
        End Property

    End Class
End Namespace
