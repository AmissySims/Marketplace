﻿#pragma checksum "..\..\..\Pages\ProductPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4B007E75F51FFF22B6F908021A73AE0767A45D26D2B152D5498F9DB501972C64"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Marketplace.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Marketplace.Pages {
    
    
    /// <summary>
    /// ProductPage
    /// </summary>
    public partial class ProductPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FoundTb;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FilterCb;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SortCb;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ProviderCb;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBt;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditBt;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ProductGD;
        
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
            System.Uri resourceLocater = new System.Uri("/Marketplace;component/pages/productpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ProductPage.xaml"
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
            
            #line 8 "..\..\..\Pages\ProductPage.xaml"
            ((Marketplace.Pages.ProductPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FoundTb = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\Pages\ProductPage.xaml"
            this.FoundTb.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FoundTb_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FilterCb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\..\Pages\ProductPage.xaml"
            this.FilterCb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FilterCb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SortCb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\..\Pages\ProductPage.xaml"
            this.SortCb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SortCb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ProviderCb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 37 "..\..\..\Pages\ProductPage.xaml"
            this.ProviderCb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProviderCb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AddBt = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\Pages\ProductPage.xaml"
            this.AddBt.Click += new System.Windows.RoutedEventHandler(this.AddBt_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.EditBt = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\Pages\ProductPage.xaml"
            this.EditBt.Click += new System.Windows.RoutedEventHandler(this.EditBt_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ProductGD = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

