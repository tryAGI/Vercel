
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField
    {
        /// <summary>
        ///
        /// </summary>
        Address1,
        /// <summary>
        ///
        /// </summary>
        Address2,
        /// <summary>
        ///
        /// </summary>
        City,
        /// <summary>
        ///
        /// </summary>
        CompanyName,
        /// <summary>
        ///
        /// </summary>
        Country,
        /// <summary>
        ///
        /// </summary>
        Email,
        /// <summary>
        ///
        /// </summary>
        Fax,
        /// <summary>
        ///
        /// </summary>
        FirstName,
        /// <summary>
        ///
        /// </summary>
        LastName,
        /// <summary>
        ///
        /// </summary>
        Phone,
        /// <summary>
        ///
        /// </summary>
        State,
        /// <summary>
        ///
        /// </summary>
        Zip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField value)
        {
            return value switch
            {
                AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField.Address1 => "address1",
                AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField.Address2 => "address2",
                AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField.City => "city",
                AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField.CompanyName => "companyName",
                AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField.Country => "country",
                AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField.Email => "email",
                AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField.Fax => "fax",
                AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField.FirstName => "firstName",
                AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField.LastName => "lastName",
                AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField.Phone => "phone",
                AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField.State => "state",
                AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField.Zip => "zip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField? ToEnum(string value)
        {
            return value switch
            {
                "address1" => AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField.Address1,
                "address2" => AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField.Address2,
                "city" => AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField.City,
                "companyName" => AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField.CompanyName,
                "country" => AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField.Country,
                "email" => AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField.Email,
                "fax" => AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField.Fax,
                "firstName" => AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField.FirstName,
                "lastName" => AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField.LastName,
                "phone" => AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField.Phone,
                "state" => AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField.State,
                "zip" => AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField.Zip,
                _ => null,
            };
        }
    }
}