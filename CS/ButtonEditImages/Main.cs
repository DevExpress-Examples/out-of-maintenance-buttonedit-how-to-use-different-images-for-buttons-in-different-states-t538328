using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;

namespace ButtonEditImages
{
    public partial class Main : XtraForm
    {
        RepositoryItemCustomButtonEdit item;
        
        public Main()
        {
            InitializeComponent();
            List<Car> cars = GetData();
            gridControl1.DataSource = cars;
           
            item = GetRepositoryItem();
            gridControl1.RepositoryItems.Add(item);

            GridColumn column = gridView1.Columns["Owner"];
            column.ColumnEdit = item;
            column.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
        }
        private List<Car> GetData() {
            List<Car> cars = new List<Car>();
            for (int i = 0; i < 6; i++)
                cars.Add(new Car() { Name = (i + 1).ToString() });
            return cars;
        }
        private RepositoryItemCustomButtonEdit GetRepositoryItem() {
            RepositoryItemCustomButtonEdit item = new RepositoryItemCustomButtonEdit();
            item.Buttons.Clear();

            EditorButton button = new EditorButton(ButtonPredefines.Glyph);
            button.Width = 60;
            button.Caption = "Example";
            button.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            button.ImageOptions.ImageToTextIndent = 20;
            item.Buttons.Add(button);
            button = new EditorButton(ButtonPredefines.Glyph);
            item.Buttons.Add(button);

            item.ImageCollection.AddImage(Image.FromFile("hovered.png"), "pressed_btn1");
            item.ImageCollection.AddImage(Image.FromFile("hovered.png"), "hovered_btn0");
            item.ImageCollection.AddImage(Image.FromFile("selected.png"), "pressed_btn0");
            item.ImageCollection.AddImage(Image.FromFile("normal.png"), "normal_btn0");
            return item;
        }
        private void OnChangeImageButtonClick(object sender, EventArgs e)
        {
            item.ImageCollection.Images[3] = Image.FromFile("selected.png");
        }
    }
}
