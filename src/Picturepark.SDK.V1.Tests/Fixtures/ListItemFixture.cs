﻿using Picturepark.SDK.V1.Tests.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Picturepark.SDK.V1.Tests.Fixtures
{
	public class ListItemFixture : SDKClientFixture
	{
		public ListItemFixture() : base()
		{
			Setup().Wait();
		}

		public async Task Setup()
		{
			if (await Client.Schemas.ExistsAsync(nameof(Tag)) == false)
			{
				var schema = Client.Schemas.GenerateSchemaFromPOCO(typeof(Tag), new List<Contract.SchemaDetailViewItem> { });
				await Client.Schemas.CreateAsync(schema.First(), true);
			}
		}
	}
}
