Namespace ButtonEditImages

    Partial Class Main

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ButtonEditImages.Main))
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.flowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.flowLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(657, 416)
            Me.gridControl1.TabIndex = 3
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageStream = CType((resources.GetObject("imageCollection1.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection1.Images.SetKeyName(0, "pressed_btn0")
            Me.imageCollection1.InsertGalleryImage("apply_32x32.png", "images/actions/apply_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/apply_32x32.png"), 1)
            Me.imageCollection1.Images.SetKeyName(1, "apply_32x32.png")
            ' 
            ' flowLayoutPanel1
            ' 
            Me.flowLayoutPanel1.Controls.Add(Me.simpleButton1)
            Me.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.flowLayoutPanel1.Location = New System.Drawing.Point(0, 416)
            Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
            Me.flowLayoutPanel1.Size = New System.Drawing.Size(657, 31)
            Me.flowLayoutPanel1.TabIndex = 4
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(3, 3)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(654, 23)
            Me.simpleButton1.TabIndex = 0
            Me.simpleButton1.Text = "Set new icon"
            AddHandler Me.simpleButton1.Click, New System.EventHandler(AddressOf Me.OnChangeImageButtonClick)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(657, 447)
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.flowLayoutPanel1)
            Me.Name = "Form1"
            Me.Text = "Main"
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.flowLayoutPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private imageCollection1 As DevExpress.Utils.ImageCollection

        Private flowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
