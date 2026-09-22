#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class AutoSDKSharede0f9d68fc63cf31dJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKSharede0f9d68fc63cf31d>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKSharede0f9d68fc63cf31d Read(
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
            if (__jsonProps.Contains("createdAt")) __score0++;
            if (__jsonProps.Contains("deployHooks")) __score0++;
            if (__jsonProps.Contains("gitCredentialId")) __score0++;
            if (__jsonProps.Contains("org")) __score0++;
            if (__jsonProps.Contains("productionBranch")) __score0++;
            if (__jsonProps.Contains("repo")) __score0++;
            if (__jsonProps.Contains("repoId")) __score0++;
            if (__jsonProps.Contains("repoOwnerId")) __score0++;
            if (__jsonProps.Contains("sourceless")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("updatedAt")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("createdAt")) __score1++;
            if (__jsonProps.Contains("deployHooks")) __score1++;
            if (__jsonProps.Contains("gitCredentialId")) __score1++;
            if (__jsonProps.Contains("org")) __score1++;
            if (__jsonProps.Contains("productionBranch")) __score1++;
            if (__jsonProps.Contains("repo")) __score1++;
            if (__jsonProps.Contains("repoId")) __score1++;
            if (__jsonProps.Contains("repoOwnerId")) __score1++;
            if (__jsonProps.Contains("sourceless")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("updatedAt")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("createdAt")) __score2++;
            if (__jsonProps.Contains("deployHooks")) __score2++;
            if (__jsonProps.Contains("gitCredentialId")) __score2++;
            if (__jsonProps.Contains("host")) __score2++;
            if (__jsonProps.Contains("org")) __score2++;
            if (__jsonProps.Contains("productionBranch")) __score2++;
            if (__jsonProps.Contains("repo")) __score2++;
            if (__jsonProps.Contains("repoId")) __score2++;
            if (__jsonProps.Contains("repoOwnerId")) __score2++;
            if (__jsonProps.Contains("sourceless")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("updatedAt")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("createdAt")) __score3++;
            if (__jsonProps.Contains("deployHooks")) __score3++;
            if (__jsonProps.Contains("gitCredentialId")) __score3++;
            if (__jsonProps.Contains("productionBranch")) __score3++;
            if (__jsonProps.Contains("projectId")) __score3++;
            if (__jsonProps.Contains("projectName")) __score3++;
            if (__jsonProps.Contains("projectNameWithNamespace")) __score3++;
            if (__jsonProps.Contains("projectNamespace")) __score3++;
            if (__jsonProps.Contains("projectOwnerId")) __score3++;
            if (__jsonProps.Contains("projectUrl")) __score3++;
            if (__jsonProps.Contains("sourceless")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("updatedAt")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("createdAt")) __score4++;
            if (__jsonProps.Contains("deployHooks")) __score4++;
            if (__jsonProps.Contains("gitCredentialId")) __score4++;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("owner")) __score4++;
            if (__jsonProps.Contains("productionBranch")) __score4++;
            if (__jsonProps.Contains("slug")) __score4++;
            if (__jsonProps.Contains("sourceless")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("updatedAt")) __score4++;
            if (__jsonProps.Contains("uuid")) __score4++;
            if (__jsonProps.Contains("workspaceUuid")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("createdAt")) __score5++;
            if (__jsonProps.Contains("deployHooks")) __score5++;
            if (__jsonProps.Contains("gitCredentialId")) __score5++;
            if (__jsonProps.Contains("org")) __score5++;
            if (__jsonProps.Contains("productionBranch")) __score5++;
            if (__jsonProps.Contains("repo")) __score5++;
            if (__jsonProps.Contains("repoId")) __score5++;
            if (__jsonProps.Contains("sourceless")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            if (__jsonProps.Contains("updatedAt")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("createdAt")) __score6++;
            if (__jsonProps.Contains("deployHooks")) __score6++;
            if (__jsonProps.Contains("gitCredentialId")) __score6++;
            if (__jsonProps.Contains("org")) __score6++;
            if (__jsonProps.Contains("productionBranch")) __score6++;
            if (__jsonProps.Contains("repo")) __score6++;
            if (__jsonProps.Contains("repoId")) __score6++;
            if (__jsonProps.Contains("sourceless")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            if (__jsonProps.Contains("updatedAt")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("createdAt")) __score7++;
            if (__jsonProps.Contains("deployHooks")) __score7++;
            if (__jsonProps.Contains("gitCredentialId")) __score7++;
            if (__jsonProps.Contains("owner")) __score7++;
            if (__jsonProps.Contains("ownerId")) __score7++;
            if (__jsonProps.Contains("productionBranch")) __score7++;
            if (__jsonProps.Contains("repo")) __score7++;
            if (__jsonProps.Contains("repoId")) __score7++;
            if (__jsonProps.Contains("sourceless")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            if (__jsonProps.Contains("updatedAt")) __score7++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }

            global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant1? autoSDKSharede0f9d68fc63cf31dVariant1 = default;
            global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant2? autoSDKSharede0f9d68fc63cf31dVariant2 = default;
            global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant3? autoSDKSharede0f9d68fc63cf31dVariant3 = default;
            global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant4? autoSDKSharede0f9d68fc63cf31dVariant4 = default;
            global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant5? autoSDKSharede0f9d68fc63cf31dVariant5 = default;
            global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant6? autoSDKSharede0f9d68fc63cf31dVariant6 = default;
            global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant7? autoSDKSharede0f9d68fc63cf31dVariant7 = default;
            global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant8? autoSDKSharede0f9d68fc63cf31dVariant8 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant1).Name}");
                        autoSDKSharede0f9d68fc63cf31dVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant2).Name}");
                        autoSDKSharede0f9d68fc63cf31dVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant3).Name}");
                        autoSDKSharede0f9d68fc63cf31dVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant4).Name}");
                        autoSDKSharede0f9d68fc63cf31dVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant5).Name}");
                        autoSDKSharede0f9d68fc63cf31dVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant6).Name}");
                        autoSDKSharede0f9d68fc63cf31dVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant7).Name}");
                        autoSDKSharede0f9d68fc63cf31dVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant8).Name}");
                        autoSDKSharede0f9d68fc63cf31dVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (autoSDKSharede0f9d68fc63cf31dVariant1 == null && autoSDKSharede0f9d68fc63cf31dVariant2 == null && autoSDKSharede0f9d68fc63cf31dVariant3 == null && autoSDKSharede0f9d68fc63cf31dVariant4 == null && autoSDKSharede0f9d68fc63cf31dVariant5 == null && autoSDKSharede0f9d68fc63cf31dVariant6 == null && autoSDKSharede0f9d68fc63cf31dVariant7 == null && autoSDKSharede0f9d68fc63cf31dVariant8 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant1).Name}");
                    autoSDKSharede0f9d68fc63cf31dVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharede0f9d68fc63cf31dVariant1 == null && autoSDKSharede0f9d68fc63cf31dVariant2 == null && autoSDKSharede0f9d68fc63cf31dVariant3 == null && autoSDKSharede0f9d68fc63cf31dVariant4 == null && autoSDKSharede0f9d68fc63cf31dVariant5 == null && autoSDKSharede0f9d68fc63cf31dVariant6 == null && autoSDKSharede0f9d68fc63cf31dVariant7 == null && autoSDKSharede0f9d68fc63cf31dVariant8 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant2).Name}");
                    autoSDKSharede0f9d68fc63cf31dVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharede0f9d68fc63cf31dVariant1 == null && autoSDKSharede0f9d68fc63cf31dVariant2 == null && autoSDKSharede0f9d68fc63cf31dVariant3 == null && autoSDKSharede0f9d68fc63cf31dVariant4 == null && autoSDKSharede0f9d68fc63cf31dVariant5 == null && autoSDKSharede0f9d68fc63cf31dVariant6 == null && autoSDKSharede0f9d68fc63cf31dVariant7 == null && autoSDKSharede0f9d68fc63cf31dVariant8 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant3).Name}");
                    autoSDKSharede0f9d68fc63cf31dVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharede0f9d68fc63cf31dVariant1 == null && autoSDKSharede0f9d68fc63cf31dVariant2 == null && autoSDKSharede0f9d68fc63cf31dVariant3 == null && autoSDKSharede0f9d68fc63cf31dVariant4 == null && autoSDKSharede0f9d68fc63cf31dVariant5 == null && autoSDKSharede0f9d68fc63cf31dVariant6 == null && autoSDKSharede0f9d68fc63cf31dVariant7 == null && autoSDKSharede0f9d68fc63cf31dVariant8 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant4).Name}");
                    autoSDKSharede0f9d68fc63cf31dVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharede0f9d68fc63cf31dVariant1 == null && autoSDKSharede0f9d68fc63cf31dVariant2 == null && autoSDKSharede0f9d68fc63cf31dVariant3 == null && autoSDKSharede0f9d68fc63cf31dVariant4 == null && autoSDKSharede0f9d68fc63cf31dVariant5 == null && autoSDKSharede0f9d68fc63cf31dVariant6 == null && autoSDKSharede0f9d68fc63cf31dVariant7 == null && autoSDKSharede0f9d68fc63cf31dVariant8 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant5).Name}");
                    autoSDKSharede0f9d68fc63cf31dVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharede0f9d68fc63cf31dVariant1 == null && autoSDKSharede0f9d68fc63cf31dVariant2 == null && autoSDKSharede0f9d68fc63cf31dVariant3 == null && autoSDKSharede0f9d68fc63cf31dVariant4 == null && autoSDKSharede0f9d68fc63cf31dVariant5 == null && autoSDKSharede0f9d68fc63cf31dVariant6 == null && autoSDKSharede0f9d68fc63cf31dVariant7 == null && autoSDKSharede0f9d68fc63cf31dVariant8 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant6).Name}");
                    autoSDKSharede0f9d68fc63cf31dVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharede0f9d68fc63cf31dVariant1 == null && autoSDKSharede0f9d68fc63cf31dVariant2 == null && autoSDKSharede0f9d68fc63cf31dVariant3 == null && autoSDKSharede0f9d68fc63cf31dVariant4 == null && autoSDKSharede0f9d68fc63cf31dVariant5 == null && autoSDKSharede0f9d68fc63cf31dVariant6 == null && autoSDKSharede0f9d68fc63cf31dVariant7 == null && autoSDKSharede0f9d68fc63cf31dVariant8 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant7).Name}");
                    autoSDKSharede0f9d68fc63cf31dVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (autoSDKSharede0f9d68fc63cf31dVariant1 == null && autoSDKSharede0f9d68fc63cf31dVariant2 == null && autoSDKSharede0f9d68fc63cf31dVariant3 == null && autoSDKSharede0f9d68fc63cf31dVariant4 == null && autoSDKSharede0f9d68fc63cf31dVariant5 == null && autoSDKSharede0f9d68fc63cf31dVariant6 == null && autoSDKSharede0f9d68fc63cf31dVariant7 == null && autoSDKSharede0f9d68fc63cf31dVariant8 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant8).Name}");
                    autoSDKSharede0f9d68fc63cf31dVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.AutoSDKSharede0f9d68fc63cf31d(
                autoSDKSharede0f9d68fc63cf31dVariant1,

                autoSDKSharede0f9d68fc63cf31dVariant2,

                autoSDKSharede0f9d68fc63cf31dVariant3,

                autoSDKSharede0f9d68fc63cf31dVariant4,

                autoSDKSharede0f9d68fc63cf31dVariant5,

                autoSDKSharede0f9d68fc63cf31dVariant6,

                autoSDKSharede0f9d68fc63cf31dVariant7,

                autoSDKSharede0f9d68fc63cf31dVariant8
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKSharede0f9d68fc63cf31d value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAutoSDKSharede0f9d68fc63cf31dVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharede0f9d68fc63cf31dVariant1!, typeInfo);
            }
            else if (value.IsAutoSDKSharede0f9d68fc63cf31dVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharede0f9d68fc63cf31dVariant2!, typeInfo);
            }
            else if (value.IsAutoSDKSharede0f9d68fc63cf31dVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharede0f9d68fc63cf31dVariant3!, typeInfo);
            }
            else if (value.IsAutoSDKSharede0f9d68fc63cf31dVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharede0f9d68fc63cf31dVariant4!, typeInfo);
            }
            else if (value.IsAutoSDKSharede0f9d68fc63cf31dVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharede0f9d68fc63cf31dVariant5!, typeInfo);
            }
            else if (value.IsAutoSDKSharede0f9d68fc63cf31dVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharede0f9d68fc63cf31dVariant6!, typeInfo);
            }
            else if (value.IsAutoSDKSharede0f9d68fc63cf31dVariant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharede0f9d68fc63cf31dVariant7!, typeInfo);
            }
            else if (value.IsAutoSDKSharede0f9d68fc63cf31dVariant8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.AutoSDKSharede0f9d68fc63cf31dVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoSDKSharede0f9d68fc63cf31dVariant8!, typeInfo);
            }
        }
    }
}