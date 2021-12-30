using e8e14766c6a82e2f2d10623bb56bd367.Tron.Messages;

using Newtonsoft.Json;

using System;

namespace e8e14766c6a82e2f2d10623bb56bd367.Tron
{
    public static class MessageConverter
    {
        /// <summary>
        /// Конвертирует указанное сообщение к формату API Tron Network
        /// </summary>
        /// <param name="message">Сообщение</param>
        /// <typeparam name="T">Любое Tron сообщение</typeparam>
        /// <returns>Конвертированное сообщение</returns>
        public static string ConvertToText<T>(T message) where T : ITronMessage
        {
            if (message is ITronQueryParamMessage)
            {
                //return new UrlEncodedFormFormatter(message.GetType()).Serialize(message);
                throw new NotImplementedException();
            }

            return JsonConvert.SerializeObject(message);
        }

        /// <summary>
        /// Конвертирует указанное сообщение API Tron Network к объектому представлению
        /// </summary>
        /// <param name="text">Сообщение API Tron Network</param>
        /// <typeparam name="T">Любое Tron сообщение</typeparam>
        /// <returns>Объектное представление сообщения</returns>
        public static T? ConvertToMessage<T>(string text) where T : ITronMessage
        {
            return JsonConvert.DeserializeObject<T?>(text);
        }
    }
}
