// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Extensions;

    /// <summary>Define the virtualNetwork.</summary>
    public partial class VirtualNetwork
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualNetwork.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualNetwork.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualNetwork FromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject json ? new VirtualNetwork(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="VirtualNetwork" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="VirtualNetwork" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._property ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode) this._property.ToJson(null,serializationMode) : null, "properties" ,container.Add );
            AddIf( null != this._extendedLocation ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode) this._extendedLocation.ToJson(null,serializationMode) : null, "extendedLocation" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._systemData ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode) this._systemData.ToJson(null,serializationMode) : null, "systemData" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode.IncludeRead)||serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode.IncludeCreate))
            {
                AddIf( null != (((object)this._location)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString(this._location.ToString()) : null, "location" ,container.Add );
            }
            AddIf( null != this._tag ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode) this._tag.ToJson(null,serializationMode) : null, "tags" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._name)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._id)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._type)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString(this._type.ToString()) : null, "type" ,container.Add );
            }
            AddIf( null != (((object)this._kind)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString(this._kind.ToString()) : null, "kind" ,container.Add );
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject into a new instance of <see cref="VirtualNetwork" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal VirtualNetwork(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_property = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject>("properties"), out var __jsonProperties) ? Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.VirtualNetworkProperties.FromJson(__jsonProperties) : _property;}
            {_extendedLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject>("extendedLocation"), out var __jsonExtendedLocation) ? Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.ExtendedLocation.FromJson(__jsonExtendedLocation) : _extendedLocation;}
            {_systemData = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject>("systemData"), out var __jsonSystemData) ? Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.SystemData.FromJson(__jsonSystemData) : _systemData;}
            {_location = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString>("location"), out var __jsonLocation) ? (string)__jsonLocation : (string)_location;}
            {_tag = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject>("tags"), out var __jsonTags) ? Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.VirtualNetworkTags.FromJson(__jsonTags) : _tag;}
            {_name = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)_name;}
            {_id = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)_id;}
            {_type = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString>("type"), out var __jsonType) ? (string)__jsonType : (string)_type;}
            {_kind = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString>("kind"), out var __jsonKind) ? (string)__jsonKind : (string)_kind;}
            AfterFromJson(json);
        }
    }
}