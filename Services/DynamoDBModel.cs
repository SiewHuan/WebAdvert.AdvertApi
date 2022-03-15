﻿using AdvertApi.Models;
using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAdvert.AdvertApi.Services
{
    [DynamoDBTable("Adverts")]
    public class AdvertDbModel
    {
        [DynamoDBHashKey] public string Id { get; set; }

        [DynamoDBProperty] public string Title { get; set; }

        [DynamoDBProperty] public string Description { get; set; }

        [DynamoDBProperty] public double Price { get; set; }

        [DynamoDBProperty] public DateTime CreationDateTime { get; set; }

        [DynamoDBProperty] public AdvertStatus Status { get; set; }
    }
}