using System.Collections.Generic;
using System;
namespace Library
{
    public class Warap : IMessageChannel
    {
        public void Send(Message message)
        {
            const string accountSid = "ACa8395e7223e7719988c09db8dfb68f0f";
            const string authToken = "fdcaac12dc7e5b031908429ee402e7a4";

            var whatsApp = new WhatsAppApi(accountSid, authToken);
            string sid = whatsApp.Send(Numero, Mensaje);
            Console.WriteLine(sid);
        }
    }

}