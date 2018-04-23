Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors

Namespace ButtonEditImages
    Partial Public Class Main
        Inherits XtraForm

        Private item As RepositoryItemCustomButtonEdit

        Public Sub New()
            InitializeComponent()
            Dim cars As List(Of Car) = GetData()
            gridControl1.DataSource = cars

            item = GetRepositoryItem()
            gridControl1.RepositoryItems.Add(item)

            Dim column As GridColumn = gridView1.Columns("Owner")
            column.ColumnEdit = item
            column.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        End Sub
        Private Function GetData() As List(Of Car)
            Dim cars As New List(Of Car)()
            For i As Integer = 0 To 5
                cars.Add(New Car() With {.Name = (i + 1).ToString()})
            Next i
            Return cars
        End Function
        Private Function GetRepositoryItem() As RepositoryItemCustomButtonEdit
            Dim item As New RepositoryItemCustomButtonEdit()
            item.Buttons.Clear()

            Dim button As New EditorButton(ButtonPredefines.Glyph)
            button.Width = 60
            button.Caption = "Example"
            button.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
            button.ImageOptions.ImageToTextIndent = 20
            item.Buttons.Add(button)
            button = New EditorButton(ButtonPredefines.Glyph)
            item.Buttons.Add(button)

            item.ImageCollection.AddImage(Image.FromFile("hovered.png"), "pressed_btn1")
            item.ImageCollection.AddImage(Image.FromFile("hovered.png"), "hovered_btn0")
            item.ImageCollection.AddImage(Image.FromFile("selected.png"), "pressed_btn0")
            item.ImageCollection.AddImage(Image.FromFile("normal.png"), "normal_btn0")
            Return item
        End Function
        Private Sub OnChangeImageButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            item.ImageCollection.Images(3) = Image.FromFile("selected.png")
        End Sub
    End Class
End Namespace
