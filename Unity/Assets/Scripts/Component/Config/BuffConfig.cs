﻿namespace Model
{
	public class BuffConfig: AConfig
	{
		public string Name { get; set; }
		public int Time { get; set; }

		public BuffConfig()
		{
		}

		public BuffConfig(long id): base(id)
		{
		}
	}

	[Config(AppType.Client | AppType.Gate)]
	public class BuffCategory: ACategory<BuffConfig>
	{
	}
}