// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for PrivateEndpointStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PrivateEndpointStatus
    {
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "Approved")]
        Approved,
        [EnumMember(Value = "Rejected")]
        Rejected,
        [EnumMember(Value = "Disconnected")]
        Disconnected,
        [EnumMember(Value = "Timeout")]
        Timeout
    }
    internal static class PrivateEndpointStatusEnumExtension
    {
        internal static string ToSerializedValue(this PrivateEndpointStatus? value)
        {
            return value == null ? null : ((PrivateEndpointStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this PrivateEndpointStatus value)
        {
            switch( value )
            {
                case PrivateEndpointStatus.Pending:
                    return "Pending";
                case PrivateEndpointStatus.Approved:
                    return "Approved";
                case PrivateEndpointStatus.Rejected:
                    return "Rejected";
                case PrivateEndpointStatus.Disconnected:
                    return "Disconnected";
                case PrivateEndpointStatus.Timeout:
                    return "Timeout";
            }
            return null;
        }

        internal static PrivateEndpointStatus? ParsePrivateEndpointStatus(this string value)
        {
            switch( value )
            {
                case "Pending":
                    return PrivateEndpointStatus.Pending;
                case "Approved":
                    return PrivateEndpointStatus.Approved;
                case "Rejected":
                    return PrivateEndpointStatus.Rejected;
                case "Disconnected":
                    return PrivateEndpointStatus.Disconnected;
                case "Timeout":
                    return PrivateEndpointStatus.Timeout;
            }
            return null;
        }
    }
}