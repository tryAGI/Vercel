
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TransferInDomainResponseLinksMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Get,
        /// <summary>
        /// 
        /// </summary>
        Patch,
        /// <summary>
        /// 
        /// </summary>
        Post,
        /// <summary>
        /// 
        /// </summary>
        Put,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferInDomainResponseLinksMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferInDomainResponseLinksMethod value)
        {
            return value switch
            {
                TransferInDomainResponseLinksMethod.Delete => "DELETE",
                TransferInDomainResponseLinksMethod.Get => "GET",
                TransferInDomainResponseLinksMethod.Patch => "PATCH",
                TransferInDomainResponseLinksMethod.Post => "POST",
                TransferInDomainResponseLinksMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferInDomainResponseLinksMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => TransferInDomainResponseLinksMethod.Delete,
                "GET" => TransferInDomainResponseLinksMethod.Get,
                "PATCH" => TransferInDomainResponseLinksMethod.Patch,
                "POST" => TransferInDomainResponseLinksMethod.Post,
                "PUT" => TransferInDomainResponseLinksMethod.Put,
                _ => null,
            };
        }
    }
}