using System;
using System.Collections.Generic;
using System.Text;

namespace RiotApi.Model
{
    public class ParticipantIdentityDTO
    {
        public int ParticipantId { get; set; }
        public Dictionary<string, PlayerDTO> Player { get; set; }
    }
}
