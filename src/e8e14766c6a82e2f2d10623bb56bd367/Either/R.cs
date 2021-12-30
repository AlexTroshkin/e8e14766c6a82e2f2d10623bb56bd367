using Newtonsoft.Json;

using System.Collections.Generic;

namespace e8e14766c6a82e2f2d10623bb56bd367.Either
{
    public class R<T>
    {
        public List<E> Failures { get; private set; } = new List<E>();
        public T Value { get; private set; }
        public bool IsSuccess { get { return Failures.Count == 0; } }
        public bool IsFailure => !IsSuccess;

        /// <summary>
        /// Use only for de/serialization
        /// </summary>
        [JsonConstructor]
        public R(List<E> failures, T value)
        {
            Failures = failures;
            Value = value;
        }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private R()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
        }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private R(List<E> errors) => Failures = errors;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private R(E error) => Failures.Add(error);
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        private R(T value) => Value = value;

        public static implicit operator R<T>(E error) => new(error);
        public static implicit operator R<T>((string Id, string Description) error) => new(error);

        public static implicit operator R<T>(List<E> errors) => new(errors);
        public static implicit operator R<T>(List<(string Id, string Description)> errors) => new(errors.ConvertAll(e => (E)e));

        public static implicit operator R<T>(T value) => new(value);
    }
}
