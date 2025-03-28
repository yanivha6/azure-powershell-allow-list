// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Defines an Aml Instance DataMount.</summary>
    public partial class ComputeInstanceDataMount :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInstanceDataMount,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInstanceDataMountInternal
    {

        /// <summary>Backing field for <see cref="CreatedBy" /> property.</summary>
        private string _createdBy;

        /// <summary>who this data mount created by.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string CreatedBy { get => this._createdBy; set => this._createdBy = value; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private string _error;

        /// <summary>Error of this data mount.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string Error { get => this._error; set => this._error = value; }

        /// <summary>Backing field for <see cref="MountAction" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MountAction? _mountAction;

        /// <summary>Mount Action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MountAction? MountAction { get => this._mountAction; set => this._mountAction = value; }

        /// <summary>Backing field for <see cref="MountName" /> property.</summary>
        private string _mountName;

        /// <summary>name of the ComputeInstance data mount.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string MountName { get => this._mountName; set => this._mountName = value; }

        /// <summary>Backing field for <see cref="MountPath" /> property.</summary>
        private string _mountPath;

        /// <summary>Path of this data mount.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string MountPath { get => this._mountPath; set => this._mountPath = value; }

        /// <summary>Backing field for <see cref="MountState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MountState? _mountState;

        /// <summary>Mount state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MountState? MountState { get => this._mountState; set => this._mountState = value; }

        /// <summary>Backing field for <see cref="MountedOn" /> property.</summary>
        private global::System.DateTime? _mountedOn;

        /// <summary>The time when the disk mounted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public global::System.DateTime? MountedOn { get => this._mountedOn; set => this._mountedOn = value; }

        /// <summary>Backing field for <see cref="Source" /> property.</summary>
        private string _source;

        /// <summary>Source of the ComputeInstance data mount.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string Source { get => this._source; set => this._source = value; }

        /// <summary>Backing field for <see cref="SourceType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SourceType? _sourceType;

        /// <summary>Data source type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SourceType? SourceType { get => this._sourceType; set => this._sourceType = value; }

        /// <summary>Creates an new <see cref="ComputeInstanceDataMount" /> instance.</summary>
        public ComputeInstanceDataMount()
        {

        }
    }
    /// Defines an Aml Instance DataMount.
    public partial interface IComputeInstanceDataMount :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>who this data mount created by.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"who this data mount created by.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedBy { get; set; }
        /// <summary>Error of this data mount.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Error of this data mount.",
        SerializedName = @"error",
        PossibleTypes = new [] { typeof(string) })]
        string Error { get; set; }
        /// <summary>Mount Action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Mount Action.",
        SerializedName = @"mountAction",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MountAction) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MountAction? MountAction { get; set; }
        /// <summary>name of the ComputeInstance data mount.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"name of the ComputeInstance data mount.",
        SerializedName = @"mountName",
        PossibleTypes = new [] { typeof(string) })]
        string MountName { get; set; }
        /// <summary>Path of this data mount.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Path of this data mount.",
        SerializedName = @"mountPath",
        PossibleTypes = new [] { typeof(string) })]
        string MountPath { get; set; }
        /// <summary>Mount state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Mount state.",
        SerializedName = @"mountState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MountState) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MountState? MountState { get; set; }
        /// <summary>The time when the disk mounted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The time when the disk mounted.",
        SerializedName = @"mountedOn",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? MountedOn { get; set; }
        /// <summary>Source of the ComputeInstance data mount.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Source of the ComputeInstance data mount.",
        SerializedName = @"source",
        PossibleTypes = new [] { typeof(string) })]
        string Source { get; set; }
        /// <summary>Data source type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Data source type.",
        SerializedName = @"sourceType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SourceType) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SourceType? SourceType { get; set; }

    }
    /// Defines an Aml Instance DataMount.
    internal partial interface IComputeInstanceDataMountInternal

    {
        /// <summary>who this data mount created by.</summary>
        string CreatedBy { get; set; }
        /// <summary>Error of this data mount.</summary>
        string Error { get; set; }
        /// <summary>Mount Action.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MountAction? MountAction { get; set; }
        /// <summary>name of the ComputeInstance data mount.</summary>
        string MountName { get; set; }
        /// <summary>Path of this data mount.</summary>
        string MountPath { get; set; }
        /// <summary>Mount state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MountState? MountState { get; set; }
        /// <summary>The time when the disk mounted.</summary>
        global::System.DateTime? MountedOn { get; set; }
        /// <summary>Source of the ComputeInstance data mount.</summary>
        string Source { get; set; }
        /// <summary>Data source type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SourceType? SourceType { get; set; }

    }
}