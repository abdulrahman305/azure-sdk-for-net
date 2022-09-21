// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ServiceFabricManagedClusters;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    internal partial class NodeTypeListResult
    {
        internal static NodeTypeListResult DeserializeNodeTypeListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ServiceFabricManagedNodeTypeData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ServiceFabricManagedNodeTypeData> array = new List<ServiceFabricManagedNodeTypeData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceFabricManagedNodeTypeData.DeserializeServiceFabricManagedNodeTypeData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new NodeTypeListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
