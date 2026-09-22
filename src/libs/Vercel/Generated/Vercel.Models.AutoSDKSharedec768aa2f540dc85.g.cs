#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKSharedec768aa2f540dc85 : global::System.IEquatable<AutoSDKSharedec768aa2f540dc85>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared5f73cd821829ef28? Shared5f73cd821829ef28 { get; init; }
#else
        public global::Vercel.AutoSDKShared5f73cd821829ef28? Shared5f73cd821829ef28 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared5f73cd821829ef28))]
#endif
        public bool IsShared5f73cd821829ef28 => Shared5f73cd821829ef28 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared5f73cd821829ef28(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared5f73cd821829ef28? value)
        {
            value = Shared5f73cd821829ef28;
            return IsShared5f73cd821829ef28;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared5f73cd821829ef28 PickShared5f73cd821829ef28() => IsShared5f73cd821829ef28
            ? Shared5f73cd821829ef28!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared5f73cd821829ef28' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKSharedec768aa2f540dc85Variant2? AutoSDKSharedec768aa2f540dc85Variant2 { get; init; }
#else
        public global::Vercel.AutoSDKSharedec768aa2f540dc85Variant2? AutoSDKSharedec768aa2f540dc85Variant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoSDKSharedec768aa2f540dc85Variant2))]
#endif
        public bool IsAutoSDKSharedec768aa2f540dc85Variant2 => AutoSDKSharedec768aa2f540dc85Variant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutoSDKSharedec768aa2f540dc85Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKSharedec768aa2f540dc85Variant2? value)
        {
            value = AutoSDKSharedec768aa2f540dc85Variant2;
            return IsAutoSDKSharedec768aa2f540dc85Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKSharedec768aa2f540dc85Variant2 PickAutoSDKSharedec768aa2f540dc85Variant2() => IsAutoSDKSharedec768aa2f540dc85Variant2
            ? AutoSDKSharedec768aa2f540dc85Variant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoSDKSharedec768aa2f540dc85Variant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedec768aa2f540dc85(global::Vercel.AutoSDKShared5f73cd821829ef28 value) => new AutoSDKSharedec768aa2f540dc85((global::Vercel.AutoSDKShared5f73cd821829ef28?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared5f73cd821829ef28?(AutoSDKSharedec768aa2f540dc85 @this) => @this.Shared5f73cd821829ef28;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedec768aa2f540dc85(global::Vercel.AutoSDKShared5f73cd821829ef28? value)
        {
            Shared5f73cd821829ef28 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedec768aa2f540dc85 FromShared5f73cd821829ef28(global::Vercel.AutoSDKShared5f73cd821829ef28? value) => new AutoSDKSharedec768aa2f540dc85(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedec768aa2f540dc85(global::Vercel.AutoSDKSharedec768aa2f540dc85Variant2 value) => new AutoSDKSharedec768aa2f540dc85((global::Vercel.AutoSDKSharedec768aa2f540dc85Variant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKSharedec768aa2f540dc85Variant2?(AutoSDKSharedec768aa2f540dc85 @this) => @this.AutoSDKSharedec768aa2f540dc85Variant2;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedec768aa2f540dc85(global::Vercel.AutoSDKSharedec768aa2f540dc85Variant2? value)
        {
            AutoSDKSharedec768aa2f540dc85Variant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedec768aa2f540dc85 FromAutoSDKSharedec768aa2f540dc85Variant2(global::Vercel.AutoSDKSharedec768aa2f540dc85Variant2? value) => new AutoSDKSharedec768aa2f540dc85(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedec768aa2f540dc85(
            global::Vercel.AutoSDKShared5f73cd821829ef28? shared5f73cd821829ef28,
            global::Vercel.AutoSDKSharedec768aa2f540dc85Variant2? autoSDKSharedec768aa2f540dc85Variant2
            )
        {
            Shared5f73cd821829ef28 = shared5f73cd821829ef28;
            AutoSDKSharedec768aa2f540dc85Variant2 = autoSDKSharedec768aa2f540dc85Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AutoSDKSharedec768aa2f540dc85Variant2 as object ??
            Shared5f73cd821829ef28 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared5f73cd821829ef28?.ToString() ??
            AutoSDKSharedec768aa2f540dc85Variant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared5f73cd821829ef28 && !IsAutoSDKSharedec768aa2f540dc85Variant2 || !IsShared5f73cd821829ef28 && IsAutoSDKSharedec768aa2f540dc85Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared5f73cd821829ef28, TResult>? shared5f73cd821829ef28 = null,
            global::System.Func<global::Vercel.AutoSDKSharedec768aa2f540dc85Variant2, TResult>? autoSDKSharedec768aa2f540dc85Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared5f73cd821829ef28 && shared5f73cd821829ef28 != null)
            {
                return shared5f73cd821829ef28(Shared5f73cd821829ef28!);
            }
            else if (IsAutoSDKSharedec768aa2f540dc85Variant2 && autoSDKSharedec768aa2f540dc85Variant2 != null)
            {
                return autoSDKSharedec768aa2f540dc85Variant2(AutoSDKSharedec768aa2f540dc85Variant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared5f73cd821829ef28>? shared5f73cd821829ef28 = null,

            global::System.Action<global::Vercel.AutoSDKSharedec768aa2f540dc85Variant2>? autoSDKSharedec768aa2f540dc85Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared5f73cd821829ef28)
            {
                shared5f73cd821829ef28?.Invoke(Shared5f73cd821829ef28!);
            }
            else if (IsAutoSDKSharedec768aa2f540dc85Variant2)
            {
                autoSDKSharedec768aa2f540dc85Variant2?.Invoke(AutoSDKSharedec768aa2f540dc85Variant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared5f73cd821829ef28>? shared5f73cd821829ef28 = null,
            global::System.Action<global::Vercel.AutoSDKSharedec768aa2f540dc85Variant2>? autoSDKSharedec768aa2f540dc85Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared5f73cd821829ef28)
            {
                shared5f73cd821829ef28?.Invoke(Shared5f73cd821829ef28!);
            }
            else if (IsAutoSDKSharedec768aa2f540dc85Variant2)
            {
                autoSDKSharedec768aa2f540dc85Variant2?.Invoke(AutoSDKSharedec768aa2f540dc85Variant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared5f73cd821829ef28,
                typeof(global::Vercel.AutoSDKShared5f73cd821829ef28),
                AutoSDKSharedec768aa2f540dc85Variant2,
                typeof(global::Vercel.AutoSDKSharedec768aa2f540dc85Variant2),
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
        public bool Equals(AutoSDKSharedec768aa2f540dc85 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared5f73cd821829ef28?>.Default.Equals(Shared5f73cd821829ef28, other.Shared5f73cd821829ef28) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKSharedec768aa2f540dc85Variant2?>.Default.Equals(AutoSDKSharedec768aa2f540dc85Variant2, other.AutoSDKSharedec768aa2f540dc85Variant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKSharedec768aa2f540dc85 obj1, AutoSDKSharedec768aa2f540dc85 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKSharedec768aa2f540dc85>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKSharedec768aa2f540dc85 obj1, AutoSDKSharedec768aa2f540dc85 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKSharedec768aa2f540dc85 o && Equals(o);
        }
    }
}
