using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using NUnitTestProject1.heroku.pages.message;

namespace NUnitTestProject1.tests.webui.heroku.pages.message
{
    public class Message1 : AbstractMessage
    {
        public static ImmutableHashSet<string> AllowedValues { get; } = ImmutableHashSet.Create( "try again", "success response");

        public Message1(String text) : base(text)
        {
            
        }
        public override ImmutableHashSet<string> getAllowedValues()
        {
            return AllowedValues;
        }
    }
}