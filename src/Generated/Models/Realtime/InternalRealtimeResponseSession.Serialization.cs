// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Realtime
{
    internal partial class InternalRealtimeResponseSession : IJsonModel<InternalRealtimeResponseSession>
    {
        internal InternalRealtimeResponseSession() : this(null, null, null, null, null, default, default, null, null, null, null, null, default, default, null, null)
        {
        }

        void IJsonModel<InternalRealtimeResponseSession>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeResponseSession>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeResponseSession)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("object") != true)
            {
                writer.WritePropertyName("object"u8);
                writer.WriteStringValue(Object);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("id") != true)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("model") != true)
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(Model);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("modalities") != true)
            {
                writer.WritePropertyName("modalities"u8);
                writer.WriteStartArray();
                foreach (InternalRealtimeRequestSessionModality item in Modalities)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (_additionalBinaryDataProperties?.ContainsKey("instructions") != true)
            {
                writer.WritePropertyName("instructions"u8);
                writer.WriteStringValue(Instructions);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("input_audio_format") != true)
            {
                writer.WritePropertyName("input_audio_format"u8);
                writer.WriteStringValue(InputAudioFormat.ToString());
            }
            if (_additionalBinaryDataProperties?.ContainsKey("output_audio_format") != true)
            {
                writer.WritePropertyName("output_audio_format"u8);
                writer.WriteStringValue(OutputAudioFormat.ToString());
            }
            if (_additionalBinaryDataProperties?.ContainsKey("input_audio_transcription") != true)
            {
                if (Optional.IsDefined(InputAudioTranscription))
                {
                    writer.WritePropertyName("input_audio_transcription"u8);
                    writer.WriteObjectValue(InputAudioTranscription, options);
                }
                else
                {
                    writer.WriteNull("input_audio_transcription"u8);
                }
            }
            if (_additionalBinaryDataProperties?.ContainsKey("turn_detection") != true)
            {
                writer.WritePropertyName("turn_detection"u8);
                writer.WriteObjectValue(TurnDetection, options);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("input_audio_noise_reduction") != true)
            {
                writer.WritePropertyName("input_audio_noise_reduction"u8);
                writer.WriteObjectValue(InputAudioNoiseReduction, options);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("tools") != true)
            {
                writer.WritePropertyName("tools"u8);
                writer.WriteStartArray();
                foreach (ConversationTool item in Tools)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (_additionalBinaryDataProperties?.ContainsKey("tool_choice") != true)
            {
                writer.WritePropertyName("tool_choice"u8);
#if NET6_0_OR_GREATER
                writer.WriteRawValue(ToolChoice);
#else
                using (JsonDocument document = JsonDocument.Parse(ToolChoice))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (_additionalBinaryDataProperties?.ContainsKey("temperature") != true)
            {
                writer.WritePropertyName("temperature"u8);
                writer.WriteNumberValue(Temperature);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("voice") != true)
            {
                writer.WritePropertyName("voice"u8);
                writer.WriteStringValue(Voice.ToString());
            }
            if (_additionalBinaryDataProperties?.ContainsKey("max_response_output_tokens") != true)
            {
                if (Optional.IsDefined(_maxResponseOutputTokens))
                {
                    writer.WritePropertyName("max_response_output_tokens"u8);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(_maxResponseOutputTokens);
#else
                    using (JsonDocument document = JsonDocument.Parse(_maxResponseOutputTokens))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                else
                {
                    writer.WriteNull("max_response_output_tokens"u8);
                }
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

        InternalRealtimeResponseSession IJsonModel<InternalRealtimeResponseSession>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalRealtimeResponseSession JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeResponseSession>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeResponseSession)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRealtimeResponseSession(document.RootElement, options);
        }

        internal static InternalRealtimeResponseSession DeserializeInternalRealtimeResponseSession(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string @object = default;
            string id = default;
            string model = default;
            IList<InternalRealtimeRequestSessionModality> modalities = default;
            string instructions = default;
            RealtimeAudioFormat inputAudioFormat = default;
            RealtimeAudioFormat outputAudioFormat = default;
            InputTranscriptionOptions inputAudioTranscription = default;
            TurnDetectionOptions turnDetection = default;
            InputNoiseReductionOptions inputAudioNoiseReduction = default;
            IList<ConversationTool> tools = default;
            BinaryData toolChoice = default;
            float temperature = default;
            ConversationVoice voice = default;
            BinaryData maxResponseOutputTokens = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("object"u8))
                {
                    @object = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("id"u8))
                {
                    id = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("model"u8))
                {
                    model = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("modalities"u8))
                {
                    List<InternalRealtimeRequestSessionModality> array = new List<InternalRealtimeRequestSessionModality>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(new InternalRealtimeRequestSessionModality(item.GetString()));
                    }
                    modalities = array;
                    continue;
                }
                if (prop.NameEquals("instructions"u8))
                {
                    instructions = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("input_audio_format"u8))
                {
                    inputAudioFormat = new RealtimeAudioFormat(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("output_audio_format"u8))
                {
                    outputAudioFormat = new RealtimeAudioFormat(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("input_audio_transcription"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        inputAudioTranscription = null;
                        continue;
                    }
                    inputAudioTranscription = InputTranscriptionOptions.DeserializeInputTranscriptionOptions(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("turn_detection"u8))
                {
                    turnDetection = TurnDetectionOptions.DeserializeTurnDetectionOptions(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("input_audio_noise_reduction"u8))
                {
                    inputAudioNoiseReduction = InputNoiseReductionOptions.DeserializeInputNoiseReductionOptions(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("tools"u8))
                {
                    List<ConversationTool> array = new List<ConversationTool>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(ConversationTool.DeserializeConversationTool(item, options));
                    }
                    tools = array;
                    continue;
                }
                if (prop.NameEquals("tool_choice"u8))
                {
                    toolChoice = BinaryData.FromString(prop.Value.GetRawText());
                    continue;
                }
                if (prop.NameEquals("temperature"u8))
                {
                    temperature = prop.Value.GetSingle();
                    continue;
                }
                if (prop.NameEquals("voice"u8))
                {
                    voice = new ConversationVoice(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("max_response_output_tokens"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        maxResponseOutputTokens = null;
                        continue;
                    }
                    maxResponseOutputTokens = BinaryData.FromString(prop.Value.GetRawText());
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalRealtimeResponseSession(
                @object,
                id,
                model,
                modalities,
                instructions,
                inputAudioFormat,
                outputAudioFormat,
                inputAudioTranscription,
                turnDetection,
                inputAudioNoiseReduction,
                tools,
                toolChoice,
                temperature,
                voice,
                maxResponseOutputTokens,
                additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalRealtimeResponseSession>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeResponseSession>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeResponseSession)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRealtimeResponseSession IPersistableModel<InternalRealtimeResponseSession>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalRealtimeResponseSession PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeResponseSession>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalRealtimeResponseSession(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeResponseSession)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRealtimeResponseSession>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
