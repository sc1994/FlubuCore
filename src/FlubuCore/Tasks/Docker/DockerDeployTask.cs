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

namespace FlubuCore.Tasks.Docker
{
    public partial class DockerDeployTask : ExternalProcessTaskBase<int, DockerDeployTask>
    {
        private string _stack;


        public DockerDeployTask(string stack)
        {
            ExecutablePath = "docker";
            WithArguments("deploy");
            _stack = stack;
        }

        protected override string Description { get; set; }

        /// <summary>
        /// Path to a Distributed Application Bundle file
        /// </summary>
        [ArgKey("--bundle-file")]
        public DockerDeployTask BundleFile(string bundleFile)
        {
            WithArgumentsKeyFromAttribute(bundleFile.ToString());
            return this;
        }

        /// <summary>
        /// Path to a Compose file, or "-" to read from stdin
        /// </summary>
        [ArgKey("--compose-file")]
        public DockerDeployTask ComposeFile(string composeFile)
        {
            WithArgumentsKeyFromAttribute(composeFile.ToString());
            return this;
        }

        /// <summary>
        /// Kubernetes namespace to use
        /// </summary>
        [ArgKey("--namespace")]
        public DockerDeployTask Namespace(string @namespace)
        {
            WithArgumentsKeyFromAttribute(@namespace.ToString());
            return this;
        }

        /// <summary>
        /// Prune services that are no longer referenced
        /// </summary>
        [ArgKey("--prune")]
        public DockerDeployTask Prune()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Query the registry to resolve image digest and supported platforms ("always"|"changed"|"never")
        /// </summary>
        [ArgKey("--resolve-image")]
        public DockerDeployTask ResolveImage(string resolveImage)
        {
            WithArgumentsKeyFromAttribute(resolveImage.ToString());
            return this;
        }

        /// <summary>
        /// Send registry authentication details to Swarm agents
        /// </summary>
        [ArgKey("--with-registry-auth")]
        public DockerDeployTask WithRegistryAuth()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        protected override int DoExecute(ITaskContextInternal context)
        {
            WithArguments(_stack);

            return base.DoExecute(context);
        }
    }
}