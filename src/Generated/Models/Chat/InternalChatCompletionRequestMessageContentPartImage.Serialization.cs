// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Chat
{
    internal partial class InternalChatCompletionRequestMessageContentPartImage : IJsonModel<InternalChatCompletionRequestMessageContentPartImage>
    {
        internal InternalChatCompletionRequestMessageContentPartImage()
        {
        }

        void IJsonModel<InternalChatCompletionRequestMessageContentPartImage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionRequestMessageContentPartImage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalChatCompletionRequestMessageContentPartImage)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("image_url") != true)
            {
                writer.WritePropertyName("image_url"u8);
                writer.WriteObjectValue(ImageUrl, options);
            }
        }

        InternalChatCompletionRequestMessageContentPartImage IJsonModel<InternalChatCompletionRequestMessageContentPartImage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalChatCompletionRequestMessageContentPartImage)JsonModelCreateCore(ref reader, options);

        protected override ChatMessageContentPart JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionRequestMessageContentPartImage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalChatCompletionRequestMessageContentPartImage)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalChatCompletionRequestMessageContentPartImage(document.RootElement, options);
        }

        internal static InternalChatCompletionRequestMessageContentPartImage DeserializeInternalChatCompletionRequestMessageContentPartImage(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            InternalChatCompletionRequestMessageContentPartImageImageUrl imageUrl = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("image_url"u8))
                {
                    imageUrl = InternalChatCompletionRequestMessageContentPartImageImageUrl.DeserializeInternalChatCompletionRequestMessageContentPartImageImageUrl(prop.Value, options);
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalChatCompletionRequestMessageContentPartImage(additionalBinaryDataProperties, imageUrl);
        }

        BinaryData IPersistableModel<InternalChatCompletionRequestMessageContentPartImage>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionRequestMessageContentPartImage>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalChatCompletionRequestMessageContentPartImage)} does not support writing '{options.Format}' format.");
            }
        }

        InternalChatCompletionRequestMessageContentPartImage IPersistableModel<InternalChatCompletionRequestMessageContentPartImage>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalChatCompletionRequestMessageContentPartImage)PersistableModelCreateCore(data, options);

        protected override ChatMessageContentPart PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionRequestMessageContentPartImage>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalChatCompletionRequestMessageContentPartImage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalChatCompletionRequestMessageContentPartImage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalChatCompletionRequestMessageContentPartImage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
