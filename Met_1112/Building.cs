namespace Met_1112
{
	[BuildingInfo("Kak Tak", "MyOrg")]
    class Building
	{
		private int index;
		private double high;
		private int storeys;
		private int aparts;
		private int entrances;

		static int indexer = 0;

		public Building()
		{
			index = indexer++;
		}

        public Building(int index, double high, int storeys, int aparts, int entrances)
        {
            this.index = index;
            this.high = high;
            this.storeys = storeys;
            this.aparts = aparts;
            this.entrances = entrances;
        }
    }
}
