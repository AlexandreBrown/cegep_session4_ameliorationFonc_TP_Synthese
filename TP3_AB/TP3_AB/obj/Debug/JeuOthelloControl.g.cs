﻿#pragma checksum "..\..\JeuOthelloControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8846471BA0B689686D5DA55EC0FC7AAE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Othello;
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


namespace Othello {
    
    
    /// <summary>
    /// JeuOthelloControl
    /// </summary>
    public partial class JeuOthelloControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\JeuOthelloControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdConteneurJeu;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\JeuOthelloControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdJeuScore;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\JeuOthelloControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblScore;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\JeuOthelloControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgCouleurHumain;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\JeuOthelloControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblHumainScore;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\JeuOthelloControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgCouleurAI;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\JeuOthelloControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblAIScore;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\JeuOthelloControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle recJeuBG;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\JeuOthelloControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdJeu;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\JeuOthelloControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdControls;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\JeuOthelloControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNouvellePartie;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\JeuOthelloControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAllerMenuPrincipal;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\JeuOthelloControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEnvoyerScore;
        
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
            System.Uri resourceLocater = new System.Uri("/Othello;component/jeuothellocontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\JeuOthelloControl.xaml"
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
            this.grdConteneurJeu = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.grdJeuScore = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.lblScore = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.imgCouleurHumain = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.lblHumainScore = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.imgCouleurAI = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.lblAIScore = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.recJeuBG = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 9:
            this.grdJeu = ((System.Windows.Controls.Grid)(target));
            return;
            case 10:
            this.grdControls = ((System.Windows.Controls.Grid)(target));
            return;
            case 11:
            this.btnNouvellePartie = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\JeuOthelloControl.xaml"
            this.btnNouvellePartie.Click += new System.Windows.RoutedEventHandler(this.btnNouvellePartie_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnAllerMenuPrincipal = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\JeuOthelloControl.xaml"
            this.btnAllerMenuPrincipal.Click += new System.Windows.RoutedEventHandler(this.btnAllerMenuPrincipal_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btnEnvoyerScore = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

