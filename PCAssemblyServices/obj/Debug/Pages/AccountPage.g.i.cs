﻿#pragma checksum "..\..\..\Pages\AccountPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "13060C8D234FA7117232572EB4B95F8B3BA2B95958563D30C6D27E5B103CE9C7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PCAssemblyServices.Pages;
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


namespace PCAssemblyServices.Pages {
    
    
    /// <summary>
    /// AccountPage
    /// </summary>
    public partial class AccountPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Pages\AccountPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Pages\AccountPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button assemblies;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Pages\AccountPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button shoppingcart;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Pages\AccountPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button catalog;
        
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
            System.Uri resourceLocater = new System.Uri("/PCAssemblyServices;component/pages/accountpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AccountPage.xaml"
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
            this.exit = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Pages\AccountPage.xaml"
            this.exit.Click += new System.Windows.RoutedEventHandler(this.exit_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.assemblies = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\Pages\AccountPage.xaml"
            this.assemblies.Click += new System.Windows.RoutedEventHandler(this.assemblies_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.shoppingcart = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\Pages\AccountPage.xaml"
            this.shoppingcart.Click += new System.Windows.RoutedEventHandler(this.shoppingcart_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.catalog = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\Pages\AccountPage.xaml"
            this.catalog.Click += new System.Windows.RoutedEventHandler(this.catalog_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

