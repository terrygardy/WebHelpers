using Newtonsoft.Json;

namespace WebHelpers
{
	public static class JSON
	{
		public static string serialiseObject<T>(T pv_objJSON)
			where T : class
		{
			return JsonConvert.SerializeObject(pv_objJSON, Formatting.Indented, new JsonSerializerSettings() { DateFormatString = "dd.MM.yyyy" });
		}

		public static T deserialiseObject<T>(string pv_strJSON)
			where T : class
		{
			return JsonConvert.DeserializeObject<T>(pv_strJSON, new JsonSerializerSettings() { DateFormatString = "dd.MM.yyyy" });
		}
	}
}
