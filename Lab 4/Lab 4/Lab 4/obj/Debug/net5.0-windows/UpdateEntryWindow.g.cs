﻿#pragma checksum "..\..\..\UpdateEntryWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94148B16E20200328049055884F7095210342C6D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Lab_4;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Lab_4 {
    
    
    /// <summary>
    /// UpdateEntryWindow
    /// </summary>
    public partial class UpdateEntryWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\UpdateEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label UpdateEntryLabel;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\UpdateEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ClueLabel;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\UpdateEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label AnswerLabel;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\UpdateEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label DifficultyLabel;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\UpdateEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label DateLabel;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\UpdateEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateEntryButton;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\UpdateEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ClueTextBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\UpdateEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AnswerTextBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\UpdateEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DifficultyTextBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\UpdateEntryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DateTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Lab 4;component/updateentrywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UpdateEntryWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.UpdateEntryLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.ClueLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.AnswerLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.DifficultyLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.DateLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.UpdateEntryButton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\UpdateEntryWindow.xaml"
            this.UpdateEntryButton.Click += new System.Windows.RoutedEventHandler(this.UpdateEntryButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ClueTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.AnswerTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.DifficultyTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.DateTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

