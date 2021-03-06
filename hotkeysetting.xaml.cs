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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Clipbrd_Plus
{
    /// <summary>
    /// hotkeysetting.xaml 的交互逻辑
    /// </summary>
    public partial class Hotkeysetting : UserControl
    {
        public Hotkeysetting()
        {
            InitializeComponent();
            ReadHotKeyConfig();
        }


        private void ReadHotKeyConfig()
        {
            string myhotkey;
            //显示设置页面
            myhotkey = Properties.Settings.Default.HKShowSet;
            if (myhotkey != null)
            {
                int index = myhotkey.IndexOf("|");
                if (index > -1)
                {
                    TbShowSet.Text = myhotkey.Substring(0, index);
                }
            }
            else
            {
                TbShowSet.Text = null;
            }

            //显示历史记录页面
            myhotkey = Properties.Settings.Default.HKShowHistory;
            if (myhotkey != null )
            {
                int index = myhotkey.IndexOf("|");
                if (index > -1)
                {
                    TbShowHistory.Text = myhotkey.Substring(0, index);
                }
                // TbShowHistory.Text = null;
            }
            else
            {
                TbShowHistory.Text = null;
            }

            //显示上一条
            myhotkey = Properties.Settings.Default.HKLastOne;
            if (myhotkey != null)
            {
                int index = myhotkey.IndexOf("|");
                if (index > -1)
                {
                    TbLastRec.Text = myhotkey.Substring(0, index);
                }
            }
            else
            {
                TbLastRec.Text = null;
            }

            //显示上一条并粘贴
            myhotkey = Properties.Settings.Default.HKLastOnePaste;
            if (myhotkey != null)
            {
                int index = myhotkey.IndexOf("|");
                if (index > -1)
                {
                    TbLastOnePaste.Text = myhotkey.Substring(0, index);
                }
            }
            else
            {
                TbLastOnePaste.Text = null;
            }

            //显示下一条
            myhotkey = Properties.Settings.Default.HKNextOne;
            if (myhotkey != null)
            {
                int index = myhotkey.IndexOf("|");
                if (index > -1)
                {
                    TbNextOne.Text = myhotkey.Substring(0, index);
                }
            }
            else
            {
                TbNextOne.Text = null;
            }

            //显示下一条并粘贴
            myhotkey = Properties.Settings.Default.HKNextOnePaste;
            if (myhotkey != null)
            {
                int index = myhotkey.IndexOf("|");
                if (index > -1)
                {
                    TbNextOnePaste.Text = myhotkey.Substring(0, index);
                }
            }
            else
            {
                TbNextOnePaste.Text = null;
            }

            //贴图到窗口
            myhotkey = Properties.Settings.Default.HKPasteToWindow;
            if (myhotkey != null)
            {
                int index = myhotkey.IndexOf("|");
                if (index > -1)
                {
                    TbPateToWindow.Text = myhotkey.Substring(0, index);
                }
            }
            else
            {
                TbPateToWindow.Text = null;
            }

            //隐藏显示窗口贴图
            myhotkey = Properties.Settings.Default.HKShowHide;
            if (myhotkey != null)
            {
                int index = myhotkey.IndexOf("|");
                if (index > -1)
                {
                    TbShowHide.Text = myhotkey.Substring(0, index);
                }
            }
            else
            {
                TbShowHide.Text = null;
            }
        }

        //显示设置页面
        private void TbShowSet_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            string myHotKey = PublicFunction.ShowHotKey(e);
            if (myHotKey != null)
            {

                //设置新快捷键
                TbShowSet.Text = myHotKey;
                Properties.Settings.Default.HKShowSet = myHotKey + "|" + MyVariable.Variable.HotKeyCode ;
                Properties.Settings.Default.Save();
                PublicFunction.RegHotKey(Properties.Settings.Default.HKShowSet,"CBP_ShowSet");
            }
        }

        //显示历史记录页面
        private void TbShowHistory_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            string myHotKey = PublicFunction.ShowHotKey(e);
            if (myHotKey != null)
            {
        
                //设置新快捷键
                TbShowHistory.Text = myHotKey;
                Properties.Settings.Default.HKShowHistory = myHotKey + "|" + MyVariable.Variable.HotKeyCode ;
                Properties.Settings.Default.Save();
                PublicFunction.RegHotKey(Properties.Settings.Default.HKShowHistory, "CBP_ShowHistory");
            }
        }

        //切换到上一条
        private void TbLastRec_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            string myHotKey = PublicFunction.ShowHotKey(e);
            if (myHotKey != null)
            {


                //设置新快捷键
                TbLastRec.Text = myHotKey;
                Properties.Settings.Default.HKLastOne = myHotKey + "|" + MyVariable.Variable.HotKeyCode ;
                Properties.Settings.Default.Save();
                PublicFunction.RegHotKey(Properties.Settings.Default.HKLastOne, "CBP_ShowLastOne");

            }
        }

        //切换到上一条并粘贴
        private void TbLastOnePaste_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            string myHotKey = PublicFunction.ShowHotKey(e);
            if (myHotKey != null)
            {


                //设置新快捷键
                TbLastOnePaste.Text = myHotKey;
                Properties.Settings.Default.HKLastOnePaste = myHotKey + "|" + MyVariable.Variable.HotKeyCode;
                Properties.Settings.Default.Save();
                PublicFunction.RegHotKey(Properties.Settings.Default.HKLastOnePaste, "CBP_ShowLastOnePaste");
            }
        }

        //切换到下一条
        private void TbNextOne_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            string myHotKey = PublicFunction.ShowHotKey(e);
            if (myHotKey != null)
            {            

                //设置新快捷键
                TbNextOne.Text = myHotKey;
                Properties.Settings.Default.HKNextOne = myHotKey + "|" + MyVariable.Variable.HotKeyCode ;
                Properties.Settings.Default.Save();
                PublicFunction.RegHotKey(Properties.Settings.Default.HKNextOne, "CBP_ShowNextOne");
            }
        }

        //切换到下一条并粘贴
        private void TbNextOnePaste_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            string myHotKey = PublicFunction.ShowHotKey(e);
            if (myHotKey != null)
            {             

                //设置新快捷键
                TbNextOnePaste.Text = myHotKey;
                Properties.Settings.Default.HKNextOnePaste = myHotKey + "|" + MyVariable.Variable.HotKeyCode;
                Properties.Settings.Default.Save();
                PublicFunction.RegHotKey(Properties.Settings.Default.HKNextOnePaste, "CBP_ShowLastOnePaste");
            }
        }

        //贴图到窗口
        private void TbPateToWindow_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            string myHotKey = PublicFunction.ShowHotKey(e);
            if (myHotKey != null)
            {

                //设置新快捷键
                TbPateToWindow.Text = myHotKey;
                Properties.Settings.Default.HKPasteToWindow = myHotKey + "|" + MyVariable.Variable.HotKeyCode ;
                Properties.Settings.Default.Save();
                PublicFunction.RegHotKey(Properties.Settings.Default.HKPasteToWindow, "CBP_PasteToWindow");
            }
        }

        //显示隐藏贴图
        private void TbShowHide_OnPreviewKeyUp(object sender, KeyEventArgs e)
        {
            string myHotKey = PublicFunction.ShowHotKey(e);
            if (myHotKey != null)
            {


                //设置新快捷键
                TbShowHide.Text = myHotKey;
                Properties.Settings.Default.HKShowHide = myHotKey + "|" + MyVariable.Variable.HotKeyCode;
                Properties.Settings.Default.Save();
                PublicFunction.RegHotKey(Properties.Settings.Default.HKShowHide, "CBP_ShowHide");
            }
        }





    }

}
