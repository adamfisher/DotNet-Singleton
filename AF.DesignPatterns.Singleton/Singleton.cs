using System;
using System.Diagnostics;

namespace AF.DesignPatterns.Singleton
{
    /// <summary>
    /// Implements the singleton design pattern.
    /// A class inheriting from this class can be instantiated as a single instance.
    /// </summary>
    /// <typeparam name="T">Class type of the singleton instance.</typeparam>
    [DebuggerStepThrough]
    public abstract class Singleton<T> where T : new()
    {
        #region Fields

        /// <summary>
        /// Static instance. Needs to use lambda expression
        /// to construct an instance (since constructor is private).
        /// </summary>
        private static Lazy<T> _instance = new Lazy<T>(() => new T());

        #endregion

        #region Properties

        /// <summary>
        /// Gets the instance of this singleton.
        /// </summary>
        public static T Instance
        {
            get => _instance.Value;
            set
            {
                _instance = new Lazy<T>(() => value);
            }
        }

        #endregion
    }
}