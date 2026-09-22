#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared6dc2506c74cb750c : global::System.IEquatable<AutoSDKShared6dc2506c74cb750c>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKSharedc0ec89e0d0c59429? Sharedc0ec89e0d0c59429 { get; init; }
#else
        public global::Vercel.AutoSDKSharedc0ec89e0d0c59429? Sharedc0ec89e0d0c59429 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedc0ec89e0d0c59429))]
#endif
        public bool IsSharedc0ec89e0d0c59429 => Sharedc0ec89e0d0c59429 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedc0ec89e0d0c59429(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKSharedc0ec89e0d0c59429? value)
        {
            value = Sharedc0ec89e0d0c59429;
            return IsSharedc0ec89e0d0c59429;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKSharedc0ec89e0d0c59429 PickSharedc0ec89e0d0c59429() => IsSharedc0ec89e0d0c59429
            ? Sharedc0ec89e0d0c59429!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedc0ec89e0d0c59429' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKSharedf70b685b3a570894? Sharedf70b685b3a570894 { get; init; }
#else
        public global::Vercel.AutoSDKSharedf70b685b3a570894? Sharedf70b685b3a570894 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedf70b685b3a570894))]
#endif
        public bool IsSharedf70b685b3a570894 => Sharedf70b685b3a570894 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedf70b685b3a570894(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKSharedf70b685b3a570894? value)
        {
            value = Sharedf70b685b3a570894;
            return IsSharedf70b685b3a570894;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKSharedf70b685b3a570894 PickSharedf70b685b3a570894() => IsSharedf70b685b3a570894
            ? Sharedf70b685b3a570894!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedf70b685b3a570894' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared6dc2506c74cb750c(global::Vercel.AutoSDKSharedc0ec89e0d0c59429 value) => new AutoSDKShared6dc2506c74cb750c((global::Vercel.AutoSDKSharedc0ec89e0d0c59429?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKSharedc0ec89e0d0c59429?(AutoSDKShared6dc2506c74cb750c @this) => @this.Sharedc0ec89e0d0c59429;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared6dc2506c74cb750c(global::Vercel.AutoSDKSharedc0ec89e0d0c59429? value)
        {
            Sharedc0ec89e0d0c59429 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared6dc2506c74cb750c FromSharedc0ec89e0d0c59429(global::Vercel.AutoSDKSharedc0ec89e0d0c59429? value) => new AutoSDKShared6dc2506c74cb750c(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared6dc2506c74cb750c(global::Vercel.AutoSDKSharedf70b685b3a570894 value) => new AutoSDKShared6dc2506c74cb750c((global::Vercel.AutoSDKSharedf70b685b3a570894?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKSharedf70b685b3a570894?(AutoSDKShared6dc2506c74cb750c @this) => @this.Sharedf70b685b3a570894;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared6dc2506c74cb750c(global::Vercel.AutoSDKSharedf70b685b3a570894? value)
        {
            Sharedf70b685b3a570894 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared6dc2506c74cb750c FromSharedf70b685b3a570894(global::Vercel.AutoSDKSharedf70b685b3a570894? value) => new AutoSDKShared6dc2506c74cb750c(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared6dc2506c74cb750c(
            global::Vercel.AutoSDKSharedc0ec89e0d0c59429? sharedc0ec89e0d0c59429,
            global::Vercel.AutoSDKSharedf70b685b3a570894? sharedf70b685b3a570894
            )
        {
            Sharedc0ec89e0d0c59429 = sharedc0ec89e0d0c59429;
            Sharedf70b685b3a570894 = sharedf70b685b3a570894;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Sharedf70b685b3a570894 as object ??
            Sharedc0ec89e0d0c59429 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Sharedc0ec89e0d0c59429?.ToString() ??
            Sharedf70b685b3a570894?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSharedc0ec89e0d0c59429 && !IsSharedf70b685b3a570894 || !IsSharedc0ec89e0d0c59429 && IsSharedf70b685b3a570894;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKSharedc0ec89e0d0c59429, TResult>? sharedc0ec89e0d0c59429 = null,
            global::System.Func<global::Vercel.AutoSDKSharedf70b685b3a570894, TResult>? sharedf70b685b3a570894 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSharedc0ec89e0d0c59429 && sharedc0ec89e0d0c59429 != null)
            {
                return sharedc0ec89e0d0c59429(Sharedc0ec89e0d0c59429!);
            }
            else if (IsSharedf70b685b3a570894 && sharedf70b685b3a570894 != null)
            {
                return sharedf70b685b3a570894(Sharedf70b685b3a570894!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKSharedc0ec89e0d0c59429>? sharedc0ec89e0d0c59429 = null,

            global::System.Action<global::Vercel.AutoSDKSharedf70b685b3a570894>? sharedf70b685b3a570894 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSharedc0ec89e0d0c59429)
            {
                sharedc0ec89e0d0c59429?.Invoke(Sharedc0ec89e0d0c59429!);
            }
            else if (IsSharedf70b685b3a570894)
            {
                sharedf70b685b3a570894?.Invoke(Sharedf70b685b3a570894!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKSharedc0ec89e0d0c59429>? sharedc0ec89e0d0c59429 = null,
            global::System.Action<global::Vercel.AutoSDKSharedf70b685b3a570894>? sharedf70b685b3a570894 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSharedc0ec89e0d0c59429)
            {
                sharedc0ec89e0d0c59429?.Invoke(Sharedc0ec89e0d0c59429!);
            }
            else if (IsSharedf70b685b3a570894)
            {
                sharedf70b685b3a570894?.Invoke(Sharedf70b685b3a570894!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Sharedc0ec89e0d0c59429,
                typeof(global::Vercel.AutoSDKSharedc0ec89e0d0c59429),
                Sharedf70b685b3a570894,
                typeof(global::Vercel.AutoSDKSharedf70b685b3a570894),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AutoSDKShared6dc2506c74cb750c other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKSharedc0ec89e0d0c59429?>.Default.Equals(Sharedc0ec89e0d0c59429, other.Sharedc0ec89e0d0c59429) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKSharedf70b685b3a570894?>.Default.Equals(Sharedf70b685b3a570894, other.Sharedf70b685b3a570894)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared6dc2506c74cb750c obj1, AutoSDKShared6dc2506c74cb750c obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared6dc2506c74cb750c>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared6dc2506c74cb750c obj1, AutoSDKShared6dc2506c74cb750c obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared6dc2506c74cb750c o && Equals(o);
        }
    }
}
