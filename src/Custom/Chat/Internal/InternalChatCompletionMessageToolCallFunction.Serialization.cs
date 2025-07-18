﻿using System;
using System.ClientModel.Primitives;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace OpenAI.Chat;

internal partial class InternalChatCompletionMessageToolCallFunction : IJsonModel<InternalChatCompletionMessageToolCallFunction>
{
    // CUSTOM: Replaced the call to WriteRawValue() for a call to WriteStringValue() because even though this property
    // is supposed to be a JSON object, the REST API handles it as a string given that there is no guarantee that it
    // actually is valid JSON.
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void SerializeArgumentsValue(Utf8JsonWriter writer, ModelReaderWriterOptions options)
    {
        string value = Arguments.ToMemory().IsEmpty
            ? string.Empty
            : Arguments.ToString();
        writer.WriteStringValue(value);
    }

    // CUSTOM: Replaced the call to GetRawText() for a call to GetString() because otherwise the starting and ending
    // quotes of the string are included in the BinaryData. While this is actually a string in the REST API, we want to
    // handle it as JSON binary data instead.
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void DeserializeArgumentsValue(JsonProperty property, ref BinaryData arguments, ModelReaderWriterOptions options = null)
    {
        //for a tool calls without arguments there will be an Object instead of String.
        var obj = property.Value.GetObject();
        if (obj is string s)
        {
            arguments = BinaryData.FromString(s);
        }
        else
        {
            arguments = BinaryData.FromString(string.Empty);
        }
    }
}