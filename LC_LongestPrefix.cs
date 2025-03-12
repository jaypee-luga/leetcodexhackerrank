string[] strs = {"flower","flow", "flight"};
var prefixes = new Dictionary<string, int>();

foreach(var str in strs)
{
	if(prefixes.ContainsKey(str[0].ToString()))
	{
		prefixes[str[0].ToString()]++;
	}
	else
	{
		prefixes.Add(str[0].ToString(), 1);
	}
}

prefixes.Dump();
