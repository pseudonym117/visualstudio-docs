//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17348
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 414
namespace Trin_VstcoreDataExcelCS {
    
    
    /// 
    [Microsoft.VisualStudio.Tools.Applications.Runtime.StartupObjectAttribute(1)]
    [global::System.Security.Permissions.PermissionSetAttribute(global::System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    public sealed partial class Sheet1 : Microsoft.Office.Tools.Excel.WorksheetBase {
        
        internal Microsoft.Office.Tools.Excel.NamedRange namedRange1;
        
        internal Microsoft.Office.Tools.Excel.NamedRange customerIDNamedRange;
        
        internal Microsoft.Office.Tools.Excel.NamedRange companyNameNamedRange;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        private global::System.Object missing = global::System.Type.Missing;
        
        internal Microsoft.Office.Tools.Excel.Controls.Button button1;
        
        internal Microsoft.Office.Tools.Excel.Controls.Button button2;
        
        internal Microsoft.Office.Tools.Excel.Controls.Button button3;
        
        internal Microsoft.Office.Tools.Excel.Controls.Button button4;
        
        internal Trin_VstcoreDataExcelCS.NorthwindDataSet northwindDataSet;
        
        internal Trin_VstcoreDataExcelCS.NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        
        internal System.Windows.Forms.BindingSource customersBindingSource;
        
        private System.ComponentModel.IContainer components;
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Sheet1(global::Microsoft.Office.Tools.Excel.Factory factory, global::System.IServiceProvider serviceProvider) : 
                base(factory, serviceProvider, "Sheet1", "Sheet1") {
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void Initialize() {
            base.Initialize();
            Globals.Sheet1 = this;
            global::System.Windows.Forms.Application.EnableVisualStyles();
            this.InitializeCachedData();
            this.InitializeControls();
            this.InitializeComponents();
            this.InitializeData();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void FinishInitialization() {
            this.InternalStartup();
            this.OnStartup();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void InitializeDataBindings() {
            this.BeginInitialization();
            this.BindToData();
            this.EndInitialization();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeCachedData() {
            if ((this.DataHost == null)) {
                return;
            }
            if (this.DataHost.IsCacheInitialized) {
                this.DataHost.FillCachedData(this);
            }
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeData() {
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void BindToData() {
            this.customerIDNamedRange.DataBindings.Add("Value2", this.customersBindingSource, "CustomerID", true, this.customerIDNamedRange.DataBindings.DefaultDataSourceUpdateMode);
            this.companyNameNamedRange.DataBindings.Add("Value2", this.customersBindingSource, "CompanyName", true, this.companyNameNamedRange.DataBindings.DefaultDataSourceUpdateMode);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private void StartCaching(string MemberName) {
            this.DataHost.StartCaching(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private void StopCaching(string MemberName) {
            this.DataHost.StopCaching(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private bool IsCached(string MemberName) {
            return this.DataHost.IsCached(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void BeginInitialization() {
            this.BeginInit();
            this.namedRange1.BeginInit();
            this.customerIDNamedRange.BeginInit();
            this.companyNameNamedRange.BeginInit();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void EndInitialization() {
            this.companyNameNamedRange.EndInit();
            this.customerIDNamedRange.EndInit();
            this.namedRange1.EndInit();
            this.EndInit();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeControls() {
            this.namedRange1 = Globals.Factory.CreateNamedRange(null, null, "namedRange1", "namedRange1", this);
            this.customerIDNamedRange = Globals.Factory.CreateNamedRange(null, null, "customerIDNamedRange", "customerIDNamedRange", this);
            this.companyNameNamedRange = Globals.Factory.CreateNamedRange(null, null, "companyNameNamedRange", "companyNameNamedRange", this);
            this.button1 = new Microsoft.Office.Tools.Excel.Controls.Button(Globals.Factory, this.ItemProvider, this.HostContext, "24116FA9721AAE244EB2B5B9268E295EE15482", "24116FA9721AAE244EB2B5B9268E295EE15482", this, "button1");
            this.button2 = new Microsoft.Office.Tools.Excel.Controls.Button(Globals.Factory, this.ItemProvider, this.HostContext, "3E7986E46327E33452B393A3391AA135764D13", "3E7986E46327E33452B393A3391AA135764D13", this, "button2");
            this.button3 = new Microsoft.Office.Tools.Excel.Controls.Button(Globals.Factory, this.ItemProvider, this.HostContext, "46426C4FF411BB4476A4A3584B6D039E4EF1D4", "46426C4FF411BB4476A4A3584B6D039E4EF1D4", this, "button3");
            this.button4 = new Microsoft.Office.Tools.Excel.Controls.Button(Globals.Factory, this.ItemProvider, this.HostContext, "541745D2E538D5545E9591BB54F830A809D195", "541745D2E538D5545E9591BB54F830A809D195", this, "button4");
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeComponents() {
            this.components = new System.ComponentModel.Container();
            if ((this.northwindDataSet == null)) {
                // Instantiate the object if not yet loaded from the data cache.
                this.northwindDataSet = new Trin_VstcoreDataExcelCS.NorthwindDataSet();
            }
            this.customersTableAdapter = new Trin_VstcoreDataExcelCS.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.namedRange1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerIDNamedRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyNameNamedRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // button1
            // 
            this.button1.Name = "button1";
            this.button1.Text = "button1";
            // 
            // button2
            // 
            this.button2.Name = "button2";
            this.button2.Text = "button2";
            // 
            // button3
            // 
            this.button3.Name = "button3";
            this.button3.Text = "button3";
            // 
            // button4
            // 
            this.button4.Name = "button4";
            this.button4.Text = "button4";
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.northwindDataSet;
            // 
            // Sheet1
            // 
            ((System.ComponentModel.ISupportInitialize)(this.namedRange1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerIDNamedRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyNameNamedRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.button1.BindingContext = this.BindingContext;
            this.button2.BindingContext = this.BindingContext;
            this.button3.BindingContext = this.BindingContext;
            this.button4.BindingContext = this.BindingContext;
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private bool NeedsFill(string MemberName) {
            return this.DataHost.NeedsFill(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void OnShutdown() {
            this.companyNameNamedRange.Dispose();
            this.customerIDNamedRange.Dispose();
            this.namedRange1.Dispose();
            base.OnShutdown();
        }
    }
    
    internal sealed partial class Globals {
        
        private static Sheet1 _Sheet1;
        
        internal static Sheet1 Sheet1 {
            get {
                return _Sheet1;
            }
            set {
                if ((_Sheet1 == null)) {
                    _Sheet1 = value;
                }
                else {
                    throw new System.NotSupportedException();
                }
            }
        }
    }
}