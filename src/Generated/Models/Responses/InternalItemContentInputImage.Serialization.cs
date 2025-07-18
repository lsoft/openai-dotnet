// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Responses
{
    internal partial class InternalItemContentInputImage : IJsonModel<InternalItemContentInputImage>
    {
        void IJsonModel<InternalItemContentInputImage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalItemContentInputImage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalItemContentInputImage)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(ImageUrl) && _additionalBinaryDataProperties?.ContainsKey("image_url") != true)
            {
                writer.WritePropertyName("image_url"u8);
                writer.WriteStringValue(ImageUrl);
            }
            if (Optional.IsDefined(FileId) && _additionalBinaryDataProperties?.ContainsKey("file_id") != true)
            {
                writer.WritePropertyName("file_id"u8);
                writer.WriteStringValue(FileId);
            }
            if (Optional.IsDefined(Detail) && _additionalBinaryDataProperties?.ContainsKey("detail") != true)
            {
                writer.WritePropertyName("detail"u8);
                writer.WriteStringValue(Detail.Value.ToString());
            }
        }

        InternalItemContentInputImage IJsonModel<InternalItemContentInputImage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalItemContentInputImage)JsonModelCreateCore(ref reader, options);

        protected override ResponseContentPart JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalItemContentInputImage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalItemContentInputImage)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalItemContentInputImage(document.RootElement, options);
        }

        internal static InternalItemContentInputImage DeserializeInternalItemContentInputImage(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalItemContentType internalType = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            string imageUrl = default;
            string fileId = default;
            ResponseImageDetailLevel? detail = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    internalType = new InternalItemContentType(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("image_url"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        imageUrl = null;
                        continue;
                    }
                    imageUrl = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("file_id"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        fileId = null;
                        continue;
                    }
                    fileId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("detail"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    detail = new ResponseImageDetailLevel(prop.Value.GetString());
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalItemContentInputImage(internalType, additionalBinaryDataProperties, imageUrl, fileId, detail);
        }

        BinaryData IPersistableModel<InternalItemContentInputImage>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalItemContentInputImage>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalItemContentInputImage)} does not support writing '{options.Format}' format.");
            }
        }

        InternalItemContentInputImage IPersistableModel<InternalItemContentInputImage>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalItemContentInputImage)PersistableModelCreateCore(data, options);

        protected override ResponseContentPart PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalItemContentInputImage>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalItemContentInputImage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalItemContentInputImage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalItemContentInputImage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
