#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class EdgeConfigItemValueJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.EdgeConfigItemValue>
    {
        /// <inheritdoc />
        public override global::Vercel.EdgeConfigItemValue Read(
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

            string? edgeConfigItemValueVariant1 = default;
            double? edgeConfigItemValueVariant2 = default;
            global::System.Collections.Generic.Dictionary<string, global::Vercel.EdgeConfigItemValue?>? edgeConfigItemValueVariant3 = default;
            global::System.Collections.Generic.IList<global::Vercel.EdgeConfigItemValue>? edgeConfigItemValueVariant4 = default;
            bool? edgeConfigItemValueVariant5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        edgeConfigItemValueVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
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

                        edgeConfigItemValueVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<double>(__rawJson, options);
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

                        edgeConfigItemValueVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.Dictionary<string, global::Vercel.EdgeConfigItemValue?>>(__rawJson, options);
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

                        edgeConfigItemValueVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::Vercel.EdgeConfigItemValue>>(__rawJson, options);
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

                        edgeConfigItemValueVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<bool>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (edgeConfigItemValueVariant1 == null && edgeConfigItemValueVariant2 == null && edgeConfigItemValueVariant3 == null && edgeConfigItemValueVariant4 == null && edgeConfigItemValueVariant5 == null)
            {
                try
                {

                    edgeConfigItemValueVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    edgeConfigItemValueVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<double>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    edgeConfigItemValueVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.Dictionary<string, global::Vercel.EdgeConfigItemValue?>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    edgeConfigItemValueVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::Vercel.EdgeConfigItemValue>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    edgeConfigItemValueVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<bool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.EdgeConfigItemValue(
                edgeConfigItemValueVariant1,

                edgeConfigItemValueVariant2,

                edgeConfigItemValueVariant3,

                edgeConfigItemValueVariant4,

                edgeConfigItemValueVariant5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.EdgeConfigItemValue value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEdgeConfigItemValueVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EdgeConfigItemValueVariant1, typeof(string), options);
            }
            else if (value.IsEdgeConfigItemValueVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EdgeConfigItemValueVariant2, typeof(double), options);
            }
            else if (value.IsEdgeConfigItemValueVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EdgeConfigItemValueVariant3, typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.EdgeConfigItemValue?>), options);
            }
            else if (value.IsEdgeConfigItemValueVariant4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EdgeConfigItemValueVariant4, typeof(global::System.Collections.Generic.IList<global::Vercel.EdgeConfigItemValue>), options);
            }
            else if (value.IsEdgeConfigItemValueVariant5)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EdgeConfigItemValueVariant5, typeof(bool), options);
            }
        }
    }
}