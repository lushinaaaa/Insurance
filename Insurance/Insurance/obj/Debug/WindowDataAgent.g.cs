#pragma checksum "..\..\WindowDataAgent.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "42F847E380E2E55E22D98A0E6B57088C0B1E32C953C24D25627558A56E46DC51"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Insurance;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Insurance {
    
    
    /// <summary>
    /// WindowDataAgent
    /// </summary>
    public partial class WindowDataAgent : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\WindowDataAgent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\WindowDataAgent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button positions;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\WindowDataAgent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button employees;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\WindowDataAgent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clients;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\WindowDataAgent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button users;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\WindowDataAgent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Insur;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\WindowDataAgent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddCl;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\WindowDataAgent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label mainLabel;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\WindowDataAgent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid mainGrid1;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\WindowDataAgent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Insur_cal;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\WindowDataAgent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Insurance;component/windowdataagent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowDataAgent.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.imageBox = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.positions = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\WindowDataAgent.xaml"
            this.positions.Click += new System.Windows.RoutedEventHandler(this.Positions_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.employees = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\WindowDataAgent.xaml"
            this.employees.Click += new System.Windows.RoutedEventHandler(this.Employees_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.clients = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\WindowDataAgent.xaml"
            this.clients.Click += new System.Windows.RoutedEventHandler(this.Clients_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.users = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\WindowDataAgent.xaml"
            this.users.Click += new System.Windows.RoutedEventHandler(this.Users_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Insur = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\WindowDataAgent.xaml"
            this.Insur.Click += new System.Windows.RoutedEventHandler(this.Insur_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AddCl = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\WindowDataAgent.xaml"
            this.AddCl.Click += new System.Windows.RoutedEventHandler(this.AddCl_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.mainLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.mainGrid1 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.Insur_cal = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\WindowDataAgent.xaml"
            this.Insur_cal.Click += new System.Windows.RoutedEventHandler(this.Insur_cal_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.exit = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\WindowDataAgent.xaml"
            this.exit.Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

