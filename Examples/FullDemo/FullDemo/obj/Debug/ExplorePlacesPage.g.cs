﻿#pragma checksum "C:\_WP_Code\offf\NewVersion\HereLaunchers\Examples\FullDemo\FullDemo\ExplorePlacesPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4836CB1612E854B5CF1FE91C8622FDD4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FullDemo;
using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace FullDemo {
    
    
    public partial class ExplorePlacesPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal FullDemo.LatLongInput LatitudeBox;
        
        internal FullDemo.LatLongInput LongittudeBox;
        
        internal System.Windows.Controls.Button getGeoButton;
        
        internal Microsoft.Phone.Controls.AutoCompleteBox StringBox;
        
        internal System.Windows.Controls.Button LaunchButton;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Here%20Launcher%20Demo;component/ExplorePlacesPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.LatitudeBox = ((FullDemo.LatLongInput)(this.FindName("LatitudeBox")));
            this.LongittudeBox = ((FullDemo.LatLongInput)(this.FindName("LongittudeBox")));
            this.getGeoButton = ((System.Windows.Controls.Button)(this.FindName("getGeoButton")));
            this.StringBox = ((Microsoft.Phone.Controls.AutoCompleteBox)(this.FindName("StringBox")));
            this.LaunchButton = ((System.Windows.Controls.Button)(this.FindName("LaunchButton")));
        }
    }
}

