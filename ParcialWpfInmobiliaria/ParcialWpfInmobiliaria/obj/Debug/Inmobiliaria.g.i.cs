﻿#pragma checksum "..\..\Inmobiliaria.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "60C36A67743FFA1C273C1D0EC396FD65"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ParcialWpfInmobiliaria;
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


namespace ParcialWpfInmobiliaria {
    
    
    /// <summary>
    /// Inmobiliaria
    /// </summary>
    public partial class Inmobiliaria : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\Inmobiliaria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid inmueblesDataGrid;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Inmobiliaria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn fechaPublicacionColumn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Inmobiliaria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn iDVendedorColumn;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Inmobiliaria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn direccionColumn;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Inmobiliaria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn ambientesColumn;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Inmobiliaria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn precioColumn;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Inmobiliaria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridCheckBoxColumn reservadoColumn;
        
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
            System.Uri resourceLocater = new System.Uri("/ParcialWpfInmobiliaria;component/inmobiliaria.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Inmobiliaria.xaml"
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
            
            #line 8 "..\..\Inmobiliaria.xaml"
            ((ParcialWpfInmobiliaria.Inmobiliaria)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.inmueblesDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.fechaPublicacionColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 4:
            this.iDVendedorColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.direccionColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.ambientesColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 7:
            this.precioColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 8:
            this.reservadoColumn = ((System.Windows.Controls.DataGridCheckBoxColumn)(target));
            return;
            case 9:
            
            #line 35 "..\..\Inmobiliaria.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonClose);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

