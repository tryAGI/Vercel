#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public class ConnectConnectorCreateDataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.ConnectConnectorCreateData>
    {
        /// <inheritdoc />
        public override global::Vercel.ConnectConnectorCreateData Read(
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
            if (__jsonProps.Contains("serviceUrls")) __score1++;
            if (__jsonProps.Contains("subjectType")) __score1++;
            if (__jsonProps.Contains("values")) __score1++;
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
            if (__jsonProps.Contains("apiToken")) __score4++;
            if (__jsonProps.Contains("phoneNumbers")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("consumerKey")) __score5++;
            if (__jsonProps.Contains("consumerSecret")) __score5++;
            if (__jsonProps.Contains("loginHost")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("apiKeyId")) __score6++;
            if (__jsonProps.Contains("apiSecretKey")) __score6++;
            if (__jsonProps.Contains("phoneNumbers")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("appId")) __score7++;
            if (__jsonProps.Contains("appName")) __score7++;
            if (__jsonProps.Contains("botScopes")) __score7++;
            if (__jsonProps.Contains("clientId")) __score7++;
            if (__jsonProps.Contains("clientSecret")) __score7++;
            if (__jsonProps.Contains("extras")) __score7++;
            if (__jsonProps.Contains("signingSecret")) __score7++;
            if (__jsonProps.Contains("slackTeam")) __score7++;
            if (__jsonProps.Contains("slackTeam.domain")) __score7++;
            if (__jsonProps.Contains("slackTeam.id")) __score7++;
            if (__jsonProps.Contains("slackTeam.name")) __score7++;
            if (__jsonProps.Contains("userScopes")) __score7++;
            if (__jsonProps.Contains("verificationToken")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("accountIdentifier")) __score8++;
            if (__jsonProps.Contains("clientName")) __score8++;
            if (__jsonProps.Contains("defaultSessionRole")) __score8++;
            if (__jsonProps.Contains("extras")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("accountIdentifier")) __score9++;
            if (__jsonProps.Contains("clientName")) __score9++;
            if (__jsonProps.Contains("extras")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("projectId")) __score10++;
            if (__jsonProps.Contains("projectSecret")) __score10++;
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

            global::Vercel.ConnectConnectorCreateDataTypeOauth? typeOauth = default;
            global::Vercel.ConnectConnectorCreateDataTypeApiKey? typeApiKey = default;
            global::Vercel.ConnectConnectorCreateDataTypeGithub? typeGithub = default;
            global::Vercel.ConnectConnectorCreateDataTypeLinear? typeLinear = default;
            global::Vercel.ConnectConnectorCreateDataTypeLinq? typeLinq = default;
            global::Vercel.ConnectConnectorCreateDataTypeSalesforce? typeSalesforce = default;
            global::Vercel.ConnectConnectorCreateDataTypeSendblue? typeSendblue = default;
            global::Vercel.ConnectConnectorCreateDataTypeSlack? typeSlack = default;
            global::Vercel.ConnectConnectorCreateDataTypeSnowflake? typeSnowflake = default;
            global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif? typeSnowflakeWif = default;
            global::Vercel.ConnectConnectorCreateDataTypePhoton? typePhoton = default;
            object? typeOther = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeOauth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeOauth> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeOauth).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeApiKey), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeApiKey> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeApiKey).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeGithub), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeGithub> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeGithub).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeLinear), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeLinear> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeLinear).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeLinq), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeLinq> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeLinq).Name}");
                        typeLinq = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeSalesforce), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeSalesforce> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeSalesforce).Name}");
                        typeSalesforce = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeSendblue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeSendblue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeSendblue).Name}");
                        typeSendblue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeSlack), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeSlack> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeSlack).Name}");
                        typeSlack = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeSnowflake), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeSnowflake> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeSnowflake).Name}");
                        typeSnowflake = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif).Name}");
                        typeSnowflakeWif = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypePhoton), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypePhoton> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypePhoton).Name}");
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

            if (typeOauth == null && typeApiKey == null && typeGithub == null && typeLinear == null && typeLinq == null && typeSalesforce == null && typeSendblue == null && typeSlack == null && typeSnowflake == null && typeSnowflakeWif == null && typePhoton == null && typeOther == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeOauth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeOauth> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeOauth).Name}");
                    typeOauth = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (typeOauth == null && typeApiKey == null && typeGithub == null && typeLinear == null && typeLinq == null && typeSalesforce == null && typeSendblue == null && typeSlack == null && typeSnowflake == null && typeSnowflakeWif == null && typePhoton == null && typeOther == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeApiKey), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeApiKey> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeApiKey).Name}");
                    typeApiKey = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (typeOauth == null && typeApiKey == null && typeGithub == null && typeLinear == null && typeLinq == null && typeSalesforce == null && typeSendblue == null && typeSlack == null && typeSnowflake == null && typeSnowflakeWif == null && typePhoton == null && typeOther == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeGithub), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeGithub> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeGithub).Name}");
                    typeGithub = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (typeOauth == null && typeApiKey == null && typeGithub == null && typeLinear == null && typeLinq == null && typeSalesforce == null && typeSendblue == null && typeSlack == null && typeSnowflake == null && typeSnowflakeWif == null && typePhoton == null && typeOther == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeLinear), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeLinear> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeLinear).Name}");
                    typeLinear = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (typeOauth == null && typeApiKey == null && typeGithub == null && typeLinear == null && typeLinq == null && typeSalesforce == null && typeSendblue == null && typeSlack == null && typeSnowflake == null && typeSnowflakeWif == null && typePhoton == null && typeOther == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeLinq), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeLinq> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeLinq).Name}");
                    typeLinq = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (typeOauth == null && typeApiKey == null && typeGithub == null && typeLinear == null && typeLinq == null && typeSalesforce == null && typeSendblue == null && typeSlack == null && typeSnowflake == null && typeSnowflakeWif == null && typePhoton == null && typeOther == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeSalesforce), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeSalesforce> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeSalesforce).Name}");
                    typeSalesforce = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (typeOauth == null && typeApiKey == null && typeGithub == null && typeLinear == null && typeLinq == null && typeSalesforce == null && typeSendblue == null && typeSlack == null && typeSnowflake == null && typeSnowflakeWif == null && typePhoton == null && typeOther == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeSendblue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeSendblue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeSendblue).Name}");
                    typeSendblue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (typeOauth == null && typeApiKey == null && typeGithub == null && typeLinear == null && typeLinq == null && typeSalesforce == null && typeSendblue == null && typeSlack == null && typeSnowflake == null && typeSnowflakeWif == null && typePhoton == null && typeOther == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeSlack), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeSlack> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeSlack).Name}");
                    typeSlack = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (typeOauth == null && typeApiKey == null && typeGithub == null && typeLinear == null && typeLinq == null && typeSalesforce == null && typeSendblue == null && typeSlack == null && typeSnowflake == null && typeSnowflakeWif == null && typePhoton == null && typeOther == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeSnowflake), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeSnowflake> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeSnowflake).Name}");
                    typeSnowflake = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (typeOauth == null && typeApiKey == null && typeGithub == null && typeLinear == null && typeLinq == null && typeSalesforce == null && typeSendblue == null && typeSlack == null && typeSnowflake == null && typeSnowflakeWif == null && typePhoton == null && typeOther == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif).Name}");
                    typeSnowflakeWif = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (typeOauth == null && typeApiKey == null && typeGithub == null && typeLinear == null && typeLinq == null && typeSalesforce == null && typeSendblue == null && typeSlack == null && typeSnowflake == null && typeSnowflakeWif == null && typePhoton == null && typeOther == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypePhoton), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypePhoton> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypePhoton).Name}");
                    typePhoton = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (typeOauth == null && typeApiKey == null && typeGithub == null && typeLinear == null && typeLinq == null && typeSalesforce == null && typeSendblue == null && typeSlack == null && typeSnowflake == null && typeSnowflakeWif == null && typePhoton == null && typeOther == null)
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

            var __value = new global::Vercel.ConnectConnectorCreateData(
                typeOauth,

                typeApiKey,

                typeGithub,

                typeLinear,

                typeLinq,

                typeSalesforce,

                typeSendblue,

                typeSlack,

                typeSnowflake,

                typeSnowflakeWif,

                typePhoton,

                typeOther
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.ConnectConnectorCreateData value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTypeOauth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeOauth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeOauth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeOauth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TypeOauth!, typeInfo);
            }
            else if (value.IsTypeApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeApiKey), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeApiKey?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeApiKey).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TypeApiKey!, typeInfo);
            }
            else if (value.IsTypeGithub)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeGithub), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeGithub?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeGithub).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TypeGithub!, typeInfo);
            }
            else if (value.IsTypeLinear)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeLinear), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeLinear?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeLinear).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TypeLinear!, typeInfo);
            }
            else if (value.IsTypeLinq)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeLinq), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeLinq?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeLinq).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TypeLinq!, typeInfo);
            }
            else if (value.IsTypeSalesforce)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeSalesforce), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeSalesforce?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeSalesforce).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TypeSalesforce!, typeInfo);
            }
            else if (value.IsTypeSendblue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeSendblue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeSendblue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeSendblue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TypeSendblue!, typeInfo);
            }
            else if (value.IsTypeSlack)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeSlack), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeSlack?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeSlack).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TypeSlack!, typeInfo);
            }
            else if (value.IsTypeSnowflake)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeSnowflake), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeSnowflake?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeSnowflake).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TypeSnowflake!, typeInfo);
            }
            else if (value.IsTypeSnowflakeWif)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TypeSnowflakeWif!, typeInfo);
            }
            else if (value.IsTypePhoton)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vercel.ConnectConnectorCreateDataTypePhoton), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vercel.ConnectConnectorCreateDataTypePhoton?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vercel.ConnectConnectorCreateDataTypePhoton).Name}");
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