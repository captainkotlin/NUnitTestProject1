using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using NUnitTestProject1.tests.webui.heroku.pages.message;

namespace NUnitTestProject1.heroku.pages.message
{
    public abstract class AbstractMessage
    {
        public HashSet<String> messages { get; } = new HashSet<String>();

        public abstract ImmutableHashSet<string> getAllowedValues();

        public AbstractMessage(String msg)
        {
            messages.Add(msg);
        }

        public bool contains(String msg)
        {
            return messages.Contains(msg);
        }

        public void add(String msg)
        {
            if (getAllowedValues().Contains(msg))
            {
                messages.Add(msg);
            }
        }

        public static Type getMessageType(String message)
        {
            if (Message1.AllowedValues.Contains(message))
            {
                return typeof(Message1);
            }
            else if (Message2.AllowedValues.Contains(message))
            {
                return typeof(Message2);
            }
            else if (Message3.AllowedValues.Contains(message))
            {
                return typeof(Message3);
            }
            else
            {
                return null;
            }
        }
    }
}