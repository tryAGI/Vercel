#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class ConnectConnectorUpdateDataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.ConnectConnectorUpdateData>
    {
        /// <inheritdoc />
        public override global::Vercel.ConnectConnectorUpdateData Read(
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
            if (__jsonProps.Contains("authorizationUrlParams")) __score0++;
            if (__jsonProps.Contains("clientAssertion")) __score0++;
            if (__jsonProps.Contains("clientAssertion.claims")) __score0++;
            if (__jsonProps.Contains("clientAssertion.ttl")) __score0++;
            if (__jsonProps.Contains("clientAssertion.type")) __score0++;
            if (__jsonProps.Contains("clientCredentials")) __score0++;
            if (__jsonProps.Contains("clientCredentials.enabled")) __score0++;
            if (__jsonProps.Contains("clientCredentials.scopes")) __score0++;
            if (__jsonProps.Contains("clientId")) __score0++;
            if (__jsonProps.Contains("clientName")) __score0++;
            if (__jsonProps.Contains("clientSecret")) __score0++;
            if (__jsonProps.Contains("codeChallengeMethod")) __score0++;
            if (__jsonProps.Contains("defaultAudience")) __score0++;
            if (__jsonProps.Contains("defaultTokenExpiresIn")) __score0++;
            if (__jsonProps.Contains("forwardedClaims")) __score0++;
            if (__jsonProps.Contains("forwardedClaims.idToken")) __score0++;
            if (__jsonProps.Contains("jwtBearer")) __score0++;
            if (__jsonProps.Contains("jwtBearer.additionalClaims")) __score0++;
            if (__jsonProps.Contains("jwtBearer.aud")) __score0++;
            if (__jsonProps.Contains("jwtBearer.enabled")) __score0++;
            if (__jsonProps.Contains("jwtBearer.iss")) __score0++;
            if (__jsonProps.Contains("jwtBearer.scopes")) __score0++;
            if (__jsonProps.Contains("jwtBearer.sub")) __score0++;
            if (__jsonProps.Contains("jwtBearer.ttl")) __score0++;
            if (__jsonProps.Contains("jwtBearer.useClientCredentials")) __score0++;
            if (__jsonProps.Contains("pkceRequired")) __score0++;
            if (__jsonProps.Contains("refreshTokens")) __score0++;
            if (__jsonProps.Contains("refreshTokens.enabled")) __score0++;
            if (__jsonProps.Contains("responseType")) __score0++;
            if (__jsonProps.Contains("serverConfig")) __score0++;
            if (__jsonProps.Contains("serverConfig.authorization_details_types_supported")) __score0++;
            if (__jsonProps.Contains("serverConfig.authorization_endpoint")) __score0++;
            if (__jsonProps.Contains("serverConfig.claim_types_supported")) __score0++;
            if (__jsonProps.Contains("serverConfig.claims_parameter_supported")) __score0++;
            if (__jsonProps.Contains("serverConfig.claims_supported")) __score0++;
            if (__jsonProps.Contains("serverConfig.client_id_metadata_document_supported")) __score0++;
            if (__jsonProps.Contains("serverConfig.code_challenge_methods_supported")) __score0++;
            if (__jsonProps.Contains("serverConfig.device_authorization_endpoint")) __score0++;
            if (__jsonProps.Contains("serverConfig.end_session_endpoint")) __score0++;
            if (__jsonProps.Contains("serverConfig.grant_types_supported")) __score0++;
            if (__jsonProps.Contains("serverConfig.id_token_encryption_alg_values_supported")) __score0++;
            if (__jsonProps.Contains("serverConfig.id_token_encryption_enc_values_supported")) __score0++;
            if (__jsonProps.Contains("serverConfig.id_token_signing_alg_values_supported")) __score0++;
            if (__jsonProps.Contains("serverConfig.introspection_endpoint")) __score0++;
            if (__jsonProps.Contains("serverConfig.issuer")) __score0++;
            if (__jsonProps.Contains("serverConfig.jwks")) __score0++;
            if (__jsonProps.Contains("serverConfig.jwks_uri")) __score0++;
            if (__jsonProps.Contains("serverConfig.logo_uri")) __score0++;
            if (__jsonProps.Contains("serverConfig.op_policy_uri")) __score0++;
            if (__jsonProps.Contains("serverConfig.op_tos_uri")) __score0++;
            if (__jsonProps.Contains("serverConfig.prompt_values_supported")) __score0++;
            if (__jsonProps.Contains("serverConfig.registration_endpoint")) __score0++;
            if (__jsonProps.Contains("serverConfig.request_parameter_supported")) __score0++;
            if (__jsonProps.Contains("serverConfig.request_uri_parameter_supported")) __score0++;
            if (__jsonProps.Contains("serverConfig.require_request_uri_registration")) __score0++;
            if (__jsonProps.Contains("serverConfig.response_modes_supported")) __score0++;
            if (__jsonProps.Contains("serverConfig.response_types_supported")) __score0++;
            if (__jsonProps.Contains("serverConfig.revocation_endpoint")) __score0++;
            if (__jsonProps.Contains("serverConfig.scopes_supported")) __score0++;
            if (__jsonProps.Contains("serverConfig.service_documentation")) __score0++;
            if (__jsonProps.Contains("serverConfig.subject_types_supported")) __score0++;
            if (__jsonProps.Contains("serverConfig.token_endpoint")) __score0++;
            if (__jsonProps.Contains("serverConfig.token_endpoint_auth_methods_supported")) __score0++;
            if (__jsonProps.Contains("serverConfig.token_endpoint_auth_signing_alg_values_supported")) __score0++;
            if (__jsonProps.Contains("serverConfig.userinfo_endpoint")) __score0++;
            if (__jsonProps.Contains("serverUrl")) __score0++;
            if (__jsonProps.Contains("tokenEndpointAuthMethod")) __score0++;
            if (__jsonProps.Contains("userAuthorization")) __score0++;
            if (__jsonProps.Contains("userAuthorization.enabled")) __score0++;
            if (__jsonProps.Contains("userAuthorization.scopes")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("toAdd")) __score1++;
            if (__jsonProps.Contains("toDelete")) __score1++;
            if (__jsonProps.Contains("toUpdate")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("appId")) __score2++;
            if (__jsonProps.Contains("appName")) __score2++;
            if (__jsonProps.Contains("appSlug")) __score2++;
            if (__jsonProps.Contains("clientId")) __score2++;
            if (__jsonProps.Contains("clientSecret")) __score2++;
            if (__jsonProps.Contains("extras")) __score2++;
            if (__jsonProps.Contains("owner")) __score2++;
            if (__jsonProps.Contains("owner.id")) __score2++;
            if (__jsonProps.Contains("owner.name")) __score2++;
            if (__jsonProps.Contains("owner.slug")) __score2++;
            if (__jsonProps.Contains("owner.type")) __score2++;
            if (__jsonProps.Contains("privateKeyPem")) __score2++;
            if (__jsonProps.Contains("webhookSecret")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("appId")) __score3++;
            if (__jsonProps.Contains("appName")) __score3++;
            if (__jsonProps.Contains("appScopes")) __score3++;
            if (__jsonProps.Contains("application")) __score3++;
            if (__jsonProps.Contains("application.clientId")) __score3++;
            if (__jsonProps.Contains("application.createdAt")) __score3++;
            if (__jsonProps.Contains("application.description")) __score3++;
            if (__jsonProps.Contains("application.developer")) __score3++;
            if (__jsonProps.Contains("application.developerUrl")) __score3++;
            if (__jsonProps.Contains("application.distribution")) __score3++;
            if (__jsonProps.Contains("application.id")) __score3++;
            if (__jsonProps.Contains("application.imageUrl")) __score3++;
            if (__jsonProps.Contains("application.name")) __score3++;
            if (__jsonProps.Contains("application.redirectUris")) __score3++;
            if (__jsonProps.Contains("application.updatedAt")) __score3++;
            if (__jsonProps.Contains("application.webhookEnabled")) __score3++;
            if (__jsonProps.Contains("application.webhookResourceTypes")) __score3++;
            if (__jsonProps.Contains("application.webhookUrl")) __score3++;
            if (__jsonProps.Contains("clientId")) __score3++;
            if (__jsonProps.Contains("clientSecret")) __score3++;
            if (__jsonProps.Contains("extras")) __score3++;
            if (__jsonProps.Contains("ownerOrganization")) __score3++;
            if (__jsonProps.Contains("ownerOrganization.id")) __score3++;
            if (__jsonProps.Contains("ownerOrganization.logoUrl")) __score3++;
            if (__jsonProps.Contains("ownerOrganization.name")) __score3++;
            if (__jsonProps.Contains("ownerOrganization.slug")) __score3++;
            if (__jsonProps.Contains("userScopes")) __score3++;
            if (__jsonProps.Contains("webhookSecret")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("consumerKey")) __score4++;
            if (__jsonProps.Contains("consumerSecret")) __score4++;
            if (__jsonProps.Contains("loginHost")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("appId")) __score5++;
            if (__jsonProps.Contains("appName")) __score5++;
            if (__jsonProps.Contains("botScopes")) __score5++;
            if (__jsonProps.Contains("clientId")) __score5++;
            if (__jsonProps.Contains("clientSecret")) __score5++;
            if (__jsonProps.Contains("extras")) __score5++;
            if (__jsonProps.Contains("shortcuts")) __score5++;
            if (__jsonProps.Contains("signingSecret")) __score5++;
            if (__jsonProps.Contains("slackTeam")) __score5++;
            if (__jsonProps.Contains("slackTeam.domain")) __score5++;
            if (__jsonProps.Contains("slackTeam.id")) __score5++;
            if (__jsonProps.Contains("slackTeam.name")) __score5++;
            if (__jsonProps.Contains("slashCommands")) __score5++;
            if (__jsonProps.Contains("userScopes")) __score5++;
            if (__jsonProps.Contains("verificationToken")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("accountIdentifier")) __score6++;
            if (__jsonProps.Contains("defaultSessionRole")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("accountIdentifier")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("apiToken")) __score8++;
            if (__jsonProps.Contains("phoneNumbers")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("apiKeyId")) __score9++;
            if (__jsonProps.Contains("apiSecretKey")) __score9++;
            if (__jsonProps.Contains("phoneNumbers")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("projectSecret")) __score10++;
            if (__jsonProps.Contains("repairWebhook")) __score10++;
            if (__jsonProps.Contains("webhookSecret")) __score10++;
            var __score11 = 0;
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
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }

            global::Vercel.ConnectConnectorUpdateDataTypeOauth? typeOauth = default;
            global::Vercel.ConnectConnectorUpdateDataTypeApiKey? typeApiKey = default;
            global::Vercel.ConnectConnectorUpdateDataTypeGithub? typeGithub = default;
            global::Vercel.ConnectConnectorUpdateDataTypeLinear? typeLinear = default;
            global::Vercel.ConnectConnectorUpdateDataTypeSalesforce? typeSalesforce = default;
            global::Vercel.ConnectConnectorUpdateDataTypeSlack? typeSlack = default;
            global::Vercel.ConnectConnectorUpdateDataTypeSnowflake? typeSnowflake = default;
            global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif? typeSnowflakeWif = default;
            global::Vercel.ConnectConnectorUpdateDataTypeLinq? typeLinq = default;
            global::Vercel.ConnectConnectorUpdateDataTypeSendblue? typeSendblue = default;
            global::Vercel.ConnectConnectorUpdateDataTypePhoton? typePhoton = default;
            object? typeOther = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeOauth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeOauth> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeOauth).Name}");
                        typeOauth = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeApiKey), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeApiKey> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeApiKey).Name}");
                        typeApiKey = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeGithub), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeGithub> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeGithub).Name}");
                        typeGithub = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeLinear), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeLinear> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeLinear).Name}");
                        typeLinear = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSalesforce), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeSalesforce> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeSalesforce).Name}");
                        typeSalesforce = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSlack), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeSlack> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeSlack).Name}");
                        typeSlack = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSnowflake), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeSnowflake> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeSnowflake).Name}");
                        typeSnowflake = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif).Name}");
                        typeSnowflakeWif = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeLinq), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeLinq> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeLinq).Name}");
                        typeLinq = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSendblue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeSendblue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeSendblue).Name}");
                        typeSendblue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypePhoton), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypePhoton> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypePhoton).Name}");
                        typePhoton = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                        typeOther = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (typeOauth == null && typeApiKey == null && typeGithub == null && typeLinear == null && typeSalesforce == null && typeSlack == null && typeSnowflake == null && typeSnowflakeWif == null && typeLinq == null && typeSendblue == null && typePhoton == null && typeOther == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeOauth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeOauth> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeOauth).Name}");
                    typeOauth = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (typeOauth == null && typeApiKey == null && typeGithub == null && typeLinear == null && typeSalesforce == null && typeSlack == null && typeSnowflake == null && typeSnowflakeWif == null && typeLinq == null && typeSendblue == null && typePhoton == null && typeOther == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeApiKey), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeApiKey> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeApiKey).Name}");
                    typeApiKey = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (typeOauth == null && typeApiKey == null && typeGithub == null && typeLinear == null && typeSalesforce == null && typeSlack == null && typeSnowflake == null && typeSnowflakeWif == null && typeLinq == null && typeSendblue == null && typePhoton == null && typeOther == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeGithub), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeGithub> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeGithub).Name}");
                    typeGithub = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (typeOauth == null && typeApiKey == null && typeGithub == null && typeLinear == null && typeSalesforce == null && typeSlack == null && typeSnowflake == null && typeSnowflakeWif == null && typeLinq == null && typeSendblue == null && typePhoton == null && typeOther == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeLinear), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeLinear> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeLinear).Name}");
                    typeLinear = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (typeOauth == null && typeApiKey == null && typeGithub == null && typeLinear == null && typeSalesforce == null && typeSlack == null && typeSnowflake == null && typeSnowflakeWif == null && typeLinq == null && typeSendblue == null && typePhoton == null && typeOther == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSalesforce), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeSalesforce> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeSalesforce).Name}");
                    typeSalesforce = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (typeOauth == null && typeApiKey == null && typeGithub == null && typeLinear == null && typeSalesforce == null && typeSlack == null && typeSnowflake == null && typeSnowflakeWif == null && typeLinq == null && typeSendblue == null && typePhoton == null && typeOther == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSlack), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeSlack> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeSlack).Name}");
                    typeSlack = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (typeOauth == null && typeApiKey == null && typeGithub == null && typeLinear == null && typeSalesforce == null && typeSlack == null && typeSnowflake == null && typeSnowflakeWif == null && typeLinq == null && typeSendblue == null && typePhoton == null && typeOther == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSnowflake), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeSnowflake> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeSnowflake).Name}");
                    typeSnowflake = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (typeOauth == null && typeApiKey == null && typeGithub == null && typeLinear == null && typeSalesforce == null && typeSlack == null && typeSnowflake == null && typeSnowflakeWif == null && typeLinq == null && typeSendblue == null && typePhoton == null && typeOther == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif).Name}");
                    typeSnowflakeWif = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (typeOauth == null && typeApiKey == null && typeGithub == null && typeLinear == null && typeSalesforce == null && typeSlack == null && typeSnowflake == null && typeSnowflakeWif == null && typeLinq == null && typeSendblue == null && typePhoton == null && typeOther == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeLinq), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeLinq> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeLinq).Name}");
                    typeLinq = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (typeOauth == null && typeApiKey == null && typeGithub == null && typeLinear == null && typeSalesforce == null && typeSlack == null && typeSnowflake == null && typeSnowflakeWif == null && typeLinq == null && typeSendblue == null && typePhoton == null && typeOther == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSendblue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeSendblue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeSendblue).Name}");
                    typeSendblue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (typeOauth == null && typeApiKey == null && typeGithub == null && typeLinear == null && typeSalesforce == null && typeSlack == null && typeSnowflake == null && typeSnowflakeWif == null && typeLinq == null && typeSendblue == null && typePhoton == null && typeOther == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypePhoton), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypePhoton> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypePhoton).Name}");
                    typePhoton = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (typeOauth == null && typeApiKey == null && typeGithub == null && typeLinear == null && typeSalesforce == null && typeSlack == null && typeSnowflake == null && typeSnowflakeWif == null && typeLinq == null && typeSendblue == null && typePhoton == null && typeOther == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                    typeOther = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vercel.ConnectConnectorUpdateData(
                typeOauth,

                typeApiKey,

                typeGithub,

                typeLinear,

                typeSalesforce,

                typeSlack,

                typeSnowflake,

                typeSnowflakeWif,

                typeLinq,

                typeSendblue,

                typePhoton,

                typeOther
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.ConnectConnectorUpdateData value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTypeOauth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeOauth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeOauth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeOauth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TypeOauth!, typeInfo);
            }
            else if (value.IsTypeApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeApiKey), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeApiKey?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeApiKey).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TypeApiKey!, typeInfo);
            }
            else if (value.IsTypeGithub)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeGithub), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeGithub?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeGithub).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TypeGithub!, typeInfo);
            }
            else if (value.IsTypeLinear)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeLinear), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeLinear?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeLinear).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TypeLinear!, typeInfo);
            }
            else if (value.IsTypeSalesforce)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSalesforce), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeSalesforce?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeSalesforce).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TypeSalesforce!, typeInfo);
            }
            else if (value.IsTypeSlack)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSlack), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeSlack?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeSlack).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TypeSlack!, typeInfo);
            }
            else if (value.IsTypeSnowflake)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSnowflake), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeSnowflake?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeSnowflake).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TypeSnowflake!, typeInfo);
            }
            else if (value.IsTypeSnowflakeWif)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TypeSnowflakeWif!, typeInfo);
            }
            else if (value.IsTypeLinq)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeLinq), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeLinq?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeLinq).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TypeLinq!, typeInfo);
            }
            else if (value.IsTypeSendblue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSendblue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypeSendblue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypeSendblue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TypeSendblue!, typeInfo);
            }
            else if (value.IsTypePhoton)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorUpdateDataTypePhoton), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorUpdateDataTypePhoton?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorUpdateDataTypePhoton).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TypePhoton!, typeInfo);
            }
            else if (value.IsTypeOther)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TypeOther!, typeInfo);
            }
        }
    }
}