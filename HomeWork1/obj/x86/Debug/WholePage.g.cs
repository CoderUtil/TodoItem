﻿#pragma checksum "C:\Users\code\Desktop\HomeWork1\HomeWork1\WholePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9DA3EC9304AF22F44B0E04B0BBF2AF2F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomeWork1
{
    partial class WholePage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.VisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 2:
                {
                    this.VisualStateMin1 = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 3:
                {
                    this.VisualStateMin800 = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4:
                {
                    this.MainPageFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 5:
                {
                    this.NewPageFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 6:
                {
                    this.barAddButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 41 "..\..\..\WholePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.barAddButton).Click += this.addButton;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

