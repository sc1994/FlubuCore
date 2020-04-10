//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Attributes;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.Plugin
{
    public partial class DockerPluginInstallTask : ExternalProcessTaskBase<int, DockerPluginInstallTask>
    {
        private string _plugin;


        public DockerPluginInstallTask(string plugin)
        {
            ExecutablePath = "docker";
            WithArguments("plugin install");
            _plugin = plugin;
        }

        protected override string Description { get; set; }

        /// <summary>
        /// Local name for plugin
        /// </summary>
        [ArgKey("--alias")]
        public DockerPluginInstallTask Alias(string alias)
        {
            WithArgumentsKeyFromAttribute(alias.ToString());
            return this;
        }

        /// <summary>
        /// Do not enable the plugin on install
        /// </summary>
        [ArgKey("--disable")]
        public DockerPluginInstallTask Disable()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Skip image verification
        /// </summary>
        [ArgKey("--disable-content-trust")]
        public DockerPluginInstallTask DisableContentTrust()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Grant all permissions necessary to run the plugin
        /// </summary>
        [ArgKey("--grant-all-permissions")]
        public DockerPluginInstallTask GrantAllPermissions()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        protected override int DoExecute(ITaskContextInternal context)
        {
            WithArguments(_plugin);

            return base.DoExecute(context);
        }
    }
}