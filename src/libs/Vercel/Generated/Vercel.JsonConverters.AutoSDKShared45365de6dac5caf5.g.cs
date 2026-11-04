#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKShared45365de6dac5caf5JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared45365de6dac5caf5>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared45365de6dac5caf5 Read(
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
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("buildCommand")) __score0++;
            if (__jsonProps.Contains("builder")) __score0++;
            if (__jsonProps.Contains("builder.config")) __score0++;
            if (__jsonProps.Contains("builder.src")) __score0++;
            if (__jsonProps.Contains("builder.use")) __score0++;
            if (__jsonProps.Contains("entrypoint")) __score0++;
            if (__jsonProps.Contains("env")) __score0++;
            if (__jsonProps.Contains("framework")) __score0++;
            if (__jsonProps.Contains("group")) __score0++;
            if (__jsonProps.Contains("handlerFunction")) __score0++;
            if (__jsonProps.Contains("installCommand")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("preDeployCommand")) __score0++;
            if (__jsonProps.Contains("routePrefix")) __score0++;
            if (__jsonProps.Contains("routePrefixSource")) __score0++;
            if (__jsonProps.Contains("runtime")) __score0++;
            if (__jsonProps.Contains("schedule")) __score0++;
            if (__jsonProps.Contains("schema")) __score0++;
            if (__jsonProps.Contains("subdomain")) __score0++;
            if (__jsonProps.Contains("topics")) __score0++;
            if (__jsonProps.Contains("trigger")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("workspace")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("bindings")) __score1++;
            if (__jsonProps.Contains("buildCommand")) __score1++;
            if (__jsonProps.Contains("builder")) __score1++;
            if (__jsonProps.Contains("builder.config")) __score1++;
            if (__jsonProps.Contains("builder.src")) __score1++;
            if (__jsonProps.Contains("builder.use")) __score1++;
            if (__jsonProps.Contains("cleanUrls")) __score1++;
            if (__jsonProps.Contains("command")) __score1++;
            if (__jsonProps.Contains("devCommand")) __score1++;
            if (__jsonProps.Contains("entrypoint")) __score1++;
            if (__jsonProps.Contains("framework")) __score1++;
            if (__jsonProps.Contains("functions")) __score1++;
            if (__jsonProps.Contains("headers")) __score1++;
            if (__jsonProps.Contains("ignoreCommand")) __score1++;
            if (__jsonProps.Contains("installCommand")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("outputDirectory")) __score1++;
            if (__jsonProps.Contains("redirects")) __score1++;
            if (__jsonProps.Contains("rewrites")) __score1++;
            if (__jsonProps.Contains("root")) __score1++;
            if (__jsonProps.Contains("routes")) __score1++;
            if (__jsonProps.Contains("runtime")) __score1++;
            if (__jsonProps.Contains("schema")) __score1++;
            if (__jsonProps.Contains("trailingSlash")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Vercel.AutoSDKShared303c00bc2455dd70? shared303c00bc2455dd70 = default;
            global::Vercel.AutoSDKShared82fc3497d7089534? shared82fc3497d7089534 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared303c00bc2455dd70), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared303c00bc2455dd70> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared303c00bc2455dd70).Name}");
                        shared303c00bc2455dd70 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared82fc3497d7089534), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared82fc3497d7089534> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared82fc3497d7089534).Name}");
                        shared82fc3497d7089534 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            if (shared303c00bc2455dd70 == null && shared82fc3497d7089534 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared303c00bc2455dd70), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared303c00bc2455dd70> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared303c00bc2455dd70).Name}");
                    shared303c00bc2455dd70 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            if (shared303c00bc2455dd70 == null && shared82fc3497d7089534 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared82fc3497d7089534), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared82fc3497d7089534> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared82fc3497d7089534).Name}");
                    shared82fc3497d7089534 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            var __value = new global::Vercel.AutoSDKShared45365de6dac5caf5(
                shared303c00bc2455dd70,

                shared82fc3497d7089534
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared45365de6dac5caf5 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsShared303c00bc2455dd70)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared303c00bc2455dd70), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared303c00bc2455dd70?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared303c00bc2455dd70).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickShared303c00bc2455dd70(), typeInfo);
            }
            else if (value.IsShared82fc3497d7089534)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKShared82fc3497d7089534), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKShared82fc3497d7089534?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKShared82fc3497d7089534).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickShared82fc3497d7089534(), typeInfo);
            }
        }
    }
}