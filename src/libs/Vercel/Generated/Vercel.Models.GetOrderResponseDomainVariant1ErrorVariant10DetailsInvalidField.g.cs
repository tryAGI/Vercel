
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField
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
    public static class GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField value)
        {
            return value switch
            {
                GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField.Address1 => "address1",
                GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField.Address2 => "address2",
                GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField.City => "city",
                GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField.CompanyName => "companyName",
                GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField.Country => "country",
                GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField.Email => "email",
                GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField.Fax => "fax",
                GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField.FirstName => "firstName",
                GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField.LastName => "lastName",
                GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField.Phone => "phone",
                GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField.State => "state",
                GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField.Zip => "zip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField? ToEnum(string value)
        {
            return value switch
            {
                "address1" => GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField.Address1,
                "address2" => GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField.Address2,
                "city" => GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField.City,
                "companyName" => GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField.CompanyName,
                "country" => GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField.Country,
                "email" => GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField.Email,
                "fax" => GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField.Fax,
                "firstName" => GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField.FirstName,
                "lastName" => GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField.LastName,
                "phone" => GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField.Phone,
                "state" => GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField.State,
                "zip" => GetOrderResponseDomainVariant1ErrorVariant10DetailsInvalidField.Zip,
                _ => null,
            };
        }
    }
}