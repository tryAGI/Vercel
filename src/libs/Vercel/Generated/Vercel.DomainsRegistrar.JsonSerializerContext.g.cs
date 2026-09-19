
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.DomainTooShort, global::Vercel.OrderTooExpensive, global::Vercel.InvalidAdditionalContactInfo, global::Vercel.AdditionalContactInfoRequired, global::Vercel.ExpectedPriceMismatch, global::Vercel.DomainNotAvailable, global::Vercel.EmojiTldNotSupported, global::Vercel.LanguageCodeRequired, global::Vercel.TldNotSupported, global::Vercel.HttpApiDecodeError>), TypeInfoPropertyName = "HttpApiDecodeError_c52ca4da997e19f4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.DomainTooShort, global::Vercel.OrderTooExpensive, global::Vercel.TooManyDomains, global::Vercel.InvalidAdditionalContactInfo, global::Vercel.AdditionalContactInfoRequired, global::Vercel.DuplicateDomains, global::Vercel.ExpectedPriceMismatch, global::Vercel.DomainNotAvailable, global::Vercel.EmojiTldNotSupported, global::Vercel.LanguageCodeRequired, global::Vercel.TldNotSupported, global::Vercel.HttpApiDecodeError>), TypeInfoPropertyName = "HttpApiDecodeError_a54a377387895af9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.BadRequest, global::Vercel.DomainAlreadyOwned, global::Vercel.DomainTooShort, global::Vercel.DNSSECEnabled, global::Vercel.ExpectedPriceMismatch, global::Vercel.DomainNotAvailable, global::Vercel.TldNotSupported, global::Vercel.HttpApiDecodeError>), TypeInfoPropertyName = "HttpApiDecodeError_8133517629ad14dc")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.AnyOf<global::Vercel.GetOrderResponseDomainVariant1ErrorVariant1, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant2, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant3, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant4, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant5, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant6, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant7, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant8, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant9, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10>?, global::Vercel.GetOrderResponseDomainVariant1Error>), TypeInfoPropertyName = "GetOrderResponseDomainVariant1Error_c28f09d51d681be1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.GetOrderResponseDomainVariant1ErrorVariant1, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant2, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant3, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant4, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant5, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant6, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant7, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant8, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant9, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10>), TypeInfoPropertyName = "GetOrderResponseDomainVariant1ErrorVariant10_a9f4cb0d91598ca4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.AnyOf<global::Vercel.GetOrderResponseDomainVariant2ErrorVariant1, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant2, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant3, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant4, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant5, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant6, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant7, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant8, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant9, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant10>?, global::Vercel.GetOrderResponseDomainVariant2Error>), TypeInfoPropertyName = "GetOrderResponseDomainVariant2Error_c4ae4b401e5bc310")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.GetOrderResponseDomainVariant2ErrorVariant1, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant2, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant3, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant4, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant5, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant6, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant7, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant8, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant9, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant10>), TypeInfoPropertyName = "GetOrderResponseDomainVariant2ErrorVariant10_2e56d9b0e4244953")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.AnyOf<global::Vercel.GetOrderResponseDomainVariant3ErrorVariant1, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant2, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant3, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant4, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant5, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant6, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant7, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant8, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant9, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant10>?, global::Vercel.GetOrderResponseDomainVariant3Error>), TypeInfoPropertyName = "GetOrderResponseDomainVariant3Error_a96fd77dba0b6317")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.GetOrderResponseDomainVariant3ErrorVariant1, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant2, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant3, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant4, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant5, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant6, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant7, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant8, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant9, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant10>), TypeInfoPropertyName = "GetOrderResponseDomainVariant3ErrorVariant10_f457edcc5891958a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.AnyOf<global::Vercel.GetOrderResponseErrorVariant1, global::Vercel.GetOrderResponseErrorVariant2, global::Vercel.GetOrderResponseErrorVariant3, global::Vercel.GetOrderResponseErrorVariant4, global::Vercel.GetOrderResponseErrorVariant5, global::Vercel.GetOrderResponseErrorVariant6>?, global::Vercel.GetOrderResponseError>), TypeInfoPropertyName = "GetOrderResponseError_d0300022924e916a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.GetOrderResponseErrorVariant1, global::Vercel.GetOrderResponseErrorVariant2, global::Vercel.GetOrderResponseErrorVariant3, global::Vercel.GetOrderResponseErrorVariant4, global::Vercel.GetOrderResponseErrorVariant5, global::Vercel.GetOrderResponseErrorVariant6>), TypeInfoPropertyName = "GetOrderResponseErrorVariant6_8a28b52e4c22267e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.DomainTooShort, global::Vercel.OrderTooExpensive, global::Vercel.InvalidAdditionalContactInfo, global::Vercel.AdditionalContactInfoRequired, global::Vercel.ExpectedPriceMismatch, global::Vercel.DomainNotAvailable, global::Vercel.EmojiTldNotSupported, global::Vercel.LanguageCodeRequired, global::Vercel.TldNotSupported, global::Vercel.HttpApiDecodeError>?), TypeInfoPropertyName = "HttpApiDecodeError_622adb2eec2140a8")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.DomainTooShort, global::Vercel.OrderTooExpensive, global::Vercel.TooManyDomains, global::Vercel.InvalidAdditionalContactInfo, global::Vercel.AdditionalContactInfoRequired, global::Vercel.DuplicateDomains, global::Vercel.ExpectedPriceMismatch, global::Vercel.DomainNotAvailable, global::Vercel.EmojiTldNotSupported, global::Vercel.LanguageCodeRequired, global::Vercel.TldNotSupported, global::Vercel.HttpApiDecodeError>?), TypeInfoPropertyName = "HttpApiDecodeError_21de2c66648ab6ca")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.BadRequest, global::Vercel.DomainAlreadyOwned, global::Vercel.DomainTooShort, global::Vercel.DNSSECEnabled, global::Vercel.ExpectedPriceMismatch, global::Vercel.DomainNotAvailable, global::Vercel.TldNotSupported, global::Vercel.HttpApiDecodeError>?), TypeInfoPropertyName = "HttpApiDecodeError_dabc7b432af58837")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.BadRequest, global::Vercel.DomainTooShort, global::Vercel.DomainNotRegistered, global::Vercel.ExpectedPriceMismatch, global::Vercel.DomainNotAvailable, global::Vercel.TldNotSupported, global::Vercel.HttpApiDecodeError>?), TypeInfoPropertyName = "HttpApiDecodeError_e5b73838d134854f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.AnyOf<global::Vercel.GetOrderResponseDomainVariant1ErrorVariant1, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant2, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant3, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant4, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant5, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant6, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant7, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant8, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant9, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10>?, global::Vercel.GetOrderResponseDomainVariant1Error>?), TypeInfoPropertyName = "GetOrderResponseDomainVariant1Error_ed7c999c05a0fe0a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.GetOrderResponseDomainVariant1ErrorVariant1, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant2, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant3, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant4, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant5, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant6, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant7, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant8, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant9, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10>?), TypeInfoPropertyName = "GetOrderResponseDomainVariant1ErrorVariant10_8de24c62822d27e1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.AnyOf<global::Vercel.GetOrderResponseDomainVariant2ErrorVariant1, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant2, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant3, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant4, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant5, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant6, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant7, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant8, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant9, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant10>?, global::Vercel.GetOrderResponseDomainVariant2Error>?), TypeInfoPropertyName = "GetOrderResponseDomainVariant2Error_f357c31b41932774")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.GetOrderResponseDomainVariant2ErrorVariant1, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant2, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant3, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant4, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant5, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant6, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant7, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant8, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant9, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant10>?), TypeInfoPropertyName = "GetOrderResponseDomainVariant2ErrorVariant10_754c0a4b7b4a096b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.AnyOf<global::Vercel.GetOrderResponseDomainVariant3ErrorVariant1, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant2, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant3, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant4, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant5, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant6, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant7, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant8, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant9, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant10>?, global::Vercel.GetOrderResponseDomainVariant3Error>?), TypeInfoPropertyName = "GetOrderResponseDomainVariant3Error_daf66779037e4b1b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.GetOrderResponseDomainVariant3ErrorVariant1, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant2, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant3, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant4, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant5, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant6, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant7, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant8, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant9, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant10>?), TypeInfoPropertyName = "GetOrderResponseDomainVariant3ErrorVariant10_b471cb1871bf25c2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.AnyOf<global::Vercel.GetOrderResponseErrorVariant1, global::Vercel.GetOrderResponseErrorVariant2, global::Vercel.GetOrderResponseErrorVariant3, global::Vercel.GetOrderResponseErrorVariant4, global::Vercel.GetOrderResponseErrorVariant5, global::Vercel.GetOrderResponseErrorVariant6>?, global::Vercel.GetOrderResponseError>?), TypeInfoPropertyName = "GetOrderResponseError_5c21c24127720878")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.GetOrderResponseErrorVariant1, global::Vercel.GetOrderResponseErrorVariant2, global::Vercel.GetOrderResponseErrorVariant3, global::Vercel.GetOrderResponseErrorVariant4, global::Vercel.GetOrderResponseErrorVariant5, global::Vercel.GetOrderResponseErrorVariant6>?), TypeInfoPropertyName = "GetOrderResponseErrorVariant6_5ac84ebdbc9b91ae")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.HttpApiDecodeError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.Issue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.Issue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.PropertyKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.PropertyKey), TypeInfoPropertyName = "PropertyKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.PropertyKeyVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.PropertyKeyVariant3Tag), TypeInfoPropertyName = "PropertyKeyVariant3Tag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TooManyRequests))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TooManyRequestsCode), TypeInfoPropertyName = "TooManyRequestsCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TooManyRequestsRetryAfter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TooManyRequestsLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.Unauthorized))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UnauthorizedCode), TypeInfoPropertyName = "UnauthorizedCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.NotAuthorizedForScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.NotAuthorizedForScopeCode), TypeInfoPropertyName = "NotAuthorizedForScopeCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.InternalServerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.InternalServerErrorCode), TypeInfoPropertyName = "InternalServerErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TldNotSupported))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TldNotSupportedCode), TypeInfoPropertyName = "TldNotSupportedCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.NotFound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.NotFoundCode), TypeInfoPropertyName = "NotFoundCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DomainTooShort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DomainTooShortCode), TypeInfoPropertyName = "DomainTooShortCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.BadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.BadRequestCode), TypeInfoPropertyName = "BadRequestCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DomainNotRegistered))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DomainNotRegisteredCode), TypeInfoPropertyName = "DomainNotRegisteredCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DomainNotFound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DomainNotFoundCode), TypeInfoPropertyName = "DomainNotFoundCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DomainCannotBeTransferedOutUntil))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DomainCannotBeTransferedOutUntilCode), TypeInfoPropertyName = "DomainCannotBeTransferedOutUntilCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.Forbidden))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ForbiddenCode), TypeInfoPropertyName = "ForbiddenCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.LanguageCodeRequired))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.LanguageCodeRequiredCode), TypeInfoPropertyName = "LanguageCodeRequiredCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EmojiTldNotSupported))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EmojiTldNotSupportedCode), TypeInfoPropertyName = "EmojiTldNotSupportedCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DomainNotAvailable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DomainNotAvailableCode), TypeInfoPropertyName = "DomainNotAvailableCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ExpectedPriceMismatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ExpectedPriceMismatchCode), TypeInfoPropertyName = "ExpectedPriceMismatchCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AdditionalContactInfoRequired))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AdditionalContactInfoRequiredCode), TypeInfoPropertyName = "AdditionalContactInfoRequiredCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.InvalidAdditionalContactInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.InvalidAdditionalContactInfoCode), TypeInfoPropertyName = "InvalidAdditionalContactInfoCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OrderTooExpensive))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OrderTooExpensiveCode), TypeInfoPropertyName = "OrderTooExpensiveCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DuplicateDomains))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DuplicateDomainsCode), TypeInfoPropertyName = "DuplicateDomainsCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TooManyDomains))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TooManyDomainsCode), TypeInfoPropertyName = "TooManyDomainsCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DNSSECEnabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DNSSECEnabledCode), TypeInfoPropertyName = "DNSSECEnabledCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DomainAlreadyOwned))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DomainAlreadyOwnedCode), TypeInfoPropertyName = "DomainAlreadyOwnedCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DomainNotRenewable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DomainNotRenewableCode), TypeInfoPropertyName = "DomainNotRenewableCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DomainAlreadyRenewing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DomainAlreadyRenewingCode), TypeInfoPropertyName = "DomainAlreadyRenewingCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ContactVerified))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ContactPendingVerification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.BoughtTooRecently))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.BoughtTooRecentlyCode), TypeInfoPropertyName = "BoughtTooRecentlyCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetBulkPriceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetBulkAvailabilityRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SearchDomainsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.BuySingleDomainRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.BuySingleDomainRequestContactInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.BuyDomainsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.BuyDomainsRequestDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.BuyDomainsRequestDomain))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.BuyDomainsRequestContactInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TransferInDomainRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TransferInDomainRequestContactInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RenewDomainRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RenewDomainRequestContactInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateDomainAutoRenewRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateDomainNameserversRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<double?, string>), TypeInfoPropertyName = "AnyOfDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetTldResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.TldNotSupported, global::Vercel.HttpApiDecodeError>), TypeInfoPropertyName = "AnyOfTldNotSupportedHttpApiDecodeError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetTldPriceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetDomainAvailabilityResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetDomainPriceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.BadRequest, global::Vercel.DomainTooShort, global::Vercel.TldNotSupported, global::Vercel.HttpApiDecodeError>), TypeInfoPropertyName = "AnyOfBadRequestDomainTooShortTldNotSupportedHttpApiDecodeError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetBulkPriceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetBulkPriceResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetBulkPriceResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetBulkAvailabilityResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetBulkAvailabilityResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetBulkAvailabilityResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SearchDomainsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.SearchDomainsResponseResultVariant1, global::Vercel.SearchDomainsResponseResultVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.SearchDomainsResponseResultVariant1, global::Vercel.SearchDomainsResponseResultVariant2>), TypeInfoPropertyName = "AnyOfSearchDomainsResponseResultVariant1SearchDomainsResponseResultVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SearchDomainsResponseResultVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SearchDomainsResponseResultVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.BadRequest, global::Vercel.HttpApiDecodeError>), TypeInfoPropertyName = "AnyOfBadRequestHttpApiDecodeError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetDomainAuthCodeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.DomainNotRegistered, global::Vercel.HttpApiDecodeError>), TypeInfoPropertyName = "AnyOfDomainNotRegisteredHttpApiDecodeError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.Forbidden, global::Vercel.NotAuthorizedForScope>), TypeInfoPropertyName = "AnyOfForbiddenNotAuthorizedForScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.BuySingleDomainResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.BuySingleDomainResponseLinks2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.BuySingleDomainResponseLinks2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.BuySingleDomainResponseLinksMethod), TypeInfoPropertyName = "BuySingleDomainResponseLinksMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.BuyDomainsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.BuyDomainsResponseLinks2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.BuyDomainsResponseLinks2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.BuyDomainsResponseLinksMethod), TypeInfoPropertyName = "BuyDomainsResponseLinksMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TransferInDomainResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.TransferInDomainResponseLinks2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TransferInDomainResponseLinks2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TransferInDomainResponseLinksMethod), TypeInfoPropertyName = "TransferInDomainResponseLinksMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetDomainTransferInResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetDomainTransferInResponseStatus), TypeInfoPropertyName = "GetDomainTransferInResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RenewDomainResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.RenewDomainResponseLinks2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RenewDomainResponseLinks2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RenewDomainResponseLinksMethod), TypeInfoPropertyName = "RenewDomainResponseLinksMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.BadRequest, global::Vercel.DomainTooShort, global::Vercel.DomainNotRegistered, global::Vercel.ExpectedPriceMismatch, global::Vercel.DomainNotAvailable, global::Vercel.TldNotSupported, global::Vercel.HttpApiDecodeError>), TypeInfoPropertyName = "HttpApiDecodeError_3a03406836c566c6")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.DomainAlreadyRenewing, global::Vercel.DomainNotRenewable, global::Vercel.DomainNotRegistered, global::Vercel.HttpApiDecodeError>), TypeInfoPropertyName = "AnyOfDomainAlreadyRenewingDomainNotRenewableDomainNotRegisteredHttpApiDecodeError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.ContactVerified, global::Vercel.ContactPendingVerification>), TypeInfoPropertyName = "AnyOfContactVerifiedContactPendingVerification2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.BoughtTooRecently, global::Vercel.DomainNotRegistered, global::Vercel.HttpApiDecodeError>), TypeInfoPropertyName = "AnyOfBoughtTooRecentlyDomainNotRegisteredHttpApiDecodeError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.GetOrderResponseDomainVariant1, global::Vercel.GetOrderResponseDomainVariant2, global::Vercel.GetOrderResponseDomainVariant3>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.GetOrderResponseDomainVariant1, global::Vercel.GetOrderResponseDomainVariant2, global::Vercel.GetOrderResponseDomainVariant3>), TypeInfoPropertyName = "AnyOfGetOrderResponseDomainVariant1GetOrderResponseDomainVariant2GetOrderResponseDomainVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1PurchaseType), TypeInfoPropertyName = "GetOrderResponseDomainVariant1PurchaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1Status), TypeInfoPropertyName = "GetOrderResponseDomainVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant1Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant1ErrorVariant1Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant1Details))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant2Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant1ErrorVariant2Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant2Details))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant3Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant1ErrorVariant3Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant4Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant1ErrorVariant4Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant5Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant1ErrorVariant5Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant6Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant1ErrorVariant6Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant6Details))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant7Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant1ErrorVariant7Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant8Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant1ErrorVariant8Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant9Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant1ErrorVariant9Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant1ErrorVariant10Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10Details))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField), TypeInfoPropertyName = "GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2PurchaseType), TypeInfoPropertyName = "GetOrderResponseDomainVariant2PurchaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2Status), TypeInfoPropertyName = "GetOrderResponseDomainVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant1Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant2ErrorVariant1Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant1Details))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant2Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant2ErrorVariant2Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant2Details))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant3Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant2ErrorVariant3Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant4Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant2ErrorVariant4Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant5Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant2ErrorVariant5Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant6Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant2ErrorVariant6Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant6Details))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant7Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant2ErrorVariant7Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant8Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant2ErrorVariant8Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant9Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant2ErrorVariant9Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant10Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant2ErrorVariant10Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant10Details))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField), TypeInfoPropertyName = "GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3PurchaseType), TypeInfoPropertyName = "GetOrderResponseDomainVariant3PurchaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3Status), TypeInfoPropertyName = "GetOrderResponseDomainVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant1Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant3ErrorVariant1Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant1Details))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant2Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant3ErrorVariant2Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant2Details))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant3Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant3ErrorVariant3Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant4Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant3ErrorVariant4Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant5Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant3ErrorVariant5Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant6Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant3ErrorVariant6Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant6Details))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant7Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant3ErrorVariant7Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant8Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant3ErrorVariant8Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant9Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant3ErrorVariant9Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant10Code), TypeInfoPropertyName = "GetOrderResponseDomainVariant3ErrorVariant10Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant10Details))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField), TypeInfoPropertyName = "GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseStatus), TypeInfoPropertyName = "GetOrderResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseErrorVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseErrorVariant1Code), TypeInfoPropertyName = "GetOrderResponseErrorVariant1Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseErrorVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseErrorVariant2Code), TypeInfoPropertyName = "GetOrderResponseErrorVariant2Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseErrorVariant2Details))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetOrderResponseErrorVariant2DetailsTld>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseErrorVariant2DetailsTld))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseErrorVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseErrorVariant3Code), TypeInfoPropertyName = "GetOrderResponseErrorVariant3Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseErrorVariant3Details))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseErrorVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseErrorVariant4Code), TypeInfoPropertyName = "GetOrderResponseErrorVariant4Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseErrorVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseErrorVariant5Code), TypeInfoPropertyName = "GetOrderResponseErrorVariant5Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseErrorVariant5Details))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseErrorVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseErrorVariant6Code), TypeInfoPropertyName = "GetOrderResponseErrorVariant6Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.NotAuthorizedForScope, global::Vercel.Forbidden>), TypeInfoPropertyName = "AnyOfNotAuthorizedForScopeForbidden2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.PropertyKey?), TypeInfoPropertyName = "NullablePropertyKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.PropertyKeyVariant3Tag?), TypeInfoPropertyName = "NullablePropertyKeyVariant3Tag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TooManyRequestsCode?), TypeInfoPropertyName = "NullableTooManyRequestsCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UnauthorizedCode?), TypeInfoPropertyName = "NullableUnauthorizedCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.NotAuthorizedForScopeCode?), TypeInfoPropertyName = "NullableNotAuthorizedForScopeCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.InternalServerErrorCode?), TypeInfoPropertyName = "NullableInternalServerErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TldNotSupportedCode?), TypeInfoPropertyName = "NullableTldNotSupportedCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.NotFoundCode?), TypeInfoPropertyName = "NullableNotFoundCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DomainTooShortCode?), TypeInfoPropertyName = "NullableDomainTooShortCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.BadRequestCode?), TypeInfoPropertyName = "NullableBadRequestCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DomainNotRegisteredCode?), TypeInfoPropertyName = "NullableDomainNotRegisteredCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DomainNotFoundCode?), TypeInfoPropertyName = "NullableDomainNotFoundCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DomainCannotBeTransferedOutUntilCode?), TypeInfoPropertyName = "NullableDomainCannotBeTransferedOutUntilCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ForbiddenCode?), TypeInfoPropertyName = "NullableForbiddenCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.LanguageCodeRequiredCode?), TypeInfoPropertyName = "NullableLanguageCodeRequiredCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EmojiTldNotSupportedCode?), TypeInfoPropertyName = "NullableEmojiTldNotSupportedCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DomainNotAvailableCode?), TypeInfoPropertyName = "NullableDomainNotAvailableCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ExpectedPriceMismatchCode?), TypeInfoPropertyName = "NullableExpectedPriceMismatchCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AdditionalContactInfoRequiredCode?), TypeInfoPropertyName = "NullableAdditionalContactInfoRequiredCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.InvalidAdditionalContactInfoCode?), TypeInfoPropertyName = "NullableInvalidAdditionalContactInfoCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OrderTooExpensiveCode?), TypeInfoPropertyName = "NullableOrderTooExpensiveCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DuplicateDomainsCode?), TypeInfoPropertyName = "NullableDuplicateDomainsCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TooManyDomainsCode?), TypeInfoPropertyName = "NullableTooManyDomainsCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DNSSECEnabledCode?), TypeInfoPropertyName = "NullableDNSSECEnabledCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DomainAlreadyOwnedCode?), TypeInfoPropertyName = "NullableDomainAlreadyOwnedCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DomainNotRenewableCode?), TypeInfoPropertyName = "NullableDomainNotRenewableCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DomainAlreadyRenewingCode?), TypeInfoPropertyName = "NullableDomainAlreadyRenewingCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.BoughtTooRecentlyCode?), TypeInfoPropertyName = "NullableBoughtTooRecentlyCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<double?, string>?), TypeInfoPropertyName = "NullableAnyOfDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.TldNotSupported, global::Vercel.HttpApiDecodeError>?), TypeInfoPropertyName = "NullableAnyOfTldNotSupportedHttpApiDecodeError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.BadRequest, global::Vercel.DomainTooShort, global::Vercel.TldNotSupported, global::Vercel.HttpApiDecodeError>?), TypeInfoPropertyName = "NullableAnyOfBadRequestDomainTooShortTldNotSupportedHttpApiDecodeError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.SearchDomainsResponseResultVariant1, global::Vercel.SearchDomainsResponseResultVariant2>?), TypeInfoPropertyName = "NullableAnyOfSearchDomainsResponseResultVariant1SearchDomainsResponseResultVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.BadRequest, global::Vercel.HttpApiDecodeError>?), TypeInfoPropertyName = "NullableAnyOfBadRequestHttpApiDecodeError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.DomainNotRegistered, global::Vercel.HttpApiDecodeError>?), TypeInfoPropertyName = "NullableAnyOfDomainNotRegisteredHttpApiDecodeError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.Forbidden, global::Vercel.NotAuthorizedForScope>?), TypeInfoPropertyName = "NullableAnyOfForbiddenNotAuthorizedForScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.BuySingleDomainResponseLinksMethod?), TypeInfoPropertyName = "NullableBuySingleDomainResponseLinksMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.BuyDomainsResponseLinksMethod?), TypeInfoPropertyName = "NullableBuyDomainsResponseLinksMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.TransferInDomainResponseLinksMethod?), TypeInfoPropertyName = "NullableTransferInDomainResponseLinksMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetDomainTransferInResponseStatus?), TypeInfoPropertyName = "NullableGetDomainTransferInResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RenewDomainResponseLinksMethod?), TypeInfoPropertyName = "NullableRenewDomainResponseLinksMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.DomainAlreadyRenewing, global::Vercel.DomainNotRenewable, global::Vercel.DomainNotRegistered, global::Vercel.HttpApiDecodeError>?), TypeInfoPropertyName = "NullableAnyOfDomainAlreadyRenewingDomainNotRenewableDomainNotRegisteredHttpApiDecodeError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.ContactVerified, global::Vercel.ContactPendingVerification>?), TypeInfoPropertyName = "NullableAnyOfContactVerifiedContactPendingVerification2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.BoughtTooRecently, global::Vercel.DomainNotRegistered, global::Vercel.HttpApiDecodeError>?), TypeInfoPropertyName = "NullableAnyOfBoughtTooRecentlyDomainNotRegisteredHttpApiDecodeError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.GetOrderResponseDomainVariant1, global::Vercel.GetOrderResponseDomainVariant2, global::Vercel.GetOrderResponseDomainVariant3>?), TypeInfoPropertyName = "NullableAnyOfGetOrderResponseDomainVariant1GetOrderResponseDomainVariant2GetOrderResponseDomainVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1PurchaseType?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant1PurchaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1Status?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant1Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant1ErrorVariant1Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant2Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant1ErrorVariant2Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant3Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant1ErrorVariant3Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant4Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant1ErrorVariant4Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant5Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant1ErrorVariant5Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant6Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant1ErrorVariant6Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant7Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant1ErrorVariant7Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant8Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant1ErrorVariant8Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant9Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant1ErrorVariant9Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant1ErrorVariant10Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2PurchaseType?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant2PurchaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2Status?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant1Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant2ErrorVariant1Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant2Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant2ErrorVariant2Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant3Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant2ErrorVariant3Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant4Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant2ErrorVariant4Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant5Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant2ErrorVariant5Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant6Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant2ErrorVariant6Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant7Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant2ErrorVariant7Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant8Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant2ErrorVariant8Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant9Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant2ErrorVariant9Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant10Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant2ErrorVariant10Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3PurchaseType?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant3PurchaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3Status?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant1Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant3ErrorVariant1Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant2Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant3ErrorVariant2Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant3Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant3ErrorVariant3Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant4Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant3ErrorVariant4Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant5Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant3ErrorVariant5Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant6Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant3ErrorVariant6Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant7Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant3ErrorVariant7Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant8Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant3ErrorVariant8Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant9Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant3ErrorVariant9Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant10Code?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant3ErrorVariant10Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField?), TypeInfoPropertyName = "NullableGetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseStatus?), TypeInfoPropertyName = "NullableGetOrderResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseErrorVariant1Code?), TypeInfoPropertyName = "NullableGetOrderResponseErrorVariant1Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseErrorVariant2Code?), TypeInfoPropertyName = "NullableGetOrderResponseErrorVariant2Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseErrorVariant3Code?), TypeInfoPropertyName = "NullableGetOrderResponseErrorVariant3Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseErrorVariant4Code?), TypeInfoPropertyName = "NullableGetOrderResponseErrorVariant4Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseErrorVariant5Code?), TypeInfoPropertyName = "NullableGetOrderResponseErrorVariant5Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrderResponseErrorVariant6Code?), TypeInfoPropertyName = "NullableGetOrderResponseErrorVariant6Code2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.NotAuthorizedForScope, global::Vercel.Forbidden>?), TypeInfoPropertyName = "NullableAnyOfNotAuthorizedForScopeForbidden2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.Issue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.PropertyKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.BuyDomainsRequestDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetBulkPriceResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetBulkAvailabilityResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AnyOf<global::Vercel.SearchDomainsResponseResultVariant1, global::Vercel.SearchDomainsResponseResultVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AnyOf<global::Vercel.GetOrderResponseDomainVariant1, global::Vercel.GetOrderResponseDomainVariant2, global::Vercel.GetOrderResponseDomainVariant3>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetOrderResponseErrorVariant2DetailsTld>))]
    internal sealed partial class DomainsRegistrarSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DomainsRegistrarSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DomainsRegistrarSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DomainsRegistrarSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Vercel.JsonConverters.PropertyKeyJsonConverter());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, object, global::System.Collections.Generic.IList<object>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<object>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<object>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.TldNotSupported, global::Vercel.HttpApiDecodeError>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.TldNotSupported, global::Vercel.HttpApiDecodeError>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.BadRequest, global::Vercel.DomainTooShort, global::Vercel.TldNotSupported, global::Vercel.HttpApiDecodeError>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.BadRequest, global::Vercel.DomainTooShort, global::Vercel.TldNotSupported, global::Vercel.HttpApiDecodeError>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.SearchDomainsResponseResultVariant1, global::Vercel.SearchDomainsResponseResultVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.BadRequest, global::Vercel.HttpApiDecodeError>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.DomainNotRegistered, global::Vercel.HttpApiDecodeError>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.Forbidden, global::Vercel.NotAuthorizedForScope>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.DomainTooShort, global::Vercel.OrderTooExpensive, global::Vercel.InvalidAdditionalContactInfo, global::Vercel.AdditionalContactInfoRequired, global::Vercel.ExpectedPriceMismatch, global::Vercel.DomainNotAvailable, global::Vercel.EmojiTldNotSupported, global::Vercel.LanguageCodeRequired, global::Vercel.TldNotSupported, global::Vercel.HttpApiDecodeError>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.Forbidden, global::Vercel.NotAuthorizedForScope>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.DomainTooShort, global::Vercel.OrderTooExpensive, global::Vercel.TooManyDomains, global::Vercel.InvalidAdditionalContactInfo, global::Vercel.AdditionalContactInfoRequired, global::Vercel.DuplicateDomains, global::Vercel.ExpectedPriceMismatch, global::Vercel.DomainNotAvailable, global::Vercel.EmojiTldNotSupported, global::Vercel.LanguageCodeRequired, global::Vercel.TldNotSupported, global::Vercel.HttpApiDecodeError>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.Forbidden, global::Vercel.NotAuthorizedForScope>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.BadRequest, global::Vercel.DomainAlreadyOwned, global::Vercel.DomainTooShort, global::Vercel.DNSSECEnabled, global::Vercel.ExpectedPriceMismatch, global::Vercel.DomainNotAvailable, global::Vercel.TldNotSupported, global::Vercel.HttpApiDecodeError>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.Forbidden, global::Vercel.NotAuthorizedForScope>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.Forbidden, global::Vercel.NotAuthorizedForScope>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.BadRequest, global::Vercel.DomainTooShort, global::Vercel.DomainNotRegistered, global::Vercel.ExpectedPriceMismatch, global::Vercel.DomainNotAvailable, global::Vercel.TldNotSupported, global::Vercel.HttpApiDecodeError>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.Forbidden, global::Vercel.NotAuthorizedForScope>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.DomainAlreadyRenewing, global::Vercel.DomainNotRenewable, global::Vercel.DomainNotRegistered, global::Vercel.HttpApiDecodeError>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.Forbidden, global::Vercel.NotAuthorizedForScope>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.DomainNotRegistered, global::Vercel.HttpApiDecodeError>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.Forbidden, global::Vercel.NotAuthorizedForScope>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.ContactVerified, global::Vercel.ContactPendingVerification>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.BoughtTooRecently, global::Vercel.DomainNotRegistered, global::Vercel.HttpApiDecodeError>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.Forbidden, global::Vercel.NotAuthorizedForScope>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.GetOrderResponseDomainVariant1, global::Vercel.GetOrderResponseDomainVariant2, global::Vercel.GetOrderResponseDomainVariant3>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.AnyOf<global::Vercel.GetOrderResponseDomainVariant1ErrorVariant1, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant2, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant3, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant4, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant5, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant6, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant7, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant8, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant9, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10>?, global::Vercel.GetOrderResponseDomainVariant1Error>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.GetOrderResponseDomainVariant1ErrorVariant1, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant2, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant3, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant4, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant5, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant6, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant7, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant8, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant9, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.AnyOf<global::Vercel.GetOrderResponseDomainVariant2ErrorVariant1, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant2, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant3, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant4, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant5, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant6, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant7, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant8, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant9, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant10>?, global::Vercel.GetOrderResponseDomainVariant2Error>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.GetOrderResponseDomainVariant2ErrorVariant1, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant2, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant3, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant4, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant5, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant6, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant7, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant8, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant9, global::Vercel.GetOrderResponseDomainVariant2ErrorVariant10>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.AnyOf<global::Vercel.GetOrderResponseDomainVariant3ErrorVariant1, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant2, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant3, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant4, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant5, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant6, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant7, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant8, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant9, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant10>?, global::Vercel.GetOrderResponseDomainVariant3Error>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.GetOrderResponseDomainVariant3ErrorVariant1, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant2, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant3, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant4, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant5, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant6, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant7, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant8, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant9, global::Vercel.GetOrderResponseDomainVariant3ErrorVariant10>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.AnyOf<global::Vercel.GetOrderResponseErrorVariant1, global::Vercel.GetOrderResponseErrorVariant2, global::Vercel.GetOrderResponseErrorVariant3, global::Vercel.GetOrderResponseErrorVariant4, global::Vercel.GetOrderResponseErrorVariant5, global::Vercel.GetOrderResponseErrorVariant6>?, global::Vercel.GetOrderResponseError>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.GetOrderResponseErrorVariant1, global::Vercel.GetOrderResponseErrorVariant2, global::Vercel.GetOrderResponseErrorVariant3, global::Vercel.GetOrderResponseErrorVariant4, global::Vercel.GetOrderResponseErrorVariant5, global::Vercel.GetOrderResponseErrorVariant6>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.NotAuthorizedForScope, global::Vercel.Forbidden>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, object, global::System.Collections.Generic.IList<object>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, object, global::System.Collections.Generic.IList<object>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, object, global::System.Collections.Generic.IList<object>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Vercel.PropertyKeyVariant3Tag)

                    || typeToConvert == typeof(global::Vercel.PropertyKeyVariant3Tag?)

                    || typeToConvert == typeof(global::Vercel.TooManyRequestsCode)

                    || typeToConvert == typeof(global::Vercel.TooManyRequestsCode?)

                    || typeToConvert == typeof(global::Vercel.UnauthorizedCode)

                    || typeToConvert == typeof(global::Vercel.UnauthorizedCode?)

                    || typeToConvert == typeof(global::Vercel.NotAuthorizedForScopeCode)

                    || typeToConvert == typeof(global::Vercel.NotAuthorizedForScopeCode?)

                    || typeToConvert == typeof(global::Vercel.InternalServerErrorCode)

                    || typeToConvert == typeof(global::Vercel.InternalServerErrorCode?)

                    || typeToConvert == typeof(global::Vercel.TldNotSupportedCode)

                    || typeToConvert == typeof(global::Vercel.TldNotSupportedCode?)

                    || typeToConvert == typeof(global::Vercel.NotFoundCode)

                    || typeToConvert == typeof(global::Vercel.NotFoundCode?)

                    || typeToConvert == typeof(global::Vercel.DomainTooShortCode)

                    || typeToConvert == typeof(global::Vercel.DomainTooShortCode?)

                    || typeToConvert == typeof(global::Vercel.BadRequestCode)

                    || typeToConvert == typeof(global::Vercel.BadRequestCode?)

                    || typeToConvert == typeof(global::Vercel.DomainNotRegisteredCode)

                    || typeToConvert == typeof(global::Vercel.DomainNotRegisteredCode?)

                    || typeToConvert == typeof(global::Vercel.DomainNotFoundCode)

                    || typeToConvert == typeof(global::Vercel.DomainNotFoundCode?)

                    || typeToConvert == typeof(global::Vercel.DomainCannotBeTransferedOutUntilCode)

                    || typeToConvert == typeof(global::Vercel.DomainCannotBeTransferedOutUntilCode?)

                    || typeToConvert == typeof(global::Vercel.ForbiddenCode)

                    || typeToConvert == typeof(global::Vercel.ForbiddenCode?)

                    || typeToConvert == typeof(global::Vercel.LanguageCodeRequiredCode)

                    || typeToConvert == typeof(global::Vercel.LanguageCodeRequiredCode?)

                    || typeToConvert == typeof(global::Vercel.EmojiTldNotSupportedCode)

                    || typeToConvert == typeof(global::Vercel.EmojiTldNotSupportedCode?)

                    || typeToConvert == typeof(global::Vercel.DomainNotAvailableCode)

                    || typeToConvert == typeof(global::Vercel.DomainNotAvailableCode?)

                    || typeToConvert == typeof(global::Vercel.ExpectedPriceMismatchCode)

                    || typeToConvert == typeof(global::Vercel.ExpectedPriceMismatchCode?)

                    || typeToConvert == typeof(global::Vercel.AdditionalContactInfoRequiredCode)

                    || typeToConvert == typeof(global::Vercel.AdditionalContactInfoRequiredCode?)

                    || typeToConvert == typeof(global::Vercel.InvalidAdditionalContactInfoCode)

                    || typeToConvert == typeof(global::Vercel.InvalidAdditionalContactInfoCode?)

                    || typeToConvert == typeof(global::Vercel.OrderTooExpensiveCode)

                    || typeToConvert == typeof(global::Vercel.OrderTooExpensiveCode?)

                    || typeToConvert == typeof(global::Vercel.DuplicateDomainsCode)

                    || typeToConvert == typeof(global::Vercel.DuplicateDomainsCode?)

                    || typeToConvert == typeof(global::Vercel.TooManyDomainsCode)

                    || typeToConvert == typeof(global::Vercel.TooManyDomainsCode?)

                    || typeToConvert == typeof(global::Vercel.DNSSECEnabledCode)

                    || typeToConvert == typeof(global::Vercel.DNSSECEnabledCode?)

                    || typeToConvert == typeof(global::Vercel.DomainAlreadyOwnedCode)

                    || typeToConvert == typeof(global::Vercel.DomainAlreadyOwnedCode?)

                    || typeToConvert == typeof(global::Vercel.DomainNotRenewableCode)

                    || typeToConvert == typeof(global::Vercel.DomainNotRenewableCode?)

                    || typeToConvert == typeof(global::Vercel.DomainAlreadyRenewingCode)

                    || typeToConvert == typeof(global::Vercel.DomainAlreadyRenewingCode?)

                    || typeToConvert == typeof(global::Vercel.BoughtTooRecentlyCode)

                    || typeToConvert == typeof(global::Vercel.BoughtTooRecentlyCode?)

                    || typeToConvert == typeof(global::Vercel.BuySingleDomainResponseLinksMethod)

                    || typeToConvert == typeof(global::Vercel.BuySingleDomainResponseLinksMethod?)

                    || typeToConvert == typeof(global::Vercel.BuyDomainsResponseLinksMethod)

                    || typeToConvert == typeof(global::Vercel.BuyDomainsResponseLinksMethod?)

                    || typeToConvert == typeof(global::Vercel.TransferInDomainResponseLinksMethod)

                    || typeToConvert == typeof(global::Vercel.TransferInDomainResponseLinksMethod?)

                    || typeToConvert == typeof(global::Vercel.GetDomainTransferInResponseStatus)

                    || typeToConvert == typeof(global::Vercel.GetDomainTransferInResponseStatus?)

                    || typeToConvert == typeof(global::Vercel.RenewDomainResponseLinksMethod)

                    || typeToConvert == typeof(global::Vercel.RenewDomainResponseLinksMethod?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1PurchaseType)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1PurchaseType?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1Status)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1Status?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant1Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant1Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant2Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant2Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant3Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant3Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant4Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant4Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant5Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant5Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant6Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant6Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant7Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant7Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant8Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant8Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant9Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant9Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2PurchaseType)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2PurchaseType?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2Status)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2Status?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant1Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant1Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant2Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant2Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant3Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant3Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant4Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant4Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant5Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant5Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant6Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant6Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant7Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant7Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant8Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant8Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant9Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant9Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant10Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant10Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3PurchaseType)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3PurchaseType?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3Status)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3Status?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant1Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant1Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant2Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant2Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant3Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant3Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant4Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant4Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant5Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant5Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant6Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant6Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant7Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant7Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant8Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant8Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant9Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant9Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant10Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant10Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseStatus)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseStatus?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseErrorVariant1Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseErrorVariant1Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseErrorVariant2Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseErrorVariant2Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseErrorVariant3Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseErrorVariant3Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseErrorVariant4Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseErrorVariant4Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseErrorVariant5Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseErrorVariant5Code?)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseErrorVariant6Code)

                    || typeToConvert == typeof(global::Vercel.GetOrderResponseErrorVariant6Code?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vercel.PropertyKeyVariant3Tag))
                {
                    return new global::Vercel.JsonConverters.PropertyKeyVariant3TagJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.PropertyKeyVariant3Tag?))
                {
                    return new global::Vercel.JsonConverters.PropertyKeyVariant3TagNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.TooManyRequestsCode))
                {
                    return new global::Vercel.JsonConverters.TooManyRequestsCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.TooManyRequestsCode?))
                {
                    return new global::Vercel.JsonConverters.TooManyRequestsCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UnauthorizedCode))
                {
                    return new global::Vercel.JsonConverters.UnauthorizedCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UnauthorizedCode?))
                {
                    return new global::Vercel.JsonConverters.UnauthorizedCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.NotAuthorizedForScopeCode))
                {
                    return new global::Vercel.JsonConverters.NotAuthorizedForScopeCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.NotAuthorizedForScopeCode?))
                {
                    return new global::Vercel.JsonConverters.NotAuthorizedForScopeCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.InternalServerErrorCode))
                {
                    return new global::Vercel.JsonConverters.InternalServerErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.InternalServerErrorCode?))
                {
                    return new global::Vercel.JsonConverters.InternalServerErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.TldNotSupportedCode))
                {
                    return new global::Vercel.JsonConverters.TldNotSupportedCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.TldNotSupportedCode?))
                {
                    return new global::Vercel.JsonConverters.TldNotSupportedCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.NotFoundCode))
                {
                    return new global::Vercel.JsonConverters.NotFoundCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.NotFoundCode?))
                {
                    return new global::Vercel.JsonConverters.NotFoundCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.DomainTooShortCode))
                {
                    return new global::Vercel.JsonConverters.DomainTooShortCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.DomainTooShortCode?))
                {
                    return new global::Vercel.JsonConverters.DomainTooShortCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.BadRequestCode))
                {
                    return new global::Vercel.JsonConverters.BadRequestCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.BadRequestCode?))
                {
                    return new global::Vercel.JsonConverters.BadRequestCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.DomainNotRegisteredCode))
                {
                    return new global::Vercel.JsonConverters.DomainNotRegisteredCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.DomainNotRegisteredCode?))
                {
                    return new global::Vercel.JsonConverters.DomainNotRegisteredCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.DomainNotFoundCode))
                {
                    return new global::Vercel.JsonConverters.DomainNotFoundCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.DomainNotFoundCode?))
                {
                    return new global::Vercel.JsonConverters.DomainNotFoundCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.DomainCannotBeTransferedOutUntilCode))
                {
                    return new global::Vercel.JsonConverters.DomainCannotBeTransferedOutUntilCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.DomainCannotBeTransferedOutUntilCode?))
                {
                    return new global::Vercel.JsonConverters.DomainCannotBeTransferedOutUntilCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ForbiddenCode))
                {
                    return new global::Vercel.JsonConverters.ForbiddenCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ForbiddenCode?))
                {
                    return new global::Vercel.JsonConverters.ForbiddenCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.LanguageCodeRequiredCode))
                {
                    return new global::Vercel.JsonConverters.LanguageCodeRequiredCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.LanguageCodeRequiredCode?))
                {
                    return new global::Vercel.JsonConverters.LanguageCodeRequiredCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EmojiTldNotSupportedCode))
                {
                    return new global::Vercel.JsonConverters.EmojiTldNotSupportedCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.EmojiTldNotSupportedCode?))
                {
                    return new global::Vercel.JsonConverters.EmojiTldNotSupportedCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.DomainNotAvailableCode))
                {
                    return new global::Vercel.JsonConverters.DomainNotAvailableCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.DomainNotAvailableCode?))
                {
                    return new global::Vercel.JsonConverters.DomainNotAvailableCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ExpectedPriceMismatchCode))
                {
                    return new global::Vercel.JsonConverters.ExpectedPriceMismatchCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ExpectedPriceMismatchCode?))
                {
                    return new global::Vercel.JsonConverters.ExpectedPriceMismatchCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AdditionalContactInfoRequiredCode))
                {
                    return new global::Vercel.JsonConverters.AdditionalContactInfoRequiredCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AdditionalContactInfoRequiredCode?))
                {
                    return new global::Vercel.JsonConverters.AdditionalContactInfoRequiredCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.InvalidAdditionalContactInfoCode))
                {
                    return new global::Vercel.JsonConverters.InvalidAdditionalContactInfoCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.InvalidAdditionalContactInfoCode?))
                {
                    return new global::Vercel.JsonConverters.InvalidAdditionalContactInfoCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.OrderTooExpensiveCode))
                {
                    return new global::Vercel.JsonConverters.OrderTooExpensiveCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.OrderTooExpensiveCode?))
                {
                    return new global::Vercel.JsonConverters.OrderTooExpensiveCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.DuplicateDomainsCode))
                {
                    return new global::Vercel.JsonConverters.DuplicateDomainsCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.DuplicateDomainsCode?))
                {
                    return new global::Vercel.JsonConverters.DuplicateDomainsCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.TooManyDomainsCode))
                {
                    return new global::Vercel.JsonConverters.TooManyDomainsCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.TooManyDomainsCode?))
                {
                    return new global::Vercel.JsonConverters.TooManyDomainsCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.DNSSECEnabledCode))
                {
                    return new global::Vercel.JsonConverters.DNSSECEnabledCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.DNSSECEnabledCode?))
                {
                    return new global::Vercel.JsonConverters.DNSSECEnabledCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.DomainAlreadyOwnedCode))
                {
                    return new global::Vercel.JsonConverters.DomainAlreadyOwnedCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.DomainAlreadyOwnedCode?))
                {
                    return new global::Vercel.JsonConverters.DomainAlreadyOwnedCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.DomainNotRenewableCode))
                {
                    return new global::Vercel.JsonConverters.DomainNotRenewableCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.DomainNotRenewableCode?))
                {
                    return new global::Vercel.JsonConverters.DomainNotRenewableCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.DomainAlreadyRenewingCode))
                {
                    return new global::Vercel.JsonConverters.DomainAlreadyRenewingCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.DomainAlreadyRenewingCode?))
                {
                    return new global::Vercel.JsonConverters.DomainAlreadyRenewingCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.BoughtTooRecentlyCode))
                {
                    return new global::Vercel.JsonConverters.BoughtTooRecentlyCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.BoughtTooRecentlyCode?))
                {
                    return new global::Vercel.JsonConverters.BoughtTooRecentlyCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.BuySingleDomainResponseLinksMethod))
                {
                    return new global::Vercel.JsonConverters.BuySingleDomainResponseLinksMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.BuySingleDomainResponseLinksMethod?))
                {
                    return new global::Vercel.JsonConverters.BuySingleDomainResponseLinksMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.BuyDomainsResponseLinksMethod))
                {
                    return new global::Vercel.JsonConverters.BuyDomainsResponseLinksMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.BuyDomainsResponseLinksMethod?))
                {
                    return new global::Vercel.JsonConverters.BuyDomainsResponseLinksMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.TransferInDomainResponseLinksMethod))
                {
                    return new global::Vercel.JsonConverters.TransferInDomainResponseLinksMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.TransferInDomainResponseLinksMethod?))
                {
                    return new global::Vercel.JsonConverters.TransferInDomainResponseLinksMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetDomainTransferInResponseStatus))
                {
                    return new global::Vercel.JsonConverters.GetDomainTransferInResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetDomainTransferInResponseStatus?))
                {
                    return new global::Vercel.JsonConverters.GetDomainTransferInResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.RenewDomainResponseLinksMethod))
                {
                    return new global::Vercel.JsonConverters.RenewDomainResponseLinksMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.RenewDomainResponseLinksMethod?))
                {
                    return new global::Vercel.JsonConverters.RenewDomainResponseLinksMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1PurchaseType))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1PurchaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1PurchaseType?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1PurchaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1Status))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1StatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1Status?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1StatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant1Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1ErrorVariant1CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant1Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1ErrorVariant1CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant2Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1ErrorVariant2CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant2Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1ErrorVariant2CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant3Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1ErrorVariant3CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant3Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1ErrorVariant3CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant4Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1ErrorVariant4CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant4Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1ErrorVariant4CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant5Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1ErrorVariant5CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant5Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1ErrorVariant5CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant6Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1ErrorVariant6CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant6Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1ErrorVariant6CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant7Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1ErrorVariant7CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant7Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1ErrorVariant7CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant8Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1ErrorVariant8CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant8Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1ErrorVariant8CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant9Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1ErrorVariant9CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant9Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1ErrorVariant9CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1ErrorVariant10CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1ErrorVariant10CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2PurchaseType))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2PurchaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2PurchaseType?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2PurchaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2Status))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2StatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2Status?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2StatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant1Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2ErrorVariant1CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant1Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2ErrorVariant1CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant2Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2ErrorVariant2CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant2Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2ErrorVariant2CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant3Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2ErrorVariant3CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant3Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2ErrorVariant3CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant4Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2ErrorVariant4CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant4Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2ErrorVariant4CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant5Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2ErrorVariant5CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant5Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2ErrorVariant5CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant6Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2ErrorVariant6CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant6Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2ErrorVariant6CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant7Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2ErrorVariant7CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant7Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2ErrorVariant7CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant8Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2ErrorVariant8CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant8Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2ErrorVariant8CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant9Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2ErrorVariant9CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant9Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2ErrorVariant9CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant10Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2ErrorVariant10CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant10Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2ErrorVariant10CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3PurchaseType))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3PurchaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3PurchaseType?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3PurchaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3Status))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3StatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3Status?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3StatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant1Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3ErrorVariant1CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant1Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3ErrorVariant1CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant2Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3ErrorVariant2CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant2Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3ErrorVariant2CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant3Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3ErrorVariant3CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant3Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3ErrorVariant3CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant4Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3ErrorVariant4CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant4Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3ErrorVariant4CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant5Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3ErrorVariant5CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant5Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3ErrorVariant5CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant6Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3ErrorVariant6CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant6Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3ErrorVariant6CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant7Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3ErrorVariant7CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant7Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3ErrorVariant7CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant8Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3ErrorVariant8CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant8Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3ErrorVariant8CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant9Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3ErrorVariant9CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant9Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3ErrorVariant9CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant10Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3ErrorVariant10CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant10Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3ErrorVariant10CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseStatus))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseStatus?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseErrorVariant1Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseErrorVariant1CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseErrorVariant1Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseErrorVariant1CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseErrorVariant2Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseErrorVariant2CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseErrorVariant2Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseErrorVariant2CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseErrorVariant3Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseErrorVariant3CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseErrorVariant3Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseErrorVariant3CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseErrorVariant4Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseErrorVariant4CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseErrorVariant4Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseErrorVariant4CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseErrorVariant5Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseErrorVariant5CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseErrorVariant5Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseErrorVariant5CodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseErrorVariant6Code))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseErrorVariant6CodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrderResponseErrorVariant6Code?))
                {
                    return new global::Vercel.JsonConverters.GetOrderResponseErrorVariant6CodeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new DomainsRegistrarSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}