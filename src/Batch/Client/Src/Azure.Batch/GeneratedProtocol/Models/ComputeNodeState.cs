// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{

    /// <summary>
    /// Defines values for ComputeNodeState.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ComputeNodeState
    {
        [System.Runtime.Serialization.EnumMember(Value = "idle")]
        Idle,
        [System.Runtime.Serialization.EnumMember(Value = "rebooting")]
        Rebooting,
        [System.Runtime.Serialization.EnumMember(Value = "reimaging")]
        Reimaging,
        [System.Runtime.Serialization.EnumMember(Value = "running")]
        Running,
        [System.Runtime.Serialization.EnumMember(Value = "unusable")]
        Unusable,
        [System.Runtime.Serialization.EnumMember(Value = "creating")]
        Creating,
        [System.Runtime.Serialization.EnumMember(Value = "starting")]
        Starting,
        [System.Runtime.Serialization.EnumMember(Value = "waitingForStartTask")]
        WaitingForStartTask,
        [System.Runtime.Serialization.EnumMember(Value = "startTaskFailed")]
        StartTaskFailed,
        [System.Runtime.Serialization.EnumMember(Value = "unknown")]
        Unknown,
        [System.Runtime.Serialization.EnumMember(Value = "leavingPool")]
        LeavingPool,
        [System.Runtime.Serialization.EnumMember(Value = "offline")]
        Offline
    }
}
