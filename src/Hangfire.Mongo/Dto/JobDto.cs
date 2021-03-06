﻿using Hangfire.Mongo.MongoUtils;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Hangfire.Mongo.Dto
{
	public class JobDto
	{
		[BsonId(IdGenerator = typeof(AutoIncrementIdGenerator))]
		public int Id { get; set; }

		public ObjectId StateId { get; set; }

		public string StateName { get; set; }

		public string InvocationData { get; set; }

		public string Arguments { get; set; }

		public DateTime CreatedAt { get; set; }

		public DateTime? ExpireAt { get; set; }
	}
}