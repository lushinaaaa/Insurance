﻿#pragma checksum "..\..\..\Add\AddUser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "37C5239795B41CC77B4C143443E42FDB6B23D5FD02C786EACB881ADF774919FB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Insurance.Edit;
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


namespace Insurance.Edit {
    
    
    /// <summary>
    /// AddUser
    /// </summary>
    public partial class AddUser : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\Add\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Content;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Add\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock mainText;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Add\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid phoneGrid;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Add\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox empl;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Add\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox role;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Add\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid passportGrid;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Add\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox login;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Add\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox password;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Add\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Insurance;component/add/adduser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Add\AddUser.xaml"
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
            this.Content = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.mainText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.phoneGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.empl = ((System.Windows.Controls.ComboBox)(target));
            
            #line 35 "..\..\..\Add\AddUser.xaml"
            this.empl.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Empl_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.role = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\..\Add\AddUser.xaml"
            this.role.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Role_TextChanged);
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\Add\AddUser.xaml"
            this.role.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Role_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.passportGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.login = ((System.Windows.Controls.TextBox)(target));
            
            #line 54 "..\..\..\Add\AddUser.xaml"
            this.login.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Login_TextChanged);
            
            #line default
            #line hidden
            
            #line 54 "..\..\..\Add\AddUser.xaml"
            this.login.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Login_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 8:
            this.password = ((System.Windows.Controls.TextBox)(target));
            
            #line 57 "..\..\..\Add\AddUser.xaml"
            this.password.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Password_TextChanged);
            
            #line default
            #line hidden
            
            #line 57 "..\..\..\Add\AddUser.xaml"
            this.password.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Password_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 9:
            this.saveButton = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\Add\AddUser.xaml"
            this.saveButton.Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

