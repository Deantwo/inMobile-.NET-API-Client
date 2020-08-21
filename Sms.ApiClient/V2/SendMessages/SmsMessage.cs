using System;

namespace Sms.ApiClient.V2.SendMessages
{
    public class SmsMessage : ISmsMessage
    {
        /// <summary>
        /// Default empty constructor.
        /// </summary>
        public SmsMessage()
        {
        }
        /// <summary>
        /// Constructor with all required parameters.
        /// </summary>
        /// <param name="msisdn">The phone number to send to, including country code, e.g. 4512345678</param>
        /// <param name="text">The text message in the SMS.</param>
        /// <param name="senderName">The sendername, keep this between 3 and 11 chars.</param>
        /// <param name="encoding">The encoding to use.</param>
        public SmsMessage(string msisdn, string text, string senderName, SmsEncoding encoding)
        {
            MessageId = messageId ?? "";
            Msisdn = msisdn;
            Text = text;
            SenderName = senderName;
            Encoding = encoding;
        }
        /// <summary>
        /// Constructor with all required parameters, and optional parameters with a default value.
        /// </summary>
        /// <param name="msisdn">The phone number to send to, including country code, e.g. 4512345678</param>
        /// <param name="text">The text message in the SMS.</param>
        /// <param name="senderName">The sendername, keep this between 3 and 11 chars.</param>
        /// <param name="encoding">The encoding to use.</param>
        /// <param name="messageId">The message id used to identify the message.<br/>If NULL or empty string, a message id will be generated on the API server side and returned in the response.<br/>Optional.</param>
        /// <param name="sendTime">The time for the message to be sent. use NULL to send immediately.<br/>Optional.</param>
        /// <param name="flash">If true, message is a flash message. Optional.</param>
        /// <param name="expireTimeSpan">The amount of time the message is valid for. If the time passes before the message is sent, the message will not be sent.<br/>Optional.</param>
        /// <param name="respectBlacklist">Whether or not blacklisting should be respected when sending messages.<br/>Optional.</param>
        public SmsMessage(string msisdn, string text, string senderName, SmsEncoding encoding, string messageId = null, DateTime? sendTime = null, bool flash = false, TimeSpan? expireTimeSpan = null, bool? respectBlacklist = null)
        {
            MessageId = messageId ?? "";
            Msisdn = msisdn;
            Text = text;
            SenderName = senderName;
            Encoding = encoding;
            SendTime = sendTime;
            Flash = flash;
            ExpireIn = expireTimeSpan;
            RespectBlacklist = respectBlacklist;
        }

        /// <summary>
        /// The message id used to identify the message.<br/>
        /// If NULL or empty string, a message id will be generated on the API server side and returned in the response.
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// If true, message is a flash message
        /// </summary>
        public bool Flash { get; set; }

        /// <summary>
        /// The phone number to send to, including country code, e.g. 4512345678
        /// </summary>
        public string Msisdn { get; set; }

        /// <summary>
        /// The text message in the SMS
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The sendername, keep this between 3 and 11 chars.
        /// </summary>
        public string SenderName { get; set; }

        /// <summary>
        /// The encoding to use.
        /// </summary>
        public SmsEncoding Encoding { get; set; }

        /// <summary>
        /// If NULL, the message is not overcharged.
        /// </summary>
        public OverchargeInfo OverchargeInfo { get; set; }

        /// <summary>
        /// The time for the message to be sent. use NULL to send immediately.
        /// </summary>
        public DateTime? SendTime { get; set; }

        /// <summary>
        /// The amount of time the message is valid for. If the time passes before the message is sent, the message will not be sent.<br/>
        /// If null, validity period for the message, is not set.
        /// </summary>
        public TimeSpan? ExpireIn { get; set; }

        /// <summary>
        /// Whether or not blacklisting should be respected when sending messages.
        /// </summary>
        public bool? RespectBlacklist { get; set; }
    }
}
