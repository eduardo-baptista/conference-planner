using System.Collections.Generic;
using GraphQL.Common;
using GraphQL.Data;

namespace GraphQL.Speakers
{
    public class SpeakerPayloadBase : Payload
    {
        public SpeakerPayloadBase(Speaker speaker)
        {
            Speaker = speaker;
        }

        public SpeakerPayloadBase(IReadOnlyList<UserError> errors) : base(errors)
        {
        }

        public Speaker? Speaker { get; }
    }
}