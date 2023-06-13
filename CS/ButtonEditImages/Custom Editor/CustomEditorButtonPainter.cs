using DevExpress.XtraEditors.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils.Drawing;
using DevExpress.Skins;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;

namespace ButtonEditImages {
    class CustomEditorButtonPainter : SkinEditorButtonPainter {

        public CustomEditorButtonPainter(ISkinProvider provider)
            : base(provider) {
        }

        protected override void DrawKindImage(EditorButtonObjectInfoArgs e, Rectangle rect) {
            CustomEditorButtonObjectInfoArgs args = e as CustomEditorButtonObjectInfoArgs;
            if (args.CustomImage == null) {
                base.DrawKindImage(e, rect);
            }
            else {
                DrawCustomKindImage(args, rect);
            }
        }
        protected virtual void DrawCustomKindImage(CustomEditorButtonObjectInfoArgs e, Rectangle rect) {
            if (e.Button.Kind == ButtonPredefines.Glyph) {
                Rectangle r = new Rectangle(Point.Empty, e.ImageSize);
                if (!e.GetAllowGlyphSkinning()) {
                    e.Cache.Paint.DrawImage(e.Graphics, e.CustomImage, rect, r, e.State != ObjectState.Disabled);
                }
            }
        }
    }
}