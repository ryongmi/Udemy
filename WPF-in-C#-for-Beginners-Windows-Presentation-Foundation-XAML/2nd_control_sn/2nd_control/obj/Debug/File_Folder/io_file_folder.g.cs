﻿#pragma checksum "..\..\..\File_Folder\io_file_folder.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "561F28467FE642558BA464F5E99BAC05CAEE7AAFA8B0D28C75B6C5413A070D7D"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
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
using _2nd_control.File_Folder;


namespace _2nd_control.File_Folder {
    
    
    /// <summary>
    /// io_file_folder
    /// </summary>
    public partial class io_file_folder : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\File_Folder\io_file_folder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal _2nd_control.File_Folder.io_file_folder io_file_folder_wind;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\File_Folder\io_file_folder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button file_exists;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\File_Folder\io_file_folder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox file_tbox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\File_Folder\io_file_folder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button folder_tbox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\File_Folder\io_file_folder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button file_delete_btn;
        
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
            System.Uri resourceLocater = new System.Uri("/2nd_control;component/file_folder/io_file_folder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\File_Folder\io_file_folder.xaml"
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
            this.io_file_folder_wind = ((_2nd_control.File_Folder.io_file_folder)(target));
            return;
            case 2:
            this.file_exists = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\File_Folder\io_file_folder.xaml"
            this.file_exists.Click += new System.Windows.RoutedEventHandler(this.file_exists_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.file_tbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.folder_tbox = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\File_Folder\io_file_folder.xaml"
            this.folder_tbox.Click += new System.Windows.RoutedEventHandler(this.folder_tbox_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.file_delete_btn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\File_Folder\io_file_folder.xaml"
            this.file_delete_btn.Click += new System.Windows.RoutedEventHandler(this.file_delete_btn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

