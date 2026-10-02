#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared2eaeda81b490b803 : global::System.IEquatable<AutoSDKShared2eaeda81b490b803>
    {
        /// <summary>
        /// Check run backed by a project-level `check` definition.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared5455d199d07ea329? Shared5455d199d07ea329 { get; init; }
#else
        public global::Vercel.AutoSDKShared5455d199d07ea329? Shared5455d199d07ea329 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared5455d199d07ea329))]
#endif
        public bool IsShared5455d199d07ea329 => Shared5455d199d07ea329 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared5455d199d07ea329(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared5455d199d07ea329? value)
        {
            value = Shared5455d199d07ea329;
            return IsShared5455d199d07ea329;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared5455d199d07ea329 PickShared5455d199d07ea329() => Shared5455d199d07ea329 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared5455d199d07ea329' but the value was {ToString()}.");

        /// <summary>
        /// Vercel CI check run without a parent `check` (no `checkId` field).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKSharedca611ecff4bbfd16? Sharedca611ecff4bbfd16 { get; init; }
#else
        public global::Vercel.AutoSDKSharedca611ecff4bbfd16? Sharedca611ecff4bbfd16 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedca611ecff4bbfd16))]
#endif
        public bool IsSharedca611ecff4bbfd16 => Sharedca611ecff4bbfd16 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedca611ecff4bbfd16(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKSharedca611ecff4bbfd16? value)
        {
            value = Sharedca611ecff4bbfd16;
            return IsSharedca611ecff4bbfd16;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKSharedca611ecff4bbfd16 PickSharedca611ecff4bbfd16() => Sharedca611ecff4bbfd16 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedca611ecff4bbfd16' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared2eaeda81b490b803(global::Vercel.AutoSDKShared5455d199d07ea329 value) => new AutoSDKShared2eaeda81b490b803((global::Vercel.AutoSDKShared5455d199d07ea329?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared5455d199d07ea329?(AutoSDKShared2eaeda81b490b803 @this) => @this.Shared5455d199d07ea329;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared2eaeda81b490b803(global::Vercel.AutoSDKShared5455d199d07ea329? value)
        {
            Shared5455d199d07ea329 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared2eaeda81b490b803 FromShared5455d199d07ea329(global::Vercel.AutoSDKShared5455d199d07ea329? value) => new AutoSDKShared2eaeda81b490b803(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared2eaeda81b490b803(global::Vercel.AutoSDKSharedca611ecff4bbfd16 value) => new AutoSDKShared2eaeda81b490b803((global::Vercel.AutoSDKSharedca611ecff4bbfd16?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKSharedca611ecff4bbfd16?(AutoSDKShared2eaeda81b490b803 @this) => @this.Sharedca611ecff4bbfd16;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared2eaeda81b490b803(global::Vercel.AutoSDKSharedca611ecff4bbfd16? value)
        {
            Sharedca611ecff4bbfd16 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared2eaeda81b490b803 FromSharedca611ecff4bbfd16(global::Vercel.AutoSDKSharedca611ecff4bbfd16? value) => new AutoSDKShared2eaeda81b490b803(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared2eaeda81b490b803(
            global::Vercel.AutoSDKShared5455d199d07ea329? shared5455d199d07ea329,
            global::Vercel.AutoSDKSharedca611ecff4bbfd16? sharedca611ecff4bbfd16
            )
        {
            Shared5455d199d07ea329 = shared5455d199d07ea329;
            Sharedca611ecff4bbfd16 = sharedca611ecff4bbfd16;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Sharedca611ecff4bbfd16 as object ??
            Shared5455d199d07ea329 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared5455d199d07ea329?.ToString() ??
            Sharedca611ecff4bbfd16?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared5455d199d07ea329 && !IsSharedca611ecff4bbfd16 || !IsShared5455d199d07ea329 && IsSharedca611ecff4bbfd16;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared5455d199d07ea329, TResult>? shared5455d199d07ea329 = null,
            global::System.Func<global::Vercel.AutoSDKSharedca611ecff4bbfd16, TResult>? sharedca611ecff4bbfd16 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared5455d199d07ea329 is { } __value0 && shared5455d199d07ea329 != null)
            {
                return shared5455d199d07ea329(__value0);
            }
            else if (Sharedca611ecff4bbfd16 is { } __value1 && sharedca611ecff4bbfd16 != null)
            {
                return sharedca611ecff4bbfd16(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared5455d199d07ea329>? shared5455d199d07ea329 = null,

            global::System.Action<global::Vercel.AutoSDKSharedca611ecff4bbfd16>? sharedca611ecff4bbfd16 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared5455d199d07ea329 is { } __value0)
            {
                shared5455d199d07ea329?.Invoke(__value0);
            }
            else if (Sharedca611ecff4bbfd16 is { } __value1)
            {
                sharedca611ecff4bbfd16?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared5455d199d07ea329>? shared5455d199d07ea329 = null,
            global::System.Action<global::Vercel.AutoSDKSharedca611ecff4bbfd16>? sharedca611ecff4bbfd16 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared5455d199d07ea329 is { } __value0)
            {
                shared5455d199d07ea329?.Invoke(__value0);
            }
            else if (Sharedca611ecff4bbfd16 is { } __value1)
            {
                sharedca611ecff4bbfd16?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared5455d199d07ea329,
                typeof(global::Vercel.AutoSDKShared5455d199d07ea329),
                Sharedca611ecff4bbfd16,
                typeof(global::Vercel.AutoSDKSharedca611ecff4bbfd16),
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
        public bool Equals(AutoSDKShared2eaeda81b490b803 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared5455d199d07ea329?>.Default.Equals(Shared5455d199d07ea329, other.Shared5455d199d07ea329) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKSharedca611ecff4bbfd16?>.Default.Equals(Sharedca611ecff4bbfd16, other.Sharedca611ecff4bbfd16)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared2eaeda81b490b803 obj1, AutoSDKShared2eaeda81b490b803 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared2eaeda81b490b803>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared2eaeda81b490b803 obj1, AutoSDKShared2eaeda81b490b803 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared2eaeda81b490b803 o && Equals(o);
        }
    }
}
