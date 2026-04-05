#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class FlagJSONValueJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.FlagJSONValue>
    {
        /// <inheritdoc />
        public override global::Vercel.FlagJSONValue Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            var __score1 = 0;
            var __score2 = 0;
            var __score3 = 0;
            var __score4 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            string? flagJSONValueVariant1 = default;
            double? flagJSONValueVariant2 = default;
            global::System.Collections.Generic.IList<global::Vercel.FlagJSONValue>? flagJSONValueVariant3 = default;
            global::System.Collections.Generic.Dictionary<string, global::Vercel.FlagJSONValue?>? flagJSONValueVariant4 = default;
            bool? flagJSONValueVariant5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        flagJSONValueVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 1)
                {
                    try
                    {

                        flagJSONValueVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<double>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 2)
                {
                    try
                    {

                        flagJSONValueVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::Vercel.FlagJSONValue>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 3)
                {
                    try
                    {

                        flagJSONValueVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.Dictionary<string, global::Vercel.FlagJSONValue?>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 4)
                {
                    try
                    {

                        flagJSONValueVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<bool>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (flagJSONValueVariant1 == null && flagJSONValueVariant2 == null && flagJSONValueVariant3 == null && flagJSONValueVariant4 == null && flagJSONValueVariant5 == null)
            {
                try
                {

                    flagJSONValueVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    flagJSONValueVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<double>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    flagJSONValueVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::Vercel.FlagJSONValue>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    flagJSONValueVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.Dictionary<string, global::Vercel.FlagJSONValue?>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    flagJSONValueVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<bool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.FlagJSONValue(
                flagJSONValueVariant1,

                flagJSONValueVariant2,

                flagJSONValueVariant3,

                flagJSONValueVariant4,

                flagJSONValueVariant5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.FlagJSONValue value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsFlagJSONValueVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FlagJSONValueVariant1, typeof(string), options);
            }
            else if (value.IsFlagJSONValueVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FlagJSONValueVariant2, typeof(double), options);
            }
            else if (value.IsFlagJSONValueVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FlagJSONValueVariant3, typeof(global::System.Collections.Generic.IList<global::Vercel.FlagJSONValue>), options);
            }
            else if (value.IsFlagJSONValueVariant4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FlagJSONValueVariant4, typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.FlagJSONValue?>), options);
            }
            else if (value.IsFlagJSONValueVariant5)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FlagJSONValueVariant5, typeof(bool), options);
            }
        }
    }
}