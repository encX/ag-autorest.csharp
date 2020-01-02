// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.RequiredOptional.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class IntWrapper
    {
        /// <summary>
        /// Initializes a new instance of the IntWrapper class.
        /// </summary>
        public IntWrapper()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IntWrapper class.
        /// </summary>
        public IntWrapper(int value)
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public int Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}