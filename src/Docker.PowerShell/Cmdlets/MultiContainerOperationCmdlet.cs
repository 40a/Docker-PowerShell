﻿using System.Management.Automation;
using Docker.DotNet.Models;

namespace Docker.PowerShell.Cmdlets
{
    public abstract class MultiContainerOperationCmdlet : DkrCmdlet
    {
        #region Parameters

        [Parameter(ParameterSetName = CommonParameterSetNames.Default,
            ValueFromPipeline = true,
                   Position = 0,
                   Mandatory = true)]
        [ValidateNotNullOrEmpty]
        [ArgumentCompleter(typeof(ContainerArgumentCompleter))]
        [Alias("Name")]
        public string[] Id { get; set; }

        [Parameter(ParameterSetName = CommonParameterSetNames.ContainerObject,
            ValueFromPipeline = true,
                   Position = 0,
                   Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public ContainerListResponse[] Container { get; set; }

        #endregion
    }
}
