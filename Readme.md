<!-- default file list -->
*Files to look at*:

* [Car.cs](./CS/ButtonEditImages/Car.cs) (VB: [Car.vb](./VB/ButtonEditImages/Car.vb))
* [CustomButtonEdit.cs](CS/ButtonEditImages/Custom%20Editor/CustomButtonEdit.cs) (VB: [CustomButtonEdit.vb](VB/ButtonEditImages/Custom%20Editor/CustomButtonEdit.vb))
* [CustomButtonEditPainter.cs](/CS/ButtonEditImages/Custom%20Editor/CustomButtonEditPainter.cs) (VB: [CustomButtonEditPainter.vb](/VB/ButtonEditImages/Custom%20Editor/CustomButtonEditPainter.vb))
* [CustomButtonEditViewInfo.cs](/CS/ButtonEditImages/Custom%20Editor/CustomButtonEditViewInfo.cs) (VB: [CustomButtonEditViewInfo.vb](/VB/ButtonEditImages/Custom%20Editor/CustomButtonEditViewInfo.vb))
* [CustomEditorButtonObjectInfoArgs.cs](/CS/ButtonEditImages/Custom%20Editor/CustomEditorButtonObjectInfoArgs.cs) (VB: [CustomEditorButtonObjectInfoArgs.vb](/VB/ButtonEditImages/Custom%20Editor/CustomEditorButtonObjectInfoArgs.vb))
* [CustomEditorButtonPainter.cs](/CS/ButtonEditImages/Custom%20Editor/CustomEditorButtonPainter.cs) (VB: [CustomEditorButtonPainter.vb](/VB/ButtonEditImages/Custom%20Editor/CustomEditorButtonPainter.vb))
* [RepositoryItemCustomButtonEdit.cs](/CS/ButtonEditImages/Custom%20Editor/RepositoryItemCustomButtonEdit.cs) (VB: [RepositoryItemCustomButtonEdit.vb](/VB/ButtonEditImages/Custom%20Editor/RepositoryItemCustomButtonEdit.vb))
* [Main.cs](./CS/ButtonEditImages/Main.cs) (VB: [Main.vb](./VB/ButtonEditImages/Main.vb))
* [Program.cs](./CS/ButtonEditImages/Program.cs) (VB: [Program.vb](./VB/ButtonEditImages/Program.vb))
<!-- default file list end -->
# ButtonEdit – How to use different images for buttons in different states


<p>This example shows how to provide the capability to use different images for buttons in different states (Normal, Hot, and Pressed).</p>
<p>In the example, we create a<strong> <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit.class">RepositoryItemButtonEdit</a></strong> descendant with the <strong>ImageCollection</strong> property that contains a linked image collection. <strong>ImageCollection’s</strong> images should have names like: normal_btn№/pressed_btn№/hovered_btn№, where № - is the button number in the <strong><a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit.Buttons.property">RepositoryItemButtonEdit.Buttons</a></strong> collection.</p>
<p>Setting the image for the button state works both at design time and runtime.</p>

<br/>


