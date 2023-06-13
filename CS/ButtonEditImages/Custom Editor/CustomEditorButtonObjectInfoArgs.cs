using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonEditImages {
    public class CustomEditorButtonObjectInfoArgs : EditorButtonObjectInfoArgs {
        public CustomEditorButtonObjectInfoArgs(EditorButton button, AppearanceObject backStyle, bool isStandalone)
            : base(button, backStyle, isStandalone) {

        }
        public CustomEditorButtonObjectInfoArgs(EditorButton button, AppearanceObject backStyle)
            : base(button, backStyle) {

        }
        public CustomEditorButtonObjectInfoArgs(GraphicsCache cache, EditorButton button, AppearanceObject backStyle)
            : base(cache, button, backStyle) {

        }
        protected CustomEditorButtonObjectInfoArgs(EditorButton button)
            : base(button) {

        }
        internal Image CustomImage { get; set; }
        public override bool IsImageExists {
            get {
                bool isImageExists = base.IsImageExists;
                if (isImageExists) return isImageExists;
                if (Button.Kind != ButtonPredefines.Glyph) return false;
                return CustomImage != null;
            }
        }
        public override Size ImageSize {
            get {
                Size size = base.ImageSize;
                if (size.IsEmpty && IsImageExists)
                    return CustomImage.Size;
                return size;
            }
        }
        protected override EditorButtonObjectInfoArgs CreateInstance() {
            return new CustomEditorButtonObjectInfoArgs(Button, null);
        }
        internal void SetCustomImage(RepositoryItemCustomButtonEdit item) {
            if (Button.Kind == ButtonPredefines.Glyph) {
                switch (State) {
                    case ObjectState.Hot:
                        SetImage(item, "hovered_btn" + item.Buttons.IndexOf(Button));
                        break;
                    case ObjectState.Pressed | ObjectState.Hot:
                    case ObjectState.Pressed:
                        SetImage(item, "pressed_btn" + item.Buttons.IndexOf(Button));
                        break;
                    case ObjectState.Normal:
                        SetImage(item, "normal_btn" + item.Buttons.IndexOf(Button));
                        break;
                }
            }
        }
        private void SetImage(RepositoryItemCustomButtonEdit item, string imageName) {
            CustomImage = item.ImageCollection.Images[imageName];
        }
    }
}
