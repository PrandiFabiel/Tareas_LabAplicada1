﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48B10A1C49D1ED25007F25B074FCECEE09B50153"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Tarea2_RegistroEstudiantes_RolesWPF;


namespace Tarea2_RegistroEstudiantes_RolesWPF {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem EstudianteMenuItem;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem RolMenuItem;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem UsuariosMenuItem;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ConsultaEstudianteMenuItem;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Tarea2_RegistroEstudiantes_RolesWPF;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.EstudianteMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 13 "..\..\..\MainWindow.xaml"
            this.EstudianteMenuItem.Click += new System.Windows.RoutedEventHandler(this.EstudianteMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RolMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 14 "..\..\..\MainWindow.xaml"
            this.RolMenuItem.Click += new System.Windows.RoutedEventHandler(this.RolMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.UsuariosMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 15 "..\..\..\MainWindow.xaml"
            this.UsuariosMenuItem.Click += new System.Windows.RoutedEventHandler(this.UsuariosMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ConsultaEstudianteMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 19 "..\..\..\MainWindow.xaml"
            this.ConsultaEstudianteMenuItem.Click += new System.Windows.RoutedEventHandler(this.ConsultaEstudianteMenuItem_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

