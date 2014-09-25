using System;
#if SILVERLIGHT
using System.Runtime.Serialization;
#endif

namespace Cometd.Client.Transport
{
    /// <version>  $Revision$ $Date: 2010-01-20 08:02:44 +0100 (Wed, 20 Jan 2010) $
    /// </version>
#if !SILVERLIGHT
    [Serializable]
#endif
#if SILVERLIGHT
    [DataContract]
#endif
    public class TransportException : SystemException
    {
        public TransportException()
        {
        }

        public TransportException(String message)
            : base(message)
        {
        }

        public TransportException(String message, Exception cause)
            : base(message, cause)
        {
        }

        /*public TransportException(Exception cause): base(cause)
        {
        }*/
    }
}