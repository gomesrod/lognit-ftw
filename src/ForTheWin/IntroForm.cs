﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ForTheWin
{
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
            headerBar.BindHandleTo(this);
        }
    }
}
