﻿using System;
using Newtonsoft.Json;

namespace Bbva.Entities.Request
{
    [JsonObject(MemberSerialization.OptIn)]
    internal class RefundRequest : JsonObject
    {
        [JsonProperty(PropertyName = "description")]
        public String Description { set; get; }

		[JsonProperty(PropertyName = "amount")]
		public Decimal? Amount { set; get; }

	}
}
