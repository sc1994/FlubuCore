﻿using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context.FluentInterface.Interfaces;
using FlubuCore.Tasks.NetCore;

namespace FlubuCore.Context.FluentInterface
{
    public class ToolsFluentInterface : IToolsFluentInterface
    {
        public TaskContext Context { get; set; }

        public DotnetToolInstall Install(string nugetPackageId)
        {
            return Context.CreateTask<DotnetToolInstall>(nugetPackageId);
        }
    }
}
