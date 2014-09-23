﻿using MangoPay.SDK.Core.Enumerations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace MangoPay.SDK.Entities.GET
{
    /// <summary>Event entity.</summary>
    public class EventDTO : EntityBase
    {
        /// <summary>Resource identifier.</summary>
        public String ResourceId { get; set; }

        /// <summary>Type of event.</summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public EventType EventType { get; set; }

        /// <summary>Date as UNIX timestamp.</summary>
        public long Date { get; set; }
    }
}