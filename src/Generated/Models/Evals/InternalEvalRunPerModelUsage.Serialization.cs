// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Evals
{
    internal partial class InternalEvalRunPerModelUsage : IJsonModel<InternalEvalRunPerModelUsage>
    {
        internal InternalEvalRunPerModelUsage()
        {
        }

        void IJsonModel<InternalEvalRunPerModelUsage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalEvalRunPerModelUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalEvalRunPerModelUsage)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("model_name") != true)
            {
                writer.WritePropertyName("model_name"u8);
                writer.WriteStringValue(ModelName);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("invocation_count") != true)
            {
                writer.WritePropertyName("invocation_count"u8);
                writer.WriteNumberValue(InvocationCount);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("prompt_tokens") != true)
            {
                writer.WritePropertyName("prompt_tokens"u8);
                writer.WriteNumberValue(PromptTokens);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("completion_tokens") != true)
            {
                writer.WritePropertyName("completion_tokens"u8);
                writer.WriteNumberValue(CompletionTokens);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("total_tokens") != true)
            {
                writer.WritePropertyName("total_tokens"u8);
                writer.WriteNumberValue(TotalTokens);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("cached_tokens") != true)
            {
                writer.WritePropertyName("cached_tokens"u8);
                writer.WriteNumberValue(CachedTokens);
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

        InternalEvalRunPerModelUsage IJsonModel<InternalEvalRunPerModelUsage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalEvalRunPerModelUsage JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalEvalRunPerModelUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalEvalRunPerModelUsage)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalEvalRunPerModelUsage(document.RootElement, options);
        }

        internal static InternalEvalRunPerModelUsage DeserializeInternalEvalRunPerModelUsage(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string modelName = default;
            int invocationCount = default;
            int promptTokens = default;
            int completionTokens = default;
            int totalTokens = default;
            int cachedTokens = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("model_name"u8))
                {
                    modelName = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("invocation_count"u8))
                {
                    invocationCount = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("prompt_tokens"u8))
                {
                    promptTokens = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("completion_tokens"u8))
                {
                    completionTokens = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("total_tokens"u8))
                {
                    totalTokens = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("cached_tokens"u8))
                {
                    cachedTokens = prop.Value.GetInt32();
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalEvalRunPerModelUsage(
                modelName,
                invocationCount,
                promptTokens,
                completionTokens,
                totalTokens,
                cachedTokens,
                additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalEvalRunPerModelUsage>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalEvalRunPerModelUsage>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalEvalRunPerModelUsage)} does not support writing '{options.Format}' format.");
            }
        }

        InternalEvalRunPerModelUsage IPersistableModel<InternalEvalRunPerModelUsage>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalEvalRunPerModelUsage PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalEvalRunPerModelUsage>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalEvalRunPerModelUsage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalEvalRunPerModelUsage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalEvalRunPerModelUsage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
