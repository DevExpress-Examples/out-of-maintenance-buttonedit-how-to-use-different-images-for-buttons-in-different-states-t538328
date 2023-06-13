using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonEditImages {
    public class CustomButtonEditPainter : ButtonEditPainter {
        static CustomButtonEditPainter() {
        }
        public CustomButtonEditPainter() {
        }
        protected override void DrawButton(ButtonEditViewInfo viewInfo, EditorButtonObjectInfoArgs info) {
            RepositoryItemCustomButtonEdit item = viewInfo.Item as RepositoryItemCustomButtonEdit;
            CustomEditorButtonObjectInfoArgs args = info as CustomEditorButtonObjectInfoArgs;
            args.SetCustomImage(item);
            base.DrawButton(viewInfo, info);
        }
    }
}
