Imports System
Imports System.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Utils

Namespace ButtonEditImages

    <UserRepositoryItem("RegisterCustomButtonEdit")>
    Public Class RepositoryItemCustomButtonEdit
        Inherits RepositoryItemButtonEdit

        Private _imageCollection As ImageCollection

        Public Property ImageCollection As ImageCollection
            Get
                Return _imageCollection
            End Get

            Set(ByVal value As ImageCollection)
                If _imageCollection IsNot Nothing Then RemoveHandler _imageCollection.Changed, AddressOf _imageCollection_Changed
                _imageCollection = value
                If _imageCollection IsNot Nothing Then AddHandler _imageCollection.Changed, AddressOf _imageCollection_Changed
                OnPropertiesChanged()
            End Set
        End Property

        Private Sub _imageCollection_Changed(ByVal sender As Object, ByVal e As EventArgs)
            OnPropertiesChanged()
        End Sub

        Shared Sub New()
            Call RegisterCustomButtonEdit()
        End Sub

        Public Const CustomEditName As String = "CustomButtonEdit"

        Public Sub New()
            ImageCollection = New ImageCollection()
        End Sub

        Public Overrides ReadOnly Property EditorTypeName As String
            Get
                Return CustomEditName
            End Get
        End Property

        Public Shared Sub RegisterCustomButtonEdit()
            Dim img As Image = Nothing
            Call EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomEditName, GetType(CustomButtonEdit), GetType(RepositoryItemCustomButtonEdit), GetType(CustomButtonEditViewInfo), New CustomButtonEditPainter(), True, img))
        End Sub

        Public Overrides Sub Assign(ByVal item As RepositoryItem)
            BeginUpdate()
            Try
                MyBase.Assign(item)
                Dim source As RepositoryItemCustomButtonEdit = TryCast(item, RepositoryItemCustomButtonEdit)
                If source Is Nothing Then Return
                '
                ImageCollection = source.ImageCollection
            Finally
                EndUpdate()
            End Try
        End Sub

        Friend Overloads Function GetAllowGlyphSkinning() As Boolean
            Return MyBase.GetAllowGlyphSkinning()
        End Function
    End Class
End Namespace
