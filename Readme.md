# ButtonEdit – How to use different images for buttons in different states


<p>This example shows how to provide the capability to use different images for buttons in different states (Normal, Hot, and Pressed).</p>
<p>In the example, we create a<strong> <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit.class">RepositoryItemButtonEdit</a></strong> descendant with the <strong>ImageCollection</strong> property that contains a linked image collection. <strong>ImageCollection’s</strong> images should have names like: normal_btn№/pressed_btn№/hovered_btn№, where № - is the button number in the <strong><a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit.Buttons.property">RepositoryItemButtonEdit.Buttons</a></strong> collection.</p>
<p>Setting the image for the button state works both at design time and runtime.</p>

<br/>


