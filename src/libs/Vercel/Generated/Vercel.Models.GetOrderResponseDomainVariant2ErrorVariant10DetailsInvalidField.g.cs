
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField
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
    public static class GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField value)
        {
            return value switch
            {
                GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField.Address1 => "address1",
                GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField.Address2 => "address2",
                GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField.City => "city",
                GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField.CompanyName => "companyName",
                GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField.Country => "country",
                GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField.Email => "email",
                GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField.Fax => "fax",
                GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField.FirstName => "firstName",
                GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField.LastName => "lastName",
                GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField.Phone => "phone",
                GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField.State => "state",
                GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField.Zip => "zip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField? ToEnum(string value)
        {
            return value switch
            {
                "address1" => GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField.Address1,
                "address2" => GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField.Address2,
                "city" => GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField.City,
                "companyName" => GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField.CompanyName,
                "country" => GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField.Country,
                "email" => GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField.Email,
                "fax" => GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField.Fax,
                "firstName" => GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField.FirstName,
                "lastName" => GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField.LastName,
                "phone" => GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField.Phone,
                "state" => GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField.State,
                "zip" => GetOrderResponseDomainVariant2ErrorVariant10DetailsInvalidField.Zip,
                _ => null,
            };
        }
    }
}