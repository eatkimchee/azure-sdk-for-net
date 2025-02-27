// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Spark.Models
{
    public partial class SparkSessionOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (ArtifactId != null)
            {
                writer.WritePropertyName("artifactId"u8);
                writer.WriteStringValue(ArtifactId);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (File != null)
            {
                writer.WritePropertyName("file"u8);
                writer.WriteStringValue(File);
            }
            if (ClassName != null)
            {
                writer.WritePropertyName("className"u8);
                writer.WriteStringValue(ClassName);
            }
            if (!(Arguments is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("args"u8);
                writer.WriteStartArray();
                foreach (var item in Arguments)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Jars is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("jars"u8);
                writer.WriteStartArray();
                foreach (var item in Jars)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(PythonFiles is ChangeTrackingList<string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("pyFiles"u8);
                writer.WriteStartArray();
                foreach (var item in PythonFiles)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Files is ChangeTrackingList<string> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("files"u8);
                writer.WriteStartArray();
                foreach (var item in Files)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Archives is ChangeTrackingList<string> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("archives"u8);
                writer.WriteStartArray();
                foreach (var item in Archives)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Configuration is ChangeTrackingDictionary<string, string> collection5 && collection5.IsUndefined))
            {
                writer.WritePropertyName("conf"u8);
                writer.WriteStartObject();
                foreach (var item in Configuration)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (DriverMemory != null)
            {
                writer.WritePropertyName("driverMemory"u8);
                writer.WriteStringValue(DriverMemory);
            }
            if (DriverCores.HasValue)
            {
                writer.WritePropertyName("driverCores"u8);
                writer.WriteNumberValue(DriverCores.Value);
            }
            if (ExecutorMemory != null)
            {
                writer.WritePropertyName("executorMemory"u8);
                writer.WriteStringValue(ExecutorMemory);
            }
            if (ExecutorCores.HasValue)
            {
                writer.WritePropertyName("executorCores"u8);
                writer.WriteNumberValue(ExecutorCores.Value);
            }
            if (ExecutorCount.HasValue)
            {
                writer.WritePropertyName("numExecutors"u8);
                writer.WriteNumberValue(ExecutorCount.Value);
            }
            writer.WriteEndObject();
        }
    }
}
