#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class RegistrantFieldJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.RegistrantField>
    {
        /// <inheritdoc />
        public override global::Vercel.RegistrantField Read(
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
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("fields")) __score0++;
            if (__jsonProps.Contains("label")) __score0++;
            if (__jsonProps.Contains("options")) __score0++;
            if (__jsonProps.Contains("required")) __score0++;
            if (__jsonProps.Contains("required_when")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("validation")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("description")) __score1++;
            if (__jsonProps.Contains("fields")) __score1++;
            if (__jsonProps.Contains("label")) __score1++;
            if (__jsonProps.Contains("options")) __score1++;
            if (__jsonProps.Contains("required")) __score1++;
            if (__jsonProps.Contains("required_when")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("validation")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("description")) __score2++;
            if (__jsonProps.Contains("label")) __score2++;
            if (__jsonProps.Contains("required")) __score2++;
            if (__jsonProps.Contains("required_when")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("validation")) __score2++;
            if (__jsonProps.Contains("value")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("description")) __score3++;
            if (__jsonProps.Contains("label")) __score3++;
            if (__jsonProps.Contains("required")) __score3++;
            if (__jsonProps.Contains("required_when")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("validation")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::Vercel.RegistrantFieldVariant1? registrantFieldVariant1 = default;
            global::Vercel.RegistrantFieldVariant2? registrantFieldVariant2 = default;
            global::Vercel.RegistrantFieldVariant3? registrantFieldVariant3 = default;
            global::Vercel.RegistrantFieldVariant4? registrantFieldVariant4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        registrantFieldVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::Vercel.RegistrantFieldVariant1>(__rawJson, options);
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
                        registrantFieldVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Vercel.RegistrantFieldVariant2>(__rawJson, options);
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
                        registrantFieldVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::Vercel.RegistrantFieldVariant3>(__rawJson, options);
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
                        registrantFieldVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::Vercel.RegistrantFieldVariant4>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (registrantFieldVariant1 == null && registrantFieldVariant2 == null && registrantFieldVariant3 == null && registrantFieldVariant4 == null)
            {
                try
                {
                    registrantFieldVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::Vercel.RegistrantFieldVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    registrantFieldVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Vercel.RegistrantFieldVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    registrantFieldVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<global::Vercel.RegistrantFieldVariant3>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    registrantFieldVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::Vercel.RegistrantFieldVariant4>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.RegistrantField(
                registrantFieldVariant1,

                registrantFieldVariant2,

                registrantFieldVariant3,

                registrantFieldVariant4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.RegistrantField value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsRegistrantFieldVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RegistrantFieldVariant1, typeof(global::Vercel.RegistrantFieldVariant1), options);
            }
            else if (value.IsRegistrantFieldVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RegistrantFieldVariant2, typeof(global::Vercel.RegistrantFieldVariant2), options);
            }
            else if (value.IsRegistrantFieldVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RegistrantFieldVariant3, typeof(global::Vercel.RegistrantFieldVariant3), options);
            }
            else if (value.IsRegistrantFieldVariant4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RegistrantFieldVariant4, typeof(global::Vercel.RegistrantFieldVariant4), options);
            }
        }
    }
}