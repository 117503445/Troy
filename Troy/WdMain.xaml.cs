﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Troy
{
    /// <summary>
    /// WdMain.xaml 的交互逻辑
    /// </summary>
    public partial class WdMain : Window
    {
        public WdMain()
        {
            InitializeComponent();
            App.WdMain = this;
#if Evil && !DEBUG
            Hide();
#endif
        }
    }
}
