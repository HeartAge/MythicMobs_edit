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

namespace MythicMobs_edit.WPF.Mob
{
    /// <summary>
    /// BABY_PIG_ZOMBIE.xaml 的交互逻辑
    /// </summary>
    public partial class BABY_PIG_ZOMBIE : UserControl
    {
        public Obj_save.Mob.Mob_type.BABY_PIG_ZOMBIE obj { get; set; } = new Obj_save.Mob.Mob_type.BABY_PIG_ZOMBIE()
        {
            ReinforcementsChance = 0,
            Angry = false
        };
        public BABY_PIG_ZOMBIE()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}