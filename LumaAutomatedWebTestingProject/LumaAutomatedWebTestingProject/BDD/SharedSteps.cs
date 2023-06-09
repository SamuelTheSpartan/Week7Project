﻿using LumaAutomatedWebTestingProject.lib.pages;
using LumaAutomatedWebTestingProject.Utils;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace LumaAutomatedWebTestingProject.BDD
{
    /// <summary>
    /// This might not be needed but include anything shared by ALL tests
    /// </summary>
    public class SharedSteps
    {
        protected SL_Website<ChromeDriver> SL_Website { get; } = new();

        protected Credentials? _credentials;

    }
}
