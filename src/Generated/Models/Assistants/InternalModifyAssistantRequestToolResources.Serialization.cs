// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Assistants
{
    internal partial class InternalModifyAssistantRequestToolResources : IJsonModel<InternalModifyAssistantRequestToolResources>
    {
        void IJsonModel<InternalModifyAssistantRequestToolResources>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalModifyAssistantRequestToolResources>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalModifyAssistantRequestToolResources)} does not support writing '{format}' format.");
            }
            if (Optional.IsDefined(CodeInterpreter) && _additionalBinaryDataProperties?.ContainsKey("code_interpreter") != true)
            {
                writer.WritePropertyName("code_interpreter"u8);
                writer.WriteObjectValue(CodeInterpreter, options);
            }
            if (Optional.IsDefined(FileSearch) && _additionalBinaryDataProperties?.ContainsKey("file_search") != true)
            {
                writer.WritePropertyName("file_search"u8);
                writer.WriteObjectValue(FileSearch, options);
            }
            // Plugin customization: remove options.Format != "W" check
            if (_additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        InternalModifyAssistantRequestToolResources IJsonModel<InternalModifyAssistantRequestToolResources>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalModifyAssistantRequestToolResources JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalModifyAssistantRequestToolResources>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalModifyAssistantRequestToolResources)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalModifyAssistantRequestToolResources(document.RootElement, options);
        }

        internal static InternalModifyAssistantRequestToolResources DeserializeInternalModifyAssistantRequestToolResources(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalModifyAssistantRequestToolResourcesCodeInterpreter codeInterpreter = default;
            InternalToolResourcesFileSearchIdsOnly fileSearch = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("code_interpreter"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    codeInterpreter = InternalModifyAssistantRequestToolResourcesCodeInterpreter.DeserializeInternalModifyAssistantRequestToolResourcesCodeInterpreter(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("file_search"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileSearch = InternalToolResourcesFileSearchIdsOnly.DeserializeInternalToolResourcesFileSearchIdsOnly(prop.Value, options);
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalModifyAssistantRequestToolResources(codeInterpreter, fileSearch, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalModifyAssistantRequestToolResources>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalModifyAssistantRequestToolResources>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalModifyAssistantRequestToolResources)} does not support writing '{options.Format}' format.");
            }
        }

        InternalModifyAssistantRequestToolResources IPersistableModel<InternalModifyAssistantRequestToolResources>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalModifyAssistantRequestToolResources PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalModifyAssistantRequestToolResources>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalModifyAssistantRequestToolResources(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalModifyAssistantRequestToolResources)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalModifyAssistantRequestToolResources>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
