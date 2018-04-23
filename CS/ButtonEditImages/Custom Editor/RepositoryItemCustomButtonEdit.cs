using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.Utils;

namespace ButtonEditImages
{
    [UserRepositoryItem("RegisterCustomButtonEdit")]
    public class RepositoryItemCustomButtonEdit : RepositoryItemButtonEdit
    {
        private ImageCollection _imageCollection;

        public ImageCollection ImageCollection {
            get { return _imageCollection; }
            set {
                if(_imageCollection != null)
                    _imageCollection.Changed -= _imageCollection_Changed;
                _imageCollection = value;
                if (_imageCollection != null)
                    _imageCollection.Changed += _imageCollection_Changed;
                OnPropertiesChanged();
            }
        }

        private void _imageCollection_Changed(object sender, EventArgs e)
        {
            OnPropertiesChanged();
        }

        static RepositoryItemCustomButtonEdit()
        {
            RegisterCustomButtonEdit();
        }

        public const string CustomEditName = "CustomButtonEdit";

        public RepositoryItemCustomButtonEdit()
        {
            ImageCollection = new ImageCollection();
        }

        public override string EditorTypeName {
            get{
                return CustomEditName;
            }
        }

        public static void RegisterCustomButtonEdit()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(CustomButtonEdit), typeof(RepositoryItemCustomButtonEdit), typeof(CustomButtonEditViewInfo), new CustomButtonEditPainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemCustomButtonEdit source = item as RepositoryItemCustomButtonEdit;
                if(source == null) return;
                ImageCollection = source.ImageCollection;
                //
            } finally
            {
                EndUpdate();
            }
        }
          internal new bool GetAllowGlyphSkinning() {
              return base.GetAllowGlyphSkinning();
        }
    }

}
