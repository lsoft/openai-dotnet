// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Assistants
{
    internal partial class InternalRunStepDetailsToolCallsCodeObject : IJsonModel<InternalRunStepDetailsToolCallsCodeObject>
    {
        internal InternalRunStepDetailsToolCallsCodeObject() : this(RunStepToolCallKind.CodeInterpreter, null, null, null)
        {
        }

        void IJsonModel<InternalRunStepDetailsToolCallsCodeObject>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsCodeObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsCodeObject)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("code_interpreter") != true)
            {
                writer.WritePropertyName("code_interpreter"u8);
                writer.WriteObjectValue(CodeInterpreter, options);
            }
        }

        InternalRunStepDetailsToolCallsCodeObject IJsonModel<InternalRunStepDetailsToolCallsCodeObject>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalRunStepDetailsToolCallsCodeObject)JsonModelCreateCore(ref reader, options);

        protected override RunStepToolCall JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsCodeObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsCodeObject)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRunStepDetailsToolCallsCodeObject(document.RootElement, options);
        }

        internal static InternalRunStepDetailsToolCallsCodeObject DeserializeInternalRunStepDetailsToolCallsCodeObject(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RunStepToolCallKind kind = default;
            string id = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter codeInterpreter = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    kind = prop.Value.GetString().ToRunStepToolCallKind();
                    continue;
                }
                if (prop.NameEquals("id"u8))
                {
                    id = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("code_interpreter"u8))
                {
                    codeInterpreter = InternalRunStepDetailsToolCallsCodeObjectCodeInterpreter.DeserializeInternalRunStepDetailsToolCallsCodeObjectCodeInterpreter(prop.Value, options);
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalRunStepDetailsToolCallsCodeObject(kind, id, additionalBinaryDataProperties, codeInterpreter);
        }

        BinaryData IPersistableModel<InternalRunStepDetailsToolCallsCodeObject>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsCodeObject>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsCodeObject)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRunStepDetailsToolCallsCodeObject IPersistableModel<InternalRunStepDetailsToolCallsCodeObject>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalRunStepDetailsToolCallsCodeObject)PersistableModelCreateCore(data, options);

        protected override RunStepToolCall PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsCodeObject>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalRunStepDetailsToolCallsCodeObject(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsCodeObject)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRunStepDetailsToolCallsCodeObject>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
