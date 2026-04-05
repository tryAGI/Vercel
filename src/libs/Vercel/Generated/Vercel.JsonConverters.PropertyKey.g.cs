#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class PropertyKeyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.PropertyKey>
    {
        /// <inheritdoc />
        public override global::Vercel.PropertyKey Read(
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
            if (__jsonProps.Contains("_tag")) __score2++;
            if (__jsonProps.Contains("key")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            string? propertyKeyVariant1 = default;
            double? propertyKeyVariant2 = default;
            global::Vercel.PropertyKeyVariant3? propertyKeyVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        propertyKeyVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
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
                        propertyKeyVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<double>(__rawJson, options);
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
                        propertyKeyVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::Vercel.PropertyKeyVariant3>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (propertyKeyVariant1 == null && propertyKeyVariant2 == null && propertyKeyVariant3 == null)
            {
                try
                {
                    propertyKeyVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    propertyKeyVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<double>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    propertyKeyVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::Vercel.PropertyKeyVariant3>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.PropertyKey(
                propertyKeyVariant1,

                propertyKeyVariant2,

                propertyKeyVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.PropertyKey value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsPropertyKeyVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PropertyKeyVariant1, typeof(string), options);
            }
            else if (value.IsPropertyKeyVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PropertyKeyVariant2, typeof(double), options);
            }
            else if (value.IsPropertyKeyVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PropertyKeyVariant3, typeof(global::Vercel.PropertyKeyVariant3), options);
            }
        }
    }
}