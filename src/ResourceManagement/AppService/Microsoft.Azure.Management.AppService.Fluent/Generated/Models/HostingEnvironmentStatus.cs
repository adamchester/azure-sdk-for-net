// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{

    /// <summary>
    /// Defines values for HostingEnvironmentStatus.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum HostingEnvironmentStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = "Preparing")]
        Preparing,
        [System.Runtime.Serialization.EnumMember(Value = "Ready")]
        Ready,
        [System.Runtime.Serialization.EnumMember(Value = "Scaling")]
        Scaling,
        [System.Runtime.Serialization.EnumMember(Value = "Deleting")]
        Deleting
    }
}