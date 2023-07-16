
namespace FluentDesign
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.fluentDesignFormContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElementNewInvoice = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementCategories = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementCustomer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementCategory = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementProduct = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.itemNav = new DevExpress.XtraBars.BarStaticItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer
            // 
            this.fluentDesignFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer.Location = new System.Drawing.Point(260, 40);
            this.fluentDesignFormContainer.Name = "fluentDesignFormContainer";
            this.fluentDesignFormContainer.Size = new System.Drawing.Size(573, 427);
            this.fluentDesignFormContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementNewInvoice,
            this.accordionControlElementCategories});
            this.accordionControl1.Location = new System.Drawing.Point(0, 40);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 427);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElementNewInvoice
            // 
            this.accordionControlElementNewInvoice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementNewInvoice.ImageOptions.Image")));
            this.accordionControlElementNewInvoice.Name = "accordionControlElementNewInvoice";
            this.accordionControlElementNewInvoice.Text = "New Invoice";
            this.accordionControlElementNewInvoice.Click += new System.EventHandler(this.accordionControlElementNewInvoice_Click);
            // 
            // accordionControlElementCategories
            // 
            this.accordionControlElementCategories.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementCustomer,
            this.accordionControlElementCategory,
            this.accordionControlElementProduct});
            this.accordionControlElementCategories.Expanded = true;
            this.accordionControlElementCategories.Name = "accordionControlElementCategories";
            this.accordionControlElementCategories.Text = "Categories";
            // 
            // accordionControlElementCustomer
            // 
            this.accordionControlElementCustomer.Name = "accordionControlElementCustomer";
            this.accordionControlElementCustomer.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementCustomer.Text = "Customers";
            this.accordionControlElementCustomer.Click += new System.EventHandler(this.accordionControlElementCustomer_Click);
            // 
            // accordionControlElementCategory
            // 
            this.accordionControlElementCategory.Name = "accordionControlElementCategory";
            this.accordionControlElementCategory.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementCategory.Text = "Categories";
            this.accordionControlElementCategory.Click += new System.EventHandler(this.accordionControlElementCategory_Click);
            // 
            // accordionControlElementProduct
            // 
            this.accordionControlElementProduct.Name = "accordionControlElementProduct";
            this.accordionControlElementProduct.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementProduct.Text = "Products";
            this.accordionControlElementProduct.Click += new System.EventHandler(this.accordionControlElementProduct_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.itemNav});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(833, 40);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.itemNav);
            // 
            // itemNav
            // 
            this.itemNav.Caption = "???";
            this.itemNav.Id = 0;
            this.itemNav.Name = "itemNav";
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.DockingEnabled = false;
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.itemNav});
            this.fluentFormDefaultManager1.MaxItemId = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 467);
            this.ControlContainer = this.fluentDesignFormContainer;
            this.Controls.Add(this.fluentDesignFormContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "frmMain";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fluent Design Form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementNewInvoice;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementCategories;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementCustomer;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementCategory;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementProduct;
        private DevExpress.XtraBars.BarStaticItem itemNav;
    }
}