﻿#pragma checksum "..\..\..\Add\AddUserWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "807F4405D2DB15D002170B89F7DA66082DC96819A24F2564A7004ABFFA198773"
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
    /// AddUserWindow
    /// </summary>
    public partial class AddUserWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\Add\AddUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Content;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Add\AddUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock mainText;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Add\AddUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid phoneGrid;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Add\AddUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fNameBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Add\AddUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PassBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Add\AddUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox VUBox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Add\AddUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid passportGrid;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Add\AddUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PosBox;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Add\AddUserWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Insurance;component/add/adduserwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Add\AddUserWindow.xaml"
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
            this.fNameBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\Add\AddUserWindow.xaml"
            this.fNameBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FNameBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 34 "..\..\..\Add\AddUserWindow.xaml"
            this.fNameBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.FNameBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PassBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\..\Add\AddUserWindow.xaml"
            this.PassBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.PassBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 37 "..\..\..\Add\AddUserWindow.xaml"
            this.PassBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PassBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.VUBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\..\Add\AddUserWindow.xaml"
            this.VUBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.VUBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 40 "..\..\..\Add\AddUserWindow.xaml"
            this.VUBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.VUBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 7:
            this.passportGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.PosBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 56 "..\..\..\Add\AddUserWindow.xaml"
            this.PosBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PosBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.saveButton = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\Add\AddUserWindow.xaml"
            this.saveButton.Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
