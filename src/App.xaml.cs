﻿using GalaSoft.MvvmLight.Ioc;
using Microsoft.Win32;
using Savaged.BlackNotepad.Services;
using Savaged.BlackNotepad.ViewModels;
using Savaged.BlackNotepad.Views;
using System.Windows;

namespace Savaged.BlackNotepad
{
    public partial class App : Application
    {
        private void OnApplicationStartup(object sender, StartupEventArgs e)
        {
            SimpleIoc.Default
                .Register<IFontColourLookupService, FontColourLookupService>();
            SimpleIoc.Default
                .Register<IFontFamilyLookupService, FontFamilyLookupService>();
            SimpleIoc.Default
                .Register<IFontZoomLookupService, FontZoomLookupService>();

            SimpleIoc.Default
                .Register<IViewStateService, ViewStateService>();

            SimpleIoc.Default
                .Register<IFileModelService, FileModelService>();


            SimpleIoc.Default
                .Register<IGoToDialogViewModel, GoToDialogViewModel>();
            SimpleIoc.Default
                .Register<IFindDialogViewModel, FindDialogViewModel>();
            SimpleIoc.Default
                .Register<IReplaceDialogViewModel, ReplaceDialogViewModel>();
            SimpleIoc.Default.Register<OpenFileDialog>();
            SimpleIoc.Default.Register<SaveFileDialog>();

            SimpleIoc.Default
                .Register<IDialogService, DialogService>();

            SimpleIoc.Default.Register<MainViewModel>();

            var mainView = new MainWindow
            {
                DataContext = SimpleIoc.Default
                .GetInstance<MainViewModel>()
            };
            mainView.Show();
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            BlackNotepad.Properties.Settings.Default.Save();
        }
   }
}
