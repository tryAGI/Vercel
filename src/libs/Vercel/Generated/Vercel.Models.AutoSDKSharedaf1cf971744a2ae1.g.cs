#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKSharedaf1cf971744a2ae1 : global::System.IEquatable<AutoSDKSharedaf1cf971744a2ae1>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared90103a1814ebf3a8? Shared90103a1814ebf3a8 { get; init; }
#else
        public global::Vercel.AutoSDKShared90103a1814ebf3a8? Shared90103a1814ebf3a8 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared90103a1814ebf3a8))]
#endif
        public bool IsShared90103a1814ebf3a8 => Shared90103a1814ebf3a8 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared90103a1814ebf3a8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared90103a1814ebf3a8? value)
        {
            value = Shared90103a1814ebf3a8;
            return IsShared90103a1814ebf3a8;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared90103a1814ebf3a8 PickShared90103a1814ebf3a8() => Shared90103a1814ebf3a8 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared90103a1814ebf3a8' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared9f8c0585e20078fc? Shared9f8c0585e20078fc { get; init; }
#else
        public global::Vercel.AutoSDKShared9f8c0585e20078fc? Shared9f8c0585e20078fc { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared9f8c0585e20078fc))]
#endif
        public bool IsShared9f8c0585e20078fc => Shared9f8c0585e20078fc != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared9f8c0585e20078fc(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared9f8c0585e20078fc? value)
        {
            value = Shared9f8c0585e20078fc;
            return IsShared9f8c0585e20078fc;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared9f8c0585e20078fc PickShared9f8c0585e20078fc() => Shared9f8c0585e20078fc is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared9f8c0585e20078fc' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedaf1cf971744a2ae1(global::Vercel.AutoSDKShared90103a1814ebf3a8 value) => new AutoSDKSharedaf1cf971744a2ae1((global::Vercel.AutoSDKShared90103a1814ebf3a8?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared90103a1814ebf3a8?(AutoSDKSharedaf1cf971744a2ae1 @this) => @this.Shared90103a1814ebf3a8;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedaf1cf971744a2ae1(global::Vercel.AutoSDKShared90103a1814ebf3a8? value)
        {
            Shared90103a1814ebf3a8 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedaf1cf971744a2ae1 FromShared90103a1814ebf3a8(global::Vercel.AutoSDKShared90103a1814ebf3a8? value) => new AutoSDKSharedaf1cf971744a2ae1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedaf1cf971744a2ae1(global::Vercel.AutoSDKShared9f8c0585e20078fc value) => new AutoSDKSharedaf1cf971744a2ae1((global::Vercel.AutoSDKShared9f8c0585e20078fc?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared9f8c0585e20078fc?(AutoSDKSharedaf1cf971744a2ae1 @this) => @this.Shared9f8c0585e20078fc;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedaf1cf971744a2ae1(global::Vercel.AutoSDKShared9f8c0585e20078fc? value)
        {
            Shared9f8c0585e20078fc = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedaf1cf971744a2ae1 FromShared9f8c0585e20078fc(global::Vercel.AutoSDKShared9f8c0585e20078fc? value) => new AutoSDKSharedaf1cf971744a2ae1(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedaf1cf971744a2ae1(
            global::Vercel.AutoSDKShared90103a1814ebf3a8? shared90103a1814ebf3a8,
            global::Vercel.AutoSDKShared9f8c0585e20078fc? shared9f8c0585e20078fc
            )
        {
            Shared90103a1814ebf3a8 = shared90103a1814ebf3a8;
            Shared9f8c0585e20078fc = shared9f8c0585e20078fc;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shared9f8c0585e20078fc as object ??
            Shared90103a1814ebf3a8 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared90103a1814ebf3a8?.ToString() ??
            Shared9f8c0585e20078fc?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared90103a1814ebf3a8 && !IsShared9f8c0585e20078fc || !IsShared90103a1814ebf3a8 && IsShared9f8c0585e20078fc;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared90103a1814ebf3a8, TResult>? shared90103a1814ebf3a8 = null,
            global::System.Func<global::Vercel.AutoSDKShared9f8c0585e20078fc, TResult>? shared9f8c0585e20078fc = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared90103a1814ebf3a8 is { } __value0 && shared90103a1814ebf3a8 != null)
            {
                return shared90103a1814ebf3a8(__value0);
            }
            else if (Shared9f8c0585e20078fc is { } __value1 && shared9f8c0585e20078fc != null)
            {
                return shared9f8c0585e20078fc(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared90103a1814ebf3a8>? shared90103a1814ebf3a8 = null,

            global::System.Action<global::Vercel.AutoSDKShared9f8c0585e20078fc>? shared9f8c0585e20078fc = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared90103a1814ebf3a8 is { } __value0)
            {
                shared90103a1814ebf3a8?.Invoke(__value0);
            }
            else if (Shared9f8c0585e20078fc is { } __value1)
            {
                shared9f8c0585e20078fc?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared90103a1814ebf3a8>? shared90103a1814ebf3a8 = null,
            global::System.Action<global::Vercel.AutoSDKShared9f8c0585e20078fc>? shared9f8c0585e20078fc = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared90103a1814ebf3a8 is { } __value0)
            {
                shared90103a1814ebf3a8?.Invoke(__value0);
            }
            else if (Shared9f8c0585e20078fc is { } __value1)
            {
                shared9f8c0585e20078fc?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared90103a1814ebf3a8,
                typeof(global::Vercel.AutoSDKShared90103a1814ebf3a8),
                Shared9f8c0585e20078fc,
                typeof(global::Vercel.AutoSDKShared9f8c0585e20078fc),
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
        public bool Equals(AutoSDKSharedaf1cf971744a2ae1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared90103a1814ebf3a8?>.Default.Equals(Shared90103a1814ebf3a8, other.Shared90103a1814ebf3a8) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared9f8c0585e20078fc?>.Default.Equals(Shared9f8c0585e20078fc, other.Shared9f8c0585e20078fc)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKSharedaf1cf971744a2ae1 obj1, AutoSDKSharedaf1cf971744a2ae1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKSharedaf1cf971744a2ae1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKSharedaf1cf971744a2ae1 obj1, AutoSDKSharedaf1cf971744a2ae1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKSharedaf1cf971744a2ae1 o && Equals(o);
        }
    }
}
