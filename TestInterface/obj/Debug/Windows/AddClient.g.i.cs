﻿#pragma checksum "..\..\..\Windows\AddClient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "01586B5B03279A0F80E3B3DE9BFBD9624EF4B87845E34A622E982729766FB5E3"
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
    /// AddClient
    /// </summary>
    public partial class AddClient : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\..\Windows\AddClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastNameTxt;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Windows\AddClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTxt;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Windows\AddClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MiddleNameTxt;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Windows\AddClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DateOfBirthPicker;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\Windows\AddClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox GenderBox;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\Windows\AddClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PhoneTxt;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\Windows\AddClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EMailTxt;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\Windows\AddClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddClientBtn;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\Windows\AddClient.xaml"
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
            System.Uri resourceLocater = new System.Uri("/TestInterface;component/windows/addclient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\AddClient.xaml"
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
            this.LastNameTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.NameTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.MiddleNameTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.DateOfBirthPicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.GenderBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.PhoneTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.EMailTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.AddClientBtn = ((System.Windows.Controls.Button)(target));
            
            #line 131 "..\..\..\Windows\AddClient.xaml"
            this.AddClientBtn.Click += new System.Windows.RoutedEventHandler(this.AddClientBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 136 "..\..\..\Windows\AddClient.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

