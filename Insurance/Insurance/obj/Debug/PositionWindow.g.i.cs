﻿#pragma checksum "..\..\PositionWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1D0EE9A0E1A9C8E08E4FEACBDA020EB282F3C5FF4361CBCCB3F20F7FFD59FB1F"
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
    /// PositionWindow
    /// </summary>
    public partial class PositionWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\PositionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid main;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\PositionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button @return;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\PositionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label mainLabel;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\PositionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid mainGrid;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\PositionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid injuredGrid;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\PositionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\PositionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button edit;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\PositionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button remove;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\PositionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\PositionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ImageLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/Insurance;component/positionwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PositionWindow.xaml"
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
            this.main = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.@return = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\PositionWindow.xaml"
            this.@return.Click += new System.Windows.RoutedEventHandler(this.Return_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.mainLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.mainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.injuredGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.add = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\PositionWindow.xaml"
            this.add.Click += new System.Windows.RoutedEventHandler(this.Add_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.edit = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\PositionWindow.xaml"
            this.edit.Click += new System.Windows.RoutedEventHandler(this.Edit_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.remove = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\PositionWindow.xaml"
            this.remove.Click += new System.Windows.RoutedEventHandler(this.Remove_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.imageBox = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            this.ImageLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

