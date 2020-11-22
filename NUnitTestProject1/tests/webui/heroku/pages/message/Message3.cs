using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using NUnitTestProject1.heroku.pages.message;

namespace NUnitTestProject1.tests.webui.heroku.pages.message
{
    public class Message3 : AbstractMessage
    {
        public static ImmutableHashSet<string> AllowedValues { get; } = ImmutableHashSet.Create( "notification message", "request processed", "processing succeeded");

        public Message3(String text) : base(text)
        {
            
        }

        public override ImmutableHashSet<string> getAllowedValues()
        {
            return AllowedValues;
        }
    }
}