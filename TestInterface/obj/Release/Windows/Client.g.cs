﻿#pragma checksum "..\..\..\Windows\Client.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C7B6DA17613B5B9CAF6210DF9E50C84C550D589A6669214A193966951C3BFBF2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using TestInterface.Windows;


namespace TestInterface.Windows {
    
    
    /// <summary>
    /// Client
    /// </summary>
    public partial class Client : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\Windows\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ClientTableDtGrd;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Windows\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddClientBtn;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Windows\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeClientBtn;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Windows\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveClientBtn;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Windows\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/TestInterface;component/windows/client.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\Client.xaml"
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
            this.ClientTableDtGrd = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.AddClientBtn = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\Windows\Client.xaml"
            this.AddClientBtn.Click += new System.Windows.RoutedEventHandler(this.AddClientBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ChangeClientBtn = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\Windows\Client.xaml"
            this.ChangeClientBtn.Click += new System.Windows.RoutedEventHandler(this.ChangeClientBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RemoveClientBtn = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\Windows\Client.xaml"
            this.RemoveClientBtn.Click += new System.Windows.RoutedEventHandler(this.RemoveClientBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\Windows\Client.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

