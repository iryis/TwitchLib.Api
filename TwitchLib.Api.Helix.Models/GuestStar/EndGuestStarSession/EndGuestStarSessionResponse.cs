﻿using Newtonsoft.Json;

namespace TwitchLib.Api.Helix.Models.GuestStar.CreateGuestStarSession;

public class EndGuestStarSessionResponse
{
    /// <summary>
    /// <para>Summary of the session details when the session was ended.</para>
    /// </summary>
    [JsonProperty(PropertyName = "data")]
    public GuestStarSession[] Data { get; protected set; }
}