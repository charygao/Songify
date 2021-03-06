﻿using MahApps.Metro;
using System;
using System.Windows;

namespace Songify_Slim
{
    internal class ThemeHandler
    {
        public static void ApplyTheme()
        {
            var theme = Settings.GetTheme();
            var color = Settings.GetColor();

            Tuple<AppTheme, Accent> appStyle = ThemeManager.DetectAppStyle(Application.Current);
            ThemeManager.ChangeAppStyle(Application.Current, ThemeManager.GetAccent(color), ThemeManager.GetAppTheme(theme));
        }
    }
}