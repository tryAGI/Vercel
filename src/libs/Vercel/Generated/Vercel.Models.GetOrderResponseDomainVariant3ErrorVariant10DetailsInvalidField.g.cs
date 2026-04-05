
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField
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
    public static class GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField value)
        {
            return value switch
            {
                GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField.Address1 => "address1",
                GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField.Address2 => "address2",
                GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField.City => "city",
                GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField.CompanyName => "companyName",
                GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField.Country => "country",
                GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField.Email => "email",
                GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField.Fax => "fax",
                GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField.FirstName => "firstName",
                GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField.LastName => "lastName",
                GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField.Phone => "phone",
                GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField.State => "state",
                GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField.Zip => "zip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField? ToEnum(string value)
        {
            return value switch
            {
                "address1" => GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField.Address1,
                "address2" => GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField.Address2,
                "city" => GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField.City,
                "companyName" => GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField.CompanyName,
                "country" => GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField.Country,
                "email" => GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField.Email,
                "fax" => GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField.Fax,
                "firstName" => GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField.FirstName,
                "lastName" => GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField.LastName,
                "phone" => GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField.Phone,
                "state" => GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField.State,
                "zip" => GetOrderResponseDomainVariant3ErrorVariant10DetailsInvalidField.Zip,
                _ => null,
            };
        }
    }
}