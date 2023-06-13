using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonEditImages {
    [ToolboxItem(true)]
    public class CustomButtonEdit : ButtonEdit {
        static CustomButtonEdit() {
            RepositoryItemCustomButtonEdit.RegisterCustomButtonEdit();
        }

        public CustomButtonEdit() {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomButtonEdit Properties {
            get { return base.Properties as RepositoryItemCustomButtonEdit; }
        }

        public override string EditorTypeName {
            get { return RepositoryItemCustomButtonEdit.CustomEditName; }
        }

    }
}
