﻿#pragma checksum "..\..\WpfEmailSender.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4A2546C3EB5B31DEAB216A95CB0806ABF78690F8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EmailSender;
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
using TabSwitcher;
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace EmailSender {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miClose;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tabControl;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem DistroTab;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar tbSender;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LSender;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddSender;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditSender;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteSender;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSenderSelect;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar tbSmtp;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lSmtp;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddSmtp;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditSmtp;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteSmtp;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSmtpSelect;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar tbPlanner;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lPlanner;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClock;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar tbAddresee;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lAddresee;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddAddresee;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditAddresee;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteAddresee;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgEmails;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabPlanner;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar cldScheduleDateTimes;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.TimePicker timePicker;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSchedule;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SendAtOnce;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem EditorTab;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox rtb;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\WpfEmailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem Statist;
        
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
            System.Uri resourceLocater = new System.Uri("/EmailSender;component/wpfemailsender.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WpfEmailSender.xaml"
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
            this.miClose = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 2:
            this.tabControl = ((System.Windows.Controls.TabControl)(target));
            return;
            case 3:
            this.DistroTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 4:
            this.tbSender = ((System.Windows.Controls.ToolBar)(target));
            return;
            case 5:
            this.LSender = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.btnAddSender = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.btnEditSender = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.btnDeleteSender = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.cbSenderSelect = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.tbSmtp = ((System.Windows.Controls.ToolBar)(target));
            return;
            case 11:
            this.lSmtp = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.btnAddSmtp = ((System.Windows.Controls.Button)(target));
            return;
            case 13:
            this.btnEditSmtp = ((System.Windows.Controls.Button)(target));
            return;
            case 14:
            this.btnDeleteSmtp = ((System.Windows.Controls.Button)(target));
            return;
            case 15:
            this.cbSmtpSelect = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 16:
            this.tbPlanner = ((System.Windows.Controls.ToolBar)(target));
            return;
            case 17:
            this.lPlanner = ((System.Windows.Controls.Label)(target));
            return;
            case 18:
            this.btnClock = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\WpfEmailSender.xaml"
            this.btnClock.Click += new System.Windows.RoutedEventHandler(this.BtnClock_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.tbAddresee = ((System.Windows.Controls.ToolBar)(target));
            return;
            case 20:
            this.lAddresee = ((System.Windows.Controls.Label)(target));
            return;
            case 21:
            this.btnAddAddresee = ((System.Windows.Controls.Button)(target));
            return;
            case 22:
            this.btnEditAddresee = ((System.Windows.Controls.Button)(target));
            return;
            case 23:
            this.btnDeleteAddresee = ((System.Windows.Controls.Button)(target));
            return;
            case 24:
            this.dgEmails = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 25:
            this.tabPlanner = ((System.Windows.Controls.TabItem)(target));
            return;
            case 26:
            this.cldScheduleDateTimes = ((System.Windows.Controls.Calendar)(target));
            return;
            case 27:
            this.timePicker = ((Xceed.Wpf.Toolkit.TimePicker)(target));
            return;
            case 28:
            this.btnSchedule = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\WpfEmailSender.xaml"
            this.btnSchedule.Click += new System.Windows.RoutedEventHandler(this.BtnSchedule_Click);
            
            #line default
            #line hidden
            return;
            case 29:
            this.SendAtOnce = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\WpfEmailSender.xaml"
            this.SendAtOnce.Click += new System.Windows.RoutedEventHandler(this.SendAtOnce_Click);
            
            #line default
            #line hidden
            return;
            case 30:
            this.EditorTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 31:
            this.rtb = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 32:
            this.Statist = ((System.Windows.Controls.TabItem)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

