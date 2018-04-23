Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Utils

Namespace ButtonEditImages
    <UserRepositoryItem("RegisterCustomButtonEdit")> _
    Public Class RepositoryItemCustomButtonEdit
        Inherits RepositoryItemButtonEdit

        Private _imageCollection As ImageCollection

        Public Property ImageCollection() As ImageCollection
            Get
                Return _imageCollection
            End Get
            Set(ByVal value As ImageCollection)
                If _imageCollection IsNot Nothing Then
                    RemoveHandler _imageCollection.Changed, AddressOf _imageCollection_Changed
                End If
                _imageCollection = value
                If _imageCollection IsNot Nothing Then
                    AddHandler _imageCollection.Changed, AddressOf _imageCollection_Changed
                End If
                OnPropertiesChanged()
            End Set
        End Property

        Private Sub _imageCollection_Changed(ByVal sender As Object, ByVal e As EventArgs)
            OnPropertiesChanged()
        End Sub

        Shared Sub New()
            RegisterCustomButtonEdit()
        End Sub

        Public Const CustomEditName As String = "CustomButtonEdit"

        Public Sub New()
            ImageCollection = New ImageCollection()
        End Sub

        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return CustomEditName
            End Get
        End Property

        Public Shared Sub RegisterCustomButtonEdit()
            Dim img As Image = Nothing
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomEditName, GetType(CustomButtonEdit), GetType(RepositoryItemCustomButtonEdit), GetType(CustomButtonEditViewInfo), New CustomButtonEditPainter(), True, img))
        End Sub

        Public Overrides Sub Assign(ByVal item As RepositoryItem)
            BeginUpdate()
            Try
                MyBase.Assign(item)
                Dim source As RepositoryItemCustomButtonEdit = TryCast(item, RepositoryItemCustomButtonEdit)
                If source Is Nothing Then
                    Return
                End If
                ImageCollection = source.ImageCollection
                '
            Finally
                EndUpdate()
            End Try
        End Sub
          Friend Shadows Function GetAllowGlyphSkinning() As Boolean
              Return MyBase.GetAllowGlyphSkinning()
          End Function
    End Class

End Namespace
