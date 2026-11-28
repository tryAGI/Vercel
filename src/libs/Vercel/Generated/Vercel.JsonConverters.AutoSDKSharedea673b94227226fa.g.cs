#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKSharedea673b94227226faJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKSharedea673b94227226fa>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKSharedea673b94227226fa Read(
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
            if (__jsonProps.Contains("defaultRoute")) __score0++;
            if (__jsonProps.Contains("enabled")) __score0++;
            if (__jsonProps.Contains("freeProjectForLegacyLimits")) __score0++;
            if (__jsonProps.Contains("groupIds")) __score0++;
            if (__jsonProps.Contains("isDefaultApp")) __score0++;
            if (__jsonProps.Contains("updatedAt")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("defaultRoute")) __score1++;
            if (__jsonProps.Contains("doNotInheritDefaultAppManagedRules")) __score1++;
            if (__jsonProps.Contains("doNotRouteWithMicrofrontendsRouting")) __score1++;
            if (__jsonProps.Contains("enabled")) __score1++;
            if (__jsonProps.Contains("freeProjectForLegacyLimits")) __score1++;
            if (__jsonProps.Contains("groupIds")) __score1++;
            if (__jsonProps.Contains("isDefaultApp")) __score1++;
            if (__jsonProps.Contains("routeObservabilityToThisProject")) __score1++;
            if (__jsonProps.Contains("updatedAt")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("enabled")) __score2++;
            if (__jsonProps.Contains("freeProjectForLegacyLimits")) __score2++;
            if (__jsonProps.Contains("groupIds")) __score2++;
            if (__jsonProps.Contains("updatedAt")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Vercel.AutoSDKSharedea673b94227226faVariant1? autoSDKSharedea673b94227226faVariant1 = default;
            global::Vercel.AutoSDKShared45ccc0a95a3ba642? shared45ccc0a95a3ba642 = default;
            global::Vercel.AutoSDKSharedea673b94227226faVariant3? autoSDKSharedea673b94227226faVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedea673b94227226faVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedea673b94227226faVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedea673b94227226faVariant1).Name}");
                        autoSDKSharedea673b94227226faVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared45ccc0a95a3ba642), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared45ccc0a95a3ba642> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared45ccc0a95a3ba642).Name}");
                        shared45ccc0a95a3ba642 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedea673b94227226faVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedea673b94227226faVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedea673b94227226faVariant3).Name}");
                        autoSDKSharedea673b94227226faVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
            }

            if (autoSDKSharedea673b94227226faVariant1 == null && shared45ccc0a95a3ba642 == null && autoSDKSharedea673b94227226faVariant3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedea673b94227226faVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedea673b94227226faVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedea673b94227226faVariant1).Name}");
                    autoSDKSharedea673b94227226faVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (autoSDKSharedea673b94227226faVariant1 == null && shared45ccc0a95a3ba642 == null && autoSDKSharedea673b94227226faVariant3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared45ccc0a95a3ba642), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared45ccc0a95a3ba642> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared45ccc0a95a3ba642).Name}");
                    shared45ccc0a95a3ba642 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (autoSDKSharedea673b94227226faVariant1 == null && shared45ccc0a95a3ba642 == null && autoSDKSharedea673b94227226faVariant3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedea673b94227226faVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedea673b94227226faVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedea673b94227226faVariant3).Name}");
                    autoSDKSharedea673b94227226faVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            var __value = new global::Vercel.AutoSDKSharedea673b94227226fa(
                autoSDKSharedea673b94227226faVariant1,

                shared45ccc0a95a3ba642,

                autoSDKSharedea673b94227226faVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKSharedea673b94227226fa value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAutoSDKSharedea673b94227226faVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedea673b94227226faVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedea673b94227226faVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedea673b94227226faVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAutoSDKSharedea673b94227226faVariant1(), typeInfo);
            }
            else if (value.IsShared45ccc0a95a3ba642)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared45ccc0a95a3ba642), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared45ccc0a95a3ba642?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared45ccc0a95a3ba642).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickShared45ccc0a95a3ba642(), typeInfo);
            }
            else if (value.IsAutoSDKSharedea673b94227226faVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharedea673b94227226faVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharedea673b94227226faVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharedea673b94227226faVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAutoSDKSharedea673b94227226faVariant3(), typeInfo);
            }
        }
    }
}