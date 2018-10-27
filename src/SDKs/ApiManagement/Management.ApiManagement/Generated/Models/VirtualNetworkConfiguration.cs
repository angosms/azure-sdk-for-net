// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Configuration of a virtual network to which API Management service is
    /// deployed.
    /// </summary>
    public partial class VirtualNetworkConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkConfiguration
        /// class.
        /// </summary>
        public VirtualNetworkConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkConfiguration
        /// class.
        /// </summary>
        /// <param name="vnetid">The virtual network ID. This is typically a
        /// GUID. Expect a null GUID by default.</param>
        /// <param name="subnetname">The name of the subnet.</param>
        /// <param name="subnetResourceId">The full resource ID of a subnet in
        /// a virtual network to deploy the API Management service in.</param>
        public VirtualNetworkConfiguration(string vnetid = default(string), string subnetname = default(string), string subnetResourceId = default(string))
        {
            Vnetid = vnetid;
            Subnetname = subnetname;
            SubnetResourceId = subnetResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the virtual network ID. This is typically a GUID. Expect a
        /// null GUID by default.
        /// </summary>
        [JsonProperty(PropertyName = "vnetid")]
        public string Vnetid { get; private set; }

        /// <summary>
        /// Gets the name of the subnet.
        /// </summary>
        [JsonProperty(PropertyName = "subnetname")]
        public string Subnetname { get; private set; }

        /// <summary>
        /// Gets or sets the full resource ID of a subnet in a virtual network
        /// to deploy the API Management service in.
        /// </summary>
        [JsonProperty(PropertyName = "subnetResourceId")]
        public string SubnetResourceId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SubnetResourceId != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(SubnetResourceId, "^/subscriptions/[^/]*/resourceGroups/[^/]*/providers/Microsoft.(ClassicNetwork|Network)/virtualNetworks/[^/]*/subnets/[^/]*$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "SubnetResourceId", "^/subscriptions/[^/]*/resourceGroups/[^/]*/providers/Microsoft.(ClassicNetwork|Network)/virtualNetworks/[^/]*/subnets/[^/]*$");
                }
            }
        }
    }
}