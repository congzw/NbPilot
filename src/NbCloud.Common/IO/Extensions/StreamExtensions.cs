using System.IO;

namespace NbCloud.Common.IO.Extensions
{
    /// <summary>
    /// StreamExtensions
    /// </summary>
    public static class StreamExtensions
    {
        /// <summary>
        /// 获取所有字节
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static byte[] GetAllBytes(this Stream stream)
        {
            using (var memoryStream = new MemoryStream())
            {
                stream.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }
        }
    }
}
