﻿#pragma checksum "..\..\..\PageFolder\Authorization.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3E200C484B4E7A46754B5342B73CE7DE93B7D854FF893400F3D101BEE5C132D8"
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
using TestWorkProgram;


namespace TestWorkProgram {
    
    
    /// <summary>
    /// Authorization
    /// </summary>
    public partial class Authorization : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\PageFolder\Authorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginName;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\PageFolder\Authorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock emailWar;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\PageFolder\Authorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border passBorder;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\PageFolder\Authorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordfield;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\PageFolder\Authorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox passHelper;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\PageFolder\Authorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PassWar;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\PageFolder\Authorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock fieladNullWar;
        
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
            System.Uri resourceLocater = new System.Uri("/TestWorkProgram;component/pagefolder/authorization.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PageFolder\Authorization.xaml"
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
            
            #line 8 "..\..\..\PageFolder\Authorization.xaml"
            ((TestWorkProgram.Authorization)(target)).Loaded += new System.Windows.RoutedEventHandler(this.PageLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.loginName = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\..\PageFolder\Authorization.xaml"
            this.loginName.GotFocus += new System.Windows.RoutedEventHandler(this.emailNameGotFocus);
            
            #line default
            #line hidden
            
            #line 41 "..\..\..\PageFolder\Authorization.xaml"
            this.loginName.LostFocus += new System.Windows.RoutedEventHandler(this.emailNameLostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.emailWar = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.passBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 5:
            this.passwordfield = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 69 "..\..\..\PageFolder\Authorization.xaml"
            this.passwordfield.LostFocus += new System.Windows.RoutedEventHandler(this.passwordfieldLostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.passHelper = ((System.Windows.Controls.TextBox)(target));
            
            #line 77 "..\..\..\PageFolder\Authorization.xaml"
            this.passHelper.GotFocus += new System.Windows.RoutedEventHandler(this.passwordfieldGotFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PassWar = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            
            #line 87 "..\..\..\PageFolder\Authorization.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AuthorizationTapped);
            
            #line default
            #line hidden
            return;
            case 9:
            this.fieladNullWar = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

