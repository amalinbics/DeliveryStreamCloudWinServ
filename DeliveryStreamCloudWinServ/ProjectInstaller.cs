﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;

namespace DeliveryStreamCloudWinServ
{
    /// <summary>
    /// Partial ProjectInstaller class
    /// </summary>
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ProjectInstaller()
        {
            InitializeComponent();
        }
    }
}
