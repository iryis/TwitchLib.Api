﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchLib.Api.Helix.Models.Entitlements.RedeemCode
{
    public class RedeemCodeResponse
    {
        [JsonProperty(PropertyName = "data")]
        public Status[] Data { get; protected set; }
    }
}
