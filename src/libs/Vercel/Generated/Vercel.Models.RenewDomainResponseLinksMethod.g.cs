
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RenewDomainResponseLinksMethod
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
    public static class RenewDomainResponseLinksMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RenewDomainResponseLinksMethod value)
        {
            return value switch
            {
                RenewDomainResponseLinksMethod.Delete => "DELETE",
                RenewDomainResponseLinksMethod.Get => "GET",
                RenewDomainResponseLinksMethod.Patch => "PATCH",
                RenewDomainResponseLinksMethod.Post => "POST",
                RenewDomainResponseLinksMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RenewDomainResponseLinksMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => RenewDomainResponseLinksMethod.Delete,
                "GET" => RenewDomainResponseLinksMethod.Get,
                "PATCH" => RenewDomainResponseLinksMethod.Patch,
                "POST" => RenewDomainResponseLinksMethod.Post,
                "PUT" => RenewDomainResponseLinksMethod.Put,
                _ => null,
            };
        }
    }
}