#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKShared6ed7be4e006b051dJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared6ed7be4e006b051d>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared6ed7be4e006b051d Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

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
            if (__jsonProps.Contains("defaultBranch")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("namespace")) __score0++;
            if (__jsonProps.Contains("ownerType")) __score0++;
            if (__jsonProps.Contains("path")) __score0++;
            if (__jsonProps.Contains("private")) __score0++;
            if (__jsonProps.Contains("projectId")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("url")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("defaultBranch")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("org")) __score1++;
            if (__jsonProps.Contains("ownerType")) __score1++;
            if (__jsonProps.Contains("path")) __score1++;
            if (__jsonProps.Contains("private")) __score1++;
            if (__jsonProps.Contains("repo")) __score1++;
            if (__jsonProps.Contains("repoId")) __score1++;
            if (__jsonProps.Contains("repoOwnerId")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("defaultBranch")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("owner")) __score2++;
            if (__jsonProps.Contains("ownerType")) __score2++;
            if (__jsonProps.Contains("path")) __score2++;
            if (__jsonProps.Contains("private")) __score2++;
            if (__jsonProps.Contains("repoUuid")) __score2++;
            if (__jsonProps.Contains("slug")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("workspaceUuid")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("defaultBranch")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("org")) __score3++;
            if (__jsonProps.Contains("ownerType")) __score3++;
            if (__jsonProps.Contains("path")) __score3++;
            if (__jsonProps.Contains("private")) __score3++;
            if (__jsonProps.Contains("repo")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("defaultBranch")) __score4++;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("owner")) __score4++;
            if (__jsonProps.Contains("ownerType")) __score4++;
            if (__jsonProps.Contains("path")) __score4++;
            if (__jsonProps.Contains("private")) __score4++;
            if (__jsonProps.Contains("repo")) __score4++;
            if (__jsonProps.Contains("repoId")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::Vercel.AutoSDKShared6ed7be4e006b051dVariant1? autoSDKShared6ed7be4e006b051dVariant1 = default;
            global::Vercel.AutoSDKShared6ed7be4e006b051dVariant2? autoSDKShared6ed7be4e006b051dVariant2 = default;
            global::Vercel.AutoSDKShared6ed7be4e006b051dVariant3? autoSDKShared6ed7be4e006b051dVariant3 = default;
            global::Vercel.AutoSDKShared6ed7be4e006b051dVariant4? autoSDKShared6ed7be4e006b051dVariant4 = default;
            global::Vercel.AutoSDKShared6ed7be4e006b051dVariant5? autoSDKShared6ed7be4e006b051dVariant5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared6ed7be4e006b051dVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant1).Name}");
                        autoSDKShared6ed7be4e006b051dVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared6ed7be4e006b051dVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant2).Name}");
                        autoSDKShared6ed7be4e006b051dVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared6ed7be4e006b051dVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant3).Name}");
                        autoSDKShared6ed7be4e006b051dVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared6ed7be4e006b051dVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant4).Name}");
                        autoSDKShared6ed7be4e006b051dVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared6ed7be4e006b051dVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant5).Name}");
                        autoSDKShared6ed7be4e006b051dVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (autoSDKShared6ed7be4e006b051dVariant1 == null && autoSDKShared6ed7be4e006b051dVariant2 == null && autoSDKShared6ed7be4e006b051dVariant3 == null && autoSDKShared6ed7be4e006b051dVariant4 == null && autoSDKShared6ed7be4e006b051dVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared6ed7be4e006b051dVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant1).Name}");
                    autoSDKShared6ed7be4e006b051dVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared6ed7be4e006b051dVariant1 == null && autoSDKShared6ed7be4e006b051dVariant2 == null && autoSDKShared6ed7be4e006b051dVariant3 == null && autoSDKShared6ed7be4e006b051dVariant4 == null && autoSDKShared6ed7be4e006b051dVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared6ed7be4e006b051dVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant2).Name}");
                    autoSDKShared6ed7be4e006b051dVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared6ed7be4e006b051dVariant1 == null && autoSDKShared6ed7be4e006b051dVariant2 == null && autoSDKShared6ed7be4e006b051dVariant3 == null && autoSDKShared6ed7be4e006b051dVariant4 == null && autoSDKShared6ed7be4e006b051dVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared6ed7be4e006b051dVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant3).Name}");
                    autoSDKShared6ed7be4e006b051dVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared6ed7be4e006b051dVariant1 == null && autoSDKShared6ed7be4e006b051dVariant2 == null && autoSDKShared6ed7be4e006b051dVariant3 == null && autoSDKShared6ed7be4e006b051dVariant4 == null && autoSDKShared6ed7be4e006b051dVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared6ed7be4e006b051dVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant4).Name}");
                    autoSDKShared6ed7be4e006b051dVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKShared6ed7be4e006b051dVariant1 == null && autoSDKShared6ed7be4e006b051dVariant2 == null && autoSDKShared6ed7be4e006b051dVariant3 == null && autoSDKShared6ed7be4e006b051dVariant4 == null && autoSDKShared6ed7be4e006b051dVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared6ed7be4e006b051dVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant5).Name}");
                    autoSDKShared6ed7be4e006b051dVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.AutoSDKShared6ed7be4e006b051d(
                autoSDKShared6ed7be4e006b051dVariant1,

                autoSDKShared6ed7be4e006b051dVariant2,

                autoSDKShared6ed7be4e006b051dVariant3,

                autoSDKShared6ed7be4e006b051dVariant4,

                autoSDKShared6ed7be4e006b051dVariant5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared6ed7be4e006b051d value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAutoSDKShared6ed7be4e006b051dVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared6ed7be4e006b051dVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared6ed7be4e006b051dVariant1!, typeInfo);
            }
            else if (value.IsAutoSDKShared6ed7be4e006b051dVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared6ed7be4e006b051dVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared6ed7be4e006b051dVariant2!, typeInfo);
            }
            else if (value.IsAutoSDKShared6ed7be4e006b051dVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared6ed7be4e006b051dVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared6ed7be4e006b051dVariant3!, typeInfo);
            }
            else if (value.IsAutoSDKShared6ed7be4e006b051dVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared6ed7be4e006b051dVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared6ed7be4e006b051dVariant4!, typeInfo);
            }
            else if (value.IsAutoSDKShared6ed7be4e006b051dVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared6ed7be4e006b051dVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared6ed7be4e006b051dVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKShared6ed7be4e006b051dVariant5!, typeInfo);
            }
        }
    }
}