using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ButtonEditImages {
    public class CustomButtonEditViewInfo : ButtonEditViewInfo {
        Action<EditorButtonObjectInfoArgs, object> setContextHtmlPropertyInfoDelegate;
        public CustomButtonEditViewInfo(RepositoryItem item)
            : base(item) {
            PropertyInfo propertyInfo = typeof(EditorButtonObjectInfoArgs).GetProperty("ContextHtml", BindingFlags.Instance | BindingFlags.NonPublic);
            if (propertyInfo != null) {
                setContextHtmlPropertyInfoDelegate = (Action<EditorButtonObjectInfoArgs, object>)propertyInfo.SetMethod.CreateDelegate(typeof(Action<EditorButtonObjectInfoArgs, object>));
            }
        }
        protected override EditorButtonPainter CreateButtonPainter() {
            return new CustomEditorButtonPainter(LookAndFeel);
        }
        protected override EditorButtonObjectInfoArgs CreateButtonInfo(EditorButton button, int index) {
            CustomEditorButtonObjectInfoArgs res = new CustomEditorButtonObjectInfoArgs(button, PaintAppearance);
            if (setContextHtmlPropertyInfoDelegate != null) {
                setContextHtmlPropertyInfoDelegate(res, GetHtmlContext());
            }
            res.AllowGlyphSkinning = Item.GetAllowGlyphSkinning();
            res.AllowHtmlDraw = AllowHtmlString;
            res.Appearance.TextOptions.RightToLeft = RightToLeft;
            return res;
        }

        internal new RepositoryItemCustomButtonEdit Item {
            get { return base.Item as RepositoryItemCustomButtonEdit; }
        }
        protected override System.Drawing.Size CalcMinButtonBounds(EditorButtonObjectInfoArgs info) {
            RepositoryItemCustomButtonEdit item = Item as RepositoryItemCustomButtonEdit;
            CustomEditorButtonObjectInfoArgs args = info as CustomEditorButtonObjectInfoArgs;
            args.SetCustomImage(item);
            return base.CalcMinButtonBounds(info);
        }
    }
}
