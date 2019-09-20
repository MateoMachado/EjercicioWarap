using System;
using WhatsAppApiUCU;
namespace Library
{
    public class WhatsApp : IMessageChannel
    {
            const string accountSid = "ACa8395e7223e7719988c09db8dfb68f0f";
            const string authToken = "fdcaac12dc7e5b031908429ee402e7a4";

        public void Send(Message message)
                {
                    var whatsApp = new WhatsAppApi(accountSid, authToken);
                    whatsApp.Send("+59899256116", message.Text);
                }
    }
}