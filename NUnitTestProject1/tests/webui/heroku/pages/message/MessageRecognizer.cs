using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using NUnitTestProject1.tests.webui.heroku.pages.message;

namespace NUnitTestProject1.heroku.pages.message
{
    public class MessageRecognizer
    {
        private static HashSet<Type> SupportedMessageTypes { get; } = new HashSet<Type>()
            { typeof(Message1), typeof(Message2), typeof(Message3) };

        public static Dictionary<Type, HashSet<AbstractMessage>> dict { get; } = new Dictionary<Type, HashSet<AbstractMessage>>();

        public MessageRecognizer()
        {
            foreach (var msgType in SupportedMessageTypes)
            {
                dict[msgType] = new HashSet<AbstractMessage>();
            }
        }

        public void addTextEntry(String textEntry)
        {
            var type = AbstractMessage.getMessageType(textEntry);
            if (type == null)
            {
                return;
            }
            HashSet<AbstractMessage> messages; 
            if (!dict.TryGetValue(type, out messages))
            {
                return;
            }
            AbstractMessage message;
            try
            {
                message = messages
                    .First(m => !m.contains(textEntry));
            }
            catch (Exception ex)
            {
                message = new Message1(textEntry);
                messages.Add(message);
                return;
            }
            message.add(textEntry);
        }

        public void validateMessages()
        {
            SupportedMessageTypes.Select(m => dict[m])
                .SelectMany(r => r)
                .ToList()
                .ForEach(abstractMessage =>
                {
                    if (!abstractMessage.getAllowedValues().Equals(abstractMessage.messages))
                    {
                        var className = abstractMessage.GetType().Name;
                        var failMessage = new StringBuilder("Message of type ")
                            .Append(className)
                            .Append(" contains values = ")
                            .Append(abstractMessage.messages)
                            .Append(" but should contains values = ")
                            .Append(abstractMessage.getAllowedValues())
                            .ToString();
                        throw new Exception(failMessage);
                    }
                });
        }
    }
}