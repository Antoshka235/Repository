﻿#pragma checksum "..\..\WindowClient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3C1A26E65840770E54600A7970B14A3B424DD9E0562F6C40A915C699595076BB"
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
using Travel_Agency;


namespace Travel_Agency {
    
    
    /// <summary>
    /// WindowClient
    /// </summary>
    public partial class WindowClient : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\WindowClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MainFrame;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\WindowClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBack1;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\WindowClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btnlose7;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\WindowClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnScr7;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\WindowClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnWin;
        
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
            System.Uri resourceLocater = new System.Uri("/Travel Agency;component/windowclient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowClient.xaml"
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
            
            #line 8 "..\..\WindowClient.xaml"
            ((Travel_Agency.WindowClient)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MainFrame = ((System.Windows.Controls.Frame)(target));
            
            #line 25 "..\..\WindowClient.xaml"
            this.MainFrame.ContentRendered += new System.EventHandler(this.MainFrame_ContentRendered);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnBack1 = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\WindowClient.xaml"
            this.BtnBack1.Click += new System.Windows.RoutedEventHandler(this.BtnBack1_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Btnlose7 = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\WindowClient.xaml"
            this.Btnlose7.Click += new System.Windows.RoutedEventHandler(this.Btnlose7_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnScr7 = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\WindowClient.xaml"
            this.BtnScr7.Click += new System.Windows.RoutedEventHandler(this.BtnScr7_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnWin = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\WindowClient.xaml"
            this.BtnWin.Click += new System.Windows.RoutedEventHandler(this.BtnWin_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
