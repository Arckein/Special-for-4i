﻿#pragma checksum "..\..\..\Windows\ChangeClientService.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "83ADB6AEB91F251C768B25BD8B7B9FBE589D5B5932C13EA1FA34418A8106E26E"
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
    /// ChangeClientService
    /// </summary>
    public partial class ChangeClientService : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\..\Windows\ChangeClientService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox LastNameBox;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Windows\ChangeClientService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox NameBox;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Windows\ChangeClientService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MiddleNameBox;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Windows\ChangeClientService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DateOfBirthPicker;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\Windows\ChangeClientService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TimeTxt;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\Windows\ChangeClientService.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeClientServiceBtn;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\Windows\ChangeClientService.xaml"
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
            System.Uri resourceLocater = new System.Uri("/TestInterface;component/windows/changeclientservice.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\ChangeClientService.xaml"
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
            this.LastNameBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.NameBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.MiddleNameBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.DateOfBirthPicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.TimeTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ChangeClientServiceBtn = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\..\Windows\ChangeClientService.xaml"
            this.ChangeClientServiceBtn.Click += new System.Windows.RoutedEventHandler(this.ChangeClientServiceBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 111 "..\..\..\Windows\ChangeClientService.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

