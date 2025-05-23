// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Extensions;

    /// <summary>
    /// Customer end point to store and retrieve data during a contact with the spacecraft.
    /// </summary>
    public partial class EndPoint :
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IEndPoint,
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IEndPointInternal
    {

        /// <summary>Backing field for <see cref="IPAddress" /> property.</summary>
        private string _iPAddress;

        /// <summary>IP Address (IPv4).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Owned)]
        public string IPAddress { get => this._iPAddress; set => this._iPAddress = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of an end point.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Port" /> property.</summary>
        private string _port;

        /// <summary>TCP port to listen on to receive data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Owned)]
        public string Port { get => this._port; set => this._port = value; }

        /// <summary>Backing field for <see cref="Protocol" /> property.</summary>
        private string _protocol;

        /// <summary>Protocol either UDP or TCP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Owned)]
        public string Protocol { get => this._protocol; set => this._protocol = value; }

        /// <summary>Creates an new <see cref="EndPoint" /> instance.</summary>
        public EndPoint()
        {

        }
    }
    /// Customer end point to store and retrieve data during a contact with the spacecraft.
    public partial interface IEndPoint :
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IJsonSerializable
    {
        /// <summary>IP Address (IPv4).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"IP Address (IPv4).",
        SerializedName = @"ipAddress",
        PossibleTypes = new [] { typeof(string) })]
        string IPAddress { get; set; }
        /// <summary>Name of an end point.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of an end point.",
        SerializedName = @"endPointName",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>TCP port to listen on to receive data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"TCP port to listen on to receive data.",
        SerializedName = @"port",
        PossibleTypes = new [] { typeof(string) })]
        string Port { get; set; }
        /// <summary>Protocol either UDP or TCP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Protocol either UDP or TCP.",
        SerializedName = @"protocol",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Orbital.PSArgumentCompleterAttribute("TCP", "UDP")]
        string Protocol { get; set; }

    }
    /// Customer end point to store and retrieve data during a contact with the spacecraft.
    internal partial interface IEndPointInternal

    {
        /// <summary>IP Address (IPv4).</summary>
        string IPAddress { get; set; }
        /// <summary>Name of an end point.</summary>
        string Name { get; set; }
        /// <summary>TCP port to listen on to receive data.</summary>
        string Port { get; set; }
        /// <summary>Protocol either UDP or TCP.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Orbital.PSArgumentCompleterAttribute("TCP", "UDP")]
        string Protocol { get; set; }

    }
}