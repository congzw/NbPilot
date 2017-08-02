//using System;
//using System.Runtime.Serialization;

//namespace NbCloud.Common
//{
//    /// <summary>
//    /// Base exception type for those are thrown by Abp system for Abp specific exceptions.
//    /// </summary>
//    [Serializable]
//    public class NbException : Exception
//    {
//        /// <summary>
//        /// Creates a new <see cref="NbException"/> object.
//        /// </summary>
//        public NbException()
//        {

//        }

//        /// <summary>
//        /// Creates a new <see cref="NbException"/> object.
//        /// </summary>
//        public NbException(SerializationInfo serializationInfo, StreamingContext context)
//            : base(serializationInfo, context)
//        {

//        }

//        /// <summary>
//        /// Creates a new <see cref="NbException"/> object.
//        /// </summary>
//        /// <param name="message">Exception message</param>
//        public NbException(string message)
//            : base(message)
//        {

//        }

//        /// <summary>
//        /// Creates a new <see cref="NbException"/> object.
//        /// </summary>
//        /// <param name="message">Exception message</param>
//        /// <param name="innerException">Inner exception</param>
//        public NbException(string message, Exception innerException)
//            : base(message, innerException)
//        {

//        }
//    }
//}
